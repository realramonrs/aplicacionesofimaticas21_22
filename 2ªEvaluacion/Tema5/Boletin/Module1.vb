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




            End Select

        Loop While opcion >= 1 And opcion <= 10
    End Sub

End Module
