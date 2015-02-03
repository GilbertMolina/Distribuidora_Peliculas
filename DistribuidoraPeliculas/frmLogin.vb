Imports BusinessLevel
Imports Domain

Public Class frmLogin

    Private Sub btIngresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btIngresar.Click
        Dim usuario As New Usuario
        Dim usuarioConsultado As New Usuario
        Dim BLUsuario As New BLUsuario
        If txtNombreUsuario.Text <> "" And txtContrasenna.Text <> "" Then
            usuario.PK_Username = txtNombreUsuario.Text
            usuario.Contrasenna = txtContrasenna.Text
            usuarioConsultado = BLUsuario.consultarUsuario(usuario)
            If usuarioConsultado.PK_Username <> "NULL" Then
                mostrarMdiPrincipal()
            Else
                MsgBox("Usuario o contraseña erronea, por favor intente nuevamente", MsgBoxStyle.Exclamation, "Atención")
            End If
        Else
            MsgBox("Debe digitar los campos del formulario", MsgBoxStyle.Exclamation, "Atención")
        End If
    End Sub

    Public Sub mostrarMdiPrincipal()
        Dim MdiPrincipal As New mdiPrincipal
        MdiPrincipal.Show()
        Me.Close()
    End Sub

    Private Sub btSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSalir.Click
        Me.Close()
    End Sub

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
