Imports Domain
Imports SQLConexion
Imports System.Data.SqlClient

Public Class DAPeliculas

    Public Sub insertarPelicula(ByVal pelicula As Pelicula)
        Try
            Dim conn = New ConexionDB()
            conn._cmd = New SqlCommand("SP_TbPeliculaInsert", conn._objConn)
            conn._cmd.CommandType = CommandType.StoredProcedure
            conn._cmd.Parameters.Add(New SqlParameter("@FK_IdDirector", pelicula.FK_IdDirector))
            conn._cmd.Parameters.Add(New SqlParameter("@Titulo", pelicula.Titulo))
            conn._cmd.Parameters.Add(New SqlParameter("@Argumento", pelicula.Argumento))
            conn._cmd.Parameters.Add(New SqlParameter("@FechaEstreno", pelicula.FechaEstreno))
            conn._cmd.Parameters.Add(New SqlParameter("@Nacionalidad", pelicula.Nacionalidad))
            If conn._objConn.State = ConnectionState.Closed Then
                conn._objConn.Open()
            End If
            conn._cmd.ExecuteReader()
            conn._cmd.Dispose()
            conn._objConn.Close()
        Catch ex As Exception
            MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical, "Error al insertar película")
        End Try
    End Sub

    Public Function consultarPeliculas() As DataTable
        Dim table As New DataTable
        Try
            Dim conn = New ConexionDB()
            conn._cmd = New SqlCommand("SP_TbPeliculaSelect", conn._objConn)
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
            MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical, "Error al consultar películas")
            Return table
        End Try
    End Function

    Public Function consultarPeliculaNombre(ByVal pelicula As Pelicula) As Pelicula
        Dim table As New DataTable
        Try
            Dim conn = New ConexionDB()

            conn._cmd = New SqlCommand("SP_TbPeliculaSelectName", conn._objConn)

            conn._cmd.CommandType = CommandType.StoredProcedure

            conn._cmd.Parameters.Add(New SqlParameter("@Titulo", pelicula.Titulo))

            If conn._objConn.State = ConnectionState.Closed Then
                conn._objConn.Open()
            End If

            Dim adapter As New SqlDataAdapter(conn._cmd)
            adapter.Fill(table)
            If table.Rows.Count > 0 Then
                For Each MiDataRow As DataRow In table.Rows
                    pelicula.FK_IdDirector = CInt(MiDataRow("FK_IdDirector").ToString())
                    pelicula.Titulo = (MiDataRow("Titulo").ToString())
                    pelicula.Argumento = (MiDataRow("Argumento").ToString())
                    pelicula.FechaEstreno = (MiDataRow("Fecha de estreno").ToString())
                    pelicula.Nacionalidad = (MiDataRow("Nacionalidad").ToString())
                Next
            Else
                pelicula.Titulo = "NULL"
            End If

            conn._cmd.Dispose()
            conn._objConn.Close()
            Return pelicula
        Catch ex As Exception
            MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical, "Error al consultar la película")
            pelicula.Titulo = "NULL"
            Return pelicula
        End Try
    End Function

    Public Function consultarPeliculaID(ByVal pelicula As Pelicula) As Pelicula
        Dim table As New DataTable
        Try
            Dim conn = New ConexionDB()

            conn._cmd = New SqlCommand("SP_TbPeliculaSelectID", conn._objConn)

            conn._cmd.CommandType = CommandType.StoredProcedure

            conn._cmd.Parameters.Add(New SqlParameter("@PK_IdPelicula", pelicula.PK_IdPelicula))

            If conn._objConn.State = ConnectionState.Closed Then
                conn._objConn.Open()
            End If

            Dim adapter As New SqlDataAdapter(conn._cmd)
            adapter.Fill(table)
            If table.Rows.Count > 0 Then
                For Each MiDataRow As DataRow In table.Rows
                    pelicula.PK_IdPelicula = CInt(MiDataRow("PK_IdPelicula").ToString())
                    If MiDataRow("FK_IdDirector").ToString() = "" Then
                        pelicula.FK_IdDirector = -1
                    Else
                        pelicula.FK_IdDirector = CInt(MiDataRow("FK_IdDirector").ToString())
                    End If
                    pelicula.Titulo = (MiDataRow("Titulo").ToString())
                    pelicula.Argumento = (MiDataRow("Argumento").ToString())
                    pelicula.FechaEstreno = (MiDataRow("Fecha de estreno").ToString())
                    pelicula.Nacionalidad = (MiDataRow("Nacionalidad").ToString())
                Next
            Else
                pelicula.PK_IdPelicula = -1
            End If

            conn._cmd.Dispose()
            conn._objConn.Close()
            Return pelicula
        Catch ex As Exception
            MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical, "Error al consultar la película")
            pelicula.PK_IdPelicula = -1
            Return pelicula
        End Try
    End Function

    Public Function busquedaPeliculaTitulo(ByVal pelicula As Pelicula) As DataTable
        Dim table As New DataTable
        Try
            Dim conn = New ConexionDB()
            conn._cmd = New SqlCommand("SP_TbPeliculaSelectName", conn._objConn)
            conn._cmd.CommandType = CommandType.StoredProcedure
            conn._cmd.Parameters.Add(New SqlParameter("@Titulo", pelicula.Titulo))
            If conn._objConn.State = ConnectionState.Closed Then
                conn._objConn.Open()
            End If
            Dim adapter As New SqlDataAdapter(conn._cmd)
            adapter.Fill(table)
            conn._cmd.Dispose()
            conn._objConn.Close()
            Return table
        Catch ex As Exception
            MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical, "Error al consultar titulo de película")
            Return table
        End Try
    End Function

    Public Sub modificarPelicula(ByVal pelicula As Pelicula)
        Try
            Dim conn = New ConexionDB()
            conn._cmd = New SqlCommand("SP_TbPeliculaUpdate", conn._objConn)
            conn._cmd.CommandType = CommandType.StoredProcedure
            conn._cmd.Parameters.Add(New SqlParameter("@PK_IdPelicula", pelicula.PK_IdPelicula))
            conn._cmd.Parameters.Add(New SqlParameter("@FK_IdDirector", pelicula.FK_IdDirector))
            conn._cmd.Parameters.Add(New SqlParameter("@Titulo", pelicula.Titulo))
            conn._cmd.Parameters.Add(New SqlParameter("@Argumento", pelicula.Argumento))
            conn._cmd.Parameters.Add(New SqlParameter("@FechaEstreno", pelicula.FechaEstreno))
            conn._cmd.Parameters.Add(New SqlParameter("@Nacionalidad", pelicula.Nacionalidad))
            If conn._objConn.State = ConnectionState.Closed Then
                conn._objConn.Open()
            End If
            conn._cmd.ExecuteReader()
            conn._cmd.Dispose()
            conn._objConn.Close()
        Catch ex As Exception
            MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical, "Error al modificar película")
        End Try
    End Sub

    Public Sub eliminarPelicula(ByVal pelicula As Pelicula)
        Try
            Dim conn = New ConexionDB()
            conn._cmd = New SqlCommand("SP_TbPeliculaDelete", conn._objConn)
            conn._cmd.CommandType = CommandType.StoredProcedure
            conn._cmd.Parameters.Add(New SqlParameter("@PK_IdPelicula", pelicula.PK_IdPelicula))
            If conn._objConn.State = ConnectionState.Closed Then
                conn._objConn.Open()
            End If
            conn._cmd.ExecuteReader()
            conn._cmd.Dispose()
            conn._objConn.Close()
        Catch ex As Exception
            MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical, "Error al eliminar película")
        End Try
    End Sub

End Class
