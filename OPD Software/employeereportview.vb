Imports System.Data
Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports
Imports CrystalDecisions.CrystalReports.Engine
Public Class employeereportview
    Dim con As New SqlConnection("Data Source=.\sqlexpress;Initial Catalog=opdsys;Integrated Security=True")
    Dim adp As New SqlDataAdapter("", con)

    Private Sub CrystalReportViewer1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CrystalReportViewer1.Load
        Dim rpt As New ReportDocument
        rpt.Load("C:/opdsoft/employee.rpt")

        If employee_report.ComboBox1.Text <> "" And employee_report.ComboBox2.Text = "" And employee_report.ComboBox3.Text = "" Then
            adp.SelectCommand.CommandText = "select * from employeemaster_view where emp_name='" + employee_report.ComboBox1.Text + "'"
        ElseIf employee_report.ComboBox2.Text <> "" And employee_report.ComboBox1.Text = "" And employee_report.ComboBox3.Text = "" Then
            adp.SelectCommand.CommandText = "select * from employeemaster_view where dep_name='" + employee_report.ComboBox2.Text + "'"
        ElseIf employee_report.ComboBox3.Text <> "" And employee_report.ComboBox2.Text = "" And employee_report.ComboBox1.Text = "" Then
            adp.SelectCommand.CommandText = "select * from employeemaster_view where emp_type='" + employee_report.ComboBox3.Text + "'"
        ElseIf employee_report.ComboBox1.Text = "" And employee_report.ComboBox2.Text = "" And employee_report.ComboBox3.Text = "" Then
            adp.SelectCommand.CommandText = "select * from employeemaster_view"
        ElseIf employee_report.ComboBox1.Text <> "" And employee_report.ComboBox2.Text <> "" And employee_report.ComboBox3.Text = "" Then
            adp.SelectCommand.CommandText = "select * from employeemaster_view where emp_name='" + employee_report.ComboBox1.Text + "' and dep_name='" + employee_report.ComboBox2.Text + "'"
        ElseIf employee_report.ComboBox1.Text = "" And employee_report.ComboBox2.Text <> "" And employee_report.ComboBox3.Text <> "" Then
            adp.SelectCommand.CommandText = "select * from employeemaster_view where dep_name='" + employee_report.ComboBox2.Text + "' and emp_type='" + employee_report.ComboBox3.Text + "'"
        ElseIf employee_report.ComboBox1.Text <> "" And employee_report.ComboBox2.Text = "" And employee_report.ComboBox3.Text <> "" Then
            adp.SelectCommand.CommandText = "select * from employeemaster_view where emp_name='" + employee_report.ComboBox1.Text + "' and emp_type='" + employee_report.ComboBox3.Text + "'"
        ElseIf employee_report.ComboBox1.Text <> "" And employee_report.ComboBox2.Text <> "" And employee_report.ComboBox3.Text <> "" Then
            adp.SelectCommand.CommandText = "select * from employeemaster_view where emp_name='" + employee_report.ComboBox1.Text + "' and emp_type='" + employee_report.ComboBox3.Text + "' and dep_name='" + employee_report.ComboBox2.Text + "'"
        End If



        Dim ds As New DataSet()
        adp.Fill(ds)
        Dim dt As New DataTable
        dt = ds.Tables(0)

        rpt.SetDataSource(dt)
        CrystalReportViewer1.ReportSource = rpt
    End Sub
End Class