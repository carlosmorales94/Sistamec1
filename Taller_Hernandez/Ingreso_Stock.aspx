<%@ Page Title="Ingreso_Stock" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Ingreso_Stock.aspx.cs" Inherits="Taller_Hernandez.UI.Ingreso_Stock" %>

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
               <div class="panel-title">Stock</div>
                 </div>
              <div style="padding-top: 30px" class="panel-body">
                  <div class="form-horizontal">
                <div >  
          <table cellspacing="3" cellpadding="2" >
   <tr>
       <td><asp:Label ID="LbBuscar" runat="server" Text="Buscar por ID Producto:" ></asp:Label></td>
       <td> <asp:TextBox ID="TxtBusIdPro" runat="server" CssClass="form-control" TextMode="Number"></asp:TextBox></td>
       <td> <asp:Button ID="BtnBuscar" runat="server" Text="Buscar" CssClass="btn btn-primary" OnClick="BtnBuscar_Click" /> </td>                    
        <td><asp:Button ID="BtnEliminar" runat="server" Text="Eliminar" CssClass="btn btn-danger" OnClick="BtnEliminar_Click" /></td>
            </tr>
            </table >
        </div>
         <br />
         <table cellspacing="3" cellpadding="2" >
   <tr>
       <td><h4>Ingreso de producto</h4>
           </tr>
              <tr>
     <td>   <asp:Label ID="LbDescripcion" runat="server" Text="Descripción"></asp:Label></td>
    <td>    <asp:TextBox ID="TxtDesPro" runat="server" CssClass="form-control"></asp:TextBox></td>
        </tr>
              <tr>
     <td>   <asp:Label ID="LbCantidad" runat="server" Text="Cantidad"></asp:Label></td>
     <td>   <asp:TextBox ID="TxtCanPro" runat="server" CssClass="form-control" TextMode="Number"></asp:TextBox></td>
    </tr>
              <tr>
      <td>  <asp:Label ID="LbPrecio" runat="server" Text="Precio"></asp:Label></td>
      <td>  <asp:TextBox ID="TxtPrePro" runat="server" CssClass="form-control" TextMode="Number"></asp:TextBox></td>
    </tr>
              <tr>
      <td>  <asp:Label ID="IdProducto" runat="server" Text="IdProducto"></asp:Label></td>
     <td>   <asp:TextBox ID="txtIdPro" runat="server" CssClass="form-control"></asp:TextBox></td>
         </tr>
<tr>        
       <td> <asp:Button ID="BtnProducto" runat="server" Text="Agregar" CssClass="btn btn-success" OnClick="BtnProducto_Click" /></td>
       <td> <asp:Button ID="BtnModificar" runat="server" Text="Modificar" CssClass="btn btn-warning" OnClick="BtnModificar_Click" /></td>
     </tr>
         </table >
         </div>
        </div>
         </div>                      
            </div>
           </div>
          
       
                
</asp:Content>
