Imports System.Data
Imports System.Data.SqlClient
Imports System.Text.RegularExpressions

Public Class companymaster
    Dim con As New SqlConnection("Data Source=.\sqlexpress;Initial Catalog=opdsys;Integrated Security=True")
    Dim a As New OpenFileDialog
    Dim str As String
    Dim picturelocation As String
    Dim adp As New SqlDataAdapter("", con)
    Dim DS As New DataSet
    Dim bs As BindingManagerBase
    Dim flag1 As Integer
    Dim flag2 As Integer

    Private Sub companymaster_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'OpdDataSet11.company_master' table. You can move, or remove it, as needed.
        Me.Company_masterTableAdapter.Fill(Me.OpdDataSet11.company_master)
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        DS.Clear()
        enablefalse()
        adp.SelectCommand.CommandText = "Select * from company_master"
        adp.Fill(DS, "company_master")
        bs = Me.BindingContext(DS, "company_master")
        'Me.KeyPreview = True
        clear()
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
        TextBox5.Enabled = False
        TextBox6.Enabled = False
        TextBox7.Enabled = False
        TextBox8.Enabled = False
        TextBox9.Enabled = False
        TextBox10.Enabled = False
        ComboBox2.Enabled = False
       
    End Sub
    Sub enabletrue()
        ComboBox1.Enabled = True
        TextBox3.Enabled = True
        TextBox4.Enabled = True
        TextBox5.Enabled = True
        TextBox6.Enabled = True
        TextBox7.Enabled = True
        TextBox8.Enabled = True
        TextBox9.Enabled = True
        TextBox10.Enabled = True
        ComboBox2.Enabled = True
       
    End Sub
    Sub data()
        ComboBox1.DataBindings.Clear()
        TextBox3.DataBindings.Clear()
        TextBox4.DataBindings.Clear()
        TextBox5.DataBindings.Clear()
        TextBox6.DataBindings.Clear()
        TextBox7.DataBindings.Clear()
        TextBox8.DataBindings.Clear()
        TextBox9.DataBindings.Clear()
        TextBox10.DataBindings.Clear()
        ComboBox2.DataBindings.Clear()
        PictureBox1.DataBindings.Clear()

        adp.SelectCommand.CommandText = "Select * from company_master"
        adp.Fill(DS, "company_master")
        bs = Me.BindingContext(DS, "company_master")

        ComboBox1.DataBindings.Add("text", DS, "company_master.cmp_name")
        TextBox3.DataBindings.Add("text", DS, "company_master.cmp_address")
        TextBox4.DataBindings.Add("text", DS, "company_master.cmp_city")
        TextBox5.DataBindings.Add("text", DS, "company_master.cmp_state")
        TextBox6.DataBindings.Add("text", DS, "company_master.cmp_country")
        TextBox7.DataBindings.Add("text", DS, "company_master.cmp_pincode")
        TextBox8.DataBindings.Add("text", DS, "company_master.cmp_email")
        TextBox9.DataBindings.Add("text", DS, "company_master.cmp_reception")
        TextBox10.DataBindings.Add("text", DS, "company_master.cmp_fax")
        ComboBox2.DataBindings.Add("text", DS, "company_master.cmp_status")
        PictureBox1.DataBindings.Add("imagelocation", DS, "company_master.cmp_photo")
    End Sub
    Sub clear()
        ComboBox1.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
        TextBox8.Text = ""
        TextBox9.Text = ""
        TextBox10.Text = ""
        ComboBox2.Text = ""
        PictureBox1.ImageLocation = ""
    End Sub

    Sub validation()
        If Trim(ComboBox1.Text) = "" Then
            MsgBox("Please enter company name")
        ElseIf Trim(TextBox3.Text) = "" Then
            MsgBox("Please enter address")
        ElseIf Trim(TextBox4.Text) = "" Then
            MsgBox("Please enter city")
        ElseIf Trim(TextBox5.Text) = "" Then
            MsgBox("Please enter state")
        ElseIf Trim(TextBox6.Text) = "" Then
            MsgBox("Please enter country")
        ElseIf Trim(TextBox7.Text) = "" Then
            MsgBox("Please enter pincode")
        ElseIf Trim(TextBox8.Text) = "" Then
            MsgBox("Please enter email")
        ElseIf Trim(TextBox9.Text) = "" Then
            MsgBox("Please enter reception desk number")
        ElseIf Trim(TextBox10.Text) = "" Then
            MsgBox("Please enter fax number ")
        ElseIf Trim(ComboBox2.Text) = "" Then
            MsgBox("Please enter status")
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Delete.Click
        Dim cmd As New SqlCommand()
        cmd.CommandText = "delete_company_master"
        If Trim(ComboBox1.Text) = "" Then
            MsgBox("Please enter company name")
        Else
            cmd.Parameters.Add("@id", SqlDbType.VarChar).Value = Val(ComboBox1.SelectedValue)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = con
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If
            cmd.ExecuteNonQuery()
            MsgBox("Data deleted")

        End If
    End Sub



    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LoadPhoto.Click
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            PictureBox1.Image = Image.FromFile(OpenFileDialog1.FileName)
            picturelocation = OpenFileDialog1.FileName
        Else
            PictureBox1.BackgroundImage = Nothing
        End If
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RemovePhoto.Click
        PictureBox1.Image = Nothing
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Edit.Click
       
        If flag2 = 0 Then
            Edit.Text = "Update"
            Edit.Image = WindowsApplication1.My.Resources.Resources.update1
            enabletrue()
            flag2 = "1"
        Else


            Dim cmd As New SqlCommand()

            picturelocation = PictureBox1.ImageLocation.ToString()

            cmd.CommandText = "update_company_master"
            If Trim(TextBox3.Text) = "" Or Trim(TextBox4.Text) = "" Or Trim(TextBox5.Text) = "" Or Trim(TextBox6.Text) = "" Or Trim(TextBox7.Text) = "" Or Trim(TextBox8.Text) = "" Or Trim(TextBox9.Text) = "" Or Trim(TextBox10.Text) = "" Or Trim(ComboBox2.Text) = "" Or Trim(ComboBox1.Text) = "" Then
                validation()
            ElseIf TextBox9.TextLength <> "8" Or TextBox10.TextLength <> "8" Then
                MsgBox("Number entered is wrong!!", MsgBoxStyle.Critical, "Verify")
            Else
                cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = ComboBox1.Text.ToString
                cmd.Parameters.Add("@address", SqlDbType.VarChar).Value = TextBox3.Text.ToString
                cmd.Parameters.Add("@city", SqlDbType.VarChar).Value = TextBox4.Text.ToString
                cmd.Parameters.Add("@state", SqlDbType.VarChar).Value = TextBox5.Text.ToString
                cmd.Parameters.Add("@country", SqlDbType.VarChar).Value = TextBox6.Text.ToString
                cmd.Parameters.Add("@pincode", SqlDbType.VarChar).Value = Val(TextBox7.Text)
                cmd.Parameters.Add("@email", SqlDbType.VarChar).Value = TextBox8.Text.ToString
                cmd.Parameters.Add("@reception", SqlDbType.VarChar).Value = Val(TextBox9.Text)
                cmd.Parameters.Add("@fax", SqlDbType.VarChar).Value = Val(TextBox10.Text)
                cmd.Parameters.Add("@status", SqlDbType.VarChar).Value = ComboBox2.Text.ToString
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



    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles View.Click
        ComboBox1.DataBindings.Clear()
        TextBox3.DataBindings.Clear()
        TextBox4.DataBindings.Clear()
        TextBox5.DataBindings.Clear()
        TextBox6.DataBindings.Clear()
        TextBox7.DataBindings.Clear()
        TextBox8.DataBindings.Clear()
        TextBox9.DataBindings.Clear()
        TextBox10.DataBindings.Clear()
        ComboBox2.DataBindings.Clear()
        PictureBox1.DataBindings.Clear()

        DS.Clear()

        If ComboBox1.Text <> "" Then
            adp.SelectCommand.CommandText = "Select * from company_master where cmp_name='" + ComboBox1.Text + "'"
            adp.Fill(DS, "company_master")
            bs = Me.BindingContext(DS, "company_master")

            ComboBox1.DataBindings.Add("text", DS, "company_master.cmp_name")
            TextBox3.DataBindings.Add("text", DS, "company_master.cmp_address")
            TextBox4.DataBindings.Add("text", DS, "company_master.cmp_city")
            TextBox5.DataBindings.Add("text", DS, "company_master.cmp_state")
            TextBox6.DataBindings.Add("text", DS, "company_master.cmp_country")
            TextBox7.DataBindings.Add("text", DS, "company_master.cmp_pincode")
            TextBox8.DataBindings.Add("text", DS, "company_master.cmp_email")
            TextBox9.DataBindings.Add("text", DS, "company_master.cmp_reception")
            TextBox10.DataBindings.Add("text", DS, "company_master.cmp_fax")
            ComboBox2.DataBindings.Add("text", DS, "company_master.cmp_status")
            PictureBox1.DataBindings.Add("imagelocation", DS, "company_master.cmp_photo")
        Else
            MsgBox("Select company name")
        End If
        enablefalse()
        ComboBox1.Enabled = True
        
    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddNew.Click
        first.Enabled = False
        last.Enabled = False
        previous.Enabled = False
        next1.Enabled = False
        Edit.Enabled = False
        View.Enabled = False
        Delete.Enabled = False
        If flag1 = 0 Then
            AddNew.Text = "Submit"
            AddNew.Image = WindowsApplication1.My.Resources.Resources.submit
            clear()
            enabletrue()
            flag1 = "1"
        Else
            Dim cmd As New SqlCommand()
            If Trim(TextBox3.Text) = "" Or Trim(TextBox4.Text) = "" Or Trim(TextBox5.Text) = "" Or Trim(TextBox6.Text) = "" Or Trim(TextBox7.Text) = "" Or Trim(TextBox8.Text) = "" Or Trim(TextBox9.Text) = "" Or Trim(TextBox10.Text) = "" Or Trim(ComboBox2.Text) = "" Or Trim(ComboBox1.Text) = "" Then
                validation()
            ElseIf TextBox9.TextLength <> "8" Or TextBox10.TextLength <> "8" Then
                MsgBox("Number entered is wrong!!", MsgBoxStyle.Critical, "Verify")

                If Trim(PictureBox1.ImageLocation) <> "" Then
                    a.Filter = ("Image files|*.jpg")
                    picturelocation = a.FileName
                End If
            Else
                cmd.CommandText = "submit_company_master"
                cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = ComboBox1.Text.ToString
                cmd.Parameters.Add("@address", SqlDbType.VarChar).Value = TextBox3.Text.ToString
                cmd.Parameters.Add("@city", SqlDbType.VarChar).Value = TextBox4.Text.ToString
                cmd.Parameters.Add("@state", SqlDbType.VarChar).Value = TextBox5.Text.ToString
                cmd.Parameters.Add("@country", SqlDbType.VarChar).Value = TextBox6.Text.ToString
                cmd.Parameters.Add("@pincode", SqlDbType.VarChar).Value = Val(TextBox7.Text)
                cmd.Parameters.Add("@email", SqlDbType.VarChar).Value = TextBox8.Text.ToString
                cmd.Parameters.Add("@reception", SqlDbType.VarChar).Value = Val(TextBox9.Text)
                cmd.Parameters.Add("@fax", SqlDbType.VarChar).Value = Val(TextBox10.Text)
                cmd.Parameters.Add("@status", SqlDbType.VarChar).Value = ComboBox2.Text.ToString
                cmd.Parameters.Add("@photo", SqlDbType.VarChar).Value = picturelocation.ToString
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Connection = con
                If con.State = ConnectionState.Closed Then
                    con.Open()
                End If
                cmd.ExecuteNonQuery()
                MsgBox("Data Added")
                Refresh()
                AddNew.Text = "Add New"
                AddNew.Image = WindowsApplication1.My.Resources.Resources.addnew
                flag1 = "0"
               


            End If
        End If
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Reset.Click

        clear()
        enabletrue()
        AddNew.Text = "Add New"
        AddNew.Image = WindowsApplication1.My.Resources.Resources.addnew
        flag1 = 0
        Edit.Text = "Edit"
        Edit.Image = WindowsApplication1.My.Resources.Resources.edit
        flag2 = 0
       
    End Sub


    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles first.Click
        bs.Position = 0
        data()
        enablefalse()
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles previous.Click
        bs.Position -= 1
        data()
        enablefalse()
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles next1.Click
        bs.Position += 1
        data()
        enablefalse()
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles last.Click
        bs.Position = DS.Tables("company_master").Rows.Count - 1
        data()
        enablefalse()
    End Sub



    Private Sub TextBox9_keypress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox9.KeyPress

        If (Char.IsControl(e.KeyChar) = False) Then
            If (Char.IsDigit(e.KeyChar)) Then
                'do nothing
            Else
                e.Handled = True
                MsgBox("Sorry Only Digits Allowed!!", MsgBoxStyle.Critical, "Verify")
            End If
        End If
    End Sub

    Private Sub TextBox8_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox8.LostFocus
        Dim regExPattern As String = "^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"
        Dim emailAddressMatch As Match = Regex.Match(TextBox8.Text, regExPattern)
        If emailAddressMatch.Success Then

        Else
            MsgBox("Please enter correct email address", MsgBoxStyle.Critical, "Verify")
        End If

    End Sub



    Private Sub TextBox10_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox10.KeyPress
        If (Char.IsControl(e.KeyChar) = False) Then
            If (Char.IsDigit(e.KeyChar)) Then

            Else
                e.Handled = True
                MsgBox("Sorry Only Digits Allowed!!", MsgBoxStyle.Critical, "Verify")
            End If
        End If
    End Sub

    Private Sub TextBox7_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox7.KeyPress
        If (Char.IsControl(e.KeyChar) = False) Then
            If (Char.IsDigit(e.KeyChar)) Then

            Else
                e.Handled = True
                MsgBox("Sorry Only Digits Allowed!!", MsgBoxStyle.Critical, "Verify")
            End If

        End If
    End Sub


    
    
    
    Private Sub TextBox8_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox8.TextChanged

    End Sub
End Class
