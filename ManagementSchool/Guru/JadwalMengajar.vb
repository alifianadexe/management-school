Public Class JadwalMengajar
    Dim conn As New SqlClient.SqlConnection()
    Dim rd As SqlClient.SqlDataReader

    Private Sub JadwalMengajar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.ConnectionString = generateConnString()
        conn.Open()

        refreshData()
    End Sub

    Private Sub refreshData()
        Dim sql As String = "SELECT tbl_jadwal.id_jadwal, nama_mapel, nama_kelas, waktu, jumlah_jam FROM ((tbl_jadwal INNER JOIN tbl_mapel ON tbl_mapel.id_mapel = tbl_jadwal.id_mapel) INNER JOIN tbl_guru ON tbl_guru.nip = tbl_jadwal.nip) INNER JOIN tbl_kelas ON tbl_kelas.id_kelas = tbl_jadwal.id_kelas WHERE tbl_guru.nip = '" + Me.Tag + "'"
        Dim adapter As New SqlClient.SqlDataAdapter(sql, conn)
        Dim dt As New DataTable
        adapter.Fill(dt)

        data_jadwal.DataSource = dt
        data_jadwal.Columns(3).DefaultCellStyle.Format = "hh:mm:ss tt"
    End Sub
End Class