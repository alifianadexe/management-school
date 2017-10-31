Public Class BayarSPP
    Dim conn As New SqlClient.SqlConnection()
    Dim rd As SqlClient.SqlDataReader

    Dim id_siswa As String = ""
    Dim id_spp As String = ""
    Private Sub BayarSPP_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.ConnectionString = generateConnString()
        conn.Open()

        refreshData()
    End Sub

    Private Sub refreshData()
        Dim sql As String = "SELECT tbl_det_spp.bulan as bulan, tbl_det_spp.tanggal_bayar as tanggal_bayar, tbl_det_spp.jumlah_bayar as jumlah_bayar ,tbl_spp.tahun_ajaran as tahun_ajaran FROM tbl_spp INNER JOIN tbl_det_spp ON tbl_spp.id_spp = tbl_det_spp.id_spp  WHERE tbl_spp.nis = '" + Me.Tag + "'"
        Dim cmnd As New SqlClient.SqlCommand(sql, conn)
        rd = cmnd.ExecuteReader
        rd.Read()
        If rd.HasRows Then
            Me.lbl_tahun.Text = rd.Item("tahun_ajaran")
        End If
    End Sub

    Private Sub btn_bayar_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim sql As String = "INSERT INTO tbl_spp_det "
    End Sub
End Class