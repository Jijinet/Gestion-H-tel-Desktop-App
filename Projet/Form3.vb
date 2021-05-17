Imports System.Data.SqlClient
Imports System.Data.Sql

Public Class Form3
    Dim cnx As SqlConnection = New SqlConnection("server=DESKTOP-FL4FBU4\SQLEXPRESS;database=GestionHotel;integrated security=true")
    Dim cmd As SqlCommand

    Dim dr As SqlDataReader

    Dim nbchambre As Integer
    Dim i As Integer = 1

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ChargerChambre(1)
        nbChambres()
        cmbEtage.Items.Add("1éme Etage")
        cmbEtage.Items.Add("2éme Etage")
        cmbEtage.Items.Add("3éme Etage")
        cmbEtage.Items.Add("4éme Etage")
        cmbType.Items.Add("Classique")
        cmbType.Items.Add("Superieure")
        cmbType.Items.Add("Twin")
        cmbType.Items.Add("Familiale")
        txtNbChambre.Text = i.ToString & "/" & nbchambre.ToString



    End Sub
    Sub ChargerChambre(ByVal p As Integer)
        cnx.Open()
        cmd = New SqlCommand("select top " & p & " * from Chambre", cnx)
        dr = cmd.ExecuteReader()
        While dr.Read()
            txtNrChambre.Text = dr(0).ToString()
            cmbType.Text = dr(1).ToString()
            cmbEtage.Text = dr(2).ToString()
            PrixparChambre.Text = dr(4).ToString
        End While
        dr.Close()
        cnx.Close()

    End Sub
    Function nbChambres()
        cnx.Open()
        cmd = New SqlCommand("select count(*) from Chambre", cnx)
        nbchambre = Integer.Parse(cmd.ExecuteScalar())
        cnx.Close()
        Return nbchambre
    End Function
    Private Sub BtnNouveau_Click(sender As Object, e As EventArgs) Handles btnNouveau.Click
        cmbType.Text = ""
        cmbEtage.Text = ""
        PrixparChambre.Clear()
        txtNrChambre.Clear()


    End Sub

    Private Sub BtnAjouter_Click(sender As Object, e As EventArgs) Handles btnAjouter.Click
        cnx.Open()
        If txtNrChambre.Text <> "" And cmbEtage.Text <> "" And cmbType.Text <> "" And PrixparChambre.Text <> "" Then

            cmd = New SqlCommand("insert into Chambre values (" & txtNrChambre.Text & ",'" & cmbType.Text.ToString & "','" & cmbEtage.Text.ToString & "',0," & PrixparChambre.Text & ")", cnx)
            If cmd.ExecuteNonQuery() = 1 Then
                MessageBox.Show("informations  ajouté", "", MessageBoxButtons.OK, MessageBoxIcon.Information)

            End If
        Else
            MessageBox.Show("champs sont vide", "champ invalide", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
        cnx.Close()

    End Sub

    Private Sub BtnSupprimer_Click(sender As Object, e As EventArgs) Handles btnSupprimer.Click
        cnx.Open()
        If True Then

            cmd = New SqlCommand("delete from Chambre where NrChambre='" & txtNrChambre.Text.ToString & "'", cnx)
            If cmd.ExecuteNonQuery() = 1 Then
                MessageBox.Show("Informations à été Supprimé")
            End If

        End If
        cnx.Close()
    End Sub

    Private Sub BtnActualiser_Click(sender As Object, e As EventArgs) Handles btnActualiser.Click
        Form3_Load(sender, e)
    End Sub

    Private Sub BtnAnnuler_Click(sender As Object, e As EventArgs) Handles btnAnnuler.Click
        Dim gr As Form2 = New Form2
        gr.Show()
        Me.Hide()

    End Sub


    Private Sub BtnModifier_Click(sender As Object, e As EventArgs) Handles btnModifier.Click
        cnx.Open()
        If txtNrChambre.Text <> "" Or cmbEtage.Text <> "" Or cmbType.Text <> "" Or PrixparChambre.Text <> "" Then

            cmd = New SqlCommand("update Chambre set NrChambre='" & txtNrChambre.Text.ToString & "',
         TypeChambre='" & cmbType.Text.ToString & "',Etage='" & cmbEtage.Text.ToString & "',prixparchambre=" & PrixparChambre.Text & " where NrChambre='" & txtNrChambre.Text.ToString & "'", cnx)
            If cmd.ExecuteNonQuery() = 1 Then
                MessageBox.Show("Informations a été modifié", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            MessageBox.Show("champs sont vide", "champ invalide", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
        cnx.Close()
    End Sub

    Private Sub BtnFermer_Click(sender As Object, e As EventArgs) Handles btnFermer.Click
        Me.Close()
    End Sub

    Private Sub BtnPrecedent_Click(sender As Object, e As EventArgs) Handles btnPrecedent.Click
        If i = 1 Then
            MessageBox.Show("Désolè c'est le premier client ")
        Else
            i = i - 1
            ChargerChambre(i)


        End If
        txtNbChambre.Text = i.ToString & "/" & nbchambre.ToString
    End Sub

    Private Sub BtnSuivant_Click(sender As Object, e As EventArgs) Handles btnSuivant.Click
        If i = nbchambre Then
            MessageBox.Show("Désolè c'est le dernier client ")
        Else
            i = i + 1
            ChargerChambre(i)

        End If
        txtNbChambre.Text = i.ToString & "/" & nbchambre.ToString
    End Sub

    Private Sub BtnPremier_Click(sender As Object, e As EventArgs) Handles btnPremier.Click
        i = 1
        ChargerChambre(i)
        txtNbChambre.Text = i.ToString & "/" & nbchambre.ToString
    End Sub

    Private Sub BtnDernier_Click(sender As Object, e As EventArgs) Handles btnDernier.Click
        i = nbchambre
        ChargerChambre(i)
        txtNbChambre.Text = i.ToString & "/" & nbchambre.ToString
    End Sub

    Private Sub BtnClient_Click(sender As Object, e As EventArgs) Handles btnClient.Click
        Dim d As Form4 = New Form4
        d.Show()
        Me.Close()
    End Sub


End Class