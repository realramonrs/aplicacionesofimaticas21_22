Module Module1

    Sub Main()
        'Prueba función ejercio 1 isPar(n)
        Dim numero As Integer = 9
        Dim par As Boolean = isPar(numero)
        Console.WriteLine()
        Console.WriteLine("Ejercicio 1: ")
        If par Then
            Console.WriteLine(numero & " es par.")
        Else
            Console.WriteLine(numero & " es impar.")
        End If

        'Probar función ejercicio 2
        Dim valor As Integer = 10
        Dim result As Double = raiz(valor)
        Console.WriteLine()
        Console.WriteLine("Ejercicio 2: ")
        If valor < 0 Then
            Console.WriteLine("No existe raiz número negativo.")
        Else
            Console.WriteLine("Raiz de " & valor & " es= " & result)
        End If

        'Probar ejercicio 3
        Dim minimo As Integer = getMinimoValor(4, 6)
        Console.WriteLine()
        Console.WriteLine("Ejercicio 3: ")
        Console.WriteLine("El menor es " & minimo)
        'Probar ejercicio 4
        Dim numero4 As Integer = 13
        Console.WriteLine()
        Console.WriteLine("Ejercicio 4: ")
        If isPrimo(numero4) Then
            Console.WriteLine(numero4 & " es primo.")
        Else
            Console.WriteLine(numero4 & " no es primo.")
        End If

        'Probar ejercicio 5

        Dim s As String = "hola"
        Dim s2 As String = "adios"
        Console.WriteLine()
        Console.WriteLine("Ejercicio 5: ")
        If sonIguales(s, s2) Then
            Console.WriteLine("Son iguales")
        Else
            Console.WriteLine("No son iguales.")
        End If

        'Probar ejercicio 6
        Dim x As Integer = 4
        Dim y As Integer = 5
        intercambiar(x, y)
        Console.WriteLine()
        Console.WriteLine("Ejercicio 6: ")
        Console.WriteLine("X = " & x)
        Console.WriteLine("y = " & y)

        'Probar ejercicio 8
        Dim numero8 As Integer = 250
        Dim sumaDivisores As Integer
        Console.WriteLine()
        Console.WriteLine("Ejercicio 8: ")
        sumaDivisoresEj8(numero8, sumaDivisores)
        Console.WriteLine("Suma divisores de " & numero8 & " es: " & sumaDivisores)

        'Probar ejercicio 9
        Dim array() As Integer = {5, 0, 9, 8, 7}
        Dim posicionCero As Integer = buscarPrimerCero(array)
        Console.WriteLine()
        Console.WriteLine("Ejercicio 9: ")

        If posicionCero = -1 Then
            Console.WriteLine("No hay ceros")
        Else
            Console.WriteLine("El primer cero está en la posición: " & posicionCero)
        End If

        'Probar ejercicio 10
        Dim matriz() As Integer = {9, 10, 8, 20, 7, 30}
        Console.WriteLine()
        Console.WriteLine("Ejercicio 10: ")
        Dim ceros As Integer = contarCeros(matriz)
        Console.WriteLine("Hay " & ceros & " ceros.")

        'Probar ejercicio 12
        Dim matriz12(9) As Integer
        Console.WriteLine()
        Console.WriteLine("Ejercicio 12: ")
        llenarMatriz(matriz12, 50, 20)

        For Each valor12 As Integer In matriz12
            Console.Write(valor12 & " ")
        Next
        Console.WriteLine()

        'Probar ejercicio 13
        Dim dnis(4) As String
        Console.WriteLine()
        Console.WriteLine("Ejercicio 13:")
        guardarDatosPorTeclado(dnis)

        'Probar ejercicio 14
        Console.WriteLine()
        Console.WriteLine("Ejercicio 14:")
        mostrarMatrizConsola(matriz12)
        mostrarMatrizConsola(dnis)

        'Probar Ejercicio 16
        Dim matriz13(9) As Integer
        llenarMatriz(matriz13, 10, 1)
        Dim suma As Integer
        sumaMatriz(matriz13, suma)

        'Probar Ejercicio 17
        Dim matriz17() As Integer = {-5, 4, 3, 1, -8, -9, -2, -3}
        Dim negativos() As Integer = getNegativosMatriz(matriz17)
        Console.WriteLine()
        Console.WriteLine("Ejercicio 17")
        mostrarMatrizConsola(negativos)


        'Función que devuelve la suma de dos números
        Dim resultado As Integer = devuelveSuma(8, 3)

        Dim matrizPrueba() As Integer = {4, 5, 6, 7}


        Dim matrizResultado() As Integer = doblarMatriz(matrizPrueba)













        Console.ReadLine()
    End Sub

End Module
