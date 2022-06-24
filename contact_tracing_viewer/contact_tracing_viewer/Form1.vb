Public Class Form1
    Private Sub readButton_Click(sender As Object, e As EventArgs) Handles readButton.Click
        Dim studentReader As System.IO.StreamReader
        Dim fileLastName As String = fileNameBox.Text.ToUpper() + ".txt"
        studentReader = My.Computer.FileSystem.OpenTextFileReader("C:\Users\Rom\Desktop\5TH-YR-2ND-SEM\elec3\contact-tracing-vb\vb_contract_tracing\vb_contract_tracing\bin\Debug\" + fileLastName)

        'readTextFileRichBox.Text = studentReader.ReadToEnd()
        readTextFileRichBox.Text = studentReader.ReadLine()
        readTextFileRichBox.Text += vbNewLine + studentReader.ReadLine()
        readTextFileRichBox.Text += vbNewLine + studentReader.ReadLine()
        readTextFileRichBox.Text += vbNewLine + studentReader.ReadLine()
        readTextFileRichBox.Text += vbNewLine + studentReader.ReadLine()
        readTextFileRichBox.Text += vbNewLine + studentReader.ReadLine()

    End Sub
End Class
