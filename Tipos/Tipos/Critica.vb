Public Class Critica
    Private idVal As Integer
    Private autorVal As String
    Private nombreMedioVal As String
    Private peliculaVal As New Pelicula
    Private fechaVal As Date


    Public Sub New()

    End Sub

    Public Property id As Integer
        Get
            Return idVal
        End Get
        Set(value As Integer)
            idVal = value
        End Set
    End Property
    Public Property autor As String
        Get
            Return autorVal
        End Get
        Set(value As String)
            autorVal = value
        End Set
    End Property
    Public Property nombreMedio As String
        Get
            Return nombreMedioVal
        End Get
        Set(value As String)
            nombreMedioVal = value
        End Set
    End Property

    Public Property fecha As Date
        Get
            Return fechaVal
        End Get
        Set(value As Date)
            fechaVal = value
        End Set
    End Property

    Public Property pelicula As Pelicula
        Get
            Return peliculaVal
        End Get
        Set(value As Pelicula)
            peliculaVal = value
        End Set
    End Property
End Class
