Imports BusinessLevel
Imports Domain

Public Class frmLugarEstreno

    Private Sub frmLugarEstreno_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim BLLugarEstreno As New BLLugarEstreno
        dgv_LugaresEstreno.DataSource = BLLugarEstreno.consultarLugaresEstreno()
    End Sub

    Private Sub btBuscarLugar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btBuscarLugar.Click
        frmBusquedaLugar.Show()
    End Sub

    Private Sub btBuscarPelicula_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btBuscarPelicula.Click
        frmBusquedaPelicula.Show()
    End Sub

    Private Sub btInsertar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btInsertar.Click
        Dim LugarEstreno As New LugarEstreno
        Dim BLLugarEstreno As New BLLugarEstreno

        If txtIdLugar.Text <> "" And txtIdPelicula.Text <> "" Then
            LugarEstreno.FK_PK_IdLugar = txtIdLugar.Text
            LugarEstreno.FK_PK_IdPelicula = txtIdPelicula.Text

            BLLugarEstreno.insertarLugarEstreno(LugarEstreno)

            dgv_LugaresEstreno.DataSource = BLLugarEstreno.consultarLugaresEstreno()

        Else
            MsgBox("Debe de digitar todos los campos del formulario", MsgBoxStyle.Critical, "Atención")
        End If

    End Sub

    Private Sub btModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btModificar.Click
        Dim LugarEstrenoAnterior As New LugarEstreno
        Dim LugarEstrenoNuevo As New LugarEstreno
        Dim BLLugarEstreno As New BLLugarEstreno

        If txtIdLugar.Text <> "" And txtIdPelicula.Text <> "" Then
            LugarEstrenoAnterior.FK_PK_IdLugar = dgv_LugaresEstreno.CurrentRow.Cells(0).Value
            LugarEstrenoAnterior.FK_PK_IdPelicula = dgv_LugaresEstreno.CurrentRow.Cells(2).Value
            LugarEstrenoNuevo.FK_PK_IdLugar = txtIdLugar.Text
            LugarEstrenoNuevo.FK_PK_IdPelicula = txtIdPelicula.Text

            BLLugarEstreno.modificarLugarEstreno(LugarEstrenoAnterior, LugarEstrenoNuevo)

            dgv_LugaresEstreno.DataSource = BLLugarEstreno.consultarLugaresEstreno()

            limpiarCampos()
        Else
            MsgBox("Debe de cargar primero un lugar de estreno de la lista de lugares", MsgBoxStyle.Critical, "Atención")
        End If

    End Sub

    Private Sub btEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btEliminar.Click
        Dim LugarEstreno As New LugarEstreno
        Dim BLLugarEstreno As New BLLugarEstreno

        Dim result As DialogResult = MsgBox("Desea eliminar el lugar de estreno seleccionado?", MsgBoxStyle.YesNo, "Eliminar Lugar de estreno")
        If result = DialogResult.Yes Then
            LugarEstreno.FK_PK_IdLugar = dgv_LugaresEstreno.CurrentRow.Cells(0).Value
            LugarEstreno.FK_PK_IdPelicula = dgv_LugaresEstreno.CurrentRow.Cells(2).Value

            BLLugarEstreno.eliminarLugarEstreno(LugarEstreno)

            dgv_LugaresEstreno.DataSource = BLLugarEstreno.consultarLugaresEstreno()

            limpiarCampos()
        End If

    End Sub

    Private Sub dgv_LugaresEstreno_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_LugaresEstreno.CellClick
        Try
            If dgv_LugaresEstreno.CurrentRow.Cells(0).Value.ToString <> "" Then
                txtIdLugar.Text = dgv_LugaresEstreno.CurrentRow.Cells(0).Value.ToString
                txtNombreLugar.Text = dgv_LugaresEstreno.CurrentRow.Cells(1).Value.ToString
                txtIdPelicula.Text = dgv_LugaresEstreno.CurrentRow.Cells(2).Value.ToString
                txtTituloPelicula.Text = dgv_LugaresEstreno.CurrentRow.Cells(3).Value.ToString
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub limpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles limpiar.Click
        limpiarCampos()
    End Sub

    Private Sub limpiarCampos()
        txtIdLugar.Text = ""
        txtNombreLugar.Text = ""
        txtIdPelicula.Text = ""
        txtTituloPelicula.Text = ""
    End Sub

End Class