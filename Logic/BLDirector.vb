Imports DataAccess
Imports Domain

Public Class BLDirector

    Private DADirector As DADirectores

    Public Sub insertarDirector(ByVal director As Director)
        Dim directorConsultado As New Director

        directorConsultado.Nombre = "%" & director.Nombre & "%"
        directorConsultado.Apellido1 = "%" & director.Apellido1 & "%"
        directorConsultado.Apellido2 = "%" & director.Apellido2 & "%"

        directorConsultado = DADirector.consultarDirectorNombre(directorConsultado)

        If directorConsultado.Nombre = "NULL" Then
            DADirector.insertarDirector(director)
        Else
            MsgBox("Error: El director ya existe en la base de datos ", MsgBoxStyle.Critical, "Error al Insertar")
        End If
    End Sub

    Public Function consultarDirectores() As DataTable
        Return DADirector.consultarDirectores()
    End Function

    Public Function consultarDirectorNombre(ByVal director As Director) As Director
        Return DADirector.consultarDirectorNombre(director)
    End Function

    Public Function consultarDirectorID(ByVal director As Director) As Director
        Return DADirector.consultarDirectorID(director)
    End Function

    Public Function busquedaDirectorNombre(ByVal director As Director) As DataTable
        Return DADirector.busquedaDirectorNombre(director)
    End Function

    Public Sub modificarDirector(ByVal director As Director)
        Dim directorConsultado As New Director

        directorConsultado.PK_IdDirector = director.PK_IdDirector

        directorConsultado = DADirector.consultarDirectorID(directorConsultado)

        If directorConsultado.PK_IdDirector = -1 Then
            MsgBox("Error: El director no existe en la base de datos ", MsgBoxStyle.Critical, "Error al Modificar")
        Else
            DADirector.modificarDirector(director)
        End If
    End Sub

    Public Sub eliminarDirector(ByVal director As Director)
        DADirector.eliminarDirector(director)
    End Sub

    Public Sub New()
        DADirector = New DADirectores()
    End Sub

End Class
