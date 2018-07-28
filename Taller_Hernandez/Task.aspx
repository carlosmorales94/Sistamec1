<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Task.aspx.cs" Inherits="Taller_Hernandez.Task" %>


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
                    <div class="panel-title">Mantenimiento de tareas</div>
                </div>
                <div style="padding-top: 30px" class="panel-body">
                    <table cellspacing="3" cellpadding="2">
                        <tr>
                            <td>
                                <asp:Label ID="LbBuscartarea" runat="server" Text="Nombre de tarea:"></asp:Label></td>
                            <td>
                                <asp:TextBox ID="TxtCodTarea" runat="server" CssClass="form-control"></asp:TextBox></td>
                            <td>
                                <asp:Button ID="BtnEliminar" runat="server" Text="Eliminar" CssClass="btn btn-primary" OnClick="BtnEliminar_Click" /></td>
                            <tr>
                    </table>

                    <br />
                    <h3>Ingreso de tareas</h3>
                    <table cellspacing="3" cellpadding="2">
                        <tr>
                            <td>
                                <asp:Label ID="LbNTarea" runat="server" Text="Tarea: "></asp:Label></td>
                            <td>
                                <asp:TextBox ID="TxtTarea" runat="server" CssClass="form-control"></asp:TextBox></td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Button ID="BtnAceptar" runat="server" Text="Aceptar" CssClass="btn btn-success" OnClick="BtnAceptar_Click" /></td>

                        </tr>
                    </table>
                </div>
            </div>
        </div>
    </div>
             <div align="center"> 
        <asp:GridView ID="Ggvtareas" runat="server" BackColor="Silver" CellPadding="5" CellSpacing="5"></asp:GridView> 
    </div>
</asp:Content>
