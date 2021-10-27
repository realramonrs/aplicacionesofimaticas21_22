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
                    Console.ReadLine()

            End Select
            Console.Clear()

        Loop While ejercicio >= 5 And ejercicio <= 16

    End Sub

End Module
