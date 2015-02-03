Imports DataAccess
Imports Domain
Public Class BLAnuncio
    Private anuncios As New DAAnuncios

    Public Function consultaAnuncios() As DataTable
        Return anuncios.consultaAnuncios
    End Function

    Public Function consultaAnuncioId(ByVal anuncio As Anuncio) As Anuncio
        Return anuncios.consultaAnuncioId(anuncio)
    End Function

    Public Sub insertarAnuncio(ByVal anuncio As Anuncio)
        anuncios.insertarAnuncio(anuncio)
    End Sub

    Public Sub modificarAnuncio(ByVal anuncio As Anuncio)
        anuncios.modificarAnuncio(anuncio)
    End Sub

    Public Sub eliminaAnuncio(ByVal anuncio As Anuncio)
        anuncios.eliminaAnuncioId(anuncio)
    End Sub
End Class
