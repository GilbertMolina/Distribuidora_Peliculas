Imports DataAccess
Imports Domain

Public Class BLUsuario

    Private DAUsuario As DAUsuarios

    Public Function consultarUsuario(ByVal usuario As Usuario) As Usuario
        Return DAUsuario.consultarUsuario(usuario)
    End Function

    Public Sub New()
        DAUsuario = New DAUsuarios()
    End Sub

End Class
