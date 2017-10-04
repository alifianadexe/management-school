<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManagementJadwal
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btn_tambah = New System.Windows.Forms.Button()
        Me.btn_simpan = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btn_edit = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.txt_class = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_guru = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_mapel = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_id = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.time_awal = New System.Windows.Forms.DateTimePicker()
        Me.time_akhir = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(849, 357)
        Me.DataGridView1.TabIndex = 0
        '
        'btn_tambah
        '
        Me.btn_tambah.Location = New System.Drawing.Point(308, 55)
        Me.btn_tambah.Name = "btn_tambah"
        Me.btn_tambah.Size = New System.Drawing.Size(136, 41)
        Me.btn_tambah.TabIndex = 1
        Me.btn_tambah.Text = "Tambah"
        Me.btn_tambah.UseVisualStyleBackColor = True
        '
        'btn_simpan
        '
        Me.btn_simpan.Location = New System.Drawing.Point(308, 109)
        Me.btn_simpan.Name = "btn_simpan"
        Me.btn_simpan.Size = New System.Drawing.Size(136, 41)
        Me.btn_simpan.TabIndex = 2
        Me.btn_simpan.Text = "Simpan"
        Me.btn_simpan.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button4)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.btn_edit)
        Me.GroupBox1.Controls.Add(Me.time_akhir)
        Me.GroupBox1.Controls.Add(Me.time_awal)
        Me.GroupBox1.Controls.Add(Me.btn_simpan)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.btn_tambah)
        Me.GroupBox1.Controls.Add(Me.txt_id)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txt_mapel)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txt_guru)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txt_class)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 375)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(606, 179)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Profile Jadwal"
        '
        'btn_edit
        '
        Me.btn_edit.Location = New System.Drawing.Point(450, 55)
        Me.btn_edit.Name = "btn_edit"
        Me.btn_edit.Size = New System.Drawing.Size(136, 42)
        Me.btn_edit.TabIndex = 4
        Me.btn_edit.Text = "Edit"
        Me.btn_edit.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(450, 109)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(136, 41)
        Me.Button4.TabIndex = 5
        Me.Button4.Text = "Hapus"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'txt_class
        '
        Me.txt_class.Enabled = False
        Me.txt_class.FormattingEnabled = True
        Me.txt_class.Location = New System.Drawing.Point(91, 55)
        Me.txt_class.Name = "txt_class"
        Me.txt_class.Size = New System.Drawing.Size(192, 21)
        Me.txt_class.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Class"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Guru"
        '
        'txt_guru
        '
        Me.txt_guru.Enabled = False
        Me.txt_guru.FormattingEnabled = True
        Me.txt_guru.Location = New System.Drawing.Point(91, 82)
        Me.txt_guru.Name = "txt_guru"
        Me.txt_guru.Size = New System.Drawing.Size(192, 21)
        Me.txt_guru.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(19, 112)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Mapel"
        '
        'txt_mapel
        '
        Me.txt_mapel.Enabled = False
        Me.txt_mapel.FormattingEnabled = True
        Me.txt_mapel.Location = New System.Drawing.Point(91, 109)
        Me.txt_mapel.Name = "txt_mapel"
        Me.txt_mapel.Size = New System.Drawing.Size(192, 21)
        Me.txt_mapel.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(20, 142)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(26, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Jam"
        '
        'txt_id
        '
        Me.txt_id.Enabled = False
        Me.txt_id.Location = New System.Drawing.Point(91, 28)
        Me.txt_id.Name = "txt_id"
        Me.txt_id.Size = New System.Drawing.Size(100, 20)
        Me.txt_id.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(19, 31)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "ID Jadwal"
        '
        'time_awal
        '
        Me.time_awal.Enabled = False
        Me.time_awal.Location = New System.Drawing.Point(91, 139)
        Me.time_awal.Name = "time_awal"
        Me.time_awal.Size = New System.Drawing.Size(61, 20)
        Me.time_awal.TabIndex = 10
        '
        'time_akhir
        '
        Me.time_akhir.Enabled = False
        Me.time_akhir.Location = New System.Drawing.Point(222, 139)
        Me.time_akhir.Name = "time_akhir"
        Me.time_akhir.Size = New System.Drawing.Size(61, 20)
        Me.time_akhir.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(166, 142)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(42, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Sampai"
        '
        'ManagementJadwal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(873, 580)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "ManagementJadwal"
        Me.Text = "ManagementJadwal"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btn_tambah As Button
    Friend WithEvents btn_simpan As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btn_edit As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_mapel As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_guru As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_class As ComboBox
    Friend WithEvents Button4 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_id As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents time_akhir As DateTimePicker
    Friend WithEvents time_awal As DateTimePicker
End Class
