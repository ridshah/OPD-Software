Imports System.Windows.Forms

Public Class OPDSoftware
    Dim cl As New Class1
    Private Sub OPDSoftware_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

     
    End Sub
    Sub hides()

        companymaster.Hide()
        departmentmaster.Hide()
        appointmentmaster.Hide()
        employeemaster.Hide()
        employeerights.Hide()
        patientdetails.Hide()
        patientmaster.Hide()
        categorymaster.Hide()
        medicinebrandmaster.Hide()
        medicinemaster.Hide()
        patientdiagnosis.Hide()
        patienttestassign.Hide()
        patienttestresult.Hide()
        receiptmaster.Hide()
        subcategorymaster.Hide()
        testmaster.Hide()
        UOM.Hide()
        employee_report.Hide()
        hospitaldetails_report.Hide()
        departmentdetails_report.Hide()
        categorydetails_report.Hide()
        subcategorydetails_report.Hide()
        patientdetails_report.Hide()
        patientmedicaldetails_report.Hide()
        patientdiagnosis_report.Hide()
        patienttest_report.Hide()
        patientappointment_report.Hide()
        receiptdetails_report.Hide()
        Form1.Hide()
    End Sub
    Private Sub ShowNewForm(ByVal sender As Object, ByVal e As EventArgs) Handles ToolStripMenuItem7.Click
        hides()
        companymaster.Show()
        companymaster.MdiParent = Me

    End Sub


    Private Sub WindowsMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Logout.Click

        LOGIN_FORM.Show()
        LOGIN_FORM.TextBox1.Text = ""
        LOGIN_FORM.TextBox2.Text = ""
        Me.Hide()
    End Sub

    Private Sub HelpMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitSystem.Click
        Me.Close()
    End Sub
    Public Shared Function SetParent(ByVal hWndChild As IntPtr, ByVal hWndParent As IntPtr) As IntPtr
    End Function
    Private Sub OptionsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem29.Click

        hides()
        MsgBox("The application will have to close in order to perform backup/restore. Are you sure you want to perform backup/restore and close the application?", MsgBoxStyle.OkCancel, "Attention")
        Me.Close()
        Try
            Dim myprocess As New Process
            myprocess.StartInfo.FileName = "C:\backup and restore.exe"
            myprocess.StartInfo.WindowStyle = ProcessWindowStyle.Normal

            myprocess.Start()
            myprocess.WaitForInputIdle()
            SetParent(myprocess.MainWindowHandle, Me.Handle)
            myprocess.WaitForExit()
            'Me.Close()
            LOGIN_FORM.Show()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ToolStripMenuItem18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub


    Private Sub ToolStripMenuItem8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem8.Click

        hides()
        departmentmaster.Show()
        departmentmaster.MdiParent = Me
    End Sub

    Private Sub ToolStripMenuItem9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem9.Click
        hides()
        categorymaster.Show()
        categorymaster.MdiParent = Me
    End Sub

    Private Sub ToolStripMenuItem10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem10.Click
        hides()
        subcategorymaster.Show()
        subcategorymaster.MdiParent = Me
    End Sub



    Private Sub ToolStripMenuItem13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem13.Click
        hides()
        employeemaster.Show()
        employeemaster.MdiParent = Me
    End Sub

    Private Sub ToolStripMenuItem14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem14.Click
        hides()
        employeerights.Show()
        employeerights.MdiParent = Me
    End Sub

    Private Sub ToolStripMenuItem15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem15.Click
        hides()
        medicinemaster.Show()
        medicinemaster.MdiParent = Me
    End Sub

    Private Sub ToolstripMenuItem16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolstripMenuItem16.Click
        hides()
        medicinebrandmaster.Show()
        medicinebrandmaster.MdiParent = Me
    End Sub

    Private Sub ToolStripMenuItem17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem17.Click
        hides()
        UOM.Show()
        UOM.MdiParent = Me
    End Sub

    Private Sub ToolStripMenuItem18_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem50.Click
        hides()
        patientmaster.Show()
        patientmaster.MdiParent = Me
    End Sub

    Private Sub ToolStripMenuItem19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem51.Click
        hides()
        patientdetails.Show()
        patientdetails.MdiParent = Me
    End Sub

    Private Sub ToolStripMenuItem20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem52.Click
        hides()
        patientdiagnosis.Show()
        patientdiagnosis.MdiParent = Me
    End Sub

    Private Sub ToolStripMenuItem21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem53.Click
        hides()
        patienttestassign.Show()
        patienttestassign.MdiParent = Me
    End Sub

    Private Sub ToolStripMenuItem22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem54.Click
        hides()
        patienttestresult.Show()
        patienttestresult.MdiParent = Me
    End Sub

    Private Sub ToolStripMenuItem23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem55.Click
        hides()
        testmaster.Show()
        testmaster.MdiParent = Me
    End Sub

    Private Sub ToolStripMenuItem24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem56.Click
        hides()
        appointmentmaster.Show()
        appointmentmaster.MdiParent = Me
    End Sub

    Private Sub ToolStripMenuItem25_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem57.Click
        hides()
        receiptmaster.Show()
        receiptmaster.MdiParent = Me
    End Sub




    Private Sub PatientHistory_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PatientHistory.Click
        hides()
        patientmedicaldetails_report.Show()
        patientmedicaldetails_report.MdiParent = Me
    End Sub

    Private Sub Patient_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Patient.Click

    End Sub

    Private Sub CompanyDetails_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CompanyDetails.Click
        hides()
        hospitaldetails_report.Show()
        hospitaldetails_report.MdiParent = Me
    End Sub

    Private Sub DepartmentDetails_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DepartmentDetails.Click
        hides()
        departmentdetails_report.Show()
        departmentdetails_report.MdiParent = Me
    End Sub

    Private Sub CategoryDetails_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CategoryDetails.Click
        hides()
        categorydetails_report.Show()
        categorydetails_report.MdiParent = Me
    End Sub

    Private Sub SubcategoryDetails_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SubcategoryDetails.Click
        hides()
        subcategorydetails_report.Show()
        subcategorydetails_report.MdiParent = Me
    End Sub

    Private Sub PatientDetail_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PatientDetail.Click
        hides()
        patientdetails_report.Show()
        patientdetails_report.MdiParent = Me
    End Sub

    Private Sub PatientDiagnosisDetail_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PatientDiagnosisDetail.Click
        hides()
        patientdiagnosis_report.Show()
        patientdiagnosis_report.MdiParent = Me
    End Sub

    Private Sub PatientTestDetail_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PatientTestDetail.Click
        hides()
        patienttest_report.Show()
        patienttest_report.MdiParent = Me
    End Sub

    Private Sub PatientAppointmentDetail_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PatientAppointmentDetail.Click
        hides()
        patientappointment_report.Show()
        patientappointment_report.MdiParent = Me
    End Sub

    Private Sub ToolStripMenuItem28_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem28.Click
        hides()
        employee_report.Show()
        employee_report.MdiParent = Me
    End Sub

    Private Sub ReceiptDetails_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReceiptDetails.Click
        hides()
        receiptdetails_report.Show()
        receiptdetails_report.MdiParent = Me
    End Sub


End Class
