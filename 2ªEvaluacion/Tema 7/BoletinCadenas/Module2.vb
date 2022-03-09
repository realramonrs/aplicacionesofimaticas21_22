Module Module2
    Public Function getCaracter(ByRef cadena As String, ByVal letra As Char) As Integer
        Dim contador As Integer

        For i As Integer = 0 To cadena.Length - 1 Step 1
            If cadena(i) = letra Then
                contador += 1
            End If
        Next

        Return contador
    End Function

    Public Function contieneArroba(ByRef cadena As String) As Boolean
        If cadena.Contains("@") Then
            Return True
        Else
            Return False
        End If
    End Function
End Module
