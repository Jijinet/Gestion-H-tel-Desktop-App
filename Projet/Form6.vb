Imports System.Data.SqlClient
Imports System.Data
Public Class Form6

    Sub NombreJours()
        Dim datedepart As DateTime = DateTime.Parse(txtDateDépart.Text)
        Dim datefin As DateTime = DateTime.Parse(txtDateFin.Text)
        txtNbDeJour.Text = DateDiff(DateInterval.Day, datedepart, datefin).ToString()
    End Sub
    Function PrixTotal() As Integer
        Dim PrixT As Double
        Dim priCh As Double
        cnx.Open()
        cmd = New SqlCommand("select prixparchambre from chambre where Nrchambre=" & cmbNrChambre.SelectedValue & "", cnx)
        priCh = Double.Parse(cmd.ExecuteScalar().ToString())
        PrixT = priCh * Integer.Parse(txtNbDeJour.Text)
        cnx.Close()
        Return PrixT
    End Function

    Dim cnx As SqlConnection = New SqlConnection("server=DESKTOP-FL4FBU4\SQLEXPRESS;database=GestionHotel;integrated security=true")
    Dim cmd As SqlCommand
    Dim dtRes, dt As DataTable
    Dim dr As SqlDataReader
    Dim da As SqlDataAdapter
    Dim i As Integer
    Dim nbFacture As Integer


    Sub ChargerNrChambre()
        cnx.Open()
        cmd = New SqlCommand(" select TypeChambre+' '+Etage as 'NomCh',NrChambre
from Chambre where disponible = 1", cnx)
        dr = cmd.ExecuteReader()
        dt = New DataTable()
        dt.Load(dr)
        cmbNrChambre.DataSource = dt
        cmbNrChambre.DisplayMember = "NomCh"
        cmbNrChambre.ValueMember = "NrChambre"

        cnx.Close()
    End Sub
    Sub ChargerIdReserve()
        cnx.Open()
        cmd = New SqlCommand(" select ReserveId,convert(char(5),ReserveId)+'| '+cin as 'IRd' from Reservation", cnx)
        dr = cmd.ExecuteReader()
        dtRes = New DataTable()
        dtRes.Load(dr)
        cmbIdReserve.DataSource = dtRes
        cmbIdReserve.DisplayMember = "IRd"
        cmbIdReserve.ValueMember = "ReserveId"

        cnx.Close()
    End Sub
    Function nbFactures()
        cnx.Open()
        cmd = New SqlCommand("select count(*) from Facture", cnx)
        nbFacture = Integer.Parse(cmd.ExecuteScalar())
        cnx.Close()
        Return nbFacture
    End Function
    Private Sub BtnTerminé_Click(sender As Object, e As EventArgs) Handles btnTerminé.Click
        Dim y As Form2 = New Form2
        y.Show()
        Me.Hide()
    End Sub

    Private Sub BtnActualiser_Click_1(sender As Object, e As EventArgs) Handles btnActualiser.Click
        Form6_Load(sender, e)
    End Sub

    Private Sub BtnNouveau_Click_1(sender As Object, e As EventArgs) Handles btnNouveau.Click
        txtDateFin.Clear()
        txtDateDépart.Clear()
        cmbIdReserve.Text = ""
        txtNbDeJour.Clear()
        cmbNrChambre.Text = ""
        txtPrixTotal.Clear()
    End Sub

    Private Sub BtnAjouter_Click_1(sender As Object, e As EventArgs) Handles btnAjouter.Click
        PrixTotal()
        NombreJours()
        cnx.Open()
        If txtDateDépart.Text <> "" Or txtDateFin.Text <> "" Or txtNbDeJour.Text <> "" Or txtPrixTotal.Text <> "" Then

            cmd = New SqlCommand("insert into Facture values (" & cmbIdReserve.SelectedValue & "," & cmbNrChambre.SelectedValue & ",
        '" & txtDateDépart.Text & "','" & txtDateFin.Text & "'," & txtPrixTotal.Text & ")", cnx)
            If cmd.ExecuteNonQuery() = 1 Then
                MessageBox.Show("Facture  ajouté", "", MessageBoxButtons.OK, MessageBoxIcon.Information)

            End If
        Else
            MessageBox.Show("champs sont vide", "champ invalide", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
        cnx.Close()

    End Sub

    Private Sub BtnModifier_Click(sender As Object, e As EventArgs) Handles btnModifier.Click
        cnx.Open()
        If txtDateDépart.Text <> "" Or txtDateFin.Text <> "" Or txtNbDeJour.Text <> "" Or txtPrixTotal.Text <> "" Then

            cmd = New SqlCommand("update Facture  set DateDepart='" & txtDateDépart.Text & "',
           DateFin='" & txtDateFin.Text & "',NbJours=" & txtNbDeJour.Text & ",PrixTotal=" & txtPrixTotal.Text & " where ReserveId=" & cmbIdReserve.Text.ToString & " and NrChambre=" & cmbNrChambre.Text.ToString & " )", cnx)
            If cmd.ExecuteNonQuery() = 1 Then
                MessageBox.Show("La Facture a été modifié", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            MessageBox.Show("champs sont vide", "champ invalide", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub BtnAnnuler_Click_1(sender As Object, e As EventArgs) Handles btnAnnuler.Click
        Dim gf As Form2 = New Form2
        gf.Show()
        Me.Hide()
    End Sub

    Private Sub BtnSupprimer_Click(sender As Object, e As EventArgs) 
        cnx.Open()
        If True Then

            cmd = New SqlCommand("delete from Facture where ReserveId=" & cmbIdReserve.Text.ToString & " and NrChambre=" & cmbNrChambre.Text.ToString & "", cnx)
            If cmd.ExecuteNonQuery() = 1 Then
                MessageBox.Show("Facture à été Supprimé")
            End If
        Else
            MessageBox.Show("champs sont vide", "champ invalide", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
        cnx.Close()
    End Sub

    Private Sub BtnFermer_Click(sender As Object, e As EventArgs) Handles btnFermer.Click
        Me.Close()
    End Sub

    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ChargerNrChambre()
        ChargerIdReserve()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) 

    End Sub

    Private Sub TxtDateFin_Leave(sender As Object, e As EventArgs) Handles txtDateFin.Leave
        NombreJours()
        txtPrixTotal.Text = PrixTotal().ToString()
    End Sub


End Class