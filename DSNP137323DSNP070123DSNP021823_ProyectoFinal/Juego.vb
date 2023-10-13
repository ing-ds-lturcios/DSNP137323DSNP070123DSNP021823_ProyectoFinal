Public Class Juego
    Private fallos As SByte = 0
    Private puntosJuego As Int16 = 0
    Private aciertos As SByte = 0
    Private puntosAcumulados As Int16 = 0

    Public Sub incFallos()
        fallos += 1
        puntosJuego -= 3
    End Sub

    Public Sub incAciertos()
        aciertos += 1
    End Sub

    Public Sub incPuntosPorLetra()
        puntosJuego += 1
    End Sub

    Public Sub incPuntosPorPalabra(dificultad As SByte)
        Select Case dificultad
            Case 0
                puntosJuego += 25
            Case 1
                puntosJuego += 50
            Case 2
                puntosJuego += 100
        End Select
    End Sub

    Public Sub incPuntosAcumulados()
        puntosAcumulados += puntosJuego
    End Sub

    Public Sub reiniciaJuego()
        fallos = 0
        puntosJuego = 0
        aciertos = 0
    End Sub

    Public Function leerFallos() As SByte
        Return fallos
    End Function

    Public Function leerAciertos() As SByte
        Return aciertos
    End Function

    Public Function leerPuntosJuego() As Int16
        Return puntosJuego
    End Function

    Public Function leerPuntosAcumulados() As Int16
        Return puntosAcumulados
    End Function
End Class
