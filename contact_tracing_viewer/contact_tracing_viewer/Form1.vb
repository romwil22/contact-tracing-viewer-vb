Public Class Form1
    Private Sub readButton_Click(sender As Object, e As EventArgs) Handles readButton.Click
        Dim studentReader As System.IO.StreamReader
        Dim fileLastName As String = fileNameBox.Text.ToUpper() + ".txt" ' filename of text file
        studentReader = My.Computer.FileSystem.OpenTextFileReader("C:\Users\Rom\Desktop\5TH-YR-2ND-SEM\elec3\contact-tracing-vb\vb_contract_tracing\vb_contract_tracing\bin\Debug\" + fileLastName)

        Dim fullName As String = studentReader.ReadLine()
        fullnameBox.Text = fullName

        Dim studentNo As String
        studentNo = studentReader.ReadLine()
        studentNoBox.Text = studentNo

        Dim courseYrSec As String
        courseYrSec = studentReader.ReadLine()
        courseYrSecbox.Text = courseYrSec

        Dim mobileNum As String
        mobileNum = studentReader.ReadLine()
        mobileNumBox.Text = mobileNum

        Dim birthGender As String
        birthGender = studentReader.ReadLine()
        birthGenderBox.Text = birthGender

        Dim address As String
        address = studentReader.ReadLine()
        address += " " + studentReader.ReadLine()
        addressBox.Text = address

    End Sub

    Private Sub closeButton_Click(sender As Object, e As EventArgs) Handles closeButton.Click
        Close()
    End Sub
End Class
