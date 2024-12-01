<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="SeleccionPremio.aspx.cs" Inherits="TpPromo_1B.SeleccionPremio" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <ul class="nav nav-tabs">
        <li class="nav-item">
            <h5 style="margin-left: 20px;">Promo Ganá</h5>
        </li>
    </ul>
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

    <div class="container-fluid" style="display: flex; justify-content: center; align-items: center; height: 80vh;">
        <div style="width: auto;">

            <h1>Elegi tu premio</h1>
            <div class="card" style="width: 18rem;">
    <div id="carouselExample" class="carousel slide" data-bs-ride="carousel">
        <div class="carousel-inner">
            <div class="carousel-item active">
                <img src="foto1.jpg" class="d-block w-100" alt="Foto 1">
            </div>
            <div class="carousel-item">
                <img src="foto2.jpg" class="d-block w-100" alt="Foto 2">
            </div>
            <div class="carousel-item">
                <img src="foto3.jpg" class="d-block w-100" alt="Foto 3">
            </div>
        </div>
        <button class="carousel-control-prev" type="button" data-bs-target="#carouselExample" data-bs-slide="prev">
            <span class="carousel-control-prev-icon" aria-hidden="true"></span>
            <span class="visually-hidden">Previous</span>
        </button>
        <button class="carousel-control-next" type="button" data-bs-target="#carouselExample" data-bs-slide="next">
            <span class="carousel-control-next-icon" aria-hidden="true"></span>
            <span class="visually-hidden">Next</span>
        </button>
    </div>
    <div class="card-body">
        <h5 class="card-title">Título de la Tarjeta</h5>
        <p class="card-text">Descripción de la tarjeta con varias fotos en un carrusel.</p>
        <a href="#" class="btn btn-primary">Ver más</a>
    </div>
</div>

        </div>
    </div>

</asp:Content>
