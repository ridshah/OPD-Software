<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OPDSoftware
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub


    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(OPDSoftware))
        Me.MenuStrip = New System.Windows.Forms.MenuStrip
        Me.Master = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem7 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem8 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem9 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem10 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem11 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem13 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem14 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem12 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem15 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolstripMenuItem16 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem17 = New System.Windows.Forms.ToolStripMenuItem
        Me.Patient = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem50 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem51 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem52 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem53 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem54 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem55 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem56 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem57 = New System.Windows.Forms.ToolStripMenuItem
        Me.Reports = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem26 = New System.Windows.Forms.ToolStripMenuItem
        Me.CompanyDetails = New System.Windows.Forms.ToolStripMenuItem
        Me.DepartmentDetails = New System.Windows.Forms.ToolStripMenuItem
        Me.CategoryDetails = New System.Windows.Forms.ToolStripMenuItem
        Me.SubcategoryDetails = New System.Windows.Forms.ToolStripMenuItem
        Me.ReceiptDetails = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem27 = New System.Windows.Forms.ToolStripMenuItem
        Me.PatientDetail = New System.Windows.Forms.ToolStripMenuItem
        Me.PatientHistory = New System.Windows.Forms.ToolStripMenuItem
        Me.PatientDiagnosisDetail = New System.Windows.Forms.ToolStripMenuItem
        Me.PatientTestDetail = New System.Windows.Forms.ToolStripMenuItem
        Me.PatientAppointmentDetail = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem28 = New System.Windows.Forms.ToolStripMenuItem
        Me.Utilities = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem29 = New System.Windows.Forms.ToolStripMenuItem
        Me.Logout = New System.Windows.Forms.ToolStripMenuItem
        Me.ExitSystem = New System.Windows.Forms.ToolStripMenuItem
        Me.StatusStrip = New System.Windows.Forms.StatusStrip
        Me.ToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuStrip.SuspendLayout()
        Me.StatusStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Master, Me.Patient, Me.Reports, Me.Utilities, Me.Logout, Me.ExitSystem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.MdiWindowListItem = Me.Logout
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(632, 24)
        Me.MenuStrip.TabIndex = 5
        Me.MenuStrip.Text = "MenuStrip"
        '
        'Master
        '
        Me.Master.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem7, Me.ToolStripMenuItem8, Me.ToolStripMenuItem9, Me.ToolStripMenuItem10, Me.ToolStripMenuItem11, Me.ToolStripMenuItem12})
        Me.Master.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder
        Me.Master.Name = "Master"
        Me.Master.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.M), System.Windows.Forms.Keys)
        Me.Master.Size = New System.Drawing.Size(55, 20)
        Me.Master.Text = "&Master"
        '
        'ToolStripMenuItem7
        '
        Me.ToolStripMenuItem7.ImageTransparentColor = System.Drawing.Color.Black
        Me.ToolStripMenuItem7.Name = "ToolStripMenuItem7"
        Me.ToolStripMenuItem7.Size = New System.Drawing.Size(179, 22)
        Me.ToolStripMenuItem7.Text = "&Hospital Master"
        '
        'ToolStripMenuItem8
        '
        Me.ToolStripMenuItem8.ImageTransparentColor = System.Drawing.Color.Black
        Me.ToolStripMenuItem8.Name = "ToolStripMenuItem8"
        Me.ToolStripMenuItem8.Size = New System.Drawing.Size(179, 22)
        Me.ToolStripMenuItem8.Text = "&Department Master"
        '
        'ToolStripMenuItem9
        '
        Me.ToolStripMenuItem9.ImageTransparentColor = System.Drawing.Color.Black
        Me.ToolStripMenuItem9.Name = "ToolStripMenuItem9"
        Me.ToolStripMenuItem9.Size = New System.Drawing.Size(179, 22)
        Me.ToolStripMenuItem9.Text = "Cate&gory Master"
        '
        'ToolStripMenuItem10
        '
        Me.ToolStripMenuItem10.Name = "ToolStripMenuItem10"
        Me.ToolStripMenuItem10.Size = New System.Drawing.Size(179, 22)
        Me.ToolStripMenuItem10.Text = "&Subcategory Master"
        '
        'ToolStripMenuItem11
        '
        Me.ToolStripMenuItem11.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem13, Me.ToolStripMenuItem14})
        Me.ToolStripMenuItem11.ImageTransparentColor = System.Drawing.Color.Black
        Me.ToolStripMenuItem11.Name = "ToolStripMenuItem11"
        Me.ToolStripMenuItem11.Size = New System.Drawing.Size(179, 22)
        Me.ToolStripMenuItem11.Text = "&Employee"
        '
        'ToolStripMenuItem13
        '
        Me.ToolStripMenuItem13.Name = "ToolStripMenuItem13"
        Me.ToolStripMenuItem13.Size = New System.Drawing.Size(165, 22)
        Me.ToolStripMenuItem13.Text = "Employee Master"
        '
        'ToolStripMenuItem14
        '
        Me.ToolStripMenuItem14.Name = "ToolStripMenuItem14"
        Me.ToolStripMenuItem14.Size = New System.Drawing.Size(165, 22)
        Me.ToolStripMenuItem14.Text = "Employee Rights"
        '
        'ToolStripMenuItem12
        '
        Me.ToolStripMenuItem12.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem15, Me.ToolstripMenuItem16, Me.ToolStripMenuItem17})
        Me.ToolStripMenuItem12.ImageTransparentColor = System.Drawing.Color.Black
        Me.ToolStripMenuItem12.Name = "ToolStripMenuItem12"
        Me.ToolStripMenuItem12.Size = New System.Drawing.Size(179, 22)
        Me.ToolStripMenuItem12.Text = "&Medicine"
        '
        'ToolStripMenuItem15
        '
        Me.ToolStripMenuItem15.Name = "ToolStripMenuItem15"
        Me.ToolStripMenuItem15.Size = New System.Drawing.Size(196, 22)
        Me.ToolStripMenuItem15.Text = "Medicine Master"
        '
        'ToolstripMenuItem16
        '
        Me.ToolstripMenuItem16.Name = "ToolstripMenuItem16"
        Me.ToolstripMenuItem16.Size = New System.Drawing.Size(196, 22)
        Me.ToolstripMenuItem16.Text = "Medicine Brand Master"
        '
        'ToolStripMenuItem17
        '
        Me.ToolStripMenuItem17.Name = "ToolStripMenuItem17"
        Me.ToolStripMenuItem17.Size = New System.Drawing.Size(196, 22)
        Me.ToolStripMenuItem17.Text = "UOM"
        '
        'Patient
        '
        Me.Patient.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem50, Me.ToolStripMenuItem51, Me.ToolStripMenuItem52, Me.ToolStripMenuItem53, Me.ToolStripMenuItem54, Me.ToolStripMenuItem55, Me.ToolStripMenuItem56, Me.ToolStripMenuItem57})
        Me.Patient.Name = "Patient"
        Me.Patient.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.Patient.Size = New System.Drawing.Size(56, 20)
        Me.Patient.Text = "&Patient"
        '
        'ToolStripMenuItem50
        '
        Me.ToolStripMenuItem50.ImageTransparentColor = System.Drawing.Color.Black
        Me.ToolStripMenuItem50.Name = "ToolStripMenuItem50"
        Me.ToolStripMenuItem50.Size = New System.Drawing.Size(203, 22)
        Me.ToolStripMenuItem50.Text = "&Patient Master"
        '
        'ToolStripMenuItem51
        '
        Me.ToolStripMenuItem51.ImageTransparentColor = System.Drawing.Color.Black
        Me.ToolStripMenuItem51.Name = "ToolStripMenuItem51"
        Me.ToolStripMenuItem51.Size = New System.Drawing.Size(203, 22)
        Me.ToolStripMenuItem51.Text = "Patient Details"
        '
        'ToolStripMenuItem52
        '
        Me.ToolStripMenuItem52.ImageTransparentColor = System.Drawing.Color.Black
        Me.ToolStripMenuItem52.Name = "ToolStripMenuItem52"
        Me.ToolStripMenuItem52.Size = New System.Drawing.Size(203, 22)
        Me.ToolStripMenuItem52.Text = "Patient Diagnosis Details"
        '
        'ToolStripMenuItem53
        '
        Me.ToolStripMenuItem53.ImageTransparentColor = System.Drawing.Color.Black
        Me.ToolStripMenuItem53.Name = "ToolStripMenuItem53"
        Me.ToolStripMenuItem53.Size = New System.Drawing.Size(203, 22)
        Me.ToolStripMenuItem53.Text = "Patient Test Assign"
        '
        'ToolStripMenuItem54
        '
        Me.ToolStripMenuItem54.ImageTransparentColor = System.Drawing.Color.Black
        Me.ToolStripMenuItem54.Name = "ToolStripMenuItem54"
        Me.ToolStripMenuItem54.Size = New System.Drawing.Size(203, 22)
        Me.ToolStripMenuItem54.Text = "Patient Test Result"
        '
        'ToolStripMenuItem55
        '
        Me.ToolStripMenuItem55.Name = "ToolStripMenuItem55"
        Me.ToolStripMenuItem55.Size = New System.Drawing.Size(203, 22)
        Me.ToolStripMenuItem55.Text = "&Test Master"
        '
        'ToolStripMenuItem56
        '
        Me.ToolStripMenuItem56.Name = "ToolStripMenuItem56"
        Me.ToolStripMenuItem56.Size = New System.Drawing.Size(203, 22)
        Me.ToolStripMenuItem56.Text = "&Appointment Master"
        '
        'ToolStripMenuItem57
        '
        Me.ToolStripMenuItem57.Name = "ToolStripMenuItem57"
        Me.ToolStripMenuItem57.Size = New System.Drawing.Size(203, 22)
        Me.ToolStripMenuItem57.Text = "&Receipt Master"
        '
        'Reports
        '
        Me.Reports.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem26, Me.ToolStripMenuItem27, Me.ToolStripMenuItem28})
        Me.Reports.Name = "Reports"
        Me.Reports.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.Reports.Size = New System.Drawing.Size(59, 20)
        Me.Reports.Text = "&Reports"
        '
        'ToolStripMenuItem26
        '
        Me.ToolStripMenuItem26.CheckOnClick = True
        Me.ToolStripMenuItem26.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CompanyDetails, Me.DepartmentDetails, Me.CategoryDetails, Me.SubcategoryDetails, Me.ReceiptDetails})
        Me.ToolStripMenuItem26.Name = "ToolStripMenuItem26"
        Me.ToolStripMenuItem26.Size = New System.Drawing.Size(164, 22)
        Me.ToolStripMenuItem26.Text = "Master"
        '
        'CompanyDetails
        '
        Me.CompanyDetails.Name = "CompanyDetails"
        Me.CompanyDetails.Size = New System.Drawing.Size(178, 22)
        Me.CompanyDetails.Text = "Hospital Details"
        '
        'DepartmentDetails
        '
        Me.DepartmentDetails.Name = "DepartmentDetails"
        Me.DepartmentDetails.Size = New System.Drawing.Size(178, 22)
        Me.DepartmentDetails.Text = "Department Details"
        '
        'CategoryDetails
        '
        Me.CategoryDetails.Name = "CategoryDetails"
        Me.CategoryDetails.Size = New System.Drawing.Size(178, 22)
        Me.CategoryDetails.Text = "Category Details"
        '
        'SubcategoryDetails
        '
        Me.SubcategoryDetails.Name = "SubcategoryDetails"
        Me.SubcategoryDetails.Size = New System.Drawing.Size(178, 22)
        Me.SubcategoryDetails.Text = "Subcategory Details"
        '
        'ReceiptDetails
        '
        Me.ReceiptDetails.Name = "ReceiptDetails"
        Me.ReceiptDetails.Size = New System.Drawing.Size(178, 22)
        Me.ReceiptDetails.Text = "Receipt Details"
        '
        'ToolStripMenuItem27
        '
        Me.ToolStripMenuItem27.CheckOnClick = True
        Me.ToolStripMenuItem27.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PatientDetail, Me.PatientHistory, Me.PatientDiagnosisDetail, Me.PatientTestDetail, Me.PatientAppointmentDetail})
        Me.ToolStripMenuItem27.Name = "ToolStripMenuItem27"
        Me.ToolStripMenuItem27.Size = New System.Drawing.Size(164, 22)
        Me.ToolStripMenuItem27.Text = "Patient"
        '
        'PatientDetail
        '
        Me.PatientDetail.Name = "PatientDetail"
        Me.PatientDetail.Size = New System.Drawing.Size(223, 22)
        Me.PatientDetail.Text = "Patient Details"
        '
        'PatientHistory
        '
        Me.PatientHistory.Name = "PatientHistory"
        Me.PatientHistory.Size = New System.Drawing.Size(223, 22)
        Me.PatientHistory.Text = "Patient Medical Details"
        '
        'PatientDiagnosisDetail
        '
        Me.PatientDiagnosisDetail.Name = "PatientDiagnosisDetail"
        Me.PatientDiagnosisDetail.Size = New System.Drawing.Size(223, 22)
        Me.PatientDiagnosisDetail.Text = "Patient Diagnosis Details"
        '
        'PatientTestDetail
        '
        Me.PatientTestDetail.Name = "PatientTestDetail"
        Me.PatientTestDetail.Size = New System.Drawing.Size(223, 22)
        Me.PatientTestDetail.Text = "Patient Test Details"
        '
        'PatientAppointmentDetail
        '
        Me.PatientAppointmentDetail.Name = "PatientAppointmentDetail"
        Me.PatientAppointmentDetail.Size = New System.Drawing.Size(223, 22)
        Me.PatientAppointmentDetail.Text = "Patient Appointment Details"
        '
        'ToolStripMenuItem28
        '
        Me.ToolStripMenuItem28.Name = "ToolStripMenuItem28"
        Me.ToolStripMenuItem28.Size = New System.Drawing.Size(164, 22)
        Me.ToolStripMenuItem28.Text = "Employee Report"
        '
        'Utilities
        '
        Me.Utilities.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem29})
        Me.Utilities.Name = "Utilities"
        Me.Utilities.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.U), System.Windows.Forms.Keys)
        Me.Utilities.Size = New System.Drawing.Size(58, 20)
        Me.Utilities.Text = "&Utilities"
        '
        'ToolStripMenuItem29
        '
        Me.ToolStripMenuItem29.Name = "ToolStripMenuItem29"
        Me.ToolStripMenuItem29.Size = New System.Drawing.Size(184, 22)
        Me.ToolStripMenuItem29.Text = "Backup/Restore Data"
        '
        'Logout
        '
        Me.Logout.AutoToolTip = True
        Me.Logout.DoubleClickEnabled = True
        Me.Logout.Name = "Logout"
        Me.Logout.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.L), System.Windows.Forms.Keys)
        Me.Logout.Size = New System.Drawing.Size(57, 20)
        Me.Logout.Text = "&Logout"
        '
        'ExitSystem
        '
        Me.ExitSystem.Name = "ExitSystem"
        Me.ExitSystem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.ExitSystem.Size = New System.Drawing.Size(37, 20)
        Me.ExitSystem.Text = "&Exit"
        '
        'StatusStrip
        '
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 431)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(632, 22)
        Me.StatusStrip.TabIndex = 7
        Me.StatusStrip.Text = "StatusStrip"
        '
        'ToolStripStatusLabel
        '
        Me.ToolStripStatusLabel.Name = "ToolStripStatusLabel"
        Me.ToolStripStatusLabel.Size = New System.Drawing.Size(39, 17)
        Me.ToolStripStatusLabel.Text = "Status"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(219, 22)
        Me.ToolStripMenuItem1.Text = "ToolStripMenuItem1"
        '
        'OPDSoftware
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(632, 453)
        Me.Controls.Add(Me.MenuStrip)
        Me.Controls.Add(Me.StatusStrip)
        Me.DoubleBuffered = True
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "OPDSoftware"
        Me.Text = "OPD Software"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ExitSystem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Logout As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem29 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents ToolStripStatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripMenuItem12 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem11 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem10 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem7 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Master As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem8 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem9 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents Patient As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem50 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem51 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem52 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem53 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem54 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem55 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Reports As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem26 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem27 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Utilities As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem13 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem14 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem15 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolstripMenuItem16 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem17 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem56 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CompanyDetails As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DepartmentDetails As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CategoryDetails As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SubcategoryDetails As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PatientDetail As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PatientHistory As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PatientDiagnosisDetail As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PatientTestDetail As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PatientAppointmentDetail As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem28 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem57 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReceiptDetails As System.Windows.Forms.ToolStripMenuItem

End Class
