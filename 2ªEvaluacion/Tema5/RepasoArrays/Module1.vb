Module Module1

    Sub Main()
        'Declarando un array con capacidad para 10 valores de tipo integer
        Dim matriz(99) As Integer
        matriz(0) = 3
        matriz(2) = 90
        matriz(5) = 34
        matriz(9) = 45


        Dim matrizJaime() As Integer = {9, 0, 5, 6, 7, 0, 3, 2, 1}
        Dim numeroBuscado As Integer
        Console.WriteLine("Introduzca el número que desea buscar: ")
        numeroBuscado = Convert.ToInt32(Console.ReadLine())
        Dim encontrado As Boolean = False
        For i As Integer = 0 To matrizJaime.Length - 1 Step 1
            If matrizJaime(i) = numeroBuscado Then
                Console.WriteLine(numeroBuscado & " en posición: " & i)
                encontrado = True

            End If
        Next
        If encontrado = False Then
            Console.WriteLine("No se ha encontrado en la matriz.")
        End If


        Console.ReadLine()

    End Sub

End Module
