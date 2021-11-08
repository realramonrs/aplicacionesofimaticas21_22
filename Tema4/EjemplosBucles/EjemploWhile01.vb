Module EjemploWhile01

    Sub Main()
        'Bucles: Ejecutar un algorimo n veces
        'Mostrar por pantalla los 100 primeros números
        Dim i As Integer = 0

        While i <= 100
            Console.Write(i & " ")
            i += 1
        End While


        'Mostrar números entre 100 y 1000 de 50 en 50
        Console.WriteLine()
        Console.WriteLine("Números entre 100 y 1000 de 50 en 50")
        Console.WriteLine()
        i = 100

        While i <= 1000
            Console.Write(i & " ")
            i += 50
        End While


        'Mostrar los números de 10 a 200 de 15 en 15, poniendo en rojo los pares


        Console.WriteLine()
        Console.WriteLine("Mostrar los números de 10 a 200 de 15 en 15, poniendo en rojo los pares")
        Console.WriteLine()
        i = 10
        While i <= 200

            If i Mod 2 = 0 Then

                Console.ForegroundColor = ConsoleColor.Red
                Console.Write(i & " ")
            Else
                Console.ResetColor()
                '  Console.ForegroundColor = ConsoleColor.White
                Console.Write(i & " ")
            End If

            i += 15
        End While





        Console.ReadLine()
    End Sub

End Module
