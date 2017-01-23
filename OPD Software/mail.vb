Imports System.Net
Imports System.IO
Imports System.Net.Mail
Public Class mail

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim smtpServer As New SmtpClient()
        Dim mail As New MailMessage
        smtpServer.Credentials = New Net.NetworkCredential(TextBox1.Text & "@gmail.com", TextBox2.Text)
        smtpServer.Port = 587
        smtpServer.Host = "smtp.gmail.com"
        smtpServer.EnableSsl = True


        mail.From = New MailAddress(TextBox1.Text & "@gmail.com")
        mail.To.Add(TextBox3.Text)
        'End If
        mail.Subject = "appointment registered"
        mail.Body = "Your appointment has been registered for " + appointmentmaster.DateTimePicker1.Text + " Thank you!"
        smtpServer.Send(mail)
        MsgBox("mail is sent", MsgBoxStyle.OkOnly, "Report")

        Me.Close()


    End Sub

    Private Sub mail_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class