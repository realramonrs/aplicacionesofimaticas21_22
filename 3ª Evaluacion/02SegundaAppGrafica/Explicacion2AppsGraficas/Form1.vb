Imports System.IO
Public Class Form1
    'Variable que almacena la ruta al fichero 
    Dim ruta As String
    Private Sub btnAddSerie_Click(sender As Object, e As EventArgs) Handles btnAddSerie.Click
        'Recoger datos de las cajas de texto
        Dim titulo As String = txtTitulo.Text
        Dim plataforma As String = cmbPlataforma.SelectedItem.ToString

        Dim valoracion As String = nudValoracion.Value.ToString

        'Crear un string con toda la info y el formato necesario para meterlo en un fichero
        Dim registro As String = titulo + "*" + plataforma + "*" + valoracion

        'Pasos para guardar datos en un fichero:
        '1. Definir la ruta al fichero
        ruta = Directory.GetCurrentDirectory() + "\InfoSeries.txt"
        '2. Crear variable de tipo StreamWriter
        Dim escritor As StreamWriter = New StreamWriter(ruta, True)
        escritor.WriteLine(registro)
        escritor.Close()
    End Sub

    Private Sub btnLetraA_Click(sender As Object, e As EventArgs) Handles btnLetraA.Click, btnLetraE.Click, btnLetraI.Click, btnLetraO.Click, btnLetraU.Click, btnBorrar.Click

        'Identificar el botón que ha sido pulsado
        Dim boton As Button = CType(sender, Button)
        If boton Is btnBorrar Then
            txtTitulo.Text = ""
        Else
            txtTitulo.Text += boton.Text
        End If

    End Sub

    Private Sub txtBuscarSerie_KeyDown(sender As Object, e As KeyEventArgs) Handles txtBuscarSerie.KeyDown

        If e.KeyCode = Keys.A Then
            MessageBox.Show("hOLAAAAAAAAAAAAAAA!!!")
        End If
    End Sub

    Private Sub txtTitulo_MouseEnter(sender As Object, e As EventArgs) Handles txtTitulo.MouseEnter
        txtTitulo.BackColor = Color.CornflowerBlue
    End Sub

    Private Sub txtTitulo_MouseLeave(sender As Object, e As EventArgs) Handles txtTitulo.MouseLeave
        txtTitulo.BackColor = Color.White
    End Sub

    Private Sub Ejercicio2ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Ejercicio2ToolStripMenuItem.Click
        Ejercicio2.ShowDialog()
    End Sub
End Class
