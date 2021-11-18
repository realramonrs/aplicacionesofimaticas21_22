Module Bucles_Anidados06
    Sub Main()

        Dim n As Integer
        Console.WriteLine("introduzca n")
        n = Convert.ToInt32(Console.ReadLine())
        'Mostrar 7 filas con números del 1 hasta n
        For j As Integer = 1 To 7 Step 1
            For i As Integer = 1 To n Step 1
                Console.Write(i & " ")
            Next
            Console.WriteLine()
        Next

        Console.WriteLine("Mismo ejercicio con un while")

        Dim z As Integer = 1
        Dim w As Integer = 1

        While w <= 7
            'resetear variable control z
            z = 1
            While z <= n
            Console.Write(z & " ")
            z += 1
            End While
            w += 1
            Console.WriteLine()
        End While



        Console.ReadLine()
    End Sub
End Module
