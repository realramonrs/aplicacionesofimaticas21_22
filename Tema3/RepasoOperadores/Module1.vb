Option Strict On
Module Module1

    Sub Main()
        Dim x As Integer = 250

        If x <> 10 And x / 25 = 0 Then
            x = x + 10
        Else
            x = x - 10
        End If
        Console.WriteLine(x)

        Console.ReadLine()


        Dim c As Boolean

        x = 0
        Dim y As Integer = 10

        c = x < 0

        If c = False Then
            y += 10
        End If
        Console.WriteLine(y)
        Console.ReadLine()


    End Sub

End Module
