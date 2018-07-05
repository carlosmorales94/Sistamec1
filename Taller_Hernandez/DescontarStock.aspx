<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DescontarStock.aspx.cs" Inherits="Taller_Hernandez.DescontarStock" %>
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
    <div class="container">
        <div id="loginbox" style="margin-top: 50px;" class="mainbox col-md-6 col-md-offset-3 col-sm-8 col-sm-offset-2">
            <div class="panel panel-info">
                <div class="panel-heading">
                    <div class="panel-title">Salida de Stock</div>
                </div>
                <div style="padding-top: 30px" class="panel-body">
                    <div class="form-horizontal">      
  <div class="form-group">
        <asp:ListView ID="lvProductos" runat="server"
            GroupItemCount="3"
            ItemType="TallerH.DATA.Producto" DataKeyNames="IdProducto">
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
                               ID:
                            </td>
                            <td>
                               Descripción
                            </td>
                             <td>
                               Cantidad
                            </td>
                             <td>
                               Precio
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <%#: Item.IdProducto %>
                            </td>
                            <td>
                                <%#: Item.Descripcion %>
                            </td>
                              <td>
                                <%#: Item.Cantidad %>
                            </td>
                             <td>
                                <%#: Item.Precio %>
                            </td>
                        </tr>                  
       <tr>
       <td> <asp:Label ID="Lbcant" runat="server" Text="Cantidad:"></asp:Label> </td>
       <td> <asp:TextBox ID="TxtcantS" runat="server" placeholder="Cantidad" CssClass="form-control" OnTextChanged="TxtcantS_TextChanged"></asp:TextBox></td>
      </tr>
       <tr>
       <td> <asp:Label ID="Placa" runat="server" Text="Placa:"></asp:Label> </td>
       <td> <asp:TextBox ID="txtPlacaS" runat="server" CssClass="form-control" OnTextChanged="txtPlacaS_TextChanged" ></asp:TextBox> </td>
    </tr>
   <tr>
       <td> <asp:Button ID="BtnSacar" runat="server" Text="Sacar de Stock" CssClass="btn btn-danger" OnClick="BtnSacar_Click" CommandArgument="<%# Item.IdProducto %>"/> </td>
        <td> <asp:Button ID="BtnFactura" runat="server" Text="Facturar" CssClass="btn btn-danger" OnClick="BtnFactura_Click" CommandArgument="<%# Item.IdProducto %>"/> </td>
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
