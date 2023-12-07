Public Class DataRequest
    Public Function MostrarMensaje(message As String, btnSuccess As String, btnCancel As String) As Entity.EntityRequest
        Dim entity As Entity.EntityRequest = New Entity.EntityRequest
        Try
            entity.Message = message
            entity.BtnSuccess = btnSuccess
            entity.BtnCancel = btnCancel
            Return entity
        Catch ex As Exception
            Return entity
        End Try
    End Function

    Public Function MostrarRespuesta(message As String, btnSuccess As String, btnCancel As String) As String
        Try
            Return "Exito"
        Catch ex As Exception
            Return "Error"
        End Try
    End Function

End Class
