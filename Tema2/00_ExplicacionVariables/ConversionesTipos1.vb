Module ConversionesTipos1
    Sub Main()
        'Conversiones de variables de más capacidad a 
        'tipos de menos precisión o menos capacidad
        Dim resultado As Double = 5 / 13

        'Problema pérdidas de precisión
        Dim resultado2 As Single = resultado
        Dim resultado3 As Integer = resultado
        Console.WriteLine("resultado = " & resultado)
        Console.WriteLine("resultado2 = " & resultado2)
        Console.WriteLine("resultado3 = " & resultado3)


        'Problemas de capacidad
        Dim numero1 As Integer = 35000
        Dim numero2 As Short = numero1

        Console.ReadLine()
    End Sub
End Module
