<%@ Page Title="" Language="C#" MasterPageFile="~/AdminManager/BackAdmin.Master" ValidateRequest="false" AutoEventWireup="true" CodeBehind="CityAddEdit.aspx.cs" Inherits="Web09042024.AdminManager.CityAddEdit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainCnt" runat="server">
    <div id="page-wrapper">
        <div class="row">
            <div class="col-lg-12">
                <h1 class="page-header">ניהול ערים</h1>
            </div>
            <!-- /.col-lg-12 -->
        </div>
        <!-- /.row -->
        <div class="row">
            <div class="col-lg-12">
                <div class="panel panel-default">
                    <div class="panel-heading">
                        הוספה / עריכת עיר
                    </div>
                    <div class="panel-body">
                        <div class="row">
                            <div class="col-lg-6">  
                                <asp:HiddenField ID="HidCityCode" runat="server" Value="-1" />
                                <div class="form-group">
                                    <label>שם עיר</label>
                                    <asp:TextBox ID="TxtCityName" Class="form-control" runat="server" placeholder="נא הזן שם עיר" />                                           
                                </div>
                                <div class="form-group">
                                    <label>סטטוס עיר</label>
                                    <asp:TextBox ID="TxtCityStatus" Class="form-control" runat="server" placeholder="נא הזן סטטוס עיר" />                                           
                                </div>
                                <asp:Button ID="BtnSave" runat="server" Class="btn btn-primary" OnClick="BtnSave_Click" Text="שמירה"/>
                            </div>
                        </div>
                        <!-- /.row (nested) -->
                    </div>
                    <!-- /.panel-body -->
                </div>
                <!-- /.panel -->
            </div>
            <!-- /.col-lg-12 -->
        </div>
        <!-- /.row -->
    </div>
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="FooterCnt" runat="server">
</asp:Content>

<asp:Content ID="Content4" ContentPlaceHolderID="UnderFooterCnt" runat="server">
</asp:Content>
