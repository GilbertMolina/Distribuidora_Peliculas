Imports DataAccess
Imports Domain

Public Class BLPelicula

    Private DAPelicula As DAPeliculas

    Public Sub insertarPelicula(ByVal pelicula As Pelicula)
        Dim peliculaConsultada As New Pelicula

        peliculaConsultada.Titulo = "%" & pelicula.Titulo & "%"

        peliculaConsultada = DAPelicula.consultarPeliculaNombre(peliculaConsultada)

        If peliculaConsultada.Titulo = "NULL" Then
            DAPelicula.insertarPelicula(pelicula)
        Else
            MsgBox("Error: La película ya existe en la base de datos", MsgBoxStyle.Critical, "Error al Insertar")
        End If
    End Sub

    Public Function consultarPeliculas() As DataTable
        Return DAPelicula.consultarPeliculas()
    End Function

    Public Function consultarPeliculaNombre(ByVal pelicula As Pelicula) As Pelicula
        Return DAPelicula.consultarPeliculaNombre(pelicula)
    End Function

    Public Function consultarPeliculaID(ByVal pelicula As Pelicula) As Pelicula
        Return DAPelicula.consultarPeliculaID(pelicula)
    End Function

    Public Function busquedaPeliculaTitulo(ByVal pelicula As Pelicula) As DataTable
        Return DAPelicula.busquedaPeliculaTitulo(pelicula)
    End Function

    Public Sub modificarPelicula(ByVal pelicula As Pelicula)
        Dim peliculaConsultada As New Pelicula

        peliculaConsultada.PK_IdPelicula = pelicula.PK_IdPelicula

        peliculaConsultada = DAPelicula.consultarPeliculaID(peliculaConsultada)

        If peliculaConsultada.PK_IdPelicula = -1 Then
            MsgBox("Error: La película no existe en la base de datos", MsgBoxStyle.Critical, "Error al Modificar")
        Else
            DAPelicula.modificarPelicula(pelicula)
        End If
    End Sub

    Public Sub eliminarPelicula(ByVal pelicula As Pelicula)
        DAPelicula.eliminarPelicula(pelicula)
    End Sub

    Public Sub New()
        DAPelicula = New DAPeliculas()
    End Sub

End Class
