Imports BusinessLevel
Imports Domain

Public Class frmBusquedaLugar

    Private Sub btBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btBuscar.Click
        Dim Lugar As New Lugar
        Dim BLLugar As New BLLugar
        Try
            Lugar.Nombre = "%" & txtNombre.Text & "%"
        Catch ex As Exception
            Lugar.Nombre = "%" & "%"
        End Try
        dgv_Lugares.DataSource = BLLugar.busquedaLugarNombre(Lugar)

    End Sub

    Private Sub btSeleccionar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSeleccionar.Click
        frmLugarEstreno.txtIdLugar.Text = dgv_Lugares.CurrentRow.Cells(0).Value
        frmLugarEstreno.txtNombreLugar.Text = dgv_Lugares.CurrentRow.Cells(1).Value
        Me.Close()
    End Sub

    Private Sub frmBusquedaLugar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtNombre.Text = ""
    End Sub

End Class