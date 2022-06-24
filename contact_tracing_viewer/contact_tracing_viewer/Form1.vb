Public Class Form1
    Private Sub readButton_Click(sender As Object, e As EventArgs) Handles readButton.Click
        Dim studentReader As System.IO.StreamReader
        Dim fileLastName As String = fileNameBox.Text

        ' if read file textbox are empty or as is
        If fileLastName = "" Or fileLastName = "Enter filename" Then
            readFileLabel.ForeColor = Color.Red
            MessageBox.Show("Enter filename.", "Information")

            ' goes to another condition
        Else
            readFileLabel.ForeColor = Color.Black
            fileLastName = ""
            fileLastName += fileNameBox.Text.ToUpper() + ".txt"

            ' check if filename is exist
            If System.IO.File.Exists("C:\Users\Rom\Desktop\5TH-YR-2ND-SEM\elec3\contact-tracing-vb\vb_contract_tracing\vb_contract_tracing\bin\Debug\" + fileLastName) Then
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

                ' if filename is not in directory 
            Else
                readFileLabel.ForeColor = Color.Red
                fullnameBox.Text = "Fullname"
                studentNoBox.Text = "Student Number"
                courseYrSecbox.Text = "Course/Year/Section"
                mobileNumBox.Text = "Mobile Number"
                birthGenderBox.Text = "Birthdate/Gender"
                addressBox.Text = "Address"
                MessageBox.Show(fileLastName + " not in directory, try again.", "Information")
            End If
        End If



    End Sub

    Private Sub closeButton_Click(sender As Object, e As EventArgs) Handles closeButton.Click
        Close()
    End Sub
End Class
