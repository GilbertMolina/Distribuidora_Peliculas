Imports Domain
Imports SQLConexion
Imports System.Data.SqlClient

Public Class DAAnuncios

    Private conn As New ConexionDB


    Public Function consultaAnuncioId(ByVal anuncio As Anuncio) As Anuncio
        Dim table As New DataTable
        Try
            'se crea el objeto de conexion a sql server
            Dim conn = New ConexionDB()


            'secrea un objeto SqlCommand para ejecutar el SQL (procedimiento almacenado)
            conn._cmd = New SqlCommand("SP_TbAnuncioSelect", conn._objConn)

            'se indica que el tipo de comando sql es un procedimiento almacenado
            conn._cmd.CommandType = CommandType.StoredProcedure
            'se incluyen los parametros SqlCommand
            conn._cmd.Parameters.Add(New SqlParameter("@PK_IdAnuncio", anuncio.Id))

            'si la conexion esta cerrada se habre, con esto se evita tener varias conexiones abiertas
            If conn._objConn.State = ConnectionState.Closed Then
                conn._objConn.Open()
            End If

            Dim adapter As New SqlDataAdapter(conn._cmd)

            'se lla el objeto dataTable con el resultado de la consulta
            adapter.Fill(table)

            'se llena el objeto anuncio
            If table.Rows.Count > 0 Then
                For Each MiDataRow As DataRow In table.Rows
                    anuncio.Id = CInt((MiDataRow("PK_IdAnuncio").ToString()))
                    anuncio.FechaEnvio = (MiDataRow("FechaEnvio").ToString)
                    Dim pelicula As New Pelicula
                    Dim peliculas As New DAPeliculas
                    anuncio.pelicula = peliculas.consultarPeliculaID(pelicula)

                Next
            Else
                anuncio.Id = -1
            End If

            conn._cmd.Dispose()
            conn._objConn.Close()




            'se retorna el anuncio
            Return anuncio

        Catch ex As Exception
            MsgBox("Error:" & ex.Message, MsgBoxStyle.Critical, "Error al consultar id anuncio")
            anuncio.Id = -1
            Return anuncio
        End Try
    End Function

    Public Sub modificarAnuncio(ByVal anuncio As Anuncio)
        Try
            Dim conn = New ConexionDB()
            conn._cmd = New SqlCommand("SP_TbAnuncioUpdate", conn._objConn)
            conn._cmd.CommandType = CommandType.StoredProcedure
            conn._cmd.Parameters.Add(New SqlParameter("PK_IdAnuncio", anuncio.Id))
            conn._cmd.Parameters.Add(New SqlParameter("FK_IdPelicula", anuncio.pelicula.PK_IdPelicula))
            conn._cmd.Parameters.Add(New SqlParameter("FechaEnvio", anuncio.FechaEnvio))

            If conn._objConn.State = ConnectionState.Closed Then
                conn._objConn.Open()
            End If
            conn._cmd.ExecuteReader()
            conn._cmd.Dispose()
            conn._objConn.Close()
        Catch ex As Exception
            MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical, "Error al modificar Anuncio")
        End Try
    End Sub

    Public Sub eliminaAnuncioId(ByVal anuncio As Anuncio)

        Try
            'se crea el objeto de conexion a sql server
            Dim conn = New ConexionDB()


            'secrea un objeto SqlCommand para ejecutar el SQL (procedimiento almacenado)
            conn._cmd = New SqlCommand("SP_TbAnuncioDelete", conn._objConn)

            'se indica que el tipo de comando sql es un procedimiento almacenado
            conn._cmd.CommandType = CommandType.StoredProcedure
            'se incluyen los parametros SqlCommand
            conn._cmd.Parameters.Add(New SqlParameter("@PK_IdAnuncio", anuncio.Id))

            'si la conexion esta cerrada se habre, con esto se evita tener varias conexiones abiertas
            If conn._objConn.State = ConnectionState.Closed Then
                conn._objConn.Open()
            End If

            conn._cmd.ExecuteReader()

            conn._cmd.Dispose()
            conn._objConn.Close()

        Catch ex As Exception
            MsgBox("Error:" & ex.Message, MsgBoxStyle.Critical, "Error al consultar id anuncio")
            anuncio.Id = -1

        End Try
    End Sub

    Public Function consultaAnuncios() As DataTable
        Dim table As New DataTable
        Try
            'se crea el objeto de conexion a sql server
            Dim conn = New ConexionDB()

            'secrea un objeto SqlCommand para ejecutar el SQL (procedimiento almacenado)
            'conn.cmd = New SqlCommand("SP_TbAnuncioSelect", conn.conexion)
            conn._cmd = New SqlCommand("select a.PK_IdAnuncio as ID,p.pk_idpelicula as cod_pelicula,a.fechaEnvio, p.titulo as titulo  from tbAnuncio a, tbpelicula p where p.pk_idpelicula=a.fk_idpelicula", conn._objConn)

            'se indica que el tipo de comando sql es un procedimiento almacenado
            conn._cmd.CommandType = CommandType.Text
            'se incluyen los parametros SqlCommand
            'conn.cmd.Parameters.Add(New SqlParameter("@PK_IdAnuncio", "null"))

            'si la conexion esta cerrada se habre, con esto se evita tener varias conexiones abiertas
            If conn._objConn.State = ConnectionState.Closed Then
                conn._objConn.Open()

            End If

            Dim adapter As New SqlDataAdapter(conn._cmd)

            'se lla el objeto dataTable con el resultado de la consulta
            adapter.Fill(table)

            'se llena el objeto anuncio

            conn._cmd.Dispose()
            conn._objConn.Close()



            'se retorna el anuncio
            Return table



        Catch ex As Exception
            MsgBox("Error:" & ex.Message & ex.StackTrace, MsgBoxStyle.Critical, "Error al consultar anuncios")

            Return table
        End Try
    End Function
    Public Sub insertarAnuncio(ByVal anuncio As Anuncio)
        Try
            Dim conn = New ConexionDB

            conn._cmd = New SqlCommand("SP_TbAnuncioInsert", conn._objConn)
            conn._cmd.CommandType = CommandType.StoredProcedure

            conn._cmd.Parameters.Add(New SqlParameter("@FK_IdPelicula", anuncio.pelicula.PK_IdPelicula))
            conn._cmd.Parameters.Add(New SqlParameter("@FechaEnvio", anuncio.FechaEnvio))


            If conn._objConn.State = ConnectionState.Closed Then
                conn._objConn.Open()

            End If

            conn._cmd.ExecuteReader()

            conn._cmd.Dispose()
            conn._objConn.Close()

        Catch ex As Exception
            MsgBox("ERROR:" & ex.Message, MsgBoxStyle.Critical, "Error al ingresar anuncio")
        End Try
    End Sub

End Class
