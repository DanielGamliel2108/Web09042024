<%@ Page Title="" Language="C#" MasterPageFile="~/MainMaster.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="Web09042024.Register1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainCnt" runat="server">
       <div>
        שם :  <asp:Textbox ID="TxtFirstName" runat="server" /><br />
  שם משפחה :   <asp:Textbox ID="TxtLastName" runat="server" /><br />
       אימייל: <asp:Textbox ID="TxtEmail" TextMode="Email" runat="server" /><br />
         סיסמה:  <asp:TextBox ID="TxtPass" runat="server" TextMode="Password"/><br />
      
               עיר  <asp:DropDownList ID="DDLCity" runat="server" CssClass="form-control"/>
        
              <asp:Button ID="BtnReg" runat="server" Text="הרשמה" OnClick="BtnReg_Click" /><br />
        <asp:Button ID="LogIn" runat="server" Text="Have User? Log In" OnClick="LogIn_Click"/>
       <asp:Literal ID="LtlMsg" runat="server" />
   </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="FooterCnt" runat="server">
</asp:Content>
