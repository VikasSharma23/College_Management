Imports System.Data.OleDb
Public Class Form1
    Dim nOstu, nOfath, fathOccu,
    eMail, conNum, add, natio, yOfPa10, yOfPa12, gen, msgText As String

    Private Sub Reset_Click(sender As Object, e As EventArgs) Handles Reset.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        RichTextBox1.Clear()
        RichTextBox4.Clear()
        TextBox10.Clear()
        TextBox6.Clear()
        TextBox7.Clear()
    End Sub

    Private Sub GenerateReceipt_Click(sender As Object, e As EventArgs) Handles GenerateReceipt.Click
        nOstu = TextBox1.Text
        nOfath = TextBox2.Text
        fathOccu = TextBox3.Text
        eMail = TextBox4.Text
        conNum = TextBox5.Text
        add = RichTextBox1.Text
        natio = TextBox10.Text
        yOfPa10 = TextBox6.Text
        yOfPa12 = TextBox7.Text
        If RadioButton1.Checked = True Then
            gen = "Male"

        ElseIf RadioButton2.Checked = True Then
            gen = "Female"
        Else
            gen = ""
        End If
        msgText = "---------------------------------Receipt-------------------------" & vbCr & "Student Name:" & nOstu & "" & vbCr & "Father Name:" & nOfath & "" & vbCr & "Father Occupation:" & fathOccu & "" & vbCr & "E-Mail ID:" & eMail & "" & vbCr & "Contact Number:" & conNum & "" & vbCr & "Address:" & add & "" & vbCr & "Gender:" & gen & "" & vbCr & "Nationality:" & natio & "" & vbCr & "Year of passing 10th:" & yOfPa10 & "" & vbCr & "Year of passing 12th:" & yOfPa12 & "" & vbCr & "Course:" & ComboBoxCourse.Text
        RichTextBox4.Text = msgText
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim con As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\admin\source\repos\SchoolManagement\SchoolManagement\student_info.mdb")
        con.Open()
        Dim query As New OleDbCommand()
        query.Connection = con
        query.CommandType = CommandType.Text
        query.CommandText = "insert into info values ('" & nOstu & "','" & nOfath & "','" & fathOccu & "','" & eMail & "','" & conNum & "','" & add & "','" & gen & "','" & natio & "','" & yOfPa10 & "','" & yOfPa12 & "','" & ComboBoxCourse.Text & "')"
        query.ExecuteNonQuery()
        con.Close()
        MessageBox.Show("Your informatino is save successfully in databse")
        Me.Close()
    End Sub
End Class
