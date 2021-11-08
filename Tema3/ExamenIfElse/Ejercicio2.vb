Module Ejercicio2
    Sub Main()
        Dim rentaAnual, rentaUnitaria, ayuda As Double
        Dim miembros As Integer

        rentaAnual = 35000
        miembros = 4

        rentaUnitaria = rentaAnual / miembros

        If rentaUnitaria < 5000 Then
            ayuda = rentaAnual * 0.2
        ElseIf rentaUnitaria < 7500 Then
            ayuda = rentaAnual * 0.15
        ElseIf rentaUnitaria < 10000 Then
            ayuda = rentaAnual * 0.1
        Else
            ayuda = 0

        End If

    End Sub
End Module
