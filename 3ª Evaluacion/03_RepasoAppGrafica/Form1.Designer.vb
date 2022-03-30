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
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.lblUserName = New System.Windows.Forms.Label()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.btnGuardarUsuario = New System.Windows.Forms.Button()
        Me.lstListaUsuarios = New System.Windows.Forms.ListBox()
        Me.lblListaUsuarios = New System.Windows.Forms.Label()
        Me.dtpFechaNac = New System.Windows.Forms.DateTimePicker()
        Me.lblFechaNac = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtBusquedaUsername = New System.Windows.Forms.TextBox()
        Me.txtBusquedaPassword = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnBuscarusuario = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AbrirSegundoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtUsername
        '
        Me.txtUsername.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.Location = New System.Drawing.Point(173, 46)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(172, 26)
        Me.txtUsername.TabIndex = 0
        '
        'txtPassword
        '
        Me.txtPassword.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(173, 97)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(172, 26)
        Me.txtPassword.TabIndex = 1
        '
        'lblUserName
        '
        Me.lblUserName.AutoSize = True
        Me.lblUserName.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserName.Location = New System.Drawing.Point(65, 50)
        Me.lblUserName.Name = "lblUserName"
        Me.lblUserName.Size = New System.Drawing.Size(97, 22)
        Me.lblUserName.TabIndex = 1
        Me.lblUserName.Text = "Username"
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPassword.Location = New System.Drawing.Point(65, 97)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(94, 22)
        Me.lblPassword.TabIndex = 1
        Me.lblPassword.Text = "Password"
        '
        'btnGuardarUsuario
        '
        Me.btnGuardarUsuario.Location = New System.Drawing.Point(69, 217)
        Me.btnGuardarUsuario.Name = "btnGuardarUsuario"
        Me.btnGuardarUsuario.Size = New System.Drawing.Size(276, 46)
        Me.btnGuardarUsuario.TabIndex = 2
        Me.btnGuardarUsuario.Text = "Guardar Usuario"
        Me.btnGuardarUsuario.UseVisualStyleBackColor = True
        '
        'lstListaUsuarios
        '
        Me.lstListaUsuarios.FormattingEnabled = True
        Me.lstListaUsuarios.Location = New System.Drawing.Point(464, 73)
        Me.lstListaUsuarios.Name = "lstListaUsuarios"
        Me.lstListaUsuarios.Size = New System.Drawing.Size(165, 199)
        Me.lstListaUsuarios.TabIndex = 3
        '
        'lblListaUsuarios
        '
        Me.lblListaUsuarios.AutoSize = True
        Me.lblListaUsuarios.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblListaUsuarios.Location = New System.Drawing.Point(461, 46)
        Me.lblListaUsuarios.Name = "lblListaUsuarios"
        Me.lblListaUsuarios.Size = New System.Drawing.Size(137, 20)
        Me.lblListaUsuarios.TabIndex = 4
        Me.lblListaUsuarios.Text = "Usuarios Registrados"
        '
        'dtpFechaNac
        '
        Me.dtpFechaNac.Location = New System.Drawing.Point(236, 152)
        Me.dtpFechaNac.Name = "dtpFechaNac"
        Me.dtpFechaNac.Size = New System.Drawing.Size(200, 20)
        Me.dtpFechaNac.TabIndex = 5
        '
        'lblFechaNac
        '
        Me.lblFechaNac.AutoSize = True
        Me.lblFechaNac.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaNac.Location = New System.Drawing.Point(68, 151)
        Me.lblFechaNac.Name = "lblFechaNac"
        Me.lblFechaNac.Size = New System.Drawing.Size(162, 22)
        Me.lblFechaNac.TabIndex = 1
        Me.lblFechaNac.Text = "Fecha Nacimiento"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnBuscarusuario)
        Me.GroupBox1.Controls.Add(Me.txtBusquedaPassword)
        Me.GroupBox1.Controls.Add(Me.txtBusquedaUsername)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(70, 324)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(420, 114)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Consultas"
        '
        'txtBusquedaUsername
        '
        Me.txtBusquedaUsername.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBusquedaUsername.Location = New System.Drawing.Point(133, 31)
        Me.txtBusquedaUsername.Name = "txtBusquedaUsername"
        Me.txtBusquedaUsername.Size = New System.Drawing.Size(172, 26)
        Me.txtBusquedaUsername.TabIndex = 0
        '
        'txtBusquedaPassword
        '
        Me.txtBusquedaPassword.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBusquedaPassword.Location = New System.Drawing.Point(133, 82)
        Me.txtBusquedaPassword.Name = "txtBusquedaPassword"
        Me.txtBusquedaPassword.Size = New System.Drawing.Size(172, 26)
        Me.txtBusquedaPassword.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(25, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 22)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Username"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(25, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 22)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Password"
        '
        'btnBuscarusuario
        '
        Me.btnBuscarusuario.BackgroundImage = Global._03_RepasoAppGrafica.My.Resources.Resources.Logo_FP_Con_texto_abajo
        Me.btnBuscarusuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnBuscarusuario.Location = New System.Drawing.Point(311, 40)
        Me.btnBuscarusuario.Name = "btnBuscarusuario"
        Me.btnBuscarusuario.Size = New System.Drawing.Size(104, 64)
        Me.btnBuscarusuario.TabIndex = 2
        Me.btnBuscarusuario.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AbrirSegundoToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 7
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AbrirSegundoToolStripMenuItem
        '
        Me.AbrirSegundoToolStripMenuItem.Name = "AbrirSegundoToolStripMenuItem"
        Me.AbrirSegundoToolStripMenuItem.Size = New System.Drawing.Size(95, 20)
        Me.AbrirSegundoToolStripMenuItem.Text = "Abrir Segundo"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dtpFechaNac)
        Me.Controls.Add(Me.lblListaUsuarios)
        Me.Controls.Add(Me.lstListaUsuarios)
        Me.Controls.Add(Me.btnGuardarUsuario)
        Me.Controls.Add(Me.lblFechaNac)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.lblUserName)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents lblUserName As Label
    Friend WithEvents lblPassword As Label
    Friend WithEvents btnGuardarUsuario As Button
    Friend WithEvents lstListaUsuarios As ListBox
    Friend WithEvents lblListaUsuarios As Label
    Friend WithEvents dtpFechaNac As DateTimePicker
    Friend WithEvents lblFechaNac As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnBuscarusuario As Button
    Friend WithEvents txtBusquedaPassword As TextBox
    Friend WithEvents txtBusquedaUsername As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents AbrirSegundoToolStripMenuItem As ToolStripMenuItem
End Class
