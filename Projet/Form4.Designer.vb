<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form4
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form4))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Chambre = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnReservation = New System.Windows.Forms.Button()
        Me.btnModifier = New System.Windows.Forms.Button()
        Me.btnAnnuler = New System.Windows.Forms.Button()
        Me.btnNouveau = New System.Windows.Forms.Button()
        Me.btnAjouter = New System.Windows.Forms.Button()
        Me.btnSupprimer = New System.Windows.Forms.Button()
        Me.btnActualiser = New System.Windows.Forms.Button()
        Me.txtDateNaiss = New System.Windows.Forms.TextBox()
        Me.txtVille = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtTel = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtAdress = New System.Windows.Forms.RichTextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtPrenom = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtNom = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtCIN = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnFermer = New System.Windows.Forms.Button()
        Me.txtnbClient = New System.Windows.Forms.TextBox()
        Me.btnSuivant = New System.Windows.Forms.Button()
        Me.btnDernier = New System.Windows.Forms.Button()
        Me.btnPremier = New System.Windows.Forms.Button()
        Me.btnPrecedent = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Chambre)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(2, -7)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1116, 52)
        Me.Panel1.TabIndex = 122
        '
        'Chambre
        '
        Me.Chambre.AutoSize = True
        Me.Chambre.BackColor = System.Drawing.Color.Transparent
        Me.Chambre.Font = New System.Drawing.Font("MS Reference Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chambre.ForeColor = System.Drawing.Color.LightGray
        Me.Chambre.Location = New System.Drawing.Point(611, 10)
        Me.Chambre.Name = "Chambre"
        Me.Chambre.Size = New System.Drawing.Size(86, 29)
        Me.Chambre.TabIndex = 7
        Me.Chambre.Text = "Client"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(-11, -19)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(110, 109)
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Montserrat SemiBold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.Label2.Location = New System.Drawing.Point(116, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(228, 41)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Gestion Hôtel"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.LemonChiffon
        Me.Panel3.Controls.Add(Me.btnReservation)
        Me.Panel3.Controls.Add(Me.btnModifier)
        Me.Panel3.Controls.Add(Me.btnAnnuler)
        Me.Panel3.Controls.Add(Me.btnNouveau)
        Me.Panel3.Controls.Add(Me.btnAjouter)
        Me.Panel3.Controls.Add(Me.btnSupprimer)
        Me.Panel3.Controls.Add(Me.btnActualiser)
        Me.Panel3.Location = New System.Drawing.Point(926, 45)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(195, 616)
        Me.Panel3.TabIndex = 123
        '
        'btnReservation
        '
        Me.btnReservation.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnReservation.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReservation.ForeColor = System.Drawing.Color.White
        Me.btnReservation.Location = New System.Drawing.Point(13, 438)
        Me.btnReservation.Name = "btnReservation"
        Me.btnReservation.Size = New System.Drawing.Size(161, 59)
        Me.btnReservation.TabIndex = 124
        Me.btnReservation.Text = "Resérvation"
        Me.btnReservation.UseVisualStyleBackColor = False
        '
        'btnModifier
        '
        Me.btnModifier.BackColor = System.Drawing.Color.PowderBlue
        Me.btnModifier.Font = New System.Drawing.Font("Microsoft YaHei UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModifier.Location = New System.Drawing.Point(13, 273)
        Me.btnModifier.Name = "btnModifier"
        Me.btnModifier.Size = New System.Drawing.Size(161, 54)
        Me.btnModifier.TabIndex = 6
        Me.btnModifier.Text = "Modifier"
        Me.btnModifier.UseVisualStyleBackColor = False
        '
        'btnAnnuler
        '
        Me.btnAnnuler.BackColor = System.Drawing.Color.PowderBlue
        Me.btnAnnuler.Font = New System.Drawing.Font("Microsoft YaHei UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnnuler.Location = New System.Drawing.Point(13, 518)
        Me.btnAnnuler.Name = "btnAnnuler"
        Me.btnAnnuler.Size = New System.Drawing.Size(161, 54)
        Me.btnAnnuler.TabIndex = 5
        Me.btnAnnuler.Text = "Annuler"
        Me.btnAnnuler.UseVisualStyleBackColor = False
        '
        'btnNouveau
        '
        Me.btnNouveau.BackColor = System.Drawing.Color.PowderBlue
        Me.btnNouveau.Font = New System.Drawing.Font("Microsoft YaHei UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNouveau.Location = New System.Drawing.Point(13, 98)
        Me.btnNouveau.Name = "btnNouveau"
        Me.btnNouveau.Size = New System.Drawing.Size(161, 54)
        Me.btnNouveau.TabIndex = 4
        Me.btnNouveau.Text = "Nouveau"
        Me.btnNouveau.UseVisualStyleBackColor = False
        '
        'btnAjouter
        '
        Me.btnAjouter.BackColor = System.Drawing.Color.PowderBlue
        Me.btnAjouter.Font = New System.Drawing.Font("Microsoft YaHei UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAjouter.Location = New System.Drawing.Point(13, 194)
        Me.btnAjouter.Name = "btnAjouter"
        Me.btnAjouter.Size = New System.Drawing.Size(161, 54)
        Me.btnAjouter.TabIndex = 3
        Me.btnAjouter.Text = "Ajouter"
        Me.btnAjouter.UseVisualStyleBackColor = False
        '
        'btnSupprimer
        '
        Me.btnSupprimer.BackColor = System.Drawing.Color.PowderBlue
        Me.btnSupprimer.Font = New System.Drawing.Font("Microsoft YaHei UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSupprimer.Location = New System.Drawing.Point(13, 365)
        Me.btnSupprimer.Name = "btnSupprimer"
        Me.btnSupprimer.Size = New System.Drawing.Size(161, 54)
        Me.btnSupprimer.TabIndex = 2
        Me.btnSupprimer.Text = "Supprimer"
        Me.btnSupprimer.UseVisualStyleBackColor = False
        '
        'btnActualiser
        '
        Me.btnActualiser.BackColor = System.Drawing.Color.PowderBlue
        Me.btnActualiser.Font = New System.Drawing.Font("Microsoft YaHei UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnActualiser.Location = New System.Drawing.Point(13, 21)
        Me.btnActualiser.Name = "btnActualiser"
        Me.btnActualiser.Size = New System.Drawing.Size(161, 54)
        Me.btnActualiser.TabIndex = 0
        Me.btnActualiser.Text = "Actualiser"
        Me.btnActualiser.UseVisualStyleBackColor = False
        '
        'txtDateNaiss
        '
        Me.txtDateNaiss.BackColor = System.Drawing.Color.LightGray
        Me.txtDateNaiss.Font = New System.Drawing.Font("Microsoft YaHei UI", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDateNaiss.Location = New System.Drawing.Point(69, 517)
        Me.txtDateNaiss.Name = "txtDateNaiss"
        Me.txtDateNaiss.Size = New System.Drawing.Size(295, 42)
        Me.txtDateNaiss.TabIndex = 137
        '
        'txtVille
        '
        Me.txtVille.BackColor = System.Drawing.Color.LightGray
        Me.txtVille.Font = New System.Drawing.Font("Microsoft YaHei UI", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVille.Location = New System.Drawing.Point(571, 514)
        Me.txtVille.Name = "txtVille"
        Me.txtVille.Size = New System.Drawing.Size(295, 42)
        Me.txtVille.TabIndex = 136
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft YaHei UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(565, 480)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(62, 31)
        Me.Label9.TabIndex = 135
        Me.Label9.Text = "Ville"
        '
        'txtTel
        '
        Me.txtTel.BackColor = System.Drawing.Color.LightGray
        Me.txtTel.Font = New System.Drawing.Font("Microsoft YaHei UI", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTel.Location = New System.Drawing.Point(571, 375)
        Me.txtTel.Name = "txtTel"
        Me.txtTel.Size = New System.Drawing.Size(295, 42)
        Me.txtTel.TabIndex = 134
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft YaHei UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(565, 341)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(48, 31)
        Me.Label10.TabIndex = 133
        Me.Label10.Text = "Tel"
        '
        'txtAdress
        '
        Me.txtAdress.BackColor = System.Drawing.Color.LightGray
        Me.txtAdress.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAdress.Location = New System.Drawing.Point(571, 143)
        Me.txtAdress.Name = "txtAdress"
        Me.txtAdress.Size = New System.Drawing.Size(295, 145)
        Me.txtAdress.TabIndex = 132
        Me.txtAdress.Text = ""
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft YaHei UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(565, 109)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(91, 31)
        Me.Label11.TabIndex = 131
        Me.Label11.Text = "Adress"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft YaHei UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(63, 483)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(167, 31)
        Me.Label12.TabIndex = 130
        Me.Label12.Text = "D . Naissance"
        '
        'txtPrenom
        '
        Me.txtPrenom.BackColor = System.Drawing.Color.LightGray
        Me.txtPrenom.Font = New System.Drawing.Font("Microsoft YaHei UI", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrenom.Location = New System.Drawing.Point(69, 375)
        Me.txtPrenom.Name = "txtPrenom"
        Me.txtPrenom.Size = New System.Drawing.Size(295, 42)
        Me.txtPrenom.TabIndex = 129
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft YaHei UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(63, 341)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(104, 31)
        Me.Label13.TabIndex = 128
        Me.Label13.Text = "Prenom"
        '
        'txtNom
        '
        Me.txtNom.BackColor = System.Drawing.Color.LightGray
        Me.txtNom.Font = New System.Drawing.Font("Microsoft YaHei UI", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNom.Location = New System.Drawing.Point(69, 251)
        Me.txtNom.Name = "txtNom"
        Me.txtNom.Size = New System.Drawing.Size(295, 42)
        Me.txtNom.TabIndex = 127
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft YaHei UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(63, 217)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(71, 31)
        Me.Label14.TabIndex = 126
        Me.Label14.Text = "Nom"
        '
        'txtCIN
        '
        Me.txtCIN.BackColor = System.Drawing.Color.LightGray
        Me.txtCIN.Font = New System.Drawing.Font("Microsoft YaHei UI", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCIN.Location = New System.Drawing.Point(69, 143)
        Me.txtCIN.Name = "txtCIN"
        Me.txtCIN.Size = New System.Drawing.Size(295, 42)
        Me.txtCIN.TabIndex = 125
        Me.txtCIN.Text = "  "
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft YaHei UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(63, 109)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(57, 31)
        Me.Label15.TabIndex = 124
        Me.Label15.Text = "CIN"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel2.Controls.Add(Me.btnFermer)
        Me.Panel2.Controls.Add(Me.txtnbClient)
        Me.Panel2.Controls.Add(Me.btnSuivant)
        Me.Panel2.Controls.Add(Me.btnDernier)
        Me.Panel2.Controls.Add(Me.btnPremier)
        Me.Panel2.Controls.Add(Me.btnPrecedent)
        Me.Panel2.Location = New System.Drawing.Point(2, 654)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1116, 78)
        Me.Panel2.TabIndex = 138
        '
        'btnFermer
        '
        Me.btnFermer.BackColor = System.Drawing.Color.Gainsboro
        Me.btnFermer.Font = New System.Drawing.Font("MS Reference Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFermer.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnFermer.Location = New System.Drawing.Point(937, 13)
        Me.btnFermer.Name = "btnFermer"
        Me.btnFermer.Size = New System.Drawing.Size(149, 54)
        Me.btnFermer.TabIndex = 5
        Me.btnFermer.Text = "Fermer"
        Me.btnFermer.UseVisualStyleBackColor = False
        '
        'txtnbClient
        '
        Me.txtnbClient.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnbClient.Location = New System.Drawing.Point(400, 22)
        Me.txtnbClient.Name = "txtnbClient"
        Me.txtnbClient.ReadOnly = True
        Me.txtnbClient.Size = New System.Drawing.Size(80, 38)
        Me.txtnbClient.TabIndex = 4
        Me.txtnbClient.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnSuivant
        '
        Me.btnSuivant.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnSuivant.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSuivant.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnSuivant.Location = New System.Drawing.Point(587, 22)
        Me.btnSuivant.Name = "btnSuivant"
        Me.btnSuivant.Size = New System.Drawing.Size(38, 37)
        Me.btnSuivant.TabIndex = 3
        Me.btnSuivant.Text = ">"
        Me.btnSuivant.UseVisualStyleBackColor = False
        '
        'btnDernier
        '
        Me.btnDernier.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnDernier.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDernier.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnDernier.Location = New System.Drawing.Point(720, 22)
        Me.btnDernier.Name = "btnDernier"
        Me.btnDernier.Size = New System.Drawing.Size(60, 37)
        Me.btnDernier.TabIndex = 2
        Me.btnDernier.Text = ">>"
        Me.btnDernier.UseVisualStyleBackColor = False
        '
        'btnPremier
        '
        Me.btnPremier.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnPremier.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPremier.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnPremier.Location = New System.Drawing.Point(124, 22)
        Me.btnPremier.Name = "btnPremier"
        Me.btnPremier.Size = New System.Drawing.Size(60, 37)
        Me.btnPremier.TabIndex = 1
        Me.btnPremier.Text = "<<"
        Me.btnPremier.UseVisualStyleBackColor = False
        '
        'btnPrecedent
        '
        Me.btnPrecedent.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnPrecedent.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrecedent.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnPrecedent.Location = New System.Drawing.Point(261, 22)
        Me.btnPrecedent.Name = "btnPrecedent"
        Me.btnPrecedent.Size = New System.Drawing.Size(38, 37)
        Me.btnPrecedent.TabIndex = 0
        Me.btnPrecedent.Text = "<"
        Me.btnPrecedent.UseVisualStyleBackColor = False
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1118, 733)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.txtDateNaiss)
        Me.Controls.Add(Me.txtVille)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtTel)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtAdress)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtPrenom)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtNom)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txtCIN)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form4"
        Me.Text = "Form4"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Chambre As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnModifier As Button
    Friend WithEvents btnAnnuler As Button
    Friend WithEvents btnNouveau As Button
    Friend WithEvents btnAjouter As Button
    Friend WithEvents btnSupprimer As Button
    Friend WithEvents btnActualiser As Button
    Friend WithEvents btnReservation As Button
    Friend WithEvents txtDateNaiss As TextBox
    Friend WithEvents txtVille As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtTel As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtAdress As RichTextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents txtPrenom As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txtNom As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents txtCIN As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnFermer As Button
    Friend WithEvents txtnbClient As TextBox
    Friend WithEvents btnSuivant As Button
    Friend WithEvents btnDernier As Button
    Friend WithEvents btnPremier As Button
    Friend WithEvents btnPrecedent As Button
End Class
