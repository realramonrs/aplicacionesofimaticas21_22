Module Ejercicio9
    Sub Main()
        Dim n1, n2, resultado As Integer

        Console.WriteLine("Introduzca número 1")
        n1 = Convert.ToInt32(Console.ReadLine())

        Console.WriteLine("Introduzca el número 2")
        n2 = Convert.ToInt32(Console.ReadLine())

        If n1 < n2 Then
            resultado = Convert.ToInt32(Math.Pow(n2, n1))
        Else
            resultado = Convert.ToInt32(Math.Pow(n1, n2))
        End If

        Console.WriteLine("Resultado = " & resultado)

        Console.ReadLine()
    End Sub
End Module
