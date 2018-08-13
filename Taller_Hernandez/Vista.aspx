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
<%--            <tr>
                <td>
                    <h4>Fecha:</h4>
                </td>
                </tr>--%>
            <tr>
                <td>
                     <%--<asp:DropDownList ID="DrpMarca" runat="server"></asp:DropDownList></td>--%>
                    <asp:DropDownList ID="Drpfecha" runat="server" CssClass="form-control" Width="120px"  ></asp:DropDownList>
               <%--    <asp:Calendar ID="Clcita" runat="server" CaptionAlign="Left" OnSelectionChanged="Clcita_SelectionChanged"></asp:Calendar>--%>
                        </td>
                <td>
                    <asp:Button ID="BtnBuscar" runat="server" Text="Buscar" CssClass="btn btn-primary" OnClick="BtnBuscar_Click" />
                </td>
                <td>
                    &nbsp;</td>
            </tr>
        </table>
    </div>
    <br>
    <p>
        <asp:GridView ID="Ggvcitas" runat="server" BackColor="Silver" CssClass="table table-hover"></asp:GridView>
    </p>
    <table>
    <tr>
        <td>
            <asp:DropDownList ID="Drpplaca" runat="server" CssClass="form-control" Width="150px"></asp:DropDownList>
        </td>
        <td>
            <asp:Button ID="Btnllegado" runat="server" Text="Check In" CssClass="btn btn-primary" OnClick="Btnllegado_Click" />
        </td>
    </tr>
    </table>

</asp:Content>
