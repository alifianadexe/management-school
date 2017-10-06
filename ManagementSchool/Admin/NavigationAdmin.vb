Public Class NavigationAdmin
    Private Sub NavigationAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        LoginForm.Show()
        Me.Close()

    End Sub

    Private Sub btn_siswa_Click(sender As Object, e As EventArgs) Handles btn_siswa.Click
        ManagementSiswa.Show()
    End Sub

    Private Sub btn_guru_Click(sender As Object, e As EventArgs) Handles btn_guru.Click
        ManagementGuru.Show()
    End Sub

    Private Sub btn_mapel_Click(sender As Object, e As EventArgs) Handles btn_mapel.Click
        ManagementMapel.Show()
    End Sub

    Private Sub btn_kelas_Click(sender As Object, e As EventArgs) Handles btn_kelas.Click
        ManagementClass.Show()
    End Sub

    Private Sub btn_jadwal_Click(sender As Object, e As EventArgs) Handles btn_jadwal.Click
        ManagementJadwal.Show()
    End Sub
End Class