<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmActoresPorPelicula
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmActoresPorPelicula))
        Me.btBuscarPelicula = New System.Windows.Forms.Button()
        Me.Panel13 = New System.Windows.Forms.Panel()
        Me.lblPublicados = New System.Windows.Forms.Label()
        Me.btModificar = New System.Windows.Forms.Button()
        Me.limpiar = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btBuscarLugar = New System.Windows.Forms.Button()
        Me.txtIdActor = New System.Windows.Forms.TextBox()
        Me.lbIdDirector = New System.Windows.Forms.Label()
        Me.btEliminar = New System.Windows.Forms.Button()
        Me.dgv_ActoresPelicula = New System.Windows.Forms.DataGridView()
        Me.btInsertar = New System.Windows.Forms.Button()
        Me.txtIdPelicula = New System.Windows.Forms.TextBox()
        Me.lbTitulo = New System.Windows.Forms.Label()
        Me.txtPapel = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtSueldo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNombreActor = New System.Windows.Forms.TextBox()
        Me.lbNombreActor = New System.Windows.Forms.Label()
        Me.txtTituloPelicula = New System.Windows.Forms.TextBox()
        Me.lbTituloPelicula = New System.Windows.Forms.Label()
        Me.Panel13.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.dgv_ActoresPelicula, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btBuscarPelicula
        '
        Me.btBuscarPelicula.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btBuscarPelicula.Image = Global.GUI.My.Resources.Resources.busqueda
        Me.btBuscarPelicula.Location = New System.Drawing.Point(270, 121)
        Me.btBuscarPelicula.Name = "btBuscarPelicula"
        Me.btBuscarPelicula.Size = New System.Drawing.Size(38, 23)
        Me.btBuscarPelicula.TabIndex = 74
        Me.btBuscarPelicula.UseVisualStyleBackColor = True
        '
        'Panel13
        '
        Me.Panel13.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel13.Controls.Add(Me.lblPublicados)
        Me.Panel13.Location = New System.Drawing.Point(316, 56)
        Me.Panel13.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel13.Name = "Panel13"
        Me.Panel13.Size = New System.Drawing.Size(456, 28)
        Me.Panel13.TabIndex = 73
        '
        'lblPublicados
        '
        Me.lblPublicados.AutoSize = True
        Me.lblPublicados.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPublicados.Location = New System.Drawing.Point(141, 4)
        Me.lblPublicados.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblPublicados.Name = "lblPublicados"
        Me.lblPublicados.Size = New System.Drawing.Size(190, 15)
        Me.lblPublicados.TabIndex = 0
        Me.lblPublicados.Text = "Lista de Actores por Pelicula"
        '
        'btModificar
        '
        Me.btModificar.Image = Global.GUI.My.Resources.Resources.editar
        Me.btModificar.Location = New System.Drawing.Point(162, 276)
        Me.btModificar.Name = "btModificar"
        Me.btModificar.Size = New System.Drawing.Size(36, 27)
        Me.btModificar.TabIndex = 72
        Me.btModificar.UseVisualStyleBackColor = True
        '
        'limpiar
        '
        Me.limpiar.Image = Global.GUI.My.Resources.Resources.limpiarCampos
        Me.limpiar.Location = New System.Drawing.Point(270, 276)
        Me.limpiar.Name = "limpiar"
        Me.limpiar.Size = New System.Drawing.Size(37, 27)
        Me.limpiar.TabIndex = 67
        Me.limpiar.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(772, 54)
        Me.Panel1.TabIndex = 71
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(276, 11)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(224, 25)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Actores por Película"
        '
        'btBuscarLugar
        '
        Me.btBuscarLugar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btBuscarLugar.Image = Global.GUI.My.Resources.Resources.busqueda
        Me.btBuscarLugar.Location = New System.Drawing.Point(269, 69)
        Me.btBuscarLugar.Name = "btBuscarLugar"
        Me.btBuscarLugar.Size = New System.Drawing.Size(38, 23)
        Me.btBuscarLugar.TabIndex = 63
        Me.btBuscarLugar.UseVisualStyleBackColor = True
        '
        'txtIdActor
        '
        Me.txtIdActor.Location = New System.Drawing.Point(101, 71)
        Me.txtIdActor.Name = "txtIdActor"
        Me.txtIdActor.ReadOnly = True
        Me.txtIdActor.Size = New System.Drawing.Size(165, 20)
        Me.txtIdActor.TabIndex = 62
        '
        'lbIdDirector
        '
        Me.lbIdDirector.AutoSize = True
        Me.lbIdDirector.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbIdDirector.Location = New System.Drawing.Point(9, 74)
        Me.lbIdDirector.Name = "lbIdDirector"
        Me.lbIdDirector.Size = New System.Drawing.Size(86, 13)
        Me.lbIdDirector.TabIndex = 70
        Me.lbIdDirector.Text = "Código de Actor:"
        '
        'btEliminar
        '
        Me.btEliminar.Image = Global.GUI.My.Resources.Resources.borrar
        Me.btEliminar.Location = New System.Drawing.Point(217, 276)
        Me.btEliminar.Name = "btEliminar"
        Me.btEliminar.Size = New System.Drawing.Size(37, 27)
        Me.btEliminar.TabIndex = 66
        Me.btEliminar.UseVisualStyleBackColor = True
        '
        'dgv_ActoresPelicula
        '
        Me.dgv_ActoresPelicula.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_ActoresPelicula.Location = New System.Drawing.Point(316, 86)
        Me.dgv_ActoresPelicula.Name = "dgv_ActoresPelicula"
        Me.dgv_ActoresPelicula.Size = New System.Drawing.Size(456, 230)
        Me.dgv_ActoresPelicula.TabIndex = 69
        '
        'btInsertar
        '
        Me.btInsertar.Image = Global.GUI.My.Resources.Resources.agregar
        Me.btInsertar.Location = New System.Drawing.Point(101, 276)
        Me.btInsertar.Name = "btInsertar"
        Me.btInsertar.Size = New System.Drawing.Size(37, 27)
        Me.btInsertar.TabIndex = 65
        Me.btInsertar.UseVisualStyleBackColor = True
        '
        'txtIdPelicula
        '
        Me.txtIdPelicula.Location = New System.Drawing.Point(102, 123)
        Me.txtIdPelicula.MaxLength = 100
        Me.txtIdPelicula.Name = "txtIdPelicula"
        Me.txtIdPelicula.ReadOnly = True
        Me.txtIdPelicula.Size = New System.Drawing.Size(163, 20)
        Me.txtIdPelicula.TabIndex = 64
        '
        'lbTitulo
        '
        Me.lbTitulo.AutoSize = True
        Me.lbTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTitulo.Location = New System.Drawing.Point(8, 125)
        Me.lbTitulo.Name = "lbTitulo"
        Me.lbTitulo.Size = New System.Drawing.Size(85, 13)
        Me.lbTitulo.TabIndex = 68
        Me.lbTitulo.Text = "Código Película:"
        '
        'txtPapel
        '
        Me.txtPapel.Location = New System.Drawing.Point(101, 175)
        Me.txtPapel.Multiline = True
        Me.txtPapel.Name = "txtPapel"
        Me.txtPapel.Size = New System.Drawing.Size(206, 72)
        Me.txtPapel.TabIndex = 75
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 177)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 76
        Me.Label1.Text = "Papel:"
        '
        'txtSueldo
        '
        Me.txtSueldo.Location = New System.Drawing.Point(101, 252)
        Me.txtSueldo.Margin = New System.Windows.Forms.Padding(2)
        Me.txtSueldo.Name = "txtSueldo"
        Me.txtSueldo.Size = New System.Drawing.Size(206, 20)
        Me.txtSueldo.TabIndex = 77
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 255)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 78
        Me.Label2.Text = "Sueldo:"
        '
        'txtNombreActor
        '
        Me.txtNombreActor.Location = New System.Drawing.Point(102, 96)
        Me.txtNombreActor.Name = "txtNombreActor"
        Me.txtNombreActor.ReadOnly = True
        Me.txtNombreActor.Size = New System.Drawing.Size(205, 20)
        Me.txtNombreActor.TabIndex = 79
        '
        'lbNombreActor
        '
        Me.lbNombreActor.AutoSize = True
        Me.lbNombreActor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbNombreActor.Location = New System.Drawing.Point(7, 99)
        Me.lbNombreActor.Name = "lbNombreActor"
        Me.lbNombreActor.Size = New System.Drawing.Size(90, 13)
        Me.lbNombreActor.TabIndex = 80
        Me.lbNombreActor.Text = "Nombre de Actor:"
        '
        'txtTituloPelicula
        '
        Me.txtTituloPelicula.Location = New System.Drawing.Point(102, 149)
        Me.txtTituloPelicula.Name = "txtTituloPelicula"
        Me.txtTituloPelicula.ReadOnly = True
        Me.txtTituloPelicula.Size = New System.Drawing.Size(205, 20)
        Me.txtTituloPelicula.TabIndex = 81
        '
        'lbTituloPelicula
        '
        Me.lbTituloPelicula.AutoSize = True
        Me.lbTituloPelicula.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTituloPelicula.Location = New System.Drawing.Point(7, 152)
        Me.lbTituloPelicula.Name = "lbTituloPelicula"
        Me.lbTituloPelicula.Size = New System.Drawing.Size(95, 13)
        Me.lbTituloPelicula.TabIndex = 82
        Me.lbTituloPelicula.Text = "Título de Película:"
        '
        'frmActoresPorPelicula
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(771, 327)
        Me.Controls.Add(Me.txtTituloPelicula)
        Me.Controls.Add(Me.lbTituloPelicula)
        Me.Controls.Add(Me.txtNombreActor)
        Me.Controls.Add(Me.lbNombreActor)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtSueldo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtPapel)
        Me.Controls.Add(Me.btBuscarPelicula)
        Me.Controls.Add(Me.Panel13)
        Me.Controls.Add(Me.btModificar)
        Me.Controls.Add(Me.limpiar)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btBuscarLugar)
        Me.Controls.Add(Me.txtIdActor)
        Me.Controls.Add(Me.lbIdDirector)
        Me.Controls.Add(Me.btEliminar)
        Me.Controls.Add(Me.dgv_ActoresPelicula)
        Me.Controls.Add(Me.btInsertar)
        Me.Controls.Add(Me.txtIdPelicula)
        Me.Controls.Add(Me.lbTitulo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmActoresPorPelicula"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Actores por Pelicula"
        Me.Panel13.ResumeLayout(False)
        Me.Panel13.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgv_ActoresPelicula, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btBuscarPelicula As System.Windows.Forms.Button
    Friend WithEvents Panel13 As System.Windows.Forms.Panel
    Friend WithEvents lblPublicados As System.Windows.Forms.Label
    Friend WithEvents btModificar As System.Windows.Forms.Button
    Friend WithEvents limpiar As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btBuscarLugar As System.Windows.Forms.Button
    Friend WithEvents txtIdActor As System.Windows.Forms.TextBox
    Friend WithEvents lbIdDirector As System.Windows.Forms.Label
    Friend WithEvents btEliminar As System.Windows.Forms.Button
    Friend WithEvents dgv_ActoresPelicula As System.Windows.Forms.DataGridView
    Friend WithEvents btInsertar As System.Windows.Forms.Button
    Friend WithEvents txtIdPelicula As System.Windows.Forms.TextBox
    Friend WithEvents lbTitulo As System.Windows.Forms.Label
    Friend WithEvents txtPapel As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtSueldo As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtNombreActor As System.Windows.Forms.TextBox
    Friend WithEvents lbNombreActor As System.Windows.Forms.Label
    Friend WithEvents txtTituloPelicula As System.Windows.Forms.TextBox
    Friend WithEvents lbTituloPelicula As System.Windows.Forms.Label
End Class
