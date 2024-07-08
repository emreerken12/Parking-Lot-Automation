Public Class AdminPanel
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim Cars As New Cars()
        Cars.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim User As New User()
        User.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim Parks As New Parks()
        Parks.Show()
        Me.Hide()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim Money As New Money()
        Money.Show()
        Me.Hide()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim Form1 As New Form1()
        Form1.Show()
        Me.Hide()
    End Sub
End Class