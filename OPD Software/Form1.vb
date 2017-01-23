Imports System
Imports System.IO
Imports System.Text



Public Class Form1


   

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
       

        cmbserver.Text = ".\sqlexpress"
        cmbdatabase.Text = "opdsys"
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
       

        Dim path As String = "C:\Program Files (x86)\Microsoft SQL Server\MSSQL.1\MSSQL\Data\opdsys.mdf"
        Dim path2 As String = "C:\Users\DELL\Desktop\opdsysback.mdf"

        Try

            If File.Exists(path) = False Then
                ' This statement ensures that the file is created, 
                ' but the handle is not kept. 
                Dim fs As FileStream = File.Create(path)
                fs.Close()
            End If

          

            ' Ensure that the target does not exist. 
            If File.Exists(path2) Then
                File.Delete(path2)
            End If

           

            ' Move the file.
            File.Copy(path, path2)
            Console.WriteLine("{0} copied to {1}", path, path2)

            ' See if the original file exists now. 
            If File.Exists(path) Then
                Console.WriteLine("The original file still exists, which is expected.")
            Else
                Console.WriteLine("The original file no longer exists, which is unexpected.")
            End If

        Catch

        End Try
       

    End Sub
End Class