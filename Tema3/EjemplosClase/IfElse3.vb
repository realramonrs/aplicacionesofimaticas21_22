Module IfElse3
    Sub Main()
        'Solicitar al usuario que introduzca una letra: 
        'Puede introducir una a, una b o una c, en cualquier otro caso se informará
        'de que ha cometido un error.
        Dim letra As Char
        Dim continuidad As Boolean = False

        Do
            Console.WriteLine("Introduzca una letra a, b o c")
            letra = Convert.ToChar(Console.ReadLine())

            If letra = "a"c Or letra = "b"c Or letra = "c"c Then
                Console.WriteLine("Opción correcta.")
                continuidad = False
            Else
                Console.WriteLine("Erroooooooooooor!!!!")
                continuidad = True
            End If
        Loop While continuidad = True
        Console.ReadLine()
    End Sub
End Module
