<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLugar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLugar))
        Me.Panel13 = New System.Windows.Forms.Panel()
        Me.lblPublicados = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dgv_Lugares = New System.Windows.Forms.DataGridView()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.lbNombre = New System.Windows.Forms.Label()
        Me.limpiar = New System.Windows.Forms.Button()
        Me.btEliminar = New System.Windows.Forms.Button()
        Me.btModificar = New System.Windows.Forms.Button()
        Me.btInsertar = New System.Windows.Forms.Button()
        Me.Panel13.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.dgv_Lugares, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel13
        '
        Me.Panel13.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel13.Controls.Add(Me.lblPublicados)
        Me.Panel13.Location = New System.Drawing.Point(237, 55)
        Me.Panel13.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel13.Name = "Panel13"
        Me.Panel13.Size = New System.Drawing.Size(231, 28)
        Me.Panel13.TabIndex = 53
        '
        'lblPublicados
        '
        Me.lblPublicados.AutoSize = True
        Me.lblPublicados.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPublicados.Location = New System.Drawing.Point(75, 5)
        Me.lblPublicados.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblPublicados.Name = "lblPublicados"
        Me.lblPublicados.Size = New System.Drawing.Size(90, 15)
        Me.lblPublicados.TabIndex = 0
        Me.lblPublicados.Text = "Lista lugares"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Location = New System.Drawing.Point(-1, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(469, 54)
        Me.Panel1.TabIndex = 52
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(190, 12)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(97, 25)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Lugares"
        '
        'dgv_Lugares
        '
        Me.dgv_Lugares.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgv_Lugares.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_Lugares.Location = New System.Drawing.Point(237, 84)
        Me.dgv_Lugares.Name = "dgv_Lugares"
        Me.dgv_Lugares.Size = New System.Drawing.Size(231, 215)
        Me.dgv_Lugares.TabIndex = 51
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(62, 70)
        Me.txtNombre.MaxLength = 20
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(158, 20)
        Me.txtNombre.TabIndex = 41
        '
        'lbNombre
        '
        Me.lbNombre.AutoSize = True
        Me.lbNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbNombre.Location = New System.Drawing.Point(9, 73)
        Me.lbNombre.Name = "lbNombre"
        Me.lbNombre.Size = New System.Drawing.Size(47, 13)
        Me.lbNombre.TabIndex = 44
        Me.lbNombre.Text = "Nombre:"
        '
        'limpiar
        '
        Me.limpiar.Image = Global.GUI.My.Resources.Resources.limpiarCampos
        Me.limpiar.Location = New System.Drawing.Point(183, 100)
        Me.limpiar.Name = "limpiar"
        Me.limpiar.Size = New System.Drawing.Size(37, 27)
        Me.limpiar.TabIndex = 50
        Me.limpiar.UseVisualStyleBackColor = True
        '
        'btEliminar
        '
        Me.btEliminar.Image = Global.GUI.My.Resources.Resources.borrar
        Me.btEliminar.Location = New System.Drawing.Point(142, 100)
        Me.btEliminar.Name = "btEliminar"
        Me.btEliminar.Size = New System.Drawing.Size(37, 27)
        Me.btEliminar.TabIndex = 49
        Me.btEliminar.UseVisualStyleBackColor = True
        '
        'btModificar
        '
        Me.btModificar.Image = Global.GUI.My.Resources.Resources.editar
        Me.btModificar.Location = New System.Drawing.Point(102, 100)
        Me.btModificar.Name = "btModificar"
        Me.btModificar.Size = New System.Drawing.Size(37, 27)
        Me.btModificar.TabIndex = 47
        Me.btModificar.UseVisualStyleBackColor = True
        '
        'btInsertar
        '
        Me.btInsertar.Image = Global.GUI.My.Resources.Resources.agregar
        Me.btInsertar.Location = New System.Drawing.Point(62, 100)
        Me.btInsertar.Name = "btInsertar"
        Me.btInsertar.Size = New System.Drawing.Size(37, 27)
        Me.btInsertar.TabIndex = 48
        Me.btInsertar.UseVisualStyleBackColor = True
        '
        'frmLugar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(467, 304)
        Me.Controls.Add(Me.Panel13)
        Me.Controls.Add(Me.limpiar)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btEliminar)
        Me.Controls.Add(Me.dgv_Lugares)
        Me.Controls.Add(Me.btModificar)
        Me.Controls.Add(Me.btInsertar)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.lbNombre)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmLugar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lugares"
        Me.Panel13.ResumeLayout(False)
        Me.Panel13.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgv_Lugares, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel13 As System.Windows.Forms.Panel
    Friend WithEvents lblPublicados As System.Windows.Forms.Label
    Friend WithEvents limpiar As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btEliminar As System.Windows.Forms.Button
    Friend WithEvents dgv_Lugares As System.Windows.Forms.DataGridView
    Friend WithEvents btModificar As System.Windows.Forms.Button
    Friend WithEvents btInsertar As System.Windows.Forms.Button
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents lbNombre As System.Windows.Forms.Label
End Class
