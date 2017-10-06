<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManagementClass
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.data_grid_all = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.data_grid_class = New System.Windows.Forms.DataGridView()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txt_tingkat = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_id = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_lokasi = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_jurusan = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_nama = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_pil_kelas = New System.Windows.Forms.ComboBox()
        Me.btn_tambah = New System.Windows.Forms.Button()
        Me.btn_edit = New System.Windows.Forms.Button()
        Me.btn_simpan = New System.Windows.Forms.Button()
        Me.btn_hapus = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.btn_masuk = New System.Windows.Forms.Button()
        Me.btn_keluar = New System.Windows.Forms.Button()
        CType(Me.data_grid_all, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.data_grid_class, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'data_grid_all
        '
        Me.data_grid_all.AllowUserToAddRows = False
        Me.data_grid_all.AllowUserToDeleteRows = False
        Me.data_grid_all.AllowUserToOrderColumns = True
        Me.data_grid_all.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.data_grid_all.Location = New System.Drawing.Point(17, 46)
        Me.data_grid_all.Name = "data_grid_all"
        Me.data_grid_all.ReadOnly = True
        Me.data_grid_all.Size = New System.Drawing.Size(301, 435)
        Me.data_grid_all.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.data_grid_all)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 218)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(337, 501)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "List Semua Siswa"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(81, 19)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(237, 20)
        Me.TextBox1.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Cari Siswa"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.data_grid_class)
        Me.GroupBox2.Location = New System.Drawing.Point(518, 218)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(331, 479)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "List Siswa Di Kelas"
        '
        'data_grid_class
        '
        Me.data_grid_class.AllowUserToAddRows = False
        Me.data_grid_class.AllowUserToDeleteRows = False
        Me.data_grid_class.AllowUserToOrderColumns = True
        Me.data_grid_class.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.data_grid_class.Location = New System.Drawing.Point(15, 19)
        Me.data_grid_class.Name = "data_grid_class"
        Me.data_grid_class.ReadOnly = True
        Me.data_grid_class.Size = New System.Drawing.Size(301, 437)
        Me.data_grid_class.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txt_tingkat)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.txt_id)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.txt_lokasi)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.txt_jurusan)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.txt_nama)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(500, 200)
        Me.GroupBox3.TabIndex = 6
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Data Kelas"
        '
        'txt_tingkat
        '
        Me.txt_tingkat.Enabled = False
        Me.txt_tingkat.FormattingEnabled = True
        Me.txt_tingkat.Items.AddRange(New Object() {"1 / X", "2 / XI", "3 / XII"})
        Me.txt_tingkat.Location = New System.Drawing.Point(81, 98)
        Me.txt_tingkat.Name = "txt_tingkat"
        Me.txt_tingkat.Size = New System.Drawing.Size(49, 21)
        Me.txt_tingkat.TabIndex = 10
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 22)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(47, 13)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "ID Kelas"
        '
        'txt_id
        '
        Me.txt_id.Enabled = False
        Me.txt_id.Location = New System.Drawing.Point(81, 19)
        Me.txt_id.Name = "txt_id"
        Me.txt_id.Size = New System.Drawing.Size(100, 20)
        Me.txt_id.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 126)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(38, 13)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Lokasi"
        '
        'txt_lokasi
        '
        Me.txt_lokasi.Enabled = False
        Me.txt_lokasi.Location = New System.Drawing.Point(81, 123)
        Me.txt_lokasi.Multiline = True
        Me.txt_lokasi.Name = "txt_lokasi"
        Me.txt_lokasi.Size = New System.Drawing.Size(277, 52)
        Me.txt_lokasi.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 100)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Tingkat"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 74)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Jurusan"
        '
        'txt_jurusan
        '
        Me.txt_jurusan.Enabled = False
        Me.txt_jurusan.Location = New System.Drawing.Point(81, 71)
        Me.txt_jurusan.Name = "txt_jurusan"
        Me.txt_jurusan.Size = New System.Drawing.Size(154, 20)
        Me.txt_jurusan.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Nama Kelas"
        '
        'txt_nama
        '
        Me.txt_nama.Enabled = False
        Me.txt_nama.Location = New System.Drawing.Point(81, 45)
        Me.txt_nama.Name = "txt_nama"
        Me.txt_nama.Size = New System.Drawing.Size(194, 20)
        Me.txt_nama.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Pilih Kelas :"
        '
        'txt_pil_kelas
        '
        Me.txt_pil_kelas.FormattingEnabled = True
        Me.txt_pil_kelas.Location = New System.Drawing.Point(78, 22)
        Me.txt_pil_kelas.Name = "txt_pil_kelas"
        Me.txt_pil_kelas.Size = New System.Drawing.Size(238, 21)
        Me.txt_pil_kelas.TabIndex = 6
        '
        'btn_tambah
        '
        Me.btn_tambah.Location = New System.Drawing.Point(44, 58)
        Me.btn_tambah.Name = "btn_tambah"
        Me.btn_tambah.Size = New System.Drawing.Size(128, 44)
        Me.btn_tambah.TabIndex = 7
        Me.btn_tambah.Text = "Tambah"
        Me.btn_tambah.UseVisualStyleBackColor = True
        '
        'btn_edit
        '
        Me.btn_edit.Location = New System.Drawing.Point(44, 112)
        Me.btn_edit.Name = "btn_edit"
        Me.btn_edit.Size = New System.Drawing.Size(128, 44)
        Me.btn_edit.TabIndex = 8
        Me.btn_edit.Text = "Edit"
        Me.btn_edit.UseVisualStyleBackColor = True
        '
        'btn_simpan
        '
        Me.btn_simpan.Location = New System.Drawing.Point(178, 58)
        Me.btn_simpan.Name = "btn_simpan"
        Me.btn_simpan.Size = New System.Drawing.Size(128, 44)
        Me.btn_simpan.TabIndex = 9
        Me.btn_simpan.Text = "Simpan"
        Me.btn_simpan.UseVisualStyleBackColor = True
        '
        'btn_hapus
        '
        Me.btn_hapus.Location = New System.Drawing.Point(178, 112)
        Me.btn_hapus.Name = "btn_hapus"
        Me.btn_hapus.Size = New System.Drawing.Size(128, 44)
        Me.btn_hapus.TabIndex = 10
        Me.btn_hapus.Text = "Hapus"
        Me.btn_hapus.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Controls.Add(Me.btn_tambah)
        Me.GroupBox4.Controls.Add(Me.btn_hapus)
        Me.GroupBox4.Controls.Add(Me.btn_edit)
        Me.GroupBox4.Controls.Add(Me.btn_simpan)
        Me.GroupBox4.Controls.Add(Me.txt_pil_kelas)
        Me.GroupBox4.Location = New System.Drawing.Point(518, 12)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(331, 200)
        Me.GroupBox4.TabIndex = 11
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Menu Class"
        '
        'btn_masuk
        '
        Me.btn_masuk.Location = New System.Drawing.Point(366, 372)
        Me.btn_masuk.Name = "btn_masuk"
        Me.btn_masuk.Size = New System.Drawing.Size(132, 52)
        Me.btn_masuk.TabIndex = 12
        Me.btn_masuk.Text = "Masukkan >>>"
        Me.btn_masuk.UseVisualStyleBackColor = True
        '
        'btn_keluar
        '
        Me.btn_keluar.Location = New System.Drawing.Point(366, 451)
        Me.btn_keluar.Name = "btn_keluar"
        Me.btn_keluar.Size = New System.Drawing.Size(132, 52)
        Me.btn_keluar.TabIndex = 13
        Me.btn_keluar.Text = "<<< Keluarkan"
        Me.btn_keluar.UseVisualStyleBackColor = True
        '
        'ManagementClass
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(863, 733)
        Me.Controls.Add(Me.btn_keluar)
        Me.Controls.Add(Me.btn_masuk)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "ManagementClass"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ManagementClass"
        CType(Me.data_grid_all, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.data_grid_class, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents data_grid_all As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents data_grid_class As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_pil_kelas As ComboBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents btn_tambah As Button
    Friend WithEvents btn_edit As Button
    Friend WithEvents btn_simpan As Button
    Friend WithEvents btn_hapus As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_jurusan As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_nama As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_id As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_lokasi As TextBox
    Friend WithEvents txt_tingkat As ComboBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents btn_masuk As Button
    Friend WithEvents btn_keluar As Button
End Class
