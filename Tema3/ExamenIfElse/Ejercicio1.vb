Module Ejercicio1

    Sub Main()

        'Programa que indica si un número es múltiplo de 7 o 13

        Dim n As Integer = 87
        Console.WriteLine("Intro n")
        n = Convert.ToInt32(Console.ReadLine())
        If n Mod 7 = 0 Or n Mod 13 = 0 Then
            Console.WriteLine("Múltiplo de 7 o 13")
        Else
            Console.WriteLine("No es múltiplo")
        End If

        If n Mod 7 = 0 Then
            Console.WriteLine("Múltiplo de 7")
        ElseIf n Mod 13 = 0 Then
            Console.WriteLine("Múltiplo de 13")
        Else
            Console.WriteLine("No es múltiplo")
        End If

    End Sub

End Module
