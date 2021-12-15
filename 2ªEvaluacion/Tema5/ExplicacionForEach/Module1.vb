Module Module1

    Sub Main()
        Dim a(19) As Integer
        Dim generador As New Random
        Dim suma As Integer
        Dim media, porcentaje As Double

        For i As Integer = 0 To a.Length - 1 Step 1
            a(i) = generador.Next(1, 50)
        Next

        'Mostrar por pantalla con un for each
        For Each valor As Integer In a
            Console.Write(valor & " ")
        Next

        For Each valor As Integer In a
            valor = 0
        Next
        Console.WriteLine()
        'Mostrar por pantalla con un for each
        For Each valor As Integer In a
            Console.Write(valor & " ")
        Next
        'Cálculo de la media de los valores y del porcentaje de ellos que están por encima de la media

        For Each numero As Integer In a
            suma = suma + numero
        Next

        media = Math.Round(suma / a.Length, 2)

        Dim contador As Integer

        For Each v As Integer In a
            If v > media Then
                contador += 1
            End If
        Next

        porcentaje = (contador / a.Length) * 100
        Console.WriteLine(contador & " elementos > media")
        Console.WriteLine("La media es: " & media)
        Console.WriteLine("Hay un " & porcentaje & "% de valores > media")
        Console.ReadLine()
    End Sub

End Module
