Module IfElse4
    Sub Main()
        Dim numero As Integer
        Dim continuidad As Boolean = False

        Do
            Console.WriteLine("Introduzca un número impar , múltiplo de 5 y > 100.")
            numero = Convert.ToInt32(Console.ReadLine())

            If numero Mod 2 <> 0 And numero Mod 5 = 0 And numero > 100 Then
                Console.WriteLine("Correcto")
                continuidad = False
            Else
                Console.WriteLine("No correcto.")
                continuidad = True
            End If

        Loop While continuidad = True







        Console.ReadLine()
    End Sub
End Module
