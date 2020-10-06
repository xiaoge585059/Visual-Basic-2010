Public Class MDIParentForm
    Private Sub MDIParentForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Child1Form.MdiParent = Me
        Child1Form.Show()

    End Sub
End Class
