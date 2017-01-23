Imports System.Data
Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports
Imports CrystalDecisions.CrystalReports.Engine
Public Class categoryreportview
    Dim con As New SqlConnection("Data Source=.\sqlexpress;Initial Catalog=opdsys;Integrated Security=True")

    Dim adp As New SqlDataAdapter("", con)

    Private Sub categoryreportview_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim rpt As New ReportDocument
        rpt.Load("C:/opdsoft/category.rpt")
        If categorydetails_report.ComboBox1.Text <> "" Then
            adp.SelectCommand.CommandText = "select * from category_view where category_name='" + categorydetails_report.ComboBox1.Text + "'"
        ElseIf categorydetails_report.ComboBox1.Text = "" Then
            adp.SelectCommand.CommandText = "select * from category_view"
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