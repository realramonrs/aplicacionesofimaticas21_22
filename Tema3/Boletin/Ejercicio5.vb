Module Ejercicio5

    Sub Main()
        'Leer numero y clasificar como par o impar
        Dim numero As Integer

        Console.WriteLine("Introduzca un número: ")
        numero = Convert.ToInt32(Console.ReadLine())

        If numero Mod 2 = 0 Then
            Console.WriteLine("Par")
        Else
            Console.WriteLine("Impar")
        End If
        Console.ReadLine()


    End Sub

End Module
