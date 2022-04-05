Imports System.IO
Public Class Form1
    Dim canciones(99) As String
    Dim ruta As String = Directory.GetCurrentDirectory() + "/canciones.txt"
    Private Sub btnGuardarCancion_Click(sender As Object, e As EventArgs) Handles btnGuardarCancion.Click
        Dim titulo As String = txtTitulo.Text
        Dim grupo As String = txtGrupo.Text
        Dim registro As String = titulo + "*" + grupo

        Dim escritor As StreamWriter = New StreamWriter(ruta, True)
        escritor.WriteLine(registro)

        ListBox1.Items.Add(registro)
        escritor.Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Leer las canciones del fichero
        Dim lector As StreamReader = New StreamReader(ruta)

        Dim posicion As Integer = 0

        While Not lector.EndOfStream
            canciones(posicion) = lector.ReadLine()
            posicion += 1
        End While
        lector.Close()

        'volcar los titulos al listbox
        For Each cancion As String In canciones
            If Not cancion Is Nothing Then
                ListBox1.Items.Add(cancion.Split("*")(0))
            Else
                Exit For
            End If

        Next
    End Sub


End Class
