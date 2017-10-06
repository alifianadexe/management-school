Public Class ManagementClass

    Dim conn As New SqlClient.SqlConnection
    Dim rd As SqlClient.SqlDataReader
    Dim id As String = ""

    Private Sub ManagementClass_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.ConnectionString = generateConnString()
        conn.Open()

        refreshData(Me.data_grid_all, "SELECT nis, nama_siswa FROM tbl_siswa")
        refreshData(Me.data_grid_class, "SELECT tbl_siswa.nis, nama_siswa FROM ((tbl_siswa INNER JOIN tbl_det_jadwal ON tbl_det_jadwal.nis = tbl_siswa.nis)INNER JOIN tbl_jadwal ON tbl_jadwal.id_jadwal = tbl_det_jadwal.id_jadwal)INNER JOIN tbl_kelas ON tbl_kelas.id_kelas = tbl_jadwal.id_kelas")
        refreshBinding(Me.txt_pil_kelas, "SELECT * FROM tbl_kelas", "nama_kelas", "id_kelas")

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

            refreshData(Me.data_grid_class, "SELECT tbl_siswa.nis,tbl_siswa.nama_siswa FROM ((tbl_siswa INNER JOIN tbl_det_jadwal ON tbl_det_jadwal.nis = tbl_siswa.nis)INNER JOIN tbl_jadwal ON tbl_jadwal.id_jadwal = tbl_det_jadwal.id_jadwal)INNER JOIN tbl_kelas ON tbl_kelas.id_kelas = tbl_jadwal.id_kelas WHERE id_kelas = '" + id + "'")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Damme", MessageBoxButtons.OK, MessageBoxIcon.Error)
            rd.Close()
        End Try


    End Sub

    Private Sub btn_keluar_Click(sender As Object, e As EventArgs) Handles btn_keluar.Click

    End Sub

    Private Sub btn_masuk_Click(sender As Object, e As EventArgs) Handles btn_masuk.Click
        Dim sql As String = "INSERT INTO "
    End Sub
End Class