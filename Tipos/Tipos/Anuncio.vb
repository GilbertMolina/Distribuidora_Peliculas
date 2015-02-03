Public Class Anuncio
    Private pK_IdAnuncioVal As Integer
    Private fechaEnvioVal As Date
    Private peliculaVal As New Pelicula

    Public Sub New()

    End Sub

    Public Property pelicula As Pelicula
        Get
            Return peliculaVal
        End Get
        Set(value As Pelicula)
            peliculaVal = value
        End Set
    End Property

    Public Property Id As Integer
        Get
            Return pK_IdAnuncioVal

        End Get
        Set(value As Integer)
            pK_IdAnuncioVal = value
        End Set
    End Property

    Public Property FechaEnvio As Date
        Get
            Return FechaEnvioVal

        End Get
        Set(value As Date)
            FechaEnvioVal = value
        End Set
    End Property

End Class
