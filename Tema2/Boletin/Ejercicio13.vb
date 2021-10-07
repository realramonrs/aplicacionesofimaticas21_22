Module Ejercicio13
    Sub Main()
        Dim a, b As Short
        Dim hipotenusa As Double

        Console.WriteLine("Introduzca el valor de a: ")
        a = Convert.ToInt16(Console.ReadLine())

        Console.WriteLine("introduzca el valor de b: ")
        b = Convert.ToInt16(Console.ReadLine())

        'Usamos variable para calcular fórmula interior de la raiz
        Dim radicando As Double = a * a + Math.Pow(b, 2)

        'Calculamos la raiz
        hipotenusa = Math.Sqrt(radicando)
        'Redondeamos el resultado a 2 decimales.
        hipotenusa = Math.Round(hipotenusa, 2)

        Console.WriteLine("La hipotenusa vale: " & hipotenusa)



        Console.ReadLine()


    End Sub
End Module
