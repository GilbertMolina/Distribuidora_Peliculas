<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPremiosPorPelicula
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPremiosPorPelicula))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtIdPeli = New System.Windows.Forms.TextBox()
        Me.txtNombrePeli = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtPaisOrigen = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dgvPremiosPorPeli = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel13 = New System.Windows.Forms.Panel()
        Me.lblPublicados = New System.Windows.Forms.Label()
        Me.btBuscar = New System.Windows.Forms.Button()
        Me.btBuscarPelicula = New System.Windows.Forms.Button()
        CType(Me.dgvPremiosPorPeli, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel13.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 83)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Código Película:"
        '
        'txtIdPeli
        '
        Me.txtIdPeli.Location = New System.Drawing.Point(104, 80)
        Me.txtIdPeli.Name = "txtIdPeli"
        Me.txtIdPeli.ReadOnly = True
        Me.txtIdPeli.Size = New System.Drawing.Size(114, 20)
        Me.txtIdPeli.TabIndex = 1
        '
        'txtNombrePeli
        '
        Me.txtNombrePeli.Location = New System.Drawing.Point(104, 109)
        Me.txtNombrePeli.Name = "txtNombrePeli"
        Me.txtNombrePeli.ReadOnly = True
        Me.txtNombrePeli.Size = New System.Drawing.Size(152, 20)
        Me.txtNombrePeli.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(13, 112)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nombre Película:"
        '
        'txtPaisOrigen
        '
        Me.txtPaisOrigen.Location = New System.Drawing.Point(104, 141)
        Me.txtPaisOrigen.Name = "txtPaisOrigen"
        Me.txtPaisOrigen.ReadOnly = True
        Me.txtPaisOrigen.Size = New System.Drawing.Size(152, 20)
        Me.txtPaisOrigen.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(13, 144)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "País origen:"
        '
        'dgvPremiosPorPeli
        '
        Me.dgvPremiosPorPeli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPremiosPorPeli.Location = New System.Drawing.Point(269, 90)
        Me.dgvPremiosPorPeli.Name = "dgvPremiosPorPeli"
        Me.dgvPremiosPorPeli.Size = New System.Drawing.Size(445, 217)
        Me.dgvPremiosPorPeli.TabIndex = 8
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Location = New System.Drawing.Point(0, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(714, 58)
        Me.Panel1.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(244, 15)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(229, 25)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Premios por Película"
        '
        'Panel13
        '
        Me.Panel13.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel13.Controls.Add(Me.lblPublicados)
        Me.Panel13.Location = New System.Drawing.Point(269, 61)
        Me.Panel13.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel13.Name = "Panel13"
        Me.Panel13.Size = New System.Drawing.Size(445, 28)
        Me.Panel13.TabIndex = 44
        '
        'lblPublicados
        '
        Me.lblPublicados.AutoSize = True
        Me.lblPublicados.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPublicados.Location = New System.Drawing.Point(142, 5)
        Me.lblPublicados.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblPublicados.Name = "lblPublicados"
        Me.lblPublicados.Size = New System.Drawing.Size(174, 15)
        Me.lblPublicados.TabIndex = 0
        Me.lblPublicados.Text = "Lista premios por película"
        '
        'btBuscar
        '
        Me.btBuscar.Image = CType(resources.GetObject("btBuscar.Image"), System.Drawing.Image)
        Me.btBuscar.Location = New System.Drawing.Point(223, 167)
        Me.btBuscar.Name = "btBuscar"
        Me.btBuscar.Size = New System.Drawing.Size(33, 33)
        Me.btBuscar.TabIndex = 7
        Me.btBuscar.UseVisualStyleBackColor = True
        '
        'btBuscarPelicula
        '
        Me.btBuscarPelicula.Image = Global.GUI.My.Resources.Resources.busqueda
        Me.btBuscarPelicula.Location = New System.Drawing.Point(224, 78)
        Me.btBuscarPelicula.Name = "btBuscarPelicula"
        Me.btBuscarPelicula.Size = New System.Drawing.Size(33, 25)
        Me.btBuscarPelicula.TabIndex = 6
        Me.btBuscarPelicula.UseVisualStyleBackColor = True
        '
        'frmPremiosPorPelicula
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(714, 313)
        Me.Controls.Add(Me.Panel13)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.dgvPremiosPorPeli)
        Me.Controls.Add(Me.btBuscar)
        Me.Controls.Add(Me.btBuscarPelicula)
        Me.Controls.Add(Me.txtPaisOrigen)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtNombrePeli)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtIdPeli)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmPremiosPorPelicula"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Premios por Película"
        CType(Me.dgvPremiosPorPeli, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel13.ResumeLayout(False)
        Me.Panel13.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtIdPeli As System.Windows.Forms.TextBox
    Friend WithEvents txtNombrePeli As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtPaisOrigen As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btBuscarPelicula As System.Windows.Forms.Button
    Friend WithEvents btBuscar As System.Windows.Forms.Button
    Friend WithEvents dgvPremiosPorPeli As System.Windows.Forms.DataGridView
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Panel13 As System.Windows.Forms.Panel
    Friend WithEvents lblPublicados As System.Windows.Forms.Label
End Class
