Imports System.Data.SqlClient

Public Class Cars
    Dim connectionString As String = "Data Source=DESKTOP-06LT5PF\SQLEXPRESS;Initial Catalog=EmreOtoparkOtomasyon;Integrated Security=True"
    Private Sub Cars_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: Bu kod satırı 'EmreOtoparkOtomasyonDataSet1.Cars' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
        Me.CarsTableAdapter.Fill(Me.EmreOtoparkOtomasyonDataSet1.Cars)

    End Sub

    Private Sub RefreshDataGridView()
        Try
            Dim query As String = "SELECT * FROM Cars"
            Using connection As New SqlConnection(connectionString)
                Using adapter As New SqlDataAdapter(query, connection)
                    Dim dataSet As New DataSet()
                    adapter.Fill(dataSet, "Cars")
                    DataGridView1.DataSource = dataSet.Tables("Cars")
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("DataGridView güncellenirken bir hata oluştu: " & ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub





    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim carName As String = TextBox1.Text.Trim()
        Dim carDetail As String = ComboBox1.Text.Trim()
        Dim plate As String = MaskedTextBox1.Text.Replace("-", "").Trim()
        Dim userTC As String = MaskedTextBox3.Text.Replace("-", "").Trim()

        If String.IsNullOrEmpty(carName) Or String.IsNullOrEmpty(carDetail) Or String.IsNullOrEmpty(plate) Or String.IsNullOrEmpty(userTC) Then
            MessageBox.Show("Tüm alanlar doldurulmalıdır.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Try
            Dim queryCheckUser As String = "SELECT COUNT(*) FROM Users WHERE tc=@UserTC"
            Using connectionCheckUser As New SqlConnection(connectionString)
                Using commandCheckUser As New SqlCommand(queryCheckUser, connectionCheckUser)
                    commandCheckUser.Parameters.AddWithValue("@UserTC", userTC)
                    connectionCheckUser.Open()
                    Dim countUser As Integer = Convert.ToInt32(commandCheckUser.ExecuteScalar())
                    If countUser = 0 Then
                        MessageBox.Show("Bu TC kimlik numarasına sahip kullanıcı bulunamadı.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Return
                    End If
                End Using
            End Using

            Dim queryInsertCar As String = "INSERT INTO Cars (carname, cardetail, plaka, usertc) VALUES (@CarName, @CarDetail, @Plate, @UserTC)"
            Using connectionInsertCar As New SqlConnection(connectionString)
                Using commandInsertCar As New SqlCommand(queryInsertCar, connectionInsertCar)
                    commandInsertCar.Parameters.AddWithValue("@CarName", carName)
                    commandInsertCar.Parameters.AddWithValue("@CarDetail", carDetail)
                    commandInsertCar.Parameters.AddWithValue("@Plate", plate)
                    commandInsertCar.Parameters.AddWithValue("@UserTC", userTC)
                    connectionInsertCar.Open()
                    commandInsertCar.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Araç başarıyla eklendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Araç eklenirken bir hata oluştu: " & ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        RefreshDataGridView()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim plateToUpdate As String = MaskedTextBox2.Text.Replace("-", "").Trim()
        Dim newCarName As String = TextBox1.Text.Trim()
        Dim newCarDetail As String = ComboBox1.Text.Trim()

        If String.IsNullOrEmpty(plateToUpdate) Or String.IsNullOrEmpty(newCarName) Or String.IsNullOrEmpty(newCarDetail) Then
            MessageBox.Show("Tüm alanlar doldurulmalıdır.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Try
            Dim queryCheckCar As String = "SELECT COUNT(*) FROM Cars WHERE plaka=@Plate"
            Using connectionCheckCar As New SqlConnection(connectionString)
                Using commandCheckCar As New SqlCommand(queryCheckCar, connectionCheckCar)
                    commandCheckCar.Parameters.AddWithValue("@Plate", plateToUpdate)
                    connectionCheckCar.Open()
                    Dim countCar As Integer = Convert.ToInt32(commandCheckCar.ExecuteScalar())
                    If countCar = 0 Then
                        MessageBox.Show("Bu plakaya sahip araç bulunamadı.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Return
                    End If
                End Using
            End Using

            Dim queryUpdateCar As String = "UPDATE Cars SET carname=@CarName, cardetail=@CarDetail WHERE plaka=@Plate"
            Using connectionUpdateCar As New SqlConnection(connectionString)
                Using commandUpdateCar As New SqlCommand(queryUpdateCar, connectionUpdateCar)
                    commandUpdateCar.Parameters.AddWithValue("@CarName", newCarName)
                    commandUpdateCar.Parameters.AddWithValue("@CarDetail", newCarDetail)
                    commandUpdateCar.Parameters.AddWithValue("@Plate", plateToUpdate)
                    connectionUpdateCar.Open()
                    commandUpdateCar.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Araç başarıyla güncellendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Araç güncellenirken bir hata oluştu: " & ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        RefreshDataGridView()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim plateToDelete As String = MaskedTextBox2.Text.Replace("-", "").Trim()

        If String.IsNullOrEmpty(plateToDelete) Then
            MessageBox.Show("Plaka numarası girilmelidir.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Try
            Dim queryCheckCar As String = "SELECT COUNT(*) FROM Cars WHERE plaka=@Plate"
            Using connectionCheckCar As New SqlConnection(connectionString)
                Using commandCheckCar As New SqlCommand(queryCheckCar, connectionCheckCar)
                    commandCheckCar.Parameters.AddWithValue("@Plate", plateToDelete)
                    connectionCheckCar.Open()
                    Dim countCar As Integer = Convert.ToInt32(commandCheckCar.ExecuteScalar())
                    If countCar = 0 Then
                        MessageBox.Show("Bu plakaya sahip araç bulunamadı.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Return
                    End If
                End Using
            End Using

            Dim queryDeleteCar As String = "DELETE FROM Cars WHERE plaka=@Plate"
            Using connectionDeleteCar As New SqlConnection(connectionString)
                Using commandDeleteCar As New SqlCommand(queryDeleteCar, connectionDeleteCar)
                    commandDeleteCar.Parameters.AddWithValue("@Plate", plateToDelete)
                    connectionDeleteCar.Open()
                    commandDeleteCar.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Araç başarıyla silindi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Araç silinirken bir hata oluştu: " & ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        RefreshDataGridView()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim AdminPanel As New AdminPanel()
        AdminPanel.Show()
        Me.Hide()
    End Sub
End Class