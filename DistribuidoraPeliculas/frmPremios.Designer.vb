<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPremios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPremios))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtIdPeli = New System.Windows.Forms.TextBox()
        Me.txtNombrePremio = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNombreCertamen = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCiudad = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dgvPremios = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel13 = New System.Windows.Forms.Panel()
        Me.lblPublicados = New System.Windows.Forms.Label()
        Me.limpiar = New System.Windows.Forms.Button()
        Me.btModificar = New System.Windows.Forms.Button()
        Me.btEliminar = New System.Windows.Forms.Button()
        Me.btAgregar = New System.Windows.Forms.Button()
        Me.btBuscarPelicula = New System.Windows.Forms.Button()
        Me.txtTituloPelicula = New System.Windows.Forms.TextBox()
        Me.lbTituloPelicula = New System.Windows.Forms.Label()
        CType(Me.dgvPremios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel13.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(22, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Código Película:"
        '
        'txtIdPeli
        '
        Me.txtIdPeli.Location = New System.Drawing.Point(114, 64)
        Me.txtIdPeli.Name = "txtIdPeli"
        Me.txtIdPeli.ReadOnly = True
        Me.txtIdPeli.Size = New System.Drawing.Size(163, 20)
        Me.txtIdPeli.TabIndex = 1
        '
        'txtNombrePremio
        '
        Me.txtNombrePremio.Location = New System.Drawing.Point(114, 135)
        Me.txtNombrePremio.Name = "txtNombrePremio"
        Me.txtNombrePremio.Size = New System.Drawing.Size(205, 20)
        Me.txtNombrePremio.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(22, 138)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nombre Premio:"
        '
        'txtNombreCertamen
        '
        Me.txtNombreCertamen.Location = New System.Drawing.Point(114, 166)
        Me.txtNombreCertamen.Name = "txtNombreCertamen"
        Me.txtNombreCertamen.Size = New System.Drawing.Size(205, 20)
        Me.txtNombreCertamen.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(22, 200)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Ciudad:"
        '
        'txtCiudad
        '
        Me.txtCiudad.Location = New System.Drawing.Point(114, 197)
        Me.txtCiudad.Name = "txtCiudad"
        Me.txtCiudad.Size = New System.Drawing.Size(205, 20)
        Me.txtCiudad.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(22, 169)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Certamen:"
        '
        'dgvPremios
        '
        Me.dgvPremios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPremios.Location = New System.Drawing.Point(334, 88)
        Me.dgvPremios.Name = "dgvPremios"
        Me.dgvPremios.Size = New System.Drawing.Size(471, 213)
        Me.dgvPremios.TabIndex = 10
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Location = New System.Drawing.Point(1, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(804, 54)
        Me.Panel1.TabIndex = 13
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(327, 13)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(97, 25)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Premios"
        '
        'Panel13
        '
        Me.Panel13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel13.Controls.Add(Me.lblPublicados)
        Me.Panel13.Location = New System.Drawing.Point(334, 57)
        Me.Panel13.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel13.Name = "Panel13"
        Me.Panel13.Size = New System.Drawing.Size(471, 28)
        Me.Panel13.TabIndex = 43
        '
        'lblPublicados
        '
        Me.lblPublicados.AutoSize = True
        Me.lblPublicados.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPublicados.Location = New System.Drawing.Point(197, 5)
        Me.lblPublicados.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblPublicados.Name = "lblPublicados"
        Me.lblPublicados.Size = New System.Drawing.Size(94, 15)
        Me.lblPublicados.TabIndex = 0
        Me.lblPublicados.Text = "Lista premios"
        '
        'limpiar
        '
        Me.limpiar.Image = Global.GUI.My.Resources.Resources.limpiarCampos
        Me.limpiar.Location = New System.Drawing.Point(283, 233)
        Me.limpiar.Name = "limpiar"
        Me.limpiar.Size = New System.Drawing.Size(36, 27)
        Me.limpiar.TabIndex = 14
        Me.limpiar.UseVisualStyleBackColor = True
        '
        'btModificar
        '
        Me.btModificar.Image = Global.GUI.My.Resources.Resources.editar
        Me.btModificar.Location = New System.Drawing.Point(175, 233)
        Me.btModificar.Name = "btModificar"
        Me.btModificar.Size = New System.Drawing.Size(36, 27)
        Me.btModificar.TabIndex = 12
        Me.btModificar.UseVisualStyleBackColor = True
        '
        'btEliminar
        '
        Me.btEliminar.Image = Global.GUI.My.Resources.Resources.borrar
        Me.btEliminar.Location = New System.Drawing.Point(229, 233)
        Me.btEliminar.Name = "btEliminar"
        Me.btEliminar.Size = New System.Drawing.Size(36, 27)
        Me.btEliminar.TabIndex = 11
        Me.btEliminar.UseVisualStyleBackColor = True
        '
        'btAgregar
        '
        Me.btAgregar.Image = Global.GUI.My.Resources.Resources.agregar
        Me.btAgregar.Location = New System.Drawing.Point(114, 233)
        Me.btAgregar.Name = "btAgregar"
        Me.btAgregar.Size = New System.Drawing.Size(36, 27)
        Me.btAgregar.TabIndex = 9
        Me.btAgregar.UseVisualStyleBackColor = True
        '
        'btBuscarPelicula
        '
        Me.btBuscarPelicula.Image = Global.GUI.My.Resources.Resources.busqueda
        Me.btBuscarPelicula.Location = New System.Drawing.Point(283, 64)
        Me.btBuscarPelicula.Name = "btBuscarPelicula"
        Me.btBuscarPelicula.Size = New System.Drawing.Size(36, 21)
        Me.btBuscarPelicula.TabIndex = 8
        Me.btBuscarPelicula.UseVisualStyleBackColor = True
        '
        'txtTituloPelicula
        '
        Me.txtTituloPelicula.Location = New System.Drawing.Point(114, 97)
        Me.txtTituloPelicula.Name = "txtTituloPelicula"
        Me.txtTituloPelicula.ReadOnly = True
        Me.txtTituloPelicula.Size = New System.Drawing.Size(205, 20)
        Me.txtTituloPelicula.TabIndex = 83
        '
        'lbTituloPelicula
        '
        Me.lbTituloPelicula.AutoSize = True
        Me.lbTituloPelicula.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTituloPelicula.Location = New System.Drawing.Point(22, 100)
        Me.lbTituloPelicula.Name = "lbTituloPelicula"
        Me.lbTituloPelicula.Size = New System.Drawing.Size(93, 13)
        Me.lbTituloPelicula.TabIndex = 84
        Me.lbTituloPelicula.Text = "Titulo de Película:"
        '
        'frmPremios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(805, 313)
        Me.Controls.Add(Me.txtTituloPelicula)
        Me.Controls.Add(Me.lbTituloPelicula)
        Me.Controls.Add(Me.Panel13)
        Me.Controls.Add(Me.limpiar)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btModificar)
        Me.Controls.Add(Me.btEliminar)
        Me.Controls.Add(Me.dgvPremios)
        Me.Controls.Add(Me.btAgregar)
        Me.Controls.Add(Me.btBuscarPelicula)
        Me.Controls.Add(Me.txtCiudad)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtNombreCertamen)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtNombrePremio)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtIdPeli)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmPremios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Premios"
        CType(Me.dgvPremios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel13.ResumeLayout(False)
        Me.Panel13.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtIdPeli As System.Windows.Forms.TextBox
    Friend WithEvents txtNombrePremio As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtNombreCertamen As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtCiudad As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btBuscarPelicula As System.Windows.Forms.Button
    Friend WithEvents btAgregar As System.Windows.Forms.Button
    Friend WithEvents dgvPremios As System.Windows.Forms.DataGridView
    Friend WithEvents btEliminar As System.Windows.Forms.Button
    Friend WithEvents btModificar As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents limpiar As System.Windows.Forms.Button
    Friend WithEvents Panel13 As System.Windows.Forms.Panel
    Friend WithEvents lblPublicados As System.Windows.Forms.Label
    Friend WithEvents txtTituloPelicula As System.Windows.Forms.TextBox
    Friend WithEvents lbTituloPelicula As System.Windows.Forms.Label
End Class
