Module Funciones
    Public Function isPerfect(ByVal n As Integer) As Boolean
        Dim suma As Integer = 0

        For i As Integer = 1 To n - 1 Step 1
            suma += i
        Next

        If suma = n Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Sub printar(ByRef m(,) As Integer)

        For i As Integer = 0 To m.GetUpperBound(0) Step 1
            For j As Integer = 0 To m.GetUpperBound(1) Step 1
                Console.Write(m(i, j) & " ")

            Next
            Console.WriteLine()
        Next
    End Sub
End Module
