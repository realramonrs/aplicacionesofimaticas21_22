Module IfElse4
    Sub Main()
        Dim numero As Integer
        Dim continuidad As Boolean = False
        Dim contador As Integer = 0

        Do
            Console.WriteLine("Introduzca un número impar , múltiplo de 5 y > 100.")
            numero = Convert.ToInt32(Console.ReadLine())

            If numero Mod 2 <> 0 And numero Mod 5 = 0 And numero > 100 Then
                Console.WriteLine("Correcto")
                continuidad = False
            Else
                Console.WriteLine("No correcto.")
                continuidad = True
                contador += 1
            End If

        Loop While continuidad = True And contador < 3

        If contador = 3 Then
            Console.WriteLine("Has agotado el número de intentos. Chao")
        End If







        Console.ReadLine()
    End Sub
End Module
