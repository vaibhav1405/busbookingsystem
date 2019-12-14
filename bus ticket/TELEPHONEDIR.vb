Public Class TELEPHONEDIR
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        HOME.Show()
        Me.Close()
    End Sub

    Private Sub TELEPHONEDIR_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub
End Class