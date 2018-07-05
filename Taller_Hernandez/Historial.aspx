<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Historial.aspx.cs" Inherits="Taller_Hernandez.Historial" %>

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
     <div class="form-inline" >
        <h3>Categorias</h3>
    <asp:Calendar ID="ClFechas" runat="server"></asp:Calendar>
     <asp:Button ID="BtnBuscar" runat="server" Text="Buscar" CssClass="btn btn-success" OnClick="BtnBuscar_Click" />
    </div>
    <br>
    <div class="container">
        <div id="loginbox" style="margin-top: 50px;" class="mainbox col-md-6 col-md-offset-3 col-sm-8 col-sm-offset-2">
            <div class="panel panel-info">
                <div class="panel-heading">
                    <div class="panel-title">Salida de Stock</div>
                </div>
                <div style="padding-top: 30px" class="panel-body">
                    <div class="form-Vetical">      
  <div class="form-group">
        <asp:ListView ID="lvProductos" runat="server"
            GroupItemCount="3"
            ItemType="TallerH.DATA.Cita" DataKeyNames="Placa">
            <EmptyDataTemplate> 
                 <table>
                    <tr>
                        <td>No data was returned.</td>
                    </tr>
                </table>
            </EmptyDataTemplate>
            <EmptyItemTemplate>
                <td />
            </EmptyItemTemplate>
            <GroupTemplate>
                <tr id="itemPlaceholderContainer" runat="server">
                    <td id="itemPlaceholder" runat="server"></td>
                </tr>
            </GroupTemplate>
            <ItemTemplate>
                <td runat="server">
                    <table align="center">
                           <tr>
                            <td>
                               Nombre Cliente
                            </td>
                            <td>
                               Movil
                            </td>
                             <td>
                               Correo
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
                        </tr>
                        <tr>
                            <td>
                                <%#: Item.NombreCliente %>
                            </td>
                            <td>
                                <%#: Item.Movil %>
                            </td>
                              <td>
                                <%#: Item.Correo %>
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
                    </div>
                        </div>                      
                    </div>
                </div>
            </div>  


</asp:Content>
