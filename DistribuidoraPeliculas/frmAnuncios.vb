Imports BusinessLevel
Imports Domain
Public Class frmAnuncios

    Private Sub Mant_Anuncios_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Dim blAnuncio As New BLAnuncio
        dgvAnuncios.DataSource = blAnuncio.consultaAnuncios

        dgvAnuncios.Columns("ID").Visible = False
        dgvAnuncios.Columns("cod_pelicula").Visible = False

        'cargar combobox
        Dim BLPelicula As New BLPelicula
        comboPeli.DataSource = BLPelicula.consultarPeliculas
        comboPeli.DisplayMember = "titulo"
        comboPeli.ValueMember = "PK_IdPelicula"

    End Sub


    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles dgvAnuncios.CellClick
        Try
            If dgvAnuncios.CurrentRow.Cells(0).Value.ToString = "" Then
            Else
                txtCodAnuncio.Text = dgvAnuncios.CurrentRow.Cells(0).Value

                btnNuevo.Text = "Editar"
                dateFecha.Text = dgvAnuncios.CurrentRow.Cells(2).Value
                txtCodPeli.Text = dgvAnuncios.CurrentRow.Cells(1).Value
                comboPeli.SelectedValue = dgvAnuncios.CurrentRow.Cells(1).Value

            End If
               

        Catch ex As Exception
            MsgBox("Error:" & ex.Message & "Elija un item correcto", MsgBoxStyle.Critical, "Error critica")
        End Try


    End Sub

    Private Sub btnNuevo_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnNuevo.Click
        Try

            Dim anuncio As New Anuncio
            Dim blanuncio As New BLAnuncio
            If btnNuevo.Text = "Nuevo" Then
                If dateFecha.Text <> "" And comboPeli.Text <> "" And txtCodPeli.Text <> "" Then
                    anuncio.pelicula.PK_IdPelicula = txtCodPeli.Text
                    anuncio.FechaEnvio = dateFecha.Text
                    blanuncio.insertarAnuncio(anuncio)
                Else
                    MsgBox("Debe de digitar todos los campos del formulario", MsgBoxStyle.Critical, "Atención")
                End If
            Else
                'modificar
                anuncio.Id = txtCodAnuncio.Text
                anuncio.FechaEnvio = dateFecha.Text
                anuncio.pelicula.PK_IdPelicula = txtCodPeli.Text

                blanuncio.modificarAnuncio(anuncio)

            End If

            dgvAnuncios.DataSource = blanuncio.consultaAnuncios

            dgvAnuncios.Columns("ID").Visible = False
            dgvAnuncios.Columns("cod_pelicula").Visible = False
            limpiarCampos()
        Catch ex As Exception
            MsgBox(ex.Message & "Error: Al insertar datos ", MsgBoxStyle.Critical, "ERROR")
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click

        Dim BLAnuncio As New BLAnuncio
        Dim anuncio As New Anuncio
        Try
            anuncio.Id = dgvAnuncios.CurrentRow.Cells(0).Value
            BLAnuncio.eliminaAnuncio(anuncio)

            limpiarCampos()
        Catch ex As Exception
            MsgBox(ex.Message & "Debe elegir el anuncio a eliminar", MsgBoxStyle.Critical, "ERROR")
        End Try



        dgvAnuncios.DataSource = BLAnuncio.consultaAnuncios
        dgvAnuncios.Columns("ID").Visible = False
        dgvAnuncios.Columns("cod_pelicula").Visible = False

    End Sub

    Private Sub btnBuscar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnBuscar.Click
        frmBusquedaPelicula.Show()

    End Sub


    Private Sub comboPeli_SelectedValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles comboPeli.SelectedValueChanged
        txtCodPeli.Text = comboPeli.SelectedValue.ToString

    End Sub

    Private Sub btnLimpiar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnLimpiar.Click
        limpiarCampos()
    End Sub

    Private Sub limpiarCampos()
        txtCodAnuncio.Text = ""
        dateFecha.Text = ""
        comboPeli.Text = ""
        txtCodPeli.Text = ""
        btnNuevo.Text = "Nuevo"
    End Sub

End Class