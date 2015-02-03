<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProductor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProductor))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtApellido1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtApellido2 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dgvProductores = New System.Windows.Forms.DataGridView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btAgregar = New System.Windows.Forms.Button()
        Me.btEditar = New System.Windows.Forms.Button()
        Me.btEliminar = New System.Windows.Forms.Button()
        Me.btLimpiar = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.dgvProductores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 75)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre:"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(107, 72)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(160, 20)
        Me.txtNombre.TabIndex = 1
        '
        'txtApellido1
        '
        Me.txtApellido1.Location = New System.Drawing.Point(107, 109)
        Me.txtApellido1.Name = "txtApellido1"
        Me.txtApellido1.Size = New System.Drawing.Size(160, 20)
        Me.txtApellido1.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 112)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Primer Apellido:"
        '
        'txtApellido2
        '
        Me.txtApellido2.Location = New System.Drawing.Point(107, 144)
        Me.txtApellido2.Name = "txtApellido2"
        Me.txtApellido2.Size = New System.Drawing.Size(160, 20)
        Me.txtApellido2.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 147)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Segundo Apellido:"
        '
        'dgvProductores
        '
        Me.dgvProductores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProductores.Location = New System.Drawing.Point(291, 86)
        Me.dgvProductores.Name = "dgvProductores"
        Me.dgvProductores.Size = New System.Drawing.Size(404, 174)
        Me.dgvProductores.TabIndex = 7
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Location = New System.Drawing.Point(291, 55)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(404, 30)
        Me.Panel2.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(147, 5)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(129, 16)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Lista Productores"
        '
        'btAgregar
        '
        Me.btAgregar.Image = Global.GUI.My.Resources.Resources.agregar
        Me.btAgregar.Location = New System.Drawing.Point(107, 178)
        Me.btAgregar.Name = "btAgregar"
        Me.btAgregar.Size = New System.Drawing.Size(35, 25)
        Me.btAgregar.TabIndex = 9
        Me.btAgregar.UseVisualStyleBackColor = True
        '
        'btEditar
        '
        Me.btEditar.Image = Global.GUI.My.Resources.Resources.editar
        Me.btEditar.Location = New System.Drawing.Point(148, 178)
        Me.btEditar.Name = "btEditar"
        Me.btEditar.Size = New System.Drawing.Size(35, 25)
        Me.btEditar.TabIndex = 10
        Me.btEditar.UseVisualStyleBackColor = True
        '
        'btEliminar
        '
        Me.btEliminar.Image = Global.GUI.My.Resources.Resources.borrar
        Me.btEliminar.Location = New System.Drawing.Point(189, 178)
        Me.btEliminar.Name = "btEliminar"
        Me.btEliminar.Size = New System.Drawing.Size(36, 25)
        Me.btEliminar.TabIndex = 11
        Me.btEliminar.UseVisualStyleBackColor = True
        '
        'btLimpiar
        '
        Me.btLimpiar.Image = Global.GUI.My.Resources.Resources.limpiarCampos
        Me.btLimpiar.Location = New System.Drawing.Point(231, 178)
        Me.btLimpiar.Name = "btLimpiar"
        Me.btLimpiar.Size = New System.Drawing.Size(36, 25)
        Me.btLimpiar.TabIndex = 12
        Me.btLimpiar.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Location = New System.Drawing.Point(-1, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(696, 54)
        Me.Panel1.TabIndex = 41
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(269, 14)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(139, 25)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Productores"
        '
        'frmProductor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(695, 270)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btLimpiar)
        Me.Controls.Add(Me.btEliminar)
        Me.Controls.Add(Me.btEditar)
        Me.Controls.Add(Me.btAgregar)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.dgvProductores)
        Me.Controls.Add(Me.txtApellido2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtApellido1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmProductor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Productor"
        CType(Me.dgvProductores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents txtApellido1 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtApellido2 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dgvProductores As System.Windows.Forms.DataGridView
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btAgregar As System.Windows.Forms.Button
    Friend WithEvents btEditar As System.Windows.Forms.Button
    Friend WithEvents btEliminar As System.Windows.Forms.Button
    Friend WithEvents btLimpiar As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
