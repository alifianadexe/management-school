<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ManagementGuru
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btn_hapus = New System.Windows.Forms.Button()
        Me.btn_edit = New System.Windows.Forms.Button()
        Me.btn_simpan = New System.Windows.Forms.Button()
        Me.btn_tambah = New System.Windows.Forms.Button()
        Me.data_grid = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btn_browse = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_studi = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_no_hp = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_date_lahir = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_jenis_kelamin = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_alamat = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_nama = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_nis = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        CType(Me.data_grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_hapus
        '
        Me.btn_hapus.Location = New System.Drawing.Point(575, 191)
        Me.btn_hapus.Name = "btn_hapus"
        Me.btn_hapus.Size = New System.Drawing.Size(142, 50)
        Me.btn_hapus.TabIndex = 6
        Me.btn_hapus.Text = "Hapus"
        Me.btn_hapus.UseVisualStyleBackColor = True
        '
        'btn_edit
        '
        Me.btn_edit.Location = New System.Drawing.Point(575, 135)
        Me.btn_edit.Name = "btn_edit"
        Me.btn_edit.Size = New System.Drawing.Size(142, 50)
        Me.btn_edit.TabIndex = 5
        Me.btn_edit.Text = "Edit"
        Me.btn_edit.UseVisualStyleBackColor = True
        '
        'btn_simpan
        '
        Me.btn_simpan.Location = New System.Drawing.Point(575, 79)
        Me.btn_simpan.Name = "btn_simpan"
        Me.btn_simpan.Size = New System.Drawing.Size(142, 50)
        Me.btn_simpan.TabIndex = 4
        Me.btn_simpan.Text = "Simpan"
        Me.btn_simpan.UseVisualStyleBackColor = True
        '
        'btn_tambah
        '
        Me.btn_tambah.Location = New System.Drawing.Point(575, 23)
        Me.btn_tambah.Name = "btn_tambah"
        Me.btn_tambah.Size = New System.Drawing.Size(142, 50)
        Me.btn_tambah.TabIndex = 3
        Me.btn_tambah.Text = "Tambah"
        Me.btn_tambah.UseVisualStyleBackColor = True
        '
        'data_grid
        '
        Me.data_grid.AllowUserToAddRows = False
        Me.data_grid.AllowUserToDeleteRows = False
        Me.data_grid.AllowUserToOrderColumns = True
        Me.data_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.data_grid.Location = New System.Drawing.Point(12, 280)
        Me.data_grid.Name = "data_grid"
        Me.data_grid.ReadOnly = True
        Me.data_grid.Size = New System.Drawing.Size(705, 217)
        Me.data_grid.TabIndex = 11
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btn_browse)
        Me.GroupBox2.Controls.Add(Me.PictureBox1)
        Me.GroupBox2.Location = New System.Drawing.Point(331, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(206, 233)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Foto Profile"
        '
        'btn_browse
        '
        Me.btn_browse.Enabled = False
        Me.btn_browse.Location = New System.Drawing.Point(33, 182)
        Me.btn_browse.Name = "btn_browse"
        Me.btn_browse.Size = New System.Drawing.Size(143, 29)
        Me.btn_browse.TabIndex = 0
        Me.btn_browse.Text = "Browse"
        Me.btn_browse.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.ManagementSchool.My.Resources.Resources.anonymous_user_profile
        Me.PictureBox1.Location = New System.Drawing.Point(33, 22)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(143, 151)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txt_studi)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txt_no_hp)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txt_date_lahir)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txt_jenis_kelamin)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txt_alamat)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txt_nama)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txt_nis)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(313, 233)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Data Diri"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(10, 155)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(67, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Bidang Studi"
        '
        'txt_studi
        '
        Me.txt_studi.Enabled = False
        Me.txt_studi.FormattingEnabled = True
        Me.txt_studi.Location = New System.Drawing.Point(89, 152)
        Me.txt_studi.Name = "txt_studi"
        Me.txt_studi.Size = New System.Drawing.Size(181, 21)
        Me.txt_studi.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(10, 208)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "No HP"
        '
        'txt_no_hp
        '
        Me.txt_no_hp.Enabled = False
        Me.txt_no_hp.Location = New System.Drawing.Point(89, 205)
        Me.txt_no_hp.Name = "txt_no_hp"
        Me.txt_no_hp.Size = New System.Drawing.Size(201, 20)
        Me.txt_no_hp.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(11, 182)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Tanggal Lahir"
        '
        'txt_date_lahir
        '
        Me.txt_date_lahir.Enabled = False
        Me.txt_date_lahir.Location = New System.Drawing.Point(89, 179)
        Me.txt_date_lahir.Name = "txt_date_lahir"
        Me.txt_date_lahir.Size = New System.Drawing.Size(200, 20)
        Me.txt_date_lahir.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(10, 129)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Jenis Kelamin"
        '
        'txt_jenis_kelamin
        '
        Me.txt_jenis_kelamin.Enabled = False
        Me.txt_jenis_kelamin.FormattingEnabled = True
        Me.txt_jenis_kelamin.Items.AddRange(New Object() {"Laki - Laki", "Perempuan"})
        Me.txt_jenis_kelamin.Location = New System.Drawing.Point(89, 126)
        Me.txt_jenis_kelamin.Name = "txt_jenis_kelamin"
        Me.txt_jenis_kelamin.Size = New System.Drawing.Size(143, 21)
        Me.txt_jenis_kelamin.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Alamat"
        '
        'txt_alamat
        '
        Me.txt_alamat.Enabled = False
        Me.txt_alamat.Location = New System.Drawing.Point(89, 71)
        Me.txt_alamat.Multiline = True
        Me.txt_alamat.Name = "txt_alamat"
        Me.txt_alamat.Size = New System.Drawing.Size(201, 49)
        Me.txt_alamat.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Nama Guru"
        '
        'txt_nama
        '
        Me.txt_nama.Enabled = False
        Me.txt_nama.Location = New System.Drawing.Point(89, 45)
        Me.txt_nama.Name = "txt_nama"
        Me.txt_nama.Size = New System.Drawing.Size(201, 20)
        Me.txt_nama.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(25, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "NIP"
        '
        'txt_nis
        '
        Me.txt_nis.Enabled = False
        Me.txt_nis.Location = New System.Drawing.Point(89, 19)
        Me.txt_nis.Name = "txt_nis"
        Me.txt_nis.Size = New System.Drawing.Size(100, 20)
        Me.txt_nis.TabIndex = 0
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(460, 257)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(47, 13)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Search :"
        '
        'TextBox1
        '
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(513, 254)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(201, 20)
        Me.TextBox1.TabIndex = 7
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'ManagementGuru
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(726, 509)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btn_hapus)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.btn_edit)
        Me.Controls.Add(Me.btn_simpan)
        Me.Controls.Add(Me.btn_tambah)
        Me.Controls.Add(Me.data_grid)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "ManagementGuru"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ManagementGuru"
        CType(Me.data_grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_hapus As Button
    Friend WithEvents btn_edit As Button
    Friend WithEvents btn_simpan As Button
    Friend WithEvents btn_tambah As Button
    Friend WithEvents data_grid As DataGridView
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btn_browse As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_no_hp As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_date_lahir As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_jenis_kelamin As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_alamat As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_nama As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_nis As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_studi As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
