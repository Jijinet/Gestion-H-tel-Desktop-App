<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.btnChambre = New System.Windows.Forms.Button()
        Me.btnReserve = New System.Windows.Forms.Button()
        Me.btnClient = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnFermer = New System.Windows.Forms.Button()
        Me.btnActualiser = New System.Windows.Forms.Button()
        Me.btnFacture = New System.Windows.Forms.Button()
        Me.dgMenu = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_logout = New System.Windows.Forms.Button()
        Me.Panel2.SuspendLayout()
        CType(Me.dgMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnChambre
        '
        Me.btnChambre.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnChambre.Font = New System.Drawing.Font("MS Reference Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChambre.ForeColor = System.Drawing.Color.White
        Me.btnChambre.Location = New System.Drawing.Point(-10, 75)
        Me.btnChambre.Name = "btnChambre"
        Me.btnChambre.Size = New System.Drawing.Size(275, 87)
        Me.btnChambre.TabIndex = 40
        Me.btnChambre.Text = "Gestion Chambre"
        Me.btnChambre.UseVisualStyleBackColor = False
        '
        'btnReserve
        '
        Me.btnReserve.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnReserve.Font = New System.Drawing.Font("MS Reference Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReserve.ForeColor = System.Drawing.Color.White
        Me.btnReserve.Location = New System.Drawing.Point(557, 75)
        Me.btnReserve.Name = "btnReserve"
        Me.btnReserve.Size = New System.Drawing.Size(282, 87)
        Me.btnReserve.TabIndex = 41
        Me.btnReserve.Text = "Gestion Reservation"
        Me.btnReserve.UseVisualStyleBackColor = False
        '
        'btnClient
        '
        Me.btnClient.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnClient.Font = New System.Drawing.Font("MS Reference Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClient.ForeColor = System.Drawing.Color.White
        Me.btnClient.Location = New System.Drawing.Point(272, 75)
        Me.btnClient.Name = "btnClient"
        Me.btnClient.Size = New System.Drawing.Size(279, 87)
        Me.btnClient.TabIndex = 42
        Me.btnClient.Text = "Gestion Client"
        Me.btnClient.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel2.Controls.Add(Me.btnFermer)
        Me.Panel2.Controls.Add(Me.btnActualiser)
        Me.Panel2.Location = New System.Drawing.Point(1, 656)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1116, 78)
        Me.Panel2.TabIndex = 46
        '
        'btnFermer
        '
        Me.btnFermer.Font = New System.Drawing.Font("MS Reference Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFermer.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnFermer.Location = New System.Drawing.Point(927, 13)
        Me.btnFermer.Name = "btnFermer"
        Me.btnFermer.Size = New System.Drawing.Size(153, 52)
        Me.btnFermer.TabIndex = 1
        Me.btnFermer.Text = "Fermer"
        Me.btnFermer.UseVisualStyleBackColor = True
        '
        'btnActualiser
        '
        Me.btnActualiser.Font = New System.Drawing.Font("MS Reference Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnActualiser.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnActualiser.Location = New System.Drawing.Point(30, 13)
        Me.btnActualiser.Name = "btnActualiser"
        Me.btnActualiser.Size = New System.Drawing.Size(166, 52)
        Me.btnActualiser.TabIndex = 0
        Me.btnActualiser.Text = "Actualiser"
        Me.btnActualiser.UseVisualStyleBackColor = True
        '
        'btnFacture
        '
        Me.btnFacture.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnFacture.Font = New System.Drawing.Font("MS Reference Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFacture.ForeColor = System.Drawing.Color.White
        Me.btnFacture.Location = New System.Drawing.Point(845, 75)
        Me.btnFacture.Name = "btnFacture"
        Me.btnFacture.Size = New System.Drawing.Size(280, 87)
        Me.btnFacture.TabIndex = 47
        Me.btnFacture.Text = "Gestion Facture"
        Me.btnFacture.UseVisualStyleBackColor = False
        '
        'dgMenu
        '
        Me.dgMenu.BackgroundColor = System.Drawing.Color.LightGray
        Me.dgMenu.ColumnHeadersHeight = 29
        Me.dgMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgMenu.Location = New System.Drawing.Point(-10, 187)
        Me.dgMenu.Name = "dgMenu"
        Me.dgMenu.RowHeadersWidth = 51
        Me.dgMenu.RowTemplate.Height = 24
        Me.dgMenu.Size = New System.Drawing.Size(1127, 463)
        Me.dgMenu.TabIndex = 52
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.btn_logout)
        Me.Panel1.Location = New System.Drawing.Point(-10, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1127, 52)
        Me.Panel1.TabIndex = 54
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("MS Reference Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.LightGray
        Me.Label1.Location = New System.Drawing.Point(603, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 29)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Menu"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(-12, -17)
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
        Me.Label2.Location = New System.Drawing.Point(115, 2)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(228, 41)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Gestion Hôtel"
        '
        'btn_logout
        '
        Me.btn_logout.BackColor = System.Drawing.Color.PowderBlue
        Me.btn_logout.Font = New System.Drawing.Font("MS Reference Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_logout.ForeColor = System.Drawing.Color.Black
        Me.btn_logout.Location = New System.Drawing.Point(1001, 10)
        Me.btn_logout.Name = "btn_logout"
        Me.btn_logout.Size = New System.Drawing.Size(125, 41)
        Me.btn_logout.TabIndex = 48
        Me.btn_logout.Text = "Logout"
        Me.btn_logout.UseVisualStyleBackColor = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1116, 733)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.dgMenu)
        Me.Controls.Add(Me.btnFacture)
        Me.Controls.Add(Me.btnReserve)
        Me.Controls.Add(Me.btnClient)
        Me.Controls.Add(Me.btnChambre)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.Panel2.ResumeLayout(False)
        CType(Me.dgMenu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnChambre As Button
    Friend WithEvents btnReserve As Button
    Friend WithEvents btnClient As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnFermer As Button
    Friend WithEvents btnActualiser As Button
    Friend WithEvents btnFacture As Button
    Friend WithEvents dgMenu As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btn_logout As Button
End Class
