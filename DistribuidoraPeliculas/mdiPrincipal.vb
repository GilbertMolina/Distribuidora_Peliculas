Imports System.Windows.Forms

Public Class mdiPrincipal

    Private Sub ShowNewForm(ByVal sender As Object, ByVal e As EventArgs)
        ' Cree una nueva instancia del formulario secundario.
        Dim ChildForm As New System.Windows.Forms.Form
        ' Conviértalo en un elemento secundario de este formulario MDI antes de mostrarlo.
        ChildForm.MdiParent = Me

        m_ChildFormNumber += 1
        ChildForm.Text = "Ventana " & m_ChildFormNumber

        ChildForm.Show()
    End Sub

    Private Sub OpenFile(ByVal sender As Object, ByVal e As EventArgs)
        Dim OpenFileDialog As New OpenFileDialog
        OpenFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        OpenFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*"
        If (OpenFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = OpenFileDialog.FileName
            ' TODO: agregue código aquí para abrir el archivo.
        End If
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim SaveFileDialog As New SaveFileDialog
        SaveFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        SaveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*"

        If (SaveFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = SaveFileDialog.FileName
            ' TODO: agregue código aquí para guardar el contenido actual del formulario en un archivo.
        End If
    End Sub

    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ExitToolStripMenuItem.Click
        If frmAcerca.Visible Then
            frmAcerca.Close()
        End If
        If frmActores.Visible Then
            frmActores.Close()
        End If
        If frmActoresPorPelicula.Visible Then
            frmActoresPorPelicula.Close()
        End If
        If frmAcerca.Visible Then
            frmAcerca.Close()
        End If
        If frmAnuncios.Visible Then
            frmAnuncios.Close()
        End If
        If frmBusquedaActores.Visible Then
            frmBusquedaActores.Close()
        End If
        If frmBusquedaDirector.Visible Then
            frmBusquedaDirector.Close()
        End If
        If frmBusquedaLugar.Visible Then
            frmBusquedaLugar.Close()
        End If
        If frmBusquedaPelicula.Visible Then
            frmBusquedaPelicula.Close()
        End If
        If frmBusquedaProductor.Visible Then
            frmBusquedaProductor.Close()
        End If
        If frmCritica.Visible Then
            frmCritica.Close()
        End If
        If frmDirectores.Visible Then
            frmDirectores.Close()
        End If
        If frmLugar.Visible Then
            frmLugar.Close()
        End If
        If frmLugarEstreno.Visible Then
            frmLugarEstreno.Close()
        End If
        If frmPeliculas.Visible Then
            frmPeliculas.Close()
        End If
        If frmPremios.Visible Then
            frmPremios.Close()
        End If
        If frmPremiosPorPelicula.Visible Then
            frmPremiosPorPelicula.Close()
        End If
        If frmProductor.Visible Then
            frmProductor.Close()
        End If
        If frmProductorPelicula.Visible Then
            frmProductorPelicula.Close()
        End If
        Me.Close()
    End Sub

    Private Sub CutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Utilice My.Computer.Clipboard para insertar el texto o las imágenes seleccionadas en el Portapapeles
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Utilice My.Computer.Clipboard para insertar el texto o las imágenes seleccionadas en el Portapapeles
    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        'Utilice My.Computer.Clipboard.GetText() o My.Computer.Clipboard.GetData para recuperar la información del Portapapeles.
    End Sub

    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CascadeToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileVerticalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles TileVerticalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles TileHorizontalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ArrangeIconsToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CloseAllToolStripMenuItem.Click
        ' Cierre todos los formularios secundarios del principal.
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub

    Private m_ChildFormNumber As Integer

    Private Sub AnunciosToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        frmAnuncios.MdiParent = Me
        frmAnuncios.Show()
    End Sub

    Private Sub CriticasToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        frmCritica.MdiParent = Me
        frmCritica.Show()
    End Sub

    Private Sub DirectoresToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DirectoresToolStripMenuItem.Click
        frmDirectores.MdiParent = Me
        frmDirectores.Show()
    End Sub

    Private Sub PelículasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PelículasToolStripMenuItem.Click
        frmPeliculas.MdiParent = Me
        frmPeliculas.Show()
    End Sub

    Private Sub PremiosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PremiosToolStripMenuItem.Click
        frmPremios.MdiParent = Me
        frmPremios.Show()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        frmAcerca.MdiParent = Me
        frmAcerca.Show()
    End Sub

    Private Sub PremiosPorPeliculaToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        frmPremiosPorPelicula.MdiParent = Me
        frmPremiosPorPelicula.Show()
    End Sub

    Private Sub ActoresToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ActoresToolStripMenuItem.Click
        frmActores.MdiParent = Me
        frmActores.Show()
    End Sub

    Private Sub mdiPrincipal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        pbBackground.Visible = False
        For Each c As Control In Me.Controls
            If TypeOf c Is MdiClient Then
                AddHandler c.Paint, AddressOf myMdiControlPaint
                AddHandler c.SizeChanged, AddressOf myMdiControlResize
                Exit For
            End If
        Next
    End Sub

    Private Sub myMdiControlPaint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs)
        e.Graphics.DrawImage(Me.pbBackground.Image, 0, 0, Me.Width, Me.Height)
    End Sub

    Private Sub myMdiControlResize(ByVal sender As Object, ByVal e As System.EventArgs)
        CType(sender, MdiClient).Invalidate()
    End Sub

    Private Sub LugaresToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LugaresToolStripMenuItem.Click
        frmLugar.MdiParent = Me
        frmLugar.Show()
    End Sub

    Private Sub LugaresDeEstrenoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmLugarEstreno.MdiParent = Me
        frmLugarEstreno.Show()
    End Sub

    Private Sub ActoresPorPelículaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmActoresPorPelicula.MdiParent = Me
        frmActoresPorPelicula.Show()
    End Sub

    Private Sub ProductoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductoresToolStripMenuItem.Click
        frmProductor.MdiParent = Me
        frmProductor.Show()
    End Sub

    Private Sub ProductorPorPelículaToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        frmPremiosPorPelicula.MdiParent = Me
        frmProductorPelicula.Show()
    End Sub

    Private Sub IngresarActoresAPelículasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IngresarActoresAPelículasToolStripMenuItem.Click
        frmActoresPorPelicula.MdiParent = Me
        frmActoresPorPelicula.Show()
    End Sub

    Private Sub LugaresDeEstrenoDePelículasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LugaresDeEstrenoDePelículasToolStripMenuItem.Click
        frmLugarEstreno.MdiParent = Me
        frmLugarEstreno.Show()
    End Sub

    Private Sub PremiosDePelículasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PremiosDePelículasToolStripMenuItem.Click
        frmPremiosPorPelicula.MdiParent = Me
        frmPremiosPorPelicula.Show()
    End Sub

    Private Sub IngresarProductoresAPelículasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IngresarProductoresAPelículasToolStripMenuItem.Click
        frmProductorPelicula.MdiParent = Me
        frmProductorPelicula.Show()
    End Sub

    Private Sub AnunciosDePelículasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AnunciosDePelículasToolStripMenuItem.Click
        frmAnuncios.MdiParent = Me
        frmAnuncios.Show()
    End Sub

    Private Sub CríticasDePelículasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CríticasDePelículasToolStripMenuItem.Click
        frmCritica.MdiParent = Me
        frmCritica.Show()
    End Sub

End Class
