<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class employeerights
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(employeerights))
        Me.TextBox3 = New System.Windows.Forms.TextBox
        Me.Delete = New System.Windows.Forms.Button
        Me.Reset = New System.Windows.Forms.Button
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.EmployeemasterBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.OpdDataSet57 = New WindowsApplication1.opdDataSet57
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.EmployeemasterBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OpdDataSet14 = New WindowsApplication1.opdDataSet14
        Me.Label4 = New System.Windows.Forms.Label
        Me.last = New System.Windows.Forms.Button
        Me.next1 = New System.Windows.Forms.Button
        Me.previous = New System.Windows.Forms.Button
        Me.first = New System.Windows.Forms.Button
        Me.Edit = New System.Windows.Forms.Button
        Me.Employee_masterTableAdapter = New WindowsApplication1.opdDataSet14TableAdapters.employee_masterTableAdapter
        Me.View = New System.Windows.Forms.Button
        Me.AddNew = New System.Windows.Forms.Button
        Me.OpdDataSet31 = New WindowsApplication1.opdDataSet31
        Me.EmployeerightsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Employee_rightsTableAdapter = New WindowsApplication1.opdDataSet31TableAdapters.employee_rightsTableAdapter
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.Employee_masterTableAdapter1 = New WindowsApplication1.opdDataSet57TableAdapters.employee_masterTableAdapter
        Me.Panel1.SuspendLayout()
        CType(Me.EmployeemasterBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OpdDataSet57, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmployeemasterBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OpdDataSet14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OpdDataSet31, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmployeerightsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(509, 69)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(342, 20)
        Me.TextBox3.TabIndex = 2
        '
        'Delete
        '
        Me.Delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Delete.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Delete.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Delete.Image = CType(resources.GetObject("Delete.Image"), System.Drawing.Image)
        Me.Delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Delete.Location = New System.Drawing.Point(898, 212)
        Me.Delete.Name = "Delete"
        Me.Delete.Size = New System.Drawing.Size(85, 31)
        Me.Delete.TabIndex = 4
        Me.Delete.Text = "Delete"
        Me.Delete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Delete.UseVisualStyleBackColor = True
        '
        'Reset
        '
        Me.Reset.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Reset.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Reset.Image = CType(resources.GetObject("Reset.Image"), System.Drawing.Image)
        Me.Reset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Reset.Location = New System.Drawing.Point(1077, 212)
        Me.Reset.Name = "Reset"
        Me.Reset.Size = New System.Drawing.Size(82, 31)
        Me.Reset.TabIndex = 8
        Me.Reset.Text = "Reset"
        Me.Reset.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Reset.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.ComboBox1)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.TextBox3)
        Me.Panel1.Location = New System.Drawing.Point(92, 53)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1067, 119)
        Me.Panel1.TabIndex = 10
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.EmployeemasterBindingSource1
        Me.ComboBox1.DisplayMember = "emp_name"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(509, 28)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(342, 21)
        Me.ComboBox1.TabIndex = 6
        Me.ComboBox1.ValueMember = "emp_id"
        '
        'EmployeemasterBindingSource1
        '
        Me.EmployeemasterBindingSource1.DataMember = "employee_master"
        Me.EmployeemasterBindingSource1.DataSource = Me.OpdDataSet57
        '
        'OpdDataSet57
        '
        Me.OpdDataSet57.DataSetName = "opdDataSet57"
        Me.OpdDataSet57.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(229, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 19)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Table Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(229, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(133, 19)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Employee Name"
        '
        'EmployeemasterBindingSource
        '
        Me.EmployeemasterBindingSource.DataMember = "employee_master"
        Me.EmployeemasterBindingSource.DataSource = Me.OpdDataSet14
        '
        'OpdDataSet14
        '
        Me.OpdDataSet14.DataSetName = "opdDataSet14"
        Me.OpdDataSet14.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(111, 28)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(285, 24)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "EMPLOYEE RIGHTS DETAILS"
        '
        'last
        '
        Me.last.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.last.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.last.Location = New System.Drawing.Point(335, 211)
        Me.last.Name = "last"
        Me.last.Size = New System.Drawing.Size(75, 31)
        Me.last.TabIndex = 47
        Me.last.Text = ">>"
        Me.last.UseVisualStyleBackColor = True
        '
        'next1
        '
        Me.next1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.next1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.next1.Location = New System.Drawing.Point(254, 211)
        Me.next1.Name = "next1"
        Me.next1.Size = New System.Drawing.Size(75, 31)
        Me.next1.TabIndex = 46
        Me.next1.Text = ">"
        Me.next1.UseVisualStyleBackColor = True
        '
        'previous
        '
        Me.previous.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.previous.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.previous.Location = New System.Drawing.Point(173, 212)
        Me.previous.Name = "previous"
        Me.previous.Size = New System.Drawing.Size(75, 31)
        Me.previous.TabIndex = 45
        Me.previous.Text = "<"
        Me.previous.UseVisualStyleBackColor = True
        '
        'first
        '
        Me.first.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.first.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.first.Location = New System.Drawing.Point(92, 211)
        Me.first.Name = "first"
        Me.first.Size = New System.Drawing.Size(75, 31)
        Me.first.TabIndex = 44
        Me.first.Text = "<<"
        Me.first.UseVisualStyleBackColor = True
        '
        'Edit
        '
        Me.Edit.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Edit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Edit.Image = Global.WindowsApplication1.My.Resources.Resources.edit
        Me.Edit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Edit.Location = New System.Drawing.Point(980, 212)
        Me.Edit.Name = "Edit"
        Me.Edit.Size = New System.Drawing.Size(97, 31)
        Me.Edit.TabIndex = 48
        Me.Edit.Text = "Edit"
        Me.Edit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Edit.UseVisualStyleBackColor = True
        '
        'Employee_masterTableAdapter
        '
        Me.Employee_masterTableAdapter.ClearBeforeFill = True
        '
        'View
        '
        Me.View.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.View.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.View.Image = CType(resources.GetObject("View.Image"), System.Drawing.Image)
        Me.View.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.View.Location = New System.Drawing.Point(715, 212)
        Me.View.Name = "View"
        Me.View.Size = New System.Drawing.Size(75, 31)
        Me.View.TabIndex = 56
        Me.View.Text = "View"
        Me.View.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.View.UseVisualStyleBackColor = True
        '
        'AddNew
        '
        Me.AddNew.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddNew.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.AddNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.AddNew.Location = New System.Drawing.Point(791, 212)
        Me.AddNew.Name = "AddNew"
        Me.AddNew.Size = New System.Drawing.Size(107, 31)
        Me.AddNew.TabIndex = 55
        Me.AddNew.Text = "Add New"
        Me.AddNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.AddNew.UseVisualStyleBackColor = True
        '
        'OpdDataSet31
        '
        Me.OpdDataSet31.DataSetName = "opdDataSet31"
        Me.OpdDataSet31.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EmployeerightsBindingSource
        '
        Me.EmployeerightsBindingSource.DataMember = "employee_rights"
        Me.EmployeerightsBindingSource.DataSource = Me.OpdDataSet31
        '
        'Employee_rightsTableAdapter
        '
        Me.Employee_rightsTableAdapter.ClearBeforeFill = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(407, 268)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(334, 150)
        Me.DataGridView1.TabIndex = 57
        '
        'Employee_masterTableAdapter1
        '
        Me.Employee_masterTableAdapter1.ClearBeforeFill = True
        '
        'employeerights
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(1247, 489)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.View)
        Me.Controls.Add(Me.AddNew)
        Me.Controls.Add(Me.Edit)
        Me.Controls.Add(Me.last)
        Me.Controls.Add(Me.next1)
        Me.Controls.Add(Me.previous)
        Me.Controls.Add(Me.first)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Reset)
        Me.Controls.Add(Me.Delete)
        Me.Name = "employeerights"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Employee Rights Master"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.EmployeemasterBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OpdDataSet57, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmployeemasterBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OpdDataSet14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OpdDataSet31, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmployeerightsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Delete As System.Windows.Forms.Button
    Friend WithEvents Reset As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents last As System.Windows.Forms.Button
    Friend WithEvents next1 As System.Windows.Forms.Button
    Friend WithEvents previous As System.Windows.Forms.Button
    Friend WithEvents first As System.Windows.Forms.Button
    Friend WithEvents Edit As System.Windows.Forms.Button
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents OpdDataSet14 As WindowsApplication1.opdDataSet14
    Friend WithEvents EmployeemasterBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Employee_masterTableAdapter As WindowsApplication1.opdDataSet14TableAdapters.employee_masterTableAdapter
    Friend WithEvents View As System.Windows.Forms.Button
    Friend WithEvents AddNew As System.Windows.Forms.Button
    Friend WithEvents OpdDataSet31 As WindowsApplication1.opdDataSet31
    Friend WithEvents EmployeerightsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Employee_rightsTableAdapter As WindowsApplication1.opdDataSet31TableAdapters.employee_rightsTableAdapter
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents OpdDataSet57 As WindowsApplication1.opdDataSet57
    Friend WithEvents EmployeemasterBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents Employee_masterTableAdapter1 As WindowsApplication1.opdDataSet57TableAdapters.employee_masterTableAdapter
End Class
