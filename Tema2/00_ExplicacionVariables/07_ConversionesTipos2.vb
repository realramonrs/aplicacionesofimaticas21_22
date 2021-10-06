Module ConversionesTipos2
    Sub Main()
        'Conversiones de menor a mayor--> Siempre permitidas
        'Conversiones implícitas
        'byte --> Short --> Integer --> Long
        Dim b1 As Byte = 5
        Dim b2 As Short = b1
        Dim b3 As Integer = b2
        Dim b4 As Long = b3
        'Single --> Double
        Dim s1 As Single = 5.6
        Dim s2 As Double = s1

        'Single || Double --> Decimal --> No está permitido
        Dim s3 As Decimal = Convert.ToDecimal(s1)

        'Conversiones explícitas --> Pasamos de variables de más capacidad a variables de menos capacidad
        'Peligro por tanto de pérdida de precision o problemas de capacidad
        'long->Integer--> Short --> Byte
        'Double --> Single
        'Decimal --> Double -- > Single

        Dim n1 As Long = 900000
        Dim n2 As Integer = Convert.ToInt32(n1)
        ' Dim n3 As Short = Convert.ToInt16(n2) --> Genera OverFlowException
        ' Dim n4 As Byte = Convert.ToByte(n3)  --> Genera OverFlowException

        'Otros tipos de conversiones explícitas interesantes:
        'String --> Char
        Dim letra As Char = Convert.ToChar("Z")
        Dim letra2 As Char = "z"c

        'Char -- > Integer
        Dim codigoZ As Integer = Convert.ToInt32(letra)

        Console.WriteLine("La letra : " & letra & " tiene de código: " & codigoZ)

        'Boolean -- > Integer
        Dim condicion As Boolean = True
        Dim c As Integer = Convert.ToInt32(condicion)

        Console.WriteLine("True = " & c)
        Console.ReadLine()



    End Sub
End Module
