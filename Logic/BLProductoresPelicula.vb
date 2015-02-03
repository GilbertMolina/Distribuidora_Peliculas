Imports DataAccess
Imports Domain

Public Class BLProductoresPelicula

    Private DAProductorPelicula As DAProductoresPelicula

    Public Sub insertarProductorPelicula(ByVal productorPelicula As ProductoresPelicula)
        Dim productorPeliculaConsultado As New ProductoresPelicula

        productorPeliculaConsultado.idPelicula = productorPelicula.idPelicula
        productorPeliculaConsultado.idProductor = productorPelicula.idProductor

        productorPeliculaConsultado = DAProductorPelicula.consultarProductorPeliculaID(productorPeliculaConsultado)

        If productorPeliculaConsultado.idProductor = -1 Then
            DAProductorPelicula.insertarProductorPelicula(productorPelicula)
        Else
            MsgBox("Error: Ya fue ingresado el productor para la película en la base de datos", MsgBoxStyle.Critical, "Error al Insertar")
        End If
    End Sub

    Public Function consultarProductorPelicula() As DataTable
        Return DAProductorPelicula.consultarProductorPelicula()
    End Function

    Public Function consultarProductorPeliculaId(ByVal productorPelicula As ProductoresPelicula) As ProductoresPelicula
        Return DAProductorPelicula.consultarProductorPeliculaID(productorPelicula)
    End Function

    Public Sub modificarProductorPelicula(ByVal productorPelicula As ProductoresPelicula)
        DAProductorPelicula.modificarProductorPelicula(productorPelicula)
    End Sub

    Public Sub eliminarProductorPelicula(ByVal productorPelicula As ProductoresPelicula)
        DAProductorPelicula.eliminarProductorPelicula(productorPelicula)
    End Sub

    Public Sub New()
        DAProductorPelicula = New DAProductoresPelicula()
    End Sub

End Class
