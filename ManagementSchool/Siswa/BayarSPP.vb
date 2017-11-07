Public Class BayarSPP
    Dim conn As New SqlClient.SqlConnection()
    Dim rd As SqlClient.SqlDataReader

    Public id_siswa As String
    Public id_spp As String
    Public total_pembayaran As Integer = 0
    Private Sub BayarSPP_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.ConnectionString = generateConnString()
        conn.Open()

        refreshData()

    End Sub

    Private Sub refreshData()
        'Dim sql As String = "SELECT * FROM tbl_spp WHERE nis = '" + Me.Tag + "'"
        Dim sql As String = "SELECT tbl_det_spp.bulan as bulan, tbl_det_spp.tanggal_bayar as tanggal_bayar, tbl_det_spp.jumlah_bayar as jumlah_bayar ,tbl_spp.tahun_ajaran as tahun_ajaran , tbl_spp.total_pembayaran as total_pembayaran FROM tbl_spp INNER JOIN tbl_det_spp ON tbl_spp.id_spp = tbl_det_spp.id_spp  WHERE tbl_spp.nis = '" + id_siswa + "'"
        Dim cmnd As New SqlClient.SqlCommand(sql, conn)
        rd = cmnd.ExecuteReader
        rd.Read()
        If rd.HasRows Then
            Me.lbl_tahun.Text = rd.Item("tahun_ajaran")
            Me.total_pembayaran = rd.Item("total_pembayaran")

            While rd.Read()
                Select Case rd.Item("bulan").ToString
                    Case "Januari"
                        Me.lbl_januari.Text = "Lunas"
                    Case "Februari"
                        Me.lbl_februari.Text = "Lunas"
                    Case "Maret"
                        Me.lbl_maret.Text = "Lunas"
                    Case "April"
                        Me.lbl_april.Text = "Lunas"
                    Case "Mei"
                        Me.lbl_mei.Text = "Lunas"
                    Case "Juni"
                        Me.lbl_juni.Text = "Lunas"
                    Case "Juli"
                        Me.lbl_juli.Text = "Lunas"
                    Case "Agustus"
                        Me.lbl_agustus.Text = "Lunas"
                    Case "September"
                        Me.lbl_september.Text = "Lunas"
                    Case "Oktober"
                        Me.lbl_oktobe.Text = "Lunas"
                    Case "November"
                        Me.lbl_november.Text = "Lunas"
                    Case "Desember"
                        Me.lbl_desember.Text = "Lunas"
                End Select
            End While
        End If
        rd.Close()
    End Sub

    Private Sub btn_bayar_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim sql As String = "INSERT INTO tbl_det_spp (id_det_spp,id_spp,bulan,tanggal_bayar,jumlah_bayar,is_accept) VALUES (@v1,@v2,@v3,@v4,@v5,@v6)"

        Using cmnd As New SqlClient.SqlCommand(sql, conn)

            cmnd.Parameters.AddWithValue("@v1", generateID("id_det_spp", conn))
            cmnd.Parameters.AddWithValue("@v2", id_spp)
            cmnd.Parameters.AddWithValue("@v3", Me.cmb_bulan.Text)
            cmnd.Parameters.AddWithValue("@v4", Date.Now)
            cmnd.Parameters.AddWithValue("@v5", 255000)
            cmnd.Parameters.AddWithValue("@v6", 0)

            If MessageBox.Show("Apakah Anda ingin membayar SPP?", "Bayar SPP", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                cmnd.ExecuteNonQuery()




                MessageBox.Show("Selamat Anda berhasil membayar SPP, Untuk Konfirmasi pembayaran tolong ke loket TU", "SELAMAT", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            End If
        End Using
        refreshData()
    End Sub

End Class