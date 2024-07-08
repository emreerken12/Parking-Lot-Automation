Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Money
    Dim connectionString As String = "Data Source=DESKTOP-06LT5PF\SQLEXPRESS;Initial Catalog=EmreOtoparkOtomasyon;Integrated Security=True"
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
    End Sub

    Private Sub Money_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ' Son giriş yapan aracın park yerini ve giriş tarihini al
            Dim queryLastPark As String = "SELECT TOP 1 parkloc, enterence FROM Parks ORDER BY enterence DESC"
            Dim lastParkLoc As String = ""
            Dim entrance As Date

            Using connectionLastPark As New SqlConnection(connectionString)
                Using commandLastPark As New SqlCommand(queryLastPark, connectionLastPark)
                    connectionLastPark.Open()
                    Dim reader As SqlDataReader = commandLastPark.ExecuteReader()
                    If reader.Read() Then
                        lastParkLoc = reader("parkloc").ToString()
                        entrance = Convert.ToDateTime(reader("enterence"))
                    Else
                        MessageBox.Show("Henüz park edilmiş araç bulunmamaktadır.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Return
                    End If
                End Using
            End Using

            ' Araç detayını al
            Dim queryCarDetail As String = "SELECT cardetail FROM Cars WHERE plaka=(SELECT plaka FROM Parks WHERE parkloc=@ParkLoc AND enterence=@Entrance)"
            Dim carDetail As String = ""

            Using connectionCarDetail As New SqlConnection(connectionString)
                Using commandCarDetail As New SqlCommand(queryCarDetail, connectionCarDetail)
                    commandCarDetail.Parameters.AddWithValue("@ParkLoc", lastParkLoc)
                    commandCarDetail.Parameters.AddWithValue("@Entrance", entrance)
                    connectionCarDetail.Open()
                    Dim reader As SqlDataReader = commandCarDetail.ExecuteReader()
                    If reader.Read() Then
                        carDetail = reader("cardetail").ToString()
                    Else
                        MessageBox.Show("Araç detayı alınamadı.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Return
                    End If
                End Using
            End Using

            ' Gün sayısını hesapla
            Dim days As Integer = (Date.Now - entrance).Days

            ' Araç detayına göre kazancı hesapla
            Dim earning As Decimal = 100

            Select Case carDetail
                Case "MOTOR"
                    earning = days * 100
                Case "ARABA"
                    earning = days * 200
                Case "SRC"
                    earning = days * 300
            End Select

            ' Kazancı Earning tablosuna ekle
            Dim queryAddEarning As String = "INSERT INTO Earning (money) VALUES (@Earning)"
            Using connectionAddEarning As New SqlConnection(connectionString)
                Using commandAddEarning As New SqlCommand(queryAddEarning, connectionAddEarning)
                    commandAddEarning.Parameters.AddWithValue("@Earning", earning)
                    connectionAddEarning.Open()
                    commandAddEarning.ExecuteNonQuery()
                End Using
            End Using

            ' Hesaplanan kazancı etikete bas
            Label2.Text = earning.ToString("C2")
        Catch ex As Exception
            MessageBox.Show("Kazanç hesaplanırken bir hata oluştu: " & ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim AdminPanel As New AdminPanel()
        AdminPanel.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Dim totalEarning As Decimal = 0

            ' Tüm kazançları al
            Dim queryTotalEarning As String = "SELECT SUM(CAST(money AS DECIMAL(18,2))) AS TotalMoney FROM Earning"
            Using connectionTotalEarning As New SqlConnection(connectionString)
                Using commandTotalEarning As New SqlCommand(queryTotalEarning, connectionTotalEarning)
                    connectionTotalEarning.Open()
                    Dim reader As SqlDataReader = commandTotalEarning.ExecuteReader()
                    If reader.Read() Then
                        If Not IsDBNull(reader("TotalMoney")) Then
                            totalEarning = Convert.ToDecimal(reader("TotalMoney"))
                        End If
                    End If
                End Using
            End Using

            ' Toplam kazancı etikete bas
            Label3.Text = totalEarning.ToString("C2")
        Catch ex As Exception
            MessageBox.Show("Toplam kazanç hesaplanırken bir hata oluştu: " & ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class