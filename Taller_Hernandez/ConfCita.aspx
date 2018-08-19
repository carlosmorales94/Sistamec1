<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ConfCita.aspx.cs" Inherits="Taller_Hernandez.ConfCita" %>

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
                                <div class="panel-title">Mantenimiento de Marcas</div>
                            </div>
                            <div style="padding-top: 30px" class="panel-body">
                                <table cellspacing="3" cellpadding="2">
                                    <tr>
                                        <td>
                                            <asp:Label ID="LbBuscarmarca" runat="server" Text="Marca:"></asp:Label></td>
                                        <td>
                                            <asp:TextBox ID="Txtelimarca" runat="server" CssClass="form-control"></asp:TextBox></td>
                                        <td>
                                            <asp:Button ID="BtnElimarca" runat="server" Text="Eliminar Marca" CssClass="btn btn-primary" OnClick="BtnElimarca_Click" /></td>
                                        <tr>
                                </table>

                                <br />
                                <h4>Ingreso</h4>
                                <table cellspacing="3" cellpadding="2">
                                    <tr>
                                        <td>
                                            <asp:Label ID="LbNmarca" runat="server" Text="Marca: "></asp:Label></td>
                                        <td>
                                            <asp:TextBox ID="Txtmarca" runat="server" CssClass="form-control"></asp:TextBox></td>
                                        <td>
                                            <asp:Button ID="BtnAceptarmar" runat="server" Text="Aceptar" CssClass="btn btn-success" OnClick="BtnAceptarmar_Click" /></td>
                                    </tr>
                                </table>
                            </div>
                        </div>
                    </div>
                </div>
                <div align="center">
                    <asp:GridView ID="Ggvmarca" runat="server" BackColor="Silver" CellPadding="5" CellSpacing="5"></asp:GridView>
                </div>
            </td>
            <td>
                <div class="container">
                    <div id="V2" style="margin-top: 10px;" class="mainbox">
                        <div class="panel panel-info">
                            <div class="panel-heading">
                                <div class="panel-title">Mantenimiento de Años</div>
                            </div>
                            <div style="padding-top: 30px" class="panel-body">
                                <table cellspacing="3" cellpadding="2">
                                    <tr>
                                        <td>
                                            <asp:Label ID="Lbanoeli" runat="server" Text="Año:"></asp:Label></td>
                                        <td>
                                            <asp:TextBox ID="Txteliano" runat="server" CssClass="form-control"></asp:TextBox></td>
                                        <td>
                                            <asp:Button ID="BtnEliano" runat="server" Text="Eliminar Año" CssClass="btn btn-primary" OnClick="BtnEliano_Click" /></td>
                                        <tr>
                                </table>

                                <br />
                                <h4>Ingreso</h4>
                                <table cellspacing="3" cellpadding="2">
                                    <tr>
                                        <td>
                                            <asp:Label ID="Lbano" runat="server" Text="Año: "></asp:Label></td>
                                        <td>
                                            <asp:TextBox ID="Txtano" runat="server" CssClass="form-control"></asp:TextBox></td>
                                        <td>
                                            <asp:Button ID="BtnAceptarano" runat="server" Text="Aceptar" CssClass="btn btn-success" OnClick="BtnAceptarano_Click" /></td>
                                    </tr>
                                </table>
                            </div>
                        </div>
                    </div>
                </div>
                <div align="center">
                    <asp:GridView ID="Gbvano" runat="server" BackColor="Silver" CellPadding="5" CellSpacing="5"></asp:GridView>
                </div>
            </td>
            <td>
                <div class="container">
                    <div id="V3" style="margin-top: 10px;" class="mainbox">
                        <div class="panel panel-info">
                            <div class="panel-heading">
                                <div class="panel-title">Mantenimiento de Estilos</div>
                            </div>
                            <div style="padding-top: 30px" class="panel-body">
                                <table cellspacing="3" cellpadding="2">
                                    <tr>
                                        <td>
                                            <asp:Label ID="Lbestiloeli" runat="server" Text="Estilo:"></asp:Label></td>
                                        <td>
                                            <asp:TextBox ID="Txteliestilo" runat="server" CssClass="form-control"></asp:TextBox></td>
                                        <td>
                                            <asp:Button ID="BtnEliestilo" runat="server" Text="Eliminar Estilo" CssClass="btn btn-primary" OnClick="BtnEliestilo_Click" /></td>
                                        <tr>
                                </table>

                                <br />
                                <h4>Ingreso</h4>
                                <table cellspacing="3" cellpadding="2">
                                    <tr>
                                        <td>
                                            <asp:Label ID="Lbestilo" runat="server" Text="Estilo: "></asp:Label></td>
                                        <td>
                                            <asp:TextBox ID="Txtestilo" runat="server" CssClass="form-control"></asp:TextBox></td>
                                        <td>
                                            <asp:Button ID="BtnAceptarest" runat="server" Text="Aceptar" CssClass="btn btn-success" OnClick="BtnAceptarest_Click" /></td>
                                    </tr>
                                </table>
                            </div>
                        </div>
                    </div>
                </div>
                <div align="center">
                    <asp:GridView ID="Gbgestilo" runat="server" BackColor="Silver" CellPadding="5" CellSpacing="5"></asp:GridView>
                </div>
            </td>
        </tr>
    </table>


</asp:Content>
