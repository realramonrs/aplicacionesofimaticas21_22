<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.btnAddSerie = New System.Windows.Forms.Button()
        Me.txtAddSerie = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnBorrarSerie = New System.Windows.Forms.Button()
        Me.btnBuscarSerie = New System.Windows.Forms.Button()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.rdbEquipo1 = New System.Windows.Forms.RadioButton()
        Me.rdbEquipo2 = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnSeleccionarEquipo = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Items.AddRange(New Object() {"Better Call Saul", "Breaking Bad", "Ozark", "Stranger Things", "Ricky Morty"})
        Me.ListBox1.Location = New System.Drawing.Point(31, 32)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(120, 134)
        Me.ListBox1.TabIndex = 0
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Steven Spielberg", "Martin Scorsese", "Robert Zemeckys", "Woody Allen"})
        Me.ComboBox1.Location = New System.Drawing.Point(221, 32)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 1
        '
        'btnAddSerie
        '
        Me.btnAddSerie.Location = New System.Drawing.Point(81, 327)
        Me.btnAddSerie.Name = "btnAddSerie"
        Me.btnAddSerie.Size = New System.Drawing.Size(124, 23)
        Me.btnAddSerie.TabIndex = 2
        Me.btnAddSerie.Text = "Añadir Serie"
        Me.btnAddSerie.UseVisualStyleBackColor = True
        '
        'txtAddSerie
        '
        Me.txtAddSerie.Location = New System.Drawing.Point(81, 278)
        Me.txtAddSerie.Name = "txtAddSerie"
        Me.txtAddSerie.Size = New System.Drawing.Size(121, 20)
        Me.txtAddSerie.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(78, 249)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Introduce Nombre Serie"
        '
        'btnBorrarSerie
        '
        Me.btnBorrarSerie.Location = New System.Drawing.Point(253, 327)
        Me.btnBorrarSerie.Name = "btnBorrarSerie"
        Me.btnBorrarSerie.Size = New System.Drawing.Size(109, 23)
        Me.btnBorrarSerie.TabIndex = 5
        Me.btnBorrarSerie.Text = "Borrar Serie"
        Me.btnBorrarSerie.UseVisualStyleBackColor = True
        '
        'btnBuscarSerie
        '
        Me.btnBuscarSerie.Location = New System.Drawing.Point(82, 382)
        Me.btnBuscarSerie.Name = "btnBuscarSerie"
        Me.btnBuscarSerie.Size = New System.Drawing.Size(115, 30)
        Me.btnBuscarSerie.TabIndex = 6
        Me.btnBuscarSerie.Text = "Buscar Serie"
        Me.btnBuscarSerie.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(545, 47)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(90, 17)
        Me.RadioButton1.TabIndex = 7
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "RadioButton1"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(545, 85)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(90, 17)
        Me.RadioButton2.TabIndex = 8
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "RadioButton2"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'rdbEquipo1
        '
        Me.rdbEquipo1.AutoSize = True
        Me.rdbEquipo1.Location = New System.Drawing.Point(20, 28)
        Me.rdbEquipo1.Name = "rdbEquipo1"
        Me.rdbEquipo1.Size = New System.Drawing.Size(82, 17)
        Me.rdbEquipo1.TabIndex = 9
        Me.rdbEquipo1.TabStop = True
        Me.rdbEquipo1.Text = "Real Madrid"
        Me.rdbEquipo1.UseVisualStyleBackColor = True
        '
        'rdbEquipo2
        '
        Me.rdbEquipo2.AutoSize = True
        Me.rdbEquipo2.Location = New System.Drawing.Point(20, 62)
        Me.rdbEquipo2.Name = "rdbEquipo2"
        Me.rdbEquipo2.Size = New System.Drawing.Size(66, 17)
        Me.rdbEquipo2.TabIndex = 10
        Me.rdbEquipo2.TabStop = True
        Me.rdbEquipo2.Text = "Rc Celta"
        Me.rdbEquipo2.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rdbEquipo1)
        Me.GroupBox1.Controls.Add(Me.rdbEquipo2)
        Me.GroupBox1.Location = New System.Drawing.Point(536, 162)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Equipo"
        '
        'btnSeleccionarEquipo
        '
        Me.btnSeleccionarEquipo.Location = New System.Drawing.Point(553, 302)
        Me.btnSeleccionarEquipo.Name = "btnSeleccionarEquipo"
        Me.btnSeleccionarEquipo.Size = New System.Drawing.Size(117, 48)
        Me.btnSeleccionarEquipo.TabIndex = 12
        Me.btnSeleccionarEquipo.Text = "Seleccionar Equipo"
        Me.btnSeleccionarEquipo.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnSeleccionarEquipo)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.btnBuscarSerie)
        Me.Controls.Add(Me.btnBorrarSerie)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtAddSerie)
        Me.Controls.Add(Me.btnAddSerie)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.ListBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents btnAddSerie As Button
    Friend WithEvents txtAddSerie As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnBorrarSerie As Button
    Friend WithEvents btnBuscarSerie As Button
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents rdbEquipo1 As RadioButton
    Friend WithEvents rdbEquipo2 As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnSeleccionarEquipo As Button
End Class
