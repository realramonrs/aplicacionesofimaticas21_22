Module Ejercicio4

    Sub Main()
        'A partir del radio calcular, longitud, area y volumen de una circunf.

        Dim radio, area, longitud, volumen As Double
        ' Const pi As Double = 3.141516
        'Solicitar el radio al usuario
        Console.WriteLine("Introduzca el radio: ")
        radio = Convert.ToDouble(Console.ReadLine())

        longitud = 2 * Math.PI * radio
        area = Math.PI * radio * radio
        volumen = (4 / 3) * Math.PI * Math.Pow(radio, 3)

        Console.WriteLine("Longitud: " & Math.Round(longitud, 2))
        Console.WriteLine("Area: " & area)
        Console.WriteLine("Volumen: " & volumen)

        Console.ReadLine()





    End Sub

End Module
