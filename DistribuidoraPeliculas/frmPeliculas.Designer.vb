<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPeliculas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPeliculas))
        Me.dgv_Peliculas = New System.Windows.Forms.DataGridView()
        Me.txtTitulo = New System.Windows.Forms.TextBox()
        Me.txtArgumento = New System.Windows.Forms.TextBox()
        Me.txtNacionalidad = New System.Windows.Forms.TextBox()
        Me.lbNacionalidad = New System.Windows.Forms.Label()
        Me.lbTitulo = New System.Windows.Forms.Label()
        Me.lbArgumento = New System.Windows.Forms.Label()
        Me.txtIdDirector = New System.Windows.Forms.TextBox()
        Me.lbIdDirector = New System.Windows.Forms.Label()
        Me.dpFechaEstreno = New System.Windows.Forms.DateTimePicker()
        Me.lbFechaEstreno = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel13 = New System.Windows.Forms.Panel()
        Me.lblPublicados = New System.Windows.Forms.Label()
        Me.btModificar = New System.Windows.Forms.Button()
        Me.limpiar = New System.Windows.Forms.Button()
        Me.btBuscar = New System.Windows.Forms.Button()
        Me.btEliminar = New System.Windows.Forms.Button()
        Me.btInsertar = New System.Windows.Forms.Button()
        Me.txtNombreDirector = New System.Windows.Forms.TextBox()
        Me.lbNombreDirector = New System.Windows.Forms.Label()
        CType(Me.dgv_Peliculas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel13.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgv_Peliculas
        '
        Me.dgv_Peliculas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_Peliculas.Location = New System.Drawing.Point(326, 86)
        Me.dgv_Peliculas.Name = "dgv_Peliculas"
        Me.dgv_Peliculas.Size = New System.Drawing.Size(521, 246)
        Me.dgv_Peliculas.TabIndex = 32
        '
        'txtTitulo
        '
        Me.txtTitulo.Location = New System.Drawing.Point(119, 115)
        Me.txtTitulo.MaxLength = 100
        Me.txtTitulo.Name = "txtTitulo"
        Me.txtTitulo.Size = New System.Drawing.Size(193, 20)
        Me.txtTitulo.TabIndex = 3
        '
        'txtArgumento
        '
        Me.txtArgumento.Location = New System.Drawing.Point(119, 141)
        Me.txtArgumento.MaxLength = 300
        Me.txtArgumento.Multiline = True
        Me.txtArgumento.Name = "txtArgumento"
        Me.txtArgumento.Size = New System.Drawing.Size(193, 111)
        Me.txtArgumento.TabIndex = 4
        '
        'txtNacionalidad
        '
        Me.txtNacionalidad.Location = New System.Drawing.Point(116, 284)
        Me.txtNacionalidad.MaxLength = 50
        Me.txtNacionalidad.Name = "txtNacionalidad"
        Me.txtNacionalidad.Size = New System.Drawing.Size(196, 20)
        Me.txtNacionalidad.TabIndex = 6
        '
        'lbNacionalidad
        '
        Me.lbNacionalidad.AutoSize = True
        Me.lbNacionalidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbNacionalidad.Location = New System.Drawing.Point(12, 287)
        Me.lbNacionalidad.Name = "lbNacionalidad"
        Me.lbNacionalidad.Size = New System.Drawing.Size(72, 13)
        Me.lbNacionalidad.TabIndex = 24
        Me.lbNacionalidad.Text = "Nacionalidad:"
        '
        'lbTitulo
        '
        Me.lbTitulo.AutoSize = True
        Me.lbTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTitulo.Location = New System.Drawing.Point(12, 118)
        Me.lbTitulo.Name = "lbTitulo"
        Me.lbTitulo.Size = New System.Drawing.Size(36, 13)
        Me.lbTitulo.TabIndex = 23
        Me.lbTitulo.Text = "Titulo:"
        '
        'lbArgumento
        '
        Me.lbArgumento.AutoSize = True
        Me.lbArgumento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbArgumento.Location = New System.Drawing.Point(14, 144)
        Me.lbArgumento.Name = "lbArgumento"
        Me.lbArgumento.Size = New System.Drawing.Size(61, 13)
        Me.lbArgumento.TabIndex = 22
        Me.lbArgumento.Text = "Argumento:"
        '
        'txtIdDirector
        '
        Me.txtIdDirector.Location = New System.Drawing.Point(119, 60)
        Me.txtIdDirector.Name = "txtIdDirector"
        Me.txtIdDirector.ReadOnly = True
        Me.txtIdDirector.Size = New System.Drawing.Size(149, 20)
        Me.txtIdDirector.TabIndex = 1
        '
        'lbIdDirector
        '
        Me.lbIdDirector.AutoSize = True
        Me.lbIdDirector.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbIdDirector.Location = New System.Drawing.Point(14, 63)
        Me.lbIdDirector.Name = "lbIdDirector"
        Me.lbIdDirector.Size = New System.Drawing.Size(83, 13)
        Me.lbIdDirector.TabIndex = 35
        Me.lbIdDirector.Text = "Código Director:"
        '
        'dpFechaEstreno
        '
        Me.dpFechaEstreno.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dpFechaEstreno.Location = New System.Drawing.Point(116, 258)
        Me.dpFechaEstreno.Name = "dpFechaEstreno"
        Me.dpFechaEstreno.Size = New System.Drawing.Size(196, 20)
        Me.dpFechaEstreno.TabIndex = 5
        '
        'lbFechaEstreno
        '
        Me.lbFechaEstreno.AutoSize = True
        Me.lbFechaEstreno.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbFechaEstreno.Location = New System.Drawing.Point(13, 260)
        Me.lbFechaEstreno.Name = "lbFechaEstreno"
        Me.lbFechaEstreno.Size = New System.Drawing.Size(78, 13)
        Me.lbFechaEstreno.TabIndex = 38
        Me.lbFechaEstreno.Text = "Fecha estreno:"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(847, 54)
        Me.Panel1.TabIndex = 40
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(363, 14)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(108, 25)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Películas"
        '
        'Panel13
        '
        Me.Panel13.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel13.Controls.Add(Me.lblPublicados)
        Me.Panel13.Location = New System.Drawing.Point(326, 56)
        Me.Panel13.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel13.Name = "Panel13"
        Me.Panel13.Size = New System.Drawing.Size(521, 28)
        Me.Panel13.TabIndex = 42
        '
        'lblPublicados
        '
        Me.lblPublicados.AutoSize = True
        Me.lblPublicados.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPublicados.Location = New System.Drawing.Point(209, 4)
        Me.lblPublicados.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblPublicados.Name = "lblPublicados"
        Me.lblPublicados.Size = New System.Drawing.Size(100, 15)
        Me.lblPublicados.TabIndex = 0
        Me.lblPublicados.Text = "Lista películas"
        '
        'btModificar
        '
        Me.btModificar.Image = Global.GUI.My.Resources.Resources.editar
        Me.btModificar.Location = New System.Drawing.Point(170, 310)
        Me.btModificar.Name = "btModificar"
        Me.btModificar.Size = New System.Drawing.Size(36, 27)
        Me.btModificar.TabIndex = 41
        Me.btModificar.UseVisualStyleBackColor = True
        '
        'limpiar
        '
        Me.limpiar.Image = Global.GUI.My.Resources.Resources.limpiarCampos
        Me.limpiar.Location = New System.Drawing.Point(274, 310)
        Me.limpiar.Name = "limpiar"
        Me.limpiar.Size = New System.Drawing.Size(37, 27)
        Me.limpiar.TabIndex = 10
        Me.limpiar.UseVisualStyleBackColor = True
        '
        'btBuscar
        '
        Me.btBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btBuscar.Image = Global.GUI.My.Resources.Resources.busqueda
        Me.btBuscar.Location = New System.Drawing.Point(274, 59)
        Me.btBuscar.Name = "btBuscar"
        Me.btBuscar.Size = New System.Drawing.Size(38, 21)
        Me.btBuscar.TabIndex = 2
        Me.btBuscar.UseVisualStyleBackColor = True
        '
        'btEliminar
        '
        Me.btEliminar.Image = Global.GUI.My.Resources.Resources.borrar
        Me.btEliminar.Location = New System.Drawing.Point(219, 310)
        Me.btEliminar.Name = "btEliminar"
        Me.btEliminar.Size = New System.Drawing.Size(37, 27)
        Me.btEliminar.TabIndex = 9
        Me.btEliminar.UseVisualStyleBackColor = True
        '
        'btInsertar
        '
        Me.btInsertar.Image = Global.GUI.My.Resources.Resources.agregar
        Me.btInsertar.Location = New System.Drawing.Point(116, 310)
        Me.btInsertar.Name = "btInsertar"
        Me.btInsertar.Size = New System.Drawing.Size(37, 27)
        Me.btInsertar.TabIndex = 8
        Me.btInsertar.UseVisualStyleBackColor = True
        '
        'txtNombreDirector
        '
        Me.txtNombreDirector.Location = New System.Drawing.Point(119, 87)
        Me.txtNombreDirector.MaxLength = 100
        Me.txtNombreDirector.Name = "txtNombreDirector"
        Me.txtNombreDirector.ReadOnly = True
        Me.txtNombreDirector.Size = New System.Drawing.Size(193, 20)
        Me.txtNombreDirector.TabIndex = 43
        '
        'lbNombreDirector
        '
        Me.lbNombreDirector.AutoSize = True
        Me.lbNombreDirector.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbNombreDirector.Location = New System.Drawing.Point(14, 90)
        Me.lbNombreDirector.Name = "lbNombreDirector"
        Me.lbNombreDirector.Size = New System.Drawing.Size(102, 13)
        Me.lbNombreDirector.TabIndex = 44
        Me.lbNombreDirector.Text = "Nombre de Director:"
        '
        'frmPeliculas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(848, 356)
        Me.Controls.Add(Me.txtNombreDirector)
        Me.Controls.Add(Me.lbNombreDirector)
        Me.Controls.Add(Me.Panel13)
        Me.Controls.Add(Me.btModificar)
        Me.Controls.Add(Me.limpiar)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.dpFechaEstreno)
        Me.Controls.Add(Me.lbFechaEstreno)
        Me.Controls.Add(Me.btBuscar)
        Me.Controls.Add(Me.txtIdDirector)
        Me.Controls.Add(Me.lbIdDirector)
        Me.Controls.Add(Me.btEliminar)
        Me.Controls.Add(Me.dgv_Peliculas)
        Me.Controls.Add(Me.btInsertar)
        Me.Controls.Add(Me.txtTitulo)
        Me.Controls.Add(Me.txtArgumento)
        Me.Controls.Add(Me.txtNacionalidad)
        Me.Controls.Add(Me.lbNacionalidad)
        Me.Controls.Add(Me.lbTitulo)
        Me.Controls.Add(Me.lbArgumento)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmPeliculas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Películas"
        CType(Me.dgv_Peliculas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel13.ResumeLayout(False)
        Me.Panel13.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btEliminar As System.Windows.Forms.Button
    Friend WithEvents dgv_Peliculas As System.Windows.Forms.DataGridView
    Friend WithEvents btInsertar As System.Windows.Forms.Button
    Friend WithEvents txtTitulo As System.Windows.Forms.TextBox
    Friend WithEvents txtArgumento As System.Windows.Forms.TextBox
    Friend WithEvents txtNacionalidad As System.Windows.Forms.TextBox
    Friend WithEvents lbNacionalidad As System.Windows.Forms.Label
    Friend WithEvents lbTitulo As System.Windows.Forms.Label
    Friend WithEvents lbArgumento As System.Windows.Forms.Label
    Friend WithEvents txtIdDirector As System.Windows.Forms.TextBox
    Friend WithEvents lbIdDirector As System.Windows.Forms.Label
    Friend WithEvents btBuscar As System.Windows.Forms.Button
    Friend WithEvents dpFechaEstreno As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbFechaEstreno As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents limpiar As System.Windows.Forms.Button
    Friend WithEvents btModificar As System.Windows.Forms.Button
    Friend WithEvents Panel13 As System.Windows.Forms.Panel
    Friend WithEvents lblPublicados As System.Windows.Forms.Label
    Friend WithEvents txtNombreDirector As System.Windows.Forms.TextBox
    Friend WithEvents lbNombreDirector As System.Windows.Forms.Label
End Class
