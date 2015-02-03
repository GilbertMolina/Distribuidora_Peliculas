<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAnuncios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAnuncios))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvAnuncios = New System.Windows.Forms.DataGridView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Publicados = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCodAnuncio = New System.Windows.Forms.TextBox()
        Me.dateFecha = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtCodPeli = New System.Windows.Forms.TextBox()
        Me.comboPeli = New System.Windows.Forms.ComboBox()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvAnuncios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(585, 51)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(243, 14)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label1.Size = New System.Drawing.Size(102, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Anuncios"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dgvAnuncios
        '
        Me.dgvAnuncios.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvAnuncios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvAnuncios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAnuncios.Location = New System.Drawing.Point(244, 74)
        Me.dgvAnuncios.Margin = New System.Windows.Forms.Padding(2)
        Me.dgvAnuncios.MultiSelect = False
        Me.dgvAnuncios.Name = "dgvAnuncios"
        Me.dgvAnuncios.RowTemplate.Height = 24
        Me.dgvAnuncios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvAnuncios.Size = New System.Drawing.Size(340, 222)
        Me.dgvAnuncios.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Publicados)
        Me.Panel2.Location = New System.Drawing.Point(244, 50)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(340, 24)
        Me.Panel2.TabIndex = 2
        '
        'Publicados
        '
        Me.Publicados.AutoSize = True
        Me.Publicados.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Publicados.Location = New System.Drawing.Point(130, 2)
        Me.Publicados.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Publicados.Name = "Publicados"
        Me.Publicados.Size = New System.Drawing.Size(78, 15)
        Me.Publicados.TabIndex = 0
        Me.Publicados.Text = "Publicados"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 74)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Código:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 105)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Fecha:"
        '
        'txtCodAnuncio
        '
        Me.txtCodAnuncio.Enabled = False
        Me.txtCodAnuncio.Location = New System.Drawing.Point(82, 75)
        Me.txtCodAnuncio.Margin = New System.Windows.Forms.Padding(2)
        Me.txtCodAnuncio.Name = "txtCodAnuncio"
        Me.txtCodAnuncio.Size = New System.Drawing.Size(100, 20)
        Me.txtCodAnuncio.TabIndex = 6
        '
        'dateFecha
        '
        Me.dateFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dateFecha.Location = New System.Drawing.Point(82, 105)
        Me.dateFecha.Margin = New System.Windows.Forms.Padding(2)
        Me.dateFecha.Name = "dateFecha"
        Me.dateFecha.Size = New System.Drawing.Size(100, 20)
        Me.dateFecha.TabIndex = 7
        Me.dateFecha.Value = New Date(2013, 11, 11, 22, 51, 13, 0)
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 138)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Pelicula:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(3, 173)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Cod pelicula:"
        '
        'txtCodPeli
        '
        Me.txtCodPeli.Enabled = False
        Me.txtCodPeli.Location = New System.Drawing.Point(82, 173)
        Me.txtCodPeli.Margin = New System.Windows.Forms.Padding(2)
        Me.txtCodPeli.Name = "txtCodPeli"
        Me.txtCodPeli.Size = New System.Drawing.Size(100, 20)
        Me.txtCodPeli.TabIndex = 10
        '
        'comboPeli
        '
        Me.comboPeli.FormattingEnabled = True
        Me.comboPeli.Location = New System.Drawing.Point(82, 138)
        Me.comboPeli.Margin = New System.Windows.Forms.Padding(2)
        Me.comboPeli.Name = "comboPeli"
        Me.comboPeli.Size = New System.Drawing.Size(100, 21)
        Me.comboPeli.TabIndex = 11
        '
        'btnNuevo
        '
        Me.btnNuevo.Location = New System.Drawing.Point(82, 211)
        Me.btnNuevo.Margin = New System.Windows.Forms.Padding(2)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(60, 31)
        Me.btnNuevo.TabIndex = 12
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Image = Global.GUI.My.Resources.Resources.limpiarCampos
        Me.btnLimpiar.Location = New System.Drawing.Point(146, 211)
        Me.btnLimpiar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(36, 31)
        Me.btnLimpiar.TabIndex = 14
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'btnBuscar
        '
        Me.btnBuscar.Image = Global.GUI.My.Resources.Resources.busqueda
        Me.btnBuscar.Location = New System.Drawing.Point(188, 137)
        Me.btnBuscar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(34, 22)
        Me.btnBuscar.TabIndex = 13
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Image = Global.GUI.My.Resources.Resources.borrar
        Me.Button1.Location = New System.Drawing.Point(188, 74)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(34, 21)
        Me.Button1.TabIndex = 3
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmAnuncios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(587, 296)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.comboPeli)
        Me.Controls.Add(Me.txtCodPeli)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.dateFecha)
        Me.Controls.Add(Me.txtCodAnuncio)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.dgvAnuncios)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.Name = "frmAnuncios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Anuncios"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgvAnuncios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dgvAnuncios As System.Windows.Forms.DataGridView
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Publicados As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtCodAnuncio As System.Windows.Forms.TextBox
    Friend WithEvents dateFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtCodPeli As System.Windows.Forms.TextBox
    Friend WithEvents comboPeli As System.Windows.Forms.ComboBox
    Friend WithEvents btnNuevo As System.Windows.Forms.Button
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents btnLimpiar As System.Windows.Forms.Button
End Class
