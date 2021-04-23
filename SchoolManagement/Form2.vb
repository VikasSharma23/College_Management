Imports System.Data.OleDb
Public Class Form2
    Private Sub Signup_Click(sender As Object, e As EventArgs) Handles Signup.Click
        Dim form3 As New Form3
        form3.Show()
        Me.Close()
    End Sub

    Private Sub logIn_Click(sender As Object, e As EventArgs) Handles logIn.Click
        Dim uname, pass, Checkpassword As String
        Checkpassword = ""
        Dim form1 As New Form1
        uname = TextBox1.Text
        pass = TextBox2.Text
        If (uname <> "" And pass <> "") Then
            Dim reader As OleDbDataReader
            Dim con As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\admin\source\repos\SchoolManagement\SchoolManagement\sclManagementSignUp.mdb")
            con.Open()
            Dim query As New OleDbCommand()
            query.Connection = con
            query.CommandType = CommandType.Text
            query.CommandText = "select password from signUp where username='" & uname & "'"
            reader = query.ExecuteReader
            Do While reader.Read
                Checkpassword = reader("Password")
            Loop
            con.Close()
            If pass.Equals(Checkpassword) Then
                form1.Show()
                Me.Close()
            Else
                MessageBox.Show("Please enter a valid credential")
            End If
        Else
            MessageBox.Show("Please enter a valid credential")
        End If
        form1.RichTextBox2.Text = "Hello, " & uname
    End Sub
End Class