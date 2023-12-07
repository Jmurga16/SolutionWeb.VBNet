Imports Entity
Imports Business
Imports Data
Imports System.Data.SqlClient
Imports System.Web.Script.Services
Imports System.Web.Services
Imports BLL
Imports System.Web.Services.Description
Imports LayerEntity
Public Class Nuevo
    Inherits Page

    Dim entityRequest As New Entity.EntityRequest
    Dim businessRequest As New Business.BusinessRequest
    Dim MostrarMensaje As New Data.DataRequest

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load


    End Sub

#Region "Metodo Desde Base de Datos"
    <System.Web.Services.WebMethod()>
    <ScriptMethod(UseHttpGet:=False, ResponseFormat:=ResponseFormat.Json)>
    Public Shared Function GetResponseFromBD(ByVal param As Integer) As List(Of Object)

        Dim MiBLLMensaje As New BLL.BLLMensaje

        Dim response As List(Of Object) = New List(Of Object)()
        Dim entity As LayerEntity.ClsMensaje

        entity = MiBLLMensaje.BGetMensajeFromBD(param)

        response.Add(New With {entity.Mensaje, entity.BtnPrincipal, entity.BtnSecundario})

        Return response

    End Function
#End Region

#Region "Respuesta Booleano"
    <System.Web.Services.WebMethod()>
    <ScriptMethod(UseHttpGet:=False, ResponseFormat:=ResponseFormat.Json)>
    Public Shared Function GetResponseTestBool(ByVal param As String) As Boolean

        Dim MiBLLMensaje As New BLL.BLLMensaje

        Dim Mensaje = "¿Desea Continuar?"
        Dim BtnPrincipal = "Aceptar"
        Dim BtnSecundario = "Cancelar"

        Return MiBLLMensaje.BGetResponseBool(Mensaje, BtnPrincipal, BtnSecundario)

    End Function
#End Region


#Region "Respuesta String"
    <System.Web.Services.WebMethod()>
    <ScriptMethod(UseHttpGet:=False, ResponseFormat:=ResponseFormat.Json)>
    Public Shared Function GetResponseTestString(ByVal param As String) As String

        Dim business As New Business.BusinessRequest

        Dim Mensaje = "¿Desea Continuar?"
        Dim BtnPrincipal = "Aceptar"
        Dim BtnSecundario = "Cancelar"

        Return business.MostrarRespuesta(Mensaje, BtnPrincipal, BtnSecundario)

    End Function
#End Region


#Region "Respuesta Desde Inputs"
    <System.Web.Services.WebMethod()>
    <ScriptMethod(UseHttpGet:=False, ResponseFormat:=ResponseFormat.Json)>
    Public Shared Function GetResponseFromInput(ByVal Mensaje As String, ByVal BtnPrincipal As String, ByVal BtnSecundario As String) As Entity.EntityRequest

        Dim business As New Business.BusinessRequest

        Return business.MostrarMensaje(Mensaje, BtnPrincipal, BtnSecundario)

    End Function
#End Region

#Region "Metodo Get En General"

    <WebMethod>
    Public Shared Function GetCurrentTime(ByVal name As String) As String
        Return "Hello " & name & Environment.NewLine & "The Current Time is: " &
                 DateTime.Now.ToString()
    End Function
#End Region

End Class