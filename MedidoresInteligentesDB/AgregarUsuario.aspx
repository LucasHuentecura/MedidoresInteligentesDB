<%@ Page Title="" Language="C#" MasterPageFile="~/PrincipalMaster.Master" AutoEventWireup="true" CodeBehind="AgregarUsuario.aspx.cs" Inherits="MedidoresInteligentesDB.AgregarUsuario" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row mt-5">
        <div class="col-lg-6 mx-auto">
            <div class="card">
                <div class="card-header bg-primary text-white">
                    <h3>Ingresar usuario</h3>
                </div>
                <div class="card-body">
                    <div class="form-group">
                        <label for="rutTxt">Rut</label>
                        <asp:TextBox ID="rutTxt" CssClass="form-control" runat="server"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label for="nombreTxt">Nombre</label>
                        <asp:TextBox ID="nombreTxt" CssClass="form-control" runat="server"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label for="correoTxt">Correo</label>
                        <asp:TextBox ID="correoTxt" CssClass="form-control" runat="server"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label for="contrasenaTxt">Contraseña</label>
                        <asp:TextBox ID="contrasenaTxt" CssClass="form-control" runat="server"></asp:TextBox>
                    </div>
                    <asp:Button runat="server" OnClick="guardarBtn_Click" CssClass="btn bg-primary" ID="guardarBtn" Text="Guardar"/>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
