Public Class ManagementGuru
    Dim conn As New SqlClient.SqlConnection()
    Dim rd As SqlClient.SqlDataReader
    Dim id As String = ""

    Private Sub ManagementGuru_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        conn.ConnectionString = generateConnString()
        conn.Open()

        bindingDataBox()

        refreshData()
    End Sub

    Private Sub refreshData()
        Dim sql As String = "SELECT nip,nama_guru,bidang_studi,jenis_kelamin,tanggal_lahir,no_hp FROM tbl_guru"
        Dim adapter As New SqlClient.SqlDataAdapter(sql, conn)
        Dim dt As New DataTable
        adapter.Fill(dt)

        data_grid.DataSource = dt

    End Sub

    Private Sub bindingDataBox()
        Dim sql As String = "SELECT * FROM tbl_mapel"
        Dim adapter As New SqlClient.SqlDataAdapter(sql, conn)
        Dim dt As New DataTable
        adapter.Fill(dt)
        Me.txt_studi.DataSource = dt
        Me.txt_studi.DisplayMember = "nama_mapel"
        Me.txt_studi.ValueMember = "id_mapel"
    End Sub

    Private Sub is_enabled(ByVal bool As Boolean)
        Me.txt_jenis_kelamin.Enabled = bool
        Me.txt_alamat.Enabled = bool
        Me.txt_date_lahir.Enabled = bool
        Me.txt_nama.Enabled = bool
        Me.txt_no_hp.Enabled = bool
        Me.txt_studi.Enabled = bool
        Me.btn_browse.Enabled = bool

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

    Private Sub btn_tambah_Click(sender As Object, e As EventArgs) Handles btn_tambah.Click
        is_clear()
        Me.txt_nis.Text = generateID("nip", conn)
        is_enabled(True)
    End Sub

    Private Sub btn_simpan_Click(sender As Object, e As EventArgs) Handles btn_simpan.Click
        Try
            If cekEmptyTextbox(Me.txt_alamat, Me.txt_nama, Me.txt_no_hp) Then
                If Me.btn_simpan.Text = "Simpan" Then
                    Dim ms As New IO.MemoryStream
                    PictureBox1.Image.Save(ms, Imaging.ImageFormat.Png)
                    Dim arr_image() As Byte = ms.GetBuffer

                    Dim sql As String = "INSERT INTO tbl_guru (nip,nama_guru,alamat,jenis_kelamin,tanggal_lahir,no_hp,photo,bidang_study) VALUES (@v1,@v2,@v3,@v4,@v5,@v6,@v7,@v8)"
                    Using cmnd As New SqlClient.SqlCommand(sql, conn)
                        cmnd.Parameters.AddWithValue("@v1", Me.txt_nis.Text)
                        cmnd.Parameters.AddWithValue("@v2", Me.txt_nama.Text)
                        cmnd.Parameters.AddWithValue("@v3", Me.txt_alamat.Text)
                        cmnd.Parameters.AddWithValue("@v4", Me.txt_jenis_kelamin.Text)
                        cmnd.Parameters.AddWithValue("@v5", Date.Parse(Me.txt_date_lahir.Value))
                        cmnd.Parameters.AddWithValue("@v6", Me.txt_no_hp.Text)
                        cmnd.Parameters.AddWithValue("@v7", arr_image)
                        cmnd.Parameters.AddWithValue("@v8", Me.txt_studi.Text)

                        If MessageBox.Show("Apakah Data Sudah Benar?", "Cek", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                            cmnd.ExecuteNonQuery()
                            generateLogin(Me.txt_nis.Text)
                            MessageBox.Show("Guru Berhasil Ditambahkan", "Yatta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                        End If

                    End Using
                ElseIf Me.btn_simpan.Text = "Update" Then
                    Dim ms As New IO.MemoryStream
                    PictureBox1.Image.Save(ms, Imaging.ImageFormat.Png)
                    Dim arr_image() As Byte = ms.GetBuffer

                    Dim sql As String = "UPDATE tbl_guru SET nama_guru = @v2 , alamat = @v3 , jenis_kelamin = @v4 , tanggal_lahir = @v5 , no_hp = @v6, photo = @v7 WHERE nis = @v1"
                    Using cmnd As New SqlClient.SqlCommand(sql, conn)
                        cmnd.Parameters.AddWithValue("@v1", Me.txt_nis.Text)
                        cmnd.Parameters.AddWithValue("@v2", Me.txt_nama.Text)
                        cmnd.Parameters.AddWithValue("@v3", Me.txt_alamat.Text)
                        cmnd.Parameters.AddWithValue("@v4", Me.txt_jenis_kelamin.Text)
                        cmnd.Parameters.AddWithValue("@v5", Date.Parse(Me.txt_date_lahir.Value))
                        cmnd.Parameters.AddWithValue("@v6", Me.txt_no_hp.Text)
                        cmnd.Parameters.AddWithValue("@v7", arr_image)
                        cmnd.Parameters.AddWithValue("@v8", Me.txt_studi.Text)

                        If MessageBox.Show("Apakah Data Sudah Benar?", "Cek", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                            cmnd.ExecuteNonQuery()
                            generateLogin(Me.txt_nis.Text)
                            MessageBox.Show("Guru Berhasil Diupdate", "Yatta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                        End If

                    End Using
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Damme", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        refreshData()
        Me.btn_simpan.Text = "Simpan"
        is_clear()
        is_enabled(False)
    End Sub

    Private Sub generateLogin(ByVal id As String)
        Dim sql As String = "INSERT INTO tbl_login (id_login,username,password,role) VALUES (@v1,@v2,@v3,@v4)"
        Using cmnd As New SqlClient.SqlCommand(sql, conn)
            cmnd.Parameters.AddWithValue("@v1", generateID("id_login", conn))
            cmnd.Parameters.AddWithValue("@v2", id)
            cmnd.Parameters.AddWithValue("@v3", id)
            cmnd.Parameters.AddWithValue("@v4", "guru")

            cmnd.ExecuteNonQuery()
        End Using
    End Sub

    Private Sub btn_hapus_Click(sender As Object, e As EventArgs) Handles btn_hapus.Click
        If Not id = "" Then
            If MessageBox.Show("Hapus guru Ini ? ", "Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Try
                    Dim sql As String = "DELETE FROM tbl_guru WHERE nip = '" + id + "'"
                    Dim cmnd As New SqlClient.SqlCommand(sql, conn)
                    cmnd.ExecuteNonQuery()
                    MessageBox.Show("guru Berhasil Dihapus", "Yatta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Damme", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        Else
            MessageBox.Show("Pilih guru Terlebih Dahulu!", "Damme", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        End If
        refreshData()
    End Sub

    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click
        Me.btn_simpan.Text = "Update"
        is_enabled(True)
    End Sub

    Private Sub data_grid_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles data_grid.CellClick
        Try
            If e.RowIndex >= 0 Then
                id = data_grid.Rows(e.RowIndex).Cells(0).Value.ToString

                Dim sql As String = "SELECT * FROM tbl_guru WHERE nip = '" + id + "'"
                Dim cmnd As New SqlClient.SqlCommand(sql, conn)
                rd = cmnd.ExecuteReader
                rd.Read()

                If rd.HasRows Then
                    Me.txt_alamat.Text = rd.Item("alamat")
                    Me.txt_date_lahir.Value = Date.Parse(rd.Item("tanggal_lahir"))
                    Me.txt_jenis_kelamin.Text = rd.Item("jenis_kelamin")
                    Me.txt_nama.Text = rd.Item("nama_guru")
                    Me.txt_studi.Text = rd.Item("bidang_study")
                    Me.txt_nis.Text = id
                    Me.txt_no_hp.Text = rd.Item("no_hp")

                    Dim arr_image() As Byte = rd.Item("photo")
                    Dim ms As New IO.MemoryStream(arr_image)
                    PictureBox1.Image = Image.FromStream(ms)

                End If
                rd.Close()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Damme", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

    End Sub
End Class