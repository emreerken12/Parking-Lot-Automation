Imports System.Data.SqlClient

Public Class Form1
    Dim connectionString As String = "Data Source=DESKTOP-06LT5PF\SQLEXPRESS;Initial Catalog=EmreOtoparkOtomasyon;Integrated Security=True"

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim username As String = TextBox1.Text.Trim()
        Dim password As String = TextBox2.Text.Trim()

        If String.IsNullOrEmpty(username) Or String.IsNullOrEmpty(password) Then
            MessageBox.Show("Kullanıcı adı veya şifre boş olamaz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim query As String = "SELECT COUNT(*) FROM Admin WHERE nick=@Username AND password=@Password"
        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@Username", username)
                command.Parameters.AddWithValue("@Password", password)
                connection.Open()
                Dim count As Integer = Convert.ToInt32(command.ExecuteScalar())
                If count > 0 Then
                    MessageBox.Show("Giriş Yapıldı", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Dim AdminPanel As New AdminPanel()
                    AdminPanel.Show()
                    Me.Hide()

                Else
                    MessageBox.Show("Kullanıcı adı veya şifre yanlış.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End Using
        End Using
    End Sub
End Class
