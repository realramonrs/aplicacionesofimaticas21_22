Imports System.IO
Public Class Form1
    'Zona declaración variables globales
    Dim registros(99) As String

    Dim ruta As String = Directory.GetCurrentDirectory() + "\usuarios.txt"
    Private Sub btnGuardarUsuario_Click(sender As Object, e As EventArgs) Handles btnGuardarUsuario.Click
        'Recoger los datos de las cajas de texto
        Dim username, password, fechaNacimiento, fechaCreacion As String
        Dim datosCorrectos As Boolean = True
        If txtUsername.Text <> "" Then
            username = txtUsername.Text
        Else
            datosCorrectos = False
            MessageBox.Show("Debe introducir un nombre de usuario")
        End If

        If txtPassword.Text <> "" Then

            password = txtPassword.Text
        Else
            datosCorrectos = False
            MessageBox.Show("Debe introducir un password")
        End If

        fechaNacimiento = dtpFechaNac.Value.ToShortDateString
        fechaCreacion = Date.Now.ToString
        'Si están correctos guardarlos en un fichero
        If datosCorrectos = True Then
            Dim escritor As StreamWriter = New StreamWriter(ruta, True)
            'Creo el string que quiero guardar
            Dim registro As String = username + "*" + password + "*" + fechaNacimiento + "*" + fechaCreacion
            escritor.WriteLine(registro)
            escritor.Close()
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Volcar los registros a la matriz de Strings..
        '1. Crear un lector
        Dim lector As StreamReader = New StreamReader(ruta)
        Dim posicion As Integer
        While Not lector.EndOfStream
            registros(posicion) = lector.ReadLine()
            posicion += 1
        End While
        lector.Close()

        'Volcar a un listbox los registros del fichero
        For Each reg As String In registros
            If Not reg Is Nothing Then
                lstListaUsuarios.Items.Add(reg.Split("*")(0))
            Else
                Exit For
            End If
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnBuscarusuario.Click
        txtBusquedaPassword.Text = ""
        Dim username As String = txtBusquedaUsername.Text
        Dim encontrado As Boolean = False
        'Recorro la matriz para buscar
        For Each registro As String In registros
            If registro Is Nothing Then
                Exit For
            Else
                Dim trozos() As String = registro.Split("*")
                If trozos(0) = username Then
                    txtBusquedaPassword.Text = trozos(1)
                    encontrado = True
                    Exit For
                End If
            End If

        Next

        If Not encontrado Then
            MessageBox.Show("Usuario no existe")
        End If





    End Sub

    Private Sub AbrirSegundoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AbrirSegundoToolStripMenuItem.Click
        Segundo.ShowDialog()
    End Sub
End Class
