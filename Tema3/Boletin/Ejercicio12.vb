Module Ejercicio12
    Sub main()
        Dim precio, descuento As Double

        Console.WriteLine("Intro precio inicial: ")
        precio = Convert.ToDouble(Console.ReadLine())

        If precio <= 100 Then
            descuento = precio * 0.1
        Else
            descuento = precio * 0.15

        End If

        precio = precio - descuento


        Console.WriteLine("Precio final: " & precio)
        Console.WriteLine("Descuento de : " & descuento)

        Console.ReadLine()

    End Sub
End Module
