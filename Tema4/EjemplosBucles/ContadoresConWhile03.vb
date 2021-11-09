Module ContadoresConWhile03
    Sub Main()
        'Contar cuantos números múltiplos de 7 y 13 hay entre el 100 y y el 1200
        Dim contador As Integer
        Dim i As Integer = 100

        While i <= 1200
            If i Mod 7 = 0 And i Mod 13 = 0 Then
                contador += 1

            End If
            i += 1
        End While

        Console.WriteLine("Hay " & contador & " multiplos de 7 y 13")
        Console.WriteLine()
        'Contar los divisores de un número

        Dim n As Integer = 900
        Dim contador2 As Integer = 0
        Dim j As Integer = 1
        Console.WriteLine("Divisores de : " & n)

        While j <= n
            If n Mod j = 0 Then
                contador2 += 1
                Console.Write(j & " ")

            End If
            j += 1
        End While
        Console.WriteLine("Tiene " & contador2 & " divisores")
















    End Sub
End Module
