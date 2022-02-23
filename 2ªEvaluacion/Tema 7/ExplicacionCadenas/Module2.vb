Module Module2

    Public Sub redondear(ByRef n As Integer)
        n = Math.Round(n)
    End Sub

    Public Sub redondear(ByRef n As Integer, ByVal decimales As Integer)
        n = Math.Round(n, decimales)
    End Sub
End Module
