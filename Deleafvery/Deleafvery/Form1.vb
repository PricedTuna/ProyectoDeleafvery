Public Class Form1
    Private Sub RegBtn_Click(sender As Object, e As EventArgs) Handles RegBtn.Click
        Me.Hide()
        Registrovb.Show()
    End Sub

    Private Sub LogBtn_Click(sender As Object, e As EventArgs) Handles LogBtn.Click
        Me.Hide()
        Form2.Show()
    End Sub
End Class
