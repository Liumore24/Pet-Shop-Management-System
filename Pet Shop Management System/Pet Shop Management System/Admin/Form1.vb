﻿Imports MySql.Data.MySqlClient
Imports System.IO
Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    Private Sub btn_dashboard_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btn_managePets_Click(sender As Object, e As EventArgs) Handles btn_managePets.Click
        With frm_pets
            .TopLevel = False
            Panel2.Controls.Add(frm_pets)
            .BringToFront()
            .Show()
        End With

    End Sub

    Private Sub btn_user_Click(sender As Object, e As EventArgs) Handles btn_user.Click
        With frm_users
            .TopLevel = False
            Panel2.Controls.Add(frm_users)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub btn_changePassword_Click(sender As Object, e As EventArgs) Handles btn_changePassword.Click
        With frm_changePassword
            .TopLevel = False
            Panel2.Controls.Add(frm_changePassword)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub btn_report_Click(sender As Object, e As EventArgs) Handles btn_report.Click
        With frm_report
            .TopLevel = False
            Panel2.Controls.Add(frm_report)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub btn_logout_Click(sender As Object, e As EventArgs) Handles btn_logout.Click
        Me.Close()
        frm_login.Show()
    End Sub
End Class
