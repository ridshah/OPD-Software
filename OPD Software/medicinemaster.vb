Imports System.Data
Imports System.Data.SqlClient

Public Class medicinemaster
    Dim con As New SqlConnection("Data Source=.\sqlexpress;Initial Catalog=opdsys;Integrated Security=True")
    Dim adp As New SqlDataAdapter("", con)
    Dim DS As New DataSet
    Dim bs As BindingManagerBase
    Dim flag1 As Integer
    Dim flag2 As Integer

    Private Sub medicinemaster_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'OpdDataSet23.medicine_master' table. You can move, or remove it, as needed.
        Me.Medicine_masterTableAdapter.Fill(Me.OpdDataSet23.medicine_master)
        'TODO: This line of code loads data into the 'OpdDataSet17.medicinebrand_master' table. You can move, or remove it, as needed.
        Me.Medicinebrand_masterTableAdapter.Fill(Me.OpdDataSet17.medicinebrand_master)
        'TODO: This line of code loads data into the 'OpdDataSet16.subcategory_master' table. You can move, or remove it, as needed.
        Me.Subcategory_masterTableAdapter.Fill(Me.OpdDataSet16.subcategory_master)
        'TODO: This line of code loads data into the 'OpdDataSet15.category_master' table. You can move, or remove it, as needed.
        Me.Category_masterTableAdapter.Fill(Me.OpdDataSet15.category_master)
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        DS.Clear()
        adp.SelectCommand.CommandText = "Select * from medicinemaster_view"
        adp.Fill(DS, "medicinemaster_view")
        bs = Me.BindingContext(DS, "medicinemaster_view")
       
        clear()
        ComboBox4.Enabled = True
        TextBox3.Enabled = False
        ComboBox1.Enabled = False
        ComboBox2.Enabled = False
        ComboBox3.Enabled = False
        AddNew.Text = "Add New"
        AddNew.Image = WindowsApplication1.My.Resources.Resources.addnew
        flag1 = 0
        Edit.Text = "Edit"
        Edit.Image = WindowsApplication1.My.Resources.Resources.edit
        flag2 = 0
    End Sub
    Sub data()
        
        TextBox3.DataBindings.Clear()
        ComboBox1.DataBindings.Clear()
        ComboBox2.DataBindings.Clear()
        ComboBox3.DataBindings.Clear()
        ComboBox4.DataBindings.Clear()

        adp.SelectCommand.CommandText = "Select * from medicinemaster_view"
        adp.Fill(DS, "medicinemaster_view")
        bs = Me.BindingContext(DS, "medicinemaster_view")

        TextBox3.DataBindings.Add("text", DS, "medicinemaster_view.medicine_description")
        ComboBox1.DataBindings.Add("text", DS, "medicinemaster_view.category_name")
        ComboBox2.DataBindings.Add("text", DS, "medicinemaster_view.subcategory_name")
        ComboBox3.DataBindings.Add("text", DS, "medicinemaster_view.brand_name")
        ComboBox4.DataBindings.Add("text", DS, "medicinemaster_view.medicine_name")
    End Sub
    Sub clear()
        ComboBox4.Text = ""
        TextBox3.Text = ""
        ComboBox1.Text = ""
        ComboBox2.Text = ""
        ComboBox3.Text = ""
    End Sub
   
    Sub validation()
        If Trim(ComboBox1.Text) = "" Then
            MsgBox("Please enter category name")
        ElseIf Trim(ComboBox2.Text) = "" Then
            MsgBox("Please enter subcategory name")
        ElseIf Trim(TextBox3.Text) = "" Then
            MsgBox("Please enter description")
        ElseIf Trim(ComboBox3.Text) = "" Then
            MsgBox("Please enter brand name")
        ElseIf Trim(ComboBox4.Text) = "" Then
            MsgBox("Please enter medicine name")
        End If
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Delete.Click
        Dim cmd As New SqlCommand()
        If Trim(ComboBox4.Text) = "" Then
            MsgBox("Please enter medicine name")
        Else
            cmd.CommandText = "delete_medicine_master"


            cmd.Parameters.Add("@mid", SqlDbType.VarChar).Value = Val(ComboBox4.SelectedValue)

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
        ComboBox4.Enabled = False
        TextBox3.Enabled = False
        ComboBox1.Enabled = False
        ComboBox2.Enabled = False
        ComboBox3.Enabled = False
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles previous.Click
        bs.Position -= 1
        data()
        ComboBox4.Enabled = False
        TextBox3.Enabled = False
        ComboBox1.Enabled = False
        ComboBox2.Enabled = False
        ComboBox3.Enabled = False
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles s.Click
        bs.Position += 1
        data()
        ComboBox4.Enabled = False
        TextBox3.Enabled = False
        ComboBox1.Enabled = False
        ComboBox2.Enabled = False
        ComboBox3.Enabled = False
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles last.Click
        bs.Position = DS.Tables("medicinemaster_view").Rows.Count - 1
        data()
        ComboBox4.Enabled = False
        TextBox3.Enabled = False
        ComboBox1.Enabled = False
        ComboBox2.Enabled = False
        ComboBox3.Enabled = False
    End Sub

   
    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Reset.Click
        clear()

        ComboBox4.Enabled = True
        TextBox3.Enabled = True
        ComboBox1.Enabled = True
        ComboBox2.Enabled = True
        ComboBox3.Enabled = True
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Edit.Click
        If flag2 = 0 Then
            Edit.Text = "Update"
            Edit.Image = WindowsApplication1.My.Resources.Resources.update1
            ComboBox4.Enabled = True
            TextBox3.Enabled = True
            ComboBox1.Enabled = True
            ComboBox2.Enabled = True
            ComboBox3.Enabled = True
            flag2 = "1"
        Else
            If Trim(ComboBox2.Text) = "" Or Trim(ComboBox1.Text) = "" Or Trim(TextBox3.Text) = "" Or Trim(ComboBox3.Text) = "" Or Trim(ComboBox4.Text) = "" Then
                validation()
            Else
                Dim cmd As New SqlCommand()
                cmd.CommandText = "update_medicine_master"

                cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = ComboBox4.Text.ToString
                cmd.Parameters.Add("@description", SqlDbType.VarChar).Value = TextBox3.Text.ToString
                cmd.Parameters.Add("@cid", SqlDbType.VarChar).Value = Val(ComboBox1.SelectedValue)
                cmd.Parameters.Add("@sid", SqlDbType.VarChar).Value = Val(ComboBox2.SelectedValue)
                cmd.Parameters.Add("@bid", SqlDbType.VarChar).Value = Val(ComboBox3.SelectedValue)
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

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles View.Click
        TextBox3.DataBindings.Clear()
        ComboBox1.DataBindings.Clear()
        ComboBox2.DataBindings.Clear()
        ComboBox3.DataBindings.Clear()
        ComboBox4.DataBindings.Clear()
        DS.Clear()

        If ComboBox4.Text <> "" Then
            adp.SelectCommand.CommandText = "Select * from medicinemaster_view where medicine_name='" + ComboBox4.Text + "'"
            adp.Fill(DS, "medicinemaster_view")
            bs = Me.BindingContext(DS, "medicinemaster_view")

            TextBox3.DataBindings.Add("text", DS, "medicinemaster_view.medicine_description")
            ComboBox1.DataBindings.Add("text", DS, "medicinemaster_view.category_name")
            ComboBox2.DataBindings.Add("text", DS, "medicinemaster_view.subcategory_name")
            ComboBox3.DataBindings.Add("text", DS, "medicinemaster_view.brand_name")
            ComboBox4.DataBindings.Add("text", DS, "medicinemaster_view.medicine_name")
        Else
            MsgBox("Select medicine name")
        End If

        ComboBox4.Enabled = True
        TextBox3.Enabled = False
        ComboBox1.Enabled = False
        ComboBox2.Enabled = False
        ComboBox3.Enabled = False
    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddNew.Click
        If flag1 = 0 Then
            AddNew.Text = "Submit"
            AddNew.Image = WindowsApplication1.My.Resources.Resources.submit
            clear()
            ComboBox4.Enabled = True
            TextBox3.Enabled = True
            ComboBox1.Enabled = True
            ComboBox2.Enabled = True
            ComboBox3.Enabled = True
            flag1 = "1"
        Else

            If Trim(ComboBox2.Text) = "" Or Trim(ComboBox1.Text) = "" Or Trim(TextBox3.Text) = "" Or Trim(ComboBox3.Text) = "" Or Trim(ComboBox4.Text) = "" Then
                validation()
            Else
                Dim cmd As New SqlCommand()
                cmd.CommandText = "submit_medicine_master"
                cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = ComboBox4.Text.ToString
                cmd.Parameters.Add("@description", SqlDbType.VarChar).Value = TextBox3.Text.ToString
                cmd.Parameters.Add("@cid", SqlDbType.VarChar).Value = Val(ComboBox1.SelectedValue)
                cmd.Parameters.Add("@sid", SqlDbType.VarChar).Value = Val(ComboBox2.SelectedValue)
                cmd.Parameters.Add("@bid", SqlDbType.VarChar).Value = Val(ComboBox3.SelectedValue)
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