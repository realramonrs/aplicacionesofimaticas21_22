Imports System.IO
Module Module1

    Sub Main()
        'Adivina número entre 1 y 15
        '************ Zona declaración variables ************
        Dim numero As Integer
        Dim generador As Random = New Random()
        Dim numeroUsuario As Integer
        Dim intentos As Integer = 0
        Dim letraContinuar As Char
        Dim jugador As String
        Dim puntos As Integer
        '************ Fin zona declaración variables ********
        Console.WriteLine("Introduzca nombre jugador: ")
        jugador = Console.ReadLine()

        Do

            'inicializar o número de intentos
            intentos = 0
            'Generar numero aleatorio entre 1 y 15
            numero = generador.Next(1, 16)

            Console.WriteLine("número generado: " & numero)

            While intentos < 3
                'Variable que cuente las veces que se equivoca el usuario
                Dim contadorErrores As Integer = 0
                Do
                    If contadorErrores > 0 Then
                        Console.WriteLine("Debe de introducir un´número entre 1 y 15")
                    End If
                    Console.WriteLine("Introduzca un número:")
                    numeroUsuario = Convert.ToInt32(Console.ReadLine())

                    contadorErrores += 1

                Loop While numeroUsuario > 15 Or numero < 1

                If numero = numeroUsuario Then
                    Console.WriteLine("Has acertado")
                    puntos += 10
                    Exit While
                Else
                    intentos += 1
                    If intentos < 3 Then
                        If numero < numeroUsuario Then
                            Console.WriteLine("El número generado es más bajo")
                        Else
                            Console.WriteLine("El número generado es más alto.")
                        End If
                    End If

                End If
            End While

            If intentos = 3 Then
                Console.WriteLine("Has agotado el número de intentos")
                Console.WriteLine("El número era : " & numero)
            End If

            Console.WriteLine("Desea volver a jugar: s/n")
            letraContinuar = Convert.ToChar(Console.ReadLine())

        Loop While letraContinuar = "s"c

        'Guardar datos en un fichero
        Dim rutaFichero As String = Directory.GetCurrentDirectory() + "puntos.txt"
        Dim escritor As StreamWriter = New StreamWriter(rutaFichero)

        escritor.WriteLine(jugador + " " + puntos.ToString)
        escritor.Close()



        Console.ReadLine()






    End Sub

End Module
