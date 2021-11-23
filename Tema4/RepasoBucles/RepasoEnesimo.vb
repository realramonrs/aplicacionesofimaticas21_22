Module RepasoEnesimo
    Sub Main()
        'Programa que indique si un número es perfecto
        Dim numero As Integer
        Console.WriteLine("Dime un numero: ")
        numero = Convert.ToInt32(Console.ReadLine())
        'Mostrar por pantalla el primer divisor distinto de 1 y del propio número

        Dim suma As Integer = 0

        Dim i As Integer = 2
        Dim encontrado As Boolean = False
        While i <= numero / 2
            If numero Mod i = 0 Then
                Console.WriteLine(i & " es el primer divisor de " & numero)
                encontrado = True
                Exit While

            End If
            i += 1
        End While

        If Not encontrado Then
            Console.WriteLine("No tiene divisores, es primo")
        End If

        'Ejercicio 8
        Dim n As Integer = 9


        For j As Integer = n To n + 4 Step 1
            Console.WriteLine(j & " " & Math.Pow(j, 2) & " " & Math.Pow(j, 3))
        Next


        Console.ReadLine()

    End Sub
End Module
