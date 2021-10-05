Module LecturaTeclado
    Sub Main()
        'Programa que solicita el dni y la edad de una persona
        Dim dni As String
        Dim edad As Integer

        'Solicitar por pantalla el DNI
        Console.WriteLine("Introduzca su DNI: ")
        dni = Console.ReadLine()

        Try
            Console.WriteLine("Introduzca su edad: ")
            edad = Convert.ToInt32(Console.ReadLine())
            Console.WriteLine("Sus datos han sido correctamente guardados!")
            Console.WriteLine("DNI: " & dni)
            Console.WriteLine("Edad " & edad)

        Catch ex As Exception
            Console.WriteLine("No ha sido posible guardar la información")
        End Try



        Console.ReadLine()



    End Sub
End Module
