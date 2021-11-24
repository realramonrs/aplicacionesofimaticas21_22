Module DoLoopWhile
    Sub Main()
        'Ejemplo 1: Programa que solicita número positivo
        Dim numero As Integer
        Do
            Console.WriteLine("Introduzca un número > 0")
            numero = Convert.ToInt32(Console.ReadLine())
        Loop While numero < 0

        'Ejemplo 2: Programa que solicita un número entre 1 y 10
        Dim numero2 As Integer
        Do

            Console.WriteLine("Introduzca un número entre 1 y 10")
            numero2 = Convert.ToInt32(Console.ReadLine())
        Loop While numero2 < 1 Or numero2 > 10

        'Ejemplo 3: Programa que solicita un número múltiplo de 7 y menor que 350

        Dim numero3 As Integer
        Do
            Console.WriteLine("Introduzca un número entre múltipo de 7 y menor que 350")
            numero3 = Convert.ToInt32(Console.ReadLine())
        Loop While numero3 Mod 7 <> 0 Or Not numero3 <= 350

        'Ejemplo 4: Programa que solicita un valor que no puede estar entre 1 y 10
        Dim numero4 As Integer

        Do
            Console.WriteLine("Introduzca un número fuera del intervalo 1 - 10")
            numero4 = Convert.ToInt32(Console.ReadLine())
        Loop While numero4 >= 1 And numero4 <= 10


        Console.ReadLine()
    End Sub
End Module
