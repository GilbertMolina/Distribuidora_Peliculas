Imports Domain
Imports SQLConexion
Imports System.Data.SqlClient

Public Class DALugar

    Public Sub insertarLugar(ByVal lugar As Lugar)
        Try
            Dim conn = New ConexionDB()
            conn._cmd = New SqlCommand("SP_TbLugarInsert", conn._objConn)
            conn._cmd.CommandType = CommandType.StoredProcedure
            conn._cmd.Parameters.Add(New SqlParameter("@Nombre", lugar.Nombre))
            If conn._objConn.State = ConnectionState.Closed Then
                conn._objConn.Open()
            End If
            conn._cmd.ExecuteReader()
            conn._cmd.Dispose()
            conn._objConn.Close()
        Catch ex As Exception
            MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical, "Error al insertar lugar")
        End Try
    End Sub

    Public Function consultarLugares() As DataTable
        Dim table As New DataTable
        Try
            Dim conn = New ConexionDB()
            conn._cmd = New SqlCommand("SP_TbLugarSelect", conn._objConn)
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
            MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical, "Error al consultar lugares")
            Return table
        End Try
    End Function

    Public Function consultarLugarNombre(ByVal lugar As Lugar) As Lugar
        Dim table As New DataTable
        Try
            Dim conn = New ConexionDB()
            conn._cmd = New SqlCommand("SP_TbLugarSelectName", conn._objConn)
            conn._cmd.CommandType = CommandType.StoredProcedure
            conn._cmd.Parameters.Add(New SqlParameter("@Nombre", lugar.Nombre))

            If conn._objConn.State = ConnectionState.Closed Then
                conn._objConn.Open()
            End If

            Dim adapter As New SqlDataAdapter(conn._cmd)
            adapter.Fill(table)
            If table.Rows.Count > 0 Then
                For Each MiDataRow As DataRow In table.Rows
                    lugar.PK_IdLugar = CInt(MiDataRow("PK_IdLugar").ToString())
                    lugar.Nombre = (MiDataRow("Nombre").ToString())
                Next
            Else
                lugar.Nombre = "NULL"
            End If

            conn._cmd.Dispose()
            conn._objConn.Close()
            Return lugar
        Catch ex As Exception
            MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical, "Error al consultar el lugar")
            lugar.Nombre = "NULL"
            Return lugar
        End Try
    End Function

    Public Function busquedaLugarNombre(ByVal lugar As Lugar) As DataTable
        Dim table As New DataTable
        Try
            Dim conn = New ConexionDB()
            conn._cmd = New SqlCommand("SP_TbLugarSelectName", conn._objConn)
            conn._cmd.CommandType = CommandType.StoredProcedure
            conn._cmd.Parameters.Add(New SqlParameter("@Nombre", lugar.Nombre))
            If conn._objConn.State = ConnectionState.Closed Then
                conn._objConn.Open()
            End If
            Dim adapter As New SqlDataAdapter(conn._cmd)
            adapter.Fill(table)
            conn._cmd.Dispose()
            conn._objConn.Close()
            Return table
        Catch ex As Exception
            MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical, "Error al consultar nombre de lugar")
            Return table
        End Try
    End Function

    Public Function consultarLugarID(ByVal lugar As Lugar) As Lugar
        Dim table As New DataTable
        Try
            Dim conn = New ConexionDB()

            conn._cmd = New SqlCommand("SP_TbLugarSelectID", conn._objConn)

            conn._cmd.CommandType = CommandType.StoredProcedure

            conn._cmd.Parameters.Add(New SqlParameter("@PK_IdLugar", lugar.PK_IdLugar))

            If conn._objConn.State = ConnectionState.Closed Then
                conn._objConn.Open()
            End If

            Dim adapter As New SqlDataAdapter(conn._cmd)
            adapter.Fill(table)
            If table.Rows.Count > 0 Then
                For Each MiDataRow As DataRow In table.Rows
                    lugar.PK_IdLugar = CInt(MiDataRow("PK_IdLugar").ToString())
                    lugar.Nombre = (MiDataRow("Nombre").ToString())
                Next
            Else
                lugar.PK_IdLugar = -1
            End If

            conn._cmd.Dispose()
            conn._objConn.Close()
            Return lugar
        Catch ex As Exception
            MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical, "Error al consultar el lugar")
            lugar.PK_IdLugar = -1
            Return lugar
        End Try
    End Function

    Public Sub modificarLugar(ByVal lugar As Lugar)
        Try
            Dim conn = New ConexionDB()
            conn._cmd = New SqlCommand("SP_TbLugarUpdate", conn._objConn)
            conn._cmd.CommandType = CommandType.StoredProcedure
            conn._cmd.Parameters.Add(New SqlParameter("@PK_IdLugar", lugar.PK_IdLugar))
            conn._cmd.Parameters.Add(New SqlParameter("@Nombre", lugar.Nombre))
            If conn._objConn.State = ConnectionState.Closed Then
                conn._objConn.Open()
            End If
            conn._cmd.ExecuteReader()
            conn._cmd.Dispose()
            conn._objConn.Close()
        Catch ex As Exception
            MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical, "Error al modificar el lugar")
        End Try
    End Sub

    Public Sub eliminarLugar(ByVal lugar As Lugar)
        Try
            Dim conn = New ConexionDB()
            conn._cmd = New SqlCommand("SP_TbLugarDelete", conn._objConn)
            conn._cmd.CommandType = CommandType.StoredProcedure
            conn._cmd.Parameters.Add(New SqlParameter("@PK_IdLugar", lugar.PK_IdLugar))
            If conn._objConn.State = ConnectionState.Closed Then
                conn._objConn.Open()
            End If
            conn._cmd.ExecuteReader()
            conn._cmd.Dispose()
            conn._objConn.Close()
        Catch ex As Exception
            MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical, "Error al eliminar lugar")
        End Try
    End Sub

End Class
