Module Module1

    Sub Main()
        'Programa que informa de la provincia a la que pertenece
        'un codigo postal
        '36205,36209---> Pontevedra
        '34902,34903--->Burgos
        '65123---> A Coruña
        'Cualquer otro es extranjero

        Dim codigoPostal As String

        Console.WriteLine("Intro codigo postal: ")
        codigoPostal = Console.ReadLine()

        Select Case codigoPostal
            Case "36205", "36206"
                Console.WriteLine("Pontevedra.")
            Case "34902", "34567"
                Console.WriteLine("Burgos")
            Case "65123"
                Console.WriteLine("A Coruña")
            Case Else
                Console.WriteLine("Extranjero")
        End Select






    End Sub

End Module
