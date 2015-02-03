Imports BusinessLevel
Imports Domain

Public Class frmBusquedaDirector

    Private Sub btBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btBuscar.Click
        Dim Director As New Director
        Dim BLDirector As New BLDirector
        Dim arr() = txtNombre.Text.Split(" ")
        Director.Nombre = "%" & arr(0) & "%"
        Try
            Director.Apellido1 = "%" & arr(1) & "%"
            Director.Apellido2 = "%" & arr(2) & "%"
        Catch ex As Exception
            Director.Apellido1 = "%" & "%"
            Director.Apellido2 = "%" & "%"
        End Try
        dgv_Directores.DataSource = BLDirector.busquedaDirectorNombre(Director)
        dgv_Directores.Columns("Nombre completo").Visible = False

    End Sub

    Private Sub btSeleccionar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSeleccionar.Click
        frmPeliculas.txtIdDirector.Text = dgv_Directores.CurrentRow.Cells(0).Value
        frmPeliculas.txtNombreDirector.Text = dgv_Directores.CurrentRow.Cells(4).Value
        Me.Close()

    End Sub

    Private Sub frmBusquedaDirector_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtNombre.Text = ""

    End Sub

End Class