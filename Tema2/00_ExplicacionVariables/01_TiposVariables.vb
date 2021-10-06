Module TiposVariables

    Sub Main()
        '¿Qué es una variable? Zona de memoria con tamaño determinado a la que se le da un nombre
        'Las variables deben ser declaradas para poder ser utilizadas
        'Declarar una variable es indicar el tipo y darle un nombre
        'Tipos de variables: Permitir especificar cuanta memoria quiero utilizar
        'Sintaxis genérica: Dim <nombre> As <Tipo de Variable>
        'Por ejemplo:
        Dim edad As Byte 'Declaro la variable de nombre edad y de tipo Byte
        edad = 9 'Inicializo la variable edad a 9

        'Una variable numérica no inicializada, almacena por defecto vale cero
        'Tipos de variables numéricas en VB:
        'Byte: Permite almacenar valores entre 0 y 256
        'Dim variable1 As Byte = -7   --> Esta linea genera un error
        'SByte: Permite almacenar valores entre -128 y 127
        Dim variable2 As SByte = -7
        ' Dim variable3 As SByte = -129  Esto genera un error

        'Short: Permite almacenar valores entre -32768 y 32767 (2 bytes)
        Dim variable4 As Short = 4500

        'Integer: Permite reservar 4 bytes de memoria
        Dim variable5 As Integer = -230000000

        'Long: Permite reservar hasta 8 bytes de memoria
        Dim variable6 As Long = 230000000000

        'Variables decimales
        Dim variable7 As Single = 4.1234567
        variable7 = 9.45
        Dim variable8 As Double = 4.2323423123132

        'Variables alfanuméricas
        Dim variable9 As Char = "r"c
        Dim variable10 As String = "En un lugar de la Mancha..."
        Dim telefono As String = "+34-655453421"

        Dim dni As String = "12345678G"

        'Variables booleanas:
        Dim condicion As Boolean = True
        Dim condicion2 As Boolean = variable7 < 10

        'Ciertas normas para los nombres de las variables:
        '1) No pueden contener espacios
        '2) No pueden empezar por dígitos, aunque puede contenerlos más adelante
        '3) No pueden contener símbolos extraños ni acentos: %,-,!?&
        '4) Por convenio se escriben en minúsculas, salvo las iniciales de las palabras compuestas
        'temperaturaMaxima






    End Sub

End Module
