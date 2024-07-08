Imports System.Data.SqlClient

Public Class Parks
    Dim connectionString As String = "Data Source=DESKTOP-06LT5PF\SQLEXPRESS;Initial Catalog=EmreOtoparkOtomasyon;Integrated Security=True"
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim parkLoc As String = MaskedTextBox4.Text.Trim()
        Dim plate As String = MaskedTextBox1.Text.Replace("-", "").Trim()
        Dim entrance As Date = DateTimePicker1.Value

        If String.IsNullOrEmpty(parkLoc) Or String.IsNullOrEmpty(plate) Then
            MessageBox.Show("Tüm alanlar doldurulmalıdır.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Try
            Dim queryCheckPlate As String = "SELECT COUNT(*) FROM Cars WHERE plaka=@Plate"
            Using connectionCheckPlate As New SqlConnection(connectionString)
                Using commandCheckPlate As New SqlCommand(queryCheckPlate, connectionCheckPlate)
                    commandCheckPlate.Parameters.AddWithValue("@Plate", plate)
                    connectionCheckPlate.Open()
                    Dim countPlate As Integer = Convert.ToInt32(commandCheckPlate.ExecuteScalar())
                    If countPlate = 0 Then
                        MessageBox.Show("Bu plakada araç bulunamadı.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Return
                    End If
                End Using
            End Using

            Dim queryInsertPark As String = "INSERT INTO Parks (parkloc, plaka, enterence) VALUES (@ParkLoc, @Plate, @Entrance)"
            Using connectionInsertPark As New SqlConnection(connectionString)
                Using commandInsertPark As New SqlCommand(queryInsertPark, connectionInsertPark)
                    commandInsertPark.Parameters.AddWithValue("@ParkLoc", parkLoc)
                    commandInsertPark.Parameters.AddWithValue("@Plate", plate)
                    commandInsertPark.Parameters.AddWithValue("@Entrance", entrance)
                    connectionInsertPark.Open()
                    commandInsertPark.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Araç park başarıyla eklendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Araç park edilirken bir hata oluştu: " & ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim AdminPanel As New AdminPanel()
        AdminPanel.Show()
        Me.Hide()
    End Sub

    Private Sub Parks_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: Bu kod satırı 'EmreOtoparkOtomasyonDataSet2.Parks' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
        Me.ParksTableAdapter.Fill(Me.EmreOtoparkOtomasyonDataSet2.Parks)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim parkLocToUpdate As String = MaskedTextBox2.Text.Trim()
        Dim newParkLoc As String = MaskedTextBox4.Text.Trim()
        Dim entrance As Date = DateTimePicker1.Value

        If String.IsNullOrEmpty(parkLocToUpdate) Then
            MessageBox.Show("Güncellenecek park yeri seçilmelidir.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If String.IsNullOrEmpty(newParkLoc) Then
            MessageBox.Show("Park yeri boş olamaz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Try
            Dim queryCheckParkLoc As String = "SELECT COUNT(*) FROM Parks WHERE parkloc=@ParkLoc"
            Using connectionCheckParkLoc As New SqlConnection(connectionString)
                Using commandCheckParkLoc As New SqlCommand(queryCheckParkLoc, connectionCheckParkLoc)
                    commandCheckParkLoc.Parameters.AddWithValue("@ParkLoc", parkLocToUpdate)
                    connectionCheckParkLoc.Open()
                    Dim countParkLoc As Integer = Convert.ToInt32(commandCheckParkLoc.ExecuteScalar())
                    If countParkLoc = 0 Then
                        MessageBox.Show("Eşleşen park yeri bulunamadı.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Return
                    End If
                End Using
            End Using

            Dim queryUpdatePark As String = "UPDATE Parks SET parkloc=@NewParkLoc, enterence=@Entrance WHERE parkloc=@ParkLoc"
            Using connectionUpdatePark As New SqlConnection(connectionString)
                Using commandUpdatePark As New SqlCommand(queryUpdatePark, connectionUpdatePark)
                    commandUpdatePark.Parameters.AddWithValue("@NewParkLoc", newParkLoc)
                    commandUpdatePark.Parameters.AddWithValue("@Entrance", entrance)
                    commandUpdatePark.Parameters.AddWithValue("@ParkLoc", parkLocToUpdate)
                    connectionUpdatePark.Open()
                    commandUpdatePark.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Park bilgileri başarıyla güncellendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Park bilgileri güncellenirken bir hata oluştu: " & ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim parkLocToDelete As String = MaskedTextBox2.Text.Trim()

        If String.IsNullOrEmpty(parkLocToDelete) Then
            MessageBox.Show("Silinecek park yeri seçilmelidir.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Try
            Dim queryCheckParkLoc As String = "SELECT COUNT(*) FROM Parks WHERE parkloc=@ParkLoc"
            Using connectionCheckParkLoc As New SqlConnection(connectionString)
                Using commandCheckParkLoc As New SqlCommand(queryCheckParkLoc, connectionCheckParkLoc)
                    commandCheckParkLoc.Parameters.AddWithValue("@ParkLoc", parkLocToDelete)
                    connectionCheckParkLoc.Open()
                    Dim countParkLoc As Integer = Convert.ToInt32(commandCheckParkLoc.ExecuteScalar())
                    If countParkLoc = 0 Then
                        MessageBox.Show("Eşleşen park yeri bulunamadı.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Return
                    End If
                End Using
            End Using

            Dim queryDeletePark As String = "DELETE FROM Parks WHERE parkloc=@ParkLoc"
            Using connectionDeletePark As New SqlConnection(connectionString)
                Using commandDeletePark As New SqlCommand(queryDeletePark, connectionDeletePark)
                    commandDeletePark.Parameters.AddWithValue("@ParkLoc", parkLocToDelete)
                    connectionDeletePark.Open()
                    commandDeletePark.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Park başarıyla silindi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Park silinirken bir hata oluştu: " & ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class