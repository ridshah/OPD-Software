﻿Imports System.Data
Imports System.Data.SqlClient

Public Class categorymaster

    Dim con As New SqlConnection("Data Source=.\sqlexpress;Initial Catalog=opdsys;Integrated Security=True")
    Dim adp As New SqlDataAdapter("", con)
    Dim DS As New DataSet
    Dim bs As BindingManagerBase
    Dim flag1 As Integer
    Dim flag2 As Integer

    Private Sub categorymaster_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'OpdDataSet10.category_master' table. You can move, or remove it, as needed.
        Me.Category_masterTableAdapter.Fill(Me.OpdDataSet10.category_master)
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        DS.Clear()
        adp.SelectCommand.CommandText = "Select * from category_master"
        adp.Fill(DS, "category_master")
        bs = Me.BindingContext(DS, "category_master")

        clear()
        ComboBox1.Enabled = True
        TextBox3.Enabled = False
        ComboBox2.Enabled = False
        AddNew.Text = "Add New"
        AddNew.Image = WindowsApplication1.My.Resources.Resources.addnew
        Edit.Text = "Edit"
        Edit.Image = WindowsApplication1.My.Resources.Resources.edit
        flag1 = 0
        flag2 = 0
    End Sub
    Sub data()
        ComboBox1.DataBindings.Clear()
        TextBox3.DataBindings.Clear()
        ComboBox2.DataBindings.Clear()

        DS.Clear()

        adp.SelectCommand.CommandText = "Select * from category_master"
        adp.Fill(DS, "category_master")
        bs = Me.BindingContext(DS, "category_master")

        ComboBox1.DataBindings.Add("text", DS, "category_master.category_name")
        TextBox3.DataBindings.Add("text", DS, "category_master.category_description")
        ComboBox2.DataBindings.Add("text", DS, "category_master.category_status")
    End Sub
    Sub clear()
        ComboBox1.Text = ""
        TextBox3.Text = ""
        ComboBox2.Text = ""
    End Sub
    Sub validation()
        If Trim(ComboBox1.Text) = "" Then
            MsgBox("Please enter category name")
        ElseIf Trim(ComboBox2.Text) = "" Then
            MsgBox("Please enter status")
        ElseIf Trim(TextBox3.Text) = "" Then
            MsgBox("Please enter description")
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Delete.Click
        If Trim(ComboBox1.Text) = "" Then
            MsgBox("Please enter category name")
        Else
            Dim cmd As New SqlCommand()
            cmd.CommandText = "delete_category_master"
            cmd.Parameters.Add("@id", SqlDbType.VarChar).Value = Val(ComboBox1.SelectedValue)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = con
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If
            cmd.ExecuteNonQuery()
            MsgBox("Data Deleted")
        End If
    End Sub


    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles first.Click
        bs.Position = 0
        data()

        ComboBox1.Enabled = False
        TextBox3.Enabled = False
        ComboBox2.Enabled = False
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles previous.Click
        bs.Position -= 1
        data()

        ComboBox1.Enabled = False
        TextBox3.Enabled = False
        ComboBox2.Enabled = False
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles next1.Click
        bs.Position += 1
        data()

        ComboBox1.Enabled = False
        TextBox3.Enabled = False
        ComboBox2.Enabled = False
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles last.Click
        bs.Position = DS.Tables("category_master").Rows.Count - 1
        data()

        ComboBox1.Enabled = False
        TextBox3.Enabled = False
        ComboBox2.Enabled = False
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Reset.Click

        clear()

        ComboBox1.Enabled = True
        TextBox3.Enabled = True
        ComboBox2.Enabled = True
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Edit.Click
        If flag2 = 0 Then
            Edit.Text = "Update"
            Edit.Image = WindowsApplication1.My.Resources.Resources.update1
            ComboBox1.Enabled = True
            TextBox3.Enabled = True
            ComboBox2.Enabled = True
            flag2 = "1"
        Else
            If Trim(ComboBox2.Text) = "" Or Trim(ComboBox1.Text) = "" Or Trim(TextBox3.Text) = "" Then
                validation()
            Else
                
                Dim cmd As New SqlCommand()
                cmd.CommandText = "update_category_master"
                cmd.Parameters.Add("@id", SqlDbType.VarChar).Value = Val(ComboBox1.SelectedValue)
                cmd.Parameters.Add("@description", SqlDbType.VarChar).Value = TextBox3.Text.ToString()
                cmd.Parameters.Add("@status", SqlDbType.VarChar).Value = ComboBox2.Text.ToString()
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Connection = con
                If con.State = ConnectionState.Closed Then
                    con.Open()
                End If
                cmd.ExecuteNonQuery()
                MsgBox("Data Updated")
                Edit.Text = "Edit"
                Edit.Image = WindowsApplication1.My.Resources.Resources.edit
                flag2 = "0"
            End If
        End If
    End Sub
   

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles View.Click
        ComboBox1.DataBindings.Clear()
        TextBox3.DataBindings.Clear()
        ComboBox2.DataBindings.Clear()

        DS.Clear()

        If ComboBox1.Text <> "" Then
            adp.SelectCommand.CommandText = "Select * from category_master where category_name='" + ComboBox1.Text + "'"
            adp.Fill(DS, "category_master")
            bs = Me.BindingContext(DS, "category_master")

            ComboBox1.DataBindings.Add("text", DS, "category_master.category_name")
            TextBox3.DataBindings.Add("text", DS, "category_master.category_description")
            ComboBox2.DataBindings.Add("text", DS, "category_master.category_status")
        Else
            MsgBox("Select category name")
        End If

        ComboBox1.Enabled = True
        TextBox3.Enabled = False
        ComboBox2.Enabled = False

    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddNew.Click
        If flag1 = 0 Then
            AddNew.Text = "Submit"
            AddNew.Image = WindowsApplication1.My.Resources.Resources.submit
            clear()
            ComboBox1.Enabled = True
            TextBox3.Enabled = True
            ComboBox2.Enabled = True
            flag1 = "1"
        Else

            If Trim(ComboBox2.Text) = "" Or Trim(ComboBox1.Text) = "" Or Trim(TextBox3.Text) = "" Then
                validation()
            Else
                Dim cmd As New SqlCommand()
                cmd.CommandText = "submit_category_master"

                cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = ComboBox1.Text.ToString
                cmd.Parameters.Add("@description", SqlDbType.VarChar).Value = TextBox3.Text.ToString
                cmd.Parameters.Add("@status", SqlDbType.VarChar).Value = ComboBox2.Text.ToString
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Connection = con
                If con.State = ConnectionState.Closed Then
                    con.Open()
                End If
                cmd.ExecuteNonQuery()
                MsgBox("Data Added")
                AddNew.Text = "Add New"
                AddNew.Image = WindowsApplication1.My.Resources.Resources.addnew
                flag1 = "0"
            End If
        End If
    End Sub


End Class