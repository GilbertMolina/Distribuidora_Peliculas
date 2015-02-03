Imports DataAccess
Imports Domain

Public Class BLPremio

    Private DAPremio As DAPremios

    Public Sub insertarPremio(ByVal premio As Premio)
        DAPremio.insertarPremio(premio)
    End Sub

    Public Function consultarPremios() As DataTable
        Return DAPremio.consultarPremios()
    End Function

    Public Function consultarPremiosPelicula(ByVal idPelicula As Integer) As DataTable
        Return DAPremio.consultarPremiosPelicula(idPelicula)
    End Function

    Public Sub modificarPremio(ByVal premio As Premio)
        DAPremio.modificarPremio(premio)
    End Sub

    Public Sub eliminarPremio(ByVal premio As Premio)
        DAPremio.eliminarPremio(premio)
    End Sub

    Public Sub New()
        DAPremio = New DAPremios()
    End Sub

End Class
