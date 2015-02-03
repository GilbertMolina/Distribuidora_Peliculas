<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCritica
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCritica))
        Me.txtAutor = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblPublicados = New System.Windows.Forms.Label()
        Me.txtMedio = New System.Windows.Forms.TextBox()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.comboxPeli = New System.Windows.Forms.ComboBox()
        Me.txtCodPeli = New System.Windows.Forms.TextBox()
        Me.labelCod = New System.Windows.Forms.Label()
        Me.lblPelicula = New System.Windows.Forms.Label()
        Me.txtCodCritica = New System.Windows.Forms.TextBox()
        Me.lblfecha = New System.Windows.Forms.Label()
        Me.lblCod = New System.Windows.Forms.Label()
        Me.Panel13 = New System.Windows.Forms.Panel()
        Me.dgvCriticas = New System.Windows.Forms.DataGridView()
        Me.lblCriticas = New System.Windows.Forms.Label()
        Me.dateFechaCritica = New System.Windows.Forms.DateTimePicker()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnBusca = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.Panel13.SuspendLayout()
        CType(Me.dgvCriticas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel10.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtAutor
        '
        Me.txtAutor.Location = New System.Drawing.Point(94, 195)
        Me.txtAutor.Margin = New System.Windows.Forms.Padding(2)
        Me.txtAutor.Name = "txtAutor"
        Me.txtAutor.Size = New System.Drawing.Size(96, 20)
        Me.txtAutor.TabIndex = 34
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(16, 228)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(78, 13)
        Me.Label7.TabIndex = 33
        Me.Label7.Text = "Nombre medio:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(16, 195)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(35, 13)
        Me.Label6.TabIndex = 32
        Me.Label6.Text = "Autor:"
        '
        'lblPublicados
        '
        Me.lblPublicados.AutoSize = True
        Me.lblPublicados.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPublicados.Location = New System.Drawing.Point(183, 4)
        Me.lblPublicados.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblPublicados.Name = "lblPublicados"
        Me.lblPublicados.Size = New System.Drawing.Size(78, 15)
        Me.lblPublicados.TabIndex = 0
        Me.lblPublicados.Text = "Publicados"
        '
        'txtMedio
        '
        Me.txtMedio.Location = New System.Drawing.Point(94, 228)
        Me.txtMedio.Margin = New System.Windows.Forms.Padding(2)
        Me.txtMedio.Name = "txtMedio"
        Me.txtMedio.Size = New System.Drawing.Size(96, 20)
        Me.txtMedio.TabIndex = 35
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(94, 257)
        Me.btnAgregar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(63, 31)
        Me.btnAgregar.TabIndex = 30
        Me.btnAgregar.Text = "Nuevo"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'comboxPeli
        '
        Me.comboxPeli.FormattingEnabled = True
        Me.comboxPeli.Location = New System.Drawing.Point(94, 128)
        Me.comboxPeli.Margin = New System.Windows.Forms.Padding(2)
        Me.comboxPeli.Name = "comboxPeli"
        Me.comboxPeli.Size = New System.Drawing.Size(96, 21)
        Me.comboxPeli.TabIndex = 29
        '
        'txtCodPeli
        '
        Me.txtCodPeli.Enabled = False
        Me.txtCodPeli.Location = New System.Drawing.Point(94, 163)
        Me.txtCodPeli.Margin = New System.Windows.Forms.Padding(2)
        Me.txtCodPeli.Name = "txtCodPeli"
        Me.txtCodPeli.Size = New System.Drawing.Size(96, 20)
        Me.txtCodPeli.TabIndex = 28
        '
        'labelCod
        '
        Me.labelCod.AutoSize = True
        Me.labelCod.Location = New System.Drawing.Point(16, 163)
        Me.labelCod.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.labelCod.Name = "labelCod"
        Me.labelCod.Size = New System.Drawing.Size(68, 13)
        Me.labelCod.TabIndex = 27
        Me.labelCod.Text = "Cod pelicula:"
        '
        'lblPelicula
        '
        Me.lblPelicula.AutoSize = True
        Me.lblPelicula.Location = New System.Drawing.Point(16, 128)
        Me.lblPelicula.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblPelicula.Name = "lblPelicula"
        Me.lblPelicula.Size = New System.Drawing.Size(47, 13)
        Me.lblPelicula.TabIndex = 26
        Me.lblPelicula.Text = "Pelicula:"
        '
        'txtCodCritica
        '
        Me.txtCodCritica.Enabled = False
        Me.txtCodCritica.Location = New System.Drawing.Point(94, 65)
        Me.txtCodCritica.Margin = New System.Windows.Forms.Padding(2)
        Me.txtCodCritica.Name = "txtCodCritica"
        Me.txtCodCritica.Size = New System.Drawing.Size(99, 20)
        Me.txtCodCritica.TabIndex = 24
        '
        'lblfecha
        '
        Me.lblfecha.AutoSize = True
        Me.lblfecha.Location = New System.Drawing.Point(16, 95)
        Me.lblfecha.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblfecha.Name = "lblfecha"
        Me.lblfecha.Size = New System.Drawing.Size(40, 13)
        Me.lblfecha.TabIndex = 23
        Me.lblfecha.Text = "Fecha:"
        '
        'lblCod
        '
        Me.lblCod.AutoSize = True
        Me.lblCod.Location = New System.Drawing.Point(16, 64)
        Me.lblCod.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCod.Name = "lblCod"
        Me.lblCod.Size = New System.Drawing.Size(43, 13)
        Me.lblCod.TabIndex = 22
        Me.lblCod.Text = "Código:"
        '
        'Panel13
        '
        Me.Panel13.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel13.Controls.Add(Me.lblPublicados)
        Me.Panel13.Location = New System.Drawing.Point(249, 53)
        Me.Panel13.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel13.Name = "Panel13"
        Me.Panel13.Size = New System.Drawing.Size(438, 28)
        Me.Panel13.TabIndex = 20
        '
        'dgvCriticas
        '
        Me.dgvCriticas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvCriticas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvCriticas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCriticas.Location = New System.Drawing.Point(249, 82)
        Me.dgvCriticas.Margin = New System.Windows.Forms.Padding(2)
        Me.dgvCriticas.MultiSelect = False
        Me.dgvCriticas.Name = "dgvCriticas"
        Me.dgvCriticas.RowTemplate.Height = 24
        Me.dgvCriticas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCriticas.Size = New System.Drawing.Size(438, 245)
        Me.dgvCriticas.TabIndex = 19
        '
        'lblCriticas
        '
        Me.lblCriticas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCriticas.AutoSize = True
        Me.lblCriticas.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCriticas.Location = New System.Drawing.Point(288, 12)
        Me.lblCriticas.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCriticas.Name = "lblCriticas"
        Me.lblCriticas.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblCriticas.Size = New System.Drawing.Size(85, 25)
        Me.lblCriticas.TabIndex = 0
        Me.lblCriticas.Text = "Críticas"
        Me.lblCriticas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dateFechaCritica
        '
        Me.dateFechaCritica.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dateFechaCritica.Location = New System.Drawing.Point(94, 95)
        Me.dateFechaCritica.Margin = New System.Windows.Forms.Padding(2)
        Me.dateFechaCritica.Name = "dateFechaCritica"
        Me.dateFechaCritica.Size = New System.Drawing.Size(96, 20)
        Me.dateFechaCritica.TabIndex = 25
        Me.dateFechaCritica.Value = New Date(2013, 11, 11, 22, 51, 13, 0)
        '
        'Panel10
        '
        Me.Panel10.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel10.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Panel10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel10.Controls.Add(Me.lblCriticas)
        Me.Panel10.Location = New System.Drawing.Point(1, -1)
        Me.Panel10.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(686, 51)
        Me.Panel10.TabIndex = 18
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Image = Global.GUI.My.Resources.Resources.limpiarCampos
        Me.btnLimpiar.Location = New System.Drawing.Point(161, 257)
        Me.btnLimpiar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(29, 31)
        Me.btnLimpiar.TabIndex = 36
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'btnBusca
        '
        Me.btnBusca.Image = Global.GUI.My.Resources.Resources.busqueda
        Me.btnBusca.Location = New System.Drawing.Point(197, 127)
        Me.btnBusca.Margin = New System.Windows.Forms.Padding(2)
        Me.btnBusca.Name = "btnBusca"
        Me.btnBusca.Size = New System.Drawing.Size(37, 22)
        Me.btnBusca.TabIndex = 31
        Me.btnBusca.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Image = Global.GUI.My.Resources.Resources.borrar
        Me.btnEliminar.Location = New System.Drawing.Point(197, 64)
        Me.btnEliminar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(37, 21)
        Me.btnEliminar.TabIndex = 21
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'frmCritica
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(687, 329)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.txtAutor)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnBusca)
        Me.Controls.Add(Me.txtMedio)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.comboxPeli)
        Me.Controls.Add(Me.txtCodPeli)
        Me.Controls.Add(Me.labelCod)
        Me.Controls.Add(Me.lblPelicula)
        Me.Controls.Add(Me.txtCodCritica)
        Me.Controls.Add(Me.lblfecha)
        Me.Controls.Add(Me.lblCod)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.Panel13)
        Me.Controls.Add(Me.dgvCriticas)
        Me.Controls.Add(Me.dateFechaCritica)
        Me.Controls.Add(Me.Panel10)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.Name = "frmCritica"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Críticas"
        Me.Panel13.ResumeLayout(False)
        Me.Panel13.PerformLayout()
        CType(Me.dgvCriticas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel10.ResumeLayout(False)
        Me.Panel10.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtAutor As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnBusca As System.Windows.Forms.Button
    Friend WithEvents lblPublicados As System.Windows.Forms.Label
    Friend WithEvents txtMedio As System.Windows.Forms.TextBox
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents comboxPeli As System.Windows.Forms.ComboBox
    Friend WithEvents txtCodPeli As System.Windows.Forms.TextBox
    Friend WithEvents labelCod As System.Windows.Forms.Label
    Friend WithEvents lblPelicula As System.Windows.Forms.Label
    Friend WithEvents txtCodCritica As System.Windows.Forms.TextBox
    Friend WithEvents lblfecha As System.Windows.Forms.Label
    Friend WithEvents lblCod As System.Windows.Forms.Label
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents Panel13 As System.Windows.Forms.Panel
    Friend WithEvents dgvCriticas As System.Windows.Forms.DataGridView
    Friend WithEvents lblCriticas As System.Windows.Forms.Label
    Friend WithEvents dateFechaCritica As System.Windows.Forms.DateTimePicker
    Friend WithEvents Panel10 As System.Windows.Forms.Panel
    Friend WithEvents btnLimpiar As System.Windows.Forms.Button
End Class
