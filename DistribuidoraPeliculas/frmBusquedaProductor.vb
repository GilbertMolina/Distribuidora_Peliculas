Imports BusinessLevel
Imports Domain

Public Class frmBusquedaProductor

    Private Sub frmBusquedaProductor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtNombre.Text = ""
    End Sub


    Private Sub btBuscar_Click(sender As Object, e As EventArgs) Handles btBuscar.Click
        Dim productor As New Productor
        Dim productorBL As New BLProductor
        Dim arr() = txtNombre.Text.Split(" ")
        productor.nombre = "%" & arr(0) & "%"
        Try
            productor.apellido1 = "%" & arr(1) & "%"
            productor.apellido2 = "%" & arr(2) & "%"
        Catch ex As Exception
            productor.apellido1 = "%" & "%"
            productor.apellido2 = "%" & "%"
        End Try
        dgvListaProductores.DataSource = productorBL.consultarProductorNombre(productor)
        dgvListaProductores.Columns("Nombre completo").Visible = False

    End Sub

    Private Sub Button2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button2.Click
        frmProductorPelicula.txtIdProductor.Text = dgvListaProductores.CurrentRow.Cells(0).Value
        frmProductorPelicula.txtNombreProductor.Text = dgvListaProductores.CurrentRow.Cells(4).Value
        Me.Close()
    End Sub
End Class