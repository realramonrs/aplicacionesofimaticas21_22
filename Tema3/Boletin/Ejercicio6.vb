Module Ejercicio6
    Sub Main()
        Dim n1, n2, n3 As Integer
        Dim media As Double

        Console.WriteLine("Intro la primera nota: ")
        n1 = Convert.ToInt32(Console.ReadLine())

        Console.WriteLine("Intro la segunda nota: ")
        n2 = Convert.ToInt32(Console.ReadLine())

        Console.WriteLine("Intro la tercera nota: ")
        n3 = Convert.ToInt32(Console.ReadLine())

        media = (n1 + n2 + n3) / 3

        If media >= 5 Then
            Console.WriteLine("Aprobado.")
        Else
            Console.WriteLine("Suspenso.")
        End If

        Console.ReadLine()


    End Sub
End Module
