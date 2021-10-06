Module EjercicioRepaso2
    Sub Main()
        'Programa que a partir de las horas trabajadas al mes y de la tasa a la que se
        'pagan esas horas. Calcula el salario neto y el salario bruto
        'El salario neto es igual al salario bruto - 15%
        'Declarar variables
        Dim horasTrabajadas, tasa, salarioBruto, salarioNeto As Double

        'valores de entrada
        'Solicitar horas trabajadas
        Console.WriteLine("Introduzca las horas trabajadas:")
        horasTrabajadas = Convert.ToDouble(Console.ReadLine())

        'Solicitar la tasa

        Console.WriteLine("A cuánto se paga la hora?")
        tasa = Convert.ToDouble(Console.ReadLine())


        salarioBruto = horasTrabajadas * tasa
        salarioNeto = salarioBruto - 0.15 * salarioBruto

        'Mostrar resultado por pantalla:
        Console.WriteLine("Salario bruto: " & salarioBruto)
        Console.WriteLine("Salario neto: " & salarioNeto)
        Console.ReadLine()
    End Sub
End Module
