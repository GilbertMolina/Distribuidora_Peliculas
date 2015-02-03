Imports DataAccess
Imports Domain

Public Class BLLugarEstreno

    Private DALugarEstreno As DALugarEstreno

    Public Sub insertarLugarEstreno(ByVal lugarEstreno As LugarEstreno)
        Dim lugarEstrenoConsultado As New LugarEstreno

        lugarEstrenoConsultado.FK_PK_IdLugar = lugarEstreno.FK_PK_IdLugar
        lugarEstrenoConsultado.FK_PK_IdPelicula = lugarEstreno.FK_PK_IdPelicula

        lugarEstrenoConsultado = DALugarEstreno.consultarLugarEstrenoID(lugarEstrenoConsultado)

        If lugarEstrenoConsultado.FK_PK_IdLugar = -1 Then
            DALugarEstreno.insertarLugarEstreno(lugarEstreno)
        Else
            MsgBox("Error: El lugar de estreno ya existe en la base de datos", MsgBoxStyle.Critical, "Error al Insertar")
        End If
    End Sub

    Public Function consultarLugaresEstreno() As DataTable
        Return DALugarEstreno.consultarLugaresEstreno()
    End Function

    Public Function consultarLugarEstrenoID(ByVal lugarEstreno As LugarEstreno) As LugarEstreno
        Return DALugarEstreno.consultarLugarEstrenoID(lugarEstreno)
    End Function

    Public Sub modificarLugarEstreno(ByVal lugarEstrenoAnterior As LugarEstreno, ByVal lugarEstrenoNuevo As LugarEstreno)
        Dim lugarEstrenoConsultado As New LugarEstreno

        lugarEstrenoConsultado.FK_PK_IdLugar = lugarEstrenoAnterior.FK_PK_IdLugar
        lugarEstrenoConsultado.FK_PK_IdPelicula = lugarEstrenoAnterior.FK_PK_IdPelicula

        lugarEstrenoConsultado = DALugarEstreno.consultarLugarEstrenoID(lugarEstrenoConsultado)

        If lugarEstrenoConsultado.FK_PK_IdLugar = -1 Then
            MsgBox("Error: EL lugar de estreno no existe en la base de datos", MsgBoxStyle.Critical, "Error al Modificar")
        Else
            DALugarEstreno.modificarLugarEstreno(lugarEstrenoAnterior, lugarEstrenoNuevo)
        End If
    End Sub

    Public Sub eliminarLugarEstreno(ByVal lugarEstreno As LugarEstreno)
        DALugarEstreno.eliminarLugarEstreno(lugarEstreno)
    End Sub

    Public Sub New()
        DALugarEstreno = New DALugarEstreno()
    End Sub

End Class
