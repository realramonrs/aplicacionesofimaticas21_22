Module Funciones

    Public Sub generador(ByRef m() As Integer, ByVal limiteInf As Integer, ByVal limiteSuperior As Integer)
        Dim aleatorio As New Random

        For i As Integer = 0 To m.Length - 1 Step 1
            m(i) = aleatorio.Next(limiteInf, limiteSuperior)
        Next
    End Sub

    Public Sub mostrar(ByRef m() As Integer)


        For i As Integer = 0 To m.Length - 1 Step 1
            Console.Write(m(i) & " ")
        Next
        Console.WriteLine()
    End Sub

    Public Sub buscarNumero()
        Dim matriz6(10) As Integer
        generador(matriz6, -10, 11)

        Console.WriteLine("Matriz generada: ")
        mostrar(matriz6)

        Console.WriteLine("Introduce número: ")
        Dim numeroBuscado As Integer = Convert.ToInt32(Console.ReadLine())

        Dim encontrado As Boolean = False

        For i As Integer = 0 To matriz6.Length - 1 Step 1
            If matriz6(i) = numeroBuscado Then
                encontrado = True
                Console.WriteLine("Posición: " & i)


            End If
        Next

        If Not encontrado Then
            Console.WriteLine("No está en la matriz")
        End If
    End Sub
End Module
