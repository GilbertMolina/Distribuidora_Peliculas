Public Class Productor
    'atributos
    Private idProductor_value As Integer
    Private nombre_value As String
    Private apellido1_value As String
    Private apellido2_value As String

    'Properties
    Public Property idProductor As Integer
        Get
            Return idProductor_value
        End Get
        Set(value As Integer)
            idProductor_value = value
        End Set
    End Property


    Public Property nombre As String
        Get
            Return nombre_value
        End Get
        Set(value As String)
            nombre_value = value
        End Set
    End Property

    Public Property apellido1 As String
        Get
            Return apellido1_value
        End Get
        Set(value As String)
            apellido1_value = value
        End Set
    End Property

    Public Property apellido2 As String
        Get
            Return apellido2_value
        End Get
        Set(value As String)
            apellido2_value = value
        End Set
    End Property


    'Constructores
    Public Sub New()
    End Sub

    Public Sub New(ByVal idProductor As Integer, ByVal nombre As String, ByVal apellido1 As String, ByVal apellido2 As String)
        Me.idProductor = idProductor
        Me.nombre = nombre
        Me.apellido1 = apellido1
        Me.apellido2 = apellido2
    End Sub
End Class
