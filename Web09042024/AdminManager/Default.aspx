<%@ Page Title="" Language="C#" MasterPageFile="~/AdminManager/BackAdmin.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Web09042024.AdminManager.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="css/style.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainCnt" runat="server">
    <div id="page-wrapper" class="container">
        <div class="row">
            <div class="col-lg-12">
                <h1 class="page-header text-center">כל בו גמליאל</h1>
            </div>
        </div>
        <div class="row">
            <!-- Example Product 1 -->
            <div class="col-lg-3 col-md-4 col-sm-6 mb-4">
                <div class="card product-card">
                    <img class="card-img-top" src="/image/bread.jpeg" alt="לחם">
                    <div class="card-body">
                        <h5 class="card-title">לחם</h5>
                        <p class="card-text">12.90 &#8362;</p>
                        <a href="#" class="btn btn-primary"><i class="fa fa-search"></i></a>
                        <a href="#" class="btn btn-success"><i class="fa fa-shopping-cart"></i></a>
                    </div>
                </div>
            </div>
            <!-- Example Product 2 -->
            <div class="col-lg-3 col-md-4 col-sm-6 mb-4">
                <div class="card product-card">
                    <img class="card-img-top" src="/image/blackchair.jpeg" alt="כיסא שחור">
                    <div class="card-body">
                        <h5 class="card-title">כיסא שחור</h5>
                        <p class="card-text">299.90 &#8362;</p>
                        <a href="#" class="btn btn-primary"><i class="fa fa-search"></i></a>
                        <a href="#" class="btn btn-success"><i class="fa fa-shopping-cart"></i></a>
                    </div>
                </div>
            </div>
            <!-- Example Product 3 -->
            <div class="col-lg-3 col-md-4 col-sm-6 mb-4">
                <div class="card product-card">
                    <img class="card-img-top" src="/image/chair.jpeg" alt="כיסא">
                    <div class="card-body">
                        <h5 class="card-title">כיסא</h5>
                        <p class="card-text">199.90 &#8362;</p>
                        <a href="#" class="btn btn-primary"><i class="fa fa-search"></i></a>
                        <a href="#" class="btn btn-success"><i class="fa fa-shopping-cart"></i></a>
                    </div>
                </div>
            </div>
            <!-- Example Product 4 -->
            <div class="col-lg-3 col-md-4 col-sm-6 mb-4">
                <div class="card product-card">
                    <img class="card-img-top" src="/image/computer.jpeg" alt="מחשב">
                    <div class="card-body">
                        <h5 class="card-title">מחשב</h5>
                        <p class="card-text">1999.90 &#8362;</p>
                        <a href="#" class="btn btn-primary"><i class="fa fa-search"></i></a>
                        <a href="#" class="btn btn-success"><i class="fa fa-shopping-cart"></i></a>
                    </div>
                </div>
            </div>
            <!-- Example Product 5 -->
            <div class="col-lg-3 col-md-4 col-sm-6 mb-4">
                <div class="card product-card">
                    <img class="card-img-top" src="/image/milk.jpeg" alt="חלב">
                    <div class="card-body">
                        <h5 class="card-title">חלב</h5>
                        <p class="card-text">5.90 &#8362;</p>
                        <a href="#" class="btn btn-primary"><i class="fa fa-search"></i></a>
                        <a href="#" class="btn btn-success"><i class="fa fa-shopping-cart"></i></a>
                    </div>
                </div>
            </div>
            <!-- Example Product 6 -->
            <div class="col-lg-3 col-md-4 col-sm-6 mb-4">
                <div class="card product-card">
                    <img class="card-img-top" src="/image/phone.jpeg" alt="טלפון">
                    <div class="card-body">
                        <h5 class="card-title">טלפון</h5>
                        <p class="card-text">899.90 &#8362;</p>
                        <a href="#" class="btn btn-primary"><i class="fa fa-search"></i></a>
                        <a href="#" class="btn btn-success"><i class="fa fa-shopping-cart"></i></a>
                    </div>
                </div>
            </div>
            <!-- Example Product 7 -->
            <div class="col-lg-3 col-md-4 col-sm-6 mb-4">
                <div class="card product-card">
                    <img class="card-img-top" src="/image/pinkchair.jpeg" alt="כיסא ורוד">
                    <div class="card-body">
                        <h5 class="card-title">כיסא ורוד</h5>
                        <p class="card-text">299.90 &#8362;</p>
                        <a href="#" class="btn btn-primary"><i class="fa fa-search"></i></a>
                        <a href="#" class="btn btn-success"><i class="fa fa-shopping-cart"></i></a>
                    </div>
                </div>
            </div>
            <!-- Example Product 8 -->
            <div class="col-lg-3 col-md-4 col-sm-6 mb-4">
                <div class="card product-card">
                    <img class="card-img-top" src="/image/yellowchair.jpeg" alt="כיסא צהוב">
                    <div class="card-body">
                        <h5 class="card-title">כיסא צהוב</h5>
                        <p class="card-text">299.90 &#8362;</p>
                        <a href="#" class="btn btn-primary"><i class="fa fa-search"></i></a>
                        <a href="#" class="btn btn-success"><i class="fa fa-shopping-cart"></i></a>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="FooterCnt" runat="server">
    <div class="footer text-center">
        <p>&copy; 2024 כל בו גמליאל. כל הזכויות שמורות.</p>
    </div>
</asp:Content>
