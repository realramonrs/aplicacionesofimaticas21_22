Module Module1

    Sub Main()
        'Sentencias selección: Permiten indicar condiciones que si son ciertas se ejecutan unas instrucciones
        'Expresiones booleanas : True o False
        'Operadores booleanos : < ,>,<=,>= ,<>,=
        'Operadores :C1 AND C2,C1 OR C2 , NOT
        Dim x As Integer = 100
        Dim y As Integer = 20

        If x > y Then
            Console.WriteLine(x & " > " & y)
        Else
            Console.WriteLine(y & " <= " & x)
        End If

        'Programa que indica si una persona es menor de edad
        Dim edad As Integer
        Console.WriteLine("Introduzca su edad: ")
        edad = Convert.ToInt32(Console.ReadLine())

        If edad <= 18 Then
            Console.WriteLine("Menor de edad")
        Else
            Console.WriteLine("Mayor de edad.")
        End If

        'Programa que dice si un número par
        Dim numero As Integer = 290

        If numero Mod 2 = 0 Then
            Console.WriteLine("Par")
        Else
            Console.WriteLine("Impar.")
        End If











        Console.ReadLine()
    End Sub

End Module
