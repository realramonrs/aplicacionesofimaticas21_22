Module _04Ejemplo4SelectCase
    Sub Main()
        'Select Case es equivalente a un if elseIf , se suele utilizar
        'para evaluar valores concretos de una determinada variable

        Dim opcion As Char
        Console.WriteLine("Escoja una opción: ")
        Console.WriteLine("a) Calcular la suma de dos numeros")
        Console.WriteLine("b) Calcular la raiz de un número ")
        Console.WriteLine("c) Indicar si un número es par o impar")
        Console.WriteLine("d) Comprobar si un número es superior a 100")

        opcion = Convert.ToChar(Console.ReadLine())

        'Evaluar variable opcion
        Select Case opcion
            Case "a"c, "A"c

                Console.WriteLine("Ha escogido la opción a")
            Case "b"c, "B"c
                Console.WriteLine("Ha escogido la opción b")
            Case "c"c, "C"c
                Console.WriteLine("Ha escogido la opción c")
            Case "d"c, "D"c
                Console.WriteLine("Ha escogido la opción d")
            Case Else
                Console.WriteLine("Opción errónea.")


        End Select

        Console.ReadLine()


    End Sub
End Module
