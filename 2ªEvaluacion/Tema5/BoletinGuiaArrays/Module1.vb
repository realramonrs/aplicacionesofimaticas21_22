Module Module1

    Sub Main()
        'Ejercicio 1
        Dim a1() As Integer = {1, 2, 3, 4, 5, 6, 7, 8, 9}

        mostrarMatriz(a1)
        'Ejercicio 2:
        Dim a2(19) As Single

        mostrarMatriz(a2)
        'Ejercicio 3:
        Dim a3(9) As Integer
        a3(0) = -3
        a3(2) = -4
        a3(5) = -8
        a3(9) = -2

        'Mostramos el array por pantalla
        'For i As Integer = 0 To a3.Length - 1 Step 1
        '    Console.Write(a3(i) & " ")
        'Next
        mostrarMatriz(a3)

        'Ejercicio 4:
        Dim a4(4) As String
        a4(0) = "Los Pilares de la Tierra"
        a4(1) = "El problema de los 3 cuerpos"
        a4(2) = "La conjura de los necios"
        a4(3) = "Los asesinos del emperador."
        a4(4) = "Gerónimo Stilton"

        mostrarMatriz(a4)
        'Ejercicio 5
        Dim a5(3) As Short

        For i As Integer = 0 To a5.Length - 1 Step 1
            Console.WriteLine("Intro valor para la posicion" & i + 1)
            a5(i) = Convert.ToInt16(Console.ReadLine())
        Next

        'Mostramos la matriz por pantalla
        'For i As Integer = 0 To a5.Length - 1 Step 1
        '    Console.Write(a5(i) & " ")
        'Next
        mostrarMatriz(a5)

        'Ejercicio 6
        Dim a6(49) As Integer
        a6(49) = -1
        mostrarMatriz(a6)

        'Ejercicio 7
        Dim n As Integer
        Console.WriteLine("Intro número de elementos del array")
        n = Convert.ToInt32(Console.ReadLine())

        Dim a7(n - 1) As Integer
        a7(0) = 20
        a7(n - 1) = 4

        'Ejercicio 8
        Dim a8(99) As Integer
        Dim generador As New Random

        For i As Integer = 0 To a8.Length - 1 Step 1
            a8(i) = generador.Next(11)
        Next

        mostrarMatriz(a8)

        'Ejercicio 9
        Dim a9(99) As Integer
        Dim contador As Integer = 1
        For i As Integer = 0 To a9.Length - 1 Step 2
            a9(i) = contador
            contador += 1
        Next
        Console.WriteLine()
        Console.WriteLine("Matriz ejercicio 9")
        mostrarMatriz(a9)


        'Ejercicio 11

        Dim a11(49) As Integer
        Dim generador2 As New Random
        For i As Integer = 0 To a11.Length - 1 Step 1
            a11(i) = generador2.Next(-10, 51)
        Next

        Console.WriteLine()
        Console.WriteLine("Matriz ejercicio 11")

        For i As Integer = 0 To a11.Length - 1 Step 1
            If a11(i) < 0 Then
                Console.WriteLine(a11(i) & " posicion: " & i)
            End If
        Next

        'Ejercicio 12
        Dim a12(21) As Integer

        For i As Integer = 0 To a12.Length - 1 Step 1
            a12(i) = generador2.Next(0, 51)
        Next

        'Sumar todos los valores del array
        Dim suma As Integer = 0
        For i As Integer = 0 To a12.Length - 1 Step 1
            suma = suma + a12(i)
        Next

        'Ejercicio 13
        'Declarar array de 50 valores
        Dim a13(49) As Integer

        llenarMatriz(a13, 1, 200)

        'Sumar posiciones pares
        Dim suma13 As Integer = 0

        For i As Integer = 0 To a13.Length - 1 Step 2
            suma13 = suma13 + a13(i)
        Next
        Console.WriteLine("Ejercicio 13: ")
        Console.WriteLine("La suma de las posiciones pares es: " & suma13)

        'Ejercicio 14
        Dim a14(99) As Integer
        Dim gen As New Random
        Dim suma14 As Integer = 0
        'Llenamos con números aleatorios entre 1 y 50
        For i As Integer = 0 To a14.Length - 1 Step 1
            a14(i) = gen.Next(1, 51)
        Next

        For i As Integer = 0 To a14.Length - 1 Step 1
            suma14 = suma14 + Convert.ToInt32(Math.Pow(a14(i), 2))
        Next

        'Ejercicio 15
        Dim a15() = {1, 3, 4, -5, -6, -9, 2, 6}
        'Sumar los números positivos
        Dim suma15 As Integer

        For i As Integer = 0 To a15.Length - 1 Step 1
            If a15(i) > 0 Then
                suma15 = suma15 + a15(i)
            End If
        Next
        Console.WriteLine("La suma de los cuadrados del array es : " & suma14)
        Console.ReadLine()
        'Ejercicio 16
        Dim a16() As Integer = {4, 5, -2, -8, 9}

        Dim contador16 As Integer

        For i As Integer = 0 To a16.Length - 1 Step 1
            If a16(i) < 0 Then
                contador16 += 1
            End If
        Next

        Console.WriteLine("Hay " & contador16 & " números negativos")
        Console.ReadLine()
        'Ejercicio 17
        'Porcentaje de números impares
        Dim a17(51) As Integer
        llenarMatriz(a17, 1, 100)

        Dim contador17 As Integer
        Dim porcentaje As Double

        For i As Integer = 0 To a17.Length - 1 Step 1
            If a17(i) Mod 2 <> 0 Then
                contador17 += 1
            End If
        Next

        porcentaje = (contador17 / a17.Length) * 100
        Console.WriteLine("Hay un " & Math.Round(porcentaje, 2) & "% de numeros impares")
        Console.ReadLine()


        'Ejercicio 18
        Dim a18(100) As String
        a18(3) = "Pedro"
        a18(5) = "Alberto"
        a18(10) = "Saúl"

        Dim contador18 As Integer

        For i As Integer = 0 To a18.Length - 1 Step 1
            If a18(i) Is Nothing Then
                contador18 += 1
            End If
        Next

        'Ejercicio 19
        Dim a19() As Integer = {200, 50, 900, 60, 400, 51}
        'Algoritmo que muestra por pantalla los valores > 1000
        Console.WriteLine("Valores > 1000 : ")
        For i As Integer = 0 To a19.Length - 1 Step 1
            If a19(i) > 1000 Then
                Console.Write(a19(i) & " ")
            End If
        Next
        'Ejercicio 20 con el array anterior
        'Mostrar solo el primer valor > 1000 junto con la posicion
        Console.WriteLine()
        Dim encontrado As Boolean = False
        Console.WriteLine("Ejercicio 20: Primer valor > 1000 y su posición")
        For i As Integer = 0 To a19.Length - 1 Step 1
            If a19(i) > 1000 Then
                encontrado = True
                Console.Write(a19(i) & " posicion: " & i)
                Exit For
            End If
        Next

        If Not encontrado Then
            Console.WriteLine("No hay valores > 1000")
        End If

        'Ejercicio 28
        Dim a28() As Integer = {1, 2, 3, 4, 5, 6}
        Dim a28Copia(a28.Length - 1) As Integer

        For i = 0 To a28.Length - 1 Step 1
            a28Copia(i) = a28(i)
        Next

        'Ejercicio 29
        'Ejemplo función Array.copy
        Dim a29() As Integer = {4, 6, 8, 10, 12}
        Dim a29Copia(a29.Length - 1) As Integer

        Array.Copy(a29, a29Copia, a29.Length)

        'Ejercicio homenaje al subcampeón matemático y conductor de patinete eléctrico profesional
        Dim numeros() As Integer = {4, 7, 6, 9, 2, 0, 1}
        Dim pares(numeros.Length - 1) As Integer
        Dim indicePares As Integer = 0
        For i As Integer = 0 To numeros.Length - 1 Step 1
            If numeros(i) Mod 2 = 0 Then
                pares(indicePares) = numeros(i)
                indicePares += 1
            End If
        Next
        ReDim Preserve pares(indicePares - 1)
        Console.WriteLine("EJERCICIO PARES ARRAY HOMENAJE CAMPEON OLIMPICO")
        mostrarMatriz(pares)
        Console.ReadLine()
    End Sub

End Module
