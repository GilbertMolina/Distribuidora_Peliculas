Imports DataAccess

Public Class BLActoresPelicula

    Sub Insertar(ByVal actor As Domain.ActoresPelicula)
        Dim oActor As New DAActoresPelicula()
        oActor.InsertActorXPelicula(actor)
    End Sub

    Function ConsultarTodos() As DataTable
        Dim oActor As New DAActoresPelicula()
        Return oActor.SelectTodo()
    End Function

    Sub Modificar(ByVal actor As Domain.ActoresPelicula)
        Dim oActor As New DAActoresPelicula()
        oActor.ModificarActorXPelicula(actor)
    End Sub

    Sub Eliminar(ByVal actor As Domain.ActoresPelicula)
        Dim oActor As New DAActoresPelicula()
        oActor.EliminarActorXPelicula(actor)
    End Sub

End Class
