Imports BusinessLevel
Imports Domain

Public Class frmBusquedaPelicula

    Private Sub btBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btBuscar.Click
        Dim Pelicula As New Pelicula
        Dim BLPelicula As New BLPelicula
        Try
            Pelicula.Titulo = "%" & txtTitulo.Text & "%"
        Catch ex As Exception
            Pelicula.Titulo = "%" & "%"
        End Try
        dgv_Peliculas.DataSource = BLPelicula.busquedaPeliculaTitulo(Pelicula)

    End Sub

    Private Sub btSeleccionar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSeleccionar.Click
        If frmCritica.Visible Then
            frmCritica.comboxPeli.SelectedValue = dgv_Peliculas.CurrentRow.Cells(0).Value
        End If

        If frmAnuncios.Visible Then
            frmAnuncios.comboPeli.SelectedValue = dgv_Peliculas.CurrentRow.Cells(0).Value
        End If

        If frmPremios.Visible Then
            frmPremios.txtIdPeli.Text = dgv_Peliculas.CurrentRow.Cells(0).Value
            frmPremios.txtTituloPelicula.Text = dgv_Peliculas.CurrentRow.Cells(1).Value
        End If

        If frmPremiosPorPelicula.Visible Then
            frmPremiosPorPelicula.txtIdPeli.Text = dgv_Peliculas.CurrentRow.Cells(0).Value
        End If

        If frmLugarEstreno.Visible Then
            frmLugarEstreno.txtIdPelicula.Text = dgv_Peliculas.CurrentRow.Cells(0).Value
            frmLugarEstreno.txtTituloPelicula.Text = dgv_Peliculas.CurrentRow.Cells(1).Value
        End If

        If frmActoresPorPelicula.Visible Then
            frmActoresPorPelicula.txtIdPelicula.Text = dgv_Peliculas.CurrentRow.Cells(0).Value
            frmActoresPorPelicula.txtTituloPelicula.Text = dgv_Peliculas.CurrentRow.Cells(1).Value
        End If

        If frmProductorPelicula.Visible Then
            frmProductorPelicula.txtIdPelicula.Text = dgv_Peliculas.CurrentRow.Cells(0).Value
            frmProductorPelicula.txtTituloPelicula.Text = dgv_Peliculas.CurrentRow.Cells(1).Value
        End If

        Me.Close()

    End Sub


    Private Sub frmBusquedaPelicula_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtTitulo.Text = ""
    End Sub

End Class