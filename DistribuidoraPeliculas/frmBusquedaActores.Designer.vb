<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBusquedaActores
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBusquedaActores))
        Me.Panel13 = New System.Windows.Forms.Panel()
        Me.lblPublicados = New System.Windows.Forms.Label()
        Me.txtTitulo = New System.Windows.Forms.TextBox()
        Me.dgv_Actores = New System.Windows.Forms.DataGridView()
        Me.lbBuscar = New System.Windows.Forms.Label()
        Me.btBuscar = New System.Windows.Forms.Button()
        Me.btSeleccionar = New System.Windows.Forms.Button()
        Me.Panel13.SuspendLayout()
        CType(Me.dgv_Actores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel13
        '
        Me.Panel13.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel13.Controls.Add(Me.lblPublicados)
        Me.Panel13.Location = New System.Drawing.Point(28, 39)
        Me.Panel13.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
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
        'txtTitulo
        '
        Me.txtTitulo.Location = New System.Drawing.Point(131, 10)
        Me.txtTitulo.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtTitulo.Name = "txtTitulo"
        Me.txtTitulo.Size = New System.Drawing.Size(208, 20)
        Me.txtTitulo.TabIndex = 49
        '
        'dgv_Actores
        '
        Me.dgv_Actores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_Actores.Location = New System.Drawing.Point(28, 69)
        Me.dgv_Actores.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dgv_Actores.Name = "dgv_Actores"
        Me.dgv_Actores.RowTemplate.Height = 24
        Me.dgv_Actores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_Actores.Size = New System.Drawing.Size(385, 156)
        Me.dgv_Actores.TabIndex = 47
        '
        'lbBuscar
        '
        Me.lbBuscar.AutoSize = True
        Me.lbBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbBuscar.Location = New System.Drawing.Point(78, 13)
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
        Me.btBuscar.Location = New System.Drawing.Point(344, 9)
        Me.btBuscar.Name = "btBuscar"
        Me.btBuscar.Size = New System.Drawing.Size(36, 21)
        Me.btBuscar.TabIndex = 50
        Me.btBuscar.UseVisualStyleBackColor = True
        '
        'btSeleccionar
        '
        Me.btSeleccionar.Image = Global.GUI.My.Resources.Resources.seleccionar
        Me.btSeleccionar.Location = New System.Drawing.Point(368, 229)
        Me.btSeleccionar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btSeleccionar.Name = "btSeleccionar"
        Me.btSeleccionar.Size = New System.Drawing.Size(45, 24)
        Me.btSeleccionar.TabIndex = 48
        Me.btSeleccionar.UseVisualStyleBackColor = True
        '
        'frmBusquedaActor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(441, 262)
        Me.Controls.Add(Me.Panel13)
        Me.Controls.Add(Me.btBuscar)
        Me.Controls.Add(Me.txtTitulo)
        Me.Controls.Add(Me.btSeleccionar)
        Me.Controls.Add(Me.dgv_Actores)
        Me.Controls.Add(Me.lbBuscar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmBusquedaActor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Busqueda de Actores"
        Me.Panel13.ResumeLayout(False)
        Me.Panel13.PerformLayout()
        CType(Me.dgv_Actores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel13 As System.Windows.Forms.Panel
    Friend WithEvents lblPublicados As System.Windows.Forms.Label
    Friend WithEvents btBuscar As System.Windows.Forms.Button
    Friend WithEvents txtTitulo As System.Windows.Forms.TextBox
    Friend WithEvents btSeleccionar As System.Windows.Forms.Button
    Friend WithEvents dgv_Actores As System.Windows.Forms.DataGridView
    Friend WithEvents lbBuscar As System.Windows.Forms.Label
End Class
