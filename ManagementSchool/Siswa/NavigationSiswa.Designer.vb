<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NavigationSiswa
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
        Me.btn_logout = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lbl_no_telp = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lbl_nama = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lbl_nip = New System.Windows.Forms.Label()
        Me.lbl_ = New System.Windows.Forms.Label()
        Me.btn_edit = New System.Windows.Forms.Button()
        Me.btn_jadwal = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbl_alamat = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lbl_jenis = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lbl_tanggal_lahir = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_logout
        '
        Me.btn_logout.BackColor = System.Drawing.Color.DarkRed
        Me.btn_logout.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_logout.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_logout.Location = New System.Drawing.Point(328, 460)
        Me.btn_logout.Name = "btn_logout"
        Me.btn_logout.Size = New System.Drawing.Size(142, 39)
        Me.btn_logout.TabIndex = 24
        Me.btn_logout.Text = "Logout"
        Me.btn_logout.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lbl_alamat)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.lbl_jenis)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.lbl_tanggal_lahir)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.lbl_no_telp)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.lbl_nama)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.lbl_nip)
        Me.GroupBox1.Controls.Add(Me.lbl_)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.btn_edit)
        Me.GroupBox1.Location = New System.Drawing.Point(17, 72)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(451, 285)
        Me.GroupBox1.TabIndex = 23
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Data Siswa"
        '
        'lbl_no_telp
        '
        Me.lbl_no_telp.AutoSize = True
        Me.lbl_no_telp.Font = New System.Drawing.Font("Maiandra GD", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_no_telp.Location = New System.Drawing.Point(267, 105)
        Me.lbl_no_telp.Name = "lbl_no_telp"
        Me.lbl_no_telp.Size = New System.Drawing.Size(48, 15)
        Me.lbl_no_telp.TabIndex = 17
        Me.lbl_no_telp.Text = "Label6"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(175, 105)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(63, 13)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "No Telepon"
        '
        'lbl_nama
        '
        Me.lbl_nama.AutoSize = True
        Me.lbl_nama.Font = New System.Drawing.Font("Maiandra GD", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nama.Location = New System.Drawing.Point(267, 75)
        Me.lbl_nama.Name = "lbl_nama"
        Me.lbl_nama.Size = New System.Drawing.Size(48, 15)
        Me.lbl_nama.TabIndex = 15
        Me.lbl_nama.Text = "Label4"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(175, 75)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 13)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Nama Siswa"
        '
        'lbl_nip
        '
        Me.lbl_nip.AutoSize = True
        Me.lbl_nip.Font = New System.Drawing.Font("Maiandra GD", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nip.Location = New System.Drawing.Point(267, 47)
        Me.lbl_nip.Name = "lbl_nip"
        Me.lbl_nip.Size = New System.Drawing.Size(48, 15)
        Me.lbl_nip.TabIndex = 13
        Me.lbl_nip.Text = "Label3"
        '
        'lbl_
        '
        Me.lbl_.AutoSize = True
        Me.lbl_.Location = New System.Drawing.Point(175, 47)
        Me.lbl_.Name = "lbl_"
        Me.lbl_.Size = New System.Drawing.Size(25, 13)
        Me.lbl_.TabIndex = 12
        Me.lbl_.Text = "NIS"
        '
        'btn_edit
        '
        Me.btn_edit.Location = New System.Drawing.Point(341, 244)
        Me.btn_edit.Name = "btn_edit"
        Me.btn_edit.Size = New System.Drawing.Size(104, 30)
        Me.btn_edit.TabIndex = 10
        Me.btn_edit.Text = "Edit"
        Me.btn_edit.UseVisualStyleBackColor = True
        '
        'btn_jadwal
        '
        Me.btn_jadwal.BackColor = System.Drawing.Color.Teal
        Me.btn_jadwal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_jadwal.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_jadwal.Location = New System.Drawing.Point(34, 363)
        Me.btn_jadwal.Name = "btn_jadwal"
        Me.btn_jadwal.Size = New System.Drawing.Size(200, 50)
        Me.btn_jadwal.TabIndex = 22
        Me.btn_jadwal.Text = "Jadwal Kelas"
        Me.btn_jadwal.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Green
        Me.Label2.Font = New System.Drawing.Font("Lucida Sans", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(-6, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(493, 60)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "WELCOME STUDENT"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_alamat
        '
        Me.lbl_alamat.Font = New System.Drawing.Font("Maiandra GD", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_alamat.Location = New System.Drawing.Point(267, 178)
        Me.lbl_alamat.Name = "lbl_alamat"
        Me.lbl_alamat.Size = New System.Drawing.Size(178, 63)
        Me.lbl_alamat.TabIndex = 31
        Me.lbl_alamat.Text = "Label8"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(175, 178)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(39, 13)
        Me.Label11.TabIndex = 30
        Me.Label11.Text = "Alamat"
        '
        'lbl_jenis
        '
        Me.lbl_jenis.AutoSize = True
        Me.lbl_jenis.Font = New System.Drawing.Font("Maiandra GD", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_jenis.Location = New System.Drawing.Point(267, 154)
        Me.lbl_jenis.Name = "lbl_jenis"
        Me.lbl_jenis.Size = New System.Drawing.Size(48, 15)
        Me.lbl_jenis.TabIndex = 29
        Me.lbl_jenis.Text = "Label8"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(175, 154)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(71, 13)
        Me.Label8.TabIndex = 28
        Me.Label8.Text = "Jenis Kelamin"
        '
        'lbl_tanggal_lahir
        '
        Me.lbl_tanggal_lahir.AutoSize = True
        Me.lbl_tanggal_lahir.Font = New System.Drawing.Font("Maiandra GD", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_tanggal_lahir.Location = New System.Drawing.Point(267, 130)
        Me.lbl_tanggal_lahir.Name = "lbl_tanggal_lahir"
        Me.lbl_tanggal_lahir.Size = New System.Drawing.Size(48, 15)
        Me.lbl_tanggal_lahir.TabIndex = 27
        Me.lbl_tanggal_lahir.Text = "Label8"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(175, 130)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 13)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "Tanggal Lahir"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Teal
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button1.Location = New System.Drawing.Point(240, 363)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(200, 50)
        Me.Button1.TabIndex = 25
        Me.Button1.Text = "Bayar SPP"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(17, 38)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(136, 170)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'NavigationSiswa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(482, 509)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btn_logout)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btn_jadwal)
        Me.Controls.Add(Me.Label2)
        Me.Name = "NavigationSiswa"
        Me.Text = "NavigationSiswa"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btn_logout As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lbl_no_telp As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lbl_nama As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lbl_nip As Label
    Friend WithEvents lbl_ As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btn_edit As Button
    Friend WithEvents btn_jadwal As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents lbl_alamat As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents lbl_jenis As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lbl_tanggal_lahir As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Button1 As Button
End Class
