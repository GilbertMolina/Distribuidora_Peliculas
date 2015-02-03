Imports DataAccess
Imports Domain

Public Class BLLugar

    Private DALugar As DALugar

    Public Sub insertarLugar(ByVal lugar As Lugar)
        Dim lugarConsultado As New Lugar

        lugarConsultado.Nombre = "%" & lugar.Nombre & "%"

        lugarConsultado = DALugar.consultarLugarNombre(lugarConsultado)

        If lugarConsultado.Nombre = "NULL" Then
            DALugar.insertarLugar(lugar)
        Else
            MsgBox("Error: El lugar ya existe en la base de datos", MsgBoxStyle.Critical, "Error al Insertar")
        End If
    End Sub

    Public Function consultarLugares() As DataTable
        Return DALugar.consultarLugares()
    End Function

    Public Function consultarLugarID(ByVal lugar As Lugar) As Lugar
        Return DALugar.consultarLugarID(lugar)
    End Function

    Public Function busquedaLugarNombre(ByVal lugar As Lugar) As DataTable
        Return DALugar.busquedaLugarNombre(lugar)
    End Function

    Public Sub modificarLugar(ByVal lugar As Lugar)
        Dim lugarConsultado As New Lugar

        lugarConsultado.PK_IdLugar = lugar.PK_IdLugar

        lugarConsultado = DALugar.consultarLugarID(lugarConsultado)

        If lugarConsultado.PK_IdLugar = -1 Then
            MsgBox("Error: EL lugar no existe en la base de datos", MsgBoxStyle.Critical, "Error al Modificar")
        Else
            DALugar.modificarLugar(lugar)
        End If
    End Sub

    Public Sub eliminarLugar(ByVal lugar As Lugar)
        DALugar.eliminarLugar(lugar)
    End Sub

    Public Sub New()
        DALugar = New DALugar()
    End Sub

End Class
