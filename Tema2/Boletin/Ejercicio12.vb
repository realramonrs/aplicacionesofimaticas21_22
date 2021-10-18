Module Ejercicio12
    Sub Main()
        Dim lado As Integer
        Dim perimetro, diagonal, area As Double

        Console.WriteLine("Introduzca el lado: ")
        lado = Convert.ToInt32(Console.ReadLine())

        perimetro = 4 * lado
        diagonal = lado * Math.Sqrt(2)
        area = lado * lado

        Console.WriteLine("Perímetro: " & perimetro)
        Console.WriteLine("Diagonal : " & diagonal)
        Console.WriteLine("Área: " & area)
        Console.ReadLine()

    End Sub
End Module
