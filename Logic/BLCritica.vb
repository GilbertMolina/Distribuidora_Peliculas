Imports DataAccess
Imports Domain
Public Class BLCritica
    Private criticas As New DACriticas

    Public Function consultaCriticas() As DataTable
        Return criticas.consultaCriticas
    End Function

    Public Function consultaCriticaId(ByVal critica As Critica) As Critica
        Return criticas.consultaCriticaId(critica)
    End Function

    Public Sub insertarCritica(ByVal critica As Critica)
        criticas.insertarCritica(critica)
    End Sub

    Public Sub modificarCritica(ByVal critica As Critica)
        criticas.modificarCritica(critica)
    End Sub

    Public Sub eliminaCritica(ByVal critica As Critica)
        criticas.eliminaCriticaId(critica)
    End Sub
End Class
