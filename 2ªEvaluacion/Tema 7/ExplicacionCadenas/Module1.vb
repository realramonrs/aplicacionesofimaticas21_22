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
        Dim mensaje As String = "Hola soy una cadena"
        Dim encontrado As Boolean = False
        Console.WriteLine("La a está en las posiciones: ")
        For i As Integer = 0 To mensaje.Length - 1 Step 1
            If mensaje(i) = "a"c Then
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
        Dim mensaje2 As String = "Pedro Martinez Sánchez"

        If mensaje2.Contains("Sanchez") Then

        End If

        'substring()--> Extraer un substring del string original
        Dim registro As String = "12345678R-65454876553212?Calle Pizarro 54 6B"
        Dim posInterrogacion As Integer = registro.IndexOf("?")
        Dim posGuion As Integer = registro.IndexOf("-")
        Dim direccion As String = registro.Substring(posInterrogacion + 1)
        Console.WriteLine("Direccion: " & direccion)
        Dim tlfn As String = registro.Substring(posGuion + 1, posInterrogacion - posGuion - 1)
        Console.WriteLine("El teléfono es: " & tlfn)

        'split(separador) --> Trocea el string original utilizando el separador indicado como argumento
        'y devuelve una matriz con los tokens generados
        Dim mensaje3 As String = "Hay que aprender a programar , si quiero trabajar"
        Dim partes() As String = mensaje3.Split(",")
        Dim palabras() As String = mensaje3.Split(" ")
        'Algoritmo que muestre las palabras empiezan por a

        For Each palabra As String In palabras
            If palabra.StartsWith("a") Then
                Console.WriteLine(palabra)
            End If
        Next

        'Algoritmo que me indica cuantos dígitos hay en un String
        Dim contadorDigitos As Integer
        Dim dniPrueba As String = "12345678Y"
        For i As Integer = 0 To dniPrueba.Length - 1 Step 1
            If Char.IsDigit(dniPrueba(i)) Then
                contadorDigitos += 1
            End If
        Next
        Console.WriteLine("El DNI tiene " & contadorDigitos & " digitos.")

        Dim cadena4 As String = "Hola caracola"
        cadena4 = cadena4.Replace("o"c, "e"c)
        cadena4 = cadena4.ToUpper()



        Console.WriteLine(cadena4)





        Console.ReadLine()

    End Sub

End Module
