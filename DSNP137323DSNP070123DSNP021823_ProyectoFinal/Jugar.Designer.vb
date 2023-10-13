<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Jugar
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Jugar))
        Me.imagenesFallo = New System.Windows.Forms.ImageList(Me.components)
        Me.imagenesGana = New System.Windows.Forms.ImageList(Me.components)
        Me.hombre = New System.Windows.Forms.PictureBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.lblErrores = New System.Windows.Forms.Label()
        Me.lblAciertos = New System.Windows.Forms.Label()
        Me.lblPuntajeJuego = New System.Windows.Forms.Label()
        Me.imagenesAdicionales = New System.Windows.Forms.ImageList(Me.components)
        Me.cboNiveles = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblPuntajeAcumulado = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.iniciarjuego = New System.Windows.Forms.PictureBox()
        Me.iniciarjuegodis = New System.Windows.Forms.PictureBox()
        Me.reiniciarjuego = New System.Windows.Forms.PictureBox()
        Me.reiniciarjuegodis = New System.Windows.Forms.PictureBox()
        Me.finalizarjuego = New System.Windows.Forms.PictureBox()
        CType(Me.hombre, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.iniciarjuego, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.iniciarjuegodis, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.reiniciarjuego, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.reiniciarjuegodis, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.finalizarjuego, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'imagenesFallo
        '
        Me.imagenesFallo.ImageStream = CType(resources.GetObject("imagenesFallo.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imagenesFallo.TransparentColor = System.Drawing.Color.Transparent
        Me.imagenesFallo.Images.SetKeyName(0, "Fallo1.png")
        Me.imagenesFallo.Images.SetKeyName(1, "Fallo2.png")
        Me.imagenesFallo.Images.SetKeyName(2, "Fallo3.png")
        Me.imagenesFallo.Images.SetKeyName(3, "Fallo4.png")
        Me.imagenesFallo.Images.SetKeyName(4, "Fallo5.png")
        Me.imagenesFallo.Images.SetKeyName(5, "Fallo6.png")
        '
        'imagenesGana
        '
        Me.imagenesGana.ImageStream = CType(resources.GetObject("imagenesGana.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imagenesGana.TransparentColor = System.Drawing.Color.Transparent
        Me.imagenesGana.Images.SetKeyName(0, "GanaFallo0.png")
        Me.imagenesGana.Images.SetKeyName(1, "GanaFallo1.png")
        Me.imagenesGana.Images.SetKeyName(2, "GanaFallo2.png")
        Me.imagenesGana.Images.SetKeyName(3, "GanaFallo3.png")
        Me.imagenesGana.Images.SetKeyName(4, "GanaFallo4.png")
        Me.imagenesGana.Images.SetKeyName(5, "GanaFallo5.png")
        '
        'hombre
        '
        Me.hombre.BackColor = System.Drawing.Color.Transparent
        Me.hombre.Location = New System.Drawing.Point(684, 205)
        Me.hombre.Name = "hombre"
        Me.hombre.Size = New System.Drawing.Size(95, 160)
        Me.hombre.TabIndex = 36
        Me.hombre.TabStop = False
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.Location = New System.Drawing.Point(67, 136)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(94, 13)
        Me.Label20.TabIndex = 38
        Me.Label20.Text = "Errores cometidos:"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.Color.Transparent
        Me.Label21.Location = New System.Drawing.Point(67, 174)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(100, 13)
        Me.Label21.TabIndex = 39
        Me.Label21.Text = "Aciertos este juego:"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.BackColor = System.Drawing.Color.Transparent
        Me.Label22.Location = New System.Drawing.Point(67, 212)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(98, 13)
        Me.Label22.TabIndex = 40
        Me.Label22.Text = "Puntaje este juego:"
        '
        'lblErrores
        '
        Me.lblErrores.BackColor = System.Drawing.Color.Transparent
        Me.lblErrores.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblErrores.Font = New System.Drawing.Font("Courier New", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblErrores.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblErrores.Location = New System.Drawing.Point(182, 130)
        Me.lblErrores.Name = "lblErrores"
        Me.lblErrores.Size = New System.Drawing.Size(100, 25)
        Me.lblErrores.TabIndex = 41
        Me.lblErrores.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblAciertos
        '
        Me.lblAciertos.BackColor = System.Drawing.Color.Transparent
        Me.lblAciertos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAciertos.Font = New System.Drawing.Font("Courier New", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAciertos.Location = New System.Drawing.Point(182, 168)
        Me.lblAciertos.Name = "lblAciertos"
        Me.lblAciertos.Size = New System.Drawing.Size(100, 25)
        Me.lblAciertos.TabIndex = 42
        Me.lblAciertos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPuntajeJuego
        '
        Me.lblPuntajeJuego.BackColor = System.Drawing.Color.Transparent
        Me.lblPuntajeJuego.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPuntajeJuego.Font = New System.Drawing.Font("Courier New", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPuntajeJuego.Location = New System.Drawing.Point(182, 206)
        Me.lblPuntajeJuego.Name = "lblPuntajeJuego"
        Me.lblPuntajeJuego.Size = New System.Drawing.Size(100, 25)
        Me.lblPuntajeJuego.TabIndex = 43
        Me.lblPuntajeJuego.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'imagenesAdicionales
        '
        Me.imagenesAdicionales.ImageStream = CType(resources.GetObject("imagenesAdicionales.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imagenesAdicionales.TransparentColor = System.Drawing.Color.Transparent
        Me.imagenesAdicionales.Images.SetKeyName(0, "Espacio.jpg")
        '
        'cboNiveles
        '
        Me.cboNiveles.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cboNiveles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboNiveles.DropDownWidth = 120
        Me.cboNiveles.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cboNiveles.Font = New System.Drawing.Font("Courier New", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboNiveles.FormattingEnabled = True
        Me.cboNiveles.ItemHeight = 22
        Me.cboNiveles.Items.AddRange(New Object() {"Fácil", "Medio", "Difícil"})
        Me.cboNiveles.Location = New System.Drawing.Point(182, 88)
        Me.cboNiveles.MaxDropDownItems = 4
        Me.cboNiveles.Name = "cboNiveles"
        Me.cboNiveles.Size = New System.Drawing.Size(101, 30)
        Me.cboNiveles.TabIndex = 44
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(67, 96)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 13)
        Me.Label1.TabIndex = 45
        Me.Label1.Text = "Nivel seleccionado:"
        '
        'lblPuntajeAcumulado
        '
        Me.lblPuntajeAcumulado.BackColor = System.Drawing.Color.Transparent
        Me.lblPuntajeAcumulado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPuntajeAcumulado.Font = New System.Drawing.Font("Courier New", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPuntajeAcumulado.Location = New System.Drawing.Point(182, 244)
        Me.lblPuntajeAcumulado.Name = "lblPuntajeAcumulado"
        Me.lblPuntajeAcumulado.Size = New System.Drawing.Size(100, 25)
        Me.lblPuntajeAcumulado.TabIndex = 47
        Me.lblPuntajeAcumulado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(67, 250)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(101, 13)
        Me.Label3.TabIndex = 46
        Me.Label3.Text = "Puntaje acumulado:"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1500
        '
        'iniciarjuego
        '
        Me.iniciarjuego.BackColor = System.Drawing.Color.Transparent
        Me.iniciarjuego.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.iniciarjuego.Cursor = System.Windows.Forms.Cursors.Hand
        Me.iniciarjuego.Image = Global.DSNP137323DSNP070123DSNP021823_ProyectoFinal.My.Resources.Resources.IniciarJuego
        Me.iniciarjuego.Location = New System.Drawing.Point(240, 309)
        Me.iniciarjuego.Name = "iniciarjuego"
        Me.iniciarjuego.Size = New System.Drawing.Size(168, 56)
        Me.iniciarjuego.TabIndex = 50
        Me.iniciarjuego.TabStop = False
        '
        'iniciarjuegodis
        '
        Me.iniciarjuegodis.BackColor = System.Drawing.Color.Transparent
        Me.iniciarjuegodis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.iniciarjuegodis.Cursor = System.Windows.Forms.Cursors.Hand
        Me.iniciarjuegodis.Enabled = False
        Me.iniciarjuegodis.Image = Global.DSNP137323DSNP070123DSNP021823_ProyectoFinal.My.Resources.Resources.IniciarJuegoDis
        Me.iniciarjuegodis.Location = New System.Drawing.Point(240, 309)
        Me.iniciarjuegodis.Name = "iniciarjuegodis"
        Me.iniciarjuegodis.Size = New System.Drawing.Size(168, 56)
        Me.iniciarjuegodis.TabIndex = 51
        Me.iniciarjuegodis.TabStop = False
        '
        'reiniciarjuego
        '
        Me.reiniciarjuego.BackColor = System.Drawing.Color.Transparent
        Me.reiniciarjuego.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.reiniciarjuego.Cursor = System.Windows.Forms.Cursors.Hand
        Me.reiniciarjuego.Image = Global.DSNP137323DSNP070123DSNP021823_ProyectoFinal.My.Resources.Resources.ReiniciarJuego
        Me.reiniciarjuego.Location = New System.Drawing.Point(66, 309)
        Me.reiniciarjuego.Name = "reiniciarjuego"
        Me.reiniciarjuego.Size = New System.Drawing.Size(168, 56)
        Me.reiniciarjuego.TabIndex = 52
        Me.reiniciarjuego.TabStop = False
        Me.reiniciarjuego.Visible = False
        '
        'reiniciarjuegodis
        '
        Me.reiniciarjuegodis.BackColor = System.Drawing.Color.Transparent
        Me.reiniciarjuegodis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.reiniciarjuegodis.Cursor = System.Windows.Forms.Cursors.Hand
        Me.reiniciarjuegodis.Enabled = False
        Me.reiniciarjuegodis.Image = Global.DSNP137323DSNP070123DSNP021823_ProyectoFinal.My.Resources.Resources.ReiniciarJuegoDis
        Me.reiniciarjuegodis.Location = New System.Drawing.Point(66, 309)
        Me.reiniciarjuegodis.Name = "reiniciarjuegodis"
        Me.reiniciarjuegodis.Size = New System.Drawing.Size(168, 56)
        Me.reiniciarjuegodis.TabIndex = 53
        Me.reiniciarjuegodis.TabStop = False
        '
        'finalizarjuego
        '
        Me.finalizarjuego.BackColor = System.Drawing.Color.Transparent
        Me.finalizarjuego.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.finalizarjuego.Cursor = System.Windows.Forms.Cursors.Hand
        Me.finalizarjuego.Image = Global.DSNP137323DSNP070123DSNP021823_ProyectoFinal.My.Resources.Resources.FinalizarJuego
        Me.finalizarjuego.Location = New System.Drawing.Point(414, 309)
        Me.finalizarjuego.Name = "finalizarjuego"
        Me.finalizarjuego.Size = New System.Drawing.Size(168, 56)
        Me.finalizarjuego.TabIndex = 54
        Me.finalizarjuego.TabStop = False
        '
        'Jugar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.DSNP137323DSNP070123DSNP021823_ProyectoFinal.My.Resources.Resources.Background
        Me.ClientSize = New System.Drawing.Size(900, 501)
        Me.Controls.Add(Me.finalizarjuego)
        Me.Controls.Add(Me.reiniciarjuego)
        Me.Controls.Add(Me.reiniciarjuegodis)
        Me.Controls.Add(Me.iniciarjuego)
        Me.Controls.Add(Me.lblPuntajeAcumulado)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cboNiveles)
        Me.Controls.Add(Me.lblPuntajeJuego)
        Me.Controls.Add(Me.lblAciertos)
        Me.Controls.Add(Me.lblErrores)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.hombre)
        Me.Controls.Add(Me.iniciarjuegodis)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Jugar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "z"
        CType(Me.hombre, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.iniciarjuego, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.iniciarjuegodis, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.reiniciarjuego, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.reiniciarjuegodis, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.finalizarjuego, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents imagenesFallo As ImageList
    Friend WithEvents imagenesGana As ImageList
    Friend WithEvents hombre As PictureBox
    Friend WithEvents Label20 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents lblErrores As Label
    Friend WithEvents lblAciertos As Label
    Friend WithEvents lblPuntajeJuego As Label
    Friend WithEvents imagenesAdicionales As ImageList
    Friend WithEvents cboNiveles As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblPuntajeAcumulado As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents iniciarjuego As PictureBox
    Friend WithEvents iniciarjuegodis As PictureBox
    Friend WithEvents reiniciarjuego As PictureBox
    Friend WithEvents reiniciarjuegodis As PictureBox
    Friend WithEvents finalizarjuego As PictureBox
End Class
