Module ExitWhile04
    Sub Main()
        'Programa que detecte el PRIMER número múltiplo de 7 entre dos valores
        Dim n, m As Integer
        Console.WriteLine("Intro n:(inferior) ")
        n = Convert.ToInt32(Console.ReadLine())
        Console.WriteLine("Intro m: (Superior)")
        m = Convert.ToInt32(Console.ReadLine())

        Dim i As Integer = n

        While i <= m
            If i Mod 7 = 0 Then
                Console.WriteLine(i & " Múltiplo de 7")
                Exit While
            End If
            i += 1
        End While

        'Adivina un número
        Dim aleatorio As Random = New Random()

        Dim numero As Integer = aleatorio.Next(1, 16)
        'El usuario tiene 3 intentos

        Dim intentos As Integer = 0
        Dim valor As Integer 'Número introducido por el usuario

        While intentos < 3
            Console.WriteLine("Introduce un valor: ")
            valor = Convert.ToInt32(Console.ReadLine())

            If valor = numero Then
                Console.WriteLine("Has acertado!!!!!!!!!")
                Exit While
            Else
                intentos += 1
            End If
        End While

        Console.ReadLine()

    End Sub
End Module
