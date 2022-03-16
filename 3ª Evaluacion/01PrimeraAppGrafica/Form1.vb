Public Class Form1

    'Zona declaracion variables.
    Dim nombre As String

    Private Sub btnSaludar_Click(sender As Object, e As EventArgs) Handles btnSaludar.Click
        'Codigo que se ejecuta cuando se pulsa el botón Bienvenido
        'Cambiamos el color de fondo, para indicar que ha sido pulsado
        btnSaludar.BackColor = Color.CornflowerBlue
        'Cambiar el texto:
        btnSaludar.Text = "Has pulsado el botón"


        'Validar que el usuario introdujo un texto, no dejó la caja vacía
        If txtNombre.Text = "" Then
            MessageBox.Show("Debe de introducir su nombre.")
            Me.ActiveControl = txtNombre
        Else
            'Recoger lo que el usuario introdujo en la caja txtNombre
            nombre = txtNombre.Text
            'Mandar un mensaje
            MessageBox.Show("Bienvenido al apasionante mundo de Gumbal Mr/Mss " & nombre)
        End If

    End Sub

    Private Sub EJERCICIO1ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EJERCICIO1ToolStripMenuItem.Click
        'Abrir el formulario del Ejercicio 1
        Ejercicio1.ShowDialog()
    End Sub
End Class
