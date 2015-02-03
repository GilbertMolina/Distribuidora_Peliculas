Imports BusinessLevel
Imports Domain

Public Class frmDirectores

    Private Sub btInsertar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btInsertar.Click
        Dim Director As New Director
        Dim BLDirector As New BLDirector

        If txtNombre.Text <> "" And txtPrimerApellido.Text <> "" And txtSegundoApellido.Text <> "" Then
            Director.Nombre = txtNombre.Text
            Director.Apellido1 = txtPrimerApellido.Text
            Director.Apellido2 = txtSegundoApellido.Text

            BLDirector.insertarDirector(Director)

            dgv_Directores.DataSource = BLDirector.consultarDirectores()

            limpiarCampos()
        Else
            MsgBox("Debe de digitar todos los campos del formulario", MsgBoxStyle.Critical, "Atención")
        End If

    End Sub

    Private Sub btModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btModificar.Click
        Dim Director As New Director
        Dim BLDirector As New BLDirector

        If txtNombre.Text <> "" And txtPrimerApellido.Text <> "" And txtSegundoApellido.Text <> "" Then
            Director.PK_IdDirector = dgv_Directores.CurrentRow.Cells(0).Value
            Director.Nombre = txtNombre.Text
            Director.Apellido1 = txtPrimerApellido.Text
            Director.Apellido2 = txtSegundoApellido.Text

            BLDirector.modificarDirector(Director)

            dgv_Directores.DataSource = BLDirector.consultarDirectores()
            dgv_Directores.Columns("PK_IdDirector").Visible = False

            limpiarCampos()
        Else
            MsgBox("Debe de cargar primero un director de la lista de directores", MsgBoxStyle.Critical, "Atención")
        End If

    End Sub

    Private Sub btEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btEliminar.Click
        Dim Director As New Director
        Dim BLDirector As New BLDirector

        Dim result As DialogResult = MsgBox("Desea eliminar el director seleccionado?", MsgBoxStyle.YesNo, "Eliminar Director")
        If result = DialogResult.Yes Then
            Director.PK_IdDirector = dgv_Directores.CurrentRow.Cells(0).Value

            BLDirector.eliminarDirector(Director)

            dgv_Directores.DataSource = BLDirector.consultarDirectores()
            dgv_Directores.Columns("PK_IdDirector").Visible = False

            limpiarCampos()
        End If

    End Sub

    Private Sub frmDirectores_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim BLDirector As New BLDirector
        dgv_Directores.DataSource = BLDirector.consultarDirectores()
        dgv_Directores.Columns("PK_IdDirector").Visible = False
    End Sub

    Private Sub dgv_Directores_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_Directores.CellClick

        Try
            If dgv_Directores.CurrentRow.Cells(0).Value.ToString <> "" Then
                txtNombre.Text = dgv_Directores.CurrentRow.Cells(1).Value
                txtPrimerApellido.Text = dgv_Directores.CurrentRow.Cells(2).Value
                txtSegundoApellido.Text = dgv_Directores.CurrentRow.Cells(3).Value
            End If
        Catch ex As Exception
            MsgBox("Error:" & ex.Message & "Elija un director", MsgBoxStyle.Critical, "Error")
        End Try

    End Sub

    Private Sub limpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles limpiar.Click
        limpiarCampos()
    End Sub

    Private Sub limpiarCampos()
        txtNombre.Text = ""
        txtPrimerApellido.Text = ""
        txtSegundoApellido.Text = ""
    End Sub

End Class