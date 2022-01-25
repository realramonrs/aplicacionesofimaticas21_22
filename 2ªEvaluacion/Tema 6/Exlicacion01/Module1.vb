Module Module1

    Sub Main()

        'Probar la función e:
        e("Bienvenidos al maravilloso mundo de las funciones!!!!!")

        'Probar la función raizSuma2
        Dim x1 As Integer = 10
        Dim x2 As Integer = -1
        'Calcular la raiz de la suma
        Dim raiz As Double = raizSuma2(x1, x2)
        e("X1 = " & x1)
        Dim raiz2 As Double = raizSuma2(9, 4)

        e("Raiz 1: " & raiz)
        e("Raiz 2: " & raiz2)


        'Prueba de la función sumaArray

        Dim matriz() As Integer = {1, 2, 3, 4, 5, 6}

        Dim suma As Integer = sumaArray(matriz)
        e("La suma de la matriz es: " & suma)


        'Prueba de la función mostrarArray:
        Dim matriz2() As Integer = {1, 2, 3, 4, 5, 6}
        e("Prueba de la función mostrar Array")
        mostrarArray(matriz2)



        Console.ReadLine()

    End Sub

End Module
