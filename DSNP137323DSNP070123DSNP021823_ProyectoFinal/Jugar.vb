Public Class Jugar
    Dim palabras As New Palabras()
    Dim juego As New Juego()
    Dim palabra As String = ""
    Dim prefixEspacio As String = "espacio"
    Dim prefixTecla As String = "boton"
    Dim jugando As Boolean = False

    Private Sub estaJugando(r As Boolean)
        jugando = r
        cboNiveles.Enabled = Not (r)
        iniciarjuego.Visible = Not (r)
        reiniciarjuego.Visible = r
        finalizarjuego.Visible = r
    End Sub

    Sub construirEspacios()
        For i = 1 To 19
            Dim x = 10 + ((i - 1) * 46)
            Dim letra As New Label()
            With letra
                .Image = imagenesAdicionales.Images(0)
                .BorderStyle = BorderStyle.Fixed3D
                .Name = prefixEspacio + i.ToString
                .Font = New Font("Courier New", 24, FontStyle.Bold)
                .Location = New System.Drawing.Point(x, 18)
                .TextAlign = ContentAlignment.MiddleCenter
                .Text = "*"
                .Size = New System.Drawing.Size(42, 43)
                .Visible = False
            End With
            Me.Controls.Add(letra)
        Next
    End Sub

    Sub mostrarEspacios(letras As SByte)
        ocultarEspacios()
        limpiarTablero_y_Teclado()
        Dim formLabels(letras - 1) As Label
        For i = 0 To (letras - 1)
            formLabels(i) = CType(Me.Controls(prefixEspacio & i + 1), Label)
        Next
        For Each label As Label In formLabels
            label.Text = "*"
            label.Visible = True
        Next
    End Sub

    Sub ocultarEspacios()
        Dim formLabels(18) As Label
        For i = 0 To 18
            formLabels(i) = CType(Me.Controls(prefixEspacio & i + 1), Label)
        Next
        For Each label As Label In formLabels
            label.Visible = False
        Next
    End Sub

    Private Sub CreaTeclas(caracter As SByte, posicion As SByte)
        Dim x = 12 + (IIf(posicion > 13, (posicion - 13) - 1, posicion - 1)) * 46
        Dim y = (IIf(posicion <= 13, 0, 1) * 50) + 388
        Dim btn As New Button()
        With btn
            .Enabled = False
            .Image = imagenesAdicionales.Images(0)
            .ImageAlign = ContentAlignment.MiddleCenter
            .Name = prefixTecla + Chr(caracter)
            .Text = Chr(caracter)
            .Font = New Font("Courier New", 16, FontStyle.Bold)
            .Location = New System.Drawing.Point(x, y)
            .Size = New System.Drawing.Size(46, 48)
        End With
        AddHandler btn.Click, AddressOf Button_Click   ' Asocias el evento al método Button_Click
        Me.Controls.Add(btn)
    End Sub
    Private Sub construirTeclado()
        Dim posicion As SByte = 0
        For i = 65 To 90
            posicion += 1
            CreaTeclas(i, posicion)
        Next
    End Sub

    Private Sub buscarLetraEnPalabra(letra As String)
        Dim boton As Button = CType(Me.Controls(prefixTecla + letra), Button)
        If Not boton.Enabled Then
            Return
        End If
        boton.Enabled = False
        If palabra.Contains(letra) Then
            For i = 0 To palabra.Length - 1
                If palabra.Chars(i) = letra Then
                    CType(Me.Controls(prefixEspacio & i + 1), Label).Text = letra
                    juego.incPuntosPorLetra()
                    juego.incAciertos()
                End If
            Next
        Else
            juego.incFallos()
            hombre.Image = imagenesFallo.Images(juego.leerFallos() - 1)
        End If
        verAvance()
    End Sub
    Private Sub Button_Click(ByVal sender As Object, ByVal e As EventArgs)
        If Not jugando Then
            Return
        End If
        Dim this As Button = CType(sender, Button)
        buscarLetraEnPalabra(this.Text)
    End Sub

    Private Sub verAvance()
        actualizaTablero()
        If juego.leerFallos() = 6 Then
            MessageBox.Show("Lo siento, perdiste!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            estaJugando(False)
        End If
        If juego.leerAciertos() = palabra.Length Then
            hombre.Image = imagenesGana.Images(juego.leerFallos)
            juego.incPuntosPorPalabra(cboNiveles.SelectedIndex)
            juego.incPuntosAcumulados()
            actualizaTablero()
            MessageBox.Show("Lo lograste, has ganado!", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            estaJugando(False)
        End If
    End Sub

    Private Sub Jugar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        construirTeclado()
        construirEspacios()
        cboNiveles.SelectedIndex = 0
        cboNiveles.SelectedItem = cboNiveles.SelectedIndex
    End Sub

    Private Sub Jugar_KeyUp(sender As Object, e As KeyEventArgs) Handles MyBase.KeyUp
        If Not jugando Then
            Return
        End If
        If e.KeyValue >= 65 And e.KeyValue <= 90 Then
            buscarLetraEnPalabra(Chr(e.KeyValue))
        End If
    End Sub

    Private Sub limpiarTablero_y_Teclado()
        juego.reiniciaJuego()
        actualizaTablero()
        Dim formBotones(25) As Button
        For i = 0 To 25
            formBotones(i) = CType(Me.Controls(prefixTecla & Chr(i + 65)), Button)
        Next
        For Each boton As Button In formBotones
            boton.Enabled = True
        Next
    End Sub

    Private Sub terminarJuego()
        juego.reiniciaJuego()
        hombre.Image = Nothing
        actualizaTablero()
        ocultarEspacios()
        Dim formBotones(25) As Button
        For i = 0 To 25
            formBotones(i) = CType(Me.Controls(prefixTecla & Chr(i + 65)), Button)
        Next
        For Each boton As Button In formBotones
            boton.Enabled = False
        Next
    End Sub

    Private Sub actualizaTablero()
        lblErrores.Text = juego.leerFallos().ToString
        lblAciertos.Text = juego.leerAciertos().ToString
        lblPuntajeJuego.Text = juego.leerPuntosJuego().ToString()
        lblPuntajeAcumulado.Text = juego.leerPuntosAcumulados().ToString
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        Timer1.Enabled = False
        Dim frmIndicaciones As New Indicaciones
        frmIndicaciones.Show()
    End Sub

    Private Sub iniciarjuego_Click(sender As Object, e As EventArgs) Handles iniciarjuego.Click
        juguemos()
    End Sub

    Private Sub finalizarjuego_Click(sender As Object, e As EventArgs) Handles finalizarjuego.Click
        Dim abandonar = MessageBox.Show("¿Desea finalizar este juego?", "Salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If abandonar = 6 Then
            terminarJuego()
            estaJugando(False)
        End If
    End Sub

    Private Sub reiniciarjuego_Click(sender As Object, e As EventArgs) Handles reiniciarjuego.Click
        Dim reiniciar = MessageBox.Show("Se cargará una nueva palabra" + Chr(13) + "¿Desea reiniciar el juego ahora?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If reiniciar = 6 Then
            juguemos()
        End If
    End Sub

    Private Sub juguemos()
        palabra = palabras.darPalabra(cboNiveles.SelectedIndex)
        mostrarEspacios(palabra.Length)
        limpiarTablero_y_Teclado()
        estaJugando(True)
    End Sub
End Class
