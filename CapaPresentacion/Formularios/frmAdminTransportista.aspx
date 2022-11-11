﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Formularios/frmMenu.Master" AutoEventWireup="true" CodeBehind="frmAdminTransportista.aspx.cs" Inherits="SistemaFarmaciaWeb.Formularios.frmAdminPromociones" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <section class="content-header">
        <h1 style="text-align:center">Transportistas</h1>
    </section>
    <section class="content">
        <br />
        <div class="row" align="center">
            <div class="col-xs-12">
                <div class="box box-primary">
                    <div class="box-header">
                        <h3 class="box-title"> Listas de Transportistas Registrados</h3>
                    </div>
                </div>
                <div class="box-body table-responsive">
                    <asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" >
                        <AlternatingRowStyle BackColor="White" />
                        <EditRowStyle BackColor="#2461BF" />
                        <FooterStyle BackColor="#507CD1" ForeColor="White" Font-Bold="True" />
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

    <section class="content-header">
        <h1 style="text-align:center">Añadir Transportista</h1>
    </section>

    <div class="row">
        <div class="col-md-12">
            <div class="box box-primary">
                <div class="box-body">
                        <div class="form-group">
                            <label>Codigo</label>
                        </div>
                        <div class="form-group">
                            <asp:TextBox ID="txtIdTransportista" runat="server" placeholder="Digite el codigo..." CssClass="form-control"> </asp:TextBox>
                        </div>
                        <div class="form-group">
                            <label>Cedula</label>
                        </div>
                        <div class="form-group">
                            <asp:TextBox ID="txtCedula" runat="server" placeholder="Digite su cedula..." CssClass="form-control" > </asp:TextBox>
                        </div>
                        <div class="form-group">
                            <label>Nombre</label>
                        </div>
                        <div class="form-group">
                            <asp:TextBox ID="txtNombre" runat="server" placeholder="Escriba su nombre..." CssClass="form-control"> </asp:TextBox>
                        </div>
                        <div class="form-group">
                            <label>Direccion</label>
                        </div>
                        <div class="form-group">
                            <asp:DropDownList ID="ddlDireccion" runat="server" CssClass="form-control"></asp:DropDownList>
                        </div>
                        <div class="form-group">
                            <label>Telefono</label>
                        </div>
                        <div class="form-group">
                            <asp:TextBox ID="txtTelefono" runat="server" placeholder="Escriba su numero de etelefono" CssClass="form-control"> </asp:TextBox>
                        </div>

                </div>
            </div>
        </div>
    </div>

    <div align="center">
                <table>
                    <tr>
                        <td> 
                            <asp:Button ID="txtSaveEdit" runat="server" Text="Guardar Cambios" CssClass="btn-primary" Width="200px" OnClick="txtSaveEdit_Click" />
                        </td>
                        <td>&nbsp;&nbsp;&nbsp;&nbsp;</td>
                        <td> 
                            <asp:Button ID="btnRegister" runat="server" Text="Registrarse" CssClass="btn-primary" Width="200px" OnClick="btnRegister_Click" />
                        </td>
                        <td>&nbsp;&nbsp;&nbsp;&nbsp;</td>
                        <td>
                            <asp:Button ID="btnCancelar" runat="server" CssClass="btn-danger" Width="200px" Text="Cancelar" OnClick="btnCancelar_Click"/>
                        </td>
                    </tr>
                </table>
     </div>

    <br />

        <section class="content-header">
        <h1 style="text-align:center">Editar Transportista</h1>
        </section>

        <div class="row">
            <div class="col-md-6">
                <div class="box box-primary">
                    <div class="box-body">
                        <div class="form-group">
                            <label>Seleccion el Transportista a Editar</label>
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
                                        <asp:Button ID="btnEdit" runat="server" Text="Editar" CssClass="btn btn-primary" Width="200px" OnClick="btnEdit_Click"/>
                                    </th>
                                    <th>
                                        <asp:Button ID="btnDelete" runat="server" Text="Eliminar" CssClass="btn btn-danger" Width="200px" OnClick="btnDelete_Click"/>
                                    </th>
                                </tr>
                            </table>
                        </div>
                    </div>
                </div>
            </div>

        </div>


    </section>
    

</asp:Content>
