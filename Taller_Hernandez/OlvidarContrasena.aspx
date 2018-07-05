<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="OlvidarContrasena.aspx.cs" Inherits="Taller_Hernandez.OlvidarContrasena" %>
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
    <div class="container">
        <div id="loginbox" style="margin-top: 50px;" class="mainbox col-md-6 col-md-offset-3 col-sm-8 col-sm-offset-2">
            <div class="panel panel-info">
                <div class="panel-heading">
                    <div class="panel-title">Restablesca su contraseña</div>
                </div>
                <div style="padding-top: 30px" class="panel-body">
                    <div class="form-horizontal">
                        <div style="margin-bottom: 25px" class="input-group">
                            <table>
                                <td>
                                    <tr>
                                        <asp:Label runat="server" Text="Nombre de Usuario:  "></asp:Label>
                                    </tr>
                                    <tr>
                                        <td > <asp:TextBox ID="Txtemail" runat="server" TextMode="Email" CssClass="form-control"></asp:TextBox></td>
                                    </tr>
                                </td>
                            </table>
                            </br>
                        <asp:Button ID="btnolvidarpass" runat="server" Text="Restablecer" CssClass="btn btn-success" OnClick="btnolvidarpass_Click" />
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
