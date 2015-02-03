Imports BusinessLevel
Imports Domain

Public Class frmCritica

    Private Sub Mant_Critica_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Dim blCritica As New BLCritica
        dgvCriticas.DataSource = blCritica.consultaCriticas

        dgvCriticas.Columns("ID").Visible = False
        dgvCriticas.Columns("cod_pelicula").Visible = False

        'cargar combobox
        Dim BLPelicula As New BLPelicula
        comboxPeli.DataSource = BLPelicula.consultarPeliculas
        comboxPeli.DisplayMember = "titulo"
        comboxPeli.ValueMember = "PK_IdPelicula"

    End Sub



    Private Sub btnAgregar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnAgregar.Click
        Try

            Dim critica As New Critica
            Dim BLCritica As New BLCritica
            If btnAgregar.Text = "Nuevo" Then
                If comboxPeli.Text <> "" And txtCodPeli.Text <> "" And txtAutor.Text <> "" And txtMedio.Text <> "" Then
                    critica.pelicula.PK_IdPelicula = txtCodPeli.Text
                    critica.fecha = dateFechaCritica.Text
                    critica.autor = txtAutor.Text
                    critica.nombreMedio = txtMedio.Text

                    BLCritica.insertarCritica(critica)
                Else
                    MsgBox("Debe de digitar todos los campos del formulario", MsgBoxStyle.Critical, "Atención")
                End If
            Else
                'modificar
                critica.id = txtCodCritica.Text
                critica.pelicula.PK_IdPelicula = txtCodPeli.Text
                critica.fecha = dateFechaCritica.Text
                critica.autor = txtAutor.Text
                critica.nombreMedio = txtMedio.Text

                BLCritica.modificarCritica(critica)
            End If


            dgvCriticas.DataSource = BLCritica.consultaCriticas

            dgvCriticas.Columns("ID").Visible = False
            dgvCriticas.Columns("cod_pelicula").Visible = False
            limpiarCampos()
        Catch ex As Exception
            MsgBox(ex.Message & "Error al ingresar datos", MsgBoxStyle.Critical, "ERROR")
        End Try
    End Sub

    Private Sub dgvCriticas_CellClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles dgvCriticas.CellClick
        Try
            If dgvCriticas.CurrentRow.Cells(0).Value.ToString = "" Then
            Else
                txtCodCritica.Text = dgvCriticas.CurrentRow.Cells(1).Value
                comboxPeli.SelectedValue = dgvCriticas.CurrentRow.Cells(2).Value
                btnAgregar.Text = "Editar"
                dateFechaCritica.Text = dgvCriticas.CurrentRow.Cells(0).Value
                txtCodPeli.Text = dgvCriticas.CurrentRow.Cells(2).Value
                txtAutor.Text = dgvCriticas.CurrentRow.Cells(4).Value
                txtMedio.Text = dgvCriticas.CurrentRow.Cells(5).Value
            End If
        Catch ex As Exception
            MsgBox("Error:" & ex.Message & "Elija un item correcto", MsgBoxStyle.Critical, "Error critica")
        End Try
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnEliminar.Click
        Dim BLcritica As New BLCritica
        Dim critica As New Critica
        Try


            critica.id = dgvCriticas.CurrentRow.Cells(1).Value
            BLcritica.eliminaCritica(critica)

        Catch ex As Exception
            MsgBox(ex.Message & "Debe elegir la critica a eliminar", MsgBoxStyle.Critical, "ERROR")

        End Try

        dgvCriticas.DataSource = BLcritica.consultaCriticas

        dgvCriticas.Columns("ID").Visible = False
        dgvCriticas.Columns("cod_pelicula").Visible = False
        limpiarCampos()

    End Sub

    Private Sub btnBusca_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnBusca.Click
        frmBusquedaPelicula.Show()
    End Sub

    Private Sub comboxPeli_SelectedValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles comboxPeli.SelectedValueChanged
        txtCodPeli.Text = comboxPeli.SelectedValue.ToString
    End Sub

    Private Sub btnLimpiar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnLimpiar.Click
        limpiarCampos()
    End Sub

    Private Sub limpiarCampos()
        txtCodCritica.Text = ""
        dateFechaCritica.Text = ""
        comboxPeli.Text = ""
        txtCodPeli.Text = ""
        txtAutor.Text = ""
        txtMedio.Text = ""
        btnAgregar.Text = "Nuevo"
    End Sub

End Class