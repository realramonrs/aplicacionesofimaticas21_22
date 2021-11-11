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




            End Select
            Console.WriteLine("Quiere seguir jugando?")
            opcion = Convert.ToChar(Console.ReadLine())
        Loop While opcion = "s"c
    End Sub

End Module
