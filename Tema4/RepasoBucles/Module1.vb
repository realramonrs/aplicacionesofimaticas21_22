Module Module1

    Sub Main()
        'Repaso bucle
        'Contar cuantos números son múltiplos de 3 entre 3 y 450
        Dim i, contador As Integer

        'i --> variable de control
        i = 3 'Inicialización
        contador = 0
        While i <= 450
            If i Mod 3 = 0 Then
                contador = contador + 1
            End If
            i = i + 1

        End While

        'Mostrar tabla de multiplicar de un número
        Dim n As Integer = 20

        Console.WriteLine("Tabla de multiplicar del " & n)

        i = 1

        While i <= 10
            Console.WriteLine(n & " * " & i & " = " & n * i)
            i += 1
        End While

        Console.WriteLine()
        'Programa que muestra los números del 1 al 50 de 2 en 2

        For i = 1 To 50 Step 2
            Console.Write(i & " ")
        Next

        'Suma los valores que hay por debajo 100
        'suma = 1 +2 + 3 + 4 + 5 + 6 + 7 + 8 + 9+ 10 + ... + 100
        Dim suma As Integer = 0
        For i = 1 To 100 Step 1
            suma = suma + i
        Next
        Console.WriteLine(suma)


        Console.ReadLine()


    End Sub

End Module
