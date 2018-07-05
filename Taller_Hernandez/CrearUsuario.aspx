<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CrearUsuario.aspx.cs" Inherits="Taller_Hernandez.CrearUsuario" %>

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
                    <div class="panel-title">Crear una cuenta</div>
                </div>
                <div style="padding-top: 30px" class="panel-body">
                    <div class="form-horizontal">
                        <div class="form-group">
                            <table>
                                <tr>                                    
                                    <td>
                                        <asp:Label ID="lbUser" runat="server" Text="Usuario:"></asp:Label>
                                    </td>
                                    <td>
                                    <asp:TextBox ID="TxtUsuarioIns" runat="server" CssClass="form-control"></asp:TextBox>
                                    </td>
                                    </tr>
                                <tr>
                                    <td>
                                        <asp:Label ID="lbpass" runat="server" Text=" Contraseña: "></asp:Label>
                                    </td>
                                    <td>
                                        <asp:TextBox ID="TxtcontraseñaIns" runat="server" CssClass="form-control" TextMode="Password"></asp:TextBox>

                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <asp:Label ID="Lbconf" runat="server" Text=" Confirmar Contraseña: "></asp:Label>
                                    </td>
                                    <td>
                                        <asp:TextBox ID="Txtconfirmar" runat="server" CssClass="form-control" TextMode="Password"></asp:TextBox>
                                    </td>
                                </tr>
                            </table>
                            <table>
                                <tr>
                                    <td>
                                        <asp:Label ID="lblFactura" runat="server" Text="Facturación"></asp:Label>
                                    </td>
                                    <td>
                                     <asp:RadioButton ID="rdfactura" runat="server" />
                                    </td>
                                    </tr>
                                <tr>
                                    <td>
                                        <asp:Label ID="lblInventario" runat="server" Text="Inventario"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:RadioButton ID="rdinventario" runat="server" />
                                    </td>
                                    </tr>
                                <tr>
                                    <td>
                                        <asp:Label ID="lblCitas" runat="server" Text="Citas"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:RadioButton ID="rdcitas" runat="server" />
                                    </td>
                                </tr>
                                                                <tr>
                                    <td>
                                        <asp:Label ID="LbConfiguracion" runat="server" Text="Configuración"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:RadioButton ID="rdconfiguracion" runat="server" />
                                    </td>
                                </tr>
                                                                <tr>
                                    <td>
                                        <asp:Label ID="LbReportes" runat="server" Text="Reportes"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:RadioButton ID="rdreportes" runat="server" />
                                    </td>
                                </tr>
                            </table>
                            <div class="form-horizontal">
                                <br />
                                <asp:Button ID="BtnRegistrar" runat="server" Text="Resgistrar" CssClass="btn btn-success" OnClick="BtnRegistrar_Click" />
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
