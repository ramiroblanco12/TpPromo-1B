<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="TpPromo_1B.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container-fluid" style="display: flex; justify-content: center; align-items: center; height: 80vh;">
        <div style="width: auto">
            <div class="mb-3">
                <h5>Si tenes un voucher hacé click</h5>
            </div>
            <div class="mb-3">
                <asp:Button ID="btnInicio" runat="server" Text="IR" CssClass="btn btn-primary" OnClick="btnInicio_Click" />
            </div>
        </div>
    </div>

</asp:Content>
