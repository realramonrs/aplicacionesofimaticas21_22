Public Class Ejercicio6
    Private Sub txtCentigrados_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCentigrados.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            Dim gradosCentigrados As Double = Convert.ToDouble(txtCentigrados.Text)

            Dim gradosFahrenheit As Double = ((gradosCentigrados * 9) / 5) + 32
            txtFahrenheit.Text = gradosFahrenheit.ToString
        End If
    End Sub
End Class