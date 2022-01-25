Module Funciones01
    'Función que calcula la raíz cuadrada de dos números enteros
    'En caso de no poder hallarla devuelve cero.
    Public Function raizSuma2(ByRef n1 As Integer, ByVal n2 As Integer) As Double
        n1 = 2000
        Dim suma As Integer = n1 + n2
        Dim raiz As Double = 0
        If suma >= 0 Then
            raiz = Math.Sqrt(suma)

        End If

        Return raiz

    End Function

    Public Function sumaArray(ByRef m() As Integer) As Integer
        Dim suma As Integer = 0

        For Each valor As Integer In m
            suma += valor
        Next

        Return suma

    End Function

    Public Sub e(ByVal mensaje As String)
        Console.WriteLine(mensaje)

    End Sub

    'Procedimiento que muestra un array de enteros por pantalle
    Public Sub mostrarArray(ByRef m() As Integer)
        For Each valor As Integer In m
            Console.Write(valor & " ")

        Next
        Console.WriteLine()
    End Sub

End Module
