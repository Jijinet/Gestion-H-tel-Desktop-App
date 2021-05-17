Imports System.Data.SqlClient
Imports System.Data.Sql

Public Class Form2

    Dim cnx As SqlConnection = New SqlConnection("server=DESKTOP-FL4FBU4\SQLEXPRESS;database=GestionHotel;integrated security=true")
    Dim cmd As SqlCommand
    Dim dt As DataTable
    Dim dr As SqlDataReader
    Sub datagrid()
        cnx.Open()
        cmd = New SqlCommand(" select nom 'Nom' ,prenom 'Prenom',ch.nrchambre 'Nr° Chambre',etage 'Etage',NbJours'Jours',PrixTotal 'Prix Total' 
 from client c ,Chambre ch,facture f
 where ch.NrChambre=f.NrChambre", cnx)
        dr = cmd.ExecuteReader()
        dt = New DataTable()
        dt.Load(dr)
        dgMenu.DataSource = dt

        cnx.Close()
        dgMenu.Columns(0).HeaderCell.Style.Font = New Font("Microsoft YaHei UI", 14, FontStyle.Bold)
        dgMenu.Columns(1).HeaderCell.Style.Font = New Font("Microsoft YaHei UI", 14, FontStyle.Bold)
        dgMenu.Columns(2).HeaderCell.Style.Font = New Font("Microsoft YaHei UI", 14, FontStyle.Bold)
        dgMenu.Columns(3).HeaderCell.Style.Font = New Font("Microsoft YaHei UI", 14, FontStyle.Bold)
        dgMenu.Columns(4).HeaderCell.Style.Font = New Font("Microsoft YaHei UI", 14, FontStyle.Bold)
        dgMenu.Columns(5).HeaderCell.Style.Font = New Font("Microsoft YaHei UI", 14, FontStyle.Bold)
        dgMenu.EnableHeadersVisualStyles = False
        dgMenu.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black
        dgMenu.ColumnHeadersDefaultCellStyle.BackColor = Color.PowderBlue
        dgMenu.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgMenu.Columns(0).DefaultCellStyle.Font = New Font("Microsoft YaHei UI", 12)
        dgMenu.Columns(0).DefaultCellStyle.ForeColor = Color.Black
        dgMenu.Columns(0).DefaultCellStyle.BackColor = Color.LemonChiffon
        dgMenu.Columns(1).DefaultCellStyle.Font = New Font("Microsoft YaHei UI", 12)
        dgMenu.Columns(1).DefaultCellStyle.ForeColor = Color.Black
        dgMenu.Columns(1).DefaultCellStyle.BackColor = Color.LemonChiffon
        dgMenu.Columns(2).DefaultCellStyle.Font = New Font("Microsoft YaHei UI", 12)
        dgMenu.Columns(2).DefaultCellStyle.ForeColor = Color.Black
        dgMenu.Columns(2).DefaultCellStyle.BackColor = Color.LemonChiffon
        dgMenu.Columns(3).DefaultCellStyle.Font = New Font("Microsoft YaHei UI", 12)
        dgMenu.Columns(3).DefaultCellStyle.ForeColor = Color.Black
        dgMenu.Columns(3).DefaultCellStyle.BackColor = Color.LemonChiffon
        dgMenu.Columns(4).DefaultCellStyle.Font = New Font("Microsoft YaHei UI", 12)
        dgMenu.Columns(4).DefaultCellStyle.ForeColor = Color.Black
        dgMenu.Columns(4).DefaultCellStyle.BackColor = Color.LemonChiffon
        dgMenu.Columns(5).DefaultCellStyle.Font = New Font("Microsoft YaHei UI", 12)
        dgMenu.Columns(5).DefaultCellStyle.ForeColor = Color.Black
        dgMenu.Columns(5).DefaultCellStyle.BackColor = Color.LemonChiffon
        dgMenu.ColumnHeadersHeight = 50
        dgMenu.Columns(0).Width = 100
        dgMenu.Columns(1).Width = 110
        dgMenu.Columns(2).Width = 185
        dgMenu.Columns(3).Width = 110
        dgMenu.Columns(4).Width = 110
        dgMenu.Columns(5).Width = 185
        dgMenu.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter








    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        datagrid()

    End Sub

    Private Sub BtnClient_Click(sender As Object, e As EventArgs) Handles btnClient.Click
        Dim b As Form4 = New Form4
        b.Show()
        Me.Hide()
    End Sub


    Private Sub BtnChambre_Click(sender As Object, e As EventArgs) Handles btnChambre.Click
        Dim b As Form3 = New Form3
        b.Show()
        Me.Hide()
    End Sub

    Private Sub BtnReserve_Click(sender As Object, e As EventArgs) Handles btnReserve.Click
        Dim b As Form5 = New Form5
        b.Show()
        Me.Hide()
    End Sub
    Private Sub BtnFacture_Click_1(sender As Object, e As EventArgs) Handles btnFacture.Click
        Dim b As Form6 = New Form6
        b.Show()
        Me.Hide()
    End Sub

    Private Sub BtnActualiser_Click(sender As Object, e As EventArgs) Handles btnActualiser.Click
        Form2_Load(sender, e)
    End Sub

    Private Sub BtnFermer_Click(sender As Object, e As EventArgs) Handles btnFermer.Click
        Me.Close()

    End Sub

    Private Sub Btn_logout_Click(sender As Object, e As EventArgs) Handles btn_logout.Click
        Dim k As Form1 = New Form1
        k.Show()
        Me.Hide()
    End Sub
End Class