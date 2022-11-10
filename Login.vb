'Imports the MySql Library
Imports MySql.Data.MySqlClient

Public Class Login

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Register.Visible = True
    End Sub

    Private Sub btnUserLogin_Click(sender As Object, e As EventArgs) Handles btnUserLogin.Click
        UserLogin.Visible = True
    End Sub
    Private Sub btnAdminLogin_Click(sender As Object, e As EventArgs) Handles btnAdminLogin.Click
        AdminLogin.Visible = True
    End Sub

    Private Sub btnDoctorLogin_Click(sender As Object, e As EventArgs) Handles btnDoctorLogin.Click
        DoctorLogin.Visible = True
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class