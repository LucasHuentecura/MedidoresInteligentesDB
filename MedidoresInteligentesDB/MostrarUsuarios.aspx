<%@ Page Title="" Language="C#" MasterPageFile="~/PrincipalMaster.Master" AutoEventWireup="true" CodeBehind="MostrarUsuarios.aspx.cs" Inherits="MedidoresInteligentesDB.MostrarUsuarios" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row mt-5">
        <div class="col-lg-6 mx-auto">
            <div class="card">
                <div class="card-header bg-primary text-white">
                    <h3>Usuarios registrados</h3>
                </div>
                <div class="card-body">
                    <asp:GridView ID="grillaUsuario"
                        AutoGenerateColumns="false"
                        ShowHeaderWhenEmpty="true"
                        CssClass="table table-hover table-bordered"
                        EmptyDataText="No hay registros"
                        runat="server">
                        <Columns>
                            <asp:BoundField HeaderText="Nombre" DataField="Nombre" />
                            <asp:BoundField HeaderText="Rut" DataField="Rut" />
                            <asp:BoundField HeaderText="Correo" DataField="Correo" />
                            <asp:TemplateField HeaderText="Eliminar">
                                <ItemTemplate>
                                    <asp:Button ID="btnAccion" runat="server" Text="Eliminar" CommandName="Accion" CommandArgument='<%# Eval("ID") %>' />
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                    </asp:GridView>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
