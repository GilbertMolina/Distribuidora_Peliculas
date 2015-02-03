Imports Domain
Imports SQLConexion
Imports System.Data.SqlClient

Public Class DAActores

    Private conn As ConexionDB

    ''' <summary>
    ''' Constructor de la Clase
    ''' </summary>
    ''' <remarks></remarks>

    Public Sub InsertarActor(ByVal actor As Actor)
        Try
            conn = New ConexionDB()
            conn._cmd = New SqlCommand("SP_TbActorInsert", conn._objConn)
            'Dim bitVacio As Byte()
            conn._cmd.CommandType = CommandType.StoredProcedure
            conn._cmd.Parameters.Add(New SqlParameter("@Nombre", actor.Nombre))
            conn._cmd.Parameters.Add(New SqlParameter("@Apellido1", actor.Apellido1))
            conn._cmd.Parameters.Add(New SqlParameter("@Apellido2", actor.Apellido2))
            conn._cmd.Parameters.Add(New SqlParameter("@Direccion", actor.Direccion))
            conn._cmd.Parameters.Add(New SqlParameter("@NumeroTelefono", actor.NumeroTelefono))
            conn._cmd.Parameters.Add(New SqlParameter("@FechaNacimiento", actor.FechaNacimiento))
            conn._cmd.Parameters.Add(New SqlParameter("@EstadoCivil", actor.EstadoCivil))
            If Not actor.Foto Is Nothing Then
                conn._cmd.Parameters.Add(New SqlParameter("@Foto", actor.Foto))
            Else
                Dim photoParam As New SqlParameter("@Foto", SqlDbType.Image)
                photoParam.Value = DBNull.Value
                conn._cmd.Parameters.Add(photoParam)
                'conn._cmd.Parameters.Add(New SqlParameter("@Foto", bitVacio))
            End If


            If conn._objConn.State = ConnectionState.Closed Then
                conn._objConn.Open()
            End If

            conn._cmd.ExecuteReader()

            conn._cmd.Dispose()
            conn._objConn.Close()
        Catch ex As Exception
            MsgBox("ERROR:" & ex.Message, MsgBoxStyle.Critical, "Error al ingresar actor")
        End Try

    End Sub

    Public Function ConsultarActoresAll() As List(Of Actor)
        Dim lActores As New List(Of Actor)
        Dim table As New DataTable
        Dim actor As Actor

        Try
            conn = New ConexionDB()
            conn._cmd = New SqlCommand("SP_TbActorSelect", conn._objConn)

            conn._cmd.CommandType = CommandType.StoredProcedure
            conn._cmd.Parameters.Add(New SqlParameter("@PK_IdActor", DBNull.Value))

            If conn._objConn.State = ConnectionState.Closed Then
                conn._objConn.Open()
            End If

            Dim adapter As New SqlDataAdapter(conn._cmd)

            adapter.Fill(table)

            conn.CerrarConeccion()

            If table.Rows.Count > 0 Then
                For Each row As DataRow In table.Rows
                    actor = New Actor
                    actor.IdActor = row("PK_IdActor")
                    actor.Nombre = row("Nombre")
                    actor.Apellido1 = row("Apellido1")
                    actor.Apellido2 = row("Apellido2")
                    actor.NumeroTelefono = row("NumeroTelefono")
                    actor.FechaNacimiento = row("FechaNacimiento")
                    actor.Direccion = row("Direccion")
                    actor.EstadoCivil = row("EstadoCivil")
                    If Not IsDBNull(row("Foto")) Then
                        actor.Foto = row("Foto")
                    End If
                    lActores.Add(actor)
                Next
            End If

            Return lActores
        Catch ex As Exception
            lActores.Clear()
            Return lActores
        End Try

    End Function

    Public Function ConsultaActoresID(ByVal idActor As String) As Actor
        Dim table As New DataTable
        Dim actor As New Actor
        Try
            conn = New ConexionDB()
            conn._cmd = New SqlCommand("SP_TbActorSelect", conn._objConn)

            conn._cmd.CommandType = CommandType.StoredProcedure
            conn._cmd.Parameters.Add(New SqlParameter("@PK_IdActor", idActor))

            If conn._objConn.State = ConnectionState.Closed Then
                conn._objConn.Open()
            End If

            Dim adapter As New SqlDataAdapter(conn._cmd)

            adapter.Fill(table)

            conn.CerrarConeccion()

            If table.Rows.Count > 0 Then
                For Each row As DataRow In table.Rows
                    actor.IdActor = row("PK_IdActor")
                    actor.Nombre = row("Nombre")
                    actor.Apellido1 = row("Apellido1")
                    actor.Apellido2 = row("Apellido2")
                    actor.NumeroTelefono = row("NumeroTelefono")
                    actor.FechaNacimiento = row("FechaNacimiento")
                    actor.Direccion = row("Direccion")
                    actor.EstadoCivil = row("EstadoCivil")
                Next
            End If

            Return actor
        Catch ex As Exception
            actor.IdActor = -1
            Return actor
        End Try
    End Function

    Sub ModificarActor(ByVal actor As Actor)
        Try
            conn = New ConexionDB()
            conn._cmd = New SqlCommand("SP_TbActorUpdate", conn._objConn)

            conn._cmd.CommandType = CommandType.StoredProcedure
            conn._cmd.Parameters.Add(New SqlParameter("@PK_IdActor", actor.IdActor))
            conn._cmd.Parameters.Add(New SqlParameter("@Nombre", actor.Nombre))
            conn._cmd.Parameters.Add(New SqlParameter("@Apellido1", actor.Apellido1))
            conn._cmd.Parameters.Add(New SqlParameter("@Apellido2", actor.Apellido2))
            conn._cmd.Parameters.Add(New SqlParameter("@Direccion", actor.Direccion))
            conn._cmd.Parameters.Add(New SqlParameter("@NumeroTelefono", actor.NumeroTelefono))
            conn._cmd.Parameters.Add(New SqlParameter("@FechaNacimiento", actor.FechaNacimiento))
            conn._cmd.Parameters.Add(New SqlParameter("@EstadoCivil", actor.EstadoCivil))
            If Not actor.Foto Is Nothing Then
                conn._cmd.Parameters.Add(New SqlParameter("@Foto", actor.Foto))
            Else
                Dim photoParam As New SqlParameter("@Foto", SqlDbType.Image)
                photoParam.Value = DBNull.Value
                conn._cmd.Parameters.Add(photoParam)
            End If

            If conn._objConn.State = ConnectionState.Closed Then
                conn._objConn.Open()
            End If

            conn._cmd.ExecuteReader()

            conn._cmd.Dispose()
            conn._objConn.Close()
        Catch ex As Exception
            MsgBox("ERROR:" & ex.Message, MsgBoxStyle.Critical, "Error al modificar actor")
        End Try
    End Sub

    Sub EliminarActor(ByVal actor As Actor)
        Try
            conn = New ConexionDB()
            conn._cmd = New SqlCommand("SP_TbActorDelete", conn._objConn)

            conn._cmd.CommandType = CommandType.StoredProcedure
            conn._cmd.Parameters.Add(New SqlParameter("@PK_IdActor", actor.IdActor))

            If conn._objConn.State = ConnectionState.Closed Then
                conn._objConn.Open()
            End If

            conn._cmd.ExecuteReader()

            conn._cmd.Dispose()
            conn._objConn.Close()
        Catch ex As Exception
            MsgBox("ERROR:" & ex.Message, MsgBoxStyle.Critical, "Error al eliminar actor")
        End Try
    End Sub

    Public Function BuscarPorNombre(ByVal actor As Actor) As DataTable
        Dim table As New DataTable
        Try
            conn = New ConexionDB()
            conn._cmd = New SqlCommand("SP_TbActorSelectNombre", conn._objConn)
            conn._cmd.CommandType = CommandType.StoredProcedure
            conn._cmd.Parameters.Add(New SqlParameter("@NOMBRE", actor.Nombre))
            conn._cmd.Parameters.Add(New SqlParameter("@APELLIDO1", actor.Apellido1))
            conn._cmd.Parameters.Add(New SqlParameter("@APELLIDO2", actor.Apellido2))
            If conn._objConn.State = ConnectionState.Closed Then
                conn._objConn.Open()
            End If
            Dim adapter As New SqlDataAdapter(conn._cmd)
            adapter.Fill(table)
            conn._cmd.Dispose()
            conn._objConn.Close()
            Return table
        Catch ex As Exception
            MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical, "Error al consultar nombre de actor")
            Return table
        End Try
    End Function

    Public Sub New()

    End Sub

End Class
