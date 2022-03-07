Module Ejercicio2
    Sub main()
        Dim alumnos(4) As String
        alumnos(0) = "Anotnio Muiña"
        alumnos(1) = "David Rodriguez"
        alumnos(2) = "Juan Pereira"
        alumnos(3) = "Ludwig Muiña"
        alumnos(4) = "Cristopher Piñeiro"

        For Each alumno As String In alumnos
            If alumno.Contains("Muiña") Then
                Console.WriteLine(alumno)
            End If
        Next

        'startsWith
        Console.WriteLine("Alumnos que empiezan por Da")
        For Each alumno As String In alumnos
            If alumno.StartsWith("Da") Then
                Console.WriteLine(alumno)
            End If
        Next
        Console.ReadLine()
    End Sub
End Module
