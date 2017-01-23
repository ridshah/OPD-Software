Imports System.Data
Imports System.Data.SqlClient
Imports System.Globalization

Public Class LOGIN_FORM
    Dim con As New SqlConnection("Data Source=.\sqlexpress;Initial Catalog=opdsys;Integrated Security=True")
    Dim adp As New SqlDataAdapter("", con)
    Dim DS As New DataSet
    Dim bs As BindingManagerBase
    Dim sql As String
    Dim cmd As New SqlCommand
    'Dim publictable As New DataTable
    Dim cl As New Class1
    Private Sub LOGIN_FORM_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextBox1.Text = ""
        TextBox2.Text = ""
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        DS.Clear()
       
        adp.SelectCommand.CommandText = "Select * from password_view"
        adp.Fill(DS, "password_view")
        bs = Me.BindingContext(DS, "password_view")

    End Sub
    Sub showall()
        OPDSoftware.Master.Visible = True
        OPDSoftware.Patient.Visible = True
        OPDSoftware.Utilities.Visible = True
        OPDSoftware.ToolStripMenuItem26.Visible = True
        OPDSoftware.ToolStripMenuItem27.Visible = True
        OPDSoftware.ToolStripMenuItem28.Visible = True
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        TextBox1.DataBindings.Clear()
        TextBox2.DataBindings.Clear()
        DS.Clear()



        If TextBox1.Text <> "" And TextBox2.Text <> "" Then
            adp.SelectCommand.CommandText = "select * from password_view where emp_name ='" + TextBox1.Text + "' and emp_password = '" + TextBox2.Text + "'"
           
            adp.Fill(DS, "password_view")
            bs = Me.BindingContext(DS, "password_view")

            If DS.Tables(0).Rows.Count > 0 Then
                Dim name As String
                cl.usertype = DS.Tables(0).Rows(0).Item(2)
                name = DS.Tables(0).Rows(0).Item(3)
                If cl.usertype = "admin" Then
                    MsgBox("Welcome Admin")
                    OPDSoftware.Show()
                    showall()

                ElseIf cl.usertype = "doctor" Then
                    MsgBox("Welcome Doctor")
                    OPDSoftware.Show()
                    showall()
                    OPDSoftware.Master.Visible = False
                    OPDSoftware.Utilities.Visible = False
                    OPDSoftware.ToolStripMenuItem26.Visible = False
                    OPDSoftware.ToolStripMenuItem28.Visible = False
                ElseIf cl.usertype = "receptionist" Then
                    MsgBox("Welcome Front Desk Staff")
                    OPDSoftware.Show()
                    showall()
                    OPDSoftware.Master.Visible = False
                    OPDSoftware.Utilities.Visible = False
                    OPDSoftware.ToolStripMenuItem51.Visible = False
                    OPDSoftware.ToolStripMenuItem52.Visible = False
                    OPDSoftware.ToolStripMenuItem53.Visible = False
                    OPDSoftware.ToolStripMenuItem54.Visible = False
                    OPDSoftware.ToolStripMenuItem55.Visible = False
                    OPDSoftware.ToolStripMenuItem28.Visible = False
                Else
                    MsgBox("Sorry! You are not authorized to access the system")
                End If

                Me.Hide()
            Else
                MsgBox("Invalid username and password")
                TextBox1.Text = ""
                TextBox2.Text = ""
            End If
            ElseIf TextBox1.Text = "" And TextBox2.Text = "" Then
                MsgBox("Please enter username and password")
                Me.Show()
                OPDSoftware.Hide()
            Else
                MsgBox("Invalid username and password!!")
                Me.Show()
                OPDSoftware.Hide()
            End If



    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Hide()
        forgotpassword.Show()

    End Sub


End Class