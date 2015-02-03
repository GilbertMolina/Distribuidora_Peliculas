Imports BusinessLevel
Imports Domain

Public Class frmPremios

    Private Sub frmPremios_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Dim BLPremio As New BLPremio
        dgvPremios.DataSource = BLPremio.consultarPremios()
        dgvPremios.Columns("PK_IdPremio").Visible = False
        dgvPremios.Columns("FK_IdPelicula").Visible = False
        limpiarCampos()
    End Sub

    Private Sub btBuscarPelicula_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btBuscarPelicula.Click
        frmBusquedaPelicula.Show()
    End Sub

    Private Sub btAgregar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btAgregar.Click
        Dim premio As New Premio
        Dim premioBL As New BLPremio

        If txtIdPeli.Text <> "" And txtNombrePremio.Text <> "" And txtCiudad.Text <> "" And txtNombreCertamen.Text <> "" Then
            premio.idPelicula = txtIdPeli.Text
            premio.nombre = txtNombreCertamen.Text & " - " & txtNombrePremio.Text
            premio.ciudad = txtCiudad.Text

            premioBL.insertarPremio(premio)

            dgvPremios.DataSource = premioBL.consultarPremios()
            limpiarCampos()
        Else
            MsgBox("No pueden existir lugares vacios en el formulario", MsgBoxStyle.Information, "Información")
        End If
    End Sub

    Private Sub btEliminar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btEliminar.Click
        Dim premio As New Premio
        Dim premioBL As New BLPremio

        Dim result As DialogResult = MsgBox("Desea eliminar el premio?", MsgBoxStyle.YesNo, "Eliminar")
        If result = DialogResult.Yes Then
            premio.idPremio = dgvPremios.CurrentRow.Cells(0).Value
            premio.idPelicula = dgvPremios.CurrentRow.Cells(1).Value

            premioBL.eliminarPremio(premio)

            dgvPremios.DataSource = premioBL.consultarPremios()
        End If
    End Sub

    Private Sub btModificar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btModificar.Click
        Dim premio As New Premio
        Dim premioBL As New BLPremio

        If txtIdPeli.Text <> "" And txtNombrePremio.Text <> "" And txtNombreCertamen.Text <> "" And txtCiudad.Text <> "" Then
            Dim resultado As DialogResult = MsgBox("Desea modificar los datos del premio", MsgBoxStyle.YesNo, "Modificar")
            If resultado = Windows.Forms.DialogResult.Yes Then
                premio.idPremio = dgvPremios.CurrentRow.Cells(0).Value
                premio.idPelicula = txtIdPeli.Text
                premio.nombre = txtNombreCertamen.Text & " - " & txtNombrePremio.Text
                premio.ciudad = txtCiudad.Text
                premioBL.modificarPremio(premio)
                dgvPremios.DataSource = premioBL.consultarPremios()
                dgvPremios.Columns("PK_IdPremio").Visible = False
                dgvPremios.Columns("FK_IdPelicula").Visible = False
            End If
        Else
            MsgBox("Seleccione un premio para modificar", MsgBoxStyle.Information, "Información")
        End If

        limpiarCampos()
    End Sub

    Private Sub dgvPremios_CellClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles dgvPremios.CellClick

        Try
            If dgvPremios.CurrentRow.Cells(0).Value.ToString = "" Then
            Else
                Dim nombrePremio As String = dgvPremios.CurrentRow.Cells(3).Value
                Dim arr() = nombrePremio.Split("-")
                txtIdPeli.Text = dgvPremios.CurrentRow.Cells(1).Value
                txtTituloPelicula.Text = dgvPremios.CurrentRow.Cells(2).Value
                txtNombreCertamen.Text = arr(0).TrimEnd()
                txtNombrePremio.Text = arr(1).TrimStart()
                txtCiudad.Text = dgvPremios.CurrentRow.Cells(4).Value
            End If

        Catch ex As Exception
            MsgBox("Error:" & ex.Message & "Elija un premio", MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub limpiar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles limpiar.Click
        limpiarCampos()
    End Sub

    Private Sub limpiarCampos()
        txtIdPeli.Text = ""
        txtTituloPelicula.Text = ""
        txtNombrePremio.Text = ""
        txtNombreCertamen.Text = ""
        txtNombrePremio.Text = ""
        txtCiudad.Text = ""
    End Sub

End Class