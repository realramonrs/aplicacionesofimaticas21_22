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
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.txtTitulo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblValoracion = New System.Windows.Forms.Label()
        Me.cmbPlataforma = New System.Windows.Forms.ComboBox()
        Me.btnAddSerie = New System.Windows.Forms.Button()
        Me.nudValoracion = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnLetraA = New System.Windows.Forms.Button()
        Me.btnLetraE = New System.Windows.Forms.Button()
        Me.btnLetraI = New System.Windows.Forms.Button()
        Me.btnLetraO = New System.Windows.Forms.Button()
        Me.btnLetraU = New System.Windows.Forms.Button()
        Me.btnBorrar = New System.Windows.Forms.Button()
        Me.txtBuscarSerie = New System.Windows.Forms.TextBox()
        Me.lblBuscador = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.Ejercicio1ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Ejercicio2ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.nudValoracion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.Location = New System.Drawing.Point(99, 56)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(50, 23)
        Me.lblTitulo.TabIndex = 0
        Me.lblTitulo.Text = "Titulo:"
        '
        'txtTitulo
        '
        Me.txtTitulo.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTitulo.Location = New System.Drawing.Point(188, 56)
        Me.txtTitulo.Name = "txtTitulo"
        Me.txtTitulo.Size = New System.Drawing.Size(149, 29)
        Me.txtTitulo.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(99, 111)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Plataforma"
        '
        'lblValoracion
        '
        Me.lblValoracion.AutoSize = True
        Me.lblValoracion.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblValoracion.Location = New System.Drawing.Point(99, 163)
        Me.lblValoracion.Name = "lblValoracion"
        Me.lblValoracion.Size = New System.Drawing.Size(85, 23)
        Me.lblValoracion.TabIndex = 0
        Me.lblValoracion.Text = "Valoracion"
        '
        'cmbPlataforma
        '
        Me.cmbPlataforma.FormattingEnabled = True
        Me.cmbPlataforma.Items.AddRange(New Object() {"Netflix", "HBO Max", "Filmin", "Amazon Prime", "Disney+", "Movistar"})
        Me.cmbPlataforma.Location = New System.Drawing.Point(188, 113)
        Me.cmbPlataforma.Name = "cmbPlataforma"
        Me.cmbPlataforma.Size = New System.Drawing.Size(121, 21)
        Me.cmbPlataforma.TabIndex = 2
        '
        'btnAddSerie
        '
        Me.btnAddSerie.Location = New System.Drawing.Point(111, 277)
        Me.btnAddSerie.Name = "btnAddSerie"
        Me.btnAddSerie.Size = New System.Drawing.Size(226, 38)
        Me.btnAddSerie.TabIndex = 3
        Me.btnAddSerie.Text = "Añadir serie"
        Me.btnAddSerie.UseVisualStyleBackColor = True
        '
        'nudValoracion
        '
        Me.nudValoracion.Location = New System.Drawing.Point(190, 166)
        Me.nudValoracion.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.nudValoracion.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudValoracion.Name = "nudValoracion"
        Me.nudValoracion.Size = New System.Drawing.Size(120, 20)
        Me.nudValoracion.TabIndex = 4
        Me.nudValoracion.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(525, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 24)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "TECLADO"
        '
        'btnLetraA
        '
        Me.btnLetraA.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLetraA.Location = New System.Drawing.Point(484, 94)
        Me.btnLetraA.Name = "btnLetraA"
        Me.btnLetraA.Size = New System.Drawing.Size(45, 40)
        Me.btnLetraA.TabIndex = 6
        Me.btnLetraA.Text = "A"
        Me.btnLetraA.UseVisualStyleBackColor = True
        '
        'btnLetraE
        '
        Me.btnLetraE.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLetraE.Location = New System.Drawing.Point(535, 94)
        Me.btnLetraE.Name = "btnLetraE"
        Me.btnLetraE.Size = New System.Drawing.Size(45, 40)
        Me.btnLetraE.TabIndex = 6
        Me.btnLetraE.Text = "E"
        Me.btnLetraE.UseVisualStyleBackColor = True
        '
        'btnLetraI
        '
        Me.btnLetraI.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLetraI.Location = New System.Drawing.Point(586, 94)
        Me.btnLetraI.Name = "btnLetraI"
        Me.btnLetraI.Size = New System.Drawing.Size(45, 40)
        Me.btnLetraI.TabIndex = 6
        Me.btnLetraI.Text = "I"
        Me.btnLetraI.UseVisualStyleBackColor = True
        '
        'btnLetraO
        '
        Me.btnLetraO.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLetraO.Location = New System.Drawing.Point(484, 146)
        Me.btnLetraO.Name = "btnLetraO"
        Me.btnLetraO.Size = New System.Drawing.Size(45, 40)
        Me.btnLetraO.TabIndex = 6
        Me.btnLetraO.Text = "O"
        Me.btnLetraO.UseVisualStyleBackColor = True
        '
        'btnLetraU
        '
        Me.btnLetraU.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLetraU.Location = New System.Drawing.Point(535, 146)
        Me.btnLetraU.Name = "btnLetraU"
        Me.btnLetraU.Size = New System.Drawing.Size(45, 40)
        Me.btnLetraU.TabIndex = 6
        Me.btnLetraU.Text = "U"
        Me.btnLetraU.UseVisualStyleBackColor = True
        '
        'btnBorrar
        '
        Me.btnBorrar.Location = New System.Drawing.Point(484, 204)
        Me.btnBorrar.Name = "btnBorrar"
        Me.btnBorrar.Size = New System.Drawing.Size(124, 33)
        Me.btnBorrar.TabIndex = 7
        Me.btnBorrar.Text = "Borrar"
        Me.btnBorrar.UseVisualStyleBackColor = True
        '
        'txtBuscarSerie
        '
        Me.txtBuscarSerie.Location = New System.Drawing.Point(529, 316)
        Me.txtBuscarSerie.Name = "txtBuscarSerie"
        Me.txtBuscarSerie.Size = New System.Drawing.Size(156, 20)
        Me.txtBuscarSerie.TabIndex = 8
        '
        'lblBuscador
        '
        Me.lblBuscador.AutoSize = True
        Me.lblBuscador.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBuscador.Location = New System.Drawing.Point(525, 277)
        Me.lblBuscador.Name = "lblBuscador"
        Me.lblBuscador.Size = New System.Drawing.Size(182, 24)
        Me.lblBuscador.TabIndex = 5
        Me.lblBuscador.Text = "BUSCADOR FAKE"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Ejercicio1ToolStripMenuItem, Me.Ejercicio2ToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 9
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'Ejercicio1ToolStripMenuItem
        '
        Me.Ejercicio1ToolStripMenuItem.Name = "Ejercicio1ToolStripMenuItem"
        Me.Ejercicio1ToolStripMenuItem.Size = New System.Drawing.Size(72, 20)
        Me.Ejercicio1ToolStripMenuItem.Text = "Ejercicio 1"
        '
        'Ejercicio2ToolStripMenuItem
        '
        Me.Ejercicio2ToolStripMenuItem.Name = "Ejercicio2ToolStripMenuItem"
        Me.Ejercicio2ToolStripMenuItem.Size = New System.Drawing.Size(72, 20)
        Me.Ejercicio2ToolStripMenuItem.Text = "Ejercicio 2"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txtBuscarSerie)
        Me.Controls.Add(Me.btnBorrar)
        Me.Controls.Add(Me.btnLetraU)
        Me.Controls.Add(Me.btnLetraO)
        Me.Controls.Add(Me.btnLetraI)
        Me.Controls.Add(Me.btnLetraE)
        Me.Controls.Add(Me.btnLetraA)
        Me.Controls.Add(Me.lblBuscador)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.nudValoracion)
        Me.Controls.Add(Me.btnAddSerie)
        Me.Controls.Add(Me.cmbPlataforma)
        Me.Controls.Add(Me.txtTitulo)
        Me.Controls.Add(Me.lblValoracion)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.nudValoracion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitulo As Label
    Friend WithEvents txtTitulo As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblValoracion As Label
    Friend WithEvents cmbPlataforma As ComboBox
    Friend WithEvents btnAddSerie As Button
    Friend WithEvents nudValoracion As NumericUpDown
    Friend WithEvents Label2 As Label
    Friend WithEvents btnLetraA As Button
    Friend WithEvents btnLetraE As Button
    Friend WithEvents btnLetraI As Button
    Friend WithEvents btnLetraO As Button
    Friend WithEvents btnLetraU As Button
    Friend WithEvents btnBorrar As Button
    Friend WithEvents txtBuscarSerie As TextBox
    Friend WithEvents lblBuscador As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents Ejercicio1ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Ejercicio2ToolStripMenuItem As ToolStripMenuItem
End Class
