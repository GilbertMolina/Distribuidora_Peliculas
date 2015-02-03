Imports System.Data.SqlClient
Imports Domain
Imports SQLConexion

Public Class DAUsuarios

    Public Function consultarUsuario(ByVal usuario As Usuario) As Usuario
        Dim table As New DataTable
        Try
            Dim conn = New ConexionDB()
            conn._cmd = New SqlCommand("SP_TbUsuarioLoginSelect", conn._objConn)
            conn._cmd.CommandType = CommandType.StoredProcedure
            conn._cmd.Parameters.Add(New SqlParameter("@PK_Username", usuario.PK_Username))
            conn._cmd.Parameters.Add(New SqlParameter("@Contrasenna", usuario.Contrasenna))
            If conn._objConn.State = ConnectionState.Closed Then
                conn._objConn.Open()
            End If
            Dim adapter As New SqlDataAdapter(conn._cmd)
            adapter.Fill(table)
            If table.Rows.Count > 0 Then
                For Each MiDataRow As DataRow In table.Rows
                    usuario.PK_Username = (MiDataRow("PK_Username").ToString())
                    usuario.Contrasenna = (MiDataRow("Contrasenna").ToString())
                Next
            Else
                usuario.PK_Username = "NULL"
            End If
            conn._cmd.Dispose()
            conn._objConn.Close()
            Return usuario
        Catch ex As Exception
            MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical, "Error al consultar usuario con la base de datos")
            usuario.PK_Username = "NULL"
            Return usuario
        End Try
    End Function

End Class
