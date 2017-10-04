Public Class ManagementMapel
    Dim conn As New SqlClient.SqlConnection
    Dim rd As SqlClient.SqlDataReader
    Dim id As String
    Private Sub ManagementMapel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.ConnectionString = generateConnString()
        conn.Open()

        refreshData()
    End Sub

    Private Sub refreshData()
        Dim sql As String = "SELECT id_mapel,nama_mapel,total_jam,nilai_min FROM tbl_mapel"
        Dim adapter As New SqlClient.SqlDataAdapter(sql, conn)
        Dim dt As New DataTable
        adapter.Fill(dt)

        data_grid.DataSource = dt

    End Sub

    Private Sub is_clear()

        Me.txt_deskripsi.Clear()
        Me.txt_id.Clear()
        Me.txt_jam.Clear()
        Me.txt_min.Clear()
        Me.txt_nama.Clear()

    End Sub

    Private Sub is_enabled(ByVal bool)
        Me.txt_deskripsi.Enabled = bool
        Me.txt_jam.Enabled = bool
        Me.txt_min.Enabled = bool

        Me.txt_nama.Enabled = bool
    End Sub

    Private Sub btn_tambah_Click(sender As Object, e As EventArgs) Handles btn_tambah.Click
        is_clear()
        Me.txt_id.Text = generateID("id_mapel", conn)
        is_enabled(True)
    End Sub

    Private Sub btn_simpan_Click(sender As Object, e As EventArgs) Handles btn_simpan.Click
        Try
            If cekEmptyTextbox() Then
                If Me.btn_simpan.Text = "Simpan" Then

                    Dim sql As String = "INSERT INTO tbl_mapel (id_mapel,nama_mapel,deskripsi,total_jam,nilai_min) VALUES (@v1,@v2,@v3,@v4,@v5)"
                    Using cmnd As New SqlClient.SqlCommand(sql, conn)
                        cmnd.Parameters.AddWithValue("@v1", Me.txt_id.Text)
                        cmnd.Parameters.AddWithValue("@v2", Me.txt_nama.Text)
                        cmnd.Parameters.AddWithValue("@v3", Me.txt_deskripsi.Text)
                        cmnd.Parameters.AddWithValue("@v4", Val(Me.txt_jam.Text))
                        cmnd.Parameters.AddWithValue("@v5", Val(Me.txt_min.Text))

                        If MessageBox.Show("Apakah Data Sudah Benar?", "Cek", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                            cmnd.ExecuteNonQuery()
                            MessageBox.Show("Mapel Berhasil Ditambahkan", "Yatta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                        End If

                    End Using
                ElseIf Me.btn_simpan.Text = "Update" Then

                    Dim sql As String = "UPDATE tbl_mapel SET nama_mapel = @v2 , deskripsi = @v3 , total_jam = @v4 , nilai_min = @v5 WHERE id_mapel = @v1"
                    Using cmnd As New SqlClient.SqlCommand(sql, conn)
                        cmnd.Parameters.AddWithValue("@v1", Me.txt_id.Text)
                        cmnd.Parameters.AddWithValue("@v2", Me.txt_nama.Text)
                        cmnd.Parameters.AddWithValue("@v3", Me.txt_deskripsi.Text)
                        cmnd.Parameters.AddWithValue("@v4", Me.txt_jam.Text)
                        cmnd.Parameters.AddWithValue("@v5", Me.txt_min.Text)

                        If MessageBox.Show("Apakah Data Sudah Benar?", "Cek", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                            cmnd.ExecuteNonQuery()
                            MessageBox.Show("Mapel Berhasil Diupdate", "Yatta", MessageBoxButtons.OK, MessageBoxIcon.Hand)
                        End If

                    End Using
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Damme", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        refreshData()
        Me.btn_simpan.Text = "Simpan"
    End Sub

    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click
        If Not id = "" Then
            is_enabled(True)
            Me.btn_simpan.Text = "Update"
        End If
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        If Not id = "" Then
            Try
                Dim sql As String = "DELETE FROM tbl_mapel WHERE id_mapel = '" + id + "'"
                Dim cmnd As New SqlClient.SqlCommand(sql, conn)
                cmnd.ExecuteNonQuery()
                MessageBox.Show("Data Berhasil Dihapus", "Yatta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Yatta", MessageBoxButtons.OK, MessageBoxIcon.Hand)
            End Try
        Else
            MessageBox.Show("Pilih Data Terlebih dahulu", "Yatta", MessageBoxButtons.OK, MessageBoxIcon.Hand)
        End If
    End Sub

End Class