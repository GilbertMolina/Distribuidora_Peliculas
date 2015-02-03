Imports Domain
Imports SQLConexion
Imports System.Data.SqlClient

Public Class DADirectores

    Public Sub insertarDirector(ByVal director As Director)
        Try
            Dim conn = New ConexionDB()
            conn._cmd = New SqlCommand("SP_TbDirectorInsert", conn._objConn)
            conn._cmd.CommandType = CommandType.StoredProcedure
            conn._cmd.Parameters.Add(New SqlParameter("@Nombre", director.Nombre))
            conn._cmd.Parameters.Add(New SqlParameter("@Apellido1", director.Apellido1))
            conn._cmd.Parameters.Add(New SqlParameter("@Apellido2", director.Apellido2))
            If conn._objConn.State = ConnectionState.Closed Then
                conn._objConn.Open()
            End If
            conn._cmd.ExecuteReader()
            conn._cmd.Dispose()
            conn._objConn.Close()
        Catch ex As Exception
            MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical, "Error al insertar director")
        End Try
    End Sub

    Public Function consultarDirectores() As DataTable
        Dim table As New DataTable
        Try
            Dim conn = New ConexionDB()
            conn._cmd = New SqlCommand("SP_TbDirectorSelect", conn._objConn)
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
            MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical, "Error al consultar directores")
            Return table
        End Try
    End Function

    Public Function consultarDirectorNombre(ByVal director As Director) As Director
        Dim table As New DataTable
        Try
            Dim conn = New ConexionDB()

            conn._cmd = New SqlCommand("SP_TbDirectorSelectName", conn._objConn)

            conn._cmd.CommandType = CommandType.StoredProcedure

            conn._cmd.Parameters.Add(New SqlParameter("@Nombre", director.Nombre))
            conn._cmd.Parameters.Add(New SqlParameter("@Apellido1", director.Apellido1))
            conn._cmd.Parameters.Add(New SqlParameter("@Apellido2", director.Apellido2))

            If conn._objConn.State = ConnectionState.Closed Then
                conn._objConn.Open()
            End If

            Dim adapter As New SqlDataAdapter(conn._cmd)
            adapter.Fill(table)
            If table.Rows.Count > 0 Then
                For Each MiDataRow As DataRow In table.Rows
                    director.Nombre = (MiDataRow("Nombre").ToString())
                    director.Apellido1 = (MiDataRow("Primer apellido").ToString())
                    director.Apellido2 = (MiDataRow("Segundo apellido").ToString())
                Next
            Else
                director.Nombre = "NULL"
            End If

            conn._cmd.Dispose()
            conn._objConn.Close()
            Return director
        Catch ex As Exception
            MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical, "Error al consultar el director")
            director.Nombre = "NULL"
            Return director
        End Try
    End Function

    Public Function consultarDirectorID(ByVal director As Director) As Director
        Dim table As New DataTable
        Try
            Dim conn = New ConexionDB()

            conn._cmd = New SqlCommand("SP_TbDirectorSelectID", conn._objConn)

            conn._cmd.CommandType = CommandType.StoredProcedure

            conn._cmd.Parameters.Add(New SqlParameter("@PK_IdDirector", director.PK_IdDirector))

            If conn._objConn.State = ConnectionState.Closed Then
                conn._objConn.Open()
            End If

            Dim adapter As New SqlDataAdapter(conn._cmd)
            adapter.Fill(table)
            If table.Rows.Count > 0 Then
                For Each MiDataRow As DataRow In table.Rows
                    director.PK_IdDirector = CInt((MiDataRow("PK_IdDirector").ToString()))
                    director.Nombre = (MiDataRow("Nombre").ToString())
                    director.Apellido1 = (MiDataRow("Apellido1").ToString())
                    director.Apellido2 = (MiDataRow("Apellido2").ToString())
                Next
            Else
                director.PK_IdDirector = -1
            End If

            conn._cmd.Dispose()
            conn._objConn.Close()
            Return director
        Catch ex As Exception
            MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical, "Error al consultar el director")
            director.PK_IdDirector = -1
            Return director
        End Try
    End Function

    Public Function busquedaDirectorNombre(ByVal director As Director) As DataTable
        Dim table As New DataTable
        Try
            Dim conn = New ConexionDB()
            conn._cmd = New SqlCommand("SP_TbDirectorSelectName", conn._objConn)
            conn._cmd.CommandType = CommandType.StoredProcedure
            conn._cmd.Parameters.Add(New SqlParameter("@Nombre", director.Nombre))
            conn._cmd.Parameters.Add(New SqlParameter("@Apellido1", director.Apellido1))
            conn._cmd.Parameters.Add(New SqlParameter("@Apellido2", director.Apellido2))
            If conn._objConn.State = ConnectionState.Closed Then
                conn._objConn.Open()
            End If
            Dim adapter As New SqlDataAdapter(conn._cmd)
            adapter.Fill(table)
            conn._cmd.Dispose()
            conn._objConn.Close()
            Return table
        Catch ex As Exception
            MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical, "Error al consultar nombre de director")
            Return table
        End Try
    End Function

    Public Sub modificarDirector(ByVal director As Director)
        Try
            Dim conn = New ConexionDB()
            conn._cmd = New SqlCommand("SP_TbDirectorUpdate", conn._objConn)
            conn._cmd.CommandType = CommandType.StoredProcedure
            conn._cmd.Parameters.Add(New SqlParameter("PK_IdDirector", director.PK_IdDirector))
            conn._cmd.Parameters.Add(New SqlParameter("@Nombre", director.Nombre))
            conn._cmd.Parameters.Add(New SqlParameter("@Apellido1", director.Apellido1))
            conn._cmd.Parameters.Add(New SqlParameter("@Apellido2", director.Apellido2))
            If conn._objConn.State = ConnectionState.Closed Then
                conn._objConn.Open()
            End If
            conn._cmd.ExecuteReader()
            conn._cmd.Dispose()
            conn._objConn.Close()
        Catch ex As Exception
            MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical, "Error al modificar director")
        End Try
    End Sub

    Public Sub eliminarDirector(ByVal director As Director)
        Try
            Dim conn = New ConexionDB()
            conn._cmd = New SqlCommand("SP_TbDirectorDelete", conn._objConn)
            conn._cmd.CommandType = CommandType.StoredProcedure
            conn._cmd.Parameters.Add(New SqlParameter("@PK_IdDirector", director.PK_IdDirector))
            If conn._objConn.State = ConnectionState.Closed Then
                conn._objConn.Open()
            End If
            conn._cmd.ExecuteReader()
            conn._cmd.Dispose()
            conn._objConn.Close()
        Catch ex As Exception
            MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical, "Error al eliminar director")
        End Try
    End Sub

End Class
