Module Module1

    Sub Main()
        Dim opcion As Integer
        Do
            Console.WriteLine("Escoja un ejercicio")
            Console.WriteLine("1. Ej1 --> Contar caracteres.")
            Console.WriteLine("2. Ej 2 --> Validar DNI")
            opcion = Convert.ToInt32(Console.ReadLine())

            Select Case opcion
                Case 1
                    Dim cadena As String = "Esto es un ejemplo"
                    Dim caracter As Char
                    Console.WriteLine("Introduzca una letra: ")
                    caracter = Convert.ToChar(Console.ReadLine())
                    Dim contador As Integer = getCaracter(cadena, caracter)

                    If contador = 0 Then
                        Console.WriteLine("No hay ese caracter")
                    Else
                        Console.WriteLine("Aparece " & contador & " veces.")
                    End If
                    Console.ReadLine()
                Case 2
                    Dim dni As String
                    Dim dniSinLetra As String
                    Dim correcto As Boolean = True
                    Console.WriteLine("Introduzca su dni: ")
                    dni = Console.ReadLine()

                    If dni.Length <> 9 Then
                        correcto = False
                    Else
                        'Comprobar que tiene 8 digitos
                        For i As Integer = 0 To dni.Length - 2 Step 1
                            If Not Char.IsDigit(dni(i)) Then
                                correcto = False
                                Exit For
                            End If
                        Next

                        'Si está todo bien , compruebo que hay una letra
                        If correcto = True Then
                            If Not Char.IsLetter(dni(8)) Then
                                correcto = False
                            End If
                        End If

                    End If

                    'Aquí si correcto = true --> El DNI tiene el formato correcto
                    If correcto = False Then
                        Console.WriteLine("El DNI no tiene el formato correcto, revíselo")
                    Else
                        Dim letras() As Char = {"T"c, "R"c, "W"c, "A"c, "G"c, "M"c, "Y"c, "F"c, "P"c, "D"c, "X"c, "B"c, "N"c, "J"c, "Z"c, "S"c, "Q"c, "V"c, "H"c, "L"c, "C"c, "K"c, "E"c}
                        'Obtener dni sin la letra
                        dniSinLetra = dni.Substring(0, 8)

                        Dim dniNumerico As Integer = Convert.ToInt32(dniSinLetra)
                        Dim resto As Integer = dniNumerico Mod 23

                        'Tengo que comprobar que la letra del dni se corresponde
                        'con letras(resto)
                        If dni(8) = letras(resto) Then
                            Console.WriteLine("DNI correcto")
                        Else
                            Console.WriteLine("La letra del dni no es correcta, debería de ser: " & letras(resto))
                        End If



                    End If
                Case 3
                    Dim cadena As String
                    Console.WriteLine("Introduzca una frase: ")
                    cadena = Console.ReadLine()

                    Dim palabras() As String = cadena.Split(" "c)

                    For Each palabra As String In palabras
                        If palabra.StartsWith("b") Or palabra.StartsWith("B") Then
                            Console.WriteLine(palabra)
                        End If
                    Next

                Case 4
                    Dim cadena As String = "emilio@ciclos.org"

                    'If cadena.IndexOf("@") >= 0 Then
                    '    Console.WriteLine("Contiene @")
                    'Else
                    '    Console.WriteLine("No contiene @")
                    'End If

                    'If cadena.Contains("@") Then
                    'Else

                    'End If

                    If contieneArroba(cadena) Then

                    End If

                Case 5
                    Dim mensaje As String
                    Console.WriteLine("Intro frase y cuenta abas")
                    mensaje = Console.ReadLine()
                    Dim contador As Integer
                    Dim palabras() As String = mensaje.Split(" "c)

                    For Each palabra As String In palabras
                        If palabra.Contains("aba") Then
                            contador += 1
                        End If
                    Next

                    Console.WriteLine("Hay " & contador & " palabras que contienen aba")

                Case 6
                    Dim correo As String
                    Console.WriteLine("Introduzca su email: ")
                    correo = Console.ReadLine
                    Dim posArroba As Integer = correo.IndexOf("@")
                    If posArroba >= 0 Then
                        Dim dominio As String = correo.Substring(posArroba + 1)
                        Console.WriteLine("Su dominio es: " & dominio)
                    Else
                        Console.WriteLine("Error en su emilio.")
                    End If

                    Dim dominio2 As String = correo.Split("@"c)(1)

                Case 7
                    'Formato AA99
                    Dim codigo As String
                    Console.WriteLine("Intro codigo (AA99):")
                    codigo = Console.ReadLine()

                    If Char.IsUpper(codigo(0)) And Char.IsUpper(codigo(1)) And Char.IsDigit(codigo(2)) And Char.IsDigit(codigo(3)) Then
                        Console.WriteLine("Correcto")
                    Else
                        Console.WriteLine("Incorrecto")
                    End If

                Case 8
                    Dim cadena8 As String
                    Console.WriteLine("Intro frase: ")
                    cadena8 = Console.ReadLine()

                    Console.WriteLine("Intro caracter a reemplazar: ")
                    Dim caracter As Char = Convert.ToChar(Console.ReadLine())

                    cadena8 = cadena8.Replace(caracter, "a")


                    Console.WriteLine(cadena8)


                Case 9
                    Dim cadena1 As String = "Pedro Jimenez*14Julio1990?2500"
                    Dim cadena2 As String = "Quique Prieto*90706!06Agosto1998"

                    Dim salario1 As Integer = Convert.ToInt32(cadena1.Substring(cadena1.IndexOf("?") + 1))

                    Dim salario1b As Integer = Convert.ToInt32(cadena1.Split("?"c)(1))

                    Dim posAsterisco As Integer = cadena2.IndexOf("*")
                    Dim posExclamacion As Integer = cadena2.IndexOf("!")
                    Dim caracteres As Integer = posExclamacion - posAsterisco

                    Dim salario2 As Integer = Convert.ToInt32(cadena2.Substring(posAsterisco + 1, caracteres - 1))

                    Console.WriteLine("Salario 2: " & salario2)

                    Dim salario2B As Integer = Convert.ToInt32(cadena2.Split("*"c, "!"c)(1))
                    Console.WriteLine("Salario 2: " & salario2)


            End Select
        Loop While opcion <> 10

    End Sub

End Module
