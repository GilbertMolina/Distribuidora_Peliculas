<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBusquedaLugar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBusquedaLugar))
        Me.Panel13 = New System.Windows.Forms.Panel()
        Me.lblPublicados = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.dgv_Lugares = New System.Windows.Forms.DataGridView()
        Me.lbBuscar = New System.Windows.Forms.Label()
        Me.btBuscar = New System.Windows.Forms.Button()
        Me.btSeleccionar = New System.Windows.Forms.Button()
        Me.Panel13.SuspendLayout()
        CType(Me.dgv_Lugares, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel13
        '
        Me.Panel13.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel13.Controls.Add(Me.lblPublicados)
        Me.Panel13.Location = New System.Drawing.Point(20, 45)
        Me.Panel13.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel13.Name = "Panel13"
        Me.Panel13.Size = New System.Drawing.Size(385, 28)
        Me.Panel13.TabIndex = 51
        '
        'lblPublicados
        '
        Me.lblPublicados.AutoSize = True
        Me.lblPublicados.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPublicados.Location = New System.Drawing.Point(118, 4)
        Me.lblPublicados.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblPublicados.Name = "lblPublicados"
        Me.lblPublicados.Size = New System.Drawing.Size(139, 15)
        Me.lblPublicados.TabIndex = 0
        Me.lblPublicados.Text = "Resultado búsqueda"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(123, 16)
        Me.txtNombre.Margin = New System.Windows.Forms.Padding(2)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(208, 20)
        Me.txtNombre.TabIndex = 49
        '
        'dgv_Lugares
        '
        Me.dgv_Lugares.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_Lugares.Location = New System.Drawing.Point(20, 75)
        Me.dgv_Lugares.Margin = New System.Windows.Forms.Padding(2)
        Me.dgv_Lugares.Name = "dgv_Lugares"
        Me.dgv_Lugares.RowTemplate.Height = 24
        Me.dgv_Lugares.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_Lugares.Size = New System.Drawing.Size(385, 156)
        Me.dgv_Lugares.TabIndex = 47
        '
        'lbBuscar
        '
        Me.lbBuscar.AutoSize = True
        Me.lbBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbBuscar.Location = New System.Drawing.Point(70, 19)
        Me.lbBuscar.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbBuscar.Name = "lbBuscar"
        Me.lbBuscar.Size = New System.Drawing.Size(43, 13)
        Me.lbBuscar.TabIndex = 46
        Me.lbBuscar.Text = "Buscar:"
        '
        'btBuscar
        '
        Me.btBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btBuscar.Image = Global.GUI.My.Resources.Resources.busqueda
        Me.btBuscar.Location = New System.Drawing.Point(336, 15)
        Me.btBuscar.Name = "btBuscar"
        Me.btBuscar.Size = New System.Drawing.Size(36, 21)
        Me.btBuscar.TabIndex = 50
        Me.btBuscar.UseVisualStyleBackColor = True
        '
        'btSeleccionar
        '
        Me.btSeleccionar.Image = Global.GUI.My.Resources.Resources.seleccionar
        Me.btSeleccionar.Location = New System.Drawing.Point(360, 235)
        Me.btSeleccionar.Margin = New System.Windows.Forms.Padding(2)
        Me.btSeleccionar.Name = "btSeleccionar"
        Me.btSeleccionar.Size = New System.Drawing.Size(45, 24)
        Me.btSeleccionar.TabIndex = 48
        Me.btSeleccionar.UseVisualStyleBackColor = True
        '
        'frmBusquedaLugar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(425, 270)
        Me.Controls.Add(Me.Panel13)
        Me.Controls.Add(Me.btBuscar)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.btSeleccionar)
        Me.Controls.Add(Me.dgv_Lugares)
        Me.Controls.Add(Me.lbBuscar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmBusquedaLugar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Búsqueda Lugar"
        Me.Panel13.ResumeLayout(False)
        Me.Panel13.PerformLayout()
        CType(Me.dgv_Lugares, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel13 As System.Windows.Forms.Panel
    Friend WithEvents lblPublicados As System.Windows.Forms.Label
    Friend WithEvents btBuscar As System.Windows.Forms.Button
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents btSeleccionar As System.Windows.Forms.Button
    Friend WithEvents dgv_Lugares As System.Windows.Forms.DataGridView
    Friend WithEvents lbBuscar As System.Windows.Forms.Label
End Class
