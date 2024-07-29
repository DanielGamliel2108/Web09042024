<%@ Page Title="" Language="C#" MasterPageFile="~/AdminManager/BackAdmin.Master" AutoEventWireup="true" CodeBehind="CategoryList.aspx.cs" Inherits="Web09042024.AdminManager.CategoryList" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <!-- DataTables CSS -->
    <link href="css/plugins/dataTables.bootstrap.css" rel="stylesheet">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainCnt" runat="server">
    <div id="page-wrapper">
        <div class="row">
            <div class="col-lg-12">
                <h1 class="page-header">ניהול קטגוריות</h1>
            </div>
            <!-- /.col-lg-12 -->
        </div>
        <div class="row">
            <div class="col-lg-12">
                <div class="panel panel-default">
                    <div class="panel-heading">
                        רשימת קטגוריות
                    </div>
                    <!-- /.panel-heading -->
                    <div class="panel-body">
                        <div class="table-responsive">
                            <table class="table table-striped table-bordered table-hover" id="CategoryTbl">
                                <thead>
                                    <tr>
                                        <th>מזהה קטגוריה</th>
                                        <th>שם קטגוריה</th>
                                        <th>תיאור קטגוריה</th>
                                        <th>קוד קטגוריה</th>
                                        <th>סטטוס</th>
                                        <th>תאריך הוספה</th>
                                        <th>ניהול</th>
                                    </tr>
                                </thead>
                                <tbody>
                                    <asp:Repeater ID="RptCategory" runat="server">
                                        <ItemTemplate>
                                            <tr>
                                                <td><%# Eval("Cid") %></td>
                                                <td><%# Eval("CategoryName") %></td>
                                                <td><%# Eval("CategoryDescription") %></td>
                                                <td><%# Eval("AvCategoryCode") %></td>
                                                <td><%# Eval("CategoryStatus") %></td>
                                                <td><%# Eval("DateAdded", "{0:yyyy-MM-dd}") %></td>
                                                <td><a href="/AdminManager/CategoryAddEdit.aspx?Cid=<%# Eval("Cid") %>">ערוך <span class="fa fa-pencil"></span></a></td>
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
    <script>
        $(document).ready(function () {
            $('#CategoryTbl').dataTable({
                language: {
                    url: '//cdn.datatables.net/plug-ins/2.0.7/i18n/he.json',
                },
            });
        });
    </script>
</asp:Content>
