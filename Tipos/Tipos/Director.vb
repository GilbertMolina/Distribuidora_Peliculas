Public Class Director
    Private PK_IdDirector_value As Integer
    Private Nombre_value As String
    Private Apellido1_value As String
    Private Apellido2_value As String

    Public Property PK_IdDirector As Integer
        Get
            Return PK_IdDirector_value
        End Get
        Set(ByVal value As Integer)
            PK_IdDirector_value = value
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
    Public Property Apellido1 As String
        Get
            Return Apellido1_value
        End Get
        Set(ByVal value As String)
            Apellido1_value = value
        End Set
    End Property

    Public Property Apellido2 As String
        Get
            Return Apellido2_value
        End Get
        Set(ByVal value As String)
            Apellido2_value = value
        End Set
    End Property

    Public Sub New()

    End Sub

    Public Sub New(ByVal PK_IdDirector As Integer, ByVal Nombre As String, ByVal Apellido1 As String, ByVal Apellido2 As String)
        Me.PK_IdDirector = PK_IdDirector
        Me.Nombre = Nombre
        Me.Apellido1 = Apellido1
        Me.Apellido2 = Apellido2
    End Sub

End Class
