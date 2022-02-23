Module Funciones
    'Ejercicio 1
    Public Function isPar(ByVal n As Integer) As Boolean
        Dim par As Boolean = False
        If n Mod 2 = 0 Then
            par = True
        End If
        Return par
    End Function

    'Ejercicio 2
    Public Function raiz(ByVal n As Double) As Double
        Dim resultado As Double = 0

        If n > 0 Then
            resultado = Math.Sqrt(n)
        End If

        Return resultado
    End Function
    'Ejercicio 3

    Public Function getMinimoValor(ByVal n1 As Integer, ByVal n2 As Integer) As Integer
        If n1 < n2 Then
            Return n1
        Else
            Return n2
        End If
    End Function

    'Ejercicio 4
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
    'Ejercicio 5
    Public Function sonIguales(ByRef s As String, ByRef s2 As String) As Boolean
        If s = s2 Then
            Return True
        Else
            Return False
        End If
    End Function

    'Ejercicio 6

    Public Sub intercambiar(ByRef n1 As Integer, ByRef n2 As Integer)
        Dim n3 As Integer = n1
        n1 = n2
        n2 = n3
    End Sub


    'Ejercicio 8
    Public Sub sumaDivisoresEj8(ByVal n As Integer, ByRef suma As Integer)

        For i As Integer = 1 To n Step 1
            If n Mod i = 0 Then
                suma += i
            End If
        Next



    End Sub

    'Ejercicio 9
    Public Function buscarPrimerCero(ByRef matriz() As Integer) As Integer
        Dim posicion As Integer = -1

        For i As Integer = 0 To matriz.Length - 1 Step 1
            If matriz(i) = 0 Then
                posicion = i
                Exit For
            End If
        Next
        Return posicion
    End Function

    'Ejercicio 10
    Public Function contarCeros(ByRef m() As Integer) As Integer
        Dim contador As Integer = 0

        For Each valor As Integer In m
            If valor = 0 Then
                contador += 1
            End If
        Next
        Return contador
    End Function

    'Ejercicio 12
    Public Sub llenarMatriz(ByRef m() As Integer)
        Dim generador As Random = New Random

        For i As Integer = 0 To m.Length - 1 Step 1
            m(i) = generador.Next()
        Next
    End Sub

    Public Sub llenarMatriz(ByRef m() As Integer, ByVal limiteSuperior As Integer)
        Dim generador As Random = New Random

        For i As Integer = 0 To m.Length - 1 Step 1
            m(i) = generador.Next(limiteSuperior)
        Next
    End Sub

    Public Sub llenarMatriz(ByRef m() As Integer, ByVal sup As Integer, ByVal inf As Integer)
        Dim generador As Random = New Random

        For i As Integer = 0 To m.Length - 1 Step 1
            m(i) = generador.Next(inf, sup)
        Next
    End Sub

    'Ejercicio 13
    Public Sub guardarDatosPorTeclado(ByRef m() As String)
        For i As Integer = 0 To m.Length - 1 Step 1
            Console.WriteLine("Introduzca dato : " & i + 1)
            m(i) = Console.ReadLine
        Next
    End Sub

    'Ejercicio 14
    Public Sub mostrarMatrizConsola(ByRef m() As Integer)

        For Each valor As Integer In m
            Console.Write(valor & " ")
        Next
        Console.WriteLine()
    End Sub

    Public Sub mostrarMatrizConsola(ByRef m() As String)

        For Each valor As String In m
            Console.Write(valor & " ")
        Next
        Console.WriteLine()
    End Sub

    Public Sub sumaMatriz(ByRef m() As Integer, ByRef resultado As Integer)

        For i As Integer = 0 To m.Length - 1 Step 1
            resultado += m(i)
        Next

    End Sub

    Private Function contarNegativos(ByRef m() As Integer) As Integer
        Dim contador As Integer
        For Each valor As Integer In m
            If valor < 0 Then
                contador += 1
            End If
        Next
        Return contador
    End Function

    Public Function getNegativosMatriz(ByRef m() As Integer) As Integer()
        Dim numerosNegativos As Integer = contarNegativos(m)
        Dim matriz(numerosNegativos - 1) As Integer
        Dim j As Integer
        For i As Integer = 0 To m.Length - 1 Step 1
            If m(i) < 0 Then
                matriz(j) = m(i)
                j += 1
            End If
        Next

        Return matriz
    End Function

    Public Function devuelveSuma(ByVal x1 As Integer, ByVal x2 As Integer) As Integer
        Return x1 + x2
    End Function

    Public Sub reseteaMatriz(ByRef x() As Integer)
        x(0) = 0

    End Sub

    Public Function doblarMatriz(ByRef original() As Integer) As Integer()
        Dim copia(original.Length - 1) As Integer
        For i As Integer = 0 To copia.Length - 1 Step 1
            copia(i) = original(i) * 2
        Next
        Return copia
    End Function

    Public Function getDivisorNoUnoNoN(ByVal n As Integer) As Integer
        Dim divisor As Integer = 1
        For i As Integer = 2 To n - 1 Step 1
            If n Mod i = 0 Then
                divisor = i
                Return divisor

            End If
        Next
        Return divisor
    End Function



End Module
