Public Class EntityRequest
#Region "Campos"
    Private _Message As String
    Private _BtnSuccess As String
    Private _BtnCancel As String
#End Region

#Region "Propiedades"
    Public Property Message As String
        Get
            Return _Message
        End Get
        Set(value As String)
            _Message = value
        End Set
    End Property

    Public Property BtnSuccess As String
        Get
            Return _BtnSuccess
        End Get
        Set(value As String)
            _BtnSuccess = value
        End Set
    End Property

    Public Property BtnCancel As String
        Get
            Return _BtnCancel
        End Get
        Set(value As String)
            _BtnCancel = value
        End Set
    End Property

#End Region


#Region "Constructor"
    Public Sub New()

    End Sub

    Public Sub New(ByVal Message As String, ByVal BtnSuccess As String, ByVal BtnCancel As String)
        _Message = Message
        _BtnSuccess = BtnSuccess
        _BtnCancel = BtnCancel
    End Sub

#End Region

End Class
