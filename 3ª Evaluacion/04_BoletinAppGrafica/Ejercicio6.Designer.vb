<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ejercicio6
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
        Me.txtCentigrados = New System.Windows.Forms.TextBox()
        Me.txtFahrenheit = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtCentigrados
        '
        Me.txtCentigrados.Location = New System.Drawing.Point(187, 142)
        Me.txtCentigrados.Name = "txtCentigrados"
        Me.txtCentigrados.Size = New System.Drawing.Size(127, 20)
        Me.txtCentigrados.TabIndex = 0
        '
        'txtFahrenheit
        '
        Me.txtFahrenheit.Location = New System.Drawing.Point(187, 224)
        Me.txtFahrenheit.Name = "txtFahrenheit"
        Me.txtFahrenheit.Size = New System.Drawing.Size(127, 20)
        Me.txtFahrenheit.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(191, 111)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(160, 18)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Grados Centígrados"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(191, 190)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(148, 18)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Grados Fahrenheit"
        '
        'Ejercicio6
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtFahrenheit)
        Me.Controls.Add(Me.txtCentigrados)
        Me.Name = "Ejercicio6"
        Me.Text = "Ejercicio6"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtCentigrados As TextBox
    Friend WithEvents txtFahrenheit As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
