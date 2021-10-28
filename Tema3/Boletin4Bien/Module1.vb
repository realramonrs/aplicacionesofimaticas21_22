Module Module1

    Sub Main()

        Dim ejercicio As Integer

        Do

            Console.WriteLine("Escoja el ejercicio del boletín que desea ejecutar")
            Console.ForegroundColor = ConsoleColor.Red
            Console.WriteLine("Ejercicios disponibles 5 - 16")
            Console.ForegroundColor = ConsoleColor.White
            ejercicio = Convert.ToInt32(Console.ReadLine())

            'Evaluar la variable ejercicio con un select case
            Select Case ejercicio
                Case 5
                    Console.WriteLine("Ejercicio 5.")
                    Console.WriteLine("Indicar la nota final de un alumno.")
                    Dim nota As Double = 0
                    Console.WriteLine("Introduzca la nota: ")
                    nota = Convert.ToDouble(Console.ReadLine())

                    If nota < 0 Or nota > 10 Then
                        Console.WriteLine("Error en la nota.")
                    ElseIf nota < 5 Then
                        Console.WriteLine("Suspenso")
                    ElseIf nota < 6.5 Then
                        Console.WriteLine("Aprobado")
                    ElseIf nota < 8.5 Then
                        Console.WriteLine("Notable")
                    Else
                        Console.WriteLine("Sobresaliente")

                    End If

                    Console.ReadLine()

                Case 6
                    'Ejercicio 6

                Case 7
                    'Ejercicio 7
                    Console.WriteLine("Sólido - Líquido - Gaseoso - Plasma")
                    Dim temp As Double = 0
                    Console.WriteLine("Introduzca temperatura del material:")
                    temp = Convert.ToDouble(Console.ReadLine())

                    If temp < 0 Then
                        Console.WriteLine("Sólido")
                    ElseIf temp < 100 Then
                        Console.WriteLine("Líquido")
                    ElseIf temp < 1000000 Then
                        Console.WriteLine("Gaseoso")
                    Else
                        Console.WriteLine("Plasma")

                    End If

                    Console.ReadLine()



                Case 10
                    Dim precio1, precio2, precio3, precioTotal As Double
                    Dim descuento, precioFinal As Double

                    Do
                        Console.WriteLine("Intro precio primer producto: ")
                        precio1 = Convert.ToDouble(Console.ReadLine())
                    Loop While precio1 < 0



                    Console.WriteLine("Intro precio segundo producto: ")
                    precio2 = Convert.ToDouble(Console.ReadLine())

                    Console.WriteLine("Intro precio tercer producto: ")
                    precio3 = Convert.ToDouble(Console.ReadLine())

                    precioTotal = precio1 + precio2 + precio3

                    If precioTotal < 500 Then
                        descuento = 0
                    ElseIf precioTotal < 1000 Then
                        'descuento del 3%
                        descuento = precioTotal * 0.03
                    ElseIf precioTotal < 2000 Then
                        descuento = precioTotal * 0.05
                    ElseIf precioTotal < 3000 Then
                        descuento = precioTotal * 0.07
                    Else
                        descuento = precioTotal * 0.1
                    End If

                    precioFinal = precioTotal - descuento
                    Console.WriteLine("Precio total: " & precioTotal)
                    Console.WriteLine("Tiene un descuento de : " & descuento & " euros")
                    Console.WriteLine("Precio final: " & precioFinal)

                    Console.ReadLine()

                Case 13
                    Dim letra As Char = "r"c

                    Select Case letra
                        Case "r"c, "R"c

                        Case "v"c, "V"c

                        Case "a"c, "A"c

                        Case Else


                    End Select

                Case 14
                    Console.WriteLine("Ejercicio 14: Indicar cifras de un número")
                    Dim numero As Integer = 0
                    Console.WriteLine("Introduzca un valor: ")
                    numero = Convert.ToInt32(Console.ReadLine())

                    Select Case numero
                        Case 0 To 9
                            Console.WriteLine("Tiene una cifra")
                        Case 10 To 99
                            Console.WriteLine("Tiene dos cifras")
                        Case 100 To 999
                            Console.WriteLine("Tiene tres cifras")
                        Case 1000 To 9999
                            Console.WriteLine("Tiene cuatro cifras")
                        Case 10000 To 99999
                            Console.WriteLine("Tiene cinco cifras")
                        Case 100000 To 999999
                            Console.WriteLine("Tiene seis cifras")
                        Case Else
                            Console.WriteLine("Tiene 7 o más cifras.")

                    End Select

                Case 15
                    'Ecuación de 2º Grado ax2 + bx + c = 0
                    Dim a, b, c As Integer
                    Dim sol1, sol2 As Double

                    Console.WriteLine("Valor de a: ")
                    a = Convert.ToInt32(Console.ReadLine())

                    Console.WriteLine("Valor de b: ")
                    b = Convert.ToInt32(Console.ReadLine())

                    Console.WriteLine("Valor de c: ")
                    c = Convert.ToInt32(Console.ReadLine())


                    If a = 0 Then
                        sol1 = -c / b
                        sol2 = sol1

                    ElseIf b = 0 Then
                        If -c / a > 0 Then
                            sol1 = Math.Sqrt(-c / a)
                            sol2 = (-1) * Math.Sqrt(-c / a)
                        Else
                            Console.WriteLine("No se puede hallar la solución")
                        End If
                    ElseIf c = 0 Then
                        sol1 = 0
                        sol2 = -b / a

                    Else

                        Dim radicando As Double = b * b - 4 * a * c
                        If radicando > 0 Then
                            sol1 = (-b + Math.Sqrt(radicando)) / (2 * a)
                            sol2 = (-b - Math.Sqrt(radicando)) / (2 * a)
                        Else
                            Console.WriteLine("No hay solución")
                        End If
                    End If


            End Select
            Console.Clear()

        Loop While ejercicio >= 5 And ejercicio <= 16

    End Sub

End Module
