<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ConfCorreo.aspx.cs" Inherits="Taller_Hernandez.ConfCorreo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <div class="alert alert-success" visible="false" id="mensaje" runat="server">
        <a href="#" class="close" data-dismiss="alert" aria-label="close">&times;</a>
        <strong id="textoMensaje" runat="server"></strong>
    </div>
    <div class="alert alert-danger" visible="false" id="mensajeError" runat="server">
        <a href="#" class="close" data-dismiss="alert" aria-label="close">&times;</a>
        <strong id="textoMensajeError" runat="server"></strong>
    </div>
    <br />
    <div class="container">
        <div id="loginbox" style="margin-top: 50px;" class="mainbox col-md-6 col-md-offset-3 col-sm-8 col-sm-offset-2">
            <div class="panel panel-info">
                <div class="panel-heading">
                    <div class="panel-title">Configuración envio de correo</div>
                </div>
                <div style="padding-top: 30px" class="panel-body">
                    <table cellspacing="3" cellpadding="2">
                        <tr>
                            <td>
                                <asp:Label ID="Lbcorreo" runat="server" Text="Correo.........:"></asp:Label></td>
                            <td>
                                <asp:TextBox ID="TxtCorreo" runat="server" CssClass="form-control" TextMode="Email"></asp:TextBox></td>

                        </tr>
                        <tr>
                            <td>
                                <asp:Label ID="Lbpass" runat="server" Text="Contraseña.:"></asp:Label></td>
                            <td>
                                <asp:TextBox ID="Txtcontra" runat="server" CssClass="form-control" TextMode="Password"></asp:TextBox></td>
                            <td>
                                <asp:Button ID="Btnaceptar" runat="server" Text="Aceptar" CssClass="btn btn-primary" OnClick="Btnaceptar_Click" />

                            </td>
                        </tr>

                        <tr>
                           <td>
                                <%--<asp:Label ID="Lbtexto" runat="server" Text="Correo Utilizado:"></asp:Label>--%>
                            </td>
                            <td >
                                      <asp:GridView ID="Gbcorreo" runat="server" BackColor="Silver" CellPadding="5" CellSpacing="5"></asp:GridView>
                            </td>
                        </tr>
                    </table>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
