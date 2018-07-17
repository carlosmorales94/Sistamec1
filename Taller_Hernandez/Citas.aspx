<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Citas.aspx.cs" Inherits="Taller_Hernandez.Citas" %>

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
    <br>
    <div class="container">
        <div id="loginbox" style="margin-top: 50px;" class="mainbox col-md-6 col-md-offset-3 col-sm-8 col-sm-offset-2">
            <div class="panel panel-info">
                <div class="panel-heading">
                    <div class="panel-title">Ingrese la cita</div>
                </div>
                <div style="padding-top: 30px" class="panel-body">
                    <div class="form-horizontal">
                        <table cellspacing="10" cellpadding="2">
                            <tr>
                                <td>
                                    <asp:Label ID="LbMarca" runat="server" Text="Marca:"></asp:Label></td>
                                <td>
                                    <asp:DropDownList ID="DrpMarca" runat="server"></asp:DropDownList></td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label ID="LbPlaca" runat="server" Text="Placa:"></asp:Label></td>
                                <td>
                                    <asp:TextBox ID="TxtPlaca" runat="server" CssClass="form-control"></asp:TextBox></td>
                            </tr>


                            <tr>
                                <td>
                                    <asp:Label ID="lbEstilo" runat="server" Text="Movil:"></asp:Label></td>
                                <td>
                                    <asp:DropDownList ID="DrpEstilo" runat="server"></asp:DropDownList></td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label ID="LbBin" runat="server" Text="Bin:"></asp:Label></td>
                                <td>
                                    <asp:TextBox ID="TxtBin" runat="server" CssClass="form-control"></asp:TextBox></td>
                            </tr>
                             <tr>
                                <td>
                                    <asp:Label ID="Lbano" runat="server" Text="Año:"></asp:Label></td>
                                <td>
                                    <asp:DropDownList ID="Drpano" runat="server"></asp:DropDownList></td>
                            </tr>
                             <tr>
                                <td>
                                    <asp:Label ID="LbKM" runat="server" Text="Kilometraje:"></asp:Label></td>
                                <td>
                                    <asp:TextBox ID="TxtKM" runat="server" CssClass="form-control"></asp:TextBox></td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label ID="LbProVeh" runat="server" Text="Problemas del Vehiculo:"></asp:Label></td>
                                <td>
                                    <asp:TextBox ID="TxtPro" runat="server" CssClass="form-control" TextMode="MultiLine"></asp:TextBox></td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label ID="LbFecha" runat="server" Text="Fecha de la Cita:"></asp:Label></td>
                                <td>
                                    <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Button ID="BtnAgendar" runat="server" Text="Agendar" OnClick="BtnAgendar_Click" /></td>
                            </tr>
                        </table>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
