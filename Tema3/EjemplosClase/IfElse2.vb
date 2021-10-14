Module IfElse2
    Sub Main()
        Dim numero As Integer

        Console.WriteLine("Introduzca un número entre 10 y 20")
        numero = Convert.ToInt32(Console.ReadLine())

        If numero >= 10 And numero <= 20 Then
            Console.WriteLine("Correcto, sabes leer")
        Else
            Console.WriteLine("Error , presta más atención")
        End If

        Console.ReadLine()


    End Sub
End Module
