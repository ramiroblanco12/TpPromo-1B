<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="IngresoCodigo.aspx.cs" Inherits="TpPromo_1B.IngresoCodigo" %>

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
