<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Vista.aspx.cs" Inherits="Taller_Hernandez.Vista" %>


<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br>
    <div class="alert alert-success" visible="false" id="mensaje" runat="server">
        <a href="#" class="close" data-dismiss="alert" aria-label="close">&times;</a>
        <strong id="textoMensaje" runat="server"></strong>
    </div>
    <div class="alert alert-danger" visible="false" id="mensajeError" runat="server">
        <a href="#" class="close" data-dismiss="alert" aria-label="close">&times;</a>
        <strong id="textoMensajeError" runat="server"></strong>
    </div>
    <br>
    <div class="form-inline">
        <table>
            <tr>
                <h2><%= DateTime.Now.ToShortDateString() %></h2>
            </tr>
            <tr>
                <td>
                    <h4>Fecha:</h4>
                </td>
                <td>
                    <asp:DropDownList ID="Drpfecha" runat="server"></asp:DropDownList></td>
                <td>
                    <asp:Button ID="BtnBuscar" runat="server" Text="Buscar" CssClass="btn btn-primary" OnClick="BtnBuscar_Click" /></td>
            </tr>
        </table>
    </div>
    <br>
    <p>
        <asp:GridView ID="Ggvcitas" runat="server" BackColor="Silver" CssClass="table table-hover"></asp:GridView>
    </p>
</asp:Content>

