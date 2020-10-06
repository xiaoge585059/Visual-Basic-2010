﻿Module DrawingModule
    Public Sub OpenPicture()
        ' Show the open file dialog box.
        If ViewerForm.ofdSelectPicture.ShowDialog = DialogResult.OK Then
            ' Load the picture into the picture box.
            ViewerForm.picShowPicture.Image = Image.FromFile(ViewerForm.ofdSelectPicture.FileName)
            ' Show the name of the file in the statusbar.
            ' Me.Text = "Picture Viewer (" & ofdSelectPicture.FileName & ")"
            ViewerForm.sbrMyStatusStrip.Items(0).Text = ViewerForm.ofdSelectPicture.FileName
        End If

    End Sub

    Public Sub DrawBorder(ByRef objPicturebox As PictureBox)
        Dim objGraphics As Graphics
        objGraphics = objPicturebox.Parent.CreateGraphics()
        objGraphics.Clear(System.Drawing.SystemColors.Control)

        objGraphics.DrawRectangle(System.Drawing.Pens.Blue,
                                  objPicturebox.Left - 1, objPicturebox.Top - 1,
                                  objPicturebox.Width + 1, objPicturebox.Height + 1)

        objGraphics.Dispose()

    End Sub
End Module
