Module Ejercicio4
    Sub Main()
        Dim temperatura As Double = 45

        If temperatura > 30 Then
            Console.WriteLine("Natacíón")
        ElseIf temperatura > 20 Then

            Console.WriteLine("Tenis")
        ElseIf temperatura > 10 Then
            Console.WriteLine("Golf")
        ElseIf temperatura > 5 Then
            Console.WriteLine("Esquí")
        Else
            Console.WriteLine("Parchís")

        End If
    End Sub
End Module
