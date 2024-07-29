<%@ Page Title="" Language="C#" MasterPageFile="~/AdminManager/BackAdmin.Master" AutoEventWireup="true" CodeBehind="CityList.aspx.cs" Inherits="Web09042024.AdminManager.CityList" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <!-- DataTables CSS -->
    <link href="css/plugins/dataTables.bootstrap.css" rel="stylesheet">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainCnt" runat="server">
    <div id="page-wrapper">
        <div class="row">
            <div class="col-lg-12">
                <h1 class="page-header">ניהול ערים</h1>
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
                                        <th>קוד עיר</th>
                                        <th>שם עיר</th>
                                        <th>סטטוס</th>
                                        <th>תאריך הוספה</th>
                                        <th>ניהול</th>
                                    </tr>
                                </thead>
                                <tbody>
                                    <asp:Repeater ID="RptCity" runat="server">
                                        <ItemTemplate>
                                            <tr>
                                                <td><%# Eval("CityCode") %></td>
                                                <td><%# Eval("CityName") %></td>
                                                <td><%# Eval("CityStatus") %></td>
                                                <td><%# Eval("CityDateAdded") %></td>
                                                <td><a href="/AdminManager/CityAddEdit.aspx?CityCode=<%# Eval("CityCode") %>">ערוך <span class="fa fa-pencil"></span></a></td>
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
