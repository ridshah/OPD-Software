Imports System.Data
Imports System.Data.SqlClient
Public Class employeerights
    Dim con As New SqlConnection("Data Source=.\sqlexpress;Initial Catalog=opdsys;Integrated Security=True")
    Dim adp As New SqlDataAdapter("", con)
    Dim DS As New DataSet
    Dim bs As BindingManagerBase
    Dim flag1 As Integer
    Dim flag2 As Integer
    Private Sub employeerights_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'OpdDataSet57.employee_master' table. You can move, or remove it, as needed.
        Me.Employee_masterTableAdapter1.Fill(Me.OpdDataSet57.employee_master)
        'TODO: This line of code loads data into the 'OpdDataSet31.employee_rights' table. You can move, or remove it, as needed.
        Me.Employee_rightsTableAdapter.Fill(Me.OpdDataSet31.employee_rights)
       
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        DS.Clear()
        'adp.SelectCommand.CommandText = "Select emp_name as Employee_Name,tablename as TableName from employeerights_view"
        adp.SelectCommand.CommandText = "Select * from employeerights_view"
        adp.Fill(DS, "employeerights_view")
        bs = Me.BindingContext(DS, "employeerights_view")

        DataGridView1.DataSource = Nothing
        DataGridView1.DataSource = DS
        DataGridView1.DataMember = "employeerights_view"



        clear()
        ComboBox1.Enabled = True
        TextBox3.Enabled = False
        AddNew.Text = "Add New"
        AddNew.Image = WindowsApplication1.My.Resources.Resources.addnew
        flag1 = 0
        Edit.Text = "Edit"
        Edit.Image = WindowsApplication1.My.Resources.Resources.edit
        flag2 = 0
    End Sub
    Sub data()

        ComboBox1.DataBindings.Clear()
        TextBox3.DataBindings.Clear()

        'adp.SelectCommand.CommandText = "Select emp_name as Employee_Name,tablename as TableName from employeerights_view"
        adp.SelectCommand.CommandText = "Select * from employeerights_view"
        adp.Fill(DS, "employeerights_view")
        bs = Me.BindingContext(DS, "employeerights_view")

        ComboBox1.DataBindings.Add("text", DS, "employeerights_view.emp_name")
        TextBox3.DataBindings.Add("text", DS, "employeerights_view.tablename")

    End Sub
    Sub clear()
        ComboBox1.Text = ""
        TextBox3.Text = ""
    End Sub
    Sub validation()
        If Trim(ComboBox1.Text) = "" Then
            MsgBox("Please enter employee name")
        ElseIf Trim(TextBox3.Text) = "" Then
            MsgBox("Please enter table name")
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Delete.Click
        If Trim(ComboBox1.Text) = "" Then
            MsgBox("Please enter employee name")
        Else
            Dim cmd As New SqlCommand()
            cmd.CommandText = "delete_employee_rights"

            cmd.Parameters.Add("@eid", SqlDbType.VarChar).Value = Val(ComboBox1.SelectedValue)


            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = con
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If
            cmd.ExecuteNonQuery()
            MsgBox("Data Deleted")
        End If
    End Sub

   

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles first.Click

        bs.Position = 0
        DS.Clear()
        data()

        ComboBox1.Enabled = False
        TextBox3.Enabled = False

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles previous.Click

        bs.Position -= 1
        DS.Clear()
        data()
        ComboBox1.Enabled = False
        TextBox3.Enabled = False

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles next1.Click


        bs.Position += 1
        DS.Clear()
        data()
        ComboBox1.Enabled = False
        TextBox3.Enabled = False

    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles last.Click

        bs.Position = DS.Tables("employeerights_view").Rows.Count - 1
        DS.Clear()
        data()

        ComboBox1.Enabled = False
        TextBox3.Enabled = False

    End Sub

   
    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Reset.Click

        clear()

        ComboBox1.Enabled = True
        TextBox3.Enabled = True
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Edit.Click
        If flag2 = 0 Then
            Edit.Text = "Update"
            Edit.Image = WindowsApplication1.My.Resources.Resources.update1
            ComboBox1.Enabled = False
            TextBox3.Enabled = True
            flag2 = "1"
        Else

            If Trim(ComboBox1.Text) = "" Or Trim(TextBox3.Text) = "" Then
                validation()
            Else
                Dim cmd As New SqlCommand()
                cmd.CommandText = "update_employee_rights"

                cmd.Parameters.Add("@eid", SqlDbType.VarChar).Value = Val(ComboBox1.SelectedValue)
                cmd.Parameters.Add("@tablename", SqlDbType.VarChar).Value = TextBox3.Text.ToString

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
        ComboBox1.DataBindings.Clear()
        TextBox3.DataBindings.Clear()
        DS.Clear()

        If ComboBox1.Text <> "" Then
            'adp.SelectCommand.CommandText = "Select emp_name as Employee_Name,tablename as TableName from employeerights_view"
            adp.SelectCommand.CommandText = "Select * from employeerights_view where emp_name='" + ComboBox1.Text + "'"
            adp.Fill(DS, "employeerights_view")
            bs = Me.BindingContext(DS, "employeerights_view")

            ComboBox1.DataBindings.Add("text", DS, "employeerights_view.emp_name")
            TextBox3.DataBindings.Add("text", DS, "employeerights_view.tablename")
        Else
            MsgBox("Select employee name")
        End If

        ComboBox1.Enabled = True
        TextBox3.Enabled = False
    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddNew.Click
        If flag1 = 0 Then
            AddNew.Text = "Submit"
            AddNew.Image = WindowsApplication1.My.Resources.Resources.submit
            ComboBox1.Enabled = True
            TextBox3.Enabled = True
            flag1 = "1"
        Else

            If Trim(ComboBox1.Text) = "" Or Trim(TextBox3.Text) = "" Then
                validation()
            Else
                Dim cmd As New SqlCommand()
                cmd.CommandText = "submit_employee_rights"

                cmd.Parameters.Add("@eid", SqlDbType.VarChar).Value = Val(ComboBox1.SelectedValue)
                cmd.Parameters.Add("@tablename", SqlDbType.VarChar).Value = TextBox3.Text.ToString

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