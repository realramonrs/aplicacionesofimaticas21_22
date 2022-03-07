Module Module1

    Sub Main()

        Dim opcion As Char
        Do
            Console.WriteLine("Escoja una opción: ")
            Console.WriteLine("a. Ejemplo letra e")
            Console.WriteLine("b. Mostrar digitos.")
            Console.WriteLine("c. Ejemplo substring")
            Console.WriteLine("d. Ejemplo indexOf")
            opcion = Convert.ToChar(Console.ReadLine())
            Dim cadena As String = "El Celta ganó 04-03"
            Select Case opcion
                Case "a"c

                    'Un String es un array
                    'Mostrar posiciones letra e o E
                    Console.WriteLine("Posiciones que contienen letra e o E:")
                    For i As Integer = 0 To cadena.Length - 1 Step 1
                        If cadena(i) = "e" Or cadena(i) = "E" Then
                            Console.Write(i & " ")
                        End If

                    Next
                    Console.WriteLine()
                Case "b"c
                    'Mostrar los caracteres que sean digitos
                    Console.WriteLine("La cadena contiene los siguientes digitos: ")
                    For i As Integer = 0 To cadena.Length - 1 Step 1
                        If Char.IsDigit(cadena(i)) Then
                            Console.Write(cadena(i) & " , ")
                        End If

                    Next
                    Console.WriteLine()
                Case "c"c
                    'Función substring
                    '1ª Forma: cadena.substring(posicion)
                    Dim cadena2 As String = "Ramón explica estupendamente"
                    Dim subCadena As String = cadena2.Substring(6)
                    Console.WriteLine(subCadena)
                    '2º Forma: cadena.subString(posicion,numero caracteres)
                    Dim codigo As String = "1234QWER"
                    Dim subCodigo As String = codigo.Substring(0, 4)
                    Console.WriteLine("Parte numérica del código: " & subCodigo)
                    Dim subCodigoInteger As Integer = Convert.ToInt32(subCodigo)

                Case "d"c
                    'indexOf()
                    '1ª Forma --> indexOf(char f)
                    Dim ejemplo As String = "Mauro está atendiendo, increible!"
                    Dim posicion As Integer = ejemplo.IndexOf("a")
                    If posicion = -1 Then
                        Console.WriteLine("No se ha encontrado el caracter en el String")
                    Else
                        Console.WriteLine("Está en la posición: " & posicion)
                    End If

                    '2ª Forma --> indexOf(char f, int startIndex)
                    Dim posicion2 As Integer = ejemplo.IndexOf("a", 5)

                    '3ª Forma --> indexOf(char f, int startIndex,int count)
                    Console.ReadLine()
                Case "e"c
                    'contains(String c)--> Devuelve true si lo encuentra
                    Dim ejemploContains As String = "Caminando por el Oeste"
                    If ejemploContains.Contains("Oeste") Then
                        Console.WriteLine("Contiene la palabra Oeste")
                    Else
                        Console.WriteLine("No contiene la palabra Oeste")
                    End If

                Case "f"c
                    Dim frase As String = "Me encanta programar en VB"
                    Dim palabras() As String = frase.Split(" "c)
                    Console.WriteLine(palabras(0))

            End Select
        Loop While opcion <> "z"c






        Console.ReadLine()
    End Sub

End Module
