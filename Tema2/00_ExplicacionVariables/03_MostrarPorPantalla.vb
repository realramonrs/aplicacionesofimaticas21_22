Module MostrarPorPantalla
    Sub Main()

        'Programa que calcula el area de un triángulo a partir de la base y la altura

        'Declaración de variables
        Dim base, altura, area As Double
        'Inicializamos la base y la altura --> Entrada
        base = 9
        altura = 3

        area = (base * altura) / 2

        'Mostrar por pantalla el resultado
        Console.WriteLine("El área es: " & area & "metros cuadrados")
        Console.ReadLine()

    End Sub
End Module
