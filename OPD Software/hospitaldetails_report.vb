Imports System.Data
Imports System.Data.SqlClient

Public Class hospitaldetails_report
    Dim con As New SqlConnection("Data Source=.\sqlexpress;Initial Catalog=opdsys;Integrated Security=True")
    Dim adp As New SqlDataAdapter("", con)
    Dim DS As New DataSet
    Dim bs As BindingManagerBase
    Private Sub Form4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'OpdDataSet35.company_master' table. You can move, or remove it, as needed.
        Me.Company_masterTableAdapter.Fill(Me.OpdDataSet35.company_master)
        ComboBox1.Enabled = False
        ComboBox2.Enabled = False
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        DS.Clear()
        If RadioButton1.Checked = True Then
            If Trim(ComboBox1.Text) <> "" And Trim(ComboBox2.Text) = "" Then
                adp.SelectCommand.CommandText = "select cmp_name as CompanyName,cmp_address as Address,cmp_city as City,cmp_state as State,cmp_country as Country,cmp_email as Email,cmp_reception as ReceptionDesk,cmp_fax as FaxNumber from company_master where cmp_name='" + ComboBox1.Text + "'"
            ElseIf Trim(ComboBox2.Text) <> "" And Trim(ComboBox1.Text) = "" Then
                adp.SelectCommand.CommandText = "select cmp_name as CompanyName,cmp_address as Address,cmp_city as City,cmp_state as State,cmp_country as Country,cmp_email as Email,cmp_reception as ReceptionDesk,cmp_fax as FaxNumber from company_master where cmp_state='" + ComboBox2.Text + "'"
            ElseIf Trim(ComboBox1.Text) <> "" And Trim(ComboBox2.Text) <> "" Then
                adp.SelectCommand.CommandText = "select cmp_name as CompanyName,cmp_address as Address,cmp_city as City,cmp_state as State,cmp_country as Country,cmp_email as Email,cmp_reception as ReceptionDesk,cmp_fax as FaxNumber from company_master where cmp_name='" + ComboBox1.Text + "' and cmp_state='" + ComboBox2.Text + "'"
            ElseIf Trim(ComboBox1.Text) = "" And Trim(ComboBox2.Text) = "" Then
                MsgBox("All fields are empty!!")
            End If
        ElseIf RadioButton2.Checked = True Then
            adp.SelectCommand.CommandText = "select cmp_name as CompanyName,cmp_address as Address,cmp_city as City,cmp_state as State,cmp_country as Country,cmp_email as Email,cmp_reception as ReceptionDesk,cmp_fax as FaxNumber from company_master"
        End If
        adp.Fill(DS, "company_master")
        DataGridView1.DataSource = Nothing
        DataGridView1.DataSource = DS
        DataGridView1.DataMember = "company_master"
        bs = Me.BindingContext(DS, "company_master")
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        hospitalreportview.Show()
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked = True Then
            ComboBox1.Enabled = False
            ComboBox2.Enabled = False
            ComboBox1.Text = ""
            ComboBox2.Text = ""
        End If
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked = True Then
            ComboBox1.Enabled = True
            ComboBox2.Enabled = True
        End If
    End Sub
End Class