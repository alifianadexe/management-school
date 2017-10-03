Public Class LoginForm
    Dim conn As New SqlClient.SqlConnection
    Dim rd As SqlClient.SqlDataReader

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.ConnectionString = generateConnString()
        conn.Open()


    End Sub

    Private Sub LoginForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        conn.Close()
        MainForm.Show()
    End Sub

    Private Sub login_Click(sender As Object, e As EventArgs) Handles login.Click
        If cekEmptyTextbox(Me.txt_username, Me.txt_password) Then
            Try
                Dim sql As String = "SELECT * FROM tbl_login WHERE username = '" + Me.txt_username.Text + "'"
                Dim cmnd As New SqlClient.SqlCommand(sql, conn)

                rd = cmnd.ExecuteReader
                rd.Read()

                If rd.HasRows Then
                    If rd.Item("password") = Me.txt_password.Text Then

                        If rd.Item("role") = "siswa" Then
                            Dim nasis As New NavigationSiswa
                            nasis.Tag = Me.txt_username.Text
                            nasis.Show()
                            Me.Dispose()

                        ElseIf rd.Item("role") = "guru" Then
                            Dim nasis As New NavigationGuru
                            nasis.Tag = Me.txt_username.Text
                            nasis.Show()
                            Me.Dispose()

                        ElseIf rd.Item("role") = "admin" Then
                            Dim nasis As New NavigationAdmin
                            nasis.Tag = Me.txt_username.Text
                            nasis.Show()
                            Me.Dispose()
                        Else
                            MessageBox.Show("Role Tidak Ada")
                        End If
                    Else
                        MessageBox.Show("Maaf Password Anda Salah!", "Gagal Login", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Else
                    MessageBox.Show("Maaf Anda Belum Terdaftar!", "Gagal Login", MessageBoxButtons.OK, MessageBoxIcon.Error)

                End If
                rd.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            MessageBox.Show("Isi Semua Field!")
        End If
    End Sub
End Class