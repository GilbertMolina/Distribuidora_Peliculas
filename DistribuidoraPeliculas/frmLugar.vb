Imports BusinessLevel
Imports Domain

Public Class frmLugar

    Private Sub btInsertar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btInsertar.Click
        Dim Lugar As New Lugar
        Dim BLLugar As New BLLugar

        If txtNombre.Text <> "" Then
            Lugar.Nombre = txtNombre.Text

            BLLugar.insertarLugar(Lugar)

            dgv_Lugares.DataSource = BLLugar.consultarLugares()

            limpiarCampos()

        Else
            MsgBox("Debe de digitar todos los campos del formulario", MsgBoxStyle.Critical, "Atención")
        End If

    End Sub

    Private Sub btModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btModificar.Click
        Dim Lugar As New Lugar
        Dim BLLugar As New BLLugar

        If txtNombre.Text <> "" Then
            Lugar.PK_IdLugar = dgv_Lugares.CurrentRow.Cells(0).Value
            Lugar.Nombre = txtNombre.Text

            BLLugar.modificarLugar(Lugar)

            dgv_Lugares.DataSource = BLLugar.consultarLugares()

            limpiarCampos()
        Else
            MsgBox("Debe de cargar primero un lugar de la lista de lugares", MsgBoxStyle.Critical, "Atención")
        End If

    End Sub

    Private Sub btEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btEliminar.Click
        Dim Lugar As New Lugar
        Dim BLLugar As New BLLugar

        Dim result As DialogResult = MsgBox("Desea eliminar el lugar seleccionado?", MsgBoxStyle.YesNo, "Eliminar Lugar")
        If result = DialogResult.Yes Then
            Lugar.PK_IdLugar = dgv_Lugares.CurrentRow.Cells(0).Value

            BLLugar.eliminarLugar(Lugar)

            dgv_Lugares.DataSource = BLLugar.consultarLugares()

            limpiarCampos()
        End If

    End Sub

    Private Sub limpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles limpiar.Click
        limpiarCampos()
    End Sub

    Private Sub frmLugar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim BLLugar As New BLLugar
        dgv_Lugares.DataSource = BLLugar.consultarLugares()
    End Sub

    Private Sub dgv_Lugares_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_Lugares.CellClick
        Try
            If dgv_Lugares.CurrentRow.Cells(0).Value.ToString <> "" Then
                txtNombre.Text = dgv_Lugares.CurrentRow.Cells(1).Value.ToString
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub limpiarCampos()
        txtNombre.Text = ""
    End Sub

End Class