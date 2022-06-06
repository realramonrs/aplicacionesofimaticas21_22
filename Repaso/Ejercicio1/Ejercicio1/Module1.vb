Module Module1

    Sub Main()
        Dim x(9) As Integer
        Dim y() As Integer = {9, 5, 4, 3, 1}

        'Para obtener la capacidad de una matriz --> .length
        Dim capacidadX As Integer = x.Length
        Dim capacidadY As Integer = y.Length

        'Para acceder a las diferentes posiciones--> índice
        'Primer valor tiene índice cero
        Dim primerValorX As Integer = x(0)
        Dim primerValorY As Integer = y(0)

        'Último valor --> índice .length - 1
        Dim ultimoValorX As Integer = x(capacidadX - 1)
        Dim ultimoValorY As Integer = y(capacidadY - 1)

        'Recorrer una matriz para mostrar por pantalla sus valores

        For i As Integer = 0 To capacidadX - 1 Step 1
            Console.Write(x(i) & " ")
        Next

        'Modificar valores de matriz X
        x(0) = 9
        x(1) = 4
        x(2) = 5

        'Introducir por teclado los valores que faltan
        For i As Integer = 3 To x.Length - 1 Step 1
            Console.WriteLine("Intro valor posición: " & i)
            x(i) = Convert.ToInt32(Console.ReadLine())
        Next

        'Mostrar valores

        For i As Integer = 0 To x.Length - 1 Step 1
            Console.Write(x(i) & " ")
        Next
        Console.WriteLine()
        'Calcular la suma: 
        Dim suma As Integer = 0
        For i As Integer = 0 To x.Length - 1 Step 1
            suma += x(i)
        Next
        'Calculo la media

        Dim media As Double = suma / x.Length

        Dim desviacion0 As Double = Math.Abs(x(0) - media)



        Console.ReadLine()












    End Sub

End Module

