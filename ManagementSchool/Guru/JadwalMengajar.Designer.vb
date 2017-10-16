<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class JadwalMengajar
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.data_jadwal = New System.Windows.Forms.DataGridView()
        CType(Me.data_jadwal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Goldenrod
        Me.Label2.Font = New System.Drawing.Font("Lucida Sans", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(-6, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(743, 60)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "JADWAL MENGAJAR"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'data_jadwal
        '
        Me.data_jadwal.AllowUserToAddRows = False
        Me.data_jadwal.AllowUserToDeleteRows = False
        Me.data_jadwal.AllowUserToOrderColumns = True
        Me.data_jadwal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.data_jadwal.Location = New System.Drawing.Point(12, 91)
        Me.data_jadwal.Name = "data_jadwal"
        Me.data_jadwal.ReadOnly = True
        Me.data_jadwal.Size = New System.Drawing.Size(717, 312)
        Me.data_jadwal.TabIndex = 9
        '
        'JadwalMengajar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(741, 415)
        Me.Controls.Add(Me.data_jadwal)
        Me.Controls.Add(Me.Label2)
        Me.Name = "JadwalMengajar"
        Me.Text = "JadwalMengajar"
        CType(Me.data_jadwal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents data_jadwal As DataGridView
End Class
