Module Repaso2
    Sub Main()
        'Programa que cuenta los números que son múltiplos de 3 o 7 entre n y m
        'Siendo n y m limite inferior y superior
        Dim n, m, contador As Integer
        Console.WriteLine("Intro límite inferior: ")
        n = Convert.ToInt32(Console.ReadLine())
        Console.WriteLine("Intro límite superior: ")
        m = Convert.ToInt32(Console.ReadLine())


        'For i As Integer = n To m Step 1
        Dim i As Integer = n
        Dim primerMultiplo3o7 As Integer = 0
        Dim suma As Integer = 0
        While i <= m
            If i Mod 3 = 0 Or i Mod 7 = 0 Then
                primerMultiplo3o7 = i
                suma = suma + i
                contador += 1
                Exit While
            End If
            i = i + 1
        End While
        'Next
        Console.WriteLine("Mostrar por pantalla los divisores de un número")
        Dim numero As Integer
        Console.WriteLine("Introduzca un número: ")
        numero = Convert.ToInt32(Console.ReadLine())

        Console.WriteLine("Los divisores de " & numero & " son :")
        Console.Write("1 , ")

        'Bucle que divide numero entre todos los números desde el 2 hasta numero/2
        Dim sumaDivisores = 1
        For j As Integer = 2 To Convert.ToInt32(numero / 2) Step 1
            If numero Mod j = 0 Then
                Console.Write(j & " , ")
                sumaDivisores = sumaDivisores + j
            End If
        Next
        Console.Write(numero)
        Console.WriteLine()
        Console.WriteLine("La suma de los divisores es: " & sumaDivisores)
        If sumaDivisores = numero Then
            Console.WriteLine("Perfecto")
        Else
            Console.WriteLine("No perfecto")
        End If

        'Mínimo Común múltiplo
        Dim n1, n2, n3 As Integer
        n1 = 18
        n2 = 24
        n3 = 30
        Dim maximo As Integer = Math.Max(n1, Math.Max(n2, n3))
        Dim multiplicacion As Integer = n1 * n2 * n3
        Dim mcm As Integer = 1
        For j As Integer = maximo To multiplicacion Step 1
            If j Mod n1 = 0 And j Mod n2 = 0 And j Mod n3 = 0 Then
                mcm = j
                Exit For
            End If
        Next

        Console.WriteLine("EL mcm es : " & mcm)

        'Máximo común divisor

        Dim mcd As Integer = 0

        Dim menor As Integer = Math.Min(n1, Math.Min(n2, n3))


        For j As Integer = menor To 1 Step -1
            If n1 Mod j = 0 And n2 Mod j = 0 And n3 Mod j = 0 Then
                mcd = j
                Exit For
            End If
        Next

        Console.WriteLine("El mcd es : " & mcd)


        Console.ReadLine()

















    End Sub
End Module
