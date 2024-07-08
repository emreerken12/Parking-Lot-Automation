<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Cars
    Inherits System.Windows.Forms.Form

    'Form, bileşen listesini temizlemeyi bırakmayı geçersiz kılar.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows Form Tasarımcısı tarafından gerektirilir
    Private components As System.ComponentModel.IContainer

    'NOT: Aşağıdaki yordam Windows Form Tasarımcısı için gereklidir
    'Windows Form Tasarımcısı kullanılarak değiştirilebilir.  
    'Kod düzenleyicisini kullanarak değiştirmeyin.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.İdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CarnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CardetailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PlakaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UsertcDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CarsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmreOtoparkOtomasyonDataSet1 = New WindowsApp1.EmreOtoparkOtomasyonDataSet1()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.MaskedTextBox1 = New System.Windows.Forms.MaskedTextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.MaskedTextBox2 = New System.Windows.Forms.MaskedTextBox()
        Me.MaskedTextBox3 = New System.Windows.Forms.MaskedTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CarsTableAdapter = New WindowsApp1.EmreOtoparkOtomasyonDataSet1TableAdapters.CarsTableAdapter()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CarsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmreOtoparkOtomasyonDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button4.Location = New System.Drawing.Point(834, 498)
        Me.Button4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(88, 28)
        Me.Button4.TabIndex = 25
        Me.Button4.Text = "Panele Dön"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(113, 428)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(249, 16)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "Silmek veya Güncellemek için PLAKA Bilgisi:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 161)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 16)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Plaka"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 108)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 16)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Araç Bilgi"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 54)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 16)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Araç Marka"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.İdDataGridViewTextBoxColumn, Me.CarnameDataGridViewTextBoxColumn, Me.CardetailDataGridViewTextBoxColumn, Me.PlakaDataGridViewTextBoxColumn, Me.UsertcDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.CarsBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(265, 28)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(573, 185)
        Me.DataGridView1.TabIndex = 20
        '
        'İdDataGridViewTextBoxColumn
        '
        Me.İdDataGridViewTextBoxColumn.DataPropertyName = "id"
        Me.İdDataGridViewTextBoxColumn.HeaderText = "id"
        Me.İdDataGridViewTextBoxColumn.Name = "İdDataGridViewTextBoxColumn"
        Me.İdDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CarnameDataGridViewTextBoxColumn
        '
        Me.CarnameDataGridViewTextBoxColumn.DataPropertyName = "carname"
        Me.CarnameDataGridViewTextBoxColumn.HeaderText = "carname"
        Me.CarnameDataGridViewTextBoxColumn.Name = "CarnameDataGridViewTextBoxColumn"
        '
        'CardetailDataGridViewTextBoxColumn
        '
        Me.CardetailDataGridViewTextBoxColumn.DataPropertyName = "cardetail"
        Me.CardetailDataGridViewTextBoxColumn.HeaderText = "cardetail"
        Me.CardetailDataGridViewTextBoxColumn.Name = "CardetailDataGridViewTextBoxColumn"
        '
        'PlakaDataGridViewTextBoxColumn
        '
        Me.PlakaDataGridViewTextBoxColumn.DataPropertyName = "plaka"
        Me.PlakaDataGridViewTextBoxColumn.HeaderText = "plaka"
        Me.PlakaDataGridViewTextBoxColumn.Name = "PlakaDataGridViewTextBoxColumn"
        '
        'UsertcDataGridViewTextBoxColumn
        '
        Me.UsertcDataGridViewTextBoxColumn.DataPropertyName = "usertc"
        Me.UsertcDataGridViewTextBoxColumn.HeaderText = "usertc"
        Me.UsertcDataGridViewTextBoxColumn.Name = "UsertcDataGridViewTextBoxColumn"
        '
        'CarsBindingSource
        '
        Me.CarsBindingSource.DataMember = "Cars"
        Me.CarsBindingSource.DataSource = Me.EmreOtoparkOtomasyonDataSet1
        '
        'EmreOtoparkOtomasyonDataSet1
        '
        Me.EmreOtoparkOtomasyonDataSet1.DataSetName = "EmreOtoparkOtomasyonDataSet1"
        Me.EmreOtoparkOtomasyonDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button3.Location = New System.Drawing.Point(468, 463)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(88, 28)
        Me.Button3.TabIndex = 19
        Me.Button3.Text = "Sil"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button2.Location = New System.Drawing.Point(373, 463)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(88, 28)
        Me.Button2.TabIndex = 18
        Me.Button2.Text = "Güncelle"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(94, 282)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(88, 28)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "Ekle"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'MaskedTextBox1
        '
        Me.MaskedTextBox1.Location = New System.Drawing.Point(94, 153)
        Me.MaskedTextBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaskedTextBox1.Mask = "aaaaaaaaaaa"
        Me.MaskedTextBox1.Name = "MaskedTextBox1"
        Me.MaskedTextBox1.Size = New System.Drawing.Size(134, 21)
        Me.MaskedTextBox1.TabIndex = 15
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(94, 46)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(134, 21)
        Me.TextBox1.TabIndex = 13
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"MOTOR", "ARABA", "SRC"})
        Me.ComboBox1.Location = New System.Drawing.Point(94, 98)
        Me.ComboBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(134, 24)
        Me.ComboBox1.TabIndex = 26
        '
        'MaskedTextBox2
        '
        Me.MaskedTextBox2.Location = New System.Drawing.Point(373, 420)
        Me.MaskedTextBox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaskedTextBox2.Mask = "aaaaaaaaaaa"
        Me.MaskedTextBox2.Name = "MaskedTextBox2"
        Me.MaskedTextBox2.Size = New System.Drawing.Size(134, 21)
        Me.MaskedTextBox2.TabIndex = 27
        '
        'MaskedTextBox3
        '
        Me.MaskedTextBox3.Location = New System.Drawing.Point(94, 209)
        Me.MaskedTextBox3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaskedTextBox3.Mask = "00000000000"
        Me.MaskedTextBox3.Name = "MaskedTextBox3"
        Me.MaskedTextBox3.Size = New System.Drawing.Size(134, 21)
        Me.MaskedTextBox3.TabIndex = 28
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 213)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 16)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = " Sahip Tc"
        '
        'CarsTableAdapter
        '
        Me.CarsTableAdapter.ClearBeforeFill = True
        '
        'Cars
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(933, 554)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.MaskedTextBox3)
        Me.Controls.Add(Me.MaskedTextBox2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.MaskedTextBox1)
        Me.Controls.Add(Me.TextBox1)
        Me.Font = New System.Drawing.Font("Sitka Text", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Cars"
        Me.Text = "Cars"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CarsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmreOtoparkOtomasyonDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button4 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents MaskedTextBox1 As MaskedTextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents MaskedTextBox2 As MaskedTextBox
    Friend WithEvents MaskedTextBox3 As MaskedTextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents EmreOtoparkOtomasyonDataSet1 As EmreOtoparkOtomasyonDataSet1
    Friend WithEvents CarsBindingSource As BindingSource
    Friend WithEvents CarsTableAdapter As EmreOtoparkOtomasyonDataSet1TableAdapters.CarsTableAdapter
    Friend WithEvents İdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CarnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CardetailDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PlakaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UsertcDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
