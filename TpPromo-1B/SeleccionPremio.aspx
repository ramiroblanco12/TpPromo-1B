<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="SeleccionPremio.aspx.cs" Inherits="TpPromo_1B.SeleccionPremio" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <ul class="nav nav-tabs">
        <li class="nav-item">
            <h5 style="margin-left: 20px;">Promo Ganá</h5>
        </li>
    </ul>

    <div class="container-fluid d-flex justify-content-center align-items-center" style="height: 60vh;">
        <div style="width: auto;">
            <h1 class="text-center mb-4">Elegi tu premio</h1>

            <div class="row row-cols-1 row-cols-md-3 g-4">
                <div class="col">
                    <div class="card">
                        <div id="carousel1" class="carousel slide" data-bs-ride="carousel">
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
                            <div class="mb-3">
<%--                                <asp:Label ID="lblNombre1" runat="server"></asp:Label>--%>
                            </div>
                            <div class="mb-3">
<%--                                <asp:Label ID="lblDesc1" runat="server"></asp:Label>--%>
                            </div>
                            <div class="mb-3">
                                <asp:Button ID="btnPremio1" CssClass="btn btn-primary" runat="server" Text="Quiero este!" />
                            </div>
                        </div>
                    </div>
                </div>
                <div class="col">
                    <div class="card">
                        <div id="carousel2" class="carousel slide" data-bs-ride="carousel">
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
                            <div class="mb-3">
<%--                                <asp:Label ID="lblNombre2" runat="server"></asp:Label>
                            </div>
                            <div class="mb-3">
                                <asp:Label ID="lblDesc2" runat="server"></asp:Label>--%>
                            </div>
                            <div class="mb-3">
                                <asp:Button ID="btnPremio2" CssClass="btn btn-primary" runat="server" Text="Quiero este!" />
                            </div>
                        </div>
                    </div>
                </div>
                <div class="col">
                    <div class="card">
                        <div id="carousel3" class="carousel slide" data-bs-ride="carousel">
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
                            <div class="mb-3">
<%--                                <asp:Label ID="lblNombre3" runat="server"></asp:Label>
                            </div>
                            <div class="mb-3">
                                <asp:Label ID="lblDesc3" runat="server"></asp:Label>
                            </div>--%>
                            <div class="mb-3">
                                <asp:Button ID="btnPremio3" CssClass="btn btn-primary" runat="server" Text="Quiero este!" />
                            </div>
                        </div>
                    </div>
                </div>

            </div>

        </div>
    </div>

</asp:Content>
