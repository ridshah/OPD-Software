<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class medicinemaster
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
        Me.TextBox3 = New System.Windows.Forms.TextBox
        Me.Delete = New System.Windows.Forms.Button
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.ComboBox4 = New System.Windows.Forms.ComboBox
        Me.MedicinemasterBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OpdDataSet23 = New WindowsApplication1.opdDataSet23
        Me.ComboBox3 = New System.Windows.Forms.ComboBox
        Me.MedicinebrandmasterBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OpdDataSet17 = New WindowsApplication1.opdDataSet17
        Me.ComboBox2 = New System.Windows.Forms.ComboBox
        Me.SubcategorymasterBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OpdDataSet16 = New WindowsApplication1.opdDataSet16
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.CategorymasterBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OpdDataSet15 = New WindowsApplication1.opdDataSet15
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.last = New System.Windows.Forms.Button
        Me.s = New System.Windows.Forms.Button
        Me.previous = New System.Windows.Forms.Button
        Me.first = New System.Windows.Forms.Button
        Me.Edit = New System.Windows.Forms.Button
        Me.Reset = New System.Windows.Forms.Button
        Me.Category_masterTableAdapter = New WindowsApplication1.opdDataSet15TableAdapters.category_masterTableAdapter
        Me.Subcategory_masterTableAdapter = New WindowsApplication1.opdDataSet16TableAdapters.subcategory_masterTableAdapter
        Me.Medicinebrand_masterTableAdapter = New WindowsApplication1.opdDataSet17TableAdapters.medicinebrand_masterTableAdapter
        Me.Medicine_masterTableAdapter = New WindowsApplication1.opdDataSet23TableAdapters.medicine_masterTableAdapter
        Me.View = New System.Windows.Forms.Button
        Me.AddNew = New System.Windows.Forms.Button
        Me.Panel1.SuspendLayout()
        CType(Me.MedicinemasterBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OpdDataSet23, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MedicinebrandmasterBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OpdDataSet17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SubcategorymasterBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OpdDataSet16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CategorymasterBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OpdDataSet15, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(543, 70)
        Me.TextBox3.Multiline = True
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox3.Size = New System.Drawing.Size(237, 107)
        Me.TextBox3.TabIndex = 19
        '
        'Delete
        '
        Me.Delete.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Delete.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Delete.Image = Global.WindowsApplication1.My.Resources.Resources.delete2
        Me.Delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Delete.Location = New System.Drawing.Point(856, 397)
        Me.Delete.Name = "Delete"
        Me.Delete.Size = New System.Drawing.Size(87, 28)
        Me.Delete.TabIndex = 15
        Me.Delete.Text = "Delete"
        Me.Delete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Delete.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.ComboBox4)
        Me.Panel1.Controls.Add(Me.ComboBox3)
        Me.Panel1.Controls.Add(Me.ComboBox2)
        Me.Panel1.Controls.Add(Me.ComboBox1)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.TextBox3)
        Me.Panel1.Location = New System.Drawing.Point(142, 48)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(971, 323)
        Me.Panel1.TabIndex = 23
        '
        'ComboBox4
        '
        Me.ComboBox4.DataSource = Me.MedicinemasterBindingSource
        Me.ComboBox4.DisplayMember = "medicine_name"
        Me.ComboBox4.FormattingEnabled = True
        Me.ComboBox4.Location = New System.Drawing.Point(543, 37)
        Me.ComboBox4.Name = "ComboBox4"
        Me.ComboBox4.Size = New System.Drawing.Size(237, 21)
        Me.ComboBox4.TabIndex = 32
        Me.ComboBox4.ValueMember = "medicine_id"
        '
        'MedicinemasterBindingSource
        '
        Me.MedicinemasterBindingSource.DataMember = "medicine_master"
        Me.MedicinemasterBindingSource.DataSource = Me.OpdDataSet23
        '
        'OpdDataSet23
        '
        Me.OpdDataSet23.DataSetName = "opdDataSet23"
        Me.OpdDataSet23.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ComboBox3
        '
        Me.ComboBox3.DataSource = Me.MedicinebrandmasterBindingSource
        Me.ComboBox3.DisplayMember = "brand_name"
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Location = New System.Drawing.Point(543, 266)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(237, 21)
        Me.ComboBox3.TabIndex = 31
        Me.ComboBox3.ValueMember = "brand_id"
        '
        'MedicinebrandmasterBindingSource
        '
        Me.MedicinebrandmasterBindingSource.DataMember = "medicinebrand_master"
        Me.MedicinebrandmasterBindingSource.DataSource = Me.OpdDataSet17
        '
        'OpdDataSet17
        '
        Me.OpdDataSet17.DataSetName = "opdDataSet17"
        Me.OpdDataSet17.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ComboBox2
        '
        Me.ComboBox2.DataSource = Me.SubcategorymasterBindingSource
        Me.ComboBox2.DisplayMember = "subcategory_name"
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(543, 231)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(237, 21)
        Me.ComboBox2.TabIndex = 30
        Me.ComboBox2.ValueMember = "subcategory_id"
        '
        'SubcategorymasterBindingSource
        '
        Me.SubcategorymasterBindingSource.DataMember = "subcategory_master"
        Me.SubcategorymasterBindingSource.DataSource = Me.OpdDataSet16
        '
        'OpdDataSet16
        '
        Me.OpdDataSet16.DataSetName = "opdDataSet16"
        Me.OpdDataSet16.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.CategorymasterBindingSource
        Me.ComboBox1.DisplayMember = "category_name"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(543, 195)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(237, 21)
        Me.ComboBox1.TabIndex = 29
        Me.ComboBox1.ValueMember = "category_id"
        '
        'CategorymasterBindingSource
        '
        Me.CategorymasterBindingSource.DataMember = "category_master"
        Me.CategorymasterBindingSource.DataSource = Me.OpdDataSet15
        '
        'OpdDataSet15
        '
        Me.OpdDataSet15.DataSetName = "opdDataSet15"
        Me.OpdDataSet15.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(179, 271)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(104, 19)
        Me.Label6.TabIndex = 28
        Me.Label6.Text = "Brand Name"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(179, 236)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(155, 19)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "Subcategory Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(179, 200)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(127, 19)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "Category Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(179, 76)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 19)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Description"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(179, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(125, 19)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Medicine Name"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label7.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(193, 31)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(193, 24)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "MEDICINE MASTER"
        '
        'last
        '
        Me.last.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.last.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.last.Location = New System.Drawing.Point(385, 392)
        Me.last.Name = "last"
        Me.last.Size = New System.Drawing.Size(75, 31)
        Me.last.TabIndex = 47
        Me.last.Text = ">>"
        Me.last.UseVisualStyleBackColor = True
        '
        's
        '
        Me.s.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.s.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.s.Location = New System.Drawing.Point(304, 392)
        Me.s.Name = "s"
        Me.s.Size = New System.Drawing.Size(75, 31)
        Me.s.TabIndex = 46
        Me.s.Text = ">"
        Me.s.UseVisualStyleBackColor = True
        '
        'previous
        '
        Me.previous.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.previous.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.previous.Location = New System.Drawing.Point(223, 392)
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
        Me.first.Location = New System.Drawing.Point(142, 392)
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
        Me.Edit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Edit.Location = New System.Drawing.Point(941, 397)
        Me.Edit.Name = "Edit"
        Me.Edit.Size = New System.Drawing.Size(97, 28)
        Me.Edit.TabIndex = 48
        Me.Edit.Text = "Edit"
        Me.Edit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Edit.UseVisualStyleBackColor = True
        '
        'Reset
        '
        Me.Reset.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Reset.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Reset.Image = Global.WindowsApplication1.My.Resources.Resources.reset
        Me.Reset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Reset.Location = New System.Drawing.Point(1038, 397)
        Me.Reset.Name = "Reset"
        Me.Reset.Size = New System.Drawing.Size(81, 28)
        Me.Reset.TabIndex = 49
        Me.Reset.Text = "Reset"
        Me.Reset.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Reset.UseVisualStyleBackColor = True
        '
        'Category_masterTableAdapter
        '
        Me.Category_masterTableAdapter.ClearBeforeFill = True
        '
        'Subcategory_masterTableAdapter
        '
        Me.Subcategory_masterTableAdapter.ClearBeforeFill = True
        '
        'Medicinebrand_masterTableAdapter
        '
        Me.Medicinebrand_masterTableAdapter.ClearBeforeFill = True
        '
        'Medicine_masterTableAdapter
        '
        Me.Medicine_masterTableAdapter.ClearBeforeFill = True
        '
        'View
        '
        Me.View.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.View.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.View.Image = Global.WindowsApplication1.My.Resources.Resources.view
        Me.View.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.View.Location = New System.Drawing.Point(678, 397)
        Me.View.Name = "View"
        Me.View.Size = New System.Drawing.Size(75, 28)
        Me.View.TabIndex = 58
        Me.View.Text = "View"
        Me.View.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.View.UseVisualStyleBackColor = True
        '
        'AddNew
        '
        Me.AddNew.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddNew.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.AddNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.AddNew.Location = New System.Drawing.Point(752, 397)
        Me.AddNew.Name = "AddNew"
        Me.AddNew.Size = New System.Drawing.Size(108, 28)
        Me.AddNew.TabIndex = 57
        Me.AddNew.Text = "Add New"
        Me.AddNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.AddNew.UseVisualStyleBackColor = True
        '
        'medicinemaster
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(1247, 506)
        Me.Controls.Add(Me.View)
        Me.Controls.Add(Me.AddNew)
        Me.Controls.Add(Me.Reset)
        Me.Controls.Add(Me.Edit)
        Me.Controls.Add(Me.last)
        Me.Controls.Add(Me.s)
        Me.Controls.Add(Me.previous)
        Me.Controls.Add(Me.first)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Delete)
        Me.Name = "medicinemaster"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Medicine Master"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.MedicinemasterBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OpdDataSet23, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MedicinebrandmasterBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OpdDataSet17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SubcategorymasterBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OpdDataSet16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CategorymasterBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OpdDataSet15, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Delete As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents last As System.Windows.Forms.Button
    Friend WithEvents s As System.Windows.Forms.Button
    Friend WithEvents previous As System.Windows.Forms.Button
    Friend WithEvents first As System.Windows.Forms.Button
    Friend WithEvents Edit As System.Windows.Forms.Button
    Friend WithEvents Reset As System.Windows.Forms.Button
    Friend WithEvents ComboBox3 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents OpdDataSet15 As WindowsApplication1.opdDataSet15
    Friend WithEvents CategorymasterBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Category_masterTableAdapter As WindowsApplication1.opdDataSet15TableAdapters.category_masterTableAdapter
    Friend WithEvents OpdDataSet16 As WindowsApplication1.opdDataSet16
    Friend WithEvents SubcategorymasterBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Subcategory_masterTableAdapter As WindowsApplication1.opdDataSet16TableAdapters.subcategory_masterTableAdapter
    Friend WithEvents OpdDataSet17 As WindowsApplication1.opdDataSet17
    Friend WithEvents MedicinebrandmasterBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Medicinebrand_masterTableAdapter As WindowsApplication1.opdDataSet17TableAdapters.medicinebrand_masterTableAdapter
    Friend WithEvents ComboBox4 As System.Windows.Forms.ComboBox
    Friend WithEvents OpdDataSet23 As WindowsApplication1.opdDataSet23
    Friend WithEvents MedicinemasterBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Medicine_masterTableAdapter As WindowsApplication1.opdDataSet23TableAdapters.medicine_masterTableAdapter
    Friend WithEvents View As System.Windows.Forms.Button
    Friend WithEvents AddNew As System.Windows.Forms.Button
End Class
