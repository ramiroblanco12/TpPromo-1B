<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="IngresoCodigo.aspx.cs" Inherits="TpPromo_1B.IngresoCodigo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <ul class="nav nav-tabs">
        <li class="nav-item">
            <h5 style="margin-left: 20px;">Promo Ganá</h5>
        </li>
    </ul>


    <div class="container-fluid" style="display: flex; justify-content: center; align-items: center; height: 80vh;">
        <div style="width: auto;">
            <div class="mb-3">
                <asp:Label ID="lblVoucher" runat="server" Text="Ingresá el código de tu voucher!" CssClass="form-label"></asp:Label>
            </div>
            <div class="mb-3">
                <asp:TextBox ID="txtVoucher" runat="server" CssClass="form-control" placeholder="XXXXXXXXXXXXXXXXX"></asp:TextBox>
            </div>
            <div class="mb-3">
                <asp:Button ID="btnVoucher" runat="server" Text="Siguiente" CssClass="btn btn-primary" OnClick="btnVoucher_Click" />
            </div>
        </div>
    </div>

</asp:Content>
