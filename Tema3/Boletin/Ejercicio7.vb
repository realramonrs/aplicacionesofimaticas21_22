Module Ejercicio7
    Sub Main()

        Dim n1, n2, suma, raiz As Double

        Console.WriteLine("introduzca un número: ")
        n1 = Convert.ToDouble(Console.ReadLine())

        Console.WriteLine("Introduce otro número: ")
        n2 = Convert.ToDouble(Console.ReadLine())


        suma = n1 + n2

        If suma >= 0 Then
            raiz = Math.Sqrt(suma)
            Console.WriteLine("Raiz de " & suma & " = " & raiz)
        Else
            Console.WriteLine("No se puede calcular la raiz")
        End If

        Console.ReadLine()
    End Sub
End Module
