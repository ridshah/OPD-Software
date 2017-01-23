Imports System.Data
Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports
Imports CrystalDecisions.CrystalReports.Engine


Public Class deptreportview
    Dim con As New SqlConnection("Data Source=.\sqlexpress;Initial Catalog=opdsys;Integrated Security=True")
    Dim adp As New SqlDataAdapter("", con)

    Private Sub deptreportview_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim rpt As New ReportDocument
        rpt.Load("C:/opdsoft/department.rpt")
        If departmentdetails_report.ComboBox1.Text <> "" Then
            adp.SelectCommand.CommandText = "select * from departmentmaster_view where dep_name='" + departmentdetails_report.ComboBox1.Text + "'"
        ElseIf departmentdetails_report.ComboBox1.Text = "" Then
            adp.SelectCommand.CommandText = "select * from departmentmaster_view"
        End If
        Dim ds As New DataSet()
        adp.Fill(ds)
        Dim dt As New DataTable
        dt = ds.Tables(0)
        rpt.SetDataSource(dt)
        CrystalReportViewer1.ReportSource = rpt
    End Sub

    Private Sub CrystalReportViewer1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CrystalReportViewer1.Load

    End Sub
End Class