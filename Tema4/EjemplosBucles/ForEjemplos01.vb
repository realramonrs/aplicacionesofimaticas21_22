Module ForEjemplos01
    Sub Main()
        'Mostrar números entre 1 y 100
        For i As Integer = 1 To 100 Step 10
            Console.Write(i & " ")
        Next

        'Mostrar números múltiplos de 13 entre n y m
        Dim n As Integer = 1200
        Dim m As Integer = 5660

        For i As Integer = n To m Step 1
            If i Mod 13 = 0 Then
                Console.Write(i & " ")
            End If
        Next
        Console.ReadLine()


        'Bucle For
        Dim j As Integer = 0
        For j = 10 To 90 Step 2
            For i As Integer = 9 To 90 Step 3
            Next i

        Next j
    End Sub
End Module
