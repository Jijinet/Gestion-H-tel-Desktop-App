
Imports System.Data.SqlClient
Imports System.Data.Sql
Public Class Form4

    Dim cnx As SqlConnection = New SqlConnection("server=DESKTOP-FL4FBU4\SQLEXPRESS;database=GestionHotel;integrated security=true")
    Dim cmd As SqlCommand
    Dim dt As DataTable
    Dim dr As SqlDataReader
    Dim da As SqlDataAdapter
    Dim nbclient As Integer
    Dim i As Integer = 1


    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ChargerClients(1)
        nbClients()
        txtnbClient.Text = i.ToString & "/" & nbclient.ToString

    End Sub
    Function nbClients()
        cnx.Open()
        cmd = New SqlCommand("select count(*) from Client", cnx)
        nbclient = Integer.Parse(cmd.ExecuteScalar())
        cnx.Close()
        Return nbclient
    End Function
    Sub ChargerClients(ByVal p As Integer)
        cnx.Open()
        cmd = New SqlCommand("select top " & p & " * from Client", cnx)
        dr = cmd.ExecuteReader()
        While dr.Read()
            txtCIN.Text = dr(0).ToString
            txtNom.Text = dr(1).ToString
            txtPrenom.Text = dr(2).ToString
            'txtDateNaiss.Text = DateTime.Parse(dr(3).ToString()).ToLocalTime
            txtDateNaiss.Text = Date.Parse(dr(3).ToString()).ToShortDateString()
            txtAdress.Text = dr(4).ToString
            txtTel.Text = dr(5).ToString
            txtVille.Text = dr(6).ToString
        End While
        dr.Close()
        cnx.Close()

    End Sub
    Function CheckStr(ByVal Pstr As String) As Integer
        Dim a As Integer = 0

        Return a
    End Function
    Private Sub BtnFermer_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub BtnReservation_Click(sender As Object, e As EventArgs) Handles btnReservation.Click
        Dim o As Form5 = New Form5
        o.Show()
        Me.Hide()
    End Sub

    Private Sub BtnSupprimer_Click_1(sender As Object, e As EventArgs) Handles btnSupprimer.Click
        cnx.Open()
        If True Then

            cmd = New SqlCommand("delete from Client where CIN='" & txtCIN.Text & "'", cnx)
            If cmd.ExecuteNonQuery() = 1 Then
                MessageBox.Show("Utilisateur à été Supprimé")

            End If
        End If

        cnx.Close()
    End Sub

    Private Sub BtnModifier_Click_1(sender As Object, e As EventArgs) Handles btnModifier.Click
        cnx.Open()
        If txtAdress.Text <> "" Or txtCIN.Text <> "" Or txtDateNaiss.Text <> "" Or txtNom.Text <> "" Or txtPrenom.Text <> "" Or txtTel.Text <> "" Or txtVille.Text <> "" Then

            cmd = New SqlCommand("update Client  set Nom='" & txtNom.Text & "',
            Prenom='" & txtPrenom.Text & "',DateNaiss='" & Convert.ToDateTime(txtDateNaiss.Text) & "',Adresse='" & txtAdress.Text & "',NumTel='" & txtTel.Text & "',Ville='" & txtVille.Text & "' where CIN='" & txtCIN.Text & "'", cnx)
            If cmd.ExecuteNonQuery() = 1 Then
                MessageBox.Show("Utilisateur a été modifié", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            MessageBox.Show("champs sont vide", "champ invalide", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub BtnNouveau_Click_1(sender As Object, e As EventArgs) Handles btnNouveau.Click
        txtAdress.Clear()
        txtCIN.Clear()
        txtnbClient.Clear()
        txtNom.Clear()
        txtPrenom.Clear()
        txtTel.Clear()
        txtVille.Clear()
        txtDateNaiss.Clear()
    End Sub

    Private Sub BtnActualiser_Click_1(sender As Object, e As EventArgs) Handles btnActualiser.Click
        Form4_Load(sender, e)
    End Sub

    Private Sub BtnAnnuler_Click_1(sender As Object, e As EventArgs) Handles btnAnnuler.Click
        Dim gc As Form2 = New Form2
        gc.Show()
        Me.Hide()
    End Sub

    Private Sub BtnAjouter_Click(sender As Object, e As EventArgs) Handles btnAjouter.Click
        cnx.Open()
        If txtAdress.Text <> "" And txtCIN.Text <> "" And txtDateNaiss.Text <> "" And txtNom.Text <> "" And txtPrenom.Text <> "" And txtTel.Text <> "" And txtVille.Text <> "" Then

            cmd = New SqlCommand("insert into Client values ('" & txtCIN.Text & "','" & txtNom.Text & "',
        '" & txtPrenom.Text & "','" & txtDateNaiss.Text.ToString & "','" & txtAdress.Text & "','" & txtTel.Text & "','" & txtVille.Text & "')", cnx)
            If cmd.ExecuteNonQuery() = 1 Then
                MessageBox.Show("Utilisateur  ajouté", "", MessageBoxButtons.OK, MessageBoxIcon.Information)

            End If
        Else
            MessageBox.Show("champs sont vide", "champ invalide", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
        cnx.Close()
    End Sub

    Private Sub BtnFermer_Click_1(sender As Object, e As EventArgs) Handles btnFermer.Click
        Me.Close()
    End Sub

    Private Sub BtnSuivant_Click_1(sender As Object, e As EventArgs) Handles btnSuivant.Click
        If i = nbclient Then
            MessageBox.Show("Désolè c'est le dernier client ")
        Else
            ChargerClients(i)
            i = i + 1
        End If
        txtnbClient.Text = i.ToString & "/" & nbclient.ToString
    End Sub

    Private Sub BtnDernier_Click_1(sender As Object, e As EventArgs) Handles btnDernier.Click
        i = nbclient
        ChargerClients(i)
        txtnbClient.Text = i.ToString & "/" & nbclient.ToString
    End Sub

    Private Sub BtnPrecedent_Click_1(sender As Object, e As EventArgs) Handles btnPrecedent.Click
        If i = 1 Then
            MessageBox.Show("Désolè c'est le premier client ")
        Else
            ChargerClients(i)
            i = i - 1
        End If
        txtnbClient.Text = i.ToString & "/" & nbclient.ToString
    End Sub

    Private Sub BtnPremier_Click_1(sender As Object, e As EventArgs) Handles btnPremier.Click
        i = 1
        ChargerClients(i)
        txtnbClient.Text = i.ToString & "/" & nbclient.ToString
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class