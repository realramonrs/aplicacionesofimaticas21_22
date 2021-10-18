Module Ejercicio10
    Sub Main()
        Dim horasTrabajadas, tasa, sBruto, sNeto As Double
        Dim irpf As Double

        Console.WriteLine("Horas trabajadas en un mes: ")
        horasTrabajadas = Convert.ToDouble(Console.ReadLine())

        Console.WriteLine("Introduce una tasa :")
        tasa = Convert.ToDouble(Console.ReadLine())

        sBruto = horasTrabajadas * tasa

        sNeto = sBruto - (sBruto * irpf) / 100

        Console.WriteLine("Salario bruto : " & sBruto)
        Console.WriteLine("Salario neto : " & sNeto)
        Console.ReadLine()
    End Sub
End Module
