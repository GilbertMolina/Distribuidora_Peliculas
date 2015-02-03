Imports BusinessLevel
Imports Domain

Public Class frmProductor

    Private Sub frmProductor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim BLProductor As New BLProductor
        dgvProductores.DataSource = BLProductor.consultarProductores()
        limpiarCampos()
    End Sub

    Private Sub limpiarCampos()
        txtNombre.Text = ""
        txtApellido1.Text = ""
        txtApellido2.Text = ""
    End Sub


    Private Sub btAgregar_Click(sender As Object, e As EventArgs) Handles btAgregar.Click
        Dim productor As New Productor
        Dim productorBL As New BLProductor

        If txtNombre.Text <> "" And txtApellido1.Text <> "" And txtApellido2.Text <> "" Then
            productor.nombre = txtNombre.Text
            productor.apellido1 = txtApellido1.Text
            productor.apellido2 = txtApellido2.Text

            productorBL.insertarProductor(productor)

            dgvProductores.DataSource = productorBL.consultarProductores()
            limpiarCampos()
        Else
            MsgBox("No pueden existir lugares vacios en el formulario", MsgBoxStyle.Information, "Información")
        End If
    End Sub

    Private Sub dgvProductores_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProductores.CellClick
        Try
            If dgvProductores.CurrentRow.Cells(0).Value.ToString = "" Then
            Else
                txtNombre.Text = dgvProductores.CurrentRow.Cells(1).Value
                txtApellido1.Text = dgvProductores.CurrentRow.Cells(2).Value
                txtApellido2.Text = dgvProductores.CurrentRow.Cells(3).Value

            End If

        Catch ex As Exception
            MsgBox("Error:" & ex.Message & "Elija un productor", MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub btEditar_Click(sender As Object, e As EventArgs) Handles btEditar.Click
        Dim productor As New Productor
        Dim productorBL As New BLProductor

        If txtNombre.Text <> "" And txtApellido1.Text <> "" And txtApellido2.Text <> "" Then
            Dim resultado As DialogResult = MsgBox("Desea modificar los datos del productor", MsgBoxStyle.YesNo, "Modificar")
            If resultado = Windows.Forms.DialogResult.Yes Then
                productor.idProductor = dgvProductores.CurrentRow.Cells(0).Value
                productor.nombre = txtNombre.Text
                productor.apellido1 = txtApellido1.Text
                productor.apellido2 = txtApellido2.Text
                productorBL.modificarProductor(productor)
                dgvProductores.DataSource = productorBL.consultarProductores()
            End If
        Else
            MsgBox("Seleccione un productor para modificar", MsgBoxStyle.Information, "Información")
        End If

        limpiarCampos()
    End Sub


    Private Sub btEliminar_Click(sender As Object, e As EventArgs) Handles btEliminar.Click
        Dim productor As New Productor
        Dim productorBL As New BLProductor

        Dim result As DialogResult = MsgBox("Desea eliminar el productor?", MsgBoxStyle.YesNo, "Eliminar")
        If result = DialogResult.Yes Then
            productor.idProductor = dgvProductores.CurrentRow.Cells(0).Value

            productorBL.eliminarProductor(productor)

            dgvProductores.DataSource = productorBL.consultarProductores()
        End If

        limpiarCampos()

    End Sub

    Private Sub btLimpiar_Click(sender As Object, e As EventArgs) Handles btLimpiar.Click
        limpiarCampos()
    End Sub
End Class