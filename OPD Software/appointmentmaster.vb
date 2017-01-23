Imports System.Data
Imports System.Data.SqlClient
Imports System.Net
Imports System.IO
Imports System.Net.Mail

Public Class appointmentmaster
    Dim con As New SqlConnection("Data Source=.\sqlexpress;Initial Catalog=opdsys;Integrated Security=True")
    Dim adp As New SqlDataAdapter("", con)
    Dim DS As New DataSet
    Dim bs As BindingManagerBase
    Dim flag1 As Integer
    Dim flag2 As Integer
   

   
    Public Sub appointmentmaster_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'OpdsysDataSet2.employee_master' table. You can move, or remove it, as needed.
        Me.Employee_masterTableAdapter.Fill(Me.OpdsysDataSet2.employee_master)
        'TODO: This line of code loads data into the 'OpdsysDataSet1.patient_master' table. You can move, or remove it, as needed.
        Me.Patient_masterTableAdapter.Fill(Me.OpdsysDataSet1.patient_master)

        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        DS.Clear()
        adp.SelectCommand.CommandText = "Select patient_name,emp_name,appoint_date,status from appointmentmaster_view"
        adp.Fill(DS, "appointmentmaster_view")
        bs = Me.BindingContext(DS, "appointmentmaster_view")

        ComboBox1.Enabled = True
        ComboBox2.Enabled = False
        DateTimePicker1.Enabled = False
        ComboBox3.Enabled = False
        clear()
        AddNew.Text = "Add New"
        AddNew.Image = WindowsApplication1.My.Resources.Resources.addnew
        flag1 = 0
        Edit.Text = "Edit"
        Edit.Image = WindowsApplication1.My.Resources.Resources.edit
        flag2 = 0

    End Sub

    Sub data()

        ComboBox1.DataBindings.Clear()
        ComboBox2.DataBindings.Clear()
        DateTimePicker1.DataBindings.Clear()
        ComboBox3.DataBindings.Clear()

        adp.SelectCommand.CommandText = "Select patient_name,emp_name,appoint_date,status from appointmentmaster_view"
        adp.Fill(DS, "appointmentmaster_view")
        bs = Me.BindingContext(DS, "appointmentmaster_view")

        ComboBox1.DataBindings.Add("text", DS, "appointmentmaster_view.patient_name")
        ComboBox2.DataBindings.Add("text", DS, "appointmentmaster_view.emp_name")
        DateTimePicker1.DataBindings.Add("text", DS, "appointmentmaster_view.appoint_date")
        ComboBox3.DataBindings.Add("text", DS, "appointmentmaster_view.status")
    End Sub
    Sub clear()
        ComboBox1.Text = ""
        ComboBox2.Text = ""

        ComboBox3.Text = ""
    End Sub
    Sub validation()
        If Trim(ComboBox1.Text) = "" Then
            MsgBox("Please enter patient name")
        ElseIf Trim(ComboBox2.Text) = "" Then
            MsgBox("Please enter employee name")
        ElseIf Trim(ComboBox3.Text) = "" Then
            MsgBox("Please enter status")
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Delete.Click
        If Trim(ComboBox1.Text) = "" Then
            MsgBox("Please enter appointment date and patient name")
        Else
            Dim cmd As New SqlCommand()
            cmd.CommandText = "delete_appointment_master"
            cmd.Parameters.Add("@adate", SqlDbType.VarChar).Value = DateTimePicker1.Text.ToString
            cmd.Parameters.Add("@pid", SqlDbType.VarChar).Value = Val(ComboBox1.SelectedValue)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = con

            If con.State = ConnectionState.Closed Then
                con.Open()
            End If

            cmd.ExecuteNonQuery()
            MsgBox("Data Deleted Successfully")
        End If

    End Sub



    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles first.Click
        bs.Position = 0
        data()

        ComboBox1.Enabled = False
        ComboBox2.Enabled = False
        DateTimePicker1.Enabled = False
        ComboBox3.Enabled = False
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles previous.Click
        bs.Position -= 1
        data()

        ComboBox1.Enabled = False
        ComboBox2.Enabled = False
        DateTimePicker1.Enabled = False
        ComboBox3.Enabled = False
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles next1.Click
        bs.Position += 1
        data()

        ComboBox1.Enabled = False
        ComboBox2.Enabled = False
        DateTimePicker1.Enabled = False
        ComboBox3.Enabled = False
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles last.Click
        bs.Position = DS.Tables("appointmentmaster_view").Rows.Count - 1
        data()

        ComboBox1.Enabled = False
        ComboBox2.Enabled = False
        DateTimePicker1.Enabled = False
        ComboBox3.Enabled = False
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Reset.Click

        clear()

        ComboBox1.Enabled = True
        ComboBox2.Enabled = True
        DateTimePicker1.Enabled = True
        ComboBox3.Enabled = True
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Edit.Click
        If flag2 = 0 Then
            Edit.Text = "Update"
            Edit.Image = WindowsApplication1.My.Resources.Resources.update1
            ComboBox1.Enabled = False
            ComboBox2.Enabled = True
            DateTimePicker1.Enabled = True
            ComboBox3.Enabled = True
            flag2 = "1"
        Else



            Dim cmd As New SqlCommand()
            If Trim(ComboBox1.Text) = "" Or Trim(ComboBox2.Text) = "" Or Trim(ComboBox3.Text) = "" Then
                validation()
            Else
                cmd.CommandText = "update_appointment_master"
                cmd.Parameters.Add("@pid", SqlDbType.VarChar).Value = Val(ComboBox1.SelectedValue)
                cmd.Parameters.Add("@eid", SqlDbType.VarChar).Value = Val(ComboBox2.SelectedValue)
                cmd.Parameters.Add("@adate", SqlDbType.VarChar).Value = DateTimePicker1.Text.ToString()
                cmd.Parameters.Add("@status", SqlDbType.VarChar).Value = ComboBox3.Text.ToString

                cmd.CommandType = CommandType.StoredProcedure
                cmd.Connection = con
                If con.State = ConnectionState.Closed Then
                    con.Open()
                End If
                cmd.ExecuteNonQuery()
                MsgBox("Data Updated Successfully")
                Edit.Image = WindowsApplication1.My.Resources.Resources.edit
                Edit.Text = "Edit"
                flag2 = "0"
            End If
        End If
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles View.Click

        ComboBox1.DataBindings.Clear()
        ComboBox2.DataBindings.Clear()
        DateTimePicker1.DataBindings.Clear()
        ComboBox3.DataBindings.Clear()

        DS.Clear()

        If ComboBox1.Text <> "" Then
            adp.SelectCommand.CommandText = "select patient_name,emp_name,appoint_date,status from appointmentmaster_view where patient_name='" + ComboBox1.Text + "' "
            adp.Fill(DS, "appointmentmaster_view")
            bs = Me.BindingContext(DS, "appointmentmaster_view")

            ComboBox1.DataBindings.Add("text", DS, "appointmentmaster_view.patient_name")
            ComboBox2.DataBindings.Add("text", DS, "appointmentmaster_view.emp_name")
            DateTimePicker1.DataBindings.Add("text", DS, "appointmentmaster_view.appoint_date")
            ComboBox3.DataBindings.Add("text", DS, "appointmentmaster_view.status")
        Else
            MsgBox("Select patient name")
        End If


        ComboBox1.Enabled = True
        ComboBox2.Enabled = False
        DateTimePicker1.Enabled = False
        ComboBox3.Enabled = False
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddNew.Click
        If flag1 = 0 Then
            AddNew.Text = "Submit"
            AddNew.Image = WindowsApplication1.My.Resources.Resources.submit
            clear()
            ComboBox1.Enabled = True
            ComboBox2.Enabled = True
            DateTimePicker1.Enabled = True
            ComboBox3.Enabled = True
            flag1 = "1"
        Else


            Dim cmd As New SqlCommand()
            If Trim(ComboBox3.Text) = "" Or Trim(ComboBox1.Text) = "" Or Trim(ComboBox2.Text) = "" Then
                validation()

            Else
                cmd.CommandText = "submit_appointment_master"

                cmd.Parameters.Add("@pid", SqlDbType.VarChar).Value = Val(ComboBox1.SelectedValue)
                cmd.Parameters.Add("@eid", SqlDbType.VarChar).Value = Val(ComboBox2.SelectedValue)
                cmd.Parameters.Add("@adate", SqlDbType.VarChar).Value = DateTimePicker1.Text.ToString()
                cmd.Parameters.Add("@status", SqlDbType.VarChar).Value = ComboBox3.Text.ToString

                cmd.CommandType = CommandType.StoredProcedure
                cmd.Connection = con
                If con.State = ConnectionState.Closed Then
                    con.Open()
                End If
                cmd.ExecuteNonQuery()
                MsgBox("Data Added Successfully")
                AddNew.Text = "Add New"
                AddNew.Image = WindowsApplication1.My.Resources.Resources.addnew
                flag1 = "0"
            End If
        End If
    End Sub

    Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker1.ValueChanged

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        
        'Dim client As WebClient = New WebClient
        '' Add a user agent header in case the requested URI contains a query.
        'client.Headers.Add("user-agent", "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2; .NET CLR 1.0.3705;)")
        'client.QueryString.Add("user", " ritz@123")
        'client.QueryString.Add("password", "FddFWBUYdDfPcV")
        'client.QueryString.Add("api_id", "3474286")
        'client.QueryString.Add("to", "919978077443")
        'client.QueryString.Add("text", "This is an example message")
        'Dim baseurl As String = "http://api.clickatell.com/http/sendmsg?"
        'Dim data As Stream = client.OpenRead(baseurl)
        'Dim reader As StreamReader = New StreamReader(data)
        'Dim s As String = reader.ReadToEnd()
        'data.Close()
        'reader.Close()
        'Return

        
       
        mail.Show()
    End Sub
End Class