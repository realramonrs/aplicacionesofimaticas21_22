Module Module1

    Sub Main()
        Dim ejercicio As Integer
        Dim opcion As Char
        Do


            Console.WriteLine("Introduzca un ejercicio: ")
            ejercicio = Convert.ToInt32(Console.ReadLine())

            Select Case ejercicio
                Case 1
                    Console.WriteLine("Apartado a)")
                    For i As Integer = 1 To 11 Step 2
                        Console.Write(i & " ")
                    Next
                    Console.WriteLine()
                    Console.WriteLine("Apartado b)")
                    For i As Integer = 2 To 10 Step 2
                        Console.Write(i & " ")
                    Next
                    Console.WriteLine()

                    Console.WriteLine("Apartado d")
                    For i As Integer = 100 To 0 Step -10
                        Console.Write(i & " ")
                    Next
                    Console.WriteLine()
                Case 5
                    Console.WriteLine("Ejercicio 5")
                    Dim i As Integer = 320
                    While i > 160
                        Console.Write(i & " ")
                        i -= 20
                    End While
                Case 6
                    Console.WriteLine("Ejercicio 6")
                    For i As Integer = 0 To 100 Step 1
                        If i Mod 5 = 0 And i Mod 7 = 0 Then
                            Console.Write(i & " ")
                        End If
                    Next
                Case 7

                    Dim n As Integer = 0
                    Console.WriteLine("Intro número: ")
                    n = Convert.ToInt32(Console.ReadLine)

                    Console.WriteLine("Tabla de multiplicar del : " & n)

                    For i As Integer = 1 To 10 Step 1
                        Console.WriteLine(n & " * " & i & " = " & n * i)
                    Next
                    Console.ReadLine()

                Case 8
                    Dim n As Integer = 0
                    Dim i As Integer = 0
                    Console.WriteLine("Intro n: ")
                    n = Convert.ToInt32(Console.ReadLine())
                    Dim g As Random = New Random()
                    g.Next()
                    Console.WriteLine("Número:   Cuadrado:   Cubo:")
                    i = n
                    While i < n + 5
                        Console.WriteLine(i & "        " & i * i & "    " & i * i * i)
                        i += 1
                    End While
                Case 9
                    Dim n As Double
                    Console.WriteLine("n    Raiz(n)")
                    For n = 16 To 1 Step -2.5
                        If n.ToString.Contains(",") Then
                            Console.WriteLine(n & "  " & Math.Round(Math.Sqrt(n), 2))
                        Else
                            Console.WriteLine(n & "    " & Math.Round(Math.Sqrt(n), 2))
                        End If

                    Next

                Case 10
                    Dim m As Integer
                    Dim suma As Integer = 0

                    Do
                        Console.WriteLine("Intro m: (debe ser positivo)")
                        m = Convert.ToInt32(Console.ReadLine())
                    Loop While m < 0

                    Dim i As Integer = 1

                    While i <= m
                        suma = suma + i
                        i += 1
                    End While

                    'Misma solución pero con un for
                    'For j As Integer = 1 To m Step 1
                    '    suma += i
                    'Next
                    Console.WriteLine("La suma de " & m & " primeros números es: ")
                    Console.WriteLine(suma)

                Case 11
                    Dim n As Integer = 50000000
                    Dim suma As Double = 0
                    For i As Integer = 1 To n Step 1
                        suma = suma + 1 / Math.Pow(i, 3)
                    Next
                    Console.WriteLine("La suma es : " & suma)
                Case 13
                    Dim n As Integer
                    Dim suma As Integer = 0
                    Console.WriteLine("Intro n: ")
                    n = Convert.ToInt32(Console.ReadLine())

                    For i As Integer = 1 To Convert.ToInt32(n / 2) Step 1
                        If n Mod i = 0 Then
                            suma = suma + i
                        End If

                    Next

                    '  Console.WriteLine("nº de operaciones: " & operaciones)
                    If suma = n Then
                        Console.WriteLine("número perfecto")
                    Else
                        Console.WriteLine("número no perfecto")
                    End If

                Case 14
                    Dim n As Integer = 0
                    Console.WriteLine("Intro valor de n")
                    n = Convert.ToInt32(Console.ReadLine())

                    Dim contador As Integer = 0
                    Dim i As Integer = 5
                    While contador < n
                        If i Mod 5 = 0 Then
                            Console.Write(i & " ")
                            contador += 1
                        End If
                        i += 1

                    End While

                    'While contador < n

                    '    Console.Write(i & " ")
                    '    i += 5
                    '    contador += 1
                    'End While
                    Console.WriteLine()
                Case 17
                    Dim numero As Integer = 0
                    Dim contador As Integer = 2
                    Console.WriteLine("Intro n: ")
                    numero = Convert.ToInt32(Console.ReadLine())

                    For i As Integer = 2 To Convert.ToInt32(numero / 2) Step 1
                        If numero Mod i = 0 Then
                            contador += 1
                        End If
                    Next
                    Console.WriteLine(numero & " tiene " & contador & " divisores")

                Case 21
                    'Tabla de Multiplicar de los 10 primeros números

                    Dim n As Integer = 2

                    For j As Integer = 1 To 10 Step 1
                        Console.WriteLine("Tabla de multiplicar del " & j)
                        For i As Integer = 1 To 10 Step 1
                            Console.WriteLine(j & " * " & i & " = " & j * i)
                        Next i
                        Console.WriteLine(" *************  ")
                    Next j

                Case 22
                    Console.WriteLine("Apartado a")
                    Dim limite As Integer
                    Console.WriteLine("Intro número asteriscos: ")
                    limite = Convert.ToInt32(Console.ReadLine())
                    Dim descenso As Integer = limite
                    'For j As Integer = 0 To limite - 1 Step 1
                    '    For i As Integer = 0 To descenso - 1 Step 1
                    '        Console.Write("* ")
                    '    Next
                    '    descenso = descenso - 1
                    '    Console.WriteLine()
                    'Next

                    For j As Integer = limite To 1 Step -1
                        For i As Integer = 1 To j Step 1
                            Console.Write("* ")
                        Next
                        ' descenso = descenso - 1
                        Console.WriteLine()
                    Next

                Case 25
                    Dim aleatorio As Random = New Random()
                    Dim c As Integer = aleatorio.Next(-5, 6)





            End Select
            Console.WriteLine("Quiere seguir jugando?")
            opcion = Convert.ToChar(Console.ReadLine())
        Loop While opcion = "s"c
    End Sub

End Module
