<%@ Page Title="" Language="C#" MasterPageFile="~/MainMaster.Master" AutoEventWireup="true" CodeBehind="ProductList.aspx.cs" Inherits="Web09042024.ProductList" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainCnt" runat="server">
     <div>
     <div class="container">
         <div class ="row">
             <!-- פקד רפיטר שחוזר על הקוד שבתוכו-->
             <asp:Repeater ID="RptProducts" runat="server">
                 <ItemTemplate>
                     <div class="col-md-4">
                         <div class="card" style="width: 18rem;">
                           <img src="image/<%# Eval("ProductImageName") %>" class="card-img-top" alt="...">
                           <div class="card-body">
                             <h5 class="card-title"><%#Eval("ProductName") %></h5>
                             <p class="card-text"><%#Eval("ProductPrice") %></p>
                             <a href="#" class="btn btn-primary">הוסף לסל</a>
                           </div>
                         </div>  
                     </div>
                 </ItemTemplate>
             </asp:Repeater>
         </div>
     </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="FooterCnt" runat="server">
</asp:Content>
