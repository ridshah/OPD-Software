Imports System.Data
Imports System.Data.SqlClient
Public Class forgotpassword
    Dim con As New SqlConnection("Data Source=.\sqlexpress;Initial Catalog=opdsys;Integrated Security=True")
    Dim adp As New SqlDataAdapter("", con)
    Dim DS As New DataSet
    Dim bs As BindingManagerBase
    Dim cmd As New SqlCommand
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Hide()
        LOGIN_FORM.Show()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        DateTimePicker1.DataBindings.Clear()
        DS.Clear()

        adp.SelectCommand.CommandText = "select * from password_view where emp_dob ='" + DateTimePicker1.Text + "'"
        adp.Fill(DS, "password_view")
        bs = Me.BindingContext(DS, "password_view")

        If DS.Tables(0).Rows.Count > 0 Then
            Dim dob As String
            Dim pswd As String
            dob = DS.Tables(0).Rows(0).Item(1)
            pswd = DS.Tables(0).Rows(0).Item(0)
            MsgBox("Your password is '" + pswd + "'.", MsgBoxStyle.Information, "Password")
            Me.Close()
            LOGIN_FORM.Show()
        End If
    End Sub

    Private Sub forgotpassword_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        DS.Clear()

        adp.SelectCommand.CommandText = "Select * from password_view"
        adp.Fill(DS, "password_view")
        bs = Me.BindingContext(DS, "password_view")
    End Sub
End Class