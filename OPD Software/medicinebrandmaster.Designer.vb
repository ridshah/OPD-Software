<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class medicinebrandmaster
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
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.MedicinebrandmasterBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OpdDataSet24 = New WindowsApplication1.opdDataSet24
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.last = New System.Windows.Forms.Button
        Me.next1 = New System.Windows.Forms.Button
        Me.previous = New System.Windows.Forms.Button
        Me.first = New System.Windows.Forms.Button
        Me.Edit = New System.Windows.Forms.Button
        Me.Reset = New System.Windows.Forms.Button
        Me.Medicinebrand_masterTableAdapter = New WindowsApplication1.opdDataSet24TableAdapters.medicinebrand_masterTableAdapter
        Me.View = New System.Windows.Forms.Button
        Me.AddNew = New System.Windows.Forms.Button
        Me.ComboBox3 = New System.Windows.Forms.ComboBox
        Me.Panel1.SuspendLayout()
        CType(Me.MedicinebrandmasterBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OpdDataSet24, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(493, 82)
        Me.TextBox3.Multiline = True
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox3.Size = New System.Drawing.Size(308, 77)
        Me.TextBox3.TabIndex = 19
        '
        'Delete
        '
        Me.Delete.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Delete.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Delete.Image = Global.WindowsApplication1.My.Resources.Resources.delete2
        Me.Delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Delete.Location = New System.Drawing.Point(861, 294)
        Me.Delete.Name = "Delete"
        Me.Delete.Size = New System.Drawing.Size(90, 30)
        Me.Delete.TabIndex = 15
        Me.Delete.Text = "Delete"
        Me.Delete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Delete.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.ComboBox3)
        Me.Panel1.Controls.Add(Me.ComboBox1)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.TextBox3)
        Me.Panel1.Location = New System.Drawing.Point(145, 56)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(985, 217)
        Me.Panel1.TabIndex = 21
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.MedicinebrandmasterBindingSource
        Me.ComboBox1.DisplayMember = "brand_name"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(493, 44)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(308, 21)
        Me.ComboBox1.TabIndex = 25
        Me.ComboBox1.ValueMember = "brand_id"
        '
        'MedicinebrandmasterBindingSource
        '
        Me.MedicinebrandmasterBindingSource.DataMember = "medicinebrand_master"
        Me.MedicinebrandmasterBindingSource.DataSource = Me.OpdDataSet24
        '
        'OpdDataSet24
        '
        Me.OpdDataSet24.DataSetName = "opdDataSet24"
        Me.OpdDataSet24.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(171, 174)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 19)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "Status"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(171, 86)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 19)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Description"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(171, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 19)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Brand Name"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label7.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(190, 38)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(265, 24)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "MEDICINE BRAND MASTER"
        '
        'last
        '
        Me.last.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.last.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.last.Location = New System.Drawing.Point(388, 293)
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
        Me.next1.Location = New System.Drawing.Point(307, 293)
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
        Me.previous.Location = New System.Drawing.Point(226, 293)
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
        Me.first.Location = New System.Drawing.Point(145, 292)
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
        Me.Edit.Location = New System.Drawing.Point(950, 294)
        Me.Edit.Name = "Edit"
        Me.Edit.Size = New System.Drawing.Size(98, 30)
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
        Me.Reset.Location = New System.Drawing.Point(1048, 294)
        Me.Reset.Name = "Reset"
        Me.Reset.Size = New System.Drawing.Size(82, 30)
        Me.Reset.TabIndex = 49
        Me.Reset.Text = "Reset"
        Me.Reset.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Reset.UseVisualStyleBackColor = True
        '
        'Medicinebrand_masterTableAdapter
        '
        Me.Medicinebrand_masterTableAdapter.ClearBeforeFill = True
        '
        'View
        '
        Me.View.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.View.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.View.Image = Global.WindowsApplication1.My.Resources.Resources.view
        Me.View.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.View.Location = New System.Drawing.Point(681, 294)
        Me.View.Name = "View"
        Me.View.Size = New System.Drawing.Size(75, 30)
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
        Me.AddNew.Location = New System.Drawing.Point(756, 294)
        Me.AddNew.Name = "AddNew"
        Me.AddNew.Size = New System.Drawing.Size(106, 30)
        Me.AddNew.TabIndex = 57
        Me.AddNew.Text = "Add New"
        Me.AddNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.AddNew.UseVisualStyleBackColor = True
        '
        'ComboBox3
        '
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Items.AddRange(New Object() {"Yes", "No"})
        Me.ComboBox3.Location = New System.Drawing.Point(493, 175)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(308, 21)
        Me.ComboBox3.TabIndex = 46
        '
        'medicinebrandmaster
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(1263, 395)
        Me.Controls.Add(Me.View)
        Me.Controls.Add(Me.AddNew)
        Me.Controls.Add(Me.Reset)
        Me.Controls.Add(Me.Edit)
        Me.Controls.Add(Me.last)
        Me.Controls.Add(Me.next1)
        Me.Controls.Add(Me.previous)
        Me.Controls.Add(Me.first)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Delete)
        Me.Name = "medicinebrandmaster"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Medicine Brand Master"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.MedicinebrandmasterBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OpdDataSet24, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Delete As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents last As System.Windows.Forms.Button
    Friend WithEvents next1 As System.Windows.Forms.Button
    Friend WithEvents previous As System.Windows.Forms.Button
    Friend WithEvents first As System.Windows.Forms.Button
    Friend WithEvents Edit As System.Windows.Forms.Button
    Friend WithEvents Reset As System.Windows.Forms.Button
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents OpdDataSet24 As WindowsApplication1.opdDataSet24
    Friend WithEvents MedicinebrandmasterBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Medicinebrand_masterTableAdapter As WindowsApplication1.opdDataSet24TableAdapters.medicinebrand_masterTableAdapter
    Friend WithEvents View As System.Windows.Forms.Button
    Friend WithEvents AddNew As System.Windows.Forms.Button
    Friend WithEvents ComboBox3 As System.Windows.Forms.ComboBox
End Class
