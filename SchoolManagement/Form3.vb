Imports System.Data.OleDb
Public Class Form3
    Private Sub Signupform3_Click(sender As Object, e As EventArgs) Handles Signupform3.Click
        Dim uname, pass As String
        Dim form2 As New Form2
        uname = TextBox1.Text
        pass = TextBox2.Text
        If (uname <> "" And pass <> "") Then
            Dim con As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\admin\source\repos\SchoolManagement\SchoolManagement\sclManagementSignUp.mdb")
            con.Open()
            Dim query As New OleDbCommand()
            query.Connection = con
            query.CommandType = CommandType.Text
            query.CommandText = "insert into signUp values ('" & uname & "','" & pass & "')"
            query.ExecuteNonQuery()
            con.Close()
            MessageBox.Show("Now you can login in school management system")
            form2.Show()
            Me.Close()
        Else
            MessageBox.Show("Please enter a valid credential")
        End If
    End Sub
End Class