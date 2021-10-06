Module Module1

    Sub Main()
        Dim edad As Byte
        Dim nombre As String
        Console.WriteLine("Bienvenidos al Ciclo de Informática")
        Console.WriteLine("Edad: " & edad)

        Console.WriteLine("Introduzca su nombre: ")
        nombre = Console.ReadLine()

        Console.WriteLine("Introduzca la edad: ")
        edad = Convert.ToByte(Console.ReadLine())

        Console.ReadLine()
    End Sub

End Module
