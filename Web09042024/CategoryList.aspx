<%@ Page Title="" Language="C#" MasterPageFile="~/MainMaster.Master" AutoEventWireup="true" CodeBehind="CategoryList.aspx.cs" Inherits="Web09042024.CategoryList" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        .card {
            margin-bottom: 20px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainCnt" runat="server">
    <div class="container">
        <div class="row">
            <!-- פקד רפיטר שחוזר על הקוד שבתוכו -->
            <asp:Repeater ID="RptCategories" runat="server">
                <ItemTemplate>
                    <div class="col-md-4">
                        <div class="card" style="width: 18rem;">
                            <div class="card-body">
                                <h5 class="card-title"><%# Eval("CategoryName") %></h5>
                                <p class="card-text"><%# Eval("CategoryDescription") %></p>
                                <p class="card-text">קוד קטגוריה: <%# Eval("AvCategoryCode") %></p>
                                <p class="card-text">סטטוס: <%# Eval("CategoryStatus") %></p>
                                <p class="card-text">נוסף בתאריך: <%# Eval("DateAdded", "{0:dd/MM/yyyy}") %></p>
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
