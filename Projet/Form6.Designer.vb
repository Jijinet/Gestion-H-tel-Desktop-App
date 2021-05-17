<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form6
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form6))
        Me.txtDateDépart = New System.Windows.Forms.TextBox()
        Me.txtDateFin = New System.Windows.Forms.TextBox()
        Me.btnFermer = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnTerminé = New System.Windows.Forms.Button()
        Me.btnModifier = New System.Windows.Forms.Button()
        Me.btnAnnuler = New System.Windows.Forms.Button()
        Me.btnNouveau = New System.Windows.Forms.Button()
        Me.btnAjouter = New System.Windows.Forms.Button()
        Me.btnActualiser = New System.Windows.Forms.Button()
        Me.txtPrixTotal = New System.Windows.Forms.TextBox()
        Me.txtNbDeJour = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbNrChambre = New System.Windows.Forms.ComboBox()
        Me.cmbIdReserve = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Chambre = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtDateDépart
        '
        Me.txtDateDépart.BackColor = System.Drawing.Color.LightGray
        Me.txtDateDépart.Font = New System.Drawing.Font("Microsoft YaHei UI", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDateDépart.Location = New System.Drawing.Point(39, 327)
        Me.txtDateDépart.Name = "txtDateDépart"
        Me.txtDateDépart.Size = New System.Drawing.Size(329, 42)
        Me.txtDateDépart.TabIndex = 119
        '
        'txtDateFin
        '
        Me.txtDateFin.BackColor = System.Drawing.Color.LightGray
        Me.txtDateFin.Font = New System.Drawing.Font("Microsoft YaHei UI", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDateFin.Location = New System.Drawing.Point(39, 492)
        Me.txtDateFin.Name = "txtDateFin"
        Me.txtDateFin.Size = New System.Drawing.Size(331, 42)
        Me.txtDateFin.TabIndex = 118
        '
        'btnFermer
        '
        Me.btnFermer.BackColor = System.Drawing.Color.LightGray
        Me.btnFermer.Font = New System.Drawing.Font("MS Reference Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFermer.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnFermer.Location = New System.Drawing.Point(955, 11)
        Me.btnFermer.Name = "btnFermer"
        Me.btnFermer.Size = New System.Drawing.Size(149, 54)
        Me.btnFermer.TabIndex = 5
        Me.btnFermer.Text = "Fermer"
        Me.btnFermer.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.LemonChiffon
        Me.Panel3.Controls.Add(Me.btnTerminé)
        Me.Panel3.Controls.Add(Me.btnModifier)
        Me.Panel3.Controls.Add(Me.btnAnnuler)
        Me.Panel3.Controls.Add(Me.btnNouveau)
        Me.Panel3.Controls.Add(Me.btnAjouter)
        Me.Panel3.Controls.Add(Me.btnActualiser)
        Me.Panel3.Location = New System.Drawing.Point(922, 49)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(195, 611)
        Me.Panel3.TabIndex = 116
        '
        'btnTerminé
        '
        Me.btnTerminé.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnTerminé.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTerminé.ForeColor = System.Drawing.Color.White
        Me.btnTerminé.Location = New System.Drawing.Point(23, 450)
        Me.btnTerminé.Name = "btnTerminé"
        Me.btnTerminé.Size = New System.Drawing.Size(161, 54)
        Me.btnTerminé.TabIndex = 106
        Me.btnTerminé.Text = "Términé"
        Me.btnTerminé.UseVisualStyleBackColor = False
        '
        'btnModifier
        '
        Me.btnModifier.BackColor = System.Drawing.Color.PowderBlue
        Me.btnModifier.Font = New System.Drawing.Font("Microsoft YaHei UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModifier.Location = New System.Drawing.Point(23, 278)
        Me.btnModifier.Name = "btnModifier"
        Me.btnModifier.Size = New System.Drawing.Size(161, 54)
        Me.btnModifier.TabIndex = 7
        Me.btnModifier.Text = "Modifier"
        Me.btnModifier.UseVisualStyleBackColor = False
        '
        'btnAnnuler
        '
        Me.btnAnnuler.BackColor = System.Drawing.Color.PowderBlue
        Me.btnAnnuler.Font = New System.Drawing.Font("Microsoft YaHei UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnnuler.Location = New System.Drawing.Point(23, 358)
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
        Me.btnNouveau.Location = New System.Drawing.Point(22, 114)
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
        Me.btnAjouter.Location = New System.Drawing.Point(23, 196)
        Me.btnAjouter.Name = "btnAjouter"
        Me.btnAjouter.Size = New System.Drawing.Size(161, 54)
        Me.btnAjouter.TabIndex = 3
        Me.btnAjouter.Text = "Ajouter"
        Me.btnAjouter.UseVisualStyleBackColor = False
        '
        'btnActualiser
        '
        Me.btnActualiser.BackColor = System.Drawing.Color.PowderBlue
        Me.btnActualiser.Font = New System.Drawing.Font("Microsoft YaHei UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnActualiser.Location = New System.Drawing.Point(22, 30)
        Me.btnActualiser.Name = "btnActualiser"
        Me.btnActualiser.Size = New System.Drawing.Size(161, 54)
        Me.btnActualiser.TabIndex = 0
        Me.btnActualiser.Text = "Actualiser"
        Me.btnActualiser.UseVisualStyleBackColor = False
        '
        'txtPrixTotal
        '
        Me.txtPrixTotal.BackColor = System.Drawing.Color.LightGray
        Me.txtPrixTotal.Font = New System.Drawing.Font("Microsoft YaHei UI", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrixTotal.Location = New System.Drawing.Point(555, 492)
        Me.txtPrixTotal.Name = "txtPrixTotal"
        Me.txtPrixTotal.ReadOnly = True
        Me.txtPrixTotal.Size = New System.Drawing.Size(258, 42)
        Me.txtPrixTotal.TabIndex = 115
        '
        'txtNbDeJour
        '
        Me.txtNbDeJour.BackColor = System.Drawing.Color.LightGray
        Me.txtNbDeJour.Font = New System.Drawing.Font("Microsoft YaHei UI", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNbDeJour.Location = New System.Drawing.Point(555, 322)
        Me.txtNbDeJour.Name = "txtNbDeJour"
        Me.txtNbDeJour.ReadOnly = True
        Me.txtNbDeJour.Size = New System.Drawing.Size(258, 42)
        Me.txtNbDeJour.TabIndex = 114
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft YaHei UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(549, 458)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(120, 31)
        Me.Label8.TabIndex = 110
        Me.Label8.Text = "Prix Total"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft YaHei UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(549, 288)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(212, 31)
        Me.Label7.TabIndex = 109
        Me.Label7.Text = "Nombre de Jours"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft YaHei UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(33, 458)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(109, 31)
        Me.Label6.TabIndex = 108
        Me.Label6.Text = "Date Fin"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft YaHei UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(35, 293)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(153, 31)
        Me.Label5.TabIndex = 107
        Me.Label5.Text = "Date Départ"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(549, 134)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(171, 31)
        Me.Label3.TabIndex = 105
        Me.Label3.Text = "Nr ° Chambre"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft YaHei UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(35, 134)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(137, 31)
        Me.Label4.TabIndex = 104
        Me.Label4.Text = "ID Reserve"
        '
        'cmbNrChambre
        '
        Me.cmbNrChambre.BackColor = System.Drawing.Color.LightGray
        Me.cmbNrChambre.Font = New System.Drawing.Font("Microsoft YaHei UI", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbNrChambre.FormattingEnabled = True
        Me.cmbNrChambre.Location = New System.Drawing.Point(555, 168)
        Me.cmbNrChambre.Name = "cmbNrChambre"
        Me.cmbNrChambre.Size = New System.Drawing.Size(331, 43)
        Me.cmbNrChambre.TabIndex = 129
        '
        'cmbIdReserve
        '
        Me.cmbIdReserve.BackColor = System.Drawing.Color.LightGray
        Me.cmbIdReserve.Font = New System.Drawing.Font("Microsoft YaHei UI", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbIdReserve.FormattingEnabled = True
        Me.cmbIdReserve.Location = New System.Drawing.Point(39, 168)
        Me.cmbIdReserve.Name = "cmbIdReserve"
        Me.cmbIdReserve.Size = New System.Drawing.Size(333, 43)
        Me.cmbIdReserve.TabIndex = 128
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(819, 322)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 31)
        Me.Label1.TabIndex = 130
        Me.Label1.Text = "Jour (s)"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft YaHei UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(819, 499)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(51, 31)
        Me.Label9.TabIndex = 131
        Me.Label9.Text = "DH"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel2.Controls.Add(Me.btnFermer)
        Me.Panel2.Location = New System.Drawing.Point(1, 656)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1116, 78)
        Me.Panel2.TabIndex = 117
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Chambre)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(1, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1116, 52)
        Me.Panel1.TabIndex = 132
        '
        'Chambre
        '
        Me.Chambre.AutoSize = True
        Me.Chambre.BackColor = System.Drawing.Color.Transparent
        Me.Chambre.Font = New System.Drawing.Font("MS Reference Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chambre.ForeColor = System.Drawing.Color.LightGray
        Me.Chambre.Location = New System.Drawing.Point(586, 10)
        Me.Chambre.Name = "Chambre"
        Me.Chambre.Size = New System.Drawing.Size(109, 29)
        Me.Chambre.TabIndex = 7
        Me.Chambre.Text = "Facture"
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
        'Form6
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1118, 733)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbNrChambre)
        Me.Controls.Add(Me.cmbIdReserve)
        Me.Controls.Add(Me.txtDateDépart)
        Me.Controls.Add(Me.txtDateFin)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.txtPrixTotal)
        Me.Controls.Add(Me.txtNbDeJour)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Name = "Form6"
        Me.Text = "Form6"
        Me.Panel3.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtDateDépart As TextBox
    Friend WithEvents txtDateFin As TextBox
    Friend WithEvents btnFermer As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnModifier As Button
    Friend WithEvents btnAnnuler As Button
    Friend WithEvents btnNouveau As Button
    Friend WithEvents btnAjouter As Button
    Friend WithEvents btnActualiser As Button
    Friend WithEvents txtPrixTotal As TextBox
    Friend WithEvents txtNbDeJour As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnTerminé As Button
    Friend WithEvents cmbNrChambre As ComboBox
    Friend WithEvents cmbIdReserve As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Chambre As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
End Class
