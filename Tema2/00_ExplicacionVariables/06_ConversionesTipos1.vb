Option Strict On
Module ConversionesTipos1
    Sub Main()
        'Conversiones de variables de más capacidad a 
        'tipos de menos precisión o menos capacidad
        Dim resultado As Double = 5 / 13

        'Problema pérdidas de precisión --> Conversiones Explícitas
        Dim resultado2 As Single = Convert.ToSingle(resultado)
        Dim resultado3 As Integer = Convert.ToInt32(resultado)
        Console.WriteLine("resultado = " & resultado)
        Console.WriteLine("resultado2 = " & resultado2)
        Console.WriteLine("resultado3 = " & resultado3)


        'Problemas de capacidad
        Dim numero1 As Integer = 35000
        Dim numero2 As Short = Convert.ToInt16(numero1) 'Esto genera una overflowException

        'Conversiones de variables de menor en capacidad a variables
        'de mayor capacidad , no hay problema

        'byte--> short--> Integer --> Long
        'Single --> Double

        Dim x As Byte = 120
        Dim y As Short = x

        Dim v1 As Single = 4.5
        Dim v2 As Double = v1



        Console.ReadLine()
    End Sub
End Module
