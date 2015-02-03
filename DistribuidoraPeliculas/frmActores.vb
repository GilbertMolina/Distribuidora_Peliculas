Imports BusinessLevel
Imports Domain
Imports System.IO

Public Class frmActores
    Dim oActor As BLActores
    Private Sub frmActores_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load

        CargarGrid()
        CargarCombo()

        Me.btModificar.Enabled = False
        Me.btEliminar.Enabled = False
        Me.btInsertar.Enabled = True

    End Sub

    Private Sub CargarGrid()
        Dim lActor As List(Of Actor)
        oActor = New BLActores

        lActor = oActor.CargarActorAll

        DataGridView1.DataSource = lActor
        DataGridView1.MultiSelect = False
        DataGridView1.Columns("Foto").Visible = False
        DataGridView1.Columns("IdActor").Visible = False
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        LimpiarControles()


        Dim col = e.ColumnIndex
        Dim row = e.RowIndex
        If (row >= 0) Then
            txtNombre.Text = DataGridView1.CurrentRow.Cells(1).Value
            txtApe1.Text = DataGridView1.CurrentRow.Cells(2).Value
            txtApe2.Text = DataGridView1.CurrentRow.Cells(3).Value
            txtDireccion.Text = DataGridView1.CurrentRow.Cells(4).Value
            txtTelefono.Text = DataGridView1.CurrentRow.Cells(5).Value
            dtNacimiento.Text = DataGridView1.CurrentRow.Cells(6).Value
            cbEstCivil.SelectedText = DataGridView1.CurrentRow.Cells(7).Value
            Try
                Dim resizeImg As Image
                Dim width As Integer = 131
                Dim height As Integer = 157
                Dim data() As Byte
                data = DataGridView1.CurrentRow.Cells(8).Value
                Dim mem As New MemoryStream(data)
                resizeImg = Image.FromStream(mem).GetThumbnailImage(width, height, Nothing, Nothing)
                pcActor.Image = resizeImg
                pcActor.BackgroundImageLayout = ImageLayout.Stretch
            Catch ex As Exception
                Dim g As Graphics = pcActor.CreateGraphics()
                g.Clear(pcActor.BackColor)
                g.Dispose()
            End Try

        End If

        Me.btInsertar.Enabled = False
        Me.btModificar.Enabled = True
        Me.btEliminar.Enabled = True

    End Sub

    Private Sub CargarCombo()
        cbEstCivil.Items.Clear()
        cbEstCivil.Items.Add("Soltero")
        cbEstCivil.Items.Add("Casado")
        cbEstCivil.Items.Add("Viudo")
        cbEstCivil.Items.Add("Divorciado")

    End Sub

    Private Sub LimpiarControles()
        txtNombre.Text = ""
        txtApe1.Text = ""
        txtApe2.Text = ""
        txtDireccion.Text = ""
        txtTelefono.Text = ""
        dtNacimiento.Text = ""
        cbEstCivil.Text = ""
        Dim g As Graphics = pcActor.CreateGraphics()
        g.Clear(pcActor.BackColor)
        g.Dispose()
        CargarCombo()
    End Sub


    Private Sub limpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles limpiar.Click
        Me.btModificar.Enabled = False
        Me.btEliminar.Enabled = False
        Me.btInsertar.Enabled = True
        LimpiarControles()
    End Sub

    Private Sub btInsertar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btInsertar.Click
        Try
            If ValidarCampos() Then
                InsertarActor()
                LimpiarControles()
                CargarGrid()
                MsgBox("Se insertó el actor", MsgBoxStyle.Information, "Atencion")
            Else
                MsgBox("Todos los campos deben ir con un valor asignado", MsgBoxStyle.Information, "Atencion")
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Error al insertar el actor")
        End Try
    End Sub

    Private Function ValidarCampos() As Boolean
        If txtNombre.Text = "" Then
            Return False
        End If
        If txtApe1.Text = "" Then
            Return False
        End If
        If txtApe2.Text = "" Then
            Return False
        End If
        If txtDireccion.Text = "" Then
            Return False
        End If
        If txtTelefono.Text = "" Then
            Return False
        End If
        If dtNacimiento.Text = "" Then
            Return False
        End If
        Return True
    End Function

    Private Sub InsertarActor()
        oActor.InsertarActor(AsignarValores())
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim g As Graphics = pcActor.CreateGraphics()
        g.Clear(pcActor.BackColor)
        g.Dispose()
        OpenFileDialog1.Filter = "Archivos JPG (*.jpg)|*.jpg|Archivos BMP (*.bmp)|*.bmp"
        If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            pcActor.BackgroundImage = Image.FromFile(OpenFileDialog1.FileName)
            pcActor.BackgroundImageLayout = ImageLayout.Stretch
        End If
        


    End Sub

    Private Sub btModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btModificar.Click
        If ValidarCampos() Then
            ModificarActor()
            LimpiarControles()
            CargarGrid()
            MsgBox("Se modificó el actor", MsgBoxStyle.Information, "Atencion")
        Else
            MsgBox("Todos los campos deben ir con un valor asignado", MsgBoxStyle.Information, "Atencion")
        End If
    End Sub

    Private Sub ModificarActor()
        oActor.ModificarActor(AsignarValores2())
    End Sub

    Private Function AsignarValores2() As Actor
        Dim actor As New Actor
        actor.IdActor = DataGridView1.CurrentRow.Cells(0).Value
        actor.Nombre = txtNombre.Text
        actor.Apellido1 = txtApe1.Text
        actor.Apellido2 = txtApe2.Text
        actor.Direccion = txtDireccion.Text
        actor.NumeroTelefono = txtTelefono.Text
        actor.FechaNacimiento = dtNacimiento.Text
        Try
            actor.Foto = File.ReadAllBytes(OpenFileDialog1.FileName)
        Catch ex As Exception
            actor.Foto = Nothing
        End Try

        Select Case cbEstCivil.Text
            Case "Soltero"
                actor.EstadoCivil = "1"

            Case "Casado"
                actor.EstadoCivil = "2"

            Case "Viudo"
                actor.EstadoCivil = "3"

            Case "Divorciado"
                actor.EstadoCivil = "4"

        End Select
        Return actor
    End Function

    Private Function AsignarValores() As Actor
        Dim actor As New Actor
        actor.Nombre = txtNombre.Text
        actor.Apellido1 = txtApe1.Text
        actor.Apellido2 = txtApe2.Text
        actor.Direccion = txtDireccion.Text
        actor.NumeroTelefono = txtTelefono.Text
        actor.FechaNacimiento = dtNacimiento.Text
        Try
            actor.Foto = File.ReadAllBytes(OpenFileDialog1.FileName)
        Catch ex As Exception
            actor.Foto = Nothing
        End Try

        Select Case cbEstCivil.Text
            Case "Soltero"
                actor.EstadoCivil = "1"

            Case "Casado"
                actor.EstadoCivil = "2"

            Case "Viudo"
                actor.EstadoCivil = "3"

            Case "Divorciado"
                actor.EstadoCivil = "4"

        End Select
        Return actor
    End Function

    Private Sub btEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btEliminar.Click
        If MessageBox.Show("¿Está seguro que desea eliminar al actor seleccionado?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.Yes Then
            If ValidarCampos() Then
                EliminarActor()
                LimpiarControles()
                CargarGrid()
                MsgBox("Se eliminó el actor", MsgBoxStyle.Information, "Atencion")
            Else
                MsgBox("Todos los campos deben ir con un valor asignado", MsgBoxStyle.Information, "Atencion")
            End If
        End If
    End Sub

    Private Sub EliminarActor()
        oActor.EliminarActor(AsignarValores2())
    End Sub

End Class