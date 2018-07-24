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
                <td>
                    <h4>Fecha:</h4>
                </td>
                <td>
                    <asp:DropDownList ID="ClFechas" runat="server"></asp:DropDownList></td>
                <td>
                    <asp:Button ID="BtnBuscar" runat="server" Text="Buscar" CssClass="btn btn-success" OnClick="BtnBuscar_Click" /></td>
            </tr>
        </table>
    </div>
    <br>
    <div class="container">
        <div id="loginbox" style="margin-top: 10px;" class="mainbox col-md-6 col-md-offset-3 col-sm-8 col-sm-offset-2">
            <div class="panel panel-info">
                <div class="panel-heading">
                    <div class="panel-title">Citas</div>
                </div>
                <div style="padding-top: 10px" class="panel-body">
                    <div class="form-Vetical">

                        <div class="form-group">
                            <table align="center">
                                <tr>
                                    <td>Estado
                                    </td>
                                    <td>Cedula
                                    </td>
                                    <td>Fecha de ingreso
                                    </td>
                                    <td>Kilometros
                                    </td>
                                    <td>Marca
                                    </td>
                                    <td>Daños
                                    </td>
                                    <td>Placa
                                    </td>
                                    <td>Editar
                                    </td>
                                </tr>
                            </table>

                            <asp:ListView ID="lvProductos" runat="server"
                                GroupItemCount="1"
                                ItemType="TallerH.DATA.Cita" DataKeyNames="FechaIngreso">

                                <EmptyDataTemplate>
                                    <table>
                                        <tr>
                                            <td>No data was returned.</td>
                                        </tr>
                                    </table>
                                </EmptyDataTemplate>
                                <%--            <EmptyItemTemplate>
                <td />
            </EmptyItemTemplate>--%>
                                <GroupTemplate>
                                    <tr id="itemPlaceholderContainer" runat="server">
                                        <td id="itemPlaceholder" runat="server"></td>
                                    </tr>
                                </GroupTemplate>
                                <ItemTemplate>
                                    <td runat="server">
                                        <table align="center">
                                            <%--                           <tr>
                            <td>
                               Cedula
                            </td>
                            <td>
                               Fecha de ingreso
                            </td>
                             <td>
                               Kilometros
                            </td>
                             <td>
                               Marca
                            </td>
                                  <td>
                               Daños
                            </td>
                                  <td>
                               Placa
                            </td>
                        </tr>--%>
                                            <tr>
                                                <td>
                                                    <asp:Button ID="Btnllegado" runat="server" Text="Llegado" OnClick="Btnllegado_Click" />
                                                </td>
                                                <td>
                                                    <%#: Item.Cedula %>
                                                </td>
                                                <td>
                                                    <%#: Item.FechaIngreso %>
                                                </td>
                                                <td>
                                                    <%#: Item.KM %>
                                                </td>
                                                <td>
                                                    <%#: Item.Marca %>
                                                </td>
                                                <td>
                                                    <%#: Item.ProVeh %>
                                                </td>
                                                <td>
                                                    <%#: Item.Placa %>
                                                </td>
                                                <td>
                                                    <asp:Button ID="Btneditar" runat="server" Text="Edit" />
                                                </td>
                                            </tr>
                                        </table>
                                        </p>
                                    </td>
                                </ItemTemplate>
                                <LayoutTemplate>
                                    <table style="width: 100%;">
                                        <tbody>
                                            <tr>
                                                <td>
                                                    <table id="groupPlaceholderContainer" runat="server" style="width: 100%">
                                                        <tr id="groupPlaceholder"></tr>
                                                    </table>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td></td>
                                            </tr>
                                            <tr></tr>
                                        </tbody>
                                    </table>
                                </LayoutTemplate>
                            </asp:ListView>
                        </div>


                        <%--<asp:GridView ID="GvCitas" runat="server"></asp:GridView>--%>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
