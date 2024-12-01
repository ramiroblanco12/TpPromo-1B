<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="RegistroCliente.aspx.cs" Inherits="TpPromo_1B.RegistroCliente" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
         <style>
        
        .form-control {
            border: 2px solid #007BFF; 
            border-radius: 5px;      
            box-shadow: 0 0 5px rgba(0, 123, 255, 0.5); 
        }

        .form-control:focus {
            border: 2px solid #0056b3; 
            box-shadow: 0 0 8px rgba(0, 86, 179, 0.8); 
            outline: none; 
        }
    </style>

    <div class="container d-flex justify-content-center align-items-center" style="height: 70vh;">
        <div class="row g-3 bg-light p-4 rounded" style="width: 600px;">
            <h5 class="text-center">Promo Ganá</h5>

            <!-- Primera fila: DNI -->
            <div class="col-12">
                <label for="InputDni" class="form-label">DNI</label>
                <input type="text" class="form-control" id="InputDni" placeholder="Ingrese su DNI" required>
            </div>

            <!-- Segunda fila: Nombre, Apellido, Email -->
            <div class="col-md-4">
                <label for="InputNombre" class="form-label">Nombre</label>
                <input type="text" class="form-control" id="InputNombre" placeholder="Ingrese su nombre" required>
            </div>
            <div class="col-md-4">
                <label for="InputApellido" class="form-label">Apellido</label>
                <input type="text" class="form-control" id="InputApellido" placeholder="Ingrese su apellido" required>
            </div>
            <div class="col-md-4">
                <label for="InputEmail" class="form-label">Email</label>
                <input type="email" class="form-control" id="InputEmail" placeholder="name@example.com" required>
            </div>

            <!-- Tercera fila: Dirección, Ciudad, Código Postal -->
            <div class="col-md-4">
                <label for="InputDireccion" class="form-label">Dirección</label>
                <input type="text" class="form-control" id="InputDireccion" placeholder="Ingrese su dirección" required>
            </div>
            <div class="col-md-4">
                <label for="InputCiudad" class="form-label">Ciudad</label>
                <input type="text" class="form-control" id="InputCiudad" placeholder="Ingrese su ciudad" required>
            </div>
            <div class="col-md-4">
                <label for="InputCP" class="form-label">Código Postal</label>
                <input type="text" class="form-control" id="InputCP" placeholder="Ingrese su código postal" required>
            </div>

            <!-- Botón de envío -->
            <div class="col-12 text-center">
                <button class="btn btn-primary" type="submit">Enviar</button>
            </div>
        </div>
    </div>

</asp:Content>
