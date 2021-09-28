Module Module1

    Sub Main()

        'Llamamos al módulo Console de la Carpeta System
        Console.WriteLine("Me gustan Los Simpsons")


        'Utilizamos la función ReadLine() para mantener consola abierta
        'El programa se detiene hasta que el usuario pulse Enter
        Console.ReadLine()

        'Cambiar el título de la ventana
        Console.Title = "Mi primer programa en VB"

        'Cambiar el color al texto de la consola
        Console.ForegroundColor = ConsoleColor.Red

        Console.WriteLine("ESto es texto en rojo!")

        'Ejemplo de función con 2 argumentos:
        Console.Beep(5600, 5000)


        'Utilizamos la función ReadLine() para mantener consola abierta
        Console.ReadLine()




    End Sub

End Module
