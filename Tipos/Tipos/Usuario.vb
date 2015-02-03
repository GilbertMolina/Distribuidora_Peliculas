Public Class Usuario
    Private PK_Username_value As String
    Private Nombre_value As String
    Private Apellido1_value As String
    Private Apellido2_value As String
    Private Contrasenna_value As String
    Private Activo_value As Integer

    Public Property PK_Username As String
        Get
            Return PK_Username_value
        End Get
        Set(ByVal value As String)
            PK_Username_value = value
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

    Public Property Contrasenna As String
        Get
            Return Contrasenna_value
        End Get
        Set(ByVal value As String)
            Contrasenna_value = value
        End Set
    End Property

    Public Property Activo As Integer
        Get
            Return Activo_value
        End Get
        Set(ByVal value As Integer)
            Activo_value = value
        End Set
    End Property

    Public Sub New()

    End Sub

    Public Sub New(ByVal PK_Username As String, ByVal Nombre As String, ByVal Apellido1 As String, ByVal Apellido2 As String, ByVal Contrasenna As String, ByVal Activo As Integer)
        Me.PK_Username = PK_Username
        Me.Nombre = Nombre
        Me.Apellido1 = Apellido1
        Me.Apellido2 = Apellido2
        Me.Contrasenna = Contrasenna
        Me.Activo = Activo
    End Sub

End Class
