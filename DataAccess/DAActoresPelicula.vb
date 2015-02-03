Imports Domain
Imports SQLConexion
Imports System.Data.SqlClient

Public Class DAActoresPelicula
    Private conn As ConexionDB
    Public Sub New()
        MyBase.New()
    End Sub

    Public Function SelectTodo() As DataTable
        Dim table As New DataTable
        Try
            conn = New ConexionDB()
            conn._cmd = New SqlCommand("SP_TbActorXPeliculaSelect", conn._objConn)
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
            MsgBox("ERROR:" & ex.Message, MsgBoxStyle.Critical, "Error al consultar actor por pelicula")
            Return table
        End Try
    End Function

    Public Sub InsertActorXPelicula(ByVal actorXpelicula As ActoresPelicula)
        Try
            conn = New ConexionDB()
            conn._cmd = New SqlCommand("SP_TbActorXPeliculaInsert", conn._objConn)
            conn._cmd.CommandType = CommandType.StoredProcedure
            conn._cmd.Parameters.Add(New SqlParameter("@FK_PK_IdActor", actorXpelicula.FK_PK_IdActor))
            conn._cmd.Parameters.Add(New SqlParameter("@FK_PK_IdPelicula", actorXpelicula.FK_PK_IdPelicula))
            conn._cmd.Parameters.Add(New SqlParameter("@Papel", actorXpelicula.Papel))
            conn._cmd.Parameters.Add(New SqlParameter("@Sueldo", actorXpelicula.Sueldo))

            If conn._objConn.State = ConnectionState.Closed Then
                conn._objConn.Open()
            End If

            conn._cmd.ExecuteReader()

            conn._cmd.Dispose()
            conn._objConn.Close()
        Catch ex As Exception
            MsgBox("ERROR:" & ex.Message, MsgBoxStyle.Critical, "Error al ingresar actor por pelicula")
        End Try
    End Sub

    Sub ModificarActorXPelicula(ByVal actor As ActoresPelicula)
        Try
            conn = New ConexionDB()
            conn._cmd = New SqlCommand("SP_TbActorXPeliculaUpdate", conn._objConn)
            conn._cmd.CommandType = CommandType.StoredProcedure
            conn._cmd.Parameters.Add(New SqlParameter("@FK_PK_IdActor", actor.FK_PK_IdActor))
            conn._cmd.Parameters.Add(New SqlParameter("@FK_PK_IdPelicula", actor.FK_PK_IdPelicula))
            conn._cmd.Parameters.Add(New SqlParameter("@Papel", actor.Papel))
            conn._cmd.Parameters.Add(New SqlParameter("@Sueldo", actor.Sueldo))

            If conn._objConn.State = ConnectionState.Closed Then
                conn._objConn.Open()
            End If

            conn._cmd.ExecuteReader()

            conn._cmd.Dispose()
            conn._objConn.Close()
        Catch ex As Exception
            MsgBox("ERROR:" & ex.Message, MsgBoxStyle.Critical, "Error al ingresar actor por pelicula")
        End Try
    End Sub

    Sub EliminarActorXPelicula(ByVal actor As ActoresPelicula)
        Try
            conn = New ConexionDB()
            conn._cmd = New SqlCommand("SP_TbActorXPeliculaDelete", conn._objConn)
            conn._cmd.CommandType = CommandType.StoredProcedure
            conn._cmd.Parameters.Add(New SqlParameter("@FK_PK_IdActor", actor.FK_PK_IdActor))
            conn._cmd.Parameters.Add(New SqlParameter("@FK_PK_IdPelicula", actor.FK_PK_IdPelicula))

            If conn._objConn.State = ConnectionState.Closed Then
                conn._objConn.Open()
            End If

            conn._cmd.ExecuteReader()

            conn._cmd.Dispose()
            conn._objConn.Close()
        Catch ex As Exception
            MsgBox("ERROR:" & ex.Message, MsgBoxStyle.Critical, "Error al ingresar actor por pelicula")
        End Try
    End Sub

End Class
