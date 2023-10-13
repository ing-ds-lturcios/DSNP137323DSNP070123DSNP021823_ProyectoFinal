Public Class Jugar
    Dim palabras As New Palabras()
    Dim juego As New Juego()
    Dim palabra As String = ""
    Dim prefixEspacio As String = "espacio"
    Dim prefixTecla As String = "btn"

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
        Dim formLabels(letras - 1) As Label
        For i = 0 To (letras - 1)
            formLabels(i) = CType(Me.Controls(prefixEspacio & i + 1), Label)
        Next
        For Each label As Label In formLabels
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
        Dim btn As Button = CType(Me.Controls(prefixTecla + letra), Button)
        btn.Enabled = False
        If palabra.Contains(letra) Then
            For i = 1 To palabra.Length - 1
                If palabra.Chars(i) = letra Then
                    CType(Me.Controls(prefixEspacio & i + 1), Label).Text = letra
                    juego.incPuntosPorLetra()
                End If
            Next
        End If
    End Sub
    Private Sub Button_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim this As Button = CType(sender, Button)
        buscarLetraEnPalabra(this.Text)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'fallos += 1
        'Button1.Text = fallos.ToString()
        Ahorcar()
    End Sub

    Private Sub Ahorcar()
        'hombre.Image = imagenesFallo.Images(fallos - 1)
    End Sub

    Private Sub Ganar()
        'hombre.Image = imagenesGana.Images(fallos - 1)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'fallos = 0
        Button1.Text = "Click"
        Ahorcar()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        palabra = palabras.darPalabra(cboNiveles.SelectedIndex)
        mostrarEspacios(palabra.Length)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)
        Ganar()
    End Sub

    Private Sub Jugar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim frmIndicaciones As New Indicaciones
        construirTeclado()
        construirEspacios()
        cboNiveles.SelectedIndex = 0
        cboNiveles.SelectedItem = cboNiveles.SelectedIndex
        frmIndicaciones.Show()
    End Sub

    Private Sub Jugar_KeyUp(sender As Object, e As KeyEventArgs) Handles MyBase.KeyUp
        If e.KeyValue >= 65 And e.KeyValue <= 90 Then
            buscarLetraEnPalabra(Chr(e.KeyValue))
        End If
    End Sub
End Class
