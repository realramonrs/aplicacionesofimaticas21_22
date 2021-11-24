Module FactorialYOtros
    Sub Main()
        Dim n As Integer
        Dim factorial As Long = 1
        'factorial = n*(n-1)*(n-2)*...*1 (n = 5) fact = 5*4*3*2*1
        'suma = 1 + 2 + 3 + 4 + 5 + ... + n

        Console.WriteLine("Introduzca n: ")
        n = Convert.ToInt32(Console.ReadLine())

        If n = 0 Then
            factorial = 1
        Else
            Dim i As Integer = n
            While i > 1
                factorial = factorial * i
                i = i - 1
            End While
        End If

    End Sub
End Module
