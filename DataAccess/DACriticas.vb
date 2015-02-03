Imports Domain
Imports SQLConexion
Imports System.Data.SqlClient

Public Class DACriticas

    Private conn As New ConexionDB

    Public Function consultaCriticaId(ByVal critica As Critica) As Critica
        Dim table As New DataTable
        Try
            Dim conn = New ConexionDB()


            conn._cmd = New SqlCommand("SP_TbCriticasSelect", conn._objConn)

            conn._cmd.CommandType = CommandType.StoredProcedure
            conn._cmd.Parameters.Add(New SqlParameter("@PK_IdCritica", critica.id))

            If conn._objConn.State = ConnectionState.Closed Then
                conn._objConn.Open()
            End If

            Dim adapter As New SqlDataAdapter(conn._cmd)

            adapter.Fill(table)

            If table.Rows.Count > 0 Then
                For Each MiDataRow As DataRow In table.Rows
                    critica.id = CInt((MiDataRow("PK_IdCritica").ToString()))
                    critica.fecha = (MiDataRow("FechaCritica").ToString)
                    Dim pelicula As New Pelicula
                    Dim peliculas As New DAPeliculas
                    critica.pelicula = peliculas.consultarPeliculaID(pelicula)

                Next
            Else
                critica.id = -1
            End If

            conn._cmd.Dispose()
            conn._objConn.Close()

            Return critica

        Catch ex As Exception
            MsgBox("Error:" & ex.Message, MsgBoxStyle.Critical, "Error al consultar id Critica")
            critica.id = -1
            Return critica
        End Try
    End Function

    Public Function consultaCriticas() As DataTable
        Dim table As New DataTable
        Try
            Dim conn = New ConexionDB()

            conn._cmd = New SqlCommand("select c.fechaCritica,c.PK_IdCritica as ID,p.pk_idpelicula as cod_pelicula,p.titulo as titulo, c.Autor, c.NombreMedio as Medio from tbCriticas c, tbpelicula p where p.pk_idpelicula=c.fk_idpelicula", conn._objConn)

            conn._cmd.CommandType = CommandType.Text

            If conn._objConn.State = ConnectionState.Closed Then
                conn._objConn.Open()

            End If

            Dim adapter As New SqlDataAdapter(conn._cmd)

            adapter.Fill(table)


            conn._cmd.Dispose()
            conn._objConn.Close()

            Return table

        Catch ex As Exception
            MsgBox("Error:" & ex.Message & ex.StackTrace, MsgBoxStyle.Critical, "Error al consultar Criticas")

            Return table
        End Try
    End Function

    Public Sub modificarCritica(ByVal critica As Critica)
        Try
            Dim conn = New ConexionDB

            conn._cmd = New SqlCommand("SP_TbCriticasUpdate", conn._objConn)
            conn._cmd.CommandType = CommandType.StoredProcedure

            conn._cmd.Parameters.Add(New SqlParameter("@PK_IdCritica", critica.id))
            conn._cmd.Parameters.Add(New SqlParameter("@FK_IdPelicula", critica.pelicula.PK_IdPelicula))
            conn._cmd.Parameters.Add(New SqlParameter("@Autor", critica.autor))
            conn._cmd.Parameters.Add(New SqlParameter("@NombreMedio", critica.nombreMedio))
            conn._cmd.Parameters.Add(New SqlParameter("@FechaCritica", critica.fecha))


            If conn._objConn.State = ConnectionState.Closed Then
                conn._objConn.Open()

            End If

            conn._cmd.ExecuteReader()

            conn._cmd.Dispose()
            conn._objConn.Close()

        Catch ex As Exception
            MsgBox("ERROR:" & ex.Message, MsgBoxStyle.Critical, "Error al ingresar critica")
        End Try
    End Sub

    Public Sub insertarCritica(ByVal critica As Critica)
        Try
            Dim conn = New ConexionDB

            conn._cmd = New SqlCommand("SP_TbCriticasInsert", conn._objConn)
            conn._cmd.CommandType = CommandType.StoredProcedure

            conn._cmd.Parameters.Add(New SqlParameter("@FK_IdPelicula", critica.pelicula.PK_IdPelicula))
            conn._cmd.Parameters.Add(New SqlParameter("@Autor", critica.autor))
            conn._cmd.Parameters.Add(New SqlParameter("@NombreMedio", critica.nombreMedio))
            conn._cmd.Parameters.Add(New SqlParameter("@FechaCritica", critica.fecha))


            If conn._objConn.State = ConnectionState.Closed Then
                conn._objConn.Open()

            End If

            conn._cmd.ExecuteReader()

            conn._cmd.Dispose()
            conn._objConn.Close()

        Catch ex As Exception
            MsgBox("ERROR:" & ex.Message, MsgBoxStyle.Critical, "Error al ingresar critica")
        End Try
    End Sub

    Public Sub eliminaCriticaId(ByVal critica As Critica)

        Try
            Dim conn = New ConexionDB()

            conn._cmd = New SqlCommand("SP_TbCriticasDelete", conn._objConn)
            conn._cmd.CommandType = CommandType.StoredProcedure
            conn._cmd.Parameters.Add(New SqlParameter("@PK_IdCritica", critica.id))

            If conn._objConn.State = ConnectionState.Closed Then
                conn._objConn.Open()
            End If

            conn._cmd.ExecuteReader()

            conn._cmd.Dispose()
            conn._objConn.Close()

        Catch ex As Exception
            MsgBox("Error:" & ex.Message, MsgBoxStyle.Critical, "Error al eliminar critica")

        End Try
    End Sub

End Class
