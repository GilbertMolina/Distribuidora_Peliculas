Imports BusinessLevel
Imports Domain

Public Class frmPeliculas

    Private Sub btBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btBuscar.Click
        frmBusquedaDirector.Show()
    End Sub

    Private Sub btInsertar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btInsertar.Click
        Dim Pelicula As New Pelicula
        Dim BLPelicula As New BLPelicula

        If txtIdDirector.Text <> "" And txtTitulo.Text <> "" And txtArgumento.Text <> "" And dpFechaEstreno.Text <> "" And txtNacionalidad.Text <> "" Then
            Pelicula.FK_IdDirector = txtIdDirector.Text
            Pelicula.Titulo = txtTitulo.Text
            Pelicula.Argumento = txtArgumento.Text
            Pelicula.FechaEstreno = dpFechaEstreno.Text
            Pelicula.Nacionalidad = txtNacionalidad.Text

            BLPelicula.insertarPelicula(Pelicula)

            dgv_Peliculas.DataSource = BLPelicula.consultarPeliculas()
            dgv_Peliculas.Columns("PK_IdPelicula").Visible = False

            limpiarCampos()
        Else
            MsgBox("Debe de digitar todos los campos del formulario", MsgBoxStyle.Critical, "Atención")
        End If

    End Sub

    Private Sub btModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btModificar.Click
        Dim Pelicula As New Pelicula
        Dim BLPelicula As New BLPelicula

        If txtIdDirector.Text <> "" And txtTitulo.Text <> "" And txtArgumento.Text <> "" And dpFechaEstreno.Text <> "" And txtNacionalidad.Text <> "" Then
            Pelicula.PK_IdPelicula = dgv_Peliculas.CurrentRow.Cells(0).Value
            Pelicula.FK_IdDirector = txtIdDirector.Text
            Pelicula.Titulo = txtTitulo.Text
            Pelicula.Argumento = txtArgumento.Text
            Pelicula.FechaEstreno = dpFechaEstreno.Text
            Pelicula.Nacionalidad = txtNacionalidad.Text

            BLPelicula.modificarPelicula(Pelicula)

            dgv_Peliculas.DataSource = BLPelicula.consultarPeliculas()
            dgv_Peliculas.Columns("PK_IdPelicula").Visible = False

            limpiarCampos()
        Else
            MsgBox("Debe de cargar primero una película de la lista de películas", MsgBoxStyle.Critical, "Atención")
        End If
    End Sub

    Private Sub btEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btEliminar.Click
        Dim Pelicula As New Pelicula
        Dim BLPelicula As New BLPelicula

        Dim result As DialogResult = MsgBox("Desea eliminar la película seleccionada?", MsgBoxStyle.YesNo, "Eliminar Película")
        If result = DialogResult.Yes Then
            Pelicula.PK_IdPelicula = dgv_Peliculas.CurrentRow.Cells(0).Value

            BLPelicula.eliminarPelicula(Pelicula)

            dgv_Peliculas.DataSource = BLPelicula.consultarPeliculas()
            dgv_Peliculas.Columns("PK_IdPelicula").Visible = False

            limpiarCampos()
        End If

    End Sub

    Private Sub frmPeliculas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim BLPelicula As New BLPelicula
        dgv_Peliculas.DataSource = BLPelicula.consultarPeliculas()
        dgv_Peliculas.Columns("PK_IdPelicula").Visible = False
        dgv_Peliculas.Columns("Código Director").Visible = False
    End Sub

    Private Sub dgv_Peliculas_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_Peliculas.CellClick

        Try
            If dgv_Peliculas.CurrentRow.Cells(0).Value.ToString <> "" Then
                txtIdDirector.Text = dgv_Peliculas.CurrentRow.Cells(1).Value.ToString
                txtNombreDirector.Text = dgv_Peliculas.CurrentRow.Cells(2).Value.ToString
                txtTitulo.Text = dgv_Peliculas.CurrentRow.Cells(3).Value.ToString
                txtArgumento.Text = dgv_Peliculas.CurrentRow.Cells(4).Value.ToString
                dpFechaEstreno.Text = dgv_Peliculas.CurrentRow.Cells(5).Value.ToString
                txtNacionalidad.Text = dgv_Peliculas.CurrentRow.Cells(6).Value.ToString
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub limpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles limpiar.Click
        limpiarCampos()
    End Sub

    Private Sub limpiarCampos()
        txtIdDirector.Text = ""
        txtNombreDirector.Text = ""
        txtTitulo.Text = ""
        txtArgumento.Text = ""
        dpFechaEstreno.Text = ""
        txtNacionalidad.Text = ""
    End Sub

End Class