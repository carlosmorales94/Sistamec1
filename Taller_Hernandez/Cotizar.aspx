<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Cotizar.aspx.cs" Inherits="Taller_Hernandez.Cotizar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
        <div class="alert alert-danger" visible="false" id="mensajeError" runat="server">
        <a href="#" class="close" data-dismiss="alert" aria-label="close">&times;</a>
        <strong id="textoMensajeError" runat="server"></strong>
    </div>
        <div id="info-correo">
                <div class="container">
      <div id="loginbox" style="margin-top: 50px;" class="mainbox col-md-6 col-md-offset-3 col-sm-8 col-sm-offset-2 ">
            <div class="panel panel-info">
                <div class="panel-heading">
                    <div class="panel-title">Cotización del auto</div>
                </div>
                <div style="padding-top: 30px" class="panel-body">
                    <div class="form-horizontal">   
        <br />
      <table cellspacing="3" cellpadding="2">
      <tr>
    <td style="width: 34px"><asp:Label ID="Label1" runat="server" Text="Destinatario:"></asp:Label>   </td>
    <td style="width: 641px"><asp:TextBox ID="txtDestinatario" runat="server" placeholder="Destinatario" CssClass="form-control" TextMode="Email" Width="1046px"></asp:TextBox></td>
           </tr>
   <tr> 
         <td style="width: 34px"><asp:Label ID="Label2" runat="server" Text="Motivo:"></asp:Label>   </td>
    <td style="width: 641px"><asp:TextBox ID="txtAsunto" runat="server" placeholder="Asunto" Width="1046px" CssClass="form-control"></asp:TextBox></td>
        </tr>
    <tr> 
        <td style="width: 34px"> <asp:Label ID="Label3" runat="server" Text="Cotización:"></asp:Label>   </td>
    <td style="width: 641px"><asp:TextBox ID="txtCuerpo" runat="server" placeholder="Cuerpo" Width="1046px" TextMode="MultiLine"  CssClass="form-control" ></asp:TextBox></td>
 </tr>
 <tr> 
    <td style="width: 34px"><asp:Button ID="btnEnviar" runat="server" Text="Enviar" CssClass="btn btn-success" class="btn btn-default btn-sm" OnClick="btnEnviar_Click" />
     </td>
      </tr>
      <tr> 
    <asp:Label ID="lblSent" runat="server" Text=""></asp:Label>
            </tr>
             </table>  
    </div>
     </div>
                        </div>                      
                    </div>
                </div>
            </div>
</asp:Content>
