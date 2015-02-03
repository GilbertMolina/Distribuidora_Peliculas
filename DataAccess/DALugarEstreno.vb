Imports Domain
Imports SQLConexion
Imports System.Data.SqlClient

Public Class DALugarEstreno

    Public Sub insertarLugarEstreno(ByVal lugarEstreno As LugarEstreno)
        Try
            Dim conn = New ConexionDB()
            conn._cmd = New SqlCommand("SP_TbLugarEstrenoInsert", conn._objConn)
            conn._cmd.CommandType = CommandType.StoredProcedure
            conn._cmd.Parameters.Add(New SqlParameter("@FK_PK_IdLugar", lugarEstreno.FK_PK_IdLugar))
            conn._cmd.Parameters.Add(New SqlParameter("@FK_PK_IdPelicula", lugarEstreno.FK_PK_IdPelicula))
            If conn._objConn.State = ConnectionState.Closed Then
                conn._objConn.Open()
            End If
            conn._cmd.ExecuteReader()
            conn._cmd.Dispose()
            conn._objConn.Close()
        Catch ex As Exception
            MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical, "Error al insertar lugar estreno")
        End Try
    End Sub

    Public Function consultarLugaresEstreno() As DataTable
        Dim table As New DataTable
        Try
            Dim conn = New ConexionDB()
            conn._cmd = New SqlCommand("SP_TbLugarEstrenoSelect", conn._objConn)
            conn._cmd.CommandType = CommandType.StoredProcedure
            If conn._objConn.State = ConnectionState.Closed Then
                conn._objConn.Open()
            End If
            Dim adapter As New SqlDataAdapter(conn._cmd)
            adapter.Fill(table)
            conn._cmd.Dispose()
            conn._objConn.Close()
            Return table
        Catch ex As Exception
            MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical, "Error al consultar lugares estreno")
            Return table
        End Try
    End Function

    Public Function consultarLugarEstrenoID(ByVal lugarEstreno As LugarEstreno) As LugarEstreno
        Dim table As New DataTable
        Try
            Dim conn = New ConexionDB()
            conn._cmd = New SqlCommand("SP_TbLugarEstrenoSelectID", conn._objConn)
            conn._cmd.CommandType = CommandType.StoredProcedure
            conn._cmd.Parameters.Add(New SqlParameter("@FK_PK_IdLugar", lugarEstreno.FK_PK_IdLugar))
            conn._cmd.Parameters.Add(New SqlParameter("@FK_PK_IdPelicula", lugarEstreno.FK_PK_IdPelicula))

            If conn._objConn.State = ConnectionState.Closed Then
                conn._objConn.Open()
            End If

            Dim adapter As New SqlDataAdapter(conn._cmd)
            adapter.Fill(table)
            If table.Rows.Count > 0 Then
                For Each MiDataRow As DataRow In table.Rows
                    lugarEstreno.FK_PK_IdLugar = CInt(MiDataRow("Código lugar").ToString())
                    lugarEstreno.FK_PK_IdPelicula = CInt(MiDataRow("Código película").ToString())
                Next
            Else
                lugarEstreno.FK_PK_IdLugar = -1
            End If

            conn._cmd.Dispose()
            conn._objConn.Close()
            Return lugarEstreno
        Catch ex As Exception
            MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical, "Error al consultar el lugar estreno")
            lugarEstreno.FK_PK_IdLugar = -1
            Return lugarEstreno
        End Try
    End Function

    Public Sub modificarLugarEstreno(ByVal lugarEstrenoAnterior As LugarEstreno, ByVal lugarEstrenoNuevo As LugarEstreno)
        Try
            Dim conn = New ConexionDB()
            conn._cmd = New SqlCommand("SP_TbLugarEstrenoUpdate", conn._objConn)
            conn._cmd.CommandType = CommandType.StoredProcedure
            conn._cmd.Parameters.Add(New SqlParameter("@FK_PK_IdLugar_Anterior", lugarEstrenoAnterior.FK_PK_IdLugar))
            conn._cmd.Parameters.Add(New SqlParameter("@FK_PK_IdPelicula_Anterior", lugarEstrenoAnterior.FK_PK_IdPelicula))
            conn._cmd.Parameters.Add(New SqlParameter("@FK_PK_IdLugar_Nuevo", lugarEstrenoNuevo.FK_PK_IdLugar))
            conn._cmd.Parameters.Add(New SqlParameter("@FK_PK_IdPelicula_Nuevo", lugarEstrenoNuevo.FK_PK_IdPelicula))
            If conn._objConn.State = ConnectionState.Closed Then
                conn._objConn.Open()
            End If
            conn._cmd.ExecuteReader()
            conn._cmd.Dispose()
            conn._objConn.Close()
        Catch ex As Exception
            MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical, "Error al modificar el lugar estreno")
        End Try
    End Sub

    Public Sub eliminarLugarEstreno(ByVal lugarEstreno As LugarEstreno)
        Try
            Dim conn = New ConexionDB()
            conn._cmd = New SqlCommand("SP_TbLugarEstrenoDelete", conn._objConn)
            conn._cmd.CommandType = CommandType.StoredProcedure
            conn._cmd.Parameters.Add(New SqlParameter("@FK_PK_IdLugar", lugarEstreno.FK_PK_IdLugar))
            conn._cmd.Parameters.Add(New SqlParameter("@FK_PK_IdPelicula", lugarEstreno.FK_PK_IdPelicula))
            If conn._objConn.State = ConnectionState.Closed Then
                conn._objConn.Open()
            End If
            conn._cmd.ExecuteReader()
            conn._cmd.Dispose()
            conn._objConn.Close()
        Catch ex As Exception
            MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical, "Error al eliminar lugar estreno")
        End Try
    End Sub

End Class
