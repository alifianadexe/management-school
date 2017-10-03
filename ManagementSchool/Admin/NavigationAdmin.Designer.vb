<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NavigationAdmin
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
        Me.btn_siswa = New System.Windows.Forms.Button()
        Me.btn_guru = New System.Windows.Forms.Button()
        Me.btn_mapel = New System.Windows.Forms.Button()
        Me.btn_jadwal = New System.Windows.Forms.Button()
        Me.btn_kelas = New System.Windows.Forms.Button()
        Me.btn_spp = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_siswa
        '
        Me.btn_siswa.Location = New System.Drawing.Point(14, 291)
        Me.btn_siswa.Name = "btn_siswa"
        Me.btn_siswa.Size = New System.Drawing.Size(200, 62)
        Me.btn_siswa.TabIndex = 0
        Me.btn_siswa.Text = "Management Siswa"
        Me.btn_siswa.UseVisualStyleBackColor = True
        '
        'btn_guru
        '
        Me.btn_guru.Location = New System.Drawing.Point(14, 359)
        Me.btn_guru.Name = "btn_guru"
        Me.btn_guru.Size = New System.Drawing.Size(200, 62)
        Me.btn_guru.TabIndex = 1
        Me.btn_guru.Text = "Management Guru"
        Me.btn_guru.UseVisualStyleBackColor = True
        '
        'btn_mapel
        '
        Me.btn_mapel.Location = New System.Drawing.Point(14, 427)
        Me.btn_mapel.Name = "btn_mapel"
        Me.btn_mapel.Size = New System.Drawing.Size(200, 62)
        Me.btn_mapel.TabIndex = 2
        Me.btn_mapel.Text = "Management Mapel"
        Me.btn_mapel.UseVisualStyleBackColor = True
        '
        'btn_jadwal
        '
        Me.btn_jadwal.Location = New System.Drawing.Point(240, 291)
        Me.btn_jadwal.Name = "btn_jadwal"
        Me.btn_jadwal.Size = New System.Drawing.Size(200, 62)
        Me.btn_jadwal.TabIndex = 3
        Me.btn_jadwal.Text = "Management Jadwal"
        Me.btn_jadwal.UseVisualStyleBackColor = True
        '
        'btn_kelas
        '
        Me.btn_kelas.Location = New System.Drawing.Point(240, 359)
        Me.btn_kelas.Name = "btn_kelas"
        Me.btn_kelas.Size = New System.Drawing.Size(200, 62)
        Me.btn_kelas.TabIndex = 4
        Me.btn_kelas.Text = "Management Kelas"
        Me.btn_kelas.UseVisualStyleBackColor = True
        '
        'btn_spp
        '
        Me.btn_spp.Location = New System.Drawing.Point(240, 427)
        Me.btn_spp.Name = "btn_spp"
        Me.btn_spp.Size = New System.Drawing.Size(200, 62)
        Me.btn_spp.TabIndex = 5
        Me.btn_spp.Text = "Management SPP"
        Me.btn_spp.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Firebrick
        Me.Label2.Font = New System.Drawing.Font("Lucida Sans", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(4, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(459, 78)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "WELCOME ADMIN"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.ManagementSchool.My.Resources.Resources.anonymous_user_profile
        Me.PictureBox1.Location = New System.Drawing.Point(134, 101)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(182, 171)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DarkRed
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button1.Location = New System.Drawing.Point(314, 509)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(142, 39)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Logout"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'NavigationAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(468, 560)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btn_spp)
        Me.Controls.Add(Me.btn_kelas)
        Me.Controls.Add(Me.btn_jadwal)
        Me.Controls.Add(Me.btn_mapel)
        Me.Controls.Add(Me.btn_guru)
        Me.Controls.Add(Me.btn_siswa)
        Me.Name = "NavigationAdmin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "NavigationAdmin"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btn_siswa As Button
    Friend WithEvents btn_guru As Button
    Friend WithEvents btn_mapel As Button
    Friend WithEvents btn_jadwal As Button
    Friend WithEvents btn_kelas As Button
    Friend WithEvents btn_spp As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button1 As Button
End Class
