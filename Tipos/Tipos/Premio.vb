Public Class Premio
    'atributos
    Private idPremio_value As Integer
    Private idPelicula_value As Integer
    Private nombre_value As String
    Private ciudad_value As String

    'Properties
    Public Property idPremio As Integer
        Get
            Return idPremio_value
        End Get
        Set(value As Integer)
            idPremio_value = value
        End Set
    End Property

    Public Property idPelicula As Integer
        Get
            Return idPelicula_value
        End Get
        Set(value As Integer)
            idPelicula_value = value
        End Set
    End Property

    Public Property nombre As String
        Get
            Return nombre_value
        End Get
        Set(value As String)
            nombre_value = value
        End Set
    End Property

    Public Property ciudad As String
        Get
            Return ciudad_value
        End Get
        Set(value As String)
            ciudad_value = value
        End Set
    End Property


    'Constructores
    Public Sub New()
    End Sub

    Public Sub New(ByVal idPremio As Integer, ByVal idPelicula As Integer, ByVal nombre As String, ByVal ciudad As String)
        Me.idPremio = idPremio
        Me.idPelicula = idPelicula
        Me.nombre = nombre
        Me.ciudad = ciudad
    End Sub

End Class
