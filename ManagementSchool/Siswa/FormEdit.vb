Public Class FormEdit

    Public conn As New SqlClient.SqlConnection
    Public rd As SqlClient.SqlDataReader

    Private Sub FormEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.ConnectionString = generateConnString()
        conn.Open()

        refreshData()

    End Sub

    Private Sub refreshData()
        Dim sql As String = "SELECT * FROM tbl_siswa WHERE nis = '" + Me.Tag + "'"
        Dim cmnd As New SqlClient.SqlCommand(sql, conn)

        rd = cmnd.ExecuteReader
        rd.Read()
        If rd.HasRows Then
            Me.txt_nis.Text = Me.Tag
            Me.txt_nama.Text = rd.Item("nama_siswa")
            Me.txt_no_hp.Text = rd.Item("no_hp")
            Me.txt_date_lahir.Text = rd.Item("tanggal_lahir")
            Me.txt_alamat.Text = rd.Item("alamat")
            Me.txt_jenis_kelamin.Text = rd.Item("jenis_kelamin")

            Dim arr_image() As Byte = rd.Item("picture")
            Dim ms_steam As New IO.MemoryStream(arr_image)
            PictureBox1.Image = Image.FromStream(ms_steam)


        End If
        rd.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Me.Button2.Text = "Edit" Then
            Me.txt_no_hp.Enabled = True
            Me.txt_alamat.Enabled = True
            Me.txt_jenis_kelamin.Enabled = True
            Me.txt_date_lahir.Enabled = True
            Me.txt_nama.Enabled = True

            Me.Button2.Text = "Update"

        ElseIf Me.Button2.Text = "Update" Then
            Dim ms As New IO.MemoryStream
            PictureBox1.Image.Save(ms, Imaging.ImageFormat.Png)
            Dim arr_image() As Byte = ms.GetBuffer

            If cekEmptyTextbox(Me.txt_nama, Me.txt_alamat, Me.txt_no_hp) Then
                Dim sql As String = "UPDATE tbl_siswa SET nama = @v1, alamat = @v2, jenis_kelamin = @v3, tanggal_lahir = @v4, no_hp = @v5 , picture = @v6 WHERE nis = '" + Me.Tag + "'"
                Using cmnd As New SqlClient.SqlCommand(sql, conn)

                    cmnd.Parameters.AddWithValue("@v1", Me.txt_nama.Text)
                    cmnd.Parameters.AddWithValue("@v2", Me.txt_alamat.Text)
                    cmnd.Parameters.AddWithValue("@v3", Me.txt_jenis_kelamin.Text)
                    cmnd.Parameters.AddWithValue("@v4", Me.txt_date_lahir.Value)
                    cmnd.Parameters.AddWithValue("@v5", Me.txt_alamat.Text)
                    cmnd.Parameters.AddWithValue("@v6", arr_image)
                    cmnd.ExecuteNonQuery()

                    MessageBox.Show("Selamat , Data Diri Berhasil Diupdate", "Yeey", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                End Using
            Else
                MessageBox.Show("Maaf , Semua Kolom Wajib Diisi", "Maaf", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

            Me.txt_no_hp.Enabled = False
            Me.txt_alamat.Enabled = False
            Me.txt_jenis_kelamin.Enabled = False
            Me.txt_date_lahir.Enabled = False
            Me.txt_nama.Enabled = False

            Me.Button2.Text = "Edit"
        End If

        refreshData()
    End Sub


End Class