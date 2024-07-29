<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Cart.aspx.cs" Inherits="Web09042024.AdminManager.Cart" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainCnt" runat="server">
    <h1 class="page-header">עגלת הקניות שלך</h1>
    <asp:GridView ID="CartGridView" runat="server" AutoGenerateColumns="False" CssClass="table table-striped">
        <Columns>
            <asp:BoundField DataField="ProductName" HeaderText="שם מוצר" />
            <asp:BoundField DataField="Quantity" HeaderText="כמות" />
            <asp:BoundField DataField="Price" HeaderText="מחיר ליחידה" DataFormatString="{0:C}" />
            <asp:TemplateField HeaderText="מחיר כולל">
                <ItemTemplate>
                    <%# (Convert.ToInt32(Eval("Quantity")) * Convert.ToDecimal(Eval("Price"))).ToString("C") %>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:CommandField ShowDeleteButton="True" DeleteText="הסר" />
        </Columns>
    </asp:GridView>
    <asp:Label ID="TotalLabel" runat="server" CssClass="total-price"></asp:Label>
    <asp:Button ID="CheckoutButton" runat="server" Text="מעבר לתשלום" CssClass="btn btn-primary" OnClick="CheckoutButton_Click" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FooterCnt" runat="server">
</asp:Content>
