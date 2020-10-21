Public Class ViewerForm

    Const c_defPromptOnExit = False

    Private m_strUserName As String
    Private m_blnPromptOnExit As Boolean
    Private m_objPictureBackColor As Color

    Private Sub btnEnlarge_Click(sender As Object, e As EventArgs) Handles btnEnlarge.Click
        Me.Width += 20
        Me.Height += 20

    End Sub

    Private Sub btnShrink_Click(sender As Object, e As EventArgs) Handles btnShrink.Click
        Me.Width -= 20
        Me.Height -= 20

    End Sub

    Private Sub picShowPicture_MouseMove(sender As Object, e As MouseEventArgs) Handles picShowPicture.MouseMove
        lblX.Text = "X: " & e.X
        lblY.Text = "Y: " & e.Y

    End Sub

    Private Sub picShowPicture_MouseLeave(sender As Object, e As EventArgs) Handles picShowPicture.MouseLeave
        lblX.Text = ""
        lblY.Text = ""

    End Sub

    Private Sub ViewerForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        lblX.Text = ""
        lblY.Text = ""

        m_blnPromptOnExit = c_defPromptOnExit
        m_objPictureBackColor = System.Drawing.SystemColors.Control

        picShowPicture.BackColor = m_objPictureBackColor
        mnuConfirmonExit.Checked = m_blnPromptOnExit

    End Sub

    Private Sub mnuOpenPicture_Click(sender As Object, e As EventArgs) Handles mnuOpenPicture.Click
        OpenPicture()

    End Sub

    Private Sub mnuConfirmonExit_Click(sender As Object, e As EventArgs) Handles mnuConfirmonExit.Click
        mnuConfirmonExit.Checked = Not (mnuConfirmonExit.Checked)
        m_blnPromptOnExit = mnuConfirmonExit.Checked

    End Sub

    Private Sub mnuQuit_Click(sender As Object, e As EventArgs) Handles mnuQuit.Click
        Me.Close()

    End Sub

    Private Sub mnuDrawBorder_Click(sender As Object, e As EventArgs) Handles mnuDrawBorder.Click
        DrawBorder(picShowPicture)

    End Sub

    Private Sub mnuOptions_Click(sender As Object, e As EventArgs) Handles mnuOptions.Click
        OptionsForm.ShowDialog()

    End Sub

    Private Sub tbbOpenPicture_Click(sender As Object, e As EventArgs) Handles tbbOpenPicture.Click
        OpenPicture()

    End Sub

    Private Sub tbbDrawBorder_Click(sender As Object, e As EventArgs) Handles tbbDrawBorder.Click
        DrawBorder(picShowPicture)

    End Sub

    Private Sub tbbOptions_Click(sender As Object, e As EventArgs) Handles tbbOptions.Click
        OptionsForm.ShowDialog()

    End Sub

    Private Sub ViewerForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If m_blnPromptOnExit Then
            If MessageBox.Show("Close the Picture Viewer program?",
                               "Picture Viewer",
                               MessageBoxButtons.YesNo,
                               MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
                e.Cancel = True
            End If
        End If

    End Sub

    Private Sub tbbShowLog_Click(sender As Object, e As EventArgs) Handles tbbShowLog.Click
        LogViewerForm.ShowDialog()

    End Sub
End Class
