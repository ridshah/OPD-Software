Imports System.Data
Imports System.Data.SqlClient

Partial Class patientlogin
    Inherits System.Web.UI.Page

    Dim con As New SqlConnection("Data Source=.\sqlexpress;Initial Catalog=opdsys;Integrated Security=True")
    Protected Sub Login1_Authenticate(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.AuthenticateEventArgs) Handles Login1.Authenticate
        Dim cmd As String = "select * from viewdetails where patient_name='" + Login1.UserName + "' and patient_dob='" + Login1.Password + "' "
        Dim adp As New SqlDataAdapter(cmd, con)
        Dim ds As New DataSet()
        adp.Fill(ds)

        If ds.Tables(0).Rows.Count > 0 Then
            Session("patientId") = ds.Tables(0).Rows(0).Item(0).ToString()
            Response.Redirect("viewdetails.aspx")

        End If
    End Sub

   
End Class
