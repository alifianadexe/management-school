Public Class ManagemenSPP

    Dim conn As New SqlClient.SqlConnection()
    Dim rd As SqlClient.SqlDataReader

    Dim total_pembayaran As Integer = 0
    Dim id_det_spp As String = ""
    Dim id_spp As String = ""

    Private Sub ManagemenSPP_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.ConnectionString = generateConnString()
        conn.Open()

        refreshData()
    End Sub

    Private Sub refreshData()
        Dim sql As String = "SELECT tbl_det_spp.id_det_spp, tbl_spp.id_spp , nama_siswa, bulan , tanggal_bayar, jumlah_bayar as [Jumlah Bayar (Rp.)] , total_pembayaran as [Total Pembayaran (Rp.)] FROM (tbl_spp INNER JOIN tbl_siswa ON tbl_siswa.nis = tbl_spp.nis) INNER JOIN tbl_det_spp ON tbl_spp.id_spp = tbl_det_spp.id_spp"
        Dim adapter As New SqlClient.SqlDataAdapter(sql, conn)
        Dim dt As New DataTable

        adapter.Fill(dt)

        data_grid.DataSource = dt

        data_grid.Columns(5).DefaultCellStyle.Format = "##,##0.00"
        data_grid.Columns(6).DefaultCellStyle.Format = "##,##0.00"

    End Sub

    Private Sub btn_accept_Click(sender As Object, e As EventArgs) Handles btn_accept.Click
        If Not id_det_spp = "" Then

            Dim sql As String = "UPDATE tbl_det_spp SET is_accept = 1 WHERE id_det_spp = '" + id_det_spp + "'"
            Dim cmnd As New SqlClient.SqlCommand(sql, conn)

            If MessageBox.Show("Konfirmasi Pembayaraan Ini?", "Confirm?", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) = DialogResult.Yes Then

                cmnd.ExecuteNonQuery()

                total_pembayaran += 255000

                Dim sql_tambah As String = "UPDATE tbl_spp SET total_pembayaran = " + total_pembayaran + " WHERE id_spp = '" + id_spp + "'"
                Dim cmnd_tambah As New SqlClient.SqlCommand(sql_tambah, conn)
                cmnd_tambah.ExecuteNonQuery()
                MessageBox.Show("Pembayaran Berhasil Dikonfirmasi", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            End If
        Else
            MessageBox.Show("Pilih Data Dahulu", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)
        End If

    End Sub

    Private Sub data_grid_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles data_grid.CellClick
        If e.RowIndex > 0 Then
            id_det_spp = data_grid.Rows(e.RowIndex).Cells(0).Value.ToString
            id_spp = data_grid.Rows(e.RowIndex).Cells(0).Value.ToString
            total_pembayaran = data_grid.Rows(e.RowIndex).Cells(6).Value.ToString

        End If
    End Sub
End Class