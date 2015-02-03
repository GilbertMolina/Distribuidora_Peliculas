<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAcerca
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAcerca))
        Me.lbDescripcion1 = New System.Windows.Forms.Label()
        Me.lbDescripcion2 = New System.Windows.Forms.Label()
        Me.lbDescripcion3 = New System.Windows.Forms.Label()
        Me.lbDescripcion4 = New System.Windows.Forms.Label()
        Me.lbDescripcion5 = New System.Windows.Forms.Label()
        Me.btAceptar = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbDescripcion1
        '
        Me.lbDescripcion1.AutoSize = True
        Me.lbDescripcion1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbDescripcion1.Location = New System.Drawing.Point(110, 202)
        Me.lbDescripcion1.Name = "lbDescripcion1"
        Me.lbDescripcion1.Size = New System.Drawing.Size(87, 15)
        Me.lbDescripcion1.TabIndex = 1
        Me.lbDescripcion1.Text = "Descripción:"
        '
        'lbDescripcion2
        '
        Me.lbDescripcion2.AutoSize = True
        Me.lbDescripcion2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbDescripcion2.Location = New System.Drawing.Point(59, 228)
        Me.lbDescripcion2.Name = "lbDescripcion2"
        Me.lbDescripcion2.Size = New System.Drawing.Size(188, 15)
        Me.lbDescripcion2.TabIndex = 2
        Me.lbDescripcion2.Text = "Proyecto de Programación 2"
        '
        'lbDescripcion3
        '
        Me.lbDescripcion3.AutoSize = True
        Me.lbDescripcion3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbDescripcion3.Location = New System.Drawing.Point(17, 254)
        Me.lbDescripcion3.Name = "lbDescripcion3"
        Me.lbDescripcion3.Size = New System.Drawing.Size(277, 15)
        Me.lbDescripcion3.TabIndex = 3
        Me.lbDescripcion3.Text = "Universidad Internacional de las Américas"
        '
        'lbDescripcion4
        '
        Me.lbDescripcion4.AutoSize = True
        Me.lbDescripcion4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbDescripcion4.Location = New System.Drawing.Point(60, 283)
        Me.lbDescripcion4.Name = "lbDescripcion4"
        Me.lbDescripcion4.Size = New System.Drawing.Size(187, 15)
        Me.lbDescripcion4.TabIndex = 4
        Me.lbDescripcion4.Text = "Aplicación desarrollada por:"
        '
        'lbDescripcion5
        '
        Me.lbDescripcion5.AutoSize = True
        Me.lbDescripcion5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbDescripcion5.Location = New System.Drawing.Point(59, 309)
        Me.lbDescripcion5.Name = "lbDescripcion5"
        Me.lbDescripcion5.Size = New System.Drawing.Size(180, 60)
        Me.lbDescripcion5.TabIndex = 5
        Me.lbDescripcion5.Text = "      Carlos Mora Aguilar" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "  Gilberth Molina Castrillo" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Jeison Leandro Hernández" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "  Jorge Leandro Benavides" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'btAceptar
        '
        Me.btAceptar.Location = New System.Drawing.Point(113, 384)
        Me.btAceptar.Name = "btAceptar"
        Me.btAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btAceptar.TabIndex = 1
        Me.btAceptar.Text = "Aceptar"
        Me.btAceptar.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.GUI.My.Resources.Resources.UIA_Login
        Me.PictureBox1.Location = New System.Drawing.Point(74, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(165, 174)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'frmAcerca
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(315, 419)
        Me.Controls.Add(Me.btAceptar)
        Me.Controls.Add(Me.lbDescripcion5)
        Me.Controls.Add(Me.lbDescripcion4)
        Me.Controls.Add(Me.lbDescripcion3)
        Me.Controls.Add(Me.lbDescripcion2)
        Me.Controls.Add(Me.lbDescripcion1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAcerca"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Acerca"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lbDescripcion1 As System.Windows.Forms.Label
    Friend WithEvents lbDescripcion2 As System.Windows.Forms.Label
    Friend WithEvents lbDescripcion3 As System.Windows.Forms.Label
    Friend WithEvents lbDescripcion4 As System.Windows.Forms.Label
    Friend WithEvents lbDescripcion5 As System.Windows.Forms.Label
    Friend WithEvents btAceptar As System.Windows.Forms.Button
End Class
