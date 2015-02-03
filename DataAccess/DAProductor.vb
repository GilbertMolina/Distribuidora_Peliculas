Imports Domain
Imports SQLConexion
Imports System.Data.SqlClient

Public Class DAProductor
    Public Sub insertarProductor(ByVal productor As Productor)
        Try
            Dim conn = New ConexionDB()
            conn._cmd = New SqlCommand("SP_TbProductorInsert", conn._objConn)
            conn._cmd.CommandType = CommandType.StoredProcedure            
            conn._cmd.Parameters.Add(New SqlParameter("@Nombre", productor.nombre))
            conn._cmd.Parameters.Add(New SqlParameter("@Apellido1", productor.apellido1))
            conn._cmd.Parameters.Add(New SqlParameter("@Apellido2", productor.apellido2))

            If conn._objConn.State = ConnectionState.Closed Then
                conn._objConn.Open()
            End If
            conn._cmd.ExecuteReader()
            conn._cmd.Dispose()
            conn._objConn.Close()
        Catch ex As Exception
            MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical, "Error al insertar productor")
        End Try
    End Sub

    Public Function consultarProductor() As DataTable
        Dim table As New DataTable
        Try
            Dim conn = New ConexionDB()
            conn._cmd = New SqlCommand("SP_TbProductorSelectAll", conn._objConn)
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
            MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical, "Error al consultar productores")
            Return table
        End Try
    End Function

    Public Function buscarProductor(ByVal productor As Productor) As DataTable
        Dim table As New DataTable
        Try
            Dim conn = New ConexionDB()
            conn._cmd = New SqlCommand("SP_TbProductorSelectName", conn._objConn)
            conn._cmd.CommandType = CommandType.StoredProcedure
            conn._cmd.Parameters.Add(New SqlParameter("@Nombre", productor.nombre))
            conn._cmd.Parameters.Add(New SqlParameter("@Apellido1", productor.apellido1))
            conn._cmd.Parameters.Add(New SqlParameter("@Apellido2", productor.apellido2))
            If conn._objConn.State = ConnectionState.Closed Then
                conn._objConn.Open()
            End If
            Dim adapter As New SqlDataAdapter(conn._cmd)
            adapter.Fill(table)
            conn._cmd.Dispose()
            conn._objConn.Close()
            Return table
        Catch ex As Exception
            MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical, "Error al consultar")
            Return table
        End Try
    End Function

    Public Function consultarProductorID(ByVal productor As Productor) As Productor
        Dim table As New DataTable
        Try
            Dim conn = New ConexionDB()

            conn._cmd = New SqlCommand("SP_TbProductorSelectID", conn._objConn)

            conn._cmd.CommandType = CommandType.StoredProcedure

            conn._cmd.Parameters.Add(New SqlParameter("@PK_IdProductor", productor.idProductor))

            If conn._objConn.State = ConnectionState.Closed Then
                conn._objConn.Open()
            End If

            Dim adapter As New SqlDataAdapter(conn._cmd)
            adapter.Fill(table)
            If table.Rows.Count > 0 Then
                For Each MiDataRow As DataRow In table.Rows
                    productor.idProductor = CInt(MiDataRow("PK_IdProductor").ToString())
                    productor.nombre = CInt(MiDataRow("Nombre").ToString())
                    productor.apellido1 = (MiDataRow("Apellido1").ToString())
                    productor.apellido2 = (MiDataRow("Apellido2").ToString())

                Next
            Else
                productor.idProductor = -1
            End If

            conn._cmd.Dispose()
            conn._objConn.Close()
            Return productor
        Catch ex As Exception
            MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical, "Error al consultar el productor")
            productor.idProductor = -1
            Return productor
        End Try
    End Function

    
    Public Sub modificarProductor(ByVal productor As Productor)
        Try
            Dim conn = New ConexionDB()
            conn._cmd = New SqlCommand("SP_TbProductorUpdate", conn._objConn)
            conn._cmd.CommandType = CommandType.StoredProcedure

            conn._cmd.Parameters.Add(New SqlParameter("@PK_IdProductor", productor.idProductor))
            conn._cmd.Parameters.Add(New SqlParameter("@Nombre", productor.nombre))
            conn._cmd.Parameters.Add(New SqlParameter("@Apellido1", productor.apellido1))
            conn._cmd.Parameters.Add(New SqlParameter("@Apellido2", productor.apellido2))

            If conn._objConn.State = ConnectionState.Closed Then
                conn._objConn.Open()
            End If
            conn._cmd.ExecuteReader()
            conn._cmd.Dispose()
            conn._objConn.Close()
        Catch ex As Exception
            MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical, "Error al modificar el productor")
        End Try
    End Sub

    Public Sub eliminarProductor(ByVal productor As Productor)
        Try
            Dim conn = New ConexionDB()
            conn._cmd = New SqlCommand("SP_TbProductorDelete", conn._objConn)
            conn._cmd.CommandType = CommandType.StoredProcedure
            conn._cmd.Parameters.Add(New SqlParameter("@PK_IdProductor", productor.idProductor))
            If conn._objConn.State = ConnectionState.Closed Then
                conn._objConn.Open()
            End If
            conn._cmd.ExecuteReader()
            conn._cmd.Dispose()
            conn._objConn.Close()
        Catch ex As Exception
            MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical, "Error al eliminar productor")
        End Try
    End Sub

End Class
