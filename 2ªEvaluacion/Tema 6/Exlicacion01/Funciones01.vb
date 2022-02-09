Module Funciones01
    'Función que calcula la raíz cuadrada de dos números enteros
    'En caso de no poder hallarla devuelve cero.
    Public Function raizSuma2(ByVal n1 As Integer, ByVal n2 As Integer) As Double

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

    Public Function sumaArray(ByRef m() As Double) As Double
        Dim suma As Double = 0

        For Each valor As Double In m
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

    Public Function add10(ByVal n As Integer) As Integer
        n = n + 10
        Return n
    End Function

    Public Sub suma10(ByRef n As Integer)
        n += 10
    End Sub

    Public Function isPrimo(ByVal n As Integer) As Boolean
        Dim primo As Boolean = True
        For i As Integer = 2 To n - 1 Step 1
            If n Mod i = 0 Then
                primo = False
                Exit For
            End If
        Next

        Return primo
    End Function

    Public Sub aplicarDescuento(ByRef x As Double, ByVal porcentaje As Double)
        x = x - (x * porcentaje) / 100

    End Sub

    Public Sub findFirst(ByRef a() As Integer, ByVal valor As Integer, ByVal posicion As Integer)
        posicion = -1
        For i As Integer = 0 To a.Length - 1 Step 1
            If a(i) = valor Then
                posicion = i
                Exit For
            End If
        Next
    End Sub
End Module
