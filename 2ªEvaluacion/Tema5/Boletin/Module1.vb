Module Module1

    Sub Main()

        Dim opcion As Integer

        Do
            Console.WriteLine("Escoge un ejercicio: 1 - 10")
            opcion = Convert.ToInt32(Console.ReadLine())

            Select Case opcion
                Case 1
                    Dim n As Integer = 20
                    Dim array(n - 1) As Integer
                    Dim generador As New Random

                    For i As Integer = 0 To array.Length - 1 Step 1
                        array(i) = generador.Next(0, 11)
                    Next

                    Dim suma As Integer
                    Dim media As Double
                    Dim contador As Integer
                    Dim porcentaje As Double

                    For Each valor As Integer In array
                        suma = suma + valor
                    Next

                    media = suma / array.Length

                    For Each valor As Integer In array
                        If valor > media Then
                            contador += 1
                        End If
                    Next

                    porcentaje = Math.Round((contador / array.Length) * 100, 2)

                    Console.WriteLine("Media: " & media)
                    Console.WriteLine("Valores > media : " & contador)
                    Console.WriteLine("Porcentaje: " & porcentaje & "%")

                    If media < 5 Then
                        Console.WriteLine("Suspenso")
                    ElseIf media < 7 Then
                        Console.WriteLine("Aprobado.")
                    ElseIf media < 9 Then
                        Console.WriteLine("Notable")
                    ElseIf media <= 10 Then
                        Console.WriteLine("Sobresaliente.")
                    Else
                        Console.WriteLine("Error.")
                    End If

                Case 2
                    Dim matriz(9) As Integer
                    generador(matriz, 0, 20)

                    Dim suma As Integer = 0
                    Dim media As Double = 0


                    For Each valor As Integer In matriz
                        suma += valor
                    Next


                    media = suma / matriz.Length
                    Dim desviacionTotal As Double = 0
                    Dim desviacionMedia As Double
                    Console.WriteLine("La media es: " & media)
                    For i As Integer = 0 To matriz.Length - 1 Step 1
                        Dim desviacion As Double = Math.Round(Math.Abs(matriz(i) - media), 2)
                        Console.WriteLine(i & " desv. " & desviacion)
                        desviacionTotal += desviacion
                    Next
                    desviacionMedia = desviacionTotal / matriz.Length
                    Console.WriteLine("Desviación media : " & desviacionMedia)
                    Console.ReadLine()
                Case 3
                    Dim matriz(10) As Integer
                    Dim copia(matriz.Length - 1) As Integer

                    generador(matriz, 1, 7)

                    For i As Integer = 0 To copia.Length - 1 Step 1
                        copia(i) = matriz(i) + 10
                    Next

                    For Each valor As Integer In matriz
                        Console.Write(valor & " ")
                    Next

                    Console.WriteLine()
                    Console.WriteLine("Matriz 2: ")
                    For Each valor As Integer In copia
                        Console.Write(valor & " ")
                    Next
                    Console.WriteLine()

                Case 4
                    Dim matriz(3) As Integer
                    generador(matriz, 1, 5)

                    Dim sumaCuadrados As Integer
                    Dim modulo As Double
                    For Each valor As Integer In matriz
                        sumaCuadrados += valor * valor
                    Next
                    modulo = Math.Sqrt(sumaCuadrados)

                    Console.WriteLine("El módulo es : " & modulo)

                Case 5
                    Dim matriz(10) As Integer
                    generador(matriz, 3, 10)
                    Dim f As Integer
                    For Each valor As Integer In matriz
                        Console.Write(valor & " ")
                    Next

                    Console.WriteLine()

                    For i As Integer = 0 To matriz.Length - 1 Step 1
                        If matriz(i) < 0 Then
                            Console.WriteLine("Primer negativo : " & matriz(i) & " posic: " & i)
                            f = 1
                            Exit For
                        End If
                    Next

                    If f = 0 Then
                        Console.WriteLine("No tiene números negativos.")
                    End If

                Case 6
                    Dim matriz6(10) As Integer
                    generador(matriz6, -10, 11)

                    Console.WriteLine("Matriz generada: ")
                    mostrar(matriz6)

                    Console.WriteLine("Introduce número: ")
                    Dim numeroBuscado As Integer = Convert.ToInt32(Console.ReadLine())

                    Dim encontrado As Boolean = False

                    For i As Integer = 0 To matriz6.Length - 1 Step 1
                        If matriz6(i) = numeroBuscado Then
                            encontrado = True
                            Console.WriteLine("Posición: " & i)


                        End If
                    Next

                    If Not encontrado Then
                        Console.WriteLine("No está en la matriz")
                    End If
                Case 7
                    Dim encontrado As Boolean
                    Dim nombres(99) As String
                    Dim posVacia As Integer
                    Dim opcion7 As Char
                    Do

                        Console.WriteLine("Que opción quiere ejecutar: ")
                        opcion7 = Convert.ToChar(Console.ReadLine())

                        If opcion7 = "a" Then
                            Console.WriteLine("Introduce un nombre: ")
                            Dim nombre As String = Console.ReadLine
                            'nombres(posVacia) = nombre
                            'posVacia += 1

                            For i As Integer = 0 To nombres.Length - 1 Step 1
                                If nombres(i) Is Nothing Then
                                    nombres(i) = nombre
                                    Exit For
                                End If
                            Next

                        ElseIf opcion7 = "b" Then

                            'Mostrar nombres guardados
                            For Each nombre As String In nombres
                                If nombre IsNot Nothing Then
                                    Console.WriteLine(nombre)
                                End If
                            Next
                        ElseIf opcion7 = "c" Then
                            Dim contador As Integer = 0

                            For Each valor As String In nombres
                                If valor IsNot Nothing Then
                                    contador += 1
                                End If
                            Next

                            Console.WriteLine("Hay " & contador & " valores.")
                        ElseIf opcion7 = "e" Then
                            Dim nombreBuscado As String
                            Console.WriteLine("Intro nombre: ")
                            nombreBuscado = Console.ReadLine()
                            Dim encontradoNombre As Boolean = False
                            For Each valor As String In nombres
                                If valor = nombreBuscado Then
                                    Console.WriteLine("Encontrado.")
                                    encontradoNombre = True

                                    Exit For
                                End If
                            Next
                            If encontradoNombre = False Then
                                Console.WriteLine("No encontrado.")
                            End If

                        ElseIf opcion7 = "f" Then
                            Dim nombreAEliminar As String
                            Console.WriteLine("Intro nombre: ")
                            nombreAEliminar = Console.ReadLine()
                            Dim encontrador7 As Boolean = False
                            For i As Integer = 0 To nombres.Length - 1 Step 1
                                If nombreAEliminar = nombres(i) Then
                                    nombres(i) = Nothing
                                    Console.WriteLine("Nombre eliminado correctamente")
                                    encontrador7 = True
                                    Exit For

                                End If
                            Next
                            If Not encontrador7 Then
                                Console.WriteLine("No se pudo eliminar.")
                            End If

                        End If


                    Loop While opcion7 <> "g"

                Case 9
                    Dim matriz9(11) As Integer
                    generador(matriz9, -5, -1)

                    mostrar(matriz9)
                    Dim maximo As Integer = matriz9(0)
                    Dim posMaximo As Integer = -1
                    For i As Integer = 1 To matriz9.Length - 1 Step 1
                        If maximo < matriz9(i) Then
                            maximo = matriz9(i)
                            posMaximo = i
                        End If
                    Next

                    Console.WriteLine("El maximo es : " & maximo)
                    Console.WriteLine("Posición: " & posMaximo)

                Case 10
                    Dim matriz10(10) As Integer
                    Dim copia(matriz10.Length - 1) As Integer

                    generador(matriz10, 1, 10)

                    Array.Copy(matriz10, copia, matriz10.Length)

                    Array.Sort(copia)

                    Console.WriteLine("Original: ")
                    For Each valor As Integer In matriz10
                        Console.Write(valor & " ")
                    Next
                    Console.WriteLine()
                    Console.WriteLine("Copia: ")

                    For Each valor As Integer In copia
                        Console.Write(valor)
                    Next


                    Console.WriteLine()

                    Dim valorBuscado As Integer = 5
                    Dim posicion As Integer = Array.IndexOf(copia, valorBuscado)

                    If posicion < 0 Then
                        Console.WriteLine("No se ha encontrado")
                    Else
                        Console.WriteLine("Está en la posición: " & posicion)
                    End If







            End Select

        Loop While opcion >= 1 And opcion <= 10
    End Sub

End Module
