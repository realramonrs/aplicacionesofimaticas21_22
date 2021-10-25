Module _03Ejemplo3
    Sub Main()
        'Programa que muestra un menú con 4 opciones al usuario
        'a) Calcular la suma de dos numeros
        'b) Calcular la raiz de un número
        'c) Indicar si un número es par o impar
        'd) Comprobar si un número es superior a 100
        'Cualquier otra opción error

        Dim opcion As Char
        Console.WriteLine("Escoja una opción: ")
        Console.WriteLine("a) Calcular la suma de dos numeros")
        Console.WriteLine("b) Calcular la raiz de un número ")
        Console.WriteLine("c) Indicar si un número es par o impar")
        Console.WriteLine("d) Comprobar si un número es superior a 100")

        opcion = Convert.ToChar(Console.ReadLine())

        If opcion = "a" Then
            'Variables locales
            Dim suma, a, b As Integer
            suma = 0
            Console.WriteLine("Intro número 1")
            a = Convert.ToInt32(Console.ReadLine())
            Console.WriteLine("Intro número 1")
            b = Convert.ToInt32(Console.ReadLine())

            suma = a + b
            Console.WriteLine("La suma es : " & suma)

        ElseIf opcion = "b" Then

        ElseIf opcion = "c" Then
            Dim numero As Integer
            Console.WriteLine("Intro número")
            numero = Convert.ToInt32(Console.ReadLine())
            If numero Mod 2 = 0 Then
                Console.WriteLine("Par")
            Else
                Console.WriteLine("Impar.")
            End If

        ElseIf opcion = "d" Then

        Else


        End If
        Console.ReadLine()
    End Sub
End Module
