Module Ejercicio4
    Sub Main()
        'Obtener el número más pequeño de 4 valores
        Dim a, b, c, d, menor As Integer

        a = 1
        b = 8
        c = 5
        d = 2

        'Algoritmo que detecta el número más pequeño
        If a < b Then
            menor = a
        Else
            menor = b
        End If

        If menor > c Then
            menor = c
        End If

        If menor > d Then
            menor = d
        End If

        Console.WriteLine("El menor es " & menor)

        Console.ReadLine()





    End Sub
End Module
