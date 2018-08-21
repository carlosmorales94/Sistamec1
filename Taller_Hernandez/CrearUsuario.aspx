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
                                    <asp:TextBox ID="TxtUsuarioIns" runat="server" CssClass="form-control"></asp:TextBox>
                                    </td>
                                    <td>
                                        &nbsp;</td>
                                    </tr>
                                <tr>
                                    <td>
                                        <asp:Label ID="lbpass" runat="server" Text=" Contraseña: "></asp:Label>
                                        <asp:TextBox ID="TxtcontraseñaIns" runat="server" CssClass="form-control" TextMode="Password"></asp:TextBox>

                                    </td>
                                    <td>
                                        &nbsp;</td>
                                </tr>
                                <tr>
                                    <td>
                                        <asp:Label ID="Lbconf" runat="server" Text=" Confirmar Contraseña: "></asp:Label>
                                        <asp:TextBox ID="Txtconfirmar" runat="server" CssClass="form-control" TextMode="Password"></asp:TextBox>
                                    </td>
                                    <td>
                                        &nbsp;</td>
                                </tr>
                            </table>
                            <table>
                                <tr>
                                    <td>
                                        <asp:Label ID="lblFactura" runat="server" Text="Facturación"></asp:Label>
                                     <asp:CheckBox ID="rdfactura" runat="server" />
                                    </td>
                                    <td>
                                        &nbsp;</td>
                                    </tr>
                                <tr>
                                    <td>
                                        <asp:Label ID="lblInventario" runat="server" Text="Inventario"></asp:Label>
                                        <asp:CheckBox ID="rdinventario" runat="server" />
                                    </td>
                                    <td>
                                        &nbsp;</td>
                                    </tr>
                                <tr>
                                    <td>
                                        <asp:Label ID="lblCitas" runat="server" Text="Citas"></asp:Label>
                                        <asp:CheckBox ID="rdcitas" runat="server" />
                                    </td>
                                    <td>
                                        &nbsp;</td>
                                </tr>
                                                                <tr>
                                    <td style="height: 26px">
                                        <asp:Label ID="LbConfiguracion" runat="server" Text="Configuración"></asp:Label>
                                        <asp:CheckBox ID="rdconfiguracion" runat="server" />
                                    </td>
                                    <td style="height: 26px">
                                        &nbsp;</td>
                                </tr>
                                                                <tr>
                                    <td>
                                        <asp:Label ID="LbReportes" runat="server" Text="Reportes"></asp:Label>
                                        <asp:CheckBox ID="rdreportes" runat="server" />
                                    </td>
                                    <td>
                                        &nbsp;</td>
                                </tr>
                            </table>
                            <div class="form-horizontal">
                                <br />
                                <asp:Button ID="BtnRegistrar" runat="server" Text="Registrar" CssClass="btn btn-success" OnClick="BtnRegistrar_Click" />
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
