Module Ejercicio10
    Sub Main()
        Dim presion, temperatura As Double
        Dim todoEnOrden As Boolean = True
        presion = 3
        temperatura = 700

        If presion > 2 Then
            Console.WriteLine("Abrir válvula de seguridad.")
            todoEnOrden = False
        End If


        If temperatura > 500 Then
            Console.WriteLine("Reducir temperatura.")
            todoEnOrden = False

        End If

        If todoEnOrden Then
            Console.WriteLine("Todo en orden.")
        End If
        Console.ReadLine()
    End Sub
End Module
