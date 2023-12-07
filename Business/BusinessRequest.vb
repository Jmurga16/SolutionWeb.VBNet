Public Class BusinessRequest
    Dim DataRequest As New Data.DataRequest
    Public Function MostrarMensaje(message As String, btnSuccess As String, btnCancel As String) As Entity.EntityRequest
        Return DataRequest.MostrarMensaje(message, btnSuccess, btnCancel)
    End Function

    Public Function MostrarRespuesta(message As String, btnSuccess As String, btnCancel As String) As String
        Return DataRequest.MostrarRespuesta(message, btnSuccess, btnCancel)
    End Function
End Class
