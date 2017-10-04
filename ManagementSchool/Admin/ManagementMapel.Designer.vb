<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ManagementMapel
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_min = New System.Windows.Forms.TextBox()
        Me.txt_jam = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_deskripsi = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_nama = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_id = New System.Windows.Forms.TextBox()
        Me.data_grid = New System.Windows.Forms.DataGridView()
        Me.btn_tambah = New System.Windows.Forms.Button()
        Me.btn_simpan = New System.Windows.Forms.Button()
        Me.btn_edit = New System.Windows.Forms.Button()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.data_grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txt_min)
        Me.GroupBox1.Controls.Add(Me.txt_jam)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txt_deskripsi)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txt_nama)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txt_id)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(313, 236)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Data Mapel"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(146, 174)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(26, 13)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Jam"
        '
        'txt_min
        '
        Me.txt_min.Enabled = False
        Me.txt_min.Location = New System.Drawing.Point(89, 197)
        Me.txt_min.Name = "txt_min"
        Me.txt_min.Size = New System.Drawing.Size(51, 20)
        Me.txt_min.TabIndex = 16
        '
        'txt_jam
        '
        Me.txt_jam.Enabled = False
        Me.txt_jam.Location = New System.Drawing.Point(89, 171)
        Me.txt_jam.Name = "txt_jam"
        Me.txt_jam.Size = New System.Drawing.Size(51, 20)
        Me.txt_jam.TabIndex = 15
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(10, 200)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(65, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Nilai Minimal"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(10, 174)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Total Jam"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Deskripsi"
        '
        'txt_deskripsi
        '
        Me.txt_deskripsi.Enabled = False
        Me.txt_deskripsi.Location = New System.Drawing.Point(89, 74)
        Me.txt_deskripsi.Multiline = True
        Me.txt_deskripsi.Name = "txt_deskripsi"
        Me.txt_deskripsi.Size = New System.Drawing.Size(201, 91)
        Me.txt_deskripsi.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Nama Mapel"
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
        Me.Label1.Size = New System.Drawing.Size(50, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "ID Mapel"
        '
        'txt_id
        '
        Me.txt_id.Enabled = False
        Me.txt_id.Location = New System.Drawing.Point(89, 19)
        Me.txt_id.Name = "txt_id"
        Me.txt_id.Size = New System.Drawing.Size(100, 20)
        Me.txt_id.TabIndex = 0
        '
        'data_grid
        '
        Me.data_grid.AllowUserToAddRows = False
        Me.data_grid.AllowUserToDeleteRows = False
        Me.data_grid.AllowUserToOrderColumns = True
        Me.data_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.data_grid.Location = New System.Drawing.Point(331, 12)
        Me.data_grid.Name = "data_grid"
        Me.data_grid.ReadOnly = True
        Me.data_grid.Size = New System.Drawing.Size(450, 236)
        Me.data_grid.TabIndex = 4
        '
        'btn_tambah
        '
        Me.btn_tambah.Location = New System.Drawing.Point(291, 264)
        Me.btn_tambah.Name = "btn_tambah"
        Me.btn_tambah.Size = New System.Drawing.Size(118, 39)
        Me.btn_tambah.TabIndex = 5
        Me.btn_tambah.Text = "Tambah"
        Me.btn_tambah.UseVisualStyleBackColor = True
        '
        'btn_simpan
        '
        Me.btn_simpan.Location = New System.Drawing.Point(415, 264)
        Me.btn_simpan.Name = "btn_simpan"
        Me.btn_simpan.Size = New System.Drawing.Size(118, 39)
        Me.btn_simpan.TabIndex = 6
        Me.btn_simpan.Text = "Simpan"
        Me.btn_simpan.UseVisualStyleBackColor = True
        '
        'btn_edit
        '
        Me.btn_edit.Location = New System.Drawing.Point(539, 264)
        Me.btn_edit.Name = "btn_edit"
        Me.btn_edit.Size = New System.Drawing.Size(118, 39)
        Me.btn_edit.TabIndex = 8
        Me.btn_edit.Text = "Edit"
        Me.btn_edit.UseVisualStyleBackColor = True
        '
        'btn_delete
        '
        Me.btn_delete.Location = New System.Drawing.Point(663, 264)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(118, 39)
        Me.btn_delete.TabIndex = 7
        Me.btn_delete.Text = "Delete"
        Me.btn_delete.UseVisualStyleBackColor = True
        '
        'ManagementMapel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(793, 315)
        Me.Controls.Add(Me.btn_edit)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.btn_simpan)
        Me.Controls.Add(Me.btn_tambah)
        Me.Controls.Add(Me.data_grid)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "ManagementMapel"
        Me.Text = "ManagementMapel"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.data_grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_deskripsi As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_nama As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_id As TextBox
    Friend WithEvents data_grid As DataGridView
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_min As TextBox
    Friend WithEvents txt_jam As TextBox
    Friend WithEvents btn_tambah As Button
    Friend WithEvents btn_simpan As Button
    Friend WithEvents btn_edit As Button
    Friend WithEvents btn_delete As Button
End Class
