Public Class Form27
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs)
        Close
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Try
            ' Define the path to the Chrome executable
            Dim chromePath As String = "C:\Program Files\Google\Chrome\Application\chrome.exe"

            ' Open the URL in Chrome
            System.Diagnostics.Process.Start(chromePath, "https://drive.google.com/file/d/1blslbzG9iRNqBsd6VKge86iUlhoIRH3g/view?usp=drive_link")
        Catch ex As Exception
            MessageBox.Show("Unable to open the link in Chrome. Please check if Google Chrome is installed in the default path.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Form27_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
