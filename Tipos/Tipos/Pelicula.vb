Public Class Pelicula
    Private PK_IdPelicula_value As Integer
    Private FK_IdDirector_value As Integer
    Private Titulo_value As String
    Private Argumento_value As String
    Private FechaEstreno_value As Date
    Private Nacionalidad_value As String

    Public Property PK_IdPelicula As Integer
        Get
            Return PK_IdPelicula_value
        End Get
        Set(ByVal value As Integer)
            PK_IdPelicula_value = value
        End Set
    End Property

    Public Property FK_IdDirector As Integer
        Get
            Return FK_IdDirector_value
        End Get
        Set(ByVal value As Integer)
            FK_IdDirector_value = value
        End Set
    End Property

    Public Property Titulo As String
        Get
            Return Titulo_value
        End Get
        Set(ByVal value As String)
            Titulo_value = value
        End Set
    End Property

    Public Property Argumento As String
        Get
            Return Argumento_value

        End Get
        Set(ByVal value As String)
            Argumento_value = value
        End Set
    End Property

    Public Property FechaEstreno As Date
        Get
            Return FechaEstreno_value
        End Get
        Set(ByVal value As Date)
            FechaEstreno_value = value
        End Set
    End Property

    Public Property Nacionalidad As String
        Get
            Return Nacionalidad_value
        End Get
        Set(ByVal value As String)
            Nacionalidad_value = value
        End Set
    End Property

    Public Sub New()

    End Sub

    Public Sub New(ByVal PK_IdPelicula As Integer, ByVal FK_IdDirector As Integer, ByVal Titulo As String, ByVal Argumento As String, ByVal FechaEstreno As Date, ByVal Nacionalidad As String)
        Me.PK_IdPelicula = PK_IdPelicula
        Me.FK_IdDirector = FK_IdDirector
        Me.Titulo = Titulo
        Me.Argumento = Argumento
        Me.FechaEstreno = FechaEstreno
        Me.Nacionalidad = Nacionalidad
    End Sub

End Class
