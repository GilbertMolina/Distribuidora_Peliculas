<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mdiPrincipal
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mdiPrincipal))
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.FileMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.Mantenimiento = New System.Windows.Forms.ToolStripMenuItem()
        Me.WindowsMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.ProcesosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.pbBackground = New System.Windows.Forms.PictureBox()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ActoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DirectoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LugaresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PelículasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PremiosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IngresarActoresAPelículasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LugaresDeEstrenoDePelículasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PremiosDePelículasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IngresarProductoresAPelículasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CascadeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TileVerticalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TileHorizontalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ArrangeIconsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CríticasDePelículasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AnunciosDePelículasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip.SuspendLayout()
        CType(Me.pbBackground, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileMenu, Me.Mantenimiento, Me.ProcesosToolStripMenuItem, Me.WindowsMenu, Me.HelpMenu})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.MdiWindowListItem = Me.WindowsMenu
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(851, 24)
        Me.MenuStrip.TabIndex = 5
        Me.MenuStrip.Text = "MenuStrip"
        '
        'FileMenu
        '
        Me.FileMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FileMenu.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder
        Me.FileMenu.Name = "FileMenu"
        Me.FileMenu.Size = New System.Drawing.Size(60, 20)
        Me.FileMenu.Text = "&Archivo"
        '
        'Mantenimiento
        '
        Me.Mantenimiento.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ActoresToolStripMenuItem, Me.DirectoresToolStripMenuItem, Me.LugaresToolStripMenuItem, Me.PelículasToolStripMenuItem, Me.PremiosToolStripMenuItem, Me.ProductoresToolStripMenuItem})
        Me.Mantenimiento.Name = "Mantenimiento"
        Me.Mantenimiento.Size = New System.Drawing.Size(106, 20)
        Me.Mantenimiento.Text = "&Mantenimientos"
        '
        'WindowsMenu
        '
        Me.WindowsMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CascadeToolStripMenuItem, Me.TileVerticalToolStripMenuItem, Me.TileHorizontalToolStripMenuItem, Me.ArrangeIconsToolStripMenuItem, Me.CloseAllToolStripMenuItem})
        Me.WindowsMenu.Name = "WindowsMenu"
        Me.WindowsMenu.Size = New System.Drawing.Size(67, 20)
        Me.WindowsMenu.Text = "&Ventanas"
        '
        'HelpMenu
        '
        Me.HelpMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator8, Me.AboutToolStripMenuItem})
        Me.HelpMenu.Name = "HelpMenu"
        Me.HelpMenu.Size = New System.Drawing.Size(53, 20)
        Me.HelpMenu.Text = "Ay&uda"
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(149, 6)
        '
        'ProcesosToolStripMenuItem
        '
        Me.ProcesosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IngresarActoresAPelículasToolStripMenuItem, Me.AnunciosDePelículasToolStripMenuItem, Me.CríticasDePelículasToolStripMenuItem, Me.LugaresDeEstrenoDePelículasToolStripMenuItem, Me.PremiosDePelículasToolStripMenuItem, Me.IngresarProductoresAPelículasToolStripMenuItem})
        Me.ProcesosToolStripMenuItem.Name = "ProcesosToolStripMenuItem"
        Me.ProcesosToolStripMenuItem.Size = New System.Drawing.Size(66, 20)
        Me.ProcesosToolStripMenuItem.Text = "Procesos"
        '
        'pbBackground
        '
        Me.pbBackground.Image = Global.GUI.My.Resources.Resources.hollywood
        Me.pbBackground.Location = New System.Drawing.Point(0, 27)
        Me.pbBackground.Name = "pbBackground"
        Me.pbBackground.Size = New System.Drawing.Size(851, 505)
        Me.pbBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbBackground.TabIndex = 7
        Me.pbBackground.TabStop = False
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Image = Global.GUI.My.Resources.Resources.logout
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ExitToolStripMenuItem.Text = "&Salir"
        '
        'ActoresToolStripMenuItem
        '
        Me.ActoresToolStripMenuItem.Image = Global.GUI.My.Resources.Resources.app
        Me.ActoresToolStripMenuItem.Name = "ActoresToolStripMenuItem"
        Me.ActoresToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ActoresToolStripMenuItem.Text = "Actores"
        '
        'DirectoresToolStripMenuItem
        '
        Me.DirectoresToolStripMenuItem.Image = Global.GUI.My.Resources.Resources.app
        Me.DirectoresToolStripMenuItem.Name = "DirectoresToolStripMenuItem"
        Me.DirectoresToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.DirectoresToolStripMenuItem.Text = "Directores"
        '
        'LugaresToolStripMenuItem
        '
        Me.LugaresToolStripMenuItem.Image = Global.GUI.My.Resources.Resources.app
        Me.LugaresToolStripMenuItem.Name = "LugaresToolStripMenuItem"
        Me.LugaresToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.LugaresToolStripMenuItem.Text = "Lugares"
        '
        'PelículasToolStripMenuItem
        '
        Me.PelículasToolStripMenuItem.Image = Global.GUI.My.Resources.Resources.app
        Me.PelículasToolStripMenuItem.Name = "PelículasToolStripMenuItem"
        Me.PelículasToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.PelículasToolStripMenuItem.Text = "Películas"
        '
        'PremiosToolStripMenuItem
        '
        Me.PremiosToolStripMenuItem.Image = Global.GUI.My.Resources.Resources.app
        Me.PremiosToolStripMenuItem.Name = "PremiosToolStripMenuItem"
        Me.PremiosToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.PremiosToolStripMenuItem.Text = "Premios"
        '
        'ProductoresToolStripMenuItem
        '
        Me.ProductoresToolStripMenuItem.Image = Global.GUI.My.Resources.Resources.app
        Me.ProductoresToolStripMenuItem.Name = "ProductoresToolStripMenuItem"
        Me.ProductoresToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ProductoresToolStripMenuItem.Text = "Productores"
        '
        'IngresarActoresAPelículasToolStripMenuItem
        '
        Me.IngresarActoresAPelículasToolStripMenuItem.Image = Global.GUI.My.Resources.Resources._option
        Me.IngresarActoresAPelículasToolStripMenuItem.Name = "IngresarActoresAPelículasToolStripMenuItem"
        Me.IngresarActoresAPelículasToolStripMenuItem.Size = New System.Drawing.Size(241, 22)
        Me.IngresarActoresAPelículasToolStripMenuItem.Text = "Ingresar actores a películas"
        '
        'LugaresDeEstrenoDePelículasToolStripMenuItem
        '
        Me.LugaresDeEstrenoDePelículasToolStripMenuItem.Image = Global.GUI.My.Resources.Resources._option
        Me.LugaresDeEstrenoDePelículasToolStripMenuItem.Name = "LugaresDeEstrenoDePelículasToolStripMenuItem"
        Me.LugaresDeEstrenoDePelículasToolStripMenuItem.Size = New System.Drawing.Size(241, 22)
        Me.LugaresDeEstrenoDePelículasToolStripMenuItem.Text = "Lugares de estreno de películas"
        '
        'PremiosDePelículasToolStripMenuItem
        '
        Me.PremiosDePelículasToolStripMenuItem.Image = Global.GUI.My.Resources.Resources._option
        Me.PremiosDePelículasToolStripMenuItem.Name = "PremiosDePelículasToolStripMenuItem"
        Me.PremiosDePelículasToolStripMenuItem.Size = New System.Drawing.Size(241, 22)
        Me.PremiosDePelículasToolStripMenuItem.Text = "Ingresar premios a películas"
        '
        'IngresarProductoresAPelículasToolStripMenuItem
        '
        Me.IngresarProductoresAPelículasToolStripMenuItem.Image = Global.GUI.My.Resources.Resources._option
        Me.IngresarProductoresAPelículasToolStripMenuItem.Name = "IngresarProductoresAPelículasToolStripMenuItem"
        Me.IngresarProductoresAPelículasToolStripMenuItem.Size = New System.Drawing.Size(241, 22)
        Me.IngresarProductoresAPelículasToolStripMenuItem.Text = "Ingresar productores a películas"
        '
        'CascadeToolStripMenuItem
        '
        Me.CascadeToolStripMenuItem.Image = Global.GUI.My.Resources.Resources.windows
        Me.CascadeToolStripMenuItem.Name = "CascadeToolStripMenuItem"
        Me.CascadeToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.CascadeToolStripMenuItem.Text = "&Cascada"
        '
        'TileVerticalToolStripMenuItem
        '
        Me.TileVerticalToolStripMenuItem.Image = Global.GUI.My.Resources.Resources.windows
        Me.TileVerticalToolStripMenuItem.Name = "TileVerticalToolStripMenuItem"
        Me.TileVerticalToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.TileVerticalToolStripMenuItem.Text = "Mosaico &vertical"
        '
        'TileHorizontalToolStripMenuItem
        '
        Me.TileHorizontalToolStripMenuItem.Image = Global.GUI.My.Resources.Resources.windows
        Me.TileHorizontalToolStripMenuItem.Name = "TileHorizontalToolStripMenuItem"
        Me.TileHorizontalToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.TileHorizontalToolStripMenuItem.Text = "Mosaico &horizontal"
        '
        'CloseAllToolStripMenuItem
        '
        Me.CloseAllToolStripMenuItem.Image = Global.GUI.My.Resources.Resources.windows
        Me.CloseAllToolStripMenuItem.Name = "CloseAllToolStripMenuItem"
        Me.CloseAllToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.CloseAllToolStripMenuItem.Text = "C&errar todo"
        '
        'ArrangeIconsToolStripMenuItem
        '
        Me.ArrangeIconsToolStripMenuItem.Image = Global.GUI.My.Resources.Resources.windows
        Me.ArrangeIconsToolStripMenuItem.Name = "ArrangeIconsToolStripMenuItem"
        Me.ArrangeIconsToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.ArrangeIconsToolStripMenuItem.Text = "&Organizar iconos"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Image = Global.GUI.My.Resources.Resources.about
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AboutToolStripMenuItem.Text = "&Acerca de..."
        '
        'CríticasDePelículasToolStripMenuItem
        '
        Me.CríticasDePelículasToolStripMenuItem.Image = Global.GUI.My.Resources.Resources._option
        Me.CríticasDePelículasToolStripMenuItem.Name = "CríticasDePelículasToolStripMenuItem"
        Me.CríticasDePelículasToolStripMenuItem.Size = New System.Drawing.Size(241, 22)
        Me.CríticasDePelículasToolStripMenuItem.Text = "Críticas de películas"
        '
        'AnunciosDePelículasToolStripMenuItem
        '
        Me.AnunciosDePelículasToolStripMenuItem.Image = Global.GUI.My.Resources.Resources._option
        Me.AnunciosDePelículasToolStripMenuItem.Name = "AnunciosDePelículasToolStripMenuItem"
        Me.AnunciosDePelículasToolStripMenuItem.Size = New System.Drawing.Size(241, 22)
        Me.AnunciosDePelículasToolStripMenuItem.Text = "Anuncios de películas"
        '
        'mdiPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(851, 530)
        Me.Controls.Add(Me.pbBackground)
        Me.Controls.Add(Me.MenuStrip)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "mdiPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Distribuidora de Películas"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        CType(Me.pbBackground, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ArrangeIconsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CloseAllToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WindowsMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CascadeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TileVerticalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TileHorizontalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FileMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents Mantenimiento As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator8 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DirectoresToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PelículasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PremiosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ActoresToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents pbBackground As System.Windows.Forms.PictureBox
    Friend WithEvents LugaresToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProductoresToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProcesosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IngresarActoresAPelículasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LugaresDeEstrenoDePelículasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PremiosDePelículasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IngresarProductoresAPelículasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AnunciosDePelículasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CríticasDePelículasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
