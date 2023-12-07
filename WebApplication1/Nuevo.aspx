<%@ Page Title="Contact" Language="VB" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Nuevo.aspx.vb" Inherits="WebApplication1.Nuevo" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <main aria-labelledby="title">
        <h2 id="title">Nuevo Test</h2>

        <p>Mensaje</p>
        <p>
            &nbsp;<asp:TextBox ID="TXT_MENSAJE" runat="server"></asp:TextBox>
        </p>
        <p>Boton Principal</p>
        <p>
            &nbsp;<asp:TextBox ID="TXT_PRINCIPAL" runat="server"></asp:TextBox>
        </p>
        <p>Boton Secundario</p>
        <p>
            &nbsp;<asp:TextBox ID="TXT_SECUNDARIO" runat="server"></asp:TextBox>
        </p>
        <p>
            &nbsp;<asp:Button ID="Button1" runat="server" Text="Mostrar Mensaje Desde input" UseSubmitBehavior="false" CssClass="btn btn-primary"
                OnClientClick="return getMensajeFromInput()" />
        </p>

        <p>
            &nbsp;<asp:Button ID="Button2" runat="server" Text="Mostrar Mensaje Desde BD" UseSubmitBehavior="false" CssClass="btn btn-primary"
                OnClientClick="return getMensajeFromBD()" />
        </p>


    </main>

    <%: Scripts.Render("~/Scripts/Nuevo/nuevo.js") %>

    <script type="text/javascript">
        function ShowCurrentTime() {
            $.ajax({
                type: "POST",
                url: "Default.aspx/GetCurrentTime",
                data: '{name: "' + $("#<%=TXT_MENSAJE.ClientID%>")[0].value + '" }',
                contentType: "application/json; charset=utf-8",
                dataType: "json",
                success: OnSuccess,
                error: function (response) {
                    alert(response.responseText);
                }
            });
        }
        function OnSuccess(response) {
            alert(response.d);
        }
    </script>

</asp:Content>
