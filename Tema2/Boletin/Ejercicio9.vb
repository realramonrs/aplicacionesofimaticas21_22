Module Ejercicio9
    Sub Main()
        Dim x, y As Integer
        Dim aux As Integer

        x = 9
        y = 1

        aux = x
        x = y
        y = aux

        Console.WriteLine("x: " & x)
        Console.WriteLine("Y: " & y)
        Console.ReadLine()

    End Sub
End Module
