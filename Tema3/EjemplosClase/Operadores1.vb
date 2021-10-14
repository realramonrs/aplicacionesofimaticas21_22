Module Operadores1

    Sub Main()
        ' Operador Mod --> Devuelve el resto de la division entera
        Dim resto As Integer = 126 Mod 2

        'Operadores de asignación y suma , resta , multiplicación y división
        ' +=, -= , *= , /=
        Dim n1 As Integer = 1
        n1 += 1   ' --> n1 = n1 + 1
        n1 -= 10   ' --> n1 = n1 - 10

        'Operadores relacionales --> <, <= , >,>= , = (igual que), <> (distinto que)
        '--> Devuelven un valor booleano
        Dim c1 As Boolean = n1 < 10

        'Explicación = y <>
        Dim v1 As Integer = 7
        Dim c2 As Boolean = v1 = 10
        Dim c3 As Boolean = v1 <> 10

        'Operadores Lógicos: AND (Y Lógico) , OR (O Lógico) , Not(Negación)
        'AND--> Devuelve true sólo si las dos condiciones son ciertas
        v1 = 9
        Dim c4 = v1 > 7 And v1 Mod 2 = 0
        Console.WriteLine("Operador AND : " & c4)

        'OR --> Devuelve True si una de las dos condiciones es true

        Dim c5 = v1 > 7 Or v1 Mod 2 = 0
        Console.WriteLine("Operador OR : " & c5)

        'NOT --> Niega lo que va a su derecha
        Dim c6 As Boolean = False
        Dim noC6 As Boolean = Not c6

        v1 = 10
        Dim c7 As Boolean = v1 > 10
        Dim c8 As Boolean = Not c7



        Console.ReadLine()


    End Sub

End Module
