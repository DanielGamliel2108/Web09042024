<%@ Page Title="" Language="C#" MasterPageFile="~/MainMaster.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Web09042024.Login1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainCnt" runat="server">
    <div>
     מייל: <asp:TextBox ID="TxtEmail" runat="server" /><br />
       סיסמה:  <asp:TextBox ID="TxtPass" TextMode="Password" runat="server" /><br />
               <asp:Button ID="BtnLogin" runat="server" Text="התחבר" Onclick="BtnLogin_Click"/>
              <div><asp:Literal ID ="LtlMsg" runat="server" /></div>
    </div>

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="FooterCnt" runat="server">
</asp:Content>
