<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Ejercicio5
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.txtOperando1 = New System.Windows.Forms.TextBox()
        Me.txtOperando2 = New System.Windows.Forms.TextBox()
        Me.lblSigno = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnMas = New System.Windows.Forms.Button()
        Me.btnMenos = New System.Windows.Forms.Button()
        Me.btnPor = New System.Windows.Forms.Button()
        Me.btnDivision = New System.Windows.Forms.Button()
        Me.txtResultado = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txtOperando1
        '
        Me.txtOperando1.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOperando1.Location = New System.Drawing.Point(132, 111)
        Me.txtOperando1.Name = "txtOperando1"
        Me.txtOperando1.Size = New System.Drawing.Size(71, 62)
        Me.txtOperando1.TabIndex = 0
        '
        'txtOperando2
        '
        Me.txtOperando2.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOperando2.Location = New System.Drawing.Point(294, 111)
        Me.txtOperando2.Name = "txtOperando2"
        Me.txtOperando2.Size = New System.Drawing.Size(70, 62)
        Me.txtOperando2.TabIndex = 1
        '
        'lblSigno
        '
        Me.lblSigno.AutoSize = True
        Me.lblSigno.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSigno.Location = New System.Drawing.Point(230, 126)
        Me.lblSigno.Name = "lblSigno"
        Me.lblSigno.Size = New System.Drawing.Size(30, 25)
        Me.lblSigno.TabIndex = 2
        Me.lblSigno.Text = "..."
        Me.lblSigno.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(397, 126)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(24, 25)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "="
        '
        'btnMas
        '
        Me.btnMas.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMas.Location = New System.Drawing.Point(111, 219)
        Me.btnMas.Name = "btnMas"
        Me.btnMas.Size = New System.Drawing.Size(73, 49)
        Me.btnMas.TabIndex = 3
        Me.btnMas.Text = "+"
        Me.btnMas.UseVisualStyleBackColor = True
        '
        'btnMenos
        '
        Me.btnMenos.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMenos.Location = New System.Drawing.Point(190, 219)
        Me.btnMenos.Name = "btnMenos"
        Me.btnMenos.Size = New System.Drawing.Size(73, 49)
        Me.btnMenos.TabIndex = 3
        Me.btnMenos.Text = "-"
        Me.btnMenos.UseVisualStyleBackColor = True
        '
        'btnPor
        '
        Me.btnPor.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPor.Location = New System.Drawing.Point(269, 219)
        Me.btnPor.Name = "btnPor"
        Me.btnPor.Size = New System.Drawing.Size(73, 49)
        Me.btnPor.TabIndex = 3
        Me.btnPor.Text = "x"
        Me.btnPor.UseVisualStyleBackColor = True
        '
        'btnDivision
        '
        Me.btnDivision.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDivision.Location = New System.Drawing.Point(348, 219)
        Me.btnDivision.Name = "btnDivision"
        Me.btnDivision.Size = New System.Drawing.Size(73, 49)
        Me.btnDivision.TabIndex = 3
        Me.btnDivision.Text = "\"
        Me.btnDivision.UseVisualStyleBackColor = True
        '
        'txtResultado
        '
        Me.txtResultado.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtResultado.Location = New System.Drawing.Point(452, 111)
        Me.txtResultado.Name = "txtResultado"
        Me.txtResultado.Size = New System.Drawing.Size(128, 62)
        Me.txtResultado.TabIndex = 2
        '
        'Ejercicio5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnDivision)
        Me.Controls.Add(Me.btnPor)
        Me.Controls.Add(Me.btnMenos)
        Me.Controls.Add(Me.btnMas)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblSigno)
        Me.Controls.Add(Me.txtResultado)
        Me.Controls.Add(Me.txtOperando2)
        Me.Controls.Add(Me.txtOperando1)
        Me.Name = "Ejercicio5"
        Me.Text = "Ejercicio5"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtOperando1 As TextBox
    Friend WithEvents txtOperando2 As TextBox
    Friend WithEvents lblSigno As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnMas As Button
    Friend WithEvents btnMenos As Button
    Friend WithEvents btnPor As Button
    Friend WithEvents btnDivision As Button
    Friend WithEvents txtResultado As TextBox
End Class
