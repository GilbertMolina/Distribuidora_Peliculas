Imports DataAccess
Imports Domain

Public Class BLProductor
    Private DAProductor As DAProductor

    Public Sub insertarProductor(ByVal productor As Productor)
        'Agrega el premio al Data Grid View
        DAProductor.insertarProductor(productor)
    End Sub

    Public Function consultarProductores() As DataTable
        Return DAProductor.consultarProductor()
    End Function

    Public Function consultarProductorNombre(ByVal productor As Productor) As DataTable
        Return DAProductor.buscarProductor(productor)
    End Function


    Public Sub modificarProductor(ByVal productor As Productor)
        DAProductor.modificarProductor(productor)
    End Sub

    Public Sub eliminarProductor(ByVal productor As Productor)
        DAProductor.eliminarProductor(productor)
    End Sub

    Public Sub New()
        DAProductor = New DAProductor()
    End Sub
End Class
