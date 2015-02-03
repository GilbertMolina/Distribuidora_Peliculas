<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBusquedaDirector
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBusquedaDirector))
        Me.dgv_Directores = New System.Windows.Forms.DataGridView()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.lbBuscar = New System.Windows.Forms.Label()
        Me.Panel13 = New System.Windows.Forms.Panel()
        Me.lblPublicados = New System.Windows.Forms.Label()
        Me.btBuscar = New System.Windows.Forms.Button()
        Me.btSeleccionar = New System.Windows.Forms.Button()
        CType(Me.dgv_Directores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel13.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgv_Directores
        '
        Me.dgv_Directores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_Directores.Location = New System.Drawing.Point(33, 80)
        Me.dgv_Directores.Margin = New System.Windows.Forms.Padding(2)
        Me.dgv_Directores.Name = "dgv_Directores"
        Me.dgv_Directores.RowTemplate.Height = 24
        Me.dgv_Directores.Size = New System.Drawing.Size(381, 156)
        Me.dgv_Directores.TabIndex = 34
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(138, 21)
        Me.txtNombre.Margin = New System.Windows.Forms.Padding(2)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(208, 20)
        Me.txtNombre.TabIndex = 33
        '
        'lbBuscar
        '
        Me.lbBuscar.AutoSize = True
        Me.lbBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbBuscar.Location = New System.Drawing.Point(84, 24)
        Me.lbBuscar.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbBuscar.Name = "lbBuscar"
        Me.lbBuscar.Size = New System.Drawing.Size(43, 13)
        Me.lbBuscar.TabIndex = 32
        Me.lbBuscar.Text = "Buscar:"
        '
        'Panel13
        '
        Me.Panel13.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel13.Controls.Add(Me.lblPublicados)
        Me.Panel13.Location = New System.Drawing.Point(33, 51)
        Me.Panel13.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel13.Name = "Panel13"
        Me.Panel13.Size = New System.Drawing.Size(381, 28)
        Me.Panel13.TabIndex = 39
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
        'btBuscar
        '
        Me.btBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btBuscar.Image = Global.GUI.My.Resources.Resources.busqueda
        Me.btBuscar.Location = New System.Drawing.Point(350, 20)
        Me.btBuscar.Name = "btBuscar"
        Me.btBuscar.Size = New System.Drawing.Size(35, 21)
        Me.btBuscar.TabIndex = 38
        Me.btBuscar.UseVisualStyleBackColor = True
        '
        'btSeleccionar
        '
        Me.btSeleccionar.Image = Global.GUI.My.Resources.Resources.seleccionar
        Me.btSeleccionar.Location = New System.Drawing.Point(369, 240)
        Me.btSeleccionar.Margin = New System.Windows.Forms.Padding(2)
        Me.btSeleccionar.Name = "btSeleccionar"
        Me.btSeleccionar.Size = New System.Drawing.Size(45, 24)
        Me.btSeleccionar.TabIndex = 35
        Me.btSeleccionar.UseVisualStyleBackColor = True
        '
        'frmBusquedaDirector
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(441, 273)
        Me.Controls.Add(Me.Panel13)
        Me.Controls.Add(Me.btBuscar)
        Me.Controls.Add(Me.btSeleccionar)
        Me.Controls.Add(Me.dgv_Directores)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.lbBuscar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmBusquedaDirector"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Búsqueda Director"
        CType(Me.dgv_Directores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel13.ResumeLayout(False)
        Me.Panel13.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btSeleccionar As System.Windows.Forms.Button
    Friend WithEvents dgv_Directores As System.Windows.Forms.DataGridView
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents lbBuscar As System.Windows.Forms.Label
    Friend WithEvents btBuscar As System.Windows.Forms.Button
    Friend WithEvents Panel13 As System.Windows.Forms.Panel
    Friend WithEvents lblPublicados As System.Windows.Forms.Label
End Class
