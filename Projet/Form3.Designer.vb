<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form3
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PrixparChambre = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbEtage = New System.Windows.Forms.ComboBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnModifier = New System.Windows.Forms.Button()
        Me.btnClient = New System.Windows.Forms.Button()
        Me.btnAnnuler = New System.Windows.Forms.Button()
        Me.btnNouveau = New System.Windows.Forms.Button()
        Me.btnAjouter = New System.Windows.Forms.Button()
        Me.btnSupprimer = New System.Windows.Forms.Button()
        Me.btnActualiser = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnFermer = New System.Windows.Forms.Button()
        Me.txtNbChambre = New System.Windows.Forms.TextBox()
        Me.btnSuivant = New System.Windows.Forms.Button()
        Me.btnDernier = New System.Windows.Forms.Button()
        Me.btnPremier = New System.Windows.Forms.Button()
        Me.btnPrecedent = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmbType = New System.Windows.Forms.ComboBox()
        Me.txtNrChambre = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
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
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(1, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1116, 52)
        Me.Panel1.TabIndex = 40
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("MS Reference Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.LightGray
        Me.Label1.Location = New System.Drawing.Point(586, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(128, 29)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Chambre"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(-10, -17)
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
        Me.Label2.Location = New System.Drawing.Point(118, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(228, 41)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Gestion Hôtel"
        '
        'PrixparChambre
        '
        Me.PrixparChambre.BackColor = System.Drawing.Color.LightGray
        Me.PrixparChambre.Font = New System.Drawing.Font("Microsoft YaHei UI", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PrixparChambre.Location = New System.Drawing.Point(571, 350)
        Me.PrixparChambre.Name = "PrixparChambre"
        Me.PrixparChambre.Size = New System.Drawing.Size(231, 42)
        Me.PrixparChambre.TabIndex = 95
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft YaHei UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(565, 316)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(211, 31)
        Me.Label7.TabIndex = 88
        Me.Label7.Text = "Prix Par Chambre"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft YaHei UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(565, 129)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(78, 31)
        Me.Label6.TabIndex = 87
        Me.Label6.Text = "Etage"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(64, 129)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(171, 31)
        Me.Label3.TabIndex = 85
        Me.Label3.Text = "Nr ° Chambre"
        '
        'cmbEtage
        '
        Me.cmbEtage.BackColor = System.Drawing.Color.LightGray
        Me.cmbEtage.Font = New System.Drawing.Font("Microsoft YaHei UI", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbEtage.FormattingEnabled = True
        Me.cmbEtage.Location = New System.Drawing.Point(571, 157)
        Me.cmbEtage.Name = "cmbEtage"
        Me.cmbEtage.Size = New System.Drawing.Size(269, 43)
        Me.cmbEtage.TabIndex = 102
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.LemonChiffon
        Me.Panel3.Controls.Add(Me.btnModifier)
        Me.Panel3.Controls.Add(Me.btnClient)
        Me.Panel3.Controls.Add(Me.btnAnnuler)
        Me.Panel3.Controls.Add(Me.btnNouveau)
        Me.Panel3.Controls.Add(Me.btnAjouter)
        Me.Panel3.Controls.Add(Me.btnSupprimer)
        Me.Panel3.Controls.Add(Me.btnActualiser)
        Me.Panel3.Location = New System.Drawing.Point(933, 50)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(191, 611)
        Me.Panel3.TabIndex = 103
        '
        'btnModifier
        '
        Me.btnModifier.BackColor = System.Drawing.Color.PowderBlue
        Me.btnModifier.Font = New System.Drawing.Font("Microsoft YaHei UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModifier.Location = New System.Drawing.Point(10, 266)
        Me.btnModifier.Name = "btnModifier"
        Me.btnModifier.Size = New System.Drawing.Size(158, 54)
        Me.btnModifier.TabIndex = 104
        Me.btnModifier.Text = "Modifier"
        Me.btnModifier.UseVisualStyleBackColor = False
        '
        'btnClient
        '
        Me.btnClient.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnClient.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClient.ForeColor = System.Drawing.Color.White
        Me.btnClient.Location = New System.Drawing.Point(10, 426)
        Me.btnClient.Name = "btnClient"
        Me.btnClient.Size = New System.Drawing.Size(158, 54)
        Me.btnClient.TabIndex = 107
        Me.btnClient.Text = "Client"
        Me.btnClient.UseVisualStyleBackColor = False
        '
        'btnAnnuler
        '
        Me.btnAnnuler.BackColor = System.Drawing.Color.PowderBlue
        Me.btnAnnuler.Font = New System.Drawing.Font("Microsoft YaHei UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnnuler.Location = New System.Drawing.Point(10, 498)
        Me.btnAnnuler.Name = "btnAnnuler"
        Me.btnAnnuler.Size = New System.Drawing.Size(158, 54)
        Me.btnAnnuler.TabIndex = 5
        Me.btnAnnuler.Text = "Annuler"
        Me.btnAnnuler.UseVisualStyleBackColor = False
        '
        'btnNouveau
        '
        Me.btnNouveau.BackColor = System.Drawing.Color.PowderBlue
        Me.btnNouveau.Font = New System.Drawing.Font("Microsoft YaHei UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNouveau.Location = New System.Drawing.Point(10, 102)
        Me.btnNouveau.Name = "btnNouveau"
        Me.btnNouveau.Size = New System.Drawing.Size(158, 54)
        Me.btnNouveau.TabIndex = 4
        Me.btnNouveau.Text = "Nouveau"
        Me.btnNouveau.UseVisualStyleBackColor = False
        '
        'btnAjouter
        '
        Me.btnAjouter.BackColor = System.Drawing.Color.PowderBlue
        Me.btnAjouter.Font = New System.Drawing.Font("Microsoft YaHei UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAjouter.Location = New System.Drawing.Point(10, 181)
        Me.btnAjouter.Name = "btnAjouter"
        Me.btnAjouter.Size = New System.Drawing.Size(158, 54)
        Me.btnAjouter.TabIndex = 3
        Me.btnAjouter.Text = "Ajouter"
        Me.btnAjouter.UseVisualStyleBackColor = False
        '
        'btnSupprimer
        '
        Me.btnSupprimer.BackColor = System.Drawing.Color.PowderBlue
        Me.btnSupprimer.Font = New System.Drawing.Font("Microsoft YaHei UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSupprimer.Location = New System.Drawing.Point(10, 351)
        Me.btnSupprimer.Name = "btnSupprimer"
        Me.btnSupprimer.Size = New System.Drawing.Size(158, 54)
        Me.btnSupprimer.TabIndex = 2
        Me.btnSupprimer.Text = "Supprimer"
        Me.btnSupprimer.UseVisualStyleBackColor = False
        '
        'btnActualiser
        '
        Me.btnActualiser.BackColor = System.Drawing.Color.PowderBlue
        Me.btnActualiser.Font = New System.Drawing.Font("Microsoft YaHei UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnActualiser.Location = New System.Drawing.Point(10, 27)
        Me.btnActualiser.Name = "btnActualiser"
        Me.btnActualiser.Size = New System.Drawing.Size(158, 54)
        Me.btnActualiser.TabIndex = 0
        Me.btnActualiser.Text = "Actualiser"
        Me.btnActualiser.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel2.Controls.Add(Me.btnFermer)
        Me.Panel2.Controls.Add(Me.txtNbChambre)
        Me.Panel2.Controls.Add(Me.btnSuivant)
        Me.Panel2.Controls.Add(Me.btnDernier)
        Me.Panel2.Controls.Add(Me.btnPremier)
        Me.Panel2.Controls.Add(Me.btnPrecedent)
        Me.Panel2.Location = New System.Drawing.Point(1, 653)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1116, 78)
        Me.Panel2.TabIndex = 101
        '
        'btnFermer
        '
        Me.btnFermer.BackColor = System.Drawing.Color.LightGray
        Me.btnFermer.Font = New System.Drawing.Font("MS Reference Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFermer.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnFermer.Location = New System.Drawing.Point(947, 13)
        Me.btnFermer.Name = "btnFermer"
        Me.btnFermer.Size = New System.Drawing.Size(149, 54)
        Me.btnFermer.TabIndex = 5
        Me.btnFermer.Text = "Fermer"
        Me.btnFermer.UseVisualStyleBackColor = False
        '
        'txtNbChambre
        '
        Me.txtNbChambre.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNbChambre.Location = New System.Drawing.Point(412, 21)
        Me.txtNbChambre.Name = "txtNbChambre"
        Me.txtNbChambre.ReadOnly = True
        Me.txtNbChambre.Size = New System.Drawing.Size(84, 38)
        Me.txtNbChambre.TabIndex = 4
        '
        'btnSuivant
        '
        Me.btnSuivant.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnSuivant.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSuivant.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnSuivant.Location = New System.Drawing.Point(592, 20)
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
        Me.btnDernier.Location = New System.Drawing.Point(715, 22)
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
        Me.btnPremier.Location = New System.Drawing.Point(126, 22)
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
        Me.btnPrecedent.Location = New System.Drawing.Point(277, 22)
        Me.btnPrecedent.Name = "btnPrecedent"
        Me.btnPrecedent.Size = New System.Drawing.Size(38, 37)
        Me.btnPrecedent.TabIndex = 0
        Me.btnPrecedent.Text = "<"
        Me.btnPrecedent.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft YaHei UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(64, 316)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 31)
        Me.Label5.TabIndex = 86
        Me.Label5.Text = "Type"
        '
        'cmbType
        '
        Me.cmbType.BackColor = System.Drawing.Color.LightGray
        Me.cmbType.Font = New System.Drawing.Font("Microsoft YaHei UI", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbType.FormattingEnabled = True
        Me.cmbType.Location = New System.Drawing.Point(70, 350)
        Me.cmbType.Name = "cmbType"
        Me.cmbType.Size = New System.Drawing.Size(269, 43)
        Me.cmbType.TabIndex = 105
        '
        'txtNrChambre
        '
        Me.txtNrChambre.BackColor = System.Drawing.Color.LightGray
        Me.txtNrChambre.Font = New System.Drawing.Font("Microsoft YaHei UI", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNrChambre.Location = New System.Drawing.Point(70, 163)
        Me.txtNrChambre.Name = "txtNrChambre"
        Me.txtNrChambre.Size = New System.Drawing.Size(269, 42)
        Me.txtNrChambre.TabIndex = 106
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft YaHei UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(808, 357)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(51, 31)
        Me.Label9.TabIndex = 132
        Me.Label9.Text = "DH"
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1115, 733)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtNrChambre)
        Me.Controls.Add(Me.cmbType)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.cmbEtage)
        Me.Controls.Add(Me.PrixparChambre)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form3"
        Me.Text = "v"
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
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PrixparChambre As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cmbEtage As ComboBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnNouveau As Button
    Friend WithEvents btnAjouter As Button
    Friend WithEvents btnSupprimer As Button
    Friend WithEvents btnActualiser As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtNbChambre As TextBox
    Friend WithEvents btnSuivant As Button
    Friend WithEvents btnDernier As Button
    Friend WithEvents btnPremier As Button
    Friend WithEvents btnPrecedent As Button
    Friend WithEvents btnFermer As Button
    Friend WithEvents btnAnnuler As Button
    Friend WithEvents btnModifier As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents cmbType As ComboBox
    Friend WithEvents txtNrChambre As TextBox
    Friend WithEvents btnClient As Button
    Friend WithEvents Label9 As Label
End Class
