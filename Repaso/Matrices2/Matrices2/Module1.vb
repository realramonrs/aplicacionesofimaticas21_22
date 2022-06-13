Imports System.IO
Module Module1

    Sub Main()
        Dim ruta As String = Directory.GetCurrentDirectory() + "\datos.txt"
        Dim ruta2 As String
        Dim escritor As StreamWriter = New StreamWriter(ruta, False)
        escritor.WriteLine("Pedro*12345678T*45")
        escritor.WriteLine("Maria*456789034Q*56")

        escritor.Close()

        Dim lector As StreamReader = New StreamReader(ruta)
        'Volcar registros a una matriz
        Dim matriz(99) As String
        Dim i As Integer = 0
        Dim registro As String = Nothing

        While Not lector.EndOfStream
            registro = lector.ReadLine()
            matriz(i) = registro

            i += 1
        End While

        'Mostramos matriz por pantalla

        For Each cadena As String In matriz
            If cadena Is Nothing Then
                Exit For
            End If
            Dim trozos() As String = cadena.Split("*")

            Console.WriteLine(trozos(1))
        Next

        lector.Close()
        Console.ReadLine()







    End Sub

End Module
