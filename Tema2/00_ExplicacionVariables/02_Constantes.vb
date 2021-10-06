Module Constantes
    Sub Main()
        Console.WriteLine("Ejemplo de uso de constantes:")
        'Las constantes son valores que no queremos que puedan modificarse
        'Deben ser inicializadas cuando se declaran
        'No pueden ser modificadas después
        Const c As Long = 90999886


        Dim masa As Double
        masa = 9

        Dim energia As Double = masa * c * c


        Console.ReadLine()
    End Sub
End Module
