Module Module1

    Sub Main()
        ' Programa que solicita código de país y muestra el pais al que pertenece
        'código pais: 34 --> España
        'Codigo país: 36 --> Alemania
        'Codigo país: 38 --> Francia
        'Cualqiuer otro código error

        Dim codigo As Byte

        Console.WriteLine("Introduzca el código del país: 34,36 o 38")
        codigo = Convert.ToByte(Console.ReadLine())

        If codigo = 34 Then
            Console.WriteLine("España")
        ElseIf codigo = 36 Then
            Console.WriteLine("Alemania.")
        ElseIf codigo = 38 Then
            Console.WriteLine("Francia")
        Else
            Console.WriteLine("Error , código introducido no existe")

        End If
        Console.ReadLine()


    End Sub

End Module
