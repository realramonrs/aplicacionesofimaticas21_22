Module Ejercicio3
    Sub main()
        Dim opcion As Char
        Console.WriteLine("Intro opción A, B, C")
        opcion = Convert.ToChar(Console.ReadLine())


        opcion = "a"c

        Select Case opcion
            Case "A"c, "a"c
                Console.WriteLine("Partido Rojo")
            Case "B"c, "b"c
                Console.WriteLine("Partido Verde")
            Case "C"c, "c"c
                Console.WriteLine("Partido azul")
            Case Else
                Console.WriteLine("Error")
        End Select
        Console.ReadLine()
    End Sub
End Module
