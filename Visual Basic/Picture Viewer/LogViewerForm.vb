Public Class LogViewerForm
    Private Sub LogViewerForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            Dim objFile As New System.IO.StreamReader(
                System.AppDomain.CurrentDomain.BaseDirectory() & "\PictureLog.txt")
            txtLog.Text = objFile.ReadToEnd()
            objFile.Close()
            objFile.Dispose()
        Catch ex As Exception
            txtLog.Text = "The log file could not be found."
        End Try

    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Me.Close()

    End Sub
End Class