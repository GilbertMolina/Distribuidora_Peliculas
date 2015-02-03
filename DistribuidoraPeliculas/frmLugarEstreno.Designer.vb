<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLugarEstreno
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLugarEstreno))
        Me.Panel13 = New System.Windows.Forms.Panel()
        Me.lblPublicados = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtIdLugar = New System.Windows.Forms.TextBox()
        Me.lbIdDirector = New System.Windows.Forms.Label()
        Me.dgv_LugaresEstreno = New System.Windows.Forms.DataGridView()
        Me.txtIdPelicula = New System.Windows.Forms.TextBox()
        Me.lbNombreLugar = New System.Windows.Forms.Label()
        Me.btBuscarPelicula = New System.Windows.Forms.Button()
        Me.btModificar = New System.Windows.Forms.Button()
        Me.limpiar = New System.Windows.Forms.Button()
        Me.btBuscarLugar = New System.Windows.Forms.Button()
        Me.btEliminar = New System.Windows.Forms.Button()
        Me.btInsertar = New System.Windows.Forms.Button()
        Me.txtNombreLugar = New System.Windows.Forms.TextBox()
        Me.lbTituloPelicula = New System.Windows.Forms.Label()
        Me.txtTituloPelicula = New System.Windows.Forms.TextBox()
        Me.lbCodigoPelicula = New System.Windows.Forms.Label()
        Me.Panel13.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.dgv_LugaresEstreno, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel13
        '
        Me.Panel13.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel13.Controls.Add(Me.lblPublicados)
        Me.Panel13.Location = New System.Drawing.Point(325, 56)
        Me.Panel13.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel13.Name = "Panel13"
        Me.Panel13.Size = New System.Drawing.Size(449, 28)
        Me.Panel13.TabIndex = 60
        '
        'lblPublicados
        '
        Me.lblPublicados.AutoSize = True
        Me.lblPublicados.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPublicados.Location = New System.Drawing.Point(154, 4)
        Me.lblPublicados.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblPublicados.Name = "lblPublicados"
        Me.lblPublicados.Size = New System.Drawing.Size(161, 15)
        Me.lblPublicados.TabIndex = 0
        Me.lblPublicados.Text = "Lugares de los estrenos"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Location = New System.Drawing.Point(-1, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(775, 54)
        Me.Panel1.TabIndex = 58
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(273, 14)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(218, 25)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Lugares de Estreno"
        '
        'txtIdLugar
        '
        Me.txtIdLugar.Location = New System.Drawing.Point(109, 60)
        Me.txtIdLugar.Name = "txtIdLugar"
        Me.txtIdLugar.ReadOnly = True
        Me.txtIdLugar.Size = New System.Drawing.Size(163, 20)
        Me.txtIdLugar.TabIndex = 43
        '
        'lbIdDirector
        '
        Me.lbIdDirector.AutoSize = True
        Me.lbIdDirector.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbIdDirector.Location = New System.Drawing.Point(13, 63)
        Me.lbIdDirector.Name = "lbIdDirector"
        Me.lbIdDirector.Size = New System.Drawing.Size(73, 13)
        Me.lbIdDirector.TabIndex = 56
        Me.lbIdDirector.Text = "Código Lugar:"
        '
        'dgv_LugaresEstreno
        '
        Me.dgv_LugaresEstreno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_LugaresEstreno.Location = New System.Drawing.Point(325, 86)
        Me.dgv_LugaresEstreno.Name = "dgv_LugaresEstreno"
        Me.dgv_LugaresEstreno.Size = New System.Drawing.Size(449, 246)
        Me.dgv_LugaresEstreno.TabIndex = 55
        '
        'txtIdPelicula
        '
        Me.txtIdPelicula.Location = New System.Drawing.Point(108, 114)
        Me.txtIdPelicula.MaxLength = 100
        Me.txtIdPelicula.Name = "txtIdPelicula"
        Me.txtIdPelicula.ReadOnly = True
        Me.txtIdPelicula.Size = New System.Drawing.Size(163, 20)
        Me.txtIdPelicula.TabIndex = 45
        '
        'lbNombreLugar
        '
        Me.lbNombreLugar.AutoSize = True
        Me.lbNombreLugar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbNombreLugar.Location = New System.Drawing.Point(13, 89)
        Me.lbNombreLugar.Name = "lbNombreLugar"
        Me.lbNombreLugar.Size = New System.Drawing.Size(37, 13)
        Me.lbNombreLugar.TabIndex = 53
        Me.lbNombreLugar.Text = "Lugar:"
        '
        'btBuscarPelicula
        '
        Me.btBuscarPelicula.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btBuscarPelicula.Image = Global.GUI.My.Resources.Resources.busqueda
        Me.btBuscarPelicula.Location = New System.Drawing.Point(278, 113)
        Me.btBuscarPelicula.Name = "btBuscarPelicula"
        Me.btBuscarPelicula.Size = New System.Drawing.Size(38, 23)
        Me.btBuscarPelicula.TabIndex = 61
        Me.btBuscarPelicula.UseVisualStyleBackColor = True
        '
        'btModificar
        '
        Me.btModificar.Image = Global.GUI.My.Resources.Resources.editar
        Me.btModificar.Location = New System.Drawing.Point(151, 165)
        Me.btModificar.Name = "btModificar"
        Me.btModificar.Size = New System.Drawing.Size(36, 27)
        Me.btModificar.TabIndex = 59
        Me.btModificar.UseVisualStyleBackColor = True
        '
        'limpiar
        '
        Me.limpiar.Image = Global.GUI.My.Resources.Resources.limpiarCampos
        Me.limpiar.Location = New System.Drawing.Point(236, 165)
        Me.limpiar.Name = "limpiar"
        Me.limpiar.Size = New System.Drawing.Size(37, 27)
        Me.limpiar.TabIndex = 51
        Me.limpiar.UseVisualStyleBackColor = True
        '
        'btBuscarLugar
        '
        Me.btBuscarLugar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btBuscarLugar.Image = Global.GUI.My.Resources.Resources.busqueda
        Me.btBuscarLugar.Location = New System.Drawing.Point(278, 59)
        Me.btBuscarLugar.Name = "btBuscarLugar"
        Me.btBuscarLugar.Size = New System.Drawing.Size(38, 23)
        Me.btBuscarLugar.TabIndex = 44
        Me.btBuscarLugar.UseVisualStyleBackColor = True
        '
        'btEliminar
        '
        Me.btEliminar.Image = Global.GUI.My.Resources.Resources.borrar
        Me.btEliminar.Location = New System.Drawing.Point(193, 165)
        Me.btEliminar.Name = "btEliminar"
        Me.btEliminar.Size = New System.Drawing.Size(37, 27)
        Me.btEliminar.TabIndex = 50
        Me.btEliminar.UseVisualStyleBackColor = True
        '
        'btInsertar
        '
        Me.btInsertar.Image = Global.GUI.My.Resources.Resources.agregar
        Me.btInsertar.Location = New System.Drawing.Point(108, 165)
        Me.btInsertar.Name = "btInsertar"
        Me.btInsertar.Size = New System.Drawing.Size(37, 27)
        Me.btInsertar.TabIndex = 49
        Me.btInsertar.UseVisualStyleBackColor = True
        '
        'txtNombreLugar
        '
        Me.txtNombreLugar.Location = New System.Drawing.Point(109, 86)
        Me.txtNombreLugar.Name = "txtNombreLugar"
        Me.txtNombreLugar.ReadOnly = True
        Me.txtNombreLugar.Size = New System.Drawing.Size(163, 20)
        Me.txtNombreLugar.TabIndex = 62
        '
        'lbTituloPelicula
        '
        Me.lbTituloPelicula.AutoSize = True
        Me.lbTituloPelicula.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTituloPelicula.Location = New System.Drawing.Point(13, 142)
        Me.lbTituloPelicula.Name = "lbTituloPelicula"
        Me.lbTituloPelicula.Size = New System.Drawing.Size(95, 13)
        Me.lbTituloPelicula.TabIndex = 65
        Me.lbTituloPelicula.Text = "Título de Película:"
        '
        'txtTituloPelicula
        '
        Me.txtTituloPelicula.Location = New System.Drawing.Point(108, 139)
        Me.txtTituloPelicula.MaxLength = 100
        Me.txtTituloPelicula.Name = "txtTituloPelicula"
        Me.txtTituloPelicula.ReadOnly = True
        Me.txtTituloPelicula.Size = New System.Drawing.Size(163, 20)
        Me.txtTituloPelicula.TabIndex = 63
        '
        'lbCodigoPelicula
        '
        Me.lbCodigoPelicula.AutoSize = True
        Me.lbCodigoPelicula.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbCodigoPelicula.Location = New System.Drawing.Point(13, 117)
        Me.lbCodigoPelicula.Name = "lbCodigoPelicula"
        Me.lbCodigoPelicula.Size = New System.Drawing.Size(85, 13)
        Me.lbCodigoPelicula.TabIndex = 64
        Me.lbCodigoPelicula.Text = "Código Película:"
        '
        'frmLugarEstreno
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(774, 344)
        Me.Controls.Add(Me.txtNombreLugar)
        Me.Controls.Add(Me.lbTituloPelicula)
        Me.Controls.Add(Me.txtTituloPelicula)
        Me.Controls.Add(Me.lbCodigoPelicula)
        Me.Controls.Add(Me.btBuscarPelicula)
        Me.Controls.Add(Me.Panel13)
        Me.Controls.Add(Me.btModificar)
        Me.Controls.Add(Me.limpiar)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btBuscarLugar)
        Me.Controls.Add(Me.txtIdLugar)
        Me.Controls.Add(Me.lbIdDirector)
        Me.Controls.Add(Me.btEliminar)
        Me.Controls.Add(Me.dgv_LugaresEstreno)
        Me.Controls.Add(Me.btInsertar)
        Me.Controls.Add(Me.txtIdPelicula)
        Me.Controls.Add(Me.lbNombreLugar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmLugarEstreno"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lugares de Estreno"
        Me.Panel13.ResumeLayout(False)
        Me.Panel13.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgv_LugaresEstreno, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel13 As System.Windows.Forms.Panel
    Friend WithEvents lblPublicados As System.Windows.Forms.Label
    Friend WithEvents btModificar As System.Windows.Forms.Button
    Friend WithEvents limpiar As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btBuscarLugar As System.Windows.Forms.Button
    Friend WithEvents txtIdLugar As System.Windows.Forms.TextBox
    Friend WithEvents lbIdDirector As System.Windows.Forms.Label
    Friend WithEvents btEliminar As System.Windows.Forms.Button
    Friend WithEvents dgv_LugaresEstreno As System.Windows.Forms.DataGridView
    Friend WithEvents btInsertar As System.Windows.Forms.Button
    Friend WithEvents txtIdPelicula As System.Windows.Forms.TextBox
    Friend WithEvents lbNombreLugar As System.Windows.Forms.Label
    Friend WithEvents btBuscarPelicula As System.Windows.Forms.Button
    Friend WithEvents txtNombreLugar As System.Windows.Forms.TextBox
    Friend WithEvents lbTituloPelicula As System.Windows.Forms.Label
    Friend WithEvents txtTituloPelicula As System.Windows.Forms.TextBox
    Friend WithEvents lbCodigoPelicula As System.Windows.Forms.Label
End Class
