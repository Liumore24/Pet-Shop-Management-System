Imports MySql.Data.MySqlClient
Public Class frm_changePassword

    Private Sub frm_changePassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbconn()
    End Sub

    Private Sub btn_ChangePassword_Click(sender As Object, e As EventArgs) Handles btn_ChangePassword.Click
        Try

            If txt_oldpass.Text = String.Empty Then
                MsgBox("Pleace Enter Your OLD Password", vbCritical)
                Return
            ElseIf txt_newpass.Text = String.Empty Or txt_reenterpass.Text = String.Empty Then
                MsgBox("Pleace Enter Your New Password", vbCritical)
                Return
            ElseIf StrComp(txt_newpass.Text, txt_reenterpass.Text, CompareMethod.Binary) Then
                MsgBox("Password does not match", vbCritical)
                Return
            Else
                conn.Open()
                Dim cmd As New MySqlCommand("UPDATE `tbl_users` SET `password`=@password WHERE `name`=@name", conn)
                cmd.Parameters.Clear()

                cmd.Parameters.AddWithValue("@password", txt_reenterpass.Text)
                cmd.Parameters.AddWithValue("@name", Form1.lbl_loginuser.Text)

                i = cmd.ExecuteNonQuery
                If i > 0 Then
                    MsgBox("Password Change Successfully !", vbInformation)
                Else
                    MsgBox("Failed", vbCritical)
                End If

            End If

            conn.Close()
            txt_newpass.Clear()
            txt_oldpass.Clear()
            txt_reenterpass.Clear()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
        Me.Close()
        frm_login.ShowDialog()




    End Sub

    Private Sub lbl_close_Click(sender As Object, e As EventArgs) Handles lbl_close.Click
        Me.Close()
    End Sub
End Class