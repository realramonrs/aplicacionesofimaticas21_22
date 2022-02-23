Module Module1

    Sub Main()
        'Cadenas --> Strings
        'Se utilizan para almacenar caracteres alfanuméricos o símbolos
        Dim dni As String = "12345678R"
        Dim cp As String = "36204"
        Dim telefono As String = "(+34)654323441"

        'Los strings son arrays de caracteres
        'Mostrar por pantalla las posiciones en las que se encuentra
        'el caracter 'a' en un String
        Dim mensaje As String = "Hdila soy una cadena"
        Dim encontrado As Boolean = False
        Console.WriteLine("La z está en las posiciones: ")
        For i As Integer = 0 To mensaje.Length - 1 Step 1
            If mensaje(i) = "z"c Then
                Console.Write(i & " ")
                encontrado = True
            End If
        Next
        If encontrado = False Then
            Console.WriteLine("No está en la cadena")
        End If
        Console.WriteLine()
        'Funciones de la clase String
        'indexOf(char c) --> El índice de la primera aparición de ese caracter en el String
        cp = "30204"
        Dim posicion As Integer = cp.IndexOf("0")
        Console.WriteLine("El cero está en la posición: " & posicion)

        'indexOf(char c, int startIndex)
        Dim posicion2 As Integer = cp.IndexOf("0", posicion + 1)
        Console.WriteLine("El segundo cero está en : " & posicion2)


        'indexOfAny(char c())--> Busca varios caracteres en el String
        'Obtener posición de la primera vocal en un String
        Dim buscados() As Char = {"a"c, "e"c, "i"c, "o"c, "u"c}
        Dim posicionVocal1 As Integer = mensaje.IndexOfAny(buscados)
        Console.WriteLine("La primera vocal está en la posición: " & posicionVocal1)

        'startsWith(String c) y endsWith(String c)

        Dim empiezaPor30 As Boolean = cp.StartsWith("30")
        Dim finalizaPor56 As Boolean = cp.EndsWith("56")

        Dim codigosPostales(7) As String

        codigosPostales(0) = "34560"
        codigosPostales(1) = "36205"
        codigosPostales(2) = "36204"
        codigosPostales(3) = "35908"
        codigosPostales(4) = "34301"
        codigosPostales(5) = "36207"
        codigosPostales(6) = "36208"
        codigosPostales(7) = "36908"

        'Buscar todos los codigos postales que empiecen por 36

        For Each codigoPostal As String In codigosPostales
            If codigoPostal.StartsWith("36") Then
                Console.WriteLine(codigoPostal)
            End If
        Next

        'contains(String c)--> Devuelve true si ese String aparece en el String desde el cuál se llama a la función
        Dim mensaje2 As String = "Pedro Martinnez Sánchez"

        If mensaje2.Contains("Sanchez") Then

        End If
        Console.ReadLine()

    End Sub

End Module
