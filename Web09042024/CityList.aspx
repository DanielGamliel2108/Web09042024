<%@ Page Title="" Language="C#" MasterPageFile="~/MainMaster.Master" AutoEventWireup="true" CodeBehind="CityList.aspx.cs" Inherits="Web09042024.CityList" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        .welcome-message {
            text-align: center;
            margin-top: 50px;
            font-size: 24px;
            color: green;
        }
        .welcome-container {
            text-align: center;
            margin-top: 20px;
        }
        .btn-back {
            margin-top: 20px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainCnt" runat="server">
    <div class="welcome-message">
        נרשמת אלינו, ברוך הבא!
    </div>
    <div class="welcome-container">
        <asp:Button ID="btnBackToHome" runat="server" CssClass="btn btn-primary btn-back" Text="חזרה לדף הראשי" OnClick="btnBackToHome_Click" />
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="FooterCnt" runat="server">
</asp:Content>
