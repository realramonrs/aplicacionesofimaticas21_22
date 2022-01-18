Option Strict On
Module Module1

    Sub Main()
        Dim matriz(15) As Integer
        Dim capacidad As Integer = matriz.Length
        Console.WriteLine("Capacidad: " & capacidad)

        Console.WriteLine("Posición cero: " & matriz(0))
        Console.WriteLine("Valores almacenados en la matriz:")
        Console.WriteLine(matriz)

        For i As Integer = 0 To matriz.Length - 1 Step 1
            Console.Write(matriz(i) & " ")
        Next

        'Inicializar todas las posiciones a -1
        For i As Integer = 0 To matriz.Length - 1 Step 1
            matriz(i) = -1
        Next

        matriz(0) = 3
        matriz(1) = 9
        Console.WriteLine("Introduce el valor de la posición 2")
        matriz(2) = Convert.ToInt32(Console.ReadLine())

        Console.WriteLine("Nuevos valores: ")
        For i As Integer = 0 To matriz.Length - 1 Step 1
            Console.Write(matriz(i) & " ")
        Next

        Dim suma As Integer = 0

        For i As Integer = 0 To matriz.Length - 1 Step 1

            suma = suma + matriz(i)
        Next

        Dim media As Double = suma / matriz.Length

        matriz(5) = 0

        'Obtener la posición que almacena el primer cero en la matriz
        Dim posicion As Integer = -1
        For i As Integer = 0 To matriz.Length - 1 Step 1
            If matriz(i) = 0 Then
                posicion = i
                Exit For
            End If
        Next

        If posicion = -1 Then
            Console.WriteLine("No se encontró ningún cero.")
        Else
            Console.WriteLine("El primer cero está en la posición, " & posicion)
        End If

        'Función indexOf

        posicion = Array.IndexOf(matriz, 0)
        Dim posicion2 As Integer = Array.IndexOf(matriz, 0, posicion + 1)
        ' Obtenemos segundo cero de la matriz

        'Comprobar si dos matrices son iguales
        Dim a1() As Integer = {3, 4, 5}
        Dim a2() As Integer = {3, 4, 5, 8}
        Dim iguales As Boolean = True

        If a1.Length = a2.Length Then
            For i As Integer = 0 To a1.Length - 1 Step 1
                If a1(i) <> a2(i) Then
                    iguales = False
                    Exit For

                End If
            Next

        End If


        If iguales Then
            Console.WriteLine("Son iguales")
        Else
            Console.Write("No son iguales")
        End If

















        Console.ReadLine()
    End Sub

End Module
