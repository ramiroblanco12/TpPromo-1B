<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="RegistroCliente.aspx.cs" Inherits="TpPromo_1B.RegistroCliente" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <style>
        .custom-textbox {
            border: 2px solid #007bff; /* Borde azul */
            border-radius: 5px; /* Bordes redondeados */
            padding: 10px; /* Espaciado interno */
            font-size: 1rem; /* Tamaño de fuente */
            outline: none; /* Quitar borde de foco predeterminado */
            transition: all 0.3s ease; /* Suavizar las transiciones */
        }

            .custom-textbox:focus {
                border-color: #0056b3; /* Cambiar color al enfocarse */
                box-shadow: 0 0 5px rgba(0, 123, 255, 0.5); /* Sombra azul al enfocar */
            }
    </style>


    <div class="container d-flex justify-content-center align-items-center" style="height: 70vh;">
        <div class="row g-3 bg-light p-4 rounded" style="width: 600px;">
            <h5 class="text-center">Promo Ganá</h5>

            <div class="col-12">
                <label for="InputDni" class="form-label">DNI</label>
                <asp:TextBox ID="txtDni" runat="server" CssClass="custom-textbox" placeholder="Ingrese su DNI"></asp:TextBox>
                <asp:Button ID="btnValidaDni" runat="server" CssClass="btn btn-primary" Text="Validar DNI" Visible="true" OnClick="btnValidaDni_Click" />
                <asp:TextBox ID="txtArticulo" runat="server" CssClass="custom-textbox"></asp:TextBox>
                <asp:TextBox ID="txtCodV" runat="server" CssClass="custom-textbox"></asp:TextBox>
                <asp:Label ID="lblError1" runat="server" CssClass="text-danger" Visible="false"></asp:Label>
            </div>
            <% if (valido)

                { %>
          
            <div class="col-md-5">
                <label for="InputNombre" class="form-label">Nombre</label>
                <asp:TextBox ID="txtNombre" runat="server" CssClass="custom-textbox" placeholder="Ingrese su Nombre"></asp:TextBox>
            </div>
            <div class="col-md-5">
                <label for="InputApellido" class="form-label">Apellido</label>
                <asp:TextBox ID="txtApellido" runat="server" CssClass="custom-textbox" placeholder="Ingrese su Apellido"></asp:TextBox>
            </div>
            <div class="col-md-5">
                <label for="InputEmail" class="form-label">Email</label>
                <asp:TextBox ID="txtEmail" runat="server" CssClass="custom-textbox" TextMode="Email" placeholder="Ingrese su Email"></asp:TextBox>
            </div>

            <div class="col-md-5">
                <label for="InputDireccion" class="form-label">Dirección</label>
                <asp:TextBox ID="txtDireccion" runat="server" CssClass="custom-textbox" placeholder="Ingrese su Direccion"></asp:TextBox>
            </div>
            <div class="col-md-5">
                <label for="InputCiudad" class="form-label">Ciudad</label>
                <asp:TextBox ID="txtCiudad" runat="server" CssClass="custom-textbox" placeholder="Ingrese su Ciudad"></asp:TextBox>
            </div>
            <div class="col-md-5">
                <label for="InputCP" class="form-label">Código Postal</label>
                <asp:TextBox ID="txtCP" runat="server" CssClass="custom-textbox" placeholder="Ingrese su Codigo Postal"></asp:TextBox>
            </div>

            <div class="col-12 text-center">
                <asp:Button ID="btnEnviar" CssClass="btn btn-primary" OnClick="btnEnviar_Click" runat="server" Text="Participar" />
                <% }
                %>
                <asp:Label ID="lblEnviado" runat="server" CssClass="text-success" Visible="false"></asp:Label>
                <asp:Label ID="lblError" runat="server" CssClass="text-danger" Visible="false"></asp:Label>

            </div>
        </div>
    </div>

</asp:Content>
