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
        Me.btnUno = New System.Windows.Forms.Button()
        Me.btnDos = New System.Windows.Forms.Button()
        Me.btnTres = New System.Windows.Forms.Button()
        Me.txtResultado = New System.Windows.Forms.TextBox()
        Me.btnMas = New System.Windows.Forms.Button()
        Me.btnMenos = New System.Windows.Forms.Button()
        Me.btnMultiplicar = New System.Windows.Forms.Button()
        Me.btnIgual = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnUno
        '
        Me.btnUno.Location = New System.Drawing.Point(78, 116)
        Me.btnUno.Name = "btnUno"
        Me.btnUno.Size = New System.Drawing.Size(75, 23)
        Me.btnUno.TabIndex = 0
        Me.btnUno.Text = "1"
        Me.btnUno.UseVisualStyleBackColor = True
        '
        'btnDos
        '
        Me.btnDos.Location = New System.Drawing.Point(159, 116)
        Me.btnDos.Name = "btnDos"
        Me.btnDos.Size = New System.Drawing.Size(75, 23)
        Me.btnDos.TabIndex = 0
        Me.btnDos.Text = "2"
        Me.btnDos.UseVisualStyleBackColor = True
        '
        'btnTres
        '
        Me.btnTres.Location = New System.Drawing.Point(240, 116)
        Me.btnTres.Name = "btnTres"
        Me.btnTres.Size = New System.Drawing.Size(75, 23)
        Me.btnTres.TabIndex = 0
        Me.btnTres.Text = "3"
        Me.btnTres.UseVisualStyleBackColor = True
        '
        'txtResultado
        '
        Me.txtResultado.Location = New System.Drawing.Point(81, 88)
        Me.txtResultado.Name = "txtResultado"
        Me.txtResultado.Size = New System.Drawing.Size(234, 20)
        Me.txtResultado.TabIndex = 1
        '
        'btnMas
        '
        Me.btnMas.Location = New System.Drawing.Point(78, 172)
        Me.btnMas.Name = "btnMas"
        Me.btnMas.Size = New System.Drawing.Size(75, 23)
        Me.btnMas.TabIndex = 2
        Me.btnMas.Text = "+"
        Me.btnMas.UseVisualStyleBackColor = True
        '
        'btnMenos
        '
        Me.btnMenos.Location = New System.Drawing.Point(159, 172)
        Me.btnMenos.Name = "btnMenos"
        Me.btnMenos.Size = New System.Drawing.Size(75, 23)
        Me.btnMenos.TabIndex = 2
        Me.btnMenos.Text = "-"
        Me.btnMenos.UseVisualStyleBackColor = True
        '
        'btnMultiplicar
        '
        Me.btnMultiplicar.Location = New System.Drawing.Point(240, 172)
        Me.btnMultiplicar.Name = "btnMultiplicar"
        Me.btnMultiplicar.Size = New System.Drawing.Size(75, 23)
        Me.btnMultiplicar.TabIndex = 2
        Me.btnMultiplicar.Text = "*"
        Me.btnMultiplicar.UseVisualStyleBackColor = True
        '
        'btnIgual
        '
        Me.btnIgual.Location = New System.Drawing.Point(78, 230)
        Me.btnIgual.Name = "btnIgual"
        Me.btnIgual.Size = New System.Drawing.Size(75, 23)
        Me.btnIgual.TabIndex = 2
        Me.btnIgual.Text = "="
        Me.btnIgual.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnIgual)
        Me.Controls.Add(Me.btnMultiplicar)
        Me.Controls.Add(Me.btnMenos)
        Me.Controls.Add(Me.btnMas)
        Me.Controls.Add(Me.txtResultado)
        Me.Controls.Add(Me.btnTres)
        Me.Controls.Add(Me.btnDos)
        Me.Controls.Add(Me.btnUno)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnUno As Button
    Friend WithEvents btnDos As Button
    Friend WithEvents btnTres As Button
    Friend WithEvents txtResultado As TextBox
    Friend WithEvents btnMas As Button
    Friend WithEvents btnMenos As Button
    Friend WithEvents btnMultiplicar As Button
    Friend WithEvents btnIgual As Button
End Class
