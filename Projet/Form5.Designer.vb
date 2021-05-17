<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form5
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form5))
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnLaFacture = New System.Windows.Forms.Button()
        Me.btnModifier = New System.Windows.Forms.Button()
        Me.btnAnnuler = New System.Windows.Forms.Button()
        Me.btnNouveau = New System.Windows.Forms.Button()
        Me.btnAjouter = New System.Windows.Forms.Button()
        Me.btnActualiser = New System.Windows.Forms.Button()
        Me.cmbCIN = New System.Windows.Forms.ComboBox()
        Me.cmbNrChambre = New System.Windows.Forms.ComboBox()
        Me.txtIdReserve = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnFermer = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.Label1)
        Me.Panel4.Controls.Add(Me.PictureBox2)
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Location = New System.Drawing.Point(-2, 1)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1123, 52)
        Me.Panel4.TabIndex = 120
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("MS Reference Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.LightGray
        Me.Label1.Location = New System.Drawing.Point(586, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(165, 29)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Reservation"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox2.Location = New System.Drawing.Point(-10, -17)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(110, 109)
        Me.PictureBox2.TabIndex = 5
        Me.PictureBox2.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Montserrat SemiBold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.Label3.Location = New System.Drawing.Point(118, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(228, 41)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Gestion Hôtel"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LemonChiffon
        Me.Panel1.Controls.Add(Me.btnLaFacture)
        Me.Panel1.Controls.Add(Me.btnModifier)
        Me.Panel1.Controls.Add(Me.btnAnnuler)
        Me.Panel1.Controls.Add(Me.btnNouveau)
        Me.Panel1.Controls.Add(Me.btnAjouter)
        Me.Panel1.Controls.Add(Me.btnActualiser)
        Me.Panel1.Location = New System.Drawing.Point(924, 53)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(197, 567)
        Me.Panel1.TabIndex = 121
        '
        'btnLaFacture
        '
        Me.btnLaFacture.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnLaFacture.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLaFacture.ForeColor = System.Drawing.Color.White
        Me.btnLaFacture.Location = New System.Drawing.Point(21, 376)
        Me.btnLaFacture.Name = "btnLaFacture"
        Me.btnLaFacture.Size = New System.Drawing.Size(166, 54)
        Me.btnLaFacture.TabIndex = 122
        Me.btnLaFacture.Text = " La Facture"
        Me.btnLaFacture.UseVisualStyleBackColor = False
        '
        'btnModifier
        '
        Me.btnModifier.BackColor = System.Drawing.Color.PowderBlue
        Me.btnModifier.Font = New System.Drawing.Font("Microsoft YaHei UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModifier.Location = New System.Drawing.Point(19, 292)
        Me.btnModifier.Name = "btnModifier"
        Me.btnModifier.Size = New System.Drawing.Size(166, 54)
        Me.btnModifier.TabIndex = 104
        Me.btnModifier.Text = "Modifier"
        Me.btnModifier.UseVisualStyleBackColor = False
        '
        'btnAnnuler
        '
        Me.btnAnnuler.BackColor = System.Drawing.Color.PowderBlue
        Me.btnAnnuler.Font = New System.Drawing.Font("Microsoft YaHei UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnnuler.Location = New System.Drawing.Point(21, 458)
        Me.btnAnnuler.Name = "btnAnnuler"
        Me.btnAnnuler.Size = New System.Drawing.Size(166, 54)
        Me.btnAnnuler.TabIndex = 5
        Me.btnAnnuler.Text = "Annuler"
        Me.btnAnnuler.UseVisualStyleBackColor = False
        '
        'btnNouveau
        '
        Me.btnNouveau.BackColor = System.Drawing.Color.PowderBlue
        Me.btnNouveau.Font = New System.Drawing.Font("Microsoft YaHei UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNouveau.Location = New System.Drawing.Point(19, 121)
        Me.btnNouveau.Name = "btnNouveau"
        Me.btnNouveau.Size = New System.Drawing.Size(166, 54)
        Me.btnNouveau.TabIndex = 4
        Me.btnNouveau.Text = "Nouveau"
        Me.btnNouveau.UseVisualStyleBackColor = False
        '
        'btnAjouter
        '
        Me.btnAjouter.BackColor = System.Drawing.Color.PowderBlue
        Me.btnAjouter.Font = New System.Drawing.Font("Microsoft YaHei UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAjouter.Location = New System.Drawing.Point(21, 207)
        Me.btnAjouter.Name = "btnAjouter"
        Me.btnAjouter.Size = New System.Drawing.Size(166, 54)
        Me.btnAjouter.TabIndex = 3
        Me.btnAjouter.Text = "Ajouter"
        Me.btnAjouter.UseVisualStyleBackColor = False
        '
        'btnActualiser
        '
        Me.btnActualiser.BackColor = System.Drawing.Color.PowderBlue
        Me.btnActualiser.Font = New System.Drawing.Font("Microsoft YaHei UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnActualiser.Location = New System.Drawing.Point(19, 36)
        Me.btnActualiser.Name = "btnActualiser"
        Me.btnActualiser.Size = New System.Drawing.Size(166, 54)
        Me.btnActualiser.TabIndex = 0
        Me.btnActualiser.Text = "Actualiser"
        Me.btnActualiser.UseVisualStyleBackColor = False
        '
        'cmbCIN
        '
        Me.cmbCIN.BackColor = System.Drawing.Color.LightGray
        Me.cmbCIN.Font = New System.Drawing.Font("Microsoft YaHei UI", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCIN.FormattingEnabled = True
        Me.cmbCIN.Location = New System.Drawing.Point(68, 280)
        Me.cmbCIN.Name = "cmbCIN"
        Me.cmbCIN.Size = New System.Drawing.Size(295, 43)
        Me.cmbCIN.TabIndex = 127
        '
        'cmbNrChambre
        '
        Me.cmbNrChambre.BackColor = System.Drawing.Color.LightGray
        Me.cmbNrChambre.Font = New System.Drawing.Font("Microsoft YaHei UI", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbNrChambre.FormattingEnabled = True
        Me.cmbNrChambre.Location = New System.Drawing.Point(68, 402)
        Me.cmbNrChambre.Name = "cmbNrChambre"
        Me.cmbNrChambre.Size = New System.Drawing.Size(295, 43)
        Me.cmbNrChambre.TabIndex = 126
        '
        'txtIdReserve
        '
        Me.txtIdReserve.BackColor = System.Drawing.Color.LightGray
        Me.txtIdReserve.Font = New System.Drawing.Font("Microsoft YaHei UI", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdReserve.Location = New System.Drawing.Point(68, 174)
        Me.txtIdReserve.Name = "txtIdReserve"
        Me.txtIdReserve.ReadOnly = True
        Me.txtIdReserve.Size = New System.Drawing.Size(295, 42)
        Me.txtIdReserve.TabIndex = 125
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(62, 368)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(171, 31)
        Me.Label2.TabIndex = 124
        Me.Label2.Text = "Nr ° Chambre"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft YaHei UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(62, 246)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 31)
        Me.Label4.TabIndex = 123
        Me.Label4.Text = "CIN"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft YaHei UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(62, 140)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(137, 31)
        Me.Label5.TabIndex = 122
        Me.Label5.Text = "ID Reserve"
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
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel3.Controls.Add(Me.btnFermer)
        Me.Panel3.Location = New System.Drawing.Point(-2, 613)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1123, 85)
        Me.Panel3.TabIndex = 128
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1121, 706)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.cmbCIN)
        Me.Controls.Add(Me.cmbNrChambre)
        Me.Controls.Add(Me.txtIdReserve)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel4)
        Me.Name = "Form5"
        Me.Text = "Form5"
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnModifier As Button
    Friend WithEvents btnAnnuler As Button
    Friend WithEvents btnNouveau As Button
    Friend WithEvents btnAjouter As Button
    Friend WithEvents btnActualiser As Button
    Friend WithEvents btnLaFacture As Button
    Friend WithEvents cmbCIN As ComboBox
    Friend WithEvents cmbNrChambre As ComboBox
    Friend WithEvents txtIdReserve As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnFermer As Button
    Friend WithEvents Panel3 As Panel
End Class
