﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Formularios/frmMenu.Master" AutoEventWireup="true" CodeBehind="frmAdminDirecciones.aspx.cs" Inherits="SistemaFarmaciaWeb.Formularios.frmAdminDirecciones" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section class="content-header">
        <h1 style="text-align:center">Registro de Direcciones</h1>
    </section>
    <section class="content">
        <div class="row">
            <div class="col-md-6">
                 <div class="box box-primary">
                      <div class="box-body">
                          <div class="form-group">
                              <label>CODIGO</label>
                              <asp:TextBox ID="TextBox1" runat="server" placeholder="Escriba el codigo..." CssClass="form-control"></asp:TextBox>
                          </div>
                          <div class="form-group">
                              <label>CIUDAD</label>
                              <asp:TextBox ID="TextBox2" runat="server" placeholder="Escriba el nombre de la ciudad..." CssClass="form-control" rows="3"></asp:TextBox>
                          </div>
                          <div class="form-group">
                              <label>CALLES</label>
                              <asp:TextBox ID="TextBox3" runat="server" placeholder="Escriba las calles..." CssClass="form-control"></asp:TextBox>
                          </div>
                      </div>
                 </div>
            </div>
            <div class="col-md-6">
                 <div class="box box-primary">
                      <div class="box-body" align="center">
                          <table id="tbl_botones" class="table table-bordered table-hover text-center">
                              <tr>
                                 
                                <asp:Button ID="Button1" runat="server" Text="Guardar Cambios"  CssClass="btn btn-primary" Width="400px" /><br />
                              </tr>
                              <tr>
                                  <br />
                                <asp:Button ID="Button3" runat="server" Text="Cancelar"  CssClass="btn btn-danger" Width="400px" /><br />

                              </tr>
                              <tr>
                                  <br />
                                <asp:Button ID="Button2" runat="server" Text="Registrar"  CssClass="btn btn-primary" Width="400px" /><br />

                              </tr>
                          </table>
                      </div>
                 </div>
            </div>
        </div>
    </section>
    <section class="content">
         <div class="row" align="center">
             <div class="col-xs-12">
                 <div class="box box-primary">
                    <div class="box-header">
                        <h3 class="box-title"> Listas de Direcciones</h3>
                    </div>
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
         </div>
    </section>
    <section class="content">
        <h1 style="text-align:center">Editar Direcciones</h1>
        <div class="row">
            <div class="col-md-6">
                <div class="box box-primary">
                    <div class="box-body">
                        <div class="form-group">
                            <label>Seleccion la direccion a editar</label>
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
                            <table id="tbl_buttons" class="table table-bordered table-hover text-center">
                                <tr>
                                    <th>
                                        <asp:Button ID="btnEditar" runat="server" Text="Editar" CssClass="btn btn-primary" Width="200px" />
                                    </th>
                                    <th>
                                        <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" CssClass="btn btn-danger" Width="200px"/>
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
