Public Class ProductoresPelicula
    Private idProductor_value As Integer
    Private idPelicula_value As Integer
    Private aporte_Value As Double

    'Properties
    Public Property idProductor As Integer
        Get
            Return idProductor_value
        End Get
        Set(ByVal value As Integer)
            idProductor_value = value
        End Set
    End Property

    Public Property idPelicula As Integer
        Get
            Return idPelicula_value
        End Get
        Set(ByVal value As Integer)
            idPelicula_value = value
        End Set
    End Property

    Public Property aporte As String
        Get
            Return aporte_Value
        End Get
        Set(ByVal value As String)
            aporte_Value = value
        End Set
    End Property


    'Constructores
    Public Sub New()
    End Sub

    Public Sub New(ByVal idProductor As Integer, ByVal idPelicula As Integer, ByVal aporte As Double)
        Me.idProductor = idProductor
        Me.idPelicula = idPelicula
        Me.aporte = aporte
    End Sub
End Class
