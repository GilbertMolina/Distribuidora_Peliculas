Imports DataAccess
Imports Domain

Public Class BLActores

    Public Function CargarActorXId(ByVal idActor As String) As Actor
        Dim actor As New Actor
        Dim oActor As New DAActores
        If Not idActor.Trim() = "" Then
            actor = oActor.ConsultaActoresID(idActor)

        End If

        Return actor
    End Function

    Public Function CargarActorAll() As List(Of Actor)
        Dim actor As List(Of Actor)
        Dim oActor As New DAActores

        actor = oActor.ConsultarActoresAll()
        Return actor
    End Function

    Public Sub InsertarActor(ByVal actor As Actor)

        Dim oActor As New DAActores
        oActor.InsertarActor(actor)


    End Sub

    Sub ModificarActor(ByVal actor As Actor)
        Dim oActor As New DAActores
        oActor.ModificarActor(actor)
    End Sub

    Sub EliminarActor(ByVal actor As Actor)
        Dim oActor As New DAActores
        oActor.EliminarActor(actor)
    End Sub

    Public Function BuscarPorNombre(ByVal actor As Actor) As DataTable
        Dim oActor As New DAActores
        Return oActor.BuscarPorNombre(actor)
    End Function
End Class
