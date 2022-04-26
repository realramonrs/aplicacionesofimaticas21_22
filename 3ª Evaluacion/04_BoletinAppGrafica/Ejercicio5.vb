Public Class Ejercicio5
    Private Sub btnMas_Click(sender As Object, e As EventArgs) Handles btnMas.Click
        Dim operando1 As Integer = Convert.ToInt32(txtOperando1.Text)
        Dim operando2 As Integer = Convert.ToInt32(txtOperando2.Text)
        lblSigno.Text = "+"
        Dim resultado As Integer = operando1 + operando2
        txtResultado.Text = resultado.ToString()
    End Sub
End Class