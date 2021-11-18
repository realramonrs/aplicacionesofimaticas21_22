Module BuclesAnidados05
    Sub Main()
        Dim filas, columnas As Integer

        Dim intentos As Integer = 0

        While intentos < 5
            Console.WriteLine("Cuantas filas desea crear: ")
        filas = Convert.ToInt32(Console.ReadLine())
        Console.WriteLine("Cuantas columnas desea crear")
        columnas = Convert.ToInt32(Console.ReadLine())
            For i As Integer = 1 To filas Step 1
                For contador As Integer = 1 To columnas Step 1
                    Console.Write(" O ")
                Next contador
                Console.WriteLine()
            Next i

            intentos += 1
        End While


        Console.ReadLine()
    End Sub
End Module
