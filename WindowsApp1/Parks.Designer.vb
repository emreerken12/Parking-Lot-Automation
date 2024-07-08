<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Parks
    Inherits System.Windows.Forms.Form

    'Form, bileşen listesini temizlemeyi bırakmayı geçersiz kılar.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.İdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ParklocDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PlakaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EnterenceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ParksBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmreOtoparkOtomasyonDataSet2 = New WindowsApp1.EmreOtoparkOtomasyonDataSet2()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.MaskedTextBox1 = New System.Windows.Forms.MaskedTextBox()
        Me.MaskedTextBox4 = New System.Windows.Forms.MaskedTextBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MaskedTextBox2 = New System.Windows.Forms.MaskedTextBox()
        Me.ParksTableAdapter = New WindowsApp1.EmreOtoparkOtomasyonDataSet2TableAdapters.ParksTableAdapter()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ParksBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmreOtoparkOtomasyonDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(835, 498)
        Me.Button4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(88, 28)
        Me.Button4.TabIndex = 40
        Me.Button4.Text = "Panele Dön"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(106, 423)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(256, 16)
        Me.Label4.TabIndex = 39
        Me.Label4.Text = "Silmek veya Güncellemek İçin KONUM Bilgisi:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 102)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 16)
        Me.Label3.TabIndex = 38
        Me.Label3.Text = "Plaka"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 54)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 16)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "Konum"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.İdDataGridViewTextBoxColumn, Me.ParklocDataGridViewTextBoxColumn, Me.PlakaDataGridViewTextBoxColumn, Me.EnterenceDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.ParksBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(346, 15)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(573, 185)
        Me.DataGridView1.TabIndex = 35
        '
        'İdDataGridViewTextBoxColumn
        '
        Me.İdDataGridViewTextBoxColumn.DataPropertyName = "id"
        Me.İdDataGridViewTextBoxColumn.HeaderText = "id"
        Me.İdDataGridViewTextBoxColumn.Name = "İdDataGridViewTextBoxColumn"
        Me.İdDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ParklocDataGridViewTextBoxColumn
        '
        Me.ParklocDataGridViewTextBoxColumn.DataPropertyName = "parkloc"
        Me.ParklocDataGridViewTextBoxColumn.HeaderText = "parkloc"
        Me.ParklocDataGridViewTextBoxColumn.Name = "ParklocDataGridViewTextBoxColumn"
        '
        'PlakaDataGridViewTextBoxColumn
        '
        Me.PlakaDataGridViewTextBoxColumn.DataPropertyName = "plaka"
        Me.PlakaDataGridViewTextBoxColumn.HeaderText = "plaka"
        Me.PlakaDataGridViewTextBoxColumn.Name = "PlakaDataGridViewTextBoxColumn"
        '
        'EnterenceDataGridViewTextBoxColumn
        '
        Me.EnterenceDataGridViewTextBoxColumn.DataPropertyName = "enterence"
        Me.EnterenceDataGridViewTextBoxColumn.HeaderText = "enterence"
        Me.EnterenceDataGridViewTextBoxColumn.Name = "EnterenceDataGridViewTextBoxColumn"
        '
        'ParksBindingSource
        '
        Me.ParksBindingSource.DataMember = "Parks"
        Me.ParksBindingSource.DataSource = Me.EmreOtoparkOtomasyonDataSet2
        '
        'EmreOtoparkOtomasyonDataSet2
        '
        Me.EmreOtoparkOtomasyonDataSet2.DataSetName = "EmreOtoparkOtomasyonDataSet2"
        Me.EmreOtoparkOtomasyonDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button3.Location = New System.Drawing.Point(469, 463)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(88, 28)
        Me.Button3.TabIndex = 34
        Me.Button3.Text = "Sil"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button2.Location = New System.Drawing.Point(374, 463)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(88, 28)
        Me.Button2.TabIndex = 33
        Me.Button2.Text = "Güncelle"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(96, 194)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(88, 28)
        Me.Button1.TabIndex = 32
        Me.Button1.Text = "Ekle"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'MaskedTextBox1
        '
        Me.MaskedTextBox1.Location = New System.Drawing.Point(96, 94)
        Me.MaskedTextBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaskedTextBox1.Mask = "aaaaaaaaaaa"
        Me.MaskedTextBox1.Name = "MaskedTextBox1"
        Me.MaskedTextBox1.Size = New System.Drawing.Size(134, 21)
        Me.MaskedTextBox1.TabIndex = 31
        '
        'MaskedTextBox4
        '
        Me.MaskedTextBox4.Location = New System.Drawing.Point(96, 50)
        Me.MaskedTextBox4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaskedTextBox4.Mask = "a00"
        Me.MaskedTextBox4.Name = "MaskedTextBox4"
        Me.MaskedTextBox4.Size = New System.Drawing.Size(134, 21)
        Me.MaskedTextBox4.TabIndex = 45
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(96, 143)
        Me.DateTimePicker1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(233, 21)
        Me.DateTimePicker1.TabIndex = 46
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 143)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 16)
        Me.Label2.TabIndex = 47
        Me.Label2.Text = "Giriş Tarihi"
        '
        'MaskedTextBox2
        '
        Me.MaskedTextBox2.Location = New System.Drawing.Point(374, 420)
        Me.MaskedTextBox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaskedTextBox2.Mask = "a00"
        Me.MaskedTextBox2.Name = "MaskedTextBox2"
        Me.MaskedTextBox2.Size = New System.Drawing.Size(134, 21)
        Me.MaskedTextBox2.TabIndex = 48
        '
        'ParksTableAdapter
        '
        Me.ParksTableAdapter.ClearBeforeFill = True
        '
        'Parks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(933, 554)
        Me.Controls.Add(Me.MaskedTextBox2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.MaskedTextBox4)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.MaskedTextBox1)
        Me.Font = New System.Drawing.Font("Sitka Text", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Parks"
        Me.Text = "Parks"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ParksBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmreOtoparkOtomasyonDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button4 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents MaskedTextBox1 As MaskedTextBox
    Friend WithEvents MaskedTextBox4 As MaskedTextBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents MaskedTextBox2 As MaskedTextBox
    Friend WithEvents EmreOtoparkOtomasyonDataSet2 As EmreOtoparkOtomasyonDataSet2
    Friend WithEvents ParksBindingSource As BindingSource
    Friend WithEvents ParksTableAdapter As EmreOtoparkOtomasyonDataSet2TableAdapters.ParksTableAdapter
    Friend WithEvents İdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ParklocDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PlakaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EnterenceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
