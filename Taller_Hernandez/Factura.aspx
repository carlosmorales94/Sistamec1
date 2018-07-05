<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Factura.aspx.cs" Inherits="Taller_Hernandez.Factura" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
     <br>
        <div class="alert alert-success" visible="false" id="mensaje" runat="server">
        <a href="#" class="close" data-dismiss="alert" aria-label="close">&times;</a>
        <strong id="textoMensaje" runat="server"></strong>
    </div>
    <div class="alert alert-danger" visible="false" id="mensajeError" runat="server">
        <a href="#" class="close" data-dismiss="alert" aria-label="close">&times;</a>
        <strong id="textoMensajeError" runat="server"></strong>
         <br>
    </div>
        <div class="container">
        <div id="loginbox" style="margin-top: 50px;" class="mainbox col-md-6 col-md-offset-3 col-sm-8 col-sm-offset-2">
            <div class="panel panel-info">
                <div class="panel-heading">
                    <div class="panel-title">Factura Taller Hernandez </div>
                </div>
                <div style="padding-top: 30px" class="panel-body">
                    <div class="form-horizontal">   
 <table cellspacing="3" cellpadding="2" >
   <tr>
    <td><asp:Label ID="LbBPlaca" runat="server" Text="Placa:"></asp:Label></td>
    <td><asp:TextBox ID="txtBuscarPlaca" runat="server"></asp:TextBox></td>
   <td><asp:Button ID="BtnBuscar" runat="server" Text="Buscar" CssClass="btn btn-primary" OnClick="BtnBuscar_Click"/></td>
    </table>
 <table cellspacing="3" cellpadding="2" >


    <tr>    
     <td><asp:Label ID="LbNomClie" runat="server" Text="Nombre Cliente:"></asp:Label></td>
    <td> <asp:TextBox ID="TxtNombreCliente" runat="server"></asp:TextBox></td>
        </tr>
      <tr>
    <td><asp:Label ID="LbNumFac" runat="server" Text="Num.Factura"></asp:Label></td>
<td>    <asp:TextBox ID="Txtfec" runat="server"></asp:TextBox></td>
        </tr>
   <tr>      
     <td><asp:Label ID="LbMovil" runat="server" Text="Movil"></asp:Label></td>
      <td> <asp:TextBox ID="LbRMovil" runat="server"></asp:TextBox></td>
       </tr>
   <tr>
     <td><asp:Label ID="LbCedula" runat="server" Text="Cedula"></asp:Label></td>
        <td> <asp:TextBox ID="LbRCedula" runat="server"></asp:TextBox></td>
       </tr>
    <tr>
     <td><asp:Label ID="LbMarca" runat="server" Text="Marca:"></asp:Label></td>
        <td> <asp:TextBox ID="LbRMarca" runat="server"></asp:TextBox></td>
        </tr>
   <tr>
    <td> <asp:Label ID="LbKm" runat="server" Text="Kilometraje"></asp:Label></td>
        <td> <asp:TextBox ID="LbRKm" runat="server"></asp:TextBox></td>
       </tr>
   <tr>
     <td><asp:Label ID="LbPlaca" runat="server" Text="Placa"></asp:Label></td>
        <td> <asp:TextBox ID="LbRPlaca" runat="server"></asp:TextBox></td>
       </tr>
  <tr>
    <td> <asp:Label ID="LbCorreo" runat="server" Text="Correo:"></asp:Label></td>
       <td> <asp:TextBox ID="LbRCorreo" runat="server"></asp:TextBox></td>
   </tr>
        <br>
    <table cellspacing="3" cellpadding="2" border="1" >

   <tr>
       <td>  <asp:Label ID="Label1" runat="server" Text="Cantidad"></asp:Label> </td>
       <td>  <asp:Label ID="Label3" runat="server" Text="Descripcion"></asp:Label> </td>
       <td> <asp:Label ID="Label4" runat="server" Text="Valor"></asp:Label></td>
   </tr>

   <tr>
       <td >  <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox></td>
       <td >  <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox></td>
       <td>   <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox> </td>
   </tr>
          <tr>
       <td >  <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox></td>
       <td >  <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox></td>
       <td>   <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox> </td>
   </tr>
          <tr>
       <td >  <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox></td>
       <td >  <asp:TextBox ID="TextBox8" runat="server"></asp:TextBox></td>
       <td>   <asp:TextBox ID="TextBox9" runat="server"></asp:TextBox> </td>
   </tr>
          <tr>
       <td >  <asp:TextBox ID="TextBox10" runat="server"></asp:TextBox></td>
       <td >  <asp:TextBox ID="TextBox11" runat="server"></asp:TextBox></td>
       <td>   <asp:TextBox ID="TextBox12" runat="server"></asp:TextBox> </td>
   </tr>
          <tr>
       <td >  <asp:TextBox ID="TextBox13" runat="server"></asp:TextBox></td>
       <td >  <asp:TextBox ID="TextBox14" runat="server"></asp:TextBox></td>
       <td>   <asp:TextBox ID="TextBox15" runat="server"></asp:TextBox> </td>
   </tr>
          <tr>
       <td >  <asp:TextBox ID="TextBox16" runat="server"></asp:TextBox></td>
       <td >  <asp:TextBox ID="TextBox17" runat="server"></asp:TextBox></td>
       <td>   <asp:TextBox ID="TextBox18" runat="server"></asp:TextBox> </td>
   </tr>
          <tr>
       <td >  <asp:TextBox ID="TextBox19" runat="server"></asp:TextBox></td>
       <td >  <asp:TextBox ID="TextBox20" runat="server"></asp:TextBox></td>
       <td>   <asp:TextBox ID="TextBox21" runat="server"></asp:TextBox> </td>
   </tr>
          <tr>
       <td >  <asp:TextBox ID="TextBox22" runat="server"></asp:TextBox></td>
       <td >  <asp:TextBox ID="TextBox23" runat="server"></asp:TextBox></td>
       <td>   <asp:TextBox ID="TextBox24" runat="server"></asp:TextBox> </td>
   </tr>
          <tr>
       <td >  <asp:TextBox ID="TextBox25" runat="server"></asp:TextBox></td>
       <td >  <asp:TextBox ID="TextBox26" runat="server"></asp:TextBox></td>
       <td>   <asp:TextBox ID="TextBox27" runat="server"></asp:TextBox> </td>
   </tr>
          <tr>
       <td >  <asp:TextBox ID="TextBox28" runat="server"></asp:TextBox></td>
       <td >  <asp:TextBox ID="TextBox29" runat="server"></asp:TextBox></td>
       <td>   <asp:TextBox ID="TextBox30" runat="server"></asp:TextBox> </td>
   </tr>
       <tr>
       <td >  </td>
       <td> <asp:Label ID="Label2" runat="server" Text="Total: "></asp:Label></td>
       <td>   <asp:TextBox ID="TextBox33" runat="server"></asp:TextBox> </td>
   </tr>
</table>
      <br> 
     <asp:Label ID="LbNota" runat="server" Text="Nota:"></asp:Label>
     <asp:TextBox ID="TextBox31" runat="server"></asp:TextBox>
    <br>
      <br>
    <asp:Button ID="BtnTerminar" runat="server" CssClass="btn btn-primary" Text="Terminar" OnClick="BtnTerminar_Click"/>
      <asp:Button ID="BtnSuma" runat="server" CssClass="btn btn-primary" Text="Suma" OnClick="BtnSuma_Click"/>
     <br>
     </div>
    </div>                      
         </div>
                </div>
            </div>
</asp:Content>
