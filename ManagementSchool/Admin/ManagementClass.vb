Public Class ManagementClass

    Dim conn As New SqlClient.SqlConnection
    Dim rd As SqlClient.SqlDataReader
    Dim id As String = ""
    Dim id_siswa As String = ""
    Dim id_jadwal As String = ""

    Private Sub ManagementClass_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.ConnectionString = generateConnString()
        conn.Open()



        refreshData(Me.data_grid_all, "SELECT nis, nama_siswa FROM tbl_siswa")
        refreshData(Me.data_grid_class, "SELECT tbl_siswa.nis,tbl_siswa.nama_siswa FROM ((tbl_siswa INNER JOIN tbl_det_jadwal ON tbl_det_jadwal.nis = tbl_siswa.nis)INNER JOIN tbl_jadwal ON tbl_jadwal.id_jadwal = tbl_det_jadwal.id_jadwal)INNER JOIN tbl_kelas ON tbl_kelas.id_kelas = tbl_jadwal.id_kelas WHERE tbl_kelas.id_kelas = '" + id + "' AND tbl_jadwal.id_jadwal = '" + id_jadwal + "'")
        refreshBinding(Me.txt_pil_kelas, "SELECT * FROM tbl_kelas", "nama_kelas", "id_kelas")

        refreshBinding(Me.txt_jadwal, "SELECT * FROM (tbl_jadwal INNER JOIN tbl_kelas ON tbl_kelas.id_kelas = tbl_jadwal.id_kelas)INNER JOIN tbl_mapel ON tbl_mapel.id_mapel = tbl_jadwal.id_mapel WHERE tbl_jadwal.id_kelas = '" + id + "'", "nama_mapel", "tbl_jadwal.id_jadwal")

    End Sub

    Private Sub refreshData(ByRef obj As DataGridView, ByVal sql As String)
        Dim adapter As New SqlClient.SqlDataAdapter(sql, conn)
        Dim dt As New DataTable
        adapter.Fill(dt)

        obj.DataSource = dt
    End Sub

    Private Sub refreshBinding(ByRef obj As ComboBox, ByVal sql As String, ByVal display As String, ByVal value As String)
        Dim adapter As New SqlClient.SqlDataAdapter(sql, conn)
        Dim dt As New DataTable
        adapter.Fill(dt)

        obj.DataSource = dt
        obj.DisplayMember = display
        obj.ValueMember = value
    End Sub


    Private Sub is_enabled(ByVal bool As Boolean)
        Me.txt_jurusan.Enabled = bool
        Me.txt_lokasi.Enabled = bool
        Me.txt_nama.Enabled = bool
        Me.txt_tingkat.Enabled = bool
    End Sub

    Private Sub is_clear()
        Me.txt_id.Clear()
        Me.txt_jurusan.Clear()
        Me.txt_lokasi.Clear()
        Me.txt_nama.Clear()

    End Sub

    Private Sub btn_tambah_Click(sender As Object, e As EventArgs) Handles btn_tambah.Click
        is_clear()
        Me.txt_id.Text = generateID("id_kelas", conn)
        is_enabled(True)
    End Sub

    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click
        is_enabled(True)
        Me.btn_simpan.Text = "Update"
    End Sub

    Private Sub btn_hapus_Click(sender As Object, e As EventArgs) Handles btn_hapus.Click
        If id = "" Then
            If MessageBox.Show("Hapus Kelas Ini ?", "Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Dim sql As String = "DELETE FROM tbl_kelas WHERE id_kelas ='" + id + "'"
                Dim cmnd As New SqlClient.SqlCommand(sql, conn)
                cmnd.ExecuteNonQuery()
                MessageBox.Show("Kelas Berhasil Dihapus", "Yatta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            End If
        Else
            MessageBox.Show("Pilih Data terlebih dahulu")
        End If
    End Sub

    Private Sub btn_simpan_Click(sender As Object, e As EventArgs) Handles btn_simpan.Click
        Try
            If cekEmptyTextbox(Me.txt_jurusan, Me.txt_lokasi, Me.txt_nama) Then
                If Me.btn_simpan.Text = "Simpan" Then
                    If MessageBox.Show("Apakah Data Sudah Benar ?", "Benar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                        Dim sql As String = "INSERT INTO tbl_kelas (id_kelas,nama_kelas,jurusan,tingkat,lokasi) VALUES (@v1,@v2,@v3,@v4,@v5)"
                        Using cmnd As New SqlClient.SqlCommand(sql, conn)
                            cmnd.Parameters.AddWithValue("@v1", Me.txt_id.Text)
                            cmnd.Parameters.AddWithValue("@v2", Me.txt_nama.Text)
                            cmnd.Parameters.AddWithValue("@v3", Me.txt_jurusan.Text)
                            cmnd.Parameters.AddWithValue("@v4", Me.txt_tingkat.Text)
                            cmnd.Parameters.AddWithValue("@v5", Me.txt_lokasi.Text)

                            cmnd.ExecuteNonQuery()
                            MessageBox.Show("Kelas Berhasil Ditambahkan", "Yatta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                        End Using
                    End If
                ElseIf Me.btn_simpan.Text = "Update" Then
                    If MessageBox.Show("Apakah Data Ingin Diupdate ?", "Benar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                        Dim sql As String = "UPDATE tbl_kelas SET nama_kelas = @v2, jurusan = @v3, tingkat = @v4, lokasi = @v5 WHERE id_kelas = @v1"
                        Using cmnd As New SqlClient.SqlCommand(sql, conn)
                            cmnd.Parameters.AddWithValue("@v1", Me.txt_id.Text)
                            cmnd.Parameters.AddWithValue("@v2", Me.txt_nama.Text)
                            cmnd.Parameters.AddWithValue("@v3", Me.txt_jurusan.Text)
                            cmnd.Parameters.AddWithValue("@v4", Me.txt_tingkat.Text)
                            cmnd.Parameters.AddWithValue("@v5", Me.txt_lokasi.Text)

                            cmnd.ExecuteNonQuery()
                            MessageBox.Show("Kelas Berhasil Diupdate", "Yatta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                        End Using
                    End If
                End If
                refreshBinding(Me.txt_pil_kelas, "SELECT * FROM tbl_kelas", "nama_kelas", "id_kelas")
                is_enabled(False)
                is_clear()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Damme", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txt_pil_kelas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txt_pil_kelas.SelectedIndexChanged
        Try
            id = Me.txt_pil_kelas.SelectedValue.ToString
            id_jadwal = Me.txt_jadwal.SelectedValue
            Dim sql As String = "SELECT * FROM tbl_kelas WHERE id_kelas = '" + id + "'"
            Dim cmnd As New SqlClient.SqlCommand(sql, conn)
            rd = cmnd.ExecuteReader
            rd.Read()

            If rd.HasRows Then
                Me.txt_id.Text = id
                Me.txt_jurusan.Text = rd.Item("jurusan")
                Me.txt_lokasi.Text = rd.Item("lokasi")
                Me.txt_nama.Text = rd.Item("nama_kelas")
                Me.txt_tingkat.Text = rd.Item("tingkat")
            End If
            rd.Close()


            refreshData(Me.data_grid_class, "SELECT tbl_siswa.nis,tbl_siswa.nama_siswa FROM ((tbl_siswa INNER JOIN tbl_det_jadwal ON tbl_det_jadwal.nis = tbl_siswa.nis)INNER JOIN tbl_jadwal ON tbl_jadwal.id_jadwal = tbl_det_jadwal.id_jadwal)INNER JOIN tbl_kelas ON tbl_kelas.id_kelas = tbl_jadwal.id_kelas WHERE tbl_kelas.id_kelas = '" + id + "' AND tbl_jadwal.id_jadwal = '" + id_jadwal + "'")

            refreshBinding(Me.txt_jadwal, "SELECT tbl_mapel.nama_mapel as [nama_mapel], tbl_jadwal.id_jadwal as [id_jadwal] FROM (tbl_jadwal INNER JOIN tbl_kelas ON tbl_kelas.id_kelas = tbl_jadwal.id_kelas)INNER JOIN tbl_mapel ON tbl_mapel.id_mapel = tbl_jadwal.id_mapel WHERE tbl_kelas.id_kelas = '" + id + "'", "nama_mapel", "id_jadwal")

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Damme", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try


    End Sub

    Private Sub btn_keluar_Click(sender As Object, e As EventArgs) Handles btn_keluar.Click
        If MessageBox.Show("Keluar kan siswa dari kelas ini ?", "Benar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Try
                Dim sql As String = "DELETE FROM tbl_det_jadwal WHERE id_jadwal = @v1 AND nis = @v2"
                Using cmnd As New SqlClient.SqlCommand(sql, conn) '
                    cmnd.Parameters.AddWithValue("@v1", Me.txt_jadwal.SelectedValue)
                    cmnd.Parameters.AddWithValue("@v2", id_siswa)

                    cmnd.ExecuteNonQuery()
                    MessageBox.Show("Siswa Berhasil di keluarkan dari kelas", "Yatta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                End Using
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Damme", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If

        refreshData(Me.data_grid_class, "SELECT tbl_siswa.nis,tbl_siswa.nama_siswa FROM ((tbl_siswa INNER JOIN tbl_det_jadwal ON tbl_det_jadwal.nis = tbl_siswa.nis)INNER JOIN tbl_jadwal ON tbl_jadwal.id_jadwal = tbl_det_jadwal.id_jadwal)INNER JOIN tbl_kelas ON tbl_kelas.id_kelas = tbl_jadwal.id_kelas WHERE tbl_kelas.id_kelas = '" + id + "' AND tbl_jadwal.id_jadwal = '" + id_jadwal + "'")

        Me.btn_masuk.Enabled = False
        Me.btn_keluar.Enabled = False

    End Sub

    Private Sub btn_masuk_Click(sender As Object, e As EventArgs) Handles btn_masuk.Click
        If MessageBox.Show("Tambahkan siswa ke kelas ini ?", "Benar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Try
                Dim sql As String = "INSERT INTO tbl_det_jadwal (id_jadwal,nis) VALUES (@v1,@v2)"
                Using cmnd As New SqlClient.SqlCommand(sql, conn)

                    cmnd.Parameters.AddWithValue("@v1", id_jadwal)
                    cmnd.Parameters.AddWithValue("@v2", id_siswa)

                    cmnd.ExecuteNonQuery()
                    MessageBox.Show("Siswa Berhasil di masukkan kedalam kelas", "Yatta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                End Using
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Damme", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If

        refreshData(Me.data_grid_class, "SELECT tbl_siswa.nis,tbl_siswa.nama_siswa FROM ((tbl_siswa INNER JOIN tbl_det_jadwal ON tbl_det_jadwal.nis = tbl_siswa.nis)INNER JOIN tbl_jadwal ON tbl_jadwal.id_jadwal = tbl_det_jadwal.id_jadwal)INNER JOIN tbl_kelas ON tbl_kelas.id_kelas = tbl_jadwal.id_kelas WHERE tbl_kelas.id_kelas = '" + id + "' AND tbl_jadwal.id_jadwal = '" + id_jadwal + "'")
        refreshBinding(Me.txt_jadwal, "SELECT tbl_mapel.nama_mapel as [nama_mapel], tbl_jadwal.id_jadwal as [id_jadwal] FROM (tbl_jadwal INNER JOIN tbl_kelas ON tbl_kelas.id_kelas = tbl_jadwal.id_kelas)INNER JOIN tbl_mapel ON tbl_mapel.id_mapel = tbl_jadwal.id_mapel WHERE tbl_kelas.id_kelas = '" + id + "'", "nama_mapel", "id_jadwal")

        Me.btn_masuk.Enabled = False
        Me.btn_keluar.Enabled = False
    End Sub

    Private Sub txt_jadwal_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txt_jadwal.SelectedIndexChanged
        Try
            id_jadwal = Me.txt_jadwal.SelectedValue.ToString

            Dim sql As String = "SELECT * FROM tbl_kelas WHERE id_kelas = '" + id + "'"
            Dim cmnd As New SqlClient.SqlCommand(sql, conn)
            rd = cmnd.ExecuteReader
            rd.Read()

            If rd.HasRows Then

            End If
            rd.Close()

            refreshData(Me.data_grid_class, "SELECT tbl_siswa.nis,tbl_siswa.nama_siswa FROM ((tbl_siswa INNER JOIN tbl_det_jadwal ON tbl_det_jadwal.nis = tbl_siswa.nis)INNER JOIN tbl_jadwal ON tbl_jadwal.id_jadwal = tbl_det_jadwal.id_jadwal)INNER JOIN tbl_kelas ON tbl_kelas.id_kelas = tbl_jadwal.id_kelas WHERE tbl_kelas.id_kelas = '" + id + "' AND tbl_jadwal.id_jadwal = '" + id_jadwal + "'")

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Damme", MessageBoxButtons.OK, MessageBoxIcon.Error)
            rd.Close()
        End Try
    End Sub

    Private Sub data_grid_all_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles data_grid_all.CellClick
        If e.RowIndex >= 0 Then
            id_siswa = data_grid_all.Rows(e.RowIndex).Cells(0).Value.ToString
            If Me.btn_keluar.Enabled = True Then
                Me.btn_keluar.Enabled = False
            End If
            Me.btn_masuk.Enabled = True
        End If
    End Sub

    Private Sub data_grid_class_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles data_grid_class.CellClick
        id_siswa = data_grid_class.Rows(e.RowIndex).Cells(0).Value.ToString
        If Me.btn_masuk.Enabled = True Then
            Me.btn_masuk.Enabled = False
        End If

        Me.btn_keluar.Enabled = True
    End Sub
End Class