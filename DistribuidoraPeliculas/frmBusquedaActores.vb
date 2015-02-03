Imports BusinessLevel
Imports Domain

Public Class frmBusquedaActores

    Private Sub btBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btBuscar.Click
        Dim actor As New Actor
        Dim oActor As New BLActores
        Try
            Dim y() As String = txtTitulo.Text.Split(" ")

            If y.Count() > 0 Then
                actor.Nombre = "%" & y(0) & "%"
            Else
                actor.Nombre = "%%"
            End If
            If y.Count() > 1 Then
                actor.Apellido1 = "%" & y(1) & "%"
            Else
                actor.Apellido1 = "%%"
            End If
            If y.Count() > 2 Then
                actor.Apellido2 = "%" & y(2) & "%"
            Else
                actor.Apellido2 = "%%"
            End If
        Catch ex As Exception
            actor.Nombre = "%%"
            actor.Apellido1 = "%%"
            actor.Apellido2 = "%%"
        End Try
        dgv_Actores.DataSource = oActor.BuscarPorNombre(actor)
        dgv_Actores.Columns("PK_IdActor").Visible = False
        dgv_Actores.Columns("Nombre completo").Visible = False
    End Sub

    Private Sub btSeleccionar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSeleccionar.Click
        frmActoresPorPelicula.txtIdActor.Text = dgv_Actores.CurrentRow.Cells(0).Value
        frmActoresPorPelicula.txtNombreActor.Text = dgv_Actores.CurrentRow.Cells(4).Value
        Me.Close()
    End Sub

End Class