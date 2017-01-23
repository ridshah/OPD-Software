Imports System.Data
Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports
Imports CrystalDecisions.CrystalReports.Engine

Public Class hospitalreportview
    Dim con As New SqlConnection("Data Source=.\sqlexpress;Initial Catalog=opdsys;Integrated Security=True")
    Dim adp As New SqlDataAdapter("", con)


    Private Sub CrystalReportViewer1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CrystalReportViewer1.Load
        Dim rpt As New ReportDocument
        rpt.Load("C:/opdsoft/hospital.rpt")

        If hospitaldetails_report.ComboBox1.Text <> "" And hospitaldetails_report.ComboBox2.Text = "" Then
            adp.SelectCommand.CommandText = "select * from company_master where cmp_name='" + hospitaldetails_report.ComboBox1.Text + "'"
        ElseIf hospitaldetails_report.ComboBox2.Text <> "" And hospitaldetails_report.ComboBox1.Text = "" Then
            adp.SelectCommand.CommandText = "select * from company_master where cmp_state='" + hospitaldetails_report.ComboBox2.Text + "'"
        ElseIf hospitaldetails_report.ComboBox1.Text <> "" And hospitaldetails_report.ComboBox2.Text <> "" Then
            adp.SelectCommand.CommandText = "select * from company_master where cmp_name='" + hospitaldetails_report.ComboBox1.Text + "' and cmp_state='" + hospitaldetails_report.ComboBox2.Text + "'"
        ElseIf hospitaldetails_report.ComboBox1.Text = "" And hospitaldetails_report.ComboBox2.Text = "" Then
            adp.SelectCommand.CommandText = "select * from company_master"
        End If

        Dim ds As New DataSet()
        adp.Fill(ds)
        Dim dt As New DataTable
        dt = ds.Tables(0)

        rpt.SetDataSource(dt)
        CrystalReportViewer1.ReportSource = rpt
    End Sub
End Class