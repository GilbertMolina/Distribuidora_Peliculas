Imports Domain
Imports SQLConexion
Imports System.Data.SqlClient

Public Class DAPremios

    Public Sub insertarPremio(ByVal premio As Premio)
        Try
            Dim conn = New ConexionDB()
            conn._cmd = New SqlCommand("SP_TbPremioInsert", conn._objConn)
            conn._cmd.CommandType = CommandType.StoredProcedure
            conn._cmd.Parameters.Add(New SqlParameter("@FK_IdPelicula", premio.idPelicula))
            conn._cmd.Parameters.Add(New SqlParameter("@Nombre", premio.nombre))
            conn._cmd.Parameters.Add(New SqlParameter("@Ciudad", premio.ciudad))

            If conn._objConn.State = ConnectionState.Closed Then
                conn._objConn.Open()
            End If
            conn._cmd.ExecuteReader()
            conn._cmd.Dispose()
            conn._objConn.Close()
        Catch ex As Exception
            MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical, "Error al insertar premio")
        End Try
    End Sub

    Public Function consultarPremios() As DataTable
        Dim table As New DataTable
        Try
            Dim conn = New ConexionDB()
            conn._cmd = New SqlCommand("SP_TbPremioConsultarTodos", conn._objConn)
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
            MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical, "Error al consultar premios")
            Return table
        End Try
    End Function

    Public Function consultarPremioNombre(ByVal premio As Premio) As Premio
        Dim table As New DataTable
        Try
            Dim conn = New ConexionDB()

            conn._cmd = New SqlCommand("SP_TbPremioSelect", conn._objConn)

            conn._cmd.CommandType = CommandType.StoredProcedure

            conn._cmd.Parameters.Add(New SqlParameter("@PK_IdPremio", premio.idPremio))

            If conn._objConn.State = ConnectionState.Closed Then
                conn._objConn.Open()
            End If

            Dim adapter As New SqlDataAdapter(conn._cmd)
            adapter.Fill(table)
            If table.Rows.Count > 0 Then
                For Each MiDataRow As DataRow In table.Rows
                    premio.idPremio = CInt(MiDataRow("PK_IdPremio").ToString())
                    premio.idPelicula = CInt(MiDataRow("FK_IdPelicula").ToString())
                    premio.nombre = (MiDataRow("Nombre").ToString())
                    premio.ciudad = (MiDataRow("Ciudad").ToString())

                Next
            Else
                premio.nombre = "NULL"
            End If

            conn._cmd.Dispose()
            conn._objConn.Close()
            Return premio
        Catch ex As Exception
            MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical, "Error al consultar el premio")
            premio.nombre = "NULL"
            Return premio
        End Try
    End Function

    Public Function consultarPremioID(ByVal premio As Premio) As Premio
        Dim table As New DataTable
        Try
            Dim conn = New ConexionDB()

            conn._cmd = New SqlCommand("SP_TbPremioSelectID", conn._objConn)

            conn._cmd.CommandType = CommandType.StoredProcedure

            conn._cmd.Parameters.Add(New SqlParameter("@PK_IdPremio", premio.idPremio))

            If conn._objConn.State = ConnectionState.Closed Then
                conn._objConn.Open()
            End If

            Dim adapter As New SqlDataAdapter(conn._cmd)
            adapter.Fill(table)
            If table.Rows.Count > 0 Then
                For Each MiDataRow As DataRow In table.Rows
                    premio.idPremio = CInt(MiDataRow("PK_IdPremio").ToString())
                    premio.idPelicula = CInt(MiDataRow("FK_IdPelicula").ToString())
                    premio.nombre = (MiDataRow("Nombre").ToString())
                    premio.ciudad = (MiDataRow("Ciudad").ToString())

                Next
            Else
                premio.idPremio = -1
            End If

            conn._cmd.Dispose()
            conn._objConn.Close()
            Return premio
        Catch ex As Exception
            MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical, "Error al consultar el premio")
            premio.idPremio = -1
            Return premio
        End Try
    End Function

    Public Function consultarPremiosPelicula(ByVal idPelicula As Integer) As DataTable
        Dim table As New DataTable
        Try
            Dim conn = New ConexionDB()
            conn._cmd = New SqlCommand("SP_TbPremioPelicula", conn._objConn)
            conn._cmd.CommandType = CommandType.StoredProcedure
            conn._cmd.Parameters.Add(New SqlParameter("@FK_IdPelicula", idPelicula))
            If conn._objConn.State = ConnectionState.Closed Then
                conn._objConn.Open()
            End If
            Dim adapter As New SqlDataAdapter(conn._cmd)
            adapter.Fill(table)
            conn._cmd.Dispose()
            conn._objConn.Close()
            Return table
        Catch ex As Exception
            MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical, "Error al consultar premios")
            Return table
        End Try
    End Function

    Public Sub modificarPremio(ByVal premio As Premio)
        Try
            Dim conn = New ConexionDB()
            conn._cmd = New SqlCommand("SP_TbPremioUpdate", conn._objConn)
            conn._cmd.CommandType = CommandType.StoredProcedure

            conn._cmd.Parameters.Add(New SqlParameter("@PK_IdPremio", premio.idPremio))
            conn._cmd.Parameters.Add(New SqlParameter("@FK_IdPelicula", premio.idPelicula))
            conn._cmd.Parameters.Add(New SqlParameter("@Nombre", premio.nombre))
            conn._cmd.Parameters.Add(New SqlParameter("@Ciudad", premio.ciudad))

            If conn._objConn.State = ConnectionState.Closed Then
                conn._objConn.Open()
            End If
            conn._cmd.ExecuteReader()
            conn._cmd.Dispose()
            conn._objConn.Close()
        Catch ex As Exception
            MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical, "Error al modificar el premio")
        End Try
    End Sub

    Public Sub eliminarPremio(ByVal premio As Premio)
        Try
            Dim conn = New ConexionDB()
            conn._cmd = New SqlCommand("SP_TbPremioDelete", conn._objConn)
            conn._cmd.CommandType = CommandType.StoredProcedure
            conn._cmd.Parameters.Add(New SqlParameter("@PK_IdPremio", premio.idPremio))
            conn._cmd.Parameters.Add(New SqlParameter("@FK_IdPelicula", premio.idPelicula))
            If conn._objConn.State = ConnectionState.Closed Then
                conn._objConn.Open()
            End If
            conn._cmd.ExecuteReader()
            conn._cmd.Dispose()
            conn._objConn.Close()
        Catch ex As Exception
            MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical, "Error al eliminar premio")
        End Try
    End Sub

End Class
