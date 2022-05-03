Public Class Form1
    Private Sub btnAddSerie_Click(sender As Object, e As EventArgs) Handles btnAddSerie.Click
        Dim titulo As String = txtAddSerie.Text
        'Añadirlo al listbox
        ListBox1.Items.Add(titulo)
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        'Obtener el texto seleccionado
        'Dim elemento As String = ListBox1.SelectedItem.ToString()
        'Dim indice As Integer = ListBox1.SelectedIndex
        'Dim respuesta As DialogResult = MessageBox.Show(elemento, "Cuidado!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)

        'If respuesta = DialogResult.Yes Then
        '    MessageBox.Show("Posicion: " & indice)
        'Else
        '    MessageBox.Show("De acuerdo")
        'End If

    End Sub

    Private Sub btnBorrarSerie_Click(sender As Object, e As EventArgs) Handles btnBorrarSerie.Click
        '  Dim titulo As String = ListBox1.SelectedItem.ToString
        If ListBox1.SelectedItem = Nothing Then
            MessageBox.Show("Debe seleccionar un elemento de la lista")
        Else
            Dim respuesta As DialogResult = MessageBox.Show("Está seguro", "Cuidado", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If respuesta = DialogResult.Yes Then
                ListBox1.Items.Remove(ListBox1.SelectedItem)
            End If

        End If

    End Sub

    Private Sub btnBuscarSerie_Click(sender As Object, e As EventArgs) Handles btnBuscarSerie.Click
        Dim titulo As String = txtAddSerie.Text
        Dim encontrado As Boolean = False
        'Buscar en el listbox
        'Forma 1
        For i As Integer = 0 To ListBox1.Items.Count - 1 Step 1
            If ListBox1.Items(i).ToString = titulo Then

            End If
        Next
        'Forma 2
        For Each elemento As String In ListBox1.Items
            If elemento = titulo Then
                MessageBox.Show("Encontrado!!")
                encontrado = True
            End If
        Next

        If Not encontrado Then
            MessageBox.Show("No encontrado")
        End If

        'Forma 3
        Dim posicion As Integer = ListBox1.Items.IndexOf(titulo)
        MessageBox.Show(posicion + 1)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.SelectedText = ListBox1.Items(0).ToString()
    End Sub

    Private Sub rdbEquipo2_CheckedChanged(sender As Object, e As EventArgs) Handles rdbEquipo2.CheckedChanged
        If rdbEquipo2.Checked Then
            MessageBox.Show("Hala Celta")
        End If
    End Sub

    Private Sub rdbEquipo1_CheckedChanged(sender As Object, e As EventArgs) Handles rdbEquipo1.CheckedChanged
        If rdbEquipo1.Checked Then
            MessageBox.Show("Campeones de Liga 2022")
        End If
    End Sub

    Private Sub btnSeleccionarEquipo_Click(sender As Object, e As EventArgs) Handles btnSeleccionarEquipo.Click
        If rdbEquipo1.Checked = False And rdbEquipo2.Checked = False Then
            MessageBox.Show("Debe seleccionar un equipo.")
        End If
    End Sub
End Class
