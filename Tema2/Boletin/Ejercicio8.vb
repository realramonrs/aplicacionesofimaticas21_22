Module Ejercicio8
    Sub Main()
        Dim p, v, n, t As Double
        Const R As Double = 0.082

        Console.WriteLine("Introduzca el volumen: ")
        v = Convert.ToDouble(Console.ReadLine())
        Console.WriteLine("Introduzca el número de moles: ")
        n = Convert.ToDouble(Console.ReadLine())
        Console.WriteLine("Introduzca la temperatura: ")
        t = Convert.ToDouble(Console.ReadLine())

        p = n * R * t / v

        Console.WriteLine("La presion es de : " & p)
        Console.ReadLine()
    End Sub
End Module
