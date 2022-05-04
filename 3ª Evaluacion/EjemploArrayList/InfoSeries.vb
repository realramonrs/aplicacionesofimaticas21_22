Public Class InfoSeries
    Private Sub InfoSeries_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtTitulo.Text = Form1.serieSeleccionada

        'Buscar plataforma en la Lista de Series
        For Each serie As String In Form1.series
            If serie.Contains(Form1.serieSeleccionada) Then
                txtPlataforma.Text = serie.Split("*"c)(1)
                Exit For
            End If
        Next
    End Sub
End Class