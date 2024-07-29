<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Checkout.aspx.cs" Inherits="Web09042024.Checkout" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainCnt" runat="server">
    <h1 class="page-header">תשלום באשראי</h1>
    <asp:Label ID="TotalLabel" runat="server" CssClass="total-price"></asp:Label>
    <div class="credit-card-form">
        <asp:TextBox ID="CardNumber" runat="server" CssClass="form-control" Placeholder="מספר כרטיס"></asp:TextBox>
        <asp:TextBox ID="CardHolderName" runat="server" CssClass="form-control" Placeholder="שם בעל הכרטיס"></asp:TextBox>
        <asp:TextBox ID="ExpirationDate" runat="server" CssClass="form-control" Placeholder="תוקף (MM/YY)"></asp:TextBox>
        <asp:TextBox ID="CVC" runat="server" CssClass="form-control" Placeholder="CVC"></asp:TextBox>
        <asp:Button ID="PayButton" runat="server" Text="בצע תשלום" CssClass="btn btn-primary" OnClick="PayButton_Click" />
    </div>
</asp:Content>
