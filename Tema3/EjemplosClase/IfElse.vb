Module IfElse

    Sub Main()
        'Programa que solicita la edad e indica si el usuario es menor o mayor de 18 años
        Dim edad As Byte
        Console.WriteLine("Introduzca su edad: ")
        edad = Convert.ToByte(Console.ReadLine())

        If edad >= 18 Then
            Console.WriteLine("Eres mayor de edad, puedes ir acceder al programa Erasmus+")
        Else
            Console.WriteLine("Menor de edad, no puedes ir de Erasmus! Lo sentimos")
        End If

        Console.ReadLine()

    End Sub
End Module
