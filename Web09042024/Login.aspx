<%@ Page Title="Login" Language="C#" MasterPageFile="~/MainMaster.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Web09042024.Login" %>
<%@ Register Src="~/User-Controls/LoginCube.ascx" TagPrefix="UC" TagName="LoginCube" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainCnt" runat="server">

    <div class="container">
        <div class="row">
            <UC:LoginCube id="LoginCube" runat="server" />
        </div>
    </div>
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="FooterCnt" runat="server">
</asp:Content>
