<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PaymentSuccess.aspx.cs" Inherits="Web09042024.PaymentSuccess" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainCnt" runat="server">
    <h1 class="page-header">תשלום הצליח</h1>
    <p>תודה על הקנייה. ההזמנה שלך הושלמה בהצלחה.</p>
    <asp:HyperLink ID="ContinueShoppingLink" runat="server" NavigateUrl="Default.aspx" CssClass="btn btn-primary">המשך בקניות</asp:HyperLink>
</asp:Content>
