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
        Dim matrizDouble() As Double = {4.5, 7.8, 3.9}
        Dim suma As Integer = sumaArray(matriz)
        Dim suma2 As Double = sumaArray(matrizDouble)
        e("La suma de la matriz es: " & suma)

        'Prueba de la función mostrarArray:
        Dim matriz2() As Integer = {1, 2, 3, 4, 5, 6}
        e("Prueba de la función mostrar Array")
        mostrarArray(matriz2)

        'Probar la función add10
        Dim x As Integer = 10
        x = add10(x)
        suma10(x)
        Console.WriteLine("X = " & x)


        Dim matrizPrimos() As Integer = {5, 7, 8, 13, 10}

        For i As Integer = 0 To matrizPrimos.Length - 1 Step 1

            If isPrimo(matrizPrimos(i)) Then
                Console.WriteLine(matrizPrimos(i) & " es primo")
            End If
        Next

        'Probar la función aplicarDescuento.
        Dim precio As Double = 127
        Dim descuento As Double = 10
        Console.WriteLine("Precio inicial: " & precio)

        aplicarDescuento(precio, descuento)

        Console.WriteLine("Precio con descuento: " & precio)

        'Probar la función findFirst
        Dim matrizPrueba() As Integer = {4, 3, 6, 7}
        Dim posicion As Integer
        Dim valor As Integer = 12
        findFirst(matrizPrueba, valor, posicion)

        Console.WriteLine("Posicion : " & posicion)





        Console.ReadLine()

    End Sub

End Module
