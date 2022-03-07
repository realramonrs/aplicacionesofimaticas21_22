Module EjemploSplit
    Sub Main()
        Dim frase As String = "Z0car1as te v0y a quitar el zov1l"
        Dim contador As Integer
        'Cuantas palabras empiezan por z
        Dim palabras() As String = frase.Split(" "c)

        For Each palabra As String In palabras
            If palabra.StartsWith("z") Or palabra.StartsWith("Z") Then
                contador += 1
            End If
        Next

        'Cuantas palabras contienen al menos un dígito
        Dim contadorPalabras As Integer
        For Each palabra As String In palabras
            For i As Integer = 0 To palabra.Length - 1 Step 1
                If Char.IsDigit(palabra(i)) Then
                    contadorPalabras += 1
                    Exit For
                End If
            Next
        Next
        Console.WriteLine("Hay " & contadorPalabras & " palabras con dígitos.")
        Console.ReadLine()


    End Sub
End Module
