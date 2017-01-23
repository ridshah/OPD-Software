Imports System.Data
Imports System.Data.SqlClient

Public Class categorydetails_report
    Dim con As New SqlConnection("Data Source=.\sqlexpress;Initial Catalog=opdsys;Integrated Security=True")
    Dim adp As New SqlDataAdapter("", con)
    Dim DS As New DataSet
    Dim bs As BindingManagerBase

    

    Private Sub categorydetails_report_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'OpdDataSet37.category_master' table. You can move, or remove it, as needed.
        Me.Category_masterTableAdapter.Fill(Me.OpdDataSet37.category_master)
        ComboBox1.Enabled = False
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        DS.Clear()
        If RadioButton1.Checked = True Then

            If Trim(ComboBox1.Text) <> "" Then
                adp.SelectCommand.CommandText = "select category_id as CategoryID,category_name as CategoryName,category_description as Description from category_master where category_name='" + ComboBox1.Text + "'"
            ElseIf Trim(ComboBox1.Text) = "" Then
                MsgBox("Field empty!!")
            End If
        ElseIf RadioButton2.Checked = True Then

            adp.SelectCommand.CommandText = "select category_id as CategoryID,category_name as CategoryName,category_description as Description from category_master "
        End If
        adp.Fill(DS, "category_master")
        DataGridView1.DataSource = Nothing
        DataGridView1.DataSource = DS
        DataGridView1.DataMember = "category_master"
        bs = Me.BindingContext(DS, "category_master")
    End Sub

   

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        categoryreportview.Show()
    End Sub

    
    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked = True Then
            ComboBox1.Enabled = True
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked = True Then
            ComboBox1.Enabled = False
            ComboBox1.Text = ""
        End If
    End Sub
End Class