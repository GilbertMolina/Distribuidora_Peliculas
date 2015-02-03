Public Class Lugar

    Private PK_IdLugar_value As Integer
    Private Nombre_value As String

    Public Property PK_IdLugar As Integer
        Get
            Return PK_IdLugar_value
        End Get
        Set(ByVal value As Integer)
            PK_IdLugar_value = value
        End Set
    End Property

    Public Property Nombre As String
        Get
            Return Nombre_value
        End Get
        Set(ByVal value As String)
            Nombre_value = value
        End Set
    End Property

    Public Sub New()

    End Sub

    Public Sub New(ByVal PK_IdLugar As Integer, ByVal Nombre As String)
        Me.PK_IdLugar = PK_IdLugar
        Me.Nombre = Nombre
    End Sub

End Class
