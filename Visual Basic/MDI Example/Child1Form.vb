Public Class Child1Form
    Private Sub btnShowChild2_Click(sender As Object, e As EventArgs) Handles btnShowChild2.Click
        Child2Form.MdiParent = Me.MdiParent
        Child2Form.Show()

    End Sub
End Class