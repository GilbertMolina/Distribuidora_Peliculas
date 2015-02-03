<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProductorPelicula
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProductorPelicula))
        Me.lbIdProductor = New System.Windows.Forms.Label()
        Me.txtIdProductor = New System.Windows.Forms.TextBox()
        Me.btBuscarProductor = New System.Windows.Forms.Button()
        Me.txtIdPelicula = New System.Windows.Forms.TextBox()
        Me.lbIdPelicula = New System.Windows.Forms.Label()
        Me.btBuscarPeli = New System.Windows.Forms.Button()
        Me.lbAporte = New System.Windows.Forms.Label()
        Me.txtAporte = New System.Windows.Forms.TextBox()
        Me.btAgregar = New System.Windows.Forms.Button()
        Me.dgvProductorPeli = New System.Windows.Forms.DataGridView()
        Me.btEliminar = New System.Windows.Forms.Button()
        Me.btEditar = New System.Windows.Forms.Button()
        Me.btLimpiar = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtTituloPelicula = New System.Windows.Forms.TextBox()
        Me.lbTituloPelicula = New System.Windows.Forms.Label()
        Me.txtNombreProductor = New System.Windows.Forms.TextBox()
        Me.lbNombreProductor = New System.Windows.Forms.Label()
        CType(Me.dgvProductorPeli, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbIdProductor
        '
        Me.lbIdProductor.AutoSize = True
        Me.lbIdProductor.Location = New System.Drawing.Point(15, 78)
        Me.lbIdProductor.Name = "lbIdProductor"
        Me.lbIdProductor.Size = New System.Drawing.Size(92, 13)
        Me.lbIdProductor.TabIndex = 0
        Me.lbIdProductor.Text = "Código Productor:"
        '
        'txtIdProductor
        '
        Me.txtIdProductor.Location = New System.Drawing.Point(114, 75)
        Me.txtIdProductor.Name = "txtIdProductor"
        Me.txtIdProductor.ReadOnly = True
        Me.txtIdProductor.Size = New System.Drawing.Size(128, 20)
        Me.txtIdProductor.TabIndex = 1
        '
        'btBuscarProductor
        '
        Me.btBuscarProductor.Image = Global.GUI.My.Resources.Resources.busqueda
        Me.btBuscarProductor.Location = New System.Drawing.Point(248, 74)
        Me.btBuscarProductor.Name = "btBuscarProductor"
        Me.btBuscarProductor.Size = New System.Drawing.Size(37, 21)
        Me.btBuscarProductor.TabIndex = 2
        Me.btBuscarProductor.UseVisualStyleBackColor = True
        '
        'txtIdPelicula
        '
        Me.txtIdPelicula.Location = New System.Drawing.Point(114, 131)
        Me.txtIdPelicula.Name = "txtIdPelicula"
        Me.txtIdPelicula.ReadOnly = True
        Me.txtIdPelicula.Size = New System.Drawing.Size(128, 20)
        Me.txtIdPelicula.TabIndex = 4
        '
        'lbIdPelicula
        '
        Me.lbIdPelicula.AutoSize = True
        Me.lbIdPelicula.Location = New System.Drawing.Point(15, 134)
        Me.lbIdPelicula.Name = "lbIdPelicula"
        Me.lbIdPelicula.Size = New System.Drawing.Size(85, 13)
        Me.lbIdPelicula.TabIndex = 3
        Me.lbIdPelicula.Text = "Código Película:"
        '
        'btBuscarPeli
        '
        Me.btBuscarPeli.Image = Global.GUI.My.Resources.Resources.busqueda
        Me.btBuscarPeli.Location = New System.Drawing.Point(248, 130)
        Me.btBuscarPeli.Name = "btBuscarPeli"
        Me.btBuscarPeli.Size = New System.Drawing.Size(37, 21)
        Me.btBuscarPeli.TabIndex = 5
        Me.btBuscarPeli.UseVisualStyleBackColor = True
        '
        'lbAporte
        '
        Me.lbAporte.AutoSize = True
        Me.lbAporte.Location = New System.Drawing.Point(15, 185)
        Me.lbAporte.Name = "lbAporte"
        Me.lbAporte.Size = New System.Drawing.Size(41, 13)
        Me.lbAporte.TabIndex = 6
        Me.lbAporte.Text = "Aporte:"
        '
        'txtAporte
        '
        Me.txtAporte.Location = New System.Drawing.Point(114, 185)
        Me.txtAporte.Name = "txtAporte"
        Me.txtAporte.Size = New System.Drawing.Size(171, 20)
        Me.txtAporte.TabIndex = 7
        '
        'btAgregar
        '
        Me.btAgregar.Image = Global.GUI.My.Resources.Resources.agregar
        Me.btAgregar.Location = New System.Drawing.Point(114, 215)
        Me.btAgregar.Name = "btAgregar"
        Me.btAgregar.Size = New System.Drawing.Size(37, 27)
        Me.btAgregar.TabIndex = 8
        Me.btAgregar.UseVisualStyleBackColor = True
        '
        'dgvProductorPeli
        '
        Me.dgvProductorPeli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProductorPeli.Location = New System.Drawing.Point(297, 97)
        Me.dgvProductorPeli.Name = "dgvProductorPeli"
        Me.dgvProductorPeli.Size = New System.Drawing.Size(511, 145)
        Me.dgvProductorPeli.TabIndex = 9
        '
        'btEliminar
        '
        Me.btEliminar.Image = Global.GUI.My.Resources.Resources.borrar
        Me.btEliminar.Location = New System.Drawing.Point(204, 215)
        Me.btEliminar.Name = "btEliminar"
        Me.btEliminar.Size = New System.Drawing.Size(37, 27)
        Me.btEliminar.TabIndex = 10
        Me.btEliminar.UseVisualStyleBackColor = True
        '
        'btEditar
        '
        Me.btEditar.Image = Global.GUI.My.Resources.Resources.editar
        Me.btEditar.Location = New System.Drawing.Point(160, 215)
        Me.btEditar.Name = "btEditar"
        Me.btEditar.Size = New System.Drawing.Size(37, 27)
        Me.btEditar.TabIndex = 11
        Me.btEditar.UseVisualStyleBackColor = True
        '
        'btLimpiar
        '
        Me.btLimpiar.Image = Global.GUI.My.Resources.Resources.limpiarCampos
        Me.btLimpiar.Location = New System.Drawing.Point(248, 215)
        Me.btLimpiar.Name = "btLimpiar"
        Me.btLimpiar.Size = New System.Drawing.Size(37, 27)
        Me.btLimpiar.TabIndex = 12
        Me.btLimpiar.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(808, 57)
        Me.Panel1.TabIndex = 13
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(265, 13)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(218, 24)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Productor por Película"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Location = New System.Drawing.Point(297, 59)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(511, 36)
        Me.Panel2.TabIndex = 14
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(142, 8)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(160, 15)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Lista Productor Película"
        '
        'txtTituloPelicula
        '
        Me.txtTituloPelicula.Location = New System.Drawing.Point(114, 158)
        Me.txtTituloPelicula.Name = "txtTituloPelicula"
        Me.txtTituloPelicula.ReadOnly = True
        Me.txtTituloPelicula.Size = New System.Drawing.Size(171, 20)
        Me.txtTituloPelicula.TabIndex = 19
        '
        'lbTituloPelicula
        '
        Me.lbTituloPelicula.AutoSize = True
        Me.lbTituloPelicula.Location = New System.Drawing.Point(15, 161)
        Me.lbTituloPelicula.Name = "lbTituloPelicula"
        Me.lbTituloPelicula.Size = New System.Drawing.Size(80, 13)
        Me.lbTituloPelicula.TabIndex = 18
        Me.lbTituloPelicula.Text = "Título Película:"
        '
        'txtNombreProductor
        '
        Me.txtNombreProductor.Location = New System.Drawing.Point(114, 103)
        Me.txtNombreProductor.Name = "txtNombreProductor"
        Me.txtNombreProductor.ReadOnly = True
        Me.txtNombreProductor.Size = New System.Drawing.Size(171, 20)
        Me.txtNombreProductor.TabIndex = 16
        '
        'lbNombreProductor
        '
        Me.lbNombreProductor.AutoSize = True
        Me.lbNombreProductor.Location = New System.Drawing.Point(15, 106)
        Me.lbNombreProductor.Name = "lbNombreProductor"
        Me.lbNombreProductor.Size = New System.Drawing.Size(96, 13)
        Me.lbNombreProductor.TabIndex = 15
        Me.lbNombreProductor.Text = "Nombre Productor:"
        '
        'frmProductorPelicula
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(807, 262)
        Me.Controls.Add(Me.txtTituloPelicula)
        Me.Controls.Add(Me.lbTituloPelicula)
        Me.Controls.Add(Me.txtNombreProductor)
        Me.Controls.Add(Me.lbNombreProductor)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btLimpiar)
        Me.Controls.Add(Me.btEditar)
        Me.Controls.Add(Me.btEliminar)
        Me.Controls.Add(Me.dgvProductorPeli)
        Me.Controls.Add(Me.btAgregar)
        Me.Controls.Add(Me.txtAporte)
        Me.Controls.Add(Me.lbAporte)
        Me.Controls.Add(Me.btBuscarPeli)
        Me.Controls.Add(Me.txtIdPelicula)
        Me.Controls.Add(Me.lbIdPelicula)
        Me.Controls.Add(Me.btBuscarProductor)
        Me.Controls.Add(Me.txtIdProductor)
        Me.Controls.Add(Me.lbIdProductor)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmProductorPelicula"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Productor por Pelicula"
        CType(Me.dgvProductorPeli, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbIdProductor As System.Windows.Forms.Label
    Friend WithEvents txtIdProductor As System.Windows.Forms.TextBox
    Friend WithEvents btBuscarProductor As System.Windows.Forms.Button
    Friend WithEvents btBuscarPeli As System.Windows.Forms.Button
    Friend WithEvents txtIdPelicula As System.Windows.Forms.TextBox
    Friend WithEvents lbIdPelicula As System.Windows.Forms.Label
    Friend WithEvents lbAporte As System.Windows.Forms.Label
    Friend WithEvents txtAporte As System.Windows.Forms.TextBox
    Friend WithEvents btAgregar As System.Windows.Forms.Button
    Friend WithEvents dgvProductorPeli As System.Windows.Forms.DataGridView
    Friend WithEvents btEliminar As System.Windows.Forms.Button
    Friend WithEvents btEditar As System.Windows.Forms.Button
    Friend WithEvents btLimpiar As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtTituloPelicula As System.Windows.Forms.TextBox
    Friend WithEvents lbTituloPelicula As System.Windows.Forms.Label
    Friend WithEvents txtNombreProductor As System.Windows.Forms.TextBox
    Friend WithEvents lbNombreProductor As System.Windows.Forms.Label
End Class
