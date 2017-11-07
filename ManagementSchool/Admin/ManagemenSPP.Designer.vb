<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManagemenSPP
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
        Me.data_grid = New System.Windows.Forms.DataGridView()
        Me.btn_batal = New System.Windows.Forms.Button()
        Me.btn_accept = New System.Windows.Forms.Button()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        CType(Me.data_grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'data_grid
        '
        Me.data_grid.AllowUserToAddRows = False
        Me.data_grid.AllowUserToDeleteRows = False
        Me.data_grid.AllowUserToOrderColumns = True
        Me.data_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.data_grid.Location = New System.Drawing.Point(12, 12)
        Me.data_grid.Name = "data_grid"
        Me.data_grid.ReadOnly = True
        Me.data_grid.Size = New System.Drawing.Size(755, 451)
        Me.data_grid.TabIndex = 0
        '
        'btn_batal
        '
        Me.btn_batal.Location = New System.Drawing.Point(12, 469)
        Me.btn_batal.Name = "btn_batal"
        Me.btn_batal.Size = New System.Drawing.Size(130, 45)
        Me.btn_batal.TabIndex = 5
        Me.btn_batal.Text = "Cancel"
        Me.btn_batal.UseVisualStyleBackColor = True
        '
        'btn_accept
        '
        Me.btn_accept.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.btn_accept.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_accept.Location = New System.Drawing.Point(371, 469)
        Me.btn_accept.Name = "btn_accept"
        Me.btn_accept.Size = New System.Drawing.Size(208, 45)
        Me.btn_accept.TabIndex = 6
        Me.btn_accept.Text = "Accept"
        Me.btn_accept.UseVisualStyleBackColor = False
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'ManagemenSPP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(812, 530)
        Me.Controls.Add(Me.btn_accept)
        Me.Controls.Add(Me.btn_batal)
        Me.Controls.Add(Me.data_grid)
        Me.Name = "ManagemenSPP"
        Me.Text = "ManagemenSPP"
        CType(Me.data_grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents data_grid As DataGridView
    Friend WithEvents btn_batal As Button
    Friend WithEvents btn_accept As Button
    Friend WithEvents PrintDialog1 As PrintDialog
End Class
