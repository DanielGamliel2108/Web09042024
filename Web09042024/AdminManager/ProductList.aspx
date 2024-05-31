<%@ Page Title="" Language="C#" MasterPageFile="~/AdminManager/BackAdmin.Master" AutoEventWireup="true" CodeBehind="ProductList.aspx.cs" Inherits="Web09042024.AdminManager.ProductList" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <!-- DataTables CSS -->
    <link href="css/plugins/dataTables.bootstrap.css" rel="stylesheet">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainCnt" runat="server">
    <div id="page-wrapper">
        <div class="row">
            <div class="col-lg-12">
                <h1 class="page-header">ניהול מוצרים</h1>
            </div>
            <!-- /.col-lg-12 -->
        </div>
        <div class="row">
            <div class="col-lg-12">
                <div class="panel panel-default">
                    <div class="panel-heading">
                        DataTables Advanced Tables
                    </div>
                    <!-- /.panel-heading -->
                    <div class="panel-body">
                        <div class="table-responsive">
                            <table class="table table-striped table-bordered table-hover" id="MainTbl">
                                <thead>
                                    <tr>
                                        <th>קוד מוצר</th>
                                        <th>שם מוצר</th>
                                        <th>מחיר</th>
                                        <th>תיאור מוצר</th>
                                        <th>תמונה</th>
                                        <th>ניהול</th>
                                    </tr>
                                </thead>
                                <tbody>
                                    <asp:Repeater ID="RptProd" runat="server">
                                        <ItemTemplate>
                                            <tr>
                                                <td><%# Eval("ProductCode") %></td>
                                                <td><%# Eval("ProductName") %></td>
                                                <td><%# Eval("ProductPrice") %></td>
                                                <td><%# Eval("ProductDescription") %></td>
                                                <td><img src="/image/<%# Eval("ProductImageName") %>" width="40" /></td>
                                                <td><a href="/AdminManager/ProdAddEdit.aspx?ProductCode=<%# Eval("ProductCode") %>">ערוך <span class="fa fa-pencil"></span></a></td>
                                            </tr>
                                        </ItemTemplate>
                                    </asp:Repeater>
                                </tbody>
                            </table>
                        </div>
                    </div>
                    <!-- /.panel-body -->
                </div>
                <!-- /.panel -->
            </div>
            <!-- /.col-lg-12 -->
        </div>
    </div>
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="FooterCnt" runat="server">
    <!-- DataTables JavaScript -->
    <script src="js/jquery/jquery.dataTables.min.js"></script>
    <script src="js/bootstrap/dataTables.bootstrap.min.js"></script>
    <!-- Page-Level Demo Scripts - Tables - Use for reference -->
    <!-- הערה להסתכל בסרטון -->
    <script>
        $(document).ready(function () {
            $('#MainTbl').dataTable({
                language: {
                    url: '//cdn.datatables.net/plug-ins/2.0.7/i18n/he.json',
                },
            });
        });
    </script>
</asp:Content>

<asp:Content ID="Content4" ContentPlaceHolderID="UnderFooterCnt" runat="server">
</asp:Content>
