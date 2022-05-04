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
        Me.btnGuardarSerie = New System.Windows.Forms.Button()
        Me.txtTitulo = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNumeroSeries = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtCapacidad = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnVerInfo = New System.Windows.Forms.Button()
        Me.btnVolcarFichero = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnGuardarSerie
        '
        Me.btnGuardarSerie.Location = New System.Drawing.Point(94, 274)
        Me.btnGuardarSerie.Name = "btnGuardarSerie"
        Me.btnGuardarSerie.Size = New System.Drawing.Size(80, 40)
        Me.btnGuardarSerie.TabIndex = 0
        Me.btnGuardarSerie.Text = "Guardar Serie"
        Me.btnGuardarSerie.UseVisualStyleBackColor = True
        '
        'txtTitulo
        '
        Me.txtTitulo.Location = New System.Drawing.Point(94, 123)
        Me.txtTitulo.Name = "txtTitulo"
        Me.txtTitulo.Size = New System.Drawing.Size(127, 20)
        Me.txtTitulo.TabIndex = 1
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"HBO", "NETFLIX", "MOVISTAR", "DISNEY+", "PRIME VIDEO"})
        Me.ComboBox1.Location = New System.Drawing.Point(100, 198)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 2
        Me.ComboBox1.Text = "Plataforma"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(96, 90)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Titulo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(105, 167)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Plataforma"
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(365, 198)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(137, 199)
        Me.ListBox1.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(362, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Nº Series guardadas:"
        '
        'txtNumeroSeries
        '
        Me.txtNumeroSeries.Enabled = False
        Me.txtNumeroSeries.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumeroSeries.Location = New System.Drawing.Point(475, 29)
        Me.txtNumeroSeries.Name = "txtNumeroSeries"
        Me.txtNumeroSeries.Size = New System.Drawing.Size(59, 29)
        Me.txtNumeroSeries.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(362, 90)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(94, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Capacidad Actual:"
        '
        'txtCapacidad
        '
        Me.txtCapacidad.Enabled = False
        Me.txtCapacidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCapacidad.Location = New System.Drawing.Point(475, 79)
        Me.txtCapacidad.Name = "txtCapacidad"
        Me.txtCapacidad.Size = New System.Drawing.Size(59, 29)
        Me.txtCapacidad.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(367, 163)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(36, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Series"
        '
        'btnVerInfo
        '
        Me.btnVerInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVerInfo.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btnVerInfo.Location = New System.Drawing.Point(610, 197)
        Me.btnVerInfo.Name = "btnVerInfo"
        Me.btnVerInfo.Size = New System.Drawing.Size(104, 62)
        Me.btnVerInfo.TabIndex = 10
        Me.btnVerInfo.Text = "Ver info"
        Me.btnVerInfo.UseVisualStyleBackColor = True
        '
        'btnVolcarFichero
        '
        Me.btnVolcarFichero.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVolcarFichero.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btnVolcarFichero.Location = New System.Drawing.Point(552, 290)
        Me.btnVolcarFichero.Name = "btnVolcarFichero"
        Me.btnVolcarFichero.Size = New System.Drawing.Size(162, 62)
        Me.btnVolcarFichero.TabIndex = 10
        Me.btnVolcarFichero.Text = "Volcar a Ficheroo"
        Me.btnVolcarFichero.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnVolcarFichero)
        Me.Controls.Add(Me.btnVerInfo)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtCapacidad)
        Me.Controls.Add(Me.txtNumeroSeries)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.txtTitulo)
        Me.Controls.Add(Me.btnGuardarSerie)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnGuardarSerie As Button
    Friend WithEvents txtTitulo As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtNumeroSeries As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtCapacidad As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btnVerInfo As Button
    Friend WithEvents btnVolcarFichero As Button
End Class
