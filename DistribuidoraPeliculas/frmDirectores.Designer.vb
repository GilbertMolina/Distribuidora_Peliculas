<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDirectores
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDirectores))
        Me.lbPrimerApellido = New System.Windows.Forms.Label()
        Me.lbNombre = New System.Windows.Forms.Label()
        Me.lbSegundoApellido = New System.Windows.Forms.Label()
        Me.txtSegundoApellido = New System.Windows.Forms.TextBox()
        Me.txtPrimerApellido = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.dgv_Directores = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel13 = New System.Windows.Forms.Panel()
        Me.lblPublicados = New System.Windows.Forms.Label()
        Me.limpiar = New System.Windows.Forms.Button()
        Me.btEliminar = New System.Windows.Forms.Button()
        Me.btModificar = New System.Windows.Forms.Button()
        Me.btInsertar = New System.Windows.Forms.Button()
        CType(Me.dgv_Directores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel13.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbPrimerApellido
        '
        Me.lbPrimerApellido.AutoSize = True
        Me.lbPrimerApellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbPrimerApellido.Location = New System.Drawing.Point(13, 121)
        Me.lbPrimerApellido.Name = "lbPrimerApellido"
        Me.lbPrimerApellido.Size = New System.Drawing.Size(78, 13)
        Me.lbPrimerApellido.TabIndex = 1
        Me.lbPrimerApellido.Text = "Primer apellido:"
        '
        'lbNombre
        '
        Me.lbNombre.AutoSize = True
        Me.lbNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbNombre.Location = New System.Drawing.Point(13, 95)
        Me.lbNombre.Name = "lbNombre"
        Me.lbNombre.Size = New System.Drawing.Size(47, 13)
        Me.lbNombre.TabIndex = 2
        Me.lbNombre.Text = "Nombre:"
        '
        'lbSegundoApellido
        '
        Me.lbSegundoApellido.AutoSize = True
        Me.lbSegundoApellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbSegundoApellido.Location = New System.Drawing.Point(13, 147)
        Me.lbSegundoApellido.Name = "lbSegundoApellido"
        Me.lbSegundoApellido.Size = New System.Drawing.Size(92, 13)
        Me.lbSegundoApellido.TabIndex = 3
        Me.lbSegundoApellido.Text = "Segundo apellido:"
        '
        'txtSegundoApellido
        '
        Me.txtSegundoApellido.Location = New System.Drawing.Point(110, 144)
        Me.txtSegundoApellido.MaxLength = 50
        Me.txtSegundoApellido.Name = "txtSegundoApellido"
        Me.txtSegundoApellido.Size = New System.Drawing.Size(158, 20)
        Me.txtSegundoApellido.TabIndex = 3
        '
        'txtPrimerApellido
        '
        Me.txtPrimerApellido.Location = New System.Drawing.Point(110, 118)
        Me.txtPrimerApellido.MaxLength = 50
        Me.txtPrimerApellido.Name = "txtPrimerApellido"
        Me.txtPrimerApellido.Size = New System.Drawing.Size(158, 20)
        Me.txtPrimerApellido.TabIndex = 2
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(110, 92)
        Me.txtNombre.MaxLength = 20
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(158, 20)
        Me.txtNombre.TabIndex = 1
        '
        'dgv_Directores
        '
        Me.dgv_Directores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgv_Directores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_Directores.Location = New System.Drawing.Point(288, 86)
        Me.dgv_Directores.Name = "dgv_Directores"
        Me.dgv_Directores.Size = New System.Drawing.Size(376, 215)
        Me.dgv_Directores.TabIndex = 18
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(664, 54)
        Me.Panel1.TabIndex = 19
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(263, 12)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(120, 25)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Directores"
        '
        'Panel13
        '
        Me.Panel13.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel13.Controls.Add(Me.lblPublicados)
        Me.Panel13.Location = New System.Drawing.Point(288, 57)
        Me.Panel13.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel13.Name = "Panel13"
        Me.Panel13.Size = New System.Drawing.Size(381, 28)
        Me.Panel13.TabIndex = 40
        '
        'lblPublicados
        '
        Me.lblPublicados.AutoSize = True
        Me.lblPublicados.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPublicados.Location = New System.Drawing.Point(140, 4)
        Me.lblPublicados.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblPublicados.Name = "lblPublicados"
        Me.lblPublicados.Size = New System.Drawing.Size(106, 15)
        Me.lblPublicados.TabIndex = 0
        Me.lblPublicados.Text = "Lista directores"
        '
        'limpiar
        '
        Me.limpiar.Image = Global.GUI.My.Resources.Resources.limpiarCampos
        Me.limpiar.Location = New System.Drawing.Point(231, 174)
        Me.limpiar.Name = "limpiar"
        Me.limpiar.Size = New System.Drawing.Size(37, 27)
        Me.limpiar.TabIndex = 7
        Me.limpiar.UseVisualStyleBackColor = True
        '
        'btEliminar
        '
        Me.btEliminar.Image = Global.GUI.My.Resources.Resources.borrar
        Me.btEliminar.Location = New System.Drawing.Point(190, 174)
        Me.btEliminar.Name = "btEliminar"
        Me.btEliminar.Size = New System.Drawing.Size(37, 27)
        Me.btEliminar.TabIndex = 6
        Me.btEliminar.UseVisualStyleBackColor = True
        '
        'btModificar
        '
        Me.btModificar.Image = Global.GUI.My.Resources.Resources.editar
        Me.btModificar.Location = New System.Drawing.Point(150, 174)
        Me.btModificar.Name = "btModificar"
        Me.btModificar.Size = New System.Drawing.Size(37, 27)
        Me.btModificar.TabIndex = 4
        Me.btModificar.UseVisualStyleBackColor = True
        '
        'btInsertar
        '
        Me.btInsertar.Image = Global.GUI.My.Resources.Resources.agregar
        Me.btInsertar.Location = New System.Drawing.Point(110, 174)
        Me.btInsertar.Name = "btInsertar"
        Me.btInsertar.Size = New System.Drawing.Size(37, 27)
        Me.btInsertar.TabIndex = 5
        Me.btInsertar.UseVisualStyleBackColor = True
        '
        'frmDirectores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(662, 309)
        Me.Controls.Add(Me.Panel13)
        Me.Controls.Add(Me.limpiar)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btEliminar)
        Me.Controls.Add(Me.dgv_Directores)
        Me.Controls.Add(Me.btModificar)
        Me.Controls.Add(Me.btInsertar)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.txtPrimerApellido)
        Me.Controls.Add(Me.txtSegundoApellido)
        Me.Controls.Add(Me.lbSegundoApellido)
        Me.Controls.Add(Me.lbNombre)
        Me.Controls.Add(Me.lbPrimerApellido)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmDirectores"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Directores"
        CType(Me.dgv_Directores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel13.ResumeLayout(False)
        Me.Panel13.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbPrimerApellido As System.Windows.Forms.Label
    Friend WithEvents lbNombre As System.Windows.Forms.Label
    Friend WithEvents lbSegundoApellido As System.Windows.Forms.Label
    Friend WithEvents txtSegundoApellido As System.Windows.Forms.TextBox
    Friend WithEvents txtPrimerApellido As System.Windows.Forms.TextBox
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents btInsertar As System.Windows.Forms.Button
    Friend WithEvents btModificar As System.Windows.Forms.Button
    Friend WithEvents btEliminar As System.Windows.Forms.Button
    Friend WithEvents dgv_Directores As System.Windows.Forms.DataGridView
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents limpiar As System.Windows.Forms.Button
    Friend WithEvents Panel13 As System.Windows.Forms.Panel
    Friend WithEvents lblPublicados As System.Windows.Forms.Label
End Class
