Imports System.Data.SqlClient
Imports System.Data.Sql

Public Class Form1
    Dim cnx As SqlConnection = New SqlConnection("server=DESKTOP-FL4FBU4\SQLEXPRESS;database=GestionHotel;integrated security=true")
    Dim cmd As SqlCommand
    Dim dt As DataTable
    Dim dr As SqlDataReader
    Dim da As SqlDataAdapter
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnLogin.Select()
    End Sub
    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        cnx.Open()
        cmd = New SqlCommand("select count (*) from LG where Utilisateur='" & txtUser.Text & "' and MotDePasse='" & txtPassword.Text & "'", cnx)
        Dim nb As Integer = Integer.Parse(cmd.ExecuteScalar().ToString())
        If nb = 1 Then
            Dim a As Form2 = New Form2
            a.Show()
            Me.Hide()
        Else
            MessageBox.Show("Nom d'utilisateur ou mot de passe est incorrect", "invalid login", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        cnx.Close()
    End Sub






    Private Sub TxtPassword_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged

    End Sub


    Private Sub BtnFermer_Click_1(sender As Object, e As EventArgs) Handles btnFermer.Click
        Me.Close()
    End Sub
End Class
