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



        Console.ReadLine()
    End Sub

End Module
