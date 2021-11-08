Module Ejercicio5
    Sub Main()
        Dim letra As Char = "a"c

        Select Case letra
            Case "a"c, "e"c, "i"c, "o"c, "u"c
                Console.WriteLine("Vocal")
            Case "A"c, "E"c, "I"c, "O"c, "U"c
                Console.WriteLine("Vocal")
            Case Else
                Console.WriteLine("No vocal")
        End Select
        Console.WriteLine()


    End Sub
End Module
