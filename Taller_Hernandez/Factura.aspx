<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Factura.aspx.cs" Inherits="Taller_Hernandez.Factura" %>


<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <script src="Scripts/example.js"></script>
    <script src="Scripts/jquery-1.3.2.min.js"></script>
    <link href="Style/print.css" rel="stylesheet" />
    <link href="Style/style.css" rel="stylesheet" />
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
    <!--BEGIN:Prueba con dynamic row-->
        <div class="container">
        <div class="row">
            <div class="col-xs-12">
                <div class="row">
                    <div class="col-xs-6">
                        <asp:Button ID="Btn_facelec" runat="server" Text="Factura Electronica" CssClass="btn btn-secondary" OnClick="Btn_facelec_Click" />
                    </div>
                    <div class="col-xs-6 text-right">
                        <td>
                            <asp:Label ID="LbBPlaca" runat="server" Text="Placa:"></asp:Label></td>
                        <td>
                            <asp:DropDownList ID="drpBuscarPlaca" runat="server"></asp:DropDownList>
                        </td>
                        <td>
                            <asp:Button ID="BtnBuscar" runat="server" Text="Buscar" CssClass="btn btn-secondary" OnClick="BtnBuscar_Click" /></td>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <hr>
        <div class="container">
        <div class="row">
            <div class="col-xs-12">
                <div class="row">
                    <div class="col-xs-6">
                        <h2>Factura Taller Hernandez</h2>
                    </div>
                    <div class="col-xs-6 text-right">
                        <h3>
                            <asp:Label ID="LbNumFac" runat="server" Text="Factura #:"></asp:Label>
                            <asp:Label ID="Txtfec" runat="server" Text="0"></asp:Label></h3>
                    </div>
                </div>
                <hr>
                <div class="row">
                    <div class="col-xs-6 text-right">
                        <address>
                            <strong>Informacion del Cliente:</strong><br />
                                <asp:Label ID="LbNomClie" runat="server" Text="Nombre Cliente:"></asp:Label>
                                <asp:TextBox ID="TxtNombreCliente" runat="server"></asp:TextBox><br />
                                <asp:Label ID="LbCedula" runat="server" Text="Identificacion:"></asp:Label>
                                <asp:TextBox ID="LbRCedula" runat="server"></asp:TextBox><br />
                                <asp:Label ID="LbCorreo" runat="server" Text="Correo:"></asp:Label>
                                <asp:TextBox ID="LbRCorreo" runat="server"></asp:TextBox><br />
                                <asp:Label ID="LbMovil" runat="server" Text="Telefono:"></asp:Label>
                                <asp:TextBox ID="LbRMovil" runat="server"></asp:TextBox><br />
                        </address>
                    </div>
                    <div class="col-xs-6 text-right">
                        <address>
                            <strong>Informacion del Vehiculo:</strong><br />
                            <asp:Label ID="LbMarca" runat="server" Text="Marca:"></asp:Label>
                            <asp:TextBox ID="LbRMarca" runat="server"></asp:TextBox><br />
                            <asp:Label ID="LbKm" runat="server" Text="Kilometraje:"></asp:Label>
                            <asp:TextBox ID="LbRKm" runat="server"></asp:TextBox><br />
                            <asp:Label ID="LbPlaca" runat="server" Text="Placa:"></asp:Label>
                            <asp:TextBox ID="LbRPlaca" runat="server"></asp:TextBox><br />
                        </address>
                        <td class="meta-head">Fecha: </td>
                        <td><textarea id="date"></textarea></td><br />
                    </div>
                </div>
            </div>
        </div>    
        <div class="row">
            <div class="col-md-12">
                <div class="panel panel-default">
                    <div class="panel-heading">
                        <h3 class="panel-title"><strong>Detalles de la Factura</strong></h3>
                    </div>
                    <div class="panel-body">
                        <div class="table-responsive">
                            <table class="table table-condensed" id="items" border="0">
                                <tr>
                                    <th>Tipo</th>
                                    <th>#Producto/Servicio</th>
                                    <th>Descripcion</th>
                                    <th>Precio Unitario ₡</th>
                                    <th>Cantidad</th>
                                    <th>Precio Total ₡</th>
                                </tr>

                                <tr class="item-row">
                                    <td class="Tipo">
                                        <div class="delete-wpr">
                                        <select>
                                            <option value="reparacion">Reparaciones</option>
                                            <option value="rep-stock">Repuestos Stock</option>
                                            <option value="rep-pedido">Repuestos por Pedido</option>
                                        </select><a class="delete" href="javascript:;" title="Remove row">X</a>
                                    </td>
                                    <td class="item-name">
                                            <asp:Label id="codigo" runat="server">1000</asp:Label>
                                    </td>
                                    <td class="description">
                                        <select>
                                            <option value="reparacion">Reparaciones</option>
                                            <option value="rep-stock">Repuestos Stock</option>
                                            <option value="rep-pedido">Repuestos por Pedido</option>
                                        </select>
                                    </td>
                                    <td>
                                        <textarea class="cost">0</textarea></td>
                                    <td>
                                        <textarea id="cant-1" class="qty">0</textarea></td>
                                    <td><span class="price">0</span></td>
                                </tr>

                                <tr id="item-row">
                                    <td colspan="6"><a id="addrow" href="javascript:;" title="Add a row">Agregar Fila</a></td>
                                </tr>

                                <tr>
                                    <td colspan="2" class="blank"></td>
                                    <td colspan="2" class="blank"></td>
                                    <td colspan="1" class="total-line">Subtotal ₡ </td>
                                    <td class="total-value">
                                        <div id="subtotal">0</div>
                                    </td>
                                </tr>
                                <tr>
                                    <td colspan="2" class="blank"></td>
                                    <td colspan="2" class="blank"></td>
                                    <td colspan="1" class="total-line">Total ₡ </td>
                                    <td class="total-value">
                                        <div id="total">0</div>
                                    </td>
                                </tr>
                            </table>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <!--END:Prueba con dynamic row-->

    <br>
    <asp:Button ID="BtnTerminar" runat="server" CssClass="btn btn-primary" Text="Terminar" OnClick="BtnTerminar_Click" />
    <br>
</asp:Content>
