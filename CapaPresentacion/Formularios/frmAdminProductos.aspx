<%@ Page Title="" Language="C#" MasterPageFile="~/Formularios/frmMenu.Master" AutoEventWireup="true" CodeBehind="frmAdminProductos.aspx.cs" Inherits="SistemaFarmaciaWeb.Formularios.frmAdminMedicamentos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section class="content-header">
        <h1 style="text-align:center">Registro de Productos</h1>
    </section>
    <section class="content">
        <div class="row">

            <div class="col-md-12">
                <!--Columna mediana de 6(mitad de pantalla) xq para full screen es 12-->
                <div class="box box-primary">
                    <!--'primary is for color blue-->
                    <div class="box-body">
                        <div class="form-group">
                            <label>CODIGO</label>
                        </div>
                        <div class="form-group">
                            <asp:TextBox ID="txtIdProducto" runat="server" placeholder="Digite el codigo..." CssClass="form-control" MaxLength="8" onkeypress="if(event.keyCode<48 || event.keyCode>57)event.returnValue=false;"> </asp:TextBox>
                        </div>

                        <div class="form-group">
                            <label>NOMBRE</label>
                        </div>
                        <div class="form-group">
                            <asp:TextBox ID="txtNombre" runat="server" placeholder="Digite el nombre..." CssClass="form-control"></asp:TextBox>
                        </div>

                        <div class="form-group">
                            <label>PRECIO</label>
                        </div>
                        <div class="form-group">
                            <asp:TextBox ID="txtPrecio" runat="server" placeholder="Digite su precio..." CssClass="form-control"></asp:TextBox>
                        </div>

                        <div class="form-group">
                            <label>CANTIDAD DE STOCK</label>
                        </div>
                        <div class="form-group">
                            <asp:TextBox ID="txtCantidad" runat="server" placeholder="Digite la cantidad" CssClass="form-control" MaxLength="8" onkeypress="if(event.keyCode<48 || event.keyCode>57)event.returnValue=false;"></asp:TextBox>
                            <%--<asp:CompareValidator runat="server" Operator="DataTypeCheck" Type="Integer" ControlToValidate="ValueTextBox" ErrorMessage="Value must be a whole number" />--%>
                        </div>

                        <div class="form-group">
                            <label>CATEGORIA</label>
                        </div>
                        <div class="form-group">
                            <asp:DropDownList ID="ddlCategoria" runat="server" CssClass="form-control">
                            </asp:DropDownList>

                        </div>
                    </div>
                </div>

            </div>

        </div>
        <!--Buttons part--->
        <div align="center">
            <table>
                <tr>
                    <td>
                        <asp:Button ID="btnGuardarEditar" runat="server" CssClass="btn-primary" Width="200px" Text="Guardar Cambios" OnClick="btnGuardarEditar_Click" />
                    </td>
                    <td>&nbsp;&nbsp;&nbsp;&nbsp;</td>
                    <td>
                        <asp:Button ID="btnRegistrar" runat="server" CssClass="btn-primary" Width="200px" Text="Registrar" OnClick="btnRegistrar_Click" />
                    </td>
                    <td>&nbsp;&nbsp;&nbsp;&nbsp;</td>
                    <!--ESPACE BETTWEN BUTTONS-->
                    <td>
                        <asp:Button ID="btnCancelar" runat="server" CssClass="btn-danger" Width="200px" Text="Cancelar" OnClick="btnCancelar_Click" />
                    </td>
                </tr>
            </table>
            <asp:Label ID="lblerror" runat="server" Text="Label"></asp:Label>
        </div>
        <br />

        <!--DatatablePart--->
        <div class="row">
            <div class="col-xs-12">
                <div class="box box-primary">
                    <div class="box-header">
                        <h3 class="box-title">Lista de Productos</h3>
                    </div>
                    <div class="box-body table-responsive">
                        <%--<table id="tbl_medicamentos" class="table table-bordered">
                            <thead>
                                <tr>
                                    <th>Codigo</th>
                                    <th>Nombre</th>
                                    <th>Enpaque</th>
                                    <th>Cantidad</th>
                                    <th>Presentacion</th>
                                    <th>Caducidad</th>
                                    <th>ViaDeAdministracion</th>
                                    <th>Almacenamiento</th>
                                    <th>Especificacion</th>
                                    <th>Precio</th>
                                    <th>Promocion</th>
                                </tr>
                            </thead>
                            <tbody id="tbl_body_table">
                                <!--DATA POR MEDIA DE AJAX--->



                            </tbody>
                        </table>--%>
                    </div>
                </div>

            </div>
        </div>

        <!--DatatablePartbyMe--->
        <div class="row" align="center">
            <div class="col-xs-12" aria-selected="undefined">
                <div class="box-body table-responsive">
                    <asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None">
                        <AlternatingRowStyle BackColor="White" />
                        <EditRowStyle BackColor="#2461BF" />
                        <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                        <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                        <RowStyle BackColor="#EFF3FB" />
                        <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                        <SortedAscendingCellStyle BackColor="#F5F7FB" />
                        <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                        <SortedDescendingCellStyle BackColor="#E9EBEF" />
                        <SortedDescendingHeaderStyle BackColor="#4870BE" />

                    </asp:GridView>
                </div>
            </div>

        </div>

        <br />

        <section class="content-header">
            <h1 style="text-align: center">Editar Productos</h1>
        </section>

        <div class="row">
            <div class="col-md-6">
                <div class="box box-primary">
                    <div class="box-body">
                        <div class="form-group">
                            <label>Seleccione el Producto a Editar</label>
                        </div>
                        <div class="form-group">
                            <asp:DropDownList ID="ddlEditar" runat="server" CssClass="form-control"></asp:DropDownList>
                        </div>
                    </div>
                </div>
            </div>
            <div class="col-md-6">
                <div class="box box-primary">
                    <div class="box-body">
                        <div class="form-group">
                            <table id="tbl_botones" class="table table-bordered table-hover text-center">
                                <tr>
                                    <th>
                                        <asp:Button ID="Button2" runat="server" Text="Editar" CssClass="btn btn-primary" Width="200px" OnClick="Button2_Click" />
                                    </th>
                                    <th>
                                        <asp:Button ID="Button3" runat="server" Text="Eliminar" CssClass="btn btn-danger" Width="200px" OnClick="Button3_Click" />
                                    </th>
                                </tr>
                            </table>
                        </div>
                    </div>
                </div>
            </div>
            <br />

           
            
            <div class="col-md-12">
            <h1 style="text-align: center">Agregar categoria</h1>
                <div class="box box-primary">
                    <div class="box-body">
                        <div class="form-group">
                            <label>CODIGO</label>
                            <asp:TextBox ID="txtCodigoCategoria" runat="server" placeholder="Digite el codigo..." CssClass="form-control" MaxLength="8" onkeypress="if(event.keyCode<48 || event.keyCode>57)event.returnValue=false;"> </asp:TextBox>
                        </div>
                        <div class="form-group">
                            <label>Nombre</label>
                            <asp:TextBox ID="txtNombreCategoria" runat="server" placeholder="Escriba el nombre de categoria..." CssClass="form-control"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <label>Descripcion</label>
                            <asp:TextBox ID="txtDescripcionCategoria" runat="server" placeholder="Escriba el nombre de categoria..." CssClass="form-control"></asp:TextBox>
                        </div>

                         <table id="tbl_buttons" class="table table-bordered table-hover text-center">
                             <tr>
                                 <asp:Button ID="Button4" runat="server" Text="Agregar"  CssClass="btn btn-primary" Width="200px" />
                             </tr>
                         </table>

                    </div>
                </div>
            </div>

        </div>


    </section>



</asp:Content>
