Imports System.Data
Imports System.Data.SqlClient
Public Class employee_report
    Dim con As New SqlConnection("Data Source=.\sqlexpress;Initial Catalog=opdsys;Integrated Security=True")
    Dim adp As New SqlDataAdapter("", con)
    Dim DS As New DataSet
    Dim bs As BindingManagerBase
   

    Private Sub employee_report_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'OpdDataSet55.department_master' table. You can move, or remove it, as needed.
        Me.Department_masterTableAdapter.Fill(Me.OpdDataSet55.department_master)
        'TODO: This line of code loads data into the 'OpdDataSet54.employee_master' table. You can move, or remove it, as needed.
        Me.Employee_masterTableAdapter.Fill(Me.OpdDataSet54.employee_master)
        ComboBox1.Enabled = False
        ComboBox2.Enabled = False
        ComboBox3.Enabled = False
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        DS.Clear()
        If RadioButton1.Checked = True Then
            If Trim(ComboBox1.Text) <> "" And Trim(ComboBox2.Text) = "" And Trim(ComboBox3.Text) = "" Then
                adp.SelectCommand.CommandText = "select emp_name as EmployeeName,emp_password as EmployeePassword,emp_type as EmployeeType,dep_name as DepartmentName,emp_address as Address,emp_email as Email,emp_mobile as MobileNumber,emp_landline as LandlineNumber from employeemaster_view where emp_name='" + ComboBox1.Text + "'"
            ElseIf Trim(ComboBox2.Text) <> "" And Trim(ComboBox1.Text) = "" And Trim(ComboBox3.Text) = "" Then
                adp.SelectCommand.CommandText = "select emp_name as EmployeeName,emp_password as EmployeePassword,emp_type as EmployeeType,dep_name as DepartmentName,emp_address as Address,emp_email as Email,emp_mobile as MobileNumber,emp_landline as LandlineNumber from employeemaster_view where dep_name='" + ComboBox2.Text + "'"
            ElseIf Trim(ComboBox3.Text) <> "" And Trim(ComboBox2.Text) = "" And Trim(ComboBox1.Text) = "" Then
                adp.SelectCommand.CommandText = "select emp_name as EmployeeName,emp_password as EmployeePassword,emp_type as EmployeeType,dep_name as DepartmentName,emp_address as Address,emp_email as Email,emp_mobile as MobileNumber,emp_landline as LandlineNumber from employeemaster_view where emp_type='" + ComboBox3.Text + "'"
            ElseIf Trim(ComboBox1.Text) = "" And Trim(ComboBox2.Text) = "" And Trim(ComboBox3.Text) = "" Then
                MsgBox("All fields are empty!!")
            ElseIf Trim(ComboBox1.Text) <> "" And Trim(ComboBox2.Text) <> "" And Trim(ComboBox3.Text) = "" Then
                adp.SelectCommand.CommandText = "select emp_name as EmployeeName,emp_password as EmployeePassword,emp_type as EmployeeType,dep_name as DepartmentName,emp_address as Address,emp_email as Email,emp_mobile as MobileNumber,emp_landline as LandlineNumber from employeemaster_view where emp_name='" + ComboBox1.Text + "' and dep_name='" + ComboBox2.Text + "'"
            ElseIf Trim(ComboBox1.Text) = "" And Trim(ComboBox2.Text) <> "" And Trim(ComboBox3.Text) <> "" Then
                adp.SelectCommand.CommandText = "select emp_name as EmployeeName,emp_password as EmployeePassword,emp_type as EmployeeType,dep_name as DepartmentName,emp_address as Address,emp_email as Email,emp_mobile as MobileNumber,emp_landline as LandlineNumber from employeemaster_view where dep_name='" + ComboBox2.Text + "' and emp_type='" + ComboBox3.Text + "'"
            ElseIf Trim(ComboBox1.Text) <> "" And Trim(ComboBox2.Text) = "" And Trim(ComboBox3.Text) <> "" Then
                adp.SelectCommand.CommandText = "select emp_name as EmployeeName,emp_password as EmployeePassword,emp_type as EmployeeType,dep_name as DepartmentName,emp_address as Address,emp_email as Email,emp_mobile as MobileNumber,emp_landline as LandlineNumber from employeemaster_view where emp_name='" + ComboBox1.Text + "' and emp_type='" + ComboBox3.Text + "'"
            ElseIf Trim(ComboBox1.Text) <> "" And Trim(ComboBox2.Text) <> "" And Trim(ComboBox3.Text) <> "" Then
                adp.SelectCommand.CommandText = "select emp_name as EmployeeName,emp_password as EmployeePassword,emp_type as EmployeeType,dep_name as DepartmentName,emp_address as Address,emp_email as Email,emp_mobile as MobileNumber,emp_landline as LandlineNumber from employeemaster_view where emp_name='" + ComboBox1.Text + "' and emp_type='" + ComboBox3.Text + "' and dep_name='" + ComboBox2.Text + "'"
            End If
        ElseIf RadioButton2.Checked = True Then
            adp.SelectCommand.CommandText = "select emp_name as EmployeeName,emp_password as EmployeePassword,emp_type as EmployeeType,dep_name as DepartmentName,emp_address as Address,emp_email as Email,emp_mobile as MobileNumber,emp_landline as LandlineNumber from employeemaster_view"
        End If
        adp.Fill(DS, "employeemaster_view")
        DataGridView1.DataSource = Nothing
        DataGridView1.DataSource = DS
        DataGridView1.DataMember = "employeemaster_view"
        bs = Me.BindingContext(DS, "employeemaster_view")
    End Sub


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        employeereportview.Show()
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked = True Then
            ComboBox1.Enabled = True
            ComboBox2.Enabled = True
            ComboBox3.Enabled = True
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked = True Then
            ComboBox1.Enabled = False
            ComboBox2.Enabled = False
            ComboBox3.Enabled = False
            ComboBox1.Text = ""
            ComboBox2.Text = ""
            ComboBox3.Text = ""
        End If
    End Sub
End Class