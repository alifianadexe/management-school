Public Class NavigationGuru
    Dim conn As New SqlClient.SqlConnection()
    Dim rd As SqlClient.SqlDataReader

    Private Sub NavigationGuru_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.ConnectionString = generateConnString()
        conn.Open()

        refreshData()
    End Sub

    Private Sub refreshData()
        Dim sql As String = "SELECT * FROM tbl_guru WHERE nip = '" + Me.Tag + "'"
        Dim cmnd As New SqlClient.SqlCommand(sql, conn)
        rd = cmnd.ExecuteReader
        rd.Read()

        If rd.HasRows Then

            Dim arr_image() As Byte = rd.Item("photo")
            Dim ms As New IO.MemoryStream(arr_image)
            PictureBox1.Image = Image.FromStream(ms)

            Me.lbl_nip.Text = rd.Item("nip")
            Me.lbl_nama.Text = rd.Item("nama_guru")
            Me.lbl_no_telp.Text = rd.Item("no_hp")
            Me.lbl_bidang.Text = rd.Item("bidang_study")
            Me.lbl_alamat.Text = rd.Item("alamat")
            Me.lbl_jenis.Text = rd.Item("jenis_kelamin")
            Me.lbl_tanggal_lahir.Text = rd.Item("tanggal_lahir")


        End If
        rd.Close()
    End Sub

    Private Sub btn_logout_Click(sender As Object, e As EventArgs) Handles btn_logout.Click
        Me.Close()
        LoginForm.Show()
    End Sub

    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click
        Dim fe As New EditForm
        fe.Tag = Me.Tag
        fe.Show()

    End Sub

    Private Sub btn_jadwal_Click(sender As Object, e As EventArgs) Handles btn_jadwal.Click
        Dim jdw As New JadwalMengajar
        jdw.Tag = Me.Tag
        jdw.Show()
    End Sub


End Class