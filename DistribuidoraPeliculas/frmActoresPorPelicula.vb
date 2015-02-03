Imports BusinessLevel
Imports Domain

Public Class frmActoresPorPelicula

    Private Sub btBuscarLugar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btBuscarLugar.Click
        frmBusquedaActores.Show()

    End Sub

    Private Sub btBuscarPelicula_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btBuscarPelicula.Click
        frmBusquedaPelicula.Show()
    End Sub

    Private Sub btInsertar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btInsertar.Click
        Dim oActorxPelicula As New BLActoresPelicula
        Dim oActor As New ActoresPelicula

        Try
            oActor.FK_PK_IdActor = txtIdActor.Text
            oActor.FK_PK_IdPelicula = txtIdPelicula.Text
            oActor.Papel = txtPapel.Text
            oActor.Sueldo = txtSueldo.Text
            oActorxPelicula.Insertar(oActor)
            CargarGrid()
        Catch ex As Exception
            MsgBox("ERROR:" & ex.Message, MsgBoxStyle.Critical, "Error al ingresar actor por pelicula")
        End Try

    End Sub

    Private Sub btModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btModificar.Click
        Dim oActorxPelicula As New BLActoresPelicula
        Dim oActor As New ActoresPelicula

        Try
            oActor.FK_PK_IdActor = txtIdActor.Text
            oActor.FK_PK_IdPelicula = txtIdPelicula.Text
            oActor.Papel = txtPapel.Text
            oActor.Sueldo = txtSueldo.Text
            oActorxPelicula.Modificar(oActor)
            CargarGrid()
            btInsertar.Enabled = True
            btEliminar.Enabled = False
            btModificar.Enabled = False
            LimpiarCampos()
        Catch ex As Exception
            MsgBox("ERROR:" & ex.Message, MsgBoxStyle.Critical, "Error al modificar actor por pelicula")
        End Try
    End Sub

    Private Sub btEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btEliminar.Click
        Dim oActorxPelicula As New BLActoresPelicula
        Dim oActor As New ActoresPelicula

        Try
            oActor.FK_PK_IdActor = txtIdActor.Text
            oActor.FK_PK_IdPelicula = txtIdPelicula.Text
            oActorxPelicula.Eliminar(oActor)
            CargarGrid()
            btInsertar.Enabled = True
            btEliminar.Enabled = False
            btModificar.Enabled = False
            LimpiarCampos()
        Catch ex As Exception
            MsgBox("ERROR:" & ex.Message, MsgBoxStyle.Critical, "Error al eliminar actor por pelicula")
        End Try
    End Sub

    Private Sub frmActoresPorPelicula_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CargarGrid()
        btInsertar.Enabled = True
        btEliminar.Enabled = False
        btModificar.Enabled = False
    End Sub

    Private Sub CargarGrid()
        Dim oActorxPelicula As New BLActoresPelicula
        dgv_ActoresPelicula.DataSource = oActorxPelicula.ConsultarTodos()
        dgv_ActoresPelicula.Columns("FK_PK_IdPelicula").Visible = False
        dgv_ActoresPelicula.Columns("FK_PK_IdActor").Visible = False
    End Sub

    Private Sub SeleccionarDatodeGrid() Handles dgv_ActoresPelicula.CellClick
        Try
            btInsertar.Enabled = False
            btEliminar.Enabled = True
            btModificar.Enabled = True
            txtIdActor.Text = dgv_ActoresPelicula.CurrentRow.Cells(1).Value
            txtNombreActor.Text = dgv_ActoresPelicula.CurrentRow.Cells(2).Value
            txtIdPelicula.Text = dgv_ActoresPelicula.CurrentRow.Cells(0).Value
            txtTituloPelicula.Text = dgv_ActoresPelicula.CurrentRow.Cells(3).Value
            txtPapel.Text = dgv_ActoresPelicula.CurrentRow.Cells(4).Value
            txtSueldo.Text = dgv_ActoresPelicula.CurrentRow.Cells(5).Value
        Catch ex As Exception
            MsgBox("ERROR:" & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub limpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles limpiar.Click
        btInsertar.Enabled = True
        btEliminar.Enabled = False
        btModificar.Enabled = False
        LimpiarCampos()
    End Sub

    Private Sub LimpiarCampos()
        txtIdActor.Text = ""
        txtNombreActor.Text = ""
        txtIdPelicula.Text = ""
        txtTituloPelicula.Text = ""
        txtPapel.Text = ""
        txtSueldo.Text = ""
    End Sub

End Class