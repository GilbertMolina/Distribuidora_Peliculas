Imports BusinessLevel
Imports Domain

Public Class frmPremiosPorPelicula

    Private Sub frmPremiosPorPelicula_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    Private Sub btBuscarPelicula_Click(sender As Object, e As EventArgs) Handles btBuscarPelicula.Click
        frmBusquedaPelicula.Show()
        limpiarCampos()
    End Sub


    Private Sub btBuscar_Click(sender As Object, e As EventArgs) Handles btBuscar.Click
        Dim pelicula As New Pelicula
        Dim peliculaBl As New BLPelicula
        Dim premio As New Premio
        Dim premioBl As New BLPremio

        If txtIdPeli.Text <> "" Then
            pelicula.PK_IdPelicula = txtIdPeli.Text
            dgvPremiosPorPeli.DataSource = premioBl.consultarPremiosPelicula(txtIdPeli.Text)
            Dim peliculaBuscada = peliculaBl.consultarPeliculaID(pelicula)
            txtPaisOrigen.Text = peliculaBuscada.Nacionalidad
            txtNombrePeli.Text = peliculaBuscada.Titulo
        Else
            MsgBox("Debe indicar el Id de la pelicula", MsgBoxStyle.Information, "Información")
        End If        
    End Sub

    Private Sub limpiarCampos()
        txtPaisOrigen.Text = ""
        txtIdPeli.Text = ""
        txtNombrePeli.Text = ""
    End Sub

End Class