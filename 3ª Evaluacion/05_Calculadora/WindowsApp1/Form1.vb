Public Class Form1
    Dim operando1, operando2, resultado As Double
    Dim operacion As Char

    Private Sub btnIgual_Click(sender As Object, e As EventArgs) Handles btnIgual.Click
        operando2 = Convert.ToDouble(txtResultado.Text)

        Select Case operacion
            Case "+"c
                resultado = operando1 + operando2
            Case "-"c
                resultado = operando1 - operando2
            Case "*"
                resultado = operando1 * operando2
        End Select
        txtResultado.Text = resultado.ToString
    End Sub

    Private Sub btnMas_Click(sender As Object, e As EventArgs) Handles btnMas.Click, btnMenos.Click, btnMultiplicar.Click
        operando1 = Convert.ToDouble(txtResultado.Text)

        Dim b As Button = CType(sender, Button)

        If b Is btnMas Then
            operacion = "+"c
        ElseIf b Is btnMenos Then
            operacion = "-"c
        ElseIf b Is btnMultiplicar Then
            operacion = "*"c
        End If


        txtResultado.Text = ""

    End Sub

    Private Sub btnUno_Click(sender As Object, e As EventArgs) Handles btnUno.Click, btnDos.Click, btnTres.Click

        Dim b As Button = CType(sender, Button)
        txtResultado.Text += b.Text

    End Sub
End Class
