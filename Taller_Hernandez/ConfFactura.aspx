<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ConfFactura.aspx.cs" Inherits="Taller_Hernandez.ConfFactura" %>

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
    <table>
        <tr>
            <td>
                <div class="container">
                    <div id="V1" style="margin-top: 10px;" class="mainbox">
                        <div class="panel panel-info">
                            <div class="panel-heading">
                                <div class="panel-title">Servicios Mecanica General</div>
                            </div>
                            <div style="padding-top: 30px" class="panel-body">
                                <table cellspacing="3" cellpadding="2">
                                    <tr>
                                        <td>
                                            <asp:Label ID="LbServi" runat="server" Text="Servicio:"></asp:Label></td>
                                        <td>
                                            <asp:TextBox ID="Txteliservi" runat="server" CssClass="form-control"></asp:TextBox></td>
                                        <td>
                                            <asp:Button ID="BtneliServi" runat="server" Text="Eliminar Servicio" CssClass="btn btn-primary" OnClick="BtneliServi_Click" /></td>
                                        <tr>
                                </table>

                                <br />
                                <h4>Ingreso</h4>
                                <table cellspacing="3" cellpadding="2">
                                    <tr>
                                        <td>
                                            <asp:Label ID="LbServicio" runat="server" Text="Servicio: "></asp:Label></td>
                                        <td>
                                            <asp:TextBox ID="Txtservicio" runat="server" CssClass="form-control"></asp:TextBox></td>
                                        <td>
                                            <asp:Button ID="BtnAceptarser" runat="server" Text="Aceptar" CssClass="btn btn-success" OnClick="BtnAceptarser_Click" /></td>
                                    </tr>
                                </table>
                            </div>
                        </div>
                    </div>
                </div>
                <div align="center">
                    <asp:GridView ID="Gbservicio" runat="server" BackColor="Silver" CellPadding="5" CellSpacing="5"></asp:GridView>
                </div>
            </td>


            <td>
                <div class="container">
                    <div id="V2" style="margin-top: 10px;" class="mainbox">
                        <div class="panel panel-info">
                            <div class="panel-heading">
                                <div class="panel-title">Producto Contrapedido</div>
                            </div>
                            <div style="padding-top: 30px" class="panel-body">
                                <table cellspacing="3" cellpadding="2">
                                    <tr>
                                        <td>
                                            <asp:Label ID="Lbpro" runat="server" Text="Producto:"></asp:Label></td>
                                        <td>
                                            <asp:TextBox ID="Txtelipro" runat="server" CssClass="form-control"></asp:TextBox></td>
                                        <td>
                                            <asp:Button ID="Btnelipro" runat="server" Text="Eliminar Producto" CssClass="btn btn-primary" OnClick="Btnelipro_Click" /></td>
                                        <tr>
                                </table>

                                <br />
                                <h4>Ingreso</h4>
                                <table cellspacing="3" cellpadding="2">
                                    <tr>
                                        <td>
                                            <asp:Label ID="Lbprod" runat="server" Text="Producto: "></asp:Label></td>
                                        <td>
                                            <asp:TextBox ID="Txtprodu" runat="server" CssClass="form-control"></asp:TextBox></td>
                                        <td>
                                            <asp:Button ID="BtnAceptarpro" runat="server" Text="Aceptar" CssClass="btn btn-success" OnClick="BtnAceptarpro_Click" /></td>
                                    </tr>
                                </table>
                            </div>
                        </div>
                    </div>
                </div>
                <div align="center">
                    <asp:GridView ID="Gbvprod" runat="server" BackColor="Silver" CellPadding="5" CellSpacing="5"></asp:GridView>
                </div>
            </td>
        </tr>
    </table>


</asp:Content>
