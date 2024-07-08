Imports System.Data.SqlClient

Public Class User
    Dim connectionString As String = "Data Source=DESKTOP-06LT5PF\SQLEXPRESS;Initial Catalog=EmreOtoparkOtomasyon;Integrated Security=True"

    Private Sub RefreshDataGridView()
        Try
            Dim query As String = "SELECT * FROM Users"
            Using connection As New SqlConnection(connectionString)
                Using adapter As New SqlDataAdapter(query, connection)
                    Dim dataSet As New DataSet()
                    adapter.Fill(dataSet, "Users")
                    DataGridView1.DataSource = dataSet.Tables("Users")
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("DataGridView güncellenirken bir hata oluştu: " & ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub



    Private Sub MaskedTextBox2_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles MaskedTextBox2.MaskInputRejected

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim name As String = TextBox1.Text.Trim()
        Dim surname As String = TextBox2.Text.Trim()
        Dim tc As String = MaskedTextBox1.Text.Replace("-", "").Trim()

        If String.IsNullOrEmpty(name) Or String.IsNullOrEmpty(surname) Or String.IsNullOrEmpty(tc) Then
            MessageBox.Show("Tüm alanlar doldurulmalıdır.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If tc.Length <> 11 Then
            MessageBox.Show("TC Kimlik No 11 haneli olmalıdır.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Try
            Dim query As String = "INSERT INTO Users (name, surname, tc) VALUES (@Name, @Surname, @TC)"
            Using connection As New SqlConnection(connectionString)
                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@Name", name)
                    command.Parameters.AddWithValue("@Surname", surname)
                    command.Parameters.AddWithValue("@TC", tc)
                    connection.Open()
                    command.ExecuteNonQuery()
                End Using
            End Using
            MessageBox.Show("Kullanıcı başarıyla eklendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Kullanıcı eklenirken bir hata oluştu: " & ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        RefreshDataGridView()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim tcToDelete As String = MaskedTextBox2.Text.Replace("-", "").Trim()

        If tcToDelete.Length <> 11 Then
            MessageBox.Show("TC Kimlik No 11 haneli olmalıdır.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Try
            Dim queryCheck As String = "SELECT COUNT(*) FROM Users WHERE tc=@TC"
            Using connectionCheck As New SqlConnection(connectionString)
                Using commandCheck As New SqlCommand(queryCheck, connectionCheck)
                    commandCheck.Parameters.AddWithValue("@TC", tcToDelete)
                    connectionCheck.Open()
                    Dim count As Integer = Convert.ToInt32(commandCheck.ExecuteScalar())
                    If count = 0 Then
                        MessageBox.Show("Bu kimlik numarasında müşteri yok.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Return
                    End If
                End Using
            End Using

            Dim queryDelete As String = "DELETE FROM Users WHERE tc=@TC"
            Using connectionDelete As New SqlConnection(connectionString)
                Using commandDelete As New SqlCommand(queryDelete, connectionDelete)
                    commandDelete.Parameters.AddWithValue("@TC", tcToDelete)
                    connectionDelete.Open()
                    commandDelete.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Kullanıcı başarıyla silindi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Kullanıcı silinirken bir hata oluştu: " & ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        RefreshDataGridView()
    End Sub

    Private Sub User_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: Bu kod satırı 'EmreOtoparkOtomasyonDataSet.Users' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
        Me.UsersTableAdapter.Fill(Me.EmreOtoparkOtomasyonDataSet.Users)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim tcToUpdate As String = MaskedTextBox2.Text.Replace("-", "").Trim()
        Dim newName As String = TextBox1.Text.Trim()
        Dim newSurname As String = TextBox2.Text.Trim()

        If tcToUpdate.Length <> 11 Then
            MessageBox.Show("TC Kimlik No 11 haneli olmalıdır.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If String.IsNullOrEmpty(newName) Or String.IsNullOrEmpty(newSurname) Then
            MessageBox.Show("Ad ve soyad boş olamaz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Try
            Dim queryCheck As String = "SELECT * FROM Users WHERE tc=@TC"
            Using connectionCheck As New SqlConnection(connectionString)
                Using commandCheck As New SqlCommand(queryCheck, connectionCheck)
                    commandCheck.Parameters.AddWithValue("@TC", tcToUpdate)
                    connectionCheck.Open()
                    Dim reader As SqlDataReader = commandCheck.ExecuteReader()
                    If reader.Read() Then
                        Dim userId As Integer = Convert.ToInt32(reader("id"))
                        reader.Close()
                        Dim queryUpdate As String = "UPDATE Users SET name=@Name, surname=@Surname WHERE id=@UserID"
                        Using connectionUpdate As New SqlConnection(connectionString)
                            Using commandUpdate As New SqlCommand(queryUpdate, connectionUpdate)
                                commandUpdate.Parameters.AddWithValue("@Name", newName)
                                commandUpdate.Parameters.AddWithValue("@Surname", newSurname)
                                commandUpdate.Parameters.AddWithValue("@UserID", userId)
                                connectionUpdate.Open()
                                commandUpdate.ExecuteNonQuery()
                            End Using
                        End Using
                        MessageBox.Show("Kullanıcı bilgileri başarıyla güncellendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        MessageBox.Show("Bu kimlik numarasında müşteri yok.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Kullanıcı bilgileri güncellenirken bir hata oluştu: " & ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        RefreshDataGridView()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim AdminPanel As New AdminPanel()
        AdminPanel.Show()
        Me.Hide()
    End Sub
End Class