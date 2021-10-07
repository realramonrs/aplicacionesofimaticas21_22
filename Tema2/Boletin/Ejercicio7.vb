Module Ejercicio7
    Sub Main()
        'Pasar de Celsius a fahrenheit
        Dim gradosCelsius As Double
        Dim gradosFahrenheit As Double

        Console.WriteLine("Introduce los grados celsius: ")
        gradosCelsius = Convert.ToDouble(Console.ReadLine())

        gradosFahrenheit = (9 / 5) * gradosCelsius + 32

        Console.WriteLine(gradosCelsius & " grados celsius equivalen a : " & gradosFahrenheit & " grados fahrenheit")

        Console.ReadLine()



    End Sub
End Module
