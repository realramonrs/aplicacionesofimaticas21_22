<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ejercicio2
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtDia = New System.Windows.Forms.TextBox()
        Me.txtMes = New System.Windows.Forms.TextBox()
        Me.txtAnho = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblFechaCompleta = New System.Windows.Forms.Label()
        Me.btnConvertir = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(73, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(170, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "LIntroduce la fecha:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(73, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(23, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Dia"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(73, 130)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(30, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Mes:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(73, 170)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(29, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Año:"
        '
        'txtDia
        '
        Me.txtDia.Location = New System.Drawing.Point(115, 97)
        Me.txtDia.Name = "txtDia"
        Me.txtDia.Size = New System.Drawing.Size(100, 20)
        Me.txtDia.TabIndex = 2
        '
        'txtMes
        '
        Me.txtMes.Location = New System.Drawing.Point(115, 130)
        Me.txtMes.Name = "txtMes"
        Me.txtMes.Size = New System.Drawing.Size(100, 20)
        Me.txtMes.TabIndex = 2
        '
        'txtAnho
        '
        Me.txtAnho.Location = New System.Drawing.Point(115, 167)
        Me.txtAnho.Name = "txtAnho"
        Me.txtAnho.Size = New System.Drawing.Size(100, 20)
        Me.txtAnho.TabIndex = 2
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblFechaCompleta)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(90, 253)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(376, 98)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "La fecha es:"
        '
        'lblFechaCompleta
        '
        Me.lblFechaCompleta.AutoSize = True
        Me.lblFechaCompleta.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblFechaCompleta.Location = New System.Drawing.Point(44, 44)
        Me.lblFechaCompleta.Name = "lblFechaCompleta"
        Me.lblFechaCompleta.Size = New System.Drawing.Size(24, 20)
        Me.lblFechaCompleta.TabIndex = 0
        Me.lblFechaCompleta.Text = "..."
        '
        'btnConvertir
        '
        Me.btnConvertir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConvertir.Location = New System.Drawing.Point(255, 97)
        Me.btnConvertir.Name = "btnConvertir"
        Me.btnConvertir.Size = New System.Drawing.Size(115, 32)
        Me.btnConvertir.TabIndex = 4
        Me.btnConvertir.Text = "Convertir"
        Me.btnConvertir.UseVisualStyleBackColor = True
        '
        'Ejercicio2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnConvertir)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtAnho)
        Me.Controls.Add(Me.txtMes)
        Me.Controls.Add(Me.txtDia)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Ejercicio2"
        Me.Text = "Ejercicio2"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtDia As TextBox
    Friend WithEvents txtMes As TextBox
    Friend WithEvents txtAnho As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblFechaCompleta As Label
    Friend WithEvents btnConvertir As Button
End Class
