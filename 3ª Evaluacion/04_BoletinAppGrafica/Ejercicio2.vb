Public Class Ejercicio2
    Private Sub btnConvertir_Click(sender As Object, e As EventArgs) Handles btnConvertir.Click
        Dim dia As Integer = txtDia.Text
        Dim mes As Integer = txtMes.Text
        Dim anho As Integer = txtAnho.Text

        Dim fecha As String = dia.ToString + " de "

        Select Case mes
            Case 1
                fecha += "Enero "
            Case 2
                fecha += "Febrero "
            Case 3
                fecha += "Marzo "
        End Select

        fecha += " de " + anho.ToString()

        lblFechaCompleta.Text = fecha
    End Sub
End Class