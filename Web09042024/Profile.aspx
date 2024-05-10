<%@ Page Title="" Language="C#" MasterPageFile="~/MainMaster.Master" AutoEventWireup="true" CodeBehind="Profile.aspx.cs" Inherits="Web09042024.Profile1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainCnt" runat="server">
       <div>
  שם פרטי <asp:TextBox ID="TextProfileFName" runat="server" required="required" />
   שם משפחה <asp:TextBox ID="TextProfileLName" runat="server" required="required" /> <br />
   עיר <asp:DropDownList ID="DDLProfileCity" runat="server"  /> <br /><br />
 קוד עיר <asp:DropDownList ID="DDLProfileCodeCity" runat="server" /> <br /><br />
    <asp:Button ID="BtnProfile" Text="עדכון פרופיל" OnClick="BtnProfile_Click" runat="server" />
     
</div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="FooterCnt" runat="server">
</asp:Content>
