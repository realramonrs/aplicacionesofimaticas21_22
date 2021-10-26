Module _05Ejemplo5SelectCase

    Sub Main()
        'Programa que si el usuario escoje un número entre 1 y 10 , hace sonar
        'el console.beep
        'Si introduce un número 11 o 13 o 15 manda un mensaje con el himno del celta
        'En cualquier otro caso indica que hay un error

        Dim opcion As Integer
        Console.WriteLine("Introduzca una opción")
        opcion = Convert.ToInt32(Console.ReadLine())

        Select Case opcion
            Case 1 To 10
                Console.Beep(25000, 2000)
            Case 11, 13, 15
                Console.WriteLine("Hala Celta a demostrar, con orgullo e tradición")
            Case Else
                Console.WriteLine("Hay un error.")
        End Select

        If opcion >= 1 And opcion <= 10 Then
        ElseIf opcion = 11 Or opcion = 13 Or opcion = 15 Then
        Else

        End If
        Console.ReadLine()
    End Sub
End Module
