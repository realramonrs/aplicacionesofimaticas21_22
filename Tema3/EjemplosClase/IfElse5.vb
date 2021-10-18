Module IfElse5
    Sub Main()
        Dim opcion As Integer

        Console.WriteLine("Escoja una opción: ")
        opcion = Convert.ToInt32(Console.ReadLine())

        If opcion = 1 Then
            Dim a, b As Integer
            Dim x As Double
            Console.WriteLine("Introduzca número a:")
            a = Convert.ToInt32(Console.ReadLine())
            Console.WriteLine("Introduzca número b:")
            b = Convert.ToInt32(Console.ReadLine())

            x = Math.Sqrt(Math.Pow(a, 5)) + (Math.Pow(a, 3) + b * b) - Math.Sqrt(Math.Pow(b, 3))

            Console.WriteLine("X = " & Math.Round(x, 2))
        Else

            Dim numero, numDecimales As Integer
            Dim resultado As Double
            Console.WriteLine("Introduce valor: ")
            numero = Convert.ToInt32(Console.ReadLine())

            Console.WriteLine("Introduce cantidad decimales: ")
            numDecimales = Convert.ToInt32(Console.ReadLine())

            resultado = Math.Sqrt(numero)

            Console.WriteLine("Raiz de " & numero & " = " & Math.Round(resultado, numDecimales))
            Console.WriteLine("Raíz original = " & resultado)


        End If

        Console.ReadLine()
    End Sub
End Module
