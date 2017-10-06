Public Class ManagementJadwal
    Dim conn As New SqlClient.SqlConnection
    Dim rd As SqlClient.SqlDataReader
    Dim id As String = ""

    Private Sub ManagementJadwal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.ConnectionString = generateConnString()
        conn.Open()

        refreshData()
        refreshBinding(Me.txt_guru, "SELECT * FROM tbl_guru", "nama_guru", "nip")
        refreshBinding(Me.txt_class, "SELECT * FROM tbl_kelas", "nama_kelas", "id_kelas")
        refreshBinding(Me.txt_mapel, "SELECT * FROM tbl_mapel", "nama_mapel", "id_mapel")

        Me.time_awal.Format = DateTimePickerFormat.Time
        Me.time_akhir.Format = DateTimePickerFormat.Time

    End Sub

    Private Sub refreshData()
        Dim sql As String = "SELECT id_jadwal, nama_mapel, nama_kelas, tingkat, nama_guru, waktu, jumlah_jam FROM ((tbl_jadwal INNER JOIN tbl_mapel ON tbl_mapel.id_mapel = tbl_jadwal.id_mapel) INNER JOIN tbl_kelas ON tbl_jadwal.id_kelas = tbl_kelas.id_kelas) INNER JOIN tbl_guru ON tbl_guru.nip = tbl_jadwal.nip "
        Dim adapter As New SqlClient.SqlDataAdapter(sql, conn)
        Dim dt As New DataTable
        adapter.Fill(dt)

        data_grid.DataSource = dt

        data_grid.Columns(5).DefaultCellStyle.Format = "hh:mm:ss tt"

    End Sub

    Private Sub refreshBinding(ByRef obj As ComboBox, ByVal sql As String, ByVal display As String, ByVal value As String)
        Dim adapter As New SqlClient.SqlDataAdapter(sql, conn)
        Dim dt As New DataTable

        adapter.fill(dt)

        obj.DataSource = dt
        obj.DisplayMember = display
        obj.ValueMember = value
    End Sub

    Private Sub btn_tambah_Click(sender As Object, e As EventArgs) Handles btn_tambah.Click
        is_clear()
        Me.txt_id.Text = generateID("id_jadwal", conn)
        is_enabled(True)
    End Sub

    Private Sub btn_simpan_Click(sender As Object, e As EventArgs) Handles btn_simpan.Click

        Try
            If Me.btn_simpan.Text = "Simpan" Then
                If MessageBox.Show("Apakah Anda Data Ingin Disimpan?", "Simpan", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    Dim time_awal As Integer = Date.Parse(Me.time_awal.Value).Hour
                    Dim time_akhir As Integer = Date.Parse(Me.time_akhir.Value).Hour

                    If time_akhir > time_awal Then
                        Dim time_total As Integer = time_akhir - time_awal
                        Dim sql As String = "INSERT INTO tbl_jadwal (id_jadwal,id_mapel,id_kelas,nip,jumlah_jam,waktu) VALUES (@v1,@v2,@v3,@v4,@v5,@v6)"
                        Using cmnd As New SqlClient.SqlCommand(sql, conn)
                            cmnd.Parameters.AddWithValue("@v1", Me.txt_id.Text)
                            cmnd.Parameters.AddWithValue("@v2", Me.txt_mapel.SelectedValue)
                            cmnd.Parameters.AddWithValue("@v3", Me.txt_class.SelectedValue)
                            cmnd.Parameters.AddWithValue("@v4", Me.txt_guru.SelectedValue)
                            cmnd.Parameters.AddWithValue("@v5", time_total)
                            cmnd.Parameters.AddWithValue("@v6", Date.Parse(Me.time_awal.Value))

                            cmnd.ExecuteNonQuery()
                        End Using
                        MessageBox.Show("Jadwal Berhasil Ditambahkan", "Yatta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)

                    Else
                        MessageBox.Show("Maaf, Rentang Waktu Tidak Sesuai", "Yatta", MessageBoxButtons.OK, MessageBoxIcon.Hand)
                    End If
                End If
            ElseIf Me.btn_simpan.Text = "Update" Then
                If MessageBox.Show("Apakah Anda Data Ingin Diupdate?", "Simpan", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    Dim time_awal As Integer = Date.Parse(Me.time_awal.Value).Hour
                    Dim time_akhir As Integer = Date.Parse(Me.time_akhir.Value).Hour

                    If time_akhir > time_awal Then
                        Dim time_total As Integer = time_akhir - time_awal
                        Dim sql As String = "UPDATE tbl_jadwal SET id_mapel = @v2, id_kelas = @v3, nip = @v4, jumlah_jam = @v5, waktu = @v6 WHERE id_jadwal = @v1"
                        Using cmnd As New SqlClient.SqlCommand(sql, conn)
                            cmnd.Parameters.AddWithValue("@v1", Me.txt_id.Text)
                            cmnd.Parameters.AddWithValue("@v2", Me.txt_mapel.SelectedValue)
                            cmnd.Parameters.AddWithValue("@v3", Me.txt_class.SelectedValue)
                            cmnd.Parameters.AddWithValue("@v4", Me.txt_guru.SelectedValue)
                            cmnd.Parameters.AddWithValue("@v5", time_total)
                            cmnd.Parameters.AddWithValue("@v6", Date.Parse(Me.time_awal.Value))

                            cmnd.ExecuteNonQuery()
                        End Using
                        MessageBox.Show("Jadwal Berhasil Diupdate", "Yatta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)

                    Else
                        MessageBox.Show("Maaf, Rentang Waktu Tidak Sesuai", "Yatta", MessageBoxButtons.OK, MessageBoxIcon.Hand)
                    End If
                End If

            End If
            Me.btn_simpan.Text = "Simpan"

            refreshData()
            is_clear()
            is_enabled(False)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Damme", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            If Not id = "" Then
                If MessageBox.Show("Apakah Anda Data Ingin Didelete?", "Simpan", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    Dim sql As String = "DELETE FROM tbl_jadwal WHERE id_jadwal = '" + id + "'"
                    Dim cmnd As New SqlClient.SqlCommand(sql, conn)
                    cmnd.ExecuteNonQuery()
                    MessageBox.Show("Jadwal Berhasil Diupdate", "Yatta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                    refreshData()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Damme", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

    End Sub

    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click
        is_enabled(True)
        Me.btn_simpan.Text = "Update"
    End Sub

    Private Sub is_enabled(ByVal bool)
        Me.txt_class.Enabled = bool
        Me.txt_guru.Enabled = bool
        Me.txt_mapel.Enabled = bool

        Me.time_akhir.Enabled = bool
        Me.time_awal.Enabled = bool

    End Sub

    Private Sub is_clear()
        Me.txt_id.Clear()
    End Sub

    Private Sub data_grid_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles data_grid.CellClick
        Try
            If e.RowIndex >= 0 Then
                id = data_grid.Rows(e.RowIndex).Cells(0).Value.ToString
                Dim sql As String = "SELECT id_jadwal, nama_mapel, nama_kelas, tingkat, nama_guru, waktu, jumlah_jam FROM ((tbl_jadwal INNER JOIN tbl_mapel ON tbl_mapel.id_mapel = tbl_jadwal.id_mapel) INNER JOIN tbl_kelas ON tbl_jadwal.id_kelas = tbl_kelas.id_kelas) INNER JOIN tbl_guru ON tbl_guru.nip = tbl_jadwal.nip WHERE tbl_jadwal.id_jadwal = '" + id + "'"
                Dim cmnd As New SqlClient.SqlCommand(sql, conn)
                rd = cmnd.ExecuteReader
                rd.Read()
                If rd.HasRows Then
                    Me.txt_class.Text = rd.Item("nama_kelas")
                    Me.txt_guru.Text = rd.Item("nama_guru")
                    Me.txt_mapel.Text = rd.Item("nama_mapel")
                    Me.time_awal.Value = Date.Parse(rd.Item("waktu"))
                    Me.time_akhir.Value = Date.Parse(rd.Item("waktu")).AddHours(rd.Item("jumlah_jam"))
                End If
                rd.Close()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Damme", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

    End Sub

    Private Sub ManagementJadwal_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing


    End Sub
End Class