Public Class ClsCliente

#Region "CAMPOS"
    Private _ID_Cliente As Integer
    Private _Nombre_C As String
    Private _Sexo As String
    Private _Edad As Integer
    Private _Observaciones As String
#End Region

#Region "PROPIEDADES"

    Public Property ID_Cliente As Integer
        Get
            Return _ID_Cliente
        End Get
        Set(value As Integer)
            _ID_Cliente = value
        End Set
    End Property

    Public Property Nombre_C As String
        Get
            Return _Nombre_C
        End Get
        Set(value As String)
            _Nombre_C = value
        End Set
    End Property

    Public Property Sexo As String
        Get
            Return _Sexo
        End Get
        Set(value As String)
            _Sexo = value
        End Set
    End Property

    Public Property Edad As Integer
        Get
            Return _Edad
        End Get
        Set(value As Integer)
            _Edad = value
        End Set
    End Property

    Public Property Observaciones As String
        Get
            Return _Observaciones
        End Get
        Set(value As String)
            _Observaciones = value
        End Set
    End Property

#End Region
    Public Sub New()
    End Sub

    Public Sub New(ByVal ID_CLIENTE As Integer, ByVal NOMBRE_C As String, ByVal SEXO As String, ByVal EDAD As Integer, ByVal OBSERVACIONES As String)
        _ID_Cliente = ID_CLIENTE
        _Nombre_C = NOMBRE_C
        _Sexo = SEXO
        _Edad = EDAD
        _Observaciones = OBSERVACIONES
    End Sub
End Class
