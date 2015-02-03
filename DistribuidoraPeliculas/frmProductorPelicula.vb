Imports BusinessLevel
Imports Domain

Public Class frmProductorPelicula

    Private Sub ProductorPelicula_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim productorPeliculaBL As New BLProductoresPelicula
        dgvProductorPeli.DataSource = productorPeliculaBL.consultarProductorPelicula()
    End Sub

    Private Sub btBuscarProductor_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btBuscarProductor.Click
        frmBusquedaProductor.Show()
    End Sub

    Private Sub btBuscarPeli_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btBuscarPeli.Click
        frmBusquedaPelicula.Show()
    End Sub

    Private Sub btAgregar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btAgregar.Click
        Dim productorPelicula As New ProductoresPelicula
        Dim productorPeliculaBL As New BLProductoresPelicula

        If txtIdPelicula.Text <> "" And txtIdProductor.Text <> "" And txtAporte.Text <> "" Then
            productorPelicula.idPelicula = txtIdPelicula.Text
            productorPelicula.idProductor = txtIdProductor.Text
            productorPelicula.aporte = txtAporte.Text

            productorPeliculaBL.insertarProductorPelicula(productorPelicula)

            dgvProductorPeli.DataSource = productorPeliculaBL.consultarProductorPelicula()

            limpiarCampos()
        Else
            MsgBox("Debe de digitar todos los campos del formulario", MsgBoxStyle.Critical, "Atención")
        End If
    End Sub


    Public Sub limpiarCampos()
        txtIdProductor.Text = ""
        txtNombreProductor.Text = ""
        txtIdPelicula.Text = ""
        txtTituloPelicula.Text = ""
        txtAporte.Text = ""
    End Sub

    Private Sub btEditar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btEditar.Click
        Dim productorPelicula As New ProductoresPelicula
        Dim productorPeliculaBL As New BLProductoresPelicula

        If txtIdPelicula.Text <> "" And txtIdProductor.Text <> "" And txtAporte.Text <> "" Then
            Dim resultado As DialogResult = MsgBox("Desea modificar los datos del premio", MsgBoxStyle.YesNo, "Modificar")
            If resultado = Windows.Forms.DialogResult.Yes Then
                productorPelicula.idPelicula = txtIdPelicula.Text
                productorPelicula.idProductor = txtIdProductor.Text
                productorPelicula.aporte = txtAporte.Text

                productorPeliculaBL.modificarProductorPelicula(productorPelicula)

                dgvProductorPeli.DataSource = productorPeliculaBL.consultarProductorPelicula()

                limpiarCampos()
            End If
        Else
            MsgBox("Seleccione una fila para modificar", MsgBoxStyle.Critical, "Atención")
        End If

        limpiarCampos()
    End Sub

    Private Sub btEliminar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btEliminar.Click
        Dim productorPelicula As New ProductoresPelicula
        Dim productorPeliculaBL As New BLProductoresPelicula

        Dim result As DialogResult = MsgBox("Desea eliminar el productor por pelicula?", MsgBoxStyle.YesNo, "Eliminar")
        If result = DialogResult.Yes Then
            productorPelicula.idPelicula = dgvProductorPeli.CurrentRow.Cells(0).Value
            productorPelicula.idProductor = dgvProductorPeli.CurrentRow.Cells(2).Value

            productorPeliculaBL.eliminarProductorPelicula(productorPelicula)

            dgvProductorPeli.DataSource = productorPeliculaBL.consultarProductorPelicula()
        End If

        limpiarCampos()

    End Sub

    Private Sub dgvProductorPeli_CellClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles dgvProductorPeli.CellClick
        Try
            If dgvProductorPeli.CurrentRow.Cells(0).Value.ToString = "" Then
            Else
                txtIdPelicula.Text = dgvProductorPeli.CurrentRow.Cells(0).Value
                txtTituloPelicula.Text = dgvProductorPeli.CurrentRow.Cells(1).Value
                txtIdProductor.Text = dgvProductorPeli.CurrentRow.Cells(2).Value
                txtNombreProductor.Text = dgvProductorPeli.CurrentRow.Cells(3).Value
                txtAporte.Text = dgvProductorPeli.CurrentRow.Cells(4).Value
            End If

        Catch ex As Exception
            MsgBox("Error:" & ex.Message & "Elija un productor pelicula", MsgBoxStyle.Critical, "Error")
        End Try

    End Sub

    Private Sub btLimpiar_Click(sender As Object, e As EventArgs) Handles btLimpiar.Click
        limpiarCampos()
    End Sub

End Class