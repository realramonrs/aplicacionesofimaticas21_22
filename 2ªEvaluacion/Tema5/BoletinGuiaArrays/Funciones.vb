Module Funciones

    Public Sub mostrarMatriz(ByRef m() As Integer)
        For i As Integer = 0 To m.Length - 1 Step 1
            Console.Write(m(i) & " ")
        Next
        Console.WriteLine()
    End Sub
    Public Sub mostrarMatriz(ByRef m() As Single)
        For i As Integer = 0 To m.Length - 1 Step 1
            Console.Write(m(i) & " ")
        Next
        Console.WriteLine()
    End Sub
    Public Sub mostrarMatriz(ByRef m() As Short)
        For i As Integer = 0 To m.Length - 1 Step 1
            Console.Write(m(i) & " ")
        Next
        Console.WriteLine()
    End Sub
    Public Sub mostrarMatriz(ByRef m() As String)
        For i As Integer = 0 To m.Length - 1 Step 1
            Console.Write(m(i) & " ")
        Next
        Console.WriteLine()
    End Sub

    Public Sub llenarMatriz(ByRef m() As Integer, ByVal inferior As Integer, ByVal superior As Integer)
        Dim aleatorio As New Random

        For i As Integer = 0 To m.Length - 1 Step 1
            m(i) = aleatorio.Next(inferior, superior + 1)
        Next
    End Sub
End Module
