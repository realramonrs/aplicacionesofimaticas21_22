Imports System.IO
Public Class Form1
    Public ruta As String = Directory.GetCurrentDirectory() + "\series.txt"
    Public series As List(Of String)
    Public serieSeleccionada As String
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        series = New List(Of String)(3) 'Inicializo capacidad
        'Guardar elementos en una lista
        'series.Add("Breaking Bad*Netflix")
        'series.Add("Peaky Blinders*Netflix")
        'series.Add("The Wire*HBO")
        'series.Add("Treme*HBO")
        'series.Add("This is US*Prime Video")
        'series.Add("Dopesick*Disney+")
        'series.Add("Chernobyl*HBO")

        'Leer del Fichero y volcar los datos a la lista
        Dim lector As StreamReader = New StreamReader(ruta)

        Dim registro As String

        While Not lector.EndOfStream
            registro = lector.ReadLine()
            'Añadirlo a la lista
            series.Add(registro)
        End While
        lector.Close()


        'Obtener nº de series guardadas
        txtNumeroSeries.Text = series.Count.ToString()

        'Obtener la capacidad de la lista
        txtCapacidad.Text = series.Capacity.ToString()


        'Volcar el título series al listbox
        For Each serie As String In series
            ListBox1.Items.Add(serie.Split("*"c)(0))
        Next



    End Sub

    Private Sub btnGuardarSerie_Click(sender As Object, e As EventArgs) Handles btnGuardarSerie.Click
        Dim titulo As String = txtTitulo.Text
        Dim plataforma As String = ComboBox1.SelectedItem.ToString

        'Buscar la serie en la lista(exige coincidencia exacta), sino está se añade
        ' If series.Contains(titulo + "*" + plataforma) Then
        ' MessageBox.Show("La serie ya está guardada.")
        ' Else
        'series.Add(titulo + "*" + plataforma)
        ''Actualizar info capacidad
        'txtNumeroSeries.Text = series.Count.ToString
        'txtCapacidad.Text = series.Capacity.ToString

        'ListBox1.Items.Add(titulo)
        'End If

        'búsqueda de un substring
        Dim encontrado As Boolean = False
        For Each serie As String In series
            If serie.Contains(titulo) Then
                MessageBox.Show("Ya está la serie")
                encontrado = True
                Exit For

            End If
        Next

        If Not encontrado Then

            series.Add(titulo + "*" + plataforma)
            'Actualizar info capacidad
            txtNumeroSeries.Text = series.Count.ToString
            txtCapacidad.Text = series.Capacity.ToString

            ListBox1.Items.Add(titulo)
        End If

    End Sub



    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        serieSeleccionada = ListBox1.SelectedItem.ToString
    End Sub

    Private Sub btnVerInfo_Click(sender As Object, e As EventArgs) Handles btnVerInfo.Click
        InfoSeries.Show()
    End Sub

    Private Sub btnVolcarFichero_Click(sender As Object, e As EventArgs) Handles btnVolcarFichero.Click
        'crear escritor
        Try
            Dim escritor As StreamWriter = New StreamWriter(ruta, False)

            'Recorro la lista
            For Each serie As String In series
                escritor.WriteLine(serie)
            Next
            escritor.Close()
        Catch ex As Exception
            MessageBox.Show("No se ha podido guardar")
        End Try


    End Sub
End Class
