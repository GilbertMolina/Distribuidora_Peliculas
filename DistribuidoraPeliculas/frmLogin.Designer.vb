<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        Me.grpBoxInicioSesion = New System.Windows.Forms.GroupBox()
        Me.btSalir = New System.Windows.Forms.Button()
        Me.btIngresar = New System.Windows.Forms.Button()
        Me.txtContrasenna = New System.Windows.Forms.TextBox()
        Me.txtNombreUsuario = New System.Windows.Forms.TextBox()
        Me.lbContrasenna = New System.Windows.Forms.Label()
        Me.lbNombreUsuario = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.grpBoxInicioSesion.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpBoxInicioSesion
        '
        Me.grpBoxInicioSesion.Controls.Add(Me.btSalir)
        Me.grpBoxInicioSesion.Controls.Add(Me.btIngresar)
        Me.grpBoxInicioSesion.Controls.Add(Me.txtContrasenna)
        Me.grpBoxInicioSesion.Controls.Add(Me.txtNombreUsuario)
        Me.grpBoxInicioSesion.Controls.Add(Me.lbContrasenna)
        Me.grpBoxInicioSesion.Controls.Add(Me.lbNombreUsuario)
        Me.grpBoxInicioSesion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpBoxInicioSesion.Location = New System.Drawing.Point(226, 56)
        Me.grpBoxInicioSesion.Name = "grpBoxInicioSesion"
        Me.grpBoxInicioSesion.Size = New System.Drawing.Size(412, 208)
        Me.grpBoxInicioSesion.TabIndex = 1
        Me.grpBoxInicioSesion.TabStop = False
        Me.grpBoxInicioSesion.Text = "Inicio de sesión"
        '
        'btSalir
        '
        Me.btSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btSalir.Image = Global.GUI.My.Resources.Resources._exit
        Me.btSalir.Location = New System.Drawing.Point(154, 126)
        Me.btSalir.Name = "btSalir"
        Me.btSalir.Size = New System.Drawing.Size(99, 40)
        Me.btSalir.TabIndex = 4
        Me.btSalir.Text = "Salir"
        Me.btSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btSalir.UseVisualStyleBackColor = True
        '
        'btIngresar
        '
        Me.btIngresar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btIngresar.Image = Global.GUI.My.Resources.Resources.sign_in
        Me.btIngresar.Location = New System.Drawing.Point(283, 126)
        Me.btIngresar.Name = "btIngresar"
        Me.btIngresar.Size = New System.Drawing.Size(99, 41)
        Me.btIngresar.TabIndex = 3
        Me.btIngresar.Text = "Ingresar"
        Me.btIngresar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btIngresar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btIngresar.UseVisualStyleBackColor = True
        '
        'txtContrasenna
        '
        Me.txtContrasenna.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContrasenna.Location = New System.Drawing.Point(154, 92)
        Me.txtContrasenna.MaxLength = 15
        Me.txtContrasenna.Name = "txtContrasenna"
        Me.txtContrasenna.Size = New System.Drawing.Size(228, 22)
        Me.txtContrasenna.TabIndex = 2
        Me.txtContrasenna.UseSystemPasswordChar = True
        '
        'txtNombreUsuario
        '
        Me.txtNombreUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombreUsuario.Location = New System.Drawing.Point(154, 54)
        Me.txtNombreUsuario.MaxLength = 10
        Me.txtNombreUsuario.Name = "txtNombreUsuario"
        Me.txtNombreUsuario.Size = New System.Drawing.Size(228, 22)
        Me.txtNombreUsuario.TabIndex = 1
        '
        'lbContrasenna
        '
        Me.lbContrasenna.AutoSize = True
        Me.lbContrasenna.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbContrasenna.Location = New System.Drawing.Point(67, 95)
        Me.lbContrasenna.Name = "lbContrasenna"
        Me.lbContrasenna.Size = New System.Drawing.Size(80, 16)
        Me.lbContrasenna.TabIndex = 1
        Me.lbContrasenna.Text = "Contraseña:"
        '
        'lbNombreUsuario
        '
        Me.lbNombreUsuario.AutoSize = True
        Me.lbNombreUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbNombreUsuario.Location = New System.Drawing.Point(21, 54)
        Me.lbNombreUsuario.Name = "lbNombreUsuario"
        Me.lbNombreUsuario.Size = New System.Drawing.Size(126, 16)
        Me.lbNombreUsuario.TabIndex = 0
        Me.lbNombreUsuario.Text = "Nombre de usuario:"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.GUI.My.Resources.Resources.UIA_Login
        Me.PictureBox1.Location = New System.Drawing.Point(27, 63)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(178, 195)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(666, 330)
        Me.Controls.Add(Me.grpBoxInicioSesion)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inicio de sesión"
        Me.grpBoxInicioSesion.ResumeLayout(False)
        Me.grpBoxInicioSesion.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents grpBoxInicioSesion As System.Windows.Forms.GroupBox
    Friend WithEvents btIngresar As System.Windows.Forms.Button
    Friend WithEvents txtContrasenna As System.Windows.Forms.TextBox
    Friend WithEvents txtNombreUsuario As System.Windows.Forms.TextBox
    Friend WithEvents lbContrasenna As System.Windows.Forms.Label
    Friend WithEvents lbNombreUsuario As System.Windows.Forms.Label
    Friend WithEvents btSalir As System.Windows.Forms.Button

End Class
