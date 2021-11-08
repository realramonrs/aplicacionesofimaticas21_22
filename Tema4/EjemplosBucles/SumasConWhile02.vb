Module SumasConWhile02
    Sub Main()
        Dim n As Integer = 34
        Dim suma As Integer = 0
        Dim i As Integer = 1
        'Calcular la suma de todos los números hasta n

        While i <= n
            'suma de todos los valores de i
            'suma = suma + i
            suma += i
            i += 1
        End While
        Console.WriteLine("La suma es : " & suma)

        'Programa que suma todos los números impares entre 1200 y 5756

        i = 1200
        suma = 0
        While i <= 5756
            If i Mod 2 <> 0 Then
                suma += i
            End If
            i += 1
        End While

        Console.ReadLine()
    End Sub
End Module
