Imports Domain
Imports SQLConexion
Imports System.Data.SqlClient

Public Class DAProductoresPelicula

    Public Sub insertarProductorPelicula(ByVal productorPelicula As ProductoresPelicula)
        Try
            Dim conn = New ConexionDB()
            conn._cmd = New SqlCommand("SP_TbProductorXPeliculaInsert", conn._objConn)
            conn._cmd.CommandType = CommandType.StoredProcedure
            conn._cmd.Parameters.Add(New SqlParameter("@FK_PK_IdPelicula", productorPelicula.idPelicula))
            conn._cmd.Parameters.Add(New SqlParameter("@FK_PK_IdProductor", productorPelicula.idProductor))
            conn._cmd.Parameters.Add(New SqlParameter("@Aporte", productorPelicula.aporte))

            If conn._objConn.State = ConnectionState.Closed Then
                conn._objConn.Open()
            End If
            conn._cmd.ExecuteReader()
            conn._cmd.Dispose()
            conn._objConn.Close()
        Catch ex As Exception
            MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical, "Error al insertar productor a la película")
        End Try
    End Sub

    Public Function consultarProductorPelicula() As DataTable
        Dim table As New DataTable
        Dim productorPelicula As New ProductoresPelicula

        Try
            Dim conn = New ConexionDB()
            conn._cmd = New SqlCommand("SP_TbProductorXPeliculaSelectAll", conn._objConn)
            conn._cmd.CommandType = CommandType.StoredProcedure
            If conn._objConn.State = ConnectionState.Closed Then
                conn._objConn.Open()
            End If
            Dim adapter As New SqlDataAdapter(conn._cmd)
            adapter.Fill(table)

            If table.Rows.Count > 0 Then
                For Each MiDataRow As DataRow In table.Rows
                    productorPelicula.idPelicula = CInt((MiDataRow("Codigo Película").ToString()))
                    productorPelicula.idPelicula = CInt((MiDataRow("Código Productor").ToString()))
                    ProductorPelicula.aporte = CInt((MiDataRow("Aporte").ToString()))
                Next
            Else
                ProductorPelicula.idProductor = -1
            End If
            conn._cmd.Dispose()
            conn._objConn.Close()
            Return table
        Catch ex As Exception
            MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical, "Error al consultar productores por película")
            Return table
        End Try
    End Function

    Public Function consultarProductorPeliculaID(ByVal productorPelicula As ProductoresPelicula) As ProductoresPelicula
        Dim table As New DataTable
        Try
            Dim conn = New ConexionDB()

            conn._cmd = New SqlCommand("SP_TbProductorXPeliculaSelectId", conn._objConn)

            conn._cmd.CommandType = CommandType.StoredProcedure

            conn._cmd.Parameters.Add(New SqlParameter("@FK_PK_IdPelicula", productorPelicula.idPelicula))
            conn._cmd.Parameters.Add(New SqlParameter("@FK_PK_IdProductor", productorPelicula.idProductor))

            If conn._objConn.State = ConnectionState.Closed Then
                conn._objConn.Open()
            End If

            Dim adapter As New SqlDataAdapter(conn._cmd)
            adapter.Fill(table)
            If table.Rows.Count > 0 Then
                For Each MiDataRow As DataRow In table.Rows
                    productorPelicula.idPelicula = CInt((MiDataRow("FK_PK_IdPelicula").ToString()))
                    productorPelicula.idProductor = CInt((MiDataRow("FK_PK_IdProductor").ToString()))
                    productorPelicula.aporte = CInt((MiDataRow("Aporte").ToString()))
                Next
            Else
                productorPelicula.idProductor = -1
            End If

            conn._cmd.Dispose()
            conn._objConn.Close()
            Return productorPelicula
        Catch ex As Exception
            MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical, "Error al consultar")
            productorPelicula.idProductor = -1
            Return productorPelicula
        End Try
    End Function

    Public Sub modificarProductorPelicula(ByVal productorPelicula As ProductoresPelicula)
        Try
            Dim conn = New ConexionDB()
            conn._cmd = New SqlCommand("SP_TbProductorXPeliculaUpdate", conn._objConn)
            conn._cmd.CommandType = CommandType.StoredProcedure
            conn._cmd.Parameters.Add(New SqlParameter("@FK_PK_IdPelicula", productorPelicula.idPelicula))
            conn._cmd.Parameters.Add(New SqlParameter("@FK_PK_IdProductor", productorPelicula.idProductor))
            conn._cmd.Parameters.Add(New SqlParameter("@Aporte", productorPelicula.aporte))

            If conn._objConn.State = ConnectionState.Closed Then
                conn._objConn.Open()
            End If
            conn._cmd.ExecuteReader()
            conn._cmd.Dispose()
            conn._objConn.Close()
        Catch ex As Exception
            MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical, "Error al modificar")
        End Try
    End Sub

    Public Sub eliminarProductorPelicula(ByVal productorPelicula As ProductoresPelicula)
        Try
            Dim conn = New ConexionDB()
            conn._cmd = New SqlCommand("SP_TbProductorXPeliculaDelete", conn._objConn)
            conn._cmd.CommandType = CommandType.StoredProcedure
            conn._cmd.Parameters.Add(New SqlParameter("@FK_PK_IdPelicula", productorPelicula.idPelicula))
            conn._cmd.Parameters.Add(New SqlParameter("@FK_PK_IdProductor", productorPelicula.idProductor))
            If conn._objConn.State = ConnectionState.Closed Then
                conn._objConn.Open()
            End If
            conn._cmd.ExecuteReader()
            conn._cmd.Dispose()
            conn._objConn.Close()
        Catch ex As Exception
            MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical, "Error al eliminar")
        End Try
    End Sub

End Class
