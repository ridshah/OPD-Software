Imports System.Data
Imports System.Data.SqlClient
Imports System.Text.RegularExpressions

Public Class employeemaster
    Dim con As New SqlConnection("Data Source=.\sqlexpress;Initial Catalog=opdsys;Integrated Security=True")
    Dim adp As New SqlDataAdapter("", con)
    Dim DS As New DataSet
    Dim bs As BindingManagerBase
    Dim a As New OpenFileDialog
    Dim str As String
    Dim picturelocation As String
    Dim flag1 As Integer
    Dim flag2 As Integer

    Private Sub employeemaster_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'OpdDataSet58.employee_master' table. You can move, or remove it, as needed.
        Me.Employee_masterTableAdapter1.Fill(Me.OpdDataSet58.employee_master)
        
        'TODO: This line of code loads data into the 'OpdDataSet27.department_master' table. You can move, or remove it, as needed.
        Me.Department_masterTableAdapter.Fill(Me.OpdDataSet27.department_master)
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        DS.Clear()
        adp.SelectCommand.CommandText = "SELECT * FROM employeemaster_view"
        adp.Fill(DS, "employeemaster_view")
        bs = Me.BindingContext(DS, "employeemaster_view")

        ' Me.KeyPreview = True
        clear()
        enablefalse()
        ComboBox1.Enabled = True
        AddNew.Text = "Add New"
        AddNew.Image = WindowsApplication1.My.Resources.Resources.addnew
        flag1 = 0
        Edit.Text = "Edit"
        Edit.Image = WindowsApplication1.My.Resources.Resources.edit
        flag2 = 0
    End Sub
    Sub enablefalse()
        ComboBox1.Enabled = False
        TextBox3.Enabled = False
        TextBox4.Enabled = False
        DateTimePicker1.Enabled = False
        DateTimePicker2.Enabled = False
        ComboBox2.Enabled = False
        TextBox6.Enabled = False
        TextBox7.Enabled = False
        TextBox8.Enabled = False
        TextBox9.Enabled = False
        TextBox10.Enabled = False
        TextBox11.Enabled = False
        TextBox12.Enabled = False
        TextBox13.Enabled = False
        ComboBox3.Enabled = False
       
    End Sub
    Sub enabletrue()
        ComboBox1.Enabled = True
        TextBox3.Enabled = True
        TextBox4.Enabled = True
        DateTimePicker1.Enabled = True
        DateTimePicker2.Enabled = True
        ComboBox2.Enabled = True
        TextBox6.Enabled = True
        TextBox7.Enabled = True
        TextBox8.Enabled = True
        TextBox9.Enabled = True
        TextBox10.Enabled = True
        TextBox11.Enabled = True
        TextBox12.Enabled = True
        TextBox13.Enabled = True
        ComboBox3.Enabled = True
        
    End Sub

    Sub data()

        ComboBox1.DataBindings.Clear()
        TextBox3.DataBindings.Clear()
        TextBox4.DataBindings.Clear()
        DateTimePicker1.DataBindings.Clear()
        DateTimePicker2.DataBindings.Clear()
        ComboBox2.DataBindings.Clear()
        TextBox6.DataBindings.Clear()
        TextBox7.DataBindings.Clear()
        TextBox8.DataBindings.Clear()
        TextBox9.DataBindings.Clear()
        TextBox10.DataBindings.Clear()
        TextBox11.DataBindings.Clear()
        TextBox12.DataBindings.Clear()
        TextBox13.DataBindings.Clear()
        ComboBox3.DataBindings.Clear()
        PictureBox1.DataBindings.Clear()

        adp.SelectCommand.CommandText = "SELECT * FROM employeemaster_view"
        adp.Fill(DS, "employeemaster_view")
        bs = Me.BindingContext(DS, "employeemaster_view")

       

        ComboBox1.DataBindings.Add("text", DS, "employeemaster_view.emp_name")
        TextBox3.DataBindings.Add("text", DS, "employeemaster_view.emp_password")
        TextBox4.DataBindings.Add("text", DS, "employeemaster_view.emp_type")
        DateTimePicker1.DataBindings.Add("text", DS, "employeemaster_view.emp_doj")
        DateTimePicker2.DataBindings.Add("text", DS, "employeemaster_view.emp_dob")

        TextBox6.DataBindings.Add("text", DS, "employeemaster_view.emp_address")
        TextBox7.DataBindings.Add("text", DS, "employeemaster_view.emp_city")
        TextBox8.DataBindings.Add("text", DS, "employeemaster_view.emp_state")
        TextBox9.DataBindings.Add("text", DS, "employeemaster_view.emp_country")
        TextBox10.DataBindings.Add("text", DS, "employeemaster_view.emp_pincode")
        TextBox11.DataBindings.Add("text", DS, "employeemaster_view.emp_email")
        TextBox12.DataBindings.Add("text", DS, "employeemaster_view.emp_mobile")
        TextBox13.DataBindings.Add("text", DS, "employeemaster_view.emp_landline")
        ComboBox3.DataBindings.Add("text", DS, "employeemaster_view.emp_status")
        PictureBox1.DataBindings.Add("imagelocation", DS, "employeemaster_view.emp_photo")
    End Sub
    Sub clear()
        ComboBox1.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        ComboBox2.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
        TextBox8.Text = ""
        TextBox9.Text = ""
        TextBox10.Text = ""
        TextBox11.Text = ""
        TextBox12.Text = ""
        TextBox13.Text = ""
        ComboBox3.Text = ""
        PictureBox1.ImageLocation = ""
    End Sub
    Sub validation()
        If Trim(ComboBox1.Text) = "" Then
            MsgBox("Please enter employee name")
        ElseIf Trim(ComboBox2.Text) = "" Then
            MsgBox("Please enter department name")
        ElseIf Trim(ComboBox3.Text) = "" Then
            MsgBox("Please enter status")
        ElseIf Trim(TextBox3.Text) = "" Then
            MsgBox("Please enter password")
        ElseIf Trim(TextBox4.Text) = "" Then
            MsgBox("Please enter employee type")
        ElseIf Trim(TextBox6.Text) = "" Then
            MsgBox("Please enter address")
        ElseIf Trim(TextBox7.Text) = "" Then
            MsgBox("Please enter city")
        ElseIf Trim(TextBox8.Text) = "" Then
            MsgBox("Please enter state")
        ElseIf Trim(TextBox9.Text) = "" Then
            MsgBox("Please enter country")
        ElseIf Trim(TextBox10.Text) = "" Then
            MsgBox("Please enter pincode")
        ElseIf Trim(TextBox11.Text) = "" Then
            MsgBox("Please enter email id")
        ElseIf Trim(TextBox12.Text) = "" Then
            MsgBox("Please enter mobile number")
        ElseIf Trim(TextBox13.Text) = "" Then
            MsgBox("Please enter landline number")
        End If
    End Sub
    
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles loadphoto.Click
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            PictureBox1.Image = Image.FromFile(OpenFileDialog1.FileName)
            picturelocation = OpenFileDialog1.FileName
        Else
            PictureBox1.BackgroundImage = Nothing
        End If
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles removephoto.Click
        PictureBox1.Image = Nothing
    End Sub

    

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Delete.Click
        If Trim(ComboBox1.Text) = "" Then
            MsgBox("Please enter employee name")
        Else
            Dim cmd As New SqlCommand()
            cmd.CommandText = "delete_employee_master"

            cmd.Parameters.Add("@emp_id", SqlDbType.VarChar).Value = Val(ComboBox1.SelectedValue)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = con
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If
            cmd.ExecuteNonQuery()
            MsgBox("Data Deleted")
        End If
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles first.Click
        bs.Position = 0
        data()

        enablefalse()
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles previous.Click
        bs.Position -= 1
        data()

        enablefalse()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles next1.Click
        bs.Position += 1
        data()

        enablefalse()
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles last.Click
        bs.Position = DS.Tables("employeemaster_view").Rows.Count - 1
        data()

        enablefalse()
    End Sub

   
    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Reset.Click

        clear()

        enabletrue()
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Edit.Click
        If flag2 = 0 Then
            Edit.Text = "Update"
            Edit.Image = WindowsApplication1.My.Resources.Resources.update1
            enabletrue()
            flag2 = "1"
        Else

            If Trim(TextBox4.Text) = "" Or Trim(TextBox6.Text) = "" Or Trim(TextBox7.Text) = "" Or Trim(TextBox8.Text) = "" Or Trim(TextBox9.Text) = "" Or Trim(TextBox10.Text) = "" Or Trim(TextBox11.Text) = "" Or Trim(TextBox12.Text) = "" Or Trim(TextBox13.Text) = "" Or Trim(ComboBox3.Text) = "" Or Trim(ComboBox2.Text) = "" Or Trim(ComboBox1.Text) = "" Or Trim(TextBox3.Text) = "" Then
                validation()
            ElseIf TextBox13.TextLength <> "8" Then
                MsgBox("Landline Number entered is wrong!!", MsgBoxStyle.Critical, "Verify")
            ElseIf TextBox12.TextLength <> "10" Then
                MsgBox("Mobile Number entered is wrong!!", MsgBoxStyle.Critical, "Verify")
            Else
                Dim cmd As New SqlCommand()
                cmd.CommandText = "update_employee_master"

                cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = ComboBox1.Text.ToString
                cmd.Parameters.Add("@password", SqlDbType.VarChar).Value = TextBox3.Text.ToString
                cmd.Parameters.Add("@type", SqlDbType.VarChar).Value = TextBox4.Text.ToString
                cmd.Parameters.Add("@doj", SqlDbType.VarChar).Value = DateTimePicker1.Text.ToString()
                cmd.Parameters.Add("@dob", SqlDbType.VarChar).Value = DateTimePicker2.Text.ToString()
                cmd.Parameters.Add("@dep_id", SqlDbType.VarChar).Value = Val(ComboBox2.SelectedValue)
                cmd.Parameters.Add("@address", SqlDbType.VarChar).Value = TextBox6.Text.ToString
                cmd.Parameters.Add("@city", SqlDbType.VarChar).Value = TextBox7.Text.ToString
                cmd.Parameters.Add("@state", SqlDbType.VarChar).Value = TextBox8.Text.ToString
                cmd.Parameters.Add("@country", SqlDbType.VarChar).Value = TextBox9.Text.ToString
                cmd.Parameters.Add("@pincode", SqlDbType.VarChar).Value = Val(TextBox10.Text)
                cmd.Parameters.Add("@email", SqlDbType.VarChar).Value = TextBox11.Text.ToString
                cmd.Parameters.Add("@landline", SqlDbType.VarChar).Value = Val(TextBox13.Text)
                cmd.Parameters.Add("@mobile", SqlDbType.VarChar).Value = TextBox12.Text.ToString
                cmd.Parameters.Add("@status", SqlDbType.VarChar).Value = ComboBox3.Text.ToString
                cmd.Parameters.Add("@photo", SqlDbType.VarChar).Value = picturelocation.ToString
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
        TextBox4.DataBindings.Clear()
        DateTimePicker1.DataBindings.Clear()
        DateTimePicker2.DataBindings.Clear()
        ComboBox2.DataBindings.Clear()
        TextBox6.DataBindings.Clear()
        TextBox7.DataBindings.Clear()
        TextBox8.DataBindings.Clear()
        TextBox9.DataBindings.Clear()
        TextBox10.DataBindings.Clear()
        TextBox11.DataBindings.Clear()
        TextBox12.DataBindings.Clear()
        TextBox13.DataBindings.Clear()
        ComboBox3.DataBindings.Clear()
        PictureBox1.DataBindings.Clear()

        DS.Clear()

        If ComboBox1.Text <> "" Then
            adp.SelectCommand.CommandText = "SELECT * FROM employeemaster_view where emp_name='" + ComboBox1.Text + "'"
            adp.Fill(DS, "employeemaster_view")
            bs = Me.BindingContext(DS, "employeemaster_view")



            ComboBox1.DataBindings.Add("text", DS, "employeemaster_view.emp_name")
            TextBox3.DataBindings.Add("text", DS, "employeemaster_view.emp_password")
            TextBox4.DataBindings.Add("text", DS, "employeemaster_view.emp_type")
            DateTimePicker1.DataBindings.Add("text", DS, "employeemaster_view.emp_doj")
            DateTimePicker2.DataBindings.Add("text", DS, "employeemaster_view.emp_dob")

            TextBox6.DataBindings.Add("text", DS, "employeemaster_view.emp_address")
            TextBox7.DataBindings.Add("text", DS, "employeemaster_view.emp_city")
            TextBox8.DataBindings.Add("text", DS, "employeemaster_view.emp_state")
            TextBox9.DataBindings.Add("text", DS, "employeemaster_view.emp_country")
            TextBox10.DataBindings.Add("text", DS, "employeemaster_view.emp_pincode")
            TextBox11.DataBindings.Add("text", DS, "employeemaster_view.emp_email")
            TextBox12.DataBindings.Add("text", DS, "employeemaster_view.emp_mobile")
            TextBox13.DataBindings.Add("text", DS, "employeemaster_view.emp_landline")
            ComboBox3.DataBindings.Add("text", DS, "employeemaster_view.emp_status")
            PictureBox1.DataBindings.Add("imagelocation", DS, "employeemaster_view.emp_photo")
        Else
            MsgBox("Select employee name")
        End If
        enablefalse()
        ComboBox1.Enabled = True
       
    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddNew.Click
        If flag1 = 0 Then
            AddNew.Text = "Submit"
            AddNew.Image = WindowsApplication1.My.Resources.Resources.submit
            clear()
            enabletrue()
            flag1 = "1"
        Else
            Dim cmd As New SqlCommand()
            If Trim(TextBox4.Text) = "" Or Trim(TextBox6.Text) = "" Or Trim(TextBox7.Text) = "" Or Trim(TextBox8.Text) = "" Or Trim(TextBox9.Text) = "" Or Trim(TextBox10.Text) = "" Or Trim(TextBox11.Text) = "" Or Trim(TextBox12.Text) = "" Or Trim(TextBox13.Text) = "" Or Trim(ComboBox3.Text) = "" Or Trim(ComboBox2.Text) = "" Or Trim(ComboBox1.Text) = "" Or Trim(TextBox3.Text) = "" Then
                validation()
            ElseIf TextBox13.TextLength <> "8" Then
                MsgBox("Landline Number entered is wrong!!", MsgBoxStyle.Critical, "Verify")
            ElseIf TextBox12.TextLength <> "10" Then
                MsgBox("Mobile Number entered is wrong!!", MsgBoxStyle.Critical, "Verify")
            Else

                If Trim(PictureBox1.ImageLocation) <> "" Then
                    a.Filter = ("Image files|*.jpg")
                    picturelocation = a.FileName
                End If
                cmd.CommandText = "submit_employee_master"

                cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = ComboBox1.Text.ToString
                cmd.Parameters.Add("@password", SqlDbType.VarChar).Value = TextBox3.Text.ToString
                cmd.Parameters.Add("@type", SqlDbType.VarChar).Value = TextBox4.Text.ToString
                cmd.Parameters.Add("@doj", SqlDbType.VarChar).Value = DateTimePicker1.Text.ToString()
                cmd.Parameters.Add("@dob", SqlDbType.VarChar).Value = DateTimePicker2.Text.ToString()
                cmd.Parameters.Add("@dep_id", SqlDbType.VarChar).Value = Val(ComboBox2.SelectedValue)
                cmd.Parameters.Add("@address", SqlDbType.VarChar).Value = TextBox6.Text.ToString
                cmd.Parameters.Add("@city", SqlDbType.VarChar).Value = TextBox7.Text.ToString
                cmd.Parameters.Add("@state", SqlDbType.VarChar).Value = TextBox8.Text.ToString
                cmd.Parameters.Add("@country", SqlDbType.VarChar).Value = TextBox9.Text.ToString
                cmd.Parameters.Add("@pincode", SqlDbType.VarChar).Value = Val(TextBox10.Text)
                cmd.Parameters.Add("@email", SqlDbType.VarChar).Value = TextBox11.Text.ToString
                cmd.Parameters.Add("@landline", SqlDbType.VarChar).Value = Val(TextBox13.Text)
                cmd.Parameters.Add("@mobile", SqlDbType.VarChar).Value = TextBox12.Text.ToString
                cmd.Parameters.Add("@status", SqlDbType.VarChar).Value = ComboBox3.Text.ToString
                cmd.Parameters.Add("@photo", SqlDbType.VarChar).Value = picturelocation.ToString

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

    Private Sub TextBox11_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox11.LostFocus
        Dim regExPattern As String = "^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"
        Dim emailAddressMatch As Match = Regex.Match(TextBox11.Text, regExPattern)
        If emailAddressMatch.Success Then

        Else
            MsgBox("Please enter correct email address", MsgBoxStyle.Information, "Verify")
        End If

    End Sub

    Private Sub TextBox10_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox10.KeyPress
        If (Char.IsControl(e.KeyChar) = False) Then
            If (Char.IsDigit(e.KeyChar)) Then

            Else
                e.Handled = True
                MsgBox("Sorry Only Digits Allowed!!", _
                       MsgBoxStyle.Information, "Verify")
            End If
        End If
    End Sub

    Private Sub TextBox12_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox12.KeyPress
        If (Char.IsControl(e.KeyChar) = False) Then
            If (Char.IsDigit(e.KeyChar)) Then

            Else
                e.Handled = True
                MsgBox("Sorry Only Digits Allowed!!", _
                       MsgBoxStyle.Information, "Verify")
            End If
        End If
    End Sub

    Private Sub TextBox13_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox13.KeyPress
        If (Char.IsControl(e.KeyChar) = False) Then
            If (Char.IsDigit(e.KeyChar)) Then

            Else
                e.Handled = True
                MsgBox("Sorry Only Digits Allowed!!", _
                       MsgBoxStyle.Information, "Verify")
            End If
        End If
    End Sub

   
    
   
   
End Class