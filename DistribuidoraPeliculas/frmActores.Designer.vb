<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmActores
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmActores))
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtApe1 = New System.Windows.Forms.TextBox()
        Me.txtApe2 = New System.Windows.Forms.TextBox()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.dtNacimiento = New System.Windows.Forms.DateTimePicker()
        Me.cbEstCivil = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel13 = New System.Windows.Forms.Panel()
        Me.lblPublicados = New System.Windows.Forms.Label()
        Me.limpiar = New System.Windows.Forms.Button()
        Me.btEliminar = New System.Windows.Forms.Button()
        Me.btModificar = New System.Windows.Forms.Button()
        Me.btInsertar = New System.Windows.Forms.Button()
        Me.pcActor = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel13.SuspendLayout()
        CType(Me.pcActor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(121, 72)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(100, 20)
        Me.txtNombre.TabIndex = 2
        '
        'txtApe1
        '
        Me.txtApe1.Location = New System.Drawing.Point(121, 99)
        Me.txtApe1.Name = "txtApe1"
        Me.txtApe1.Size = New System.Drawing.Size(100, 20)
        Me.txtApe1.TabIndex = 3
        '
        'txtApe2
        '
        Me.txtApe2.Location = New System.Drawing.Point(227, 99)
        Me.txtApe2.Name = "txtApe2"
        Me.txtApe2.Size = New System.Drawing.Size(100, 20)
        Me.txtApe2.TabIndex = 4
        '
        'txtDireccion
        '
        Me.txtDireccion.Location = New System.Drawing.Point(121, 125)
        Me.txtDireccion.Multiline = True
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(206, 72)
        Me.txtDireccion.TabIndex = 5
        '
        'txtTelefono
        '
        Me.txtTelefono.Location = New System.Drawing.Point(121, 203)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(134, 20)
        Me.txtTelefono.TabIndex = 6
        '
        'dtNacimiento
        '
        Me.dtNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtNacimiento.Location = New System.Drawing.Point(121, 229)
        Me.dtNacimiento.Name = "dtNacimiento"
        Me.dtNacimiento.Size = New System.Drawing.Size(134, 20)
        Me.dtNacimiento.TabIndex = 7
        '
        'cbEstCivil
        '
        Me.cbEstCivil.FormattingEnabled = True
        Me.cbEstCivil.Location = New System.Drawing.Point(121, 255)
        Me.cbEstCivil.Name = "cbEstCivil"
        Me.cbEstCivil.Size = New System.Drawing.Size(134, 21)
        Me.cbEstCivil.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Nombre:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 99)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Apellidos:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 128)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Direccion:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(8, 206)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 13)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Teléfono:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(8, 232)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(111, 13)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Fecha de Nacimiento:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(8, 258)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 13)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Estado civil:"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(344, 81)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(621, 406)
        Me.DataGridView1.TabIndex = 16
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(965, 51)
        Me.Panel1.TabIndex = 17
        '
        'Label8
        '
        Me.Label8.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(439, 11)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label8.Size = New System.Drawing.Size(86, 25)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Actores"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel13
        '
        Me.Panel13.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel13.Controls.Add(Me.lblPublicados)
        Me.Panel13.Location = New System.Drawing.Point(344, 52)
        Me.Panel13.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel13.Name = "Panel13"
        Me.Panel13.Size = New System.Drawing.Size(621, 28)
        Me.Panel13.TabIndex = 21
        '
        'lblPublicados
        '
        Me.lblPublicados.AutoSize = True
        Me.lblPublicados.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPublicados.Location = New System.Drawing.Point(262, 4)
        Me.lblPublicados.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblPublicados.Name = "lblPublicados"
        Me.lblPublicados.Size = New System.Drawing.Size(89, 15)
        Me.lblPublicados.TabIndex = 0
        Me.lblPublicados.Text = "Lista actores"
        '
        'limpiar
        '
        Me.limpiar.Image = Global.GUI.My.Resources.Resources.limpiarCampos
        Me.limpiar.Location = New System.Drawing.Point(290, 460)
        Me.limpiar.Name = "limpiar"
        Me.limpiar.Size = New System.Drawing.Size(37, 27)
        Me.limpiar.TabIndex = 25
        Me.limpiar.UseVisualStyleBackColor = True
        '
        'btEliminar
        '
        Me.btEliminar.Image = Global.GUI.My.Resources.Resources.borrar
        Me.btEliminar.Location = New System.Drawing.Point(236, 460)
        Me.btEliminar.Name = "btEliminar"
        Me.btEliminar.Size = New System.Drawing.Size(37, 27)
        Me.btEliminar.TabIndex = 24
        Me.btEliminar.UseVisualStyleBackColor = True
        '
        'btModificar
        '
        Me.btModificar.Image = Global.GUI.My.Resources.Resources.editar
        Me.btModificar.Location = New System.Drawing.Point(180, 460)
        Me.btModificar.Name = "btModificar"
        Me.btModificar.Size = New System.Drawing.Size(37, 27)
        Me.btModificar.TabIndex = 22
        Me.btModificar.UseVisualStyleBackColor = True
        '
        'btInsertar
        '
        Me.btInsertar.Image = Global.GUI.My.Resources.Resources.agregar
        Me.btInsertar.Location = New System.Drawing.Point(121, 460)
        Me.btInsertar.Name = "btInsertar"
        Me.btInsertar.Size = New System.Drawing.Size(37, 27)
        Me.btInsertar.TabIndex = 23
        Me.btInsertar.UseVisualStyleBackColor = True
        '
        'pcActor
        '
        Me.pcActor.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.pcActor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pcActor.Location = New System.Drawing.Point(121, 291)
        Me.pcActor.Margin = New System.Windows.Forms.Padding(2)
        Me.pcActor.Name = "pcActor"
        Me.pcActor.Size = New System.Drawing.Size(134, 128)
        Me.pcActor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pcActor.TabIndex = 26
        Me.pcActor.TabStop = False
        '
        'Button1
        '
        Me.Button1.Image = Global.GUI.My.Resources.Resources.busqueda2
        Me.Button1.Location = New System.Drawing.Point(260, 289)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(37, 35)
        Me.Button1.TabIndex = 27
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 291)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 13)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "Foto:"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'frmActores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(965, 503)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.pcActor)
        Me.Controls.Add(Me.limpiar)
        Me.Controls.Add(Me.btEliminar)
        Me.Controls.Add(Me.btModificar)
        Me.Controls.Add(Me.btInsertar)
        Me.Controls.Add(Me.Panel13)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cbEstCivil)
        Me.Controls.Add(Me.dtNacimiento)
        Me.Controls.Add(Me.txtTelefono)
        Me.Controls.Add(Me.txtDireccion)
        Me.Controls.Add(Me.txtApe2)
        Me.Controls.Add(Me.txtApe1)
        Me.Controls.Add(Me.txtNombre)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmActores"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Actores"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel13.ResumeLayout(False)
        Me.Panel13.PerformLayout()
        CType(Me.pcActor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents txtApe1 As System.Windows.Forms.TextBox
    Friend WithEvents txtApe2 As System.Windows.Forms.TextBox
    Friend WithEvents txtDireccion As System.Windows.Forms.TextBox
    Friend WithEvents txtTelefono As System.Windows.Forms.TextBox
    Friend WithEvents dtNacimiento As System.Windows.Forms.DateTimePicker
    Friend WithEvents cbEstCivil As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Panel13 As System.Windows.Forms.Panel
    Friend WithEvents lblPublicados As System.Windows.Forms.Label
    Friend WithEvents limpiar As System.Windows.Forms.Button
    Friend WithEvents btEliminar As System.Windows.Forms.Button
    Friend WithEvents btModificar As System.Windows.Forms.Button
    Friend WithEvents btInsertar As System.Windows.Forms.Button
    Friend WithEvents pcActor As System.Windows.Forms.PictureBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
End Class
