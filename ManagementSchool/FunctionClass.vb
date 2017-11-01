Module FunctionClass
    Dim rd As SqlClient.SqlDataReader
    Dim server As String = "localhost"


    Public Function cekEmptyTextbox(ByVal ParamArray obj() As Object) As Boolean
        Dim bool As Boolean = True
        For i As Integer = 0 To UBound(obj)
            If obj(i).Text = "" Then
                MessageBox.Show("Tolong isi semua")
                bool = False
            End If
        Next
        Return bool
    End Function


    Public Function generateConnString()
        Dim connString As String = "Data Source=" + server + ",1433;Network Library=DBMSSOCN;Initial Catalog=db_sekolah;user id=sa;password=adexe123"
        Try
            Dim conn As New SqlClient.SqlConnection()
            If conn.State = ConnectionState.Closed Then
                conn.ConnectionString = connString
                conn.Open()
                conn.Close()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Server", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk)
            server = InputBox("Masukkan IP Server : ", "SERVER", "1.1.1.202")
            generateConnString()
        End Try
        Return connString
    End Function

    Public Function generateID(ByVal what As String, ByVal conn As SqlClient.SqlConnection)
        Dim id As String = ""
        Select Case what
            Case "nis"
                Dim sql As String = "SELECT * FROM tbl_siswa ORDER BY " + what + " DESC"
                Dim cmnd As New SqlClient.SqlCommand(sql, conn)
                rd = cmnd.ExecuteReader
                rd.Read()

                If Not rd.HasRows Then
                    id = "151001"
                Else
                    id = Val(rd.Item(0)) + 1
                End If
                rd.Close()
            Case "nip"
                Dim sql As String = "SELECT * FROM tbl_guru ORDER BY " + what + " DESC"
                Dim cmnd As New SqlClient.SqlCommand(sql, conn)
                rd = cmnd.ExecuteReader
                rd.Read()

                If Not rd.HasRows Then
                    id = "192168881"
                Else
                    id = Val(rd.Item(0)) + 1
                End If
                rd.Close()
            Case "id_mapel"
                Dim sql As String = "SELECT * FROM tbl_mapel ORDER BY " + what + " DESC"
                Dim cmnd As New SqlClient.SqlCommand(sql, conn)
                rd = cmnd.ExecuteReader
                rd.Read()

                If Not rd.HasRows Then
                    id = "MPL001"
                Else
                    id = Val(Mid(rd.Item(0), 4, 3)) + 1
                    If Len(id) = 1 Then
                        id = "MPL00" + id
                    ElseIf Len(id) = 2 Then
                        id = "MPL0" + id
                    ElseIf Len(id) = 3 Then
                        id = "MPL" + id
                    End If
                End If
                rd.Close()
            Case "id_nilai"
                Dim sql As String = "SELECT * FROM tbl_nilai ORDER BY " + what + " DESC"
                Dim cmnd As New SqlClient.SqlCommand(sql, conn)
                rd = cmnd.ExecuteReader
                rd.Read()

                If Not rd.HasRows Then
                    id = "NIL001"
                Else
                    id = Val(Mid(rd.Item(0), 4, 3)) + 1
                    If Len(id) = 1 Then
                        id = "NIL00" + id
                    ElseIf Len(id) = 2 Then
                        id = "NIL0" + id
                    ElseIf Len(id) = 3 Then
                        id = "NIL" + id
                    End If
                End If
                rd.Close()
            Case "id_jadwal"
                Dim sql As String = "SELECT * FROM tbl_jadwal ORDER BY " + what + " DESC"
                Dim cmnd As New SqlClient.SqlCommand(sql, conn)
                rd = cmnd.ExecuteReader
                rd.Read()

                If Not rd.HasRows Then
                    id = "JDW001"
                Else
                    id = Val(Mid(rd.Item(0), 4, 3)) + 1
                    If Len(id) = 1 Then
                        id = "JDW00" + id
                    ElseIf Len(id) = 2 Then
                        id = "JDW0" + id
                    ElseIf Len(id) = 3 Then
                        id = "JDW" + id
                    End If
                End If
                rd.Close()

            Case "id_kelas"
                Dim sql As String = "SELECT * FROM tbl_kelas ORDER BY " + what + " DESC"
                Dim cmnd As New SqlClient.SqlCommand(sql, conn)
                rd = cmnd.ExecuteReader
                rd.Read()

                If Not rd.HasRows Then
                    id = "KLS001"
                Else
                    id = Val(Mid(rd.Item(0), 4, 3)) + 1
                    If Len(id) = 1 Then
                        id = "KLS00" + id
                    ElseIf Len(id) = 2 Then
                        id = "KLS0" + id
                    ElseIf Len(id) = 3 Then
                        id = "KLS" + id
                    End If
                End If
                rd.Close()

            Case "id_login"
                Dim sql As String = "SELECT * FROM tbl_login ORDER BY " + what + " DESC"
                Dim cmnd As New SqlClient.SqlCommand(sql, conn)
                rd = cmnd.ExecuteReader
                rd.Read()

                If Not rd.HasRows Then
                    id = "LGN001"
                Else
                    id = Val(Mid(rd.Item(0), 4, 3)) + 1
                    If Len(id) = 1 Then
                        id = "LGN00" + id
                    ElseIf Len(id) = 2 Then
                        id = "LGN0" + id
                    ElseIf Len(id) = 3 Then
                        id = "LGN" + id
                    End If
                End If
                rd.Close()
            Case "id_spp"
                Dim sql As String = "SELECT * FROM tbl_spp ORDER BY " + what + " DESC"
                Dim cmnd As New SqlClient.SqlCommand(sql, conn)
                rd = cmnd.ExecuteReader
                rd.Read()

                If Not rd.HasRows Then
                    id = "SPP001"
                Else
                    id = Val(Mid(rd.Item(0), 4, 3)) + 1
                    If Len(id) = 1 Then
                        id = "SPP00" + id
                    ElseIf Len(id) = 2 Then
                        id = "SPP0" + id
                    ElseIf Len(id) = 3 Then
                        id = "SPP" + id
                    End If
                End If
                rd.Close()
            Case "id_det_spp"
                Dim sql As String = "SELECT * FROM tbl_det_spp ORDER BY " + what + " DESC"
                Dim cmnd As New SqlClient.SqlCommand(sql, conn)
                rd = cmnd.ExecuteReader
                rd.Read()

                If Not rd.HasRows Then
                    id = "DSP001"
                Else
                    id = Val(Mid(rd.Item(0), 4, 3)) + 1
                    If Len(id) = 1 Then
                        id = "DSP00" + id
                    ElseIf Len(id) = 2 Then
                        id = "DSP0" + id
                    ElseIf Len(id) = 3 Then
                        id = "DSP" + id
                    End If
                End If
                rd.Close()
        End Select
        Return id
    End Function
End Module
