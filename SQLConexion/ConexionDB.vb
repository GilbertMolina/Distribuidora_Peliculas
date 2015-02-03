Imports System.Data.SqlClient

Public Class ConexionDB

    Private _strConnString_value As String
    Private _objConn_value As SqlConnection
    Private _cmd_value As SqlCommand
    Private _ad_value As SqlDataAdapter

    Public Property _strConnString As String
        Get
            Return _strConnString_value
        End Get
        Set(ByVal value As String)
            _strConnString_value = value
        End Set
    End Property

    Public Property _objConn As SqlConnection
        Get
            Return _objConn_value
        End Get
        Set(ByVal value As SqlConnection)
            _objConn_value = value
        End Set
    End Property

    Public Property _cmd As SqlCommand
        Get
            Return _cmd_value
        End Get
        Set(ByVal value As SqlCommand)
            _cmd_value = value
        End Set
    End Property

    Public Property _ad As SqlDataAdapter
        Get
            Return _ad_value
        End Get
        Set(ByVal value As SqlDataAdapter)
            _ad_value = value
        End Set
    End Property

    Public Sub CerrarConeccion()
        Me._objConn.Close()
    End Sub

    Public Function EjecutarConsulta(ByVal comando As String, ByVal tabla As String) As DataSet
        Dim ds As New DataSet

        _ad_value = New SqlDataAdapter(comando, _objConn_value)

        _ad_value.Fill(ds, tabla)

        Return ds
    End Function

    Public Function EjecutarComando(ByVal comando As String) As Boolean
        Dim res As Boolean = True
        Dim intRes As Integer = 0

        _cmd_value = New SqlCommand(comando, _objConn_value)
        intRes = _cmd_value.ExecuteNonQuery()

        Return res
    End Function

    Public Sub New()
        'Me._strConnString = "Server=TOSHIBA-PC\SQLEXPRESS;Database=BDDistribuidoraPeliculas;Trusted_Connection=True;" '--> Jorge
        'Me._strConnString = "Server=Cavi\SQL2008EX;Database=BDDistruibuidoraPeliculas;User Id=sysDisPeli; Password=sysDisPeli;" '--> Carlos
        Me._strConnString = "Server=WIN7-PROGRA2;Database=BDDistruibuidoraPeliculas;User Id=sysDisPeli; Password=sysDisPeli;" '--> Gilberth
        'Me._strConnString = "Server=Jei\SQLEXPRESS;Database=BDDistruibuidoraPeliculas;Trusted_Connection=True;" '--> Jeison
        Me._objConn = New SqlConnection(Me._strConnString)
    End Sub

End Class
