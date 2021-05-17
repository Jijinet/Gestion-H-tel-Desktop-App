Imports System.Data.SqlClient
Imports System.Data.Sql
Public Class Form5
    Dim cnx As SqlConnection = New SqlConnection("server=DESKTOP-FL4FBU4\SQLEXPRESS;database=GestionHotel;integrated security=true")
    Dim cmd As SqlCommand
    Dim cmdCH As SqlCommand
    Dim dt As DataTable
    Dim dr As SqlDataReader
    Dim da As SqlDataAdapter
    Dim i As Integer
    Dim nbreserve As Integer
    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ChargerReservation(1)
        ChargerNrChambre()
        ChargerCIN()
        nbReservation()

    End Sub
    Sub ChargerCIN()
        cnx.Open()
        cmd = New SqlCommand("select nom+' '+prenom as 'NomCmpt', c.CIN from Client c", cnx)
        dr = cmd.ExecuteReader()
        dt = New DataTable()
        dt.Load(dr)
        cmbCIN.DataSource = dt
        cmbCIN.DisplayMember = "NomCmpt"
        cmbCIN.ValueMember = "CIN"
        cnx.Close()
    End Sub
    Sub ChargerNrChambre()
        cnx.Open()
        cmd = New SqlCommand(" select TypeChambre+' '+Etage as 'NomCh',NrChambre
from Chambre where disponible = 0", cnx)
        dr = cmd.ExecuteReader()
        dt = New DataTable()
        dt.Load(dr)
        cmbNrChambre.DataSource = dt
        cmbNrChambre.DisplayMember = "NrChambre"
        cmbNrChambre.ValueMember = "NrChambre"

        cnx.Close()
    End Sub
    Sub ChargerReservation(ByVal p As Integer)
        cnx.Open()
        cmd = New SqlCommand("select top " & p & " * from Reservation", cnx)
        dr = cmd.ExecuteReader()
        While dr.Read()
            txtIdReserve.Text = dr(0).ToString()
            cmbCIN.SelectedValue = dr(1).ToString()
            cmbNrChambre.Text = dr(2).ToString()
        End While
        dr.Close()
        cnx.Close()
    End Sub
    Function nbReservation()
        cnx.Open()
        cmd = New SqlCommand("select count(*) from Reservation", cnx)
        nbreserve = Integer.Parse(cmd.ExecuteScalar())
        cnx.Close()
        Return nbreserve
    End Function

    Private Sub BtnSupprimer_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub BtnActualiser_Click_1(sender As Object, e As EventArgs) Handles btnActualiser.Click
        Form5_Load(sender, e)
    End Sub

    Private Sub BtnNouveau_Click_1(sender As Object, e As EventArgs) Handles btnNouveau.Click
        cmbCIN.Text = ""
        txtIdReserve.Clear()
        cmbNrChambre.Text = ""
    End Sub

    Private Sub BtnAjouter_Click_1(sender As Object, e As EventArgs) Handles btnAjouter.Click
        cnx.Open()
        If txtIdReserve.Text <> "" Or cmbCIN.Text <> "" Or cmbNrChambre.Text <> "" Then


            cmd = New SqlCommand("insert into Reservation values ('" & cmbCIN.SelectedValue & "'," & cmbNrChambre.Text & ")", cnx)
            If cmd.ExecuteNonQuery() = 1 Then
                cmdCH = New SqlCommand("update chambre set disponible=1 where nrchambre='" & cmbNrChambre.Text.ToString & "'", cnx)
                cmdCH.ExecuteNonQuery()
                MessageBox.Show("Réservation réussie", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("La réservation a échoué", "", MessageBoxButtons.OK, MessageBoxIcon.None)
            End If
        Else
            MessageBox.Show("champs sont vide", "champ invalide", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
        cnx.Close()
    End Sub

    Private Sub BtnSupprimer_Click_1(sender As Object, e As EventArgs) 

        cnx.Open()
        If True Then

            cmd = New SqlCommand("delete from Reservation where ReserveId=" & txtIdReserve.Text.ToString & "", cnx)
            If cmd.ExecuteNonQuery() = 1 Then
                cmdCH = New SqlCommand("update chambre set disponible=1 where nrchambre='" & cmbNrChambre.Text.ToString & "'", cnx)
                cmdCH.ExecuteNonQuery()
                MessageBox.Show("La Reservation à été Supprimé")

            End If

        End If
        cnx.Close()
    End Sub

    Private Sub BtnModifier_Click(sender As Object, e As EventArgs) Handles btnModifier.Click
        cnx.Open()
        If txtIdReserve.Text <> "" Or cmbCIN.Text <> "" Or cmbNrChambre.Text <> "" Then

            cmd = New SqlCommand("update Reservation set CIN='" & cmbCIN.SelectedValue & "', NrChambre=" & cmbNrChambre.Text.ToString & " where ReserveId=" & txtIdReserve.Text & "", cnx)
            If cmd.ExecuteNonQuery() = 1 Then
                MessageBox.Show("Reservation a été modifié", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Else
            MessageBox.Show("champs sont vide", "champ invalide", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
        cnx.Close()
    End Sub

    Private Sub BtnAnnuler_Click_1(sender As Object, e As EventArgs) Handles btnAnnuler.Click
        Dim gr As Form2 = New Form2
        gr.Show()
        Me.Hide()
    End Sub

    Private Sub BtnFermer_Click(sender As Object, e As EventArgs) Handles btnFermer.Click
        Me.Close()
    End Sub

    Private Sub BtnLaFacture_Click_1(sender As Object, e As EventArgs) Handles btnLaFacture.Click
        Dim r As Form6 = New Form6
        r.Show()
        Me.Hide()
    End Sub
End Class