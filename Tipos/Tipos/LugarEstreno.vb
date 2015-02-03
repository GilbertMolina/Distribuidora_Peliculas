Public Class LugarEstreno

    Private FK_PK_IdLugar_value As Integer
    Private FK_PK_IdPelicula_value As Integer

    Public Property FK_PK_IdLugar As Integer
        Get
            Return FK_PK_IdLugar_value
        End Get
        Set(ByVal value As Integer)
            FK_PK_IdLugar_value = value
        End Set
    End Property

    Public Property FK_PK_IdPelicula As Integer
        Get
            Return FK_PK_IdPelicula_value
        End Get
        Set(ByVal value As Integer)
            FK_PK_IdPelicula_value = value
        End Set
    End Property

    Public Sub New()

    End Sub

    Public Sub New(ByVal FK_PK_IdLugar As Integer, ByVal FK_PK_IdPelicula As Integer)
        Me.FK_PK_IdLugar = FK_PK_IdLugar
        Me.FK_PK_IdPelicula = FK_PK_IdPelicula
    End Sub

End Class
