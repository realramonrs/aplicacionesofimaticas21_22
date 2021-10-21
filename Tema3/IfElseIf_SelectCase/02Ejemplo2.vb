Module _02Ejemplo2
    Sub Main()
        'Programa que detecte si un número es múltiplo de 2, de 3, de 5 o de 7
        Dim numero As Integer
        Console.WriteLine("Intro número")
        numero = Convert.ToInt32(Console.ReadLine())

        If numero Mod 2 = 0 Then
            Console.WriteLine("Múltiplo de 2")
        ElseIf numero Mod 3 = 0 Then
            Console.WriteLine("múltiplo de 3")
        ElseIf numero Mod 5 = 0 Then
            Console.WriteLine("múltiplo de 5")
        ElseIf numero Mod 7 = 0 Then
            Console.WriteLine("Múltiplo de 7")
        Else
            Console.WriteLine("No es múltiplo ni de 2 , ni de 3 , ni de 5 , ni de 7")
        End If

        'Versión mejorada del programa:

        'If numero Mod 2 = 0 Then
        '    If numero Mod 3 = 0 Then
        '        If numero Mod 5 = 0 Then
        '            Console.WriteLine("número múltiplo de 2, de 3 y de 5")
        '        Else
        '            Console.WriteLine("Número múltiplo de 2 y de 3")
        '        End If
        '    Else
        '        Console.WriteLine("Número múltiplo de 2")
        '    End If
        'Else
        '    Console.WriteLine("Número no es múltiplo de 2")

        'End If

        Console.WriteLine("Versión mejorada, indica si es múltiplo de varios a la vez")
        Console.WriteLine()
        Console.ReadLine()

        If numero Mod 2 = 0 And numero Mod 3 = 0 And numero Mod 5 = 0 Then
            Console.WriteLine("Número múltiplo de 2,3, y 5")
        ElseIf numero Mod 2 = 0 And numero Mod 3 = 0 Then
            Console.WriteLine("número múltiplo de 2 y de 3")
        ElseIf numero Mod 2 = 0 And numero Mod 5 = 0 Then
            Console.WriteLine("Número moltiplo de 2 y de 5")
        ElseIf numero Mod 3 = 0 And numero Mod 5 = 0 Then
            Console.WriteLine("número múltiplo de 3 y de 5")
        ElseIf numero Mod 2 = 0 Then
            Console.WriteLine("Número múltiplo de 2")
        ElseIf numero Mod 3 = 0 Then
            Console.WriteLine("Número múltiplo de 3")
        ElseIf numero Mod 5 = 0 Then
            Console.WriteLine("Número múltiplo de 5")
        Else
            Console.WriteLine("No es múltiplo de 2 ni de 3 ni de 5")
        End If





        Console.ReadLine()
    End Sub
End Module
