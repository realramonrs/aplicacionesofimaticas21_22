Module EjemplosDeclaracion01

    Sub Main()
        'Ejemplo 1 : Array de 10 valores de tipo integer
        Dim x(9) As Integer

        'Ejemplo 2 : Array de 14 valores de tipo String
        Dim y(13) As String

        'Guardar un String en la posicion 0
        y(0) = "Zacarias Blanco"
        y(1) = "Leandro Puente"

        'Ejemplo 3: Array cuyo tamanho es escogido por el usuario
        Dim n As Integer = 0
        Console.WriteLine("Introduzca el tamaño de la matriz")
        n = Convert.ToInt32(Console.ReadLine())

        Dim array(n - 1) As Integer





    End Sub

End Module
