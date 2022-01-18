Module Funciones

    Public Sub generador(ByRef m() As Integer, ByVal limiteInf As Integer, ByVal limiteSuperior As Integer)
        Dim aleatorio As New Random

        For i As Integer = 0 To m.Length - 1 Step 1
            m(i) = aleatorio.Next(limiteInf, limiteSuperior)
        Next
    End Sub
End Module
