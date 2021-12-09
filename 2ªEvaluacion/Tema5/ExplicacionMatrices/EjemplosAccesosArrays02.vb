Module EjemplosAccesosArrays02
    Sub main()
        Dim temperaturas(29) As Double

        'Programa que solicita una temperatura 
        'Esta temperatura debe de guardarse en la primera pos que no tenga datos
        'Necesitamos inicializar todas las posiciones del array a un valor absurdo,
        ' por ejemplo 500
        'temperaturas(0) = 500
        'temperaturas(1) = 500
        'temperaturas(2) = 500

        Dim i As Integer = 0
        While i < temperaturas.Length

            temperaturas(i) = 500
            i += 1
        End While

        temperaturas(0) = 15.6
        temperaturas(1) = 20.4
        temperaturas(2) = 14.3
        'Solicitamos temperatura 
        Console.WriteLine("Introduzca la temperatura del día : " & Date.Today.ToShortDateString)
        Dim temp As Double = Convert.ToDouble(Console.ReadLine())

        'Recorremos matriz en busca de posición vacía (valor 500)
        Dim contador As Integer = 3
        For pos As Integer = 0 To temperaturas.Length - 1 Step 1
            If temperaturas(pos) = 500 Then
                temperaturas(pos) = temp
                contador += 1 'Registramos que hemos guardado una temperatura
                Exit For
            End If
        Next

        'Mostrar temperaturas registradas en Noviembre
        Console.WriteLine("Temperaturas registradas en el mes " & Date.Today.Month)
        For pos As Integer = 0 To temperaturas.Length - 1 Step 1
            If temperaturas(pos) <> 500 Then
                Console.WriteLine("Día " & pos + 1 & " : " & temperaturas(pos))
            End If
        Next

        'Calcular la suma de todas las temperaturas

        Dim sumaTemperaturas As Double = 0

        Dim posicion As Integer = 0

        While posicion < temperaturas.Length
            If temperaturas(posicion) <> 500 Then
                sumaTemperaturas = sumaTemperaturas + temperaturas(posicion)
            End If
            posicion += 1
        End While
        'Calcular la media
        '1º Necesito contar las temperaturas
        Dim media As Double = sumaTemperaturas / contador
        Console.WriteLine("La temperatura media del mes es : " & media)


        Console.ReadLine()
    End Sub
End Module
