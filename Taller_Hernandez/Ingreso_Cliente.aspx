<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Ingreso_Cliente.aspx.cs" Inherits="Taller_Hernandez.Ingreso_Cliente" %>

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
                    <div class="panel-title">Datos del Cliente</div>
                </div>
                <div style="padding-top: 30px" class="panel-body">
                    <%--  <table class="form-horizontal">--%>
                    <table cellspacing="3" cellpadding="2">
                        <tr>
                            <td><asp:Label ID="LbBuscar" runat="server" Text="Buscar por Cedula: "></asp:Label></td>
                            <td><asp:TextBox ID="TxtBuscarCedula" runat="server" CssClass="form-control"></asp:TextBox></td>
                            <td><asp:Button ID="BtnBuscarAuto" runat="server" Text="Buscar" CssClass="btn btn-primary" OnClick="BtnBuscarCliente_Click" /></td>
                            <td><asp:Button ID="BtnEliminar" runat="server" Text="Eliminar" CssClass="btn btn-danger" OnClick="BtnEliminar_Click" /></td>
                            </tr>
                    </table>
                    <br />
                    <h3>Ingrese Información General:</h3>
                    <table cellspacing="3" cellpadding="2">
                        <tr>
                            <td><asp:Label ID="LbNCliente" runat="server" Text="Nombre Cliente:"></asp:Label></td>
                            <td><asp:TextBox ID="TxtNCliente" runat="server" CssClass="form-control"></asp:TextBox></td>
                        </tr>
                        <tr>
                            <td><asp:Label ID="LbApellido" runat="server" Text="Apellido Cliente:"></asp:Label></td>
                            <td><asp:TextBox ID="TxtApellido" runat="server" CssClass="form-control"></asp:TextBox></td>
                        </tr>
                        <tr>
                            <td><asp:Label ID="LbCedula" runat="server" Text="Cedula.......:"></asp:Label></td>
                            <td><asp:TextBox ID="TxtCedula" runat="server" CssClass="form-control" TextMode="Number"></asp:TextBox></td>
                        </tr>
                        <tr>
                            <td><asp:Label ID="LbTelefono" runat="server" Text="Telefono......:"></asp:Label></td>
                            <td><asp:TextBox ID="TxtTelefono" runat="server" CssClass="form-control" TextMode="Number"></asp:TextBox></td>
                        </tr>
                        <tr>
                            <td><asp:Label ID="LbMovil" runat="server" Text="Movil........:"></asp:Label></td>
                            <td><asp:TextBox ID="TxtMovil" runat="server" CssClass="form-control" TextMode="Number"></asp:TextBox></td>
                        </tr>
                        <tr>
                            <td><asp:Label ID="LbCorreo" runat="server" Text="Correo........:"></asp:Label></td>
                            <td><asp:TextBox ID="TxtCorreo" runat="server" CssClass="form-control" TextMode="Email"></asp:TextBox></td>
                        </tr>
                        <tr>
                            <td><asp:Label ID="LbNota" runat="server" Text="Nota.........:"></asp:Label></td>
                            <td><asp:TextBox ID="TxtNota" runat="server" CssClass="form-control"></asp:TextBox></td>
                        </tr>
                        <tr>
                            <td><asp:Button ID="BtnCliente" runat="server" Text="Aceptar" CssClass="btn btn-success" OnClick="BtnCliente_Click" /></td>
                            <td><asp:Button ID="BtnAct" runat="server" Text="Actualizar" CssClass="btn btn-primary" OnClick="BtnAct_Click" /></td>
                            <td><asp:Button ID="BtnAgendar" runat="server" Text="Agendar" CssClass="btn btn-primary" OnClick="BtnAgendar_Click" /></td>
                        </tr>
                    </table>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
