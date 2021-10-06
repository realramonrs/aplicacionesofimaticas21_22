Option Strict On
Module EjercicioRepaso
    Sub Main()
        'Programa que calcula el precio final de venta
        'de un inmueble a partir de los siguientes datos
        'precio inicial de venta , precio que cuesta el inmueble
        'IVA: 10% --> Constante
        'Comisión de la inmobiliaria
        Dim precioInicial, precioConIva, precioFinal As Double
        Const IVA As Byte = 15
        Dim comision As Single = 3.0

        precioInicial = 100000
        precioConIva = precioInicial + (IVA / 100) * precioInicial

        precioFinal = precioConIva + (precioConIva * comision) / 100

        Console.WriteLine("Precio inicial del inmueble: " & precioInicial & " euros")
        Console.WriteLine("Precio con Iva: " & precioConIva & " euros")
        Console.WriteLine("Precio final con comisión: " & precioFinal & "euros")
        Console.ReadLine()


    End Sub
End Module
