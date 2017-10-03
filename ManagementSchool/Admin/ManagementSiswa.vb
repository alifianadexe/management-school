Public Class ManagementSiswa
    Dim conn As New SqlClient.SqlConnection()
    Dim rd As SqlClient.SqlDataReader
    Private Sub ManagementSiswa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.ConnectionString = generateConnString()
        conn.Open()

        refreshData()
    End Sub

    Private Sub refreshData()
        Dim sql As String = "SELECT nis,nama_siswa,jenis_kelamin,tanggal_lahir,no_hp FROM tbl_siswa"
        Dim adapter As New SqlClient.SqlDataAdapter(sql, conn)
        Dim dt As New DataTable
        adapter.Fill(dt)

        data_grid.DataSource = dt

    End Sub
    Private Sub is_enabled(ByVal bool As Boolean)
        Me.txt_jenis_kelamin.Enabled = bool
        Me.txt_alamat.Enabled = bool
        Me.txt_date_lahir.Enabled = bool
        Me.txt_nama.Enabled = bool
        Me.txt_no_hp.Enabled = bool

    End Sub

    Private Sub is_clear()
        Me.txt_nis.Clear()
        Me.txt_alamat.Clear()
        Me.txt_nama.Clear()
        Me.txt_no_hp.Clear()
    End Sub

    Private Sub btn_browse_Click(sender As Object, e As EventArgs) Handles btn_browse.Click
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            PictureBox1.Image = Image.FromFile(OpenFileDialog1.FileName)
        End If
    End Sub
End Class