<%@ Page Title="" Language="C#" MasterPageFile="~/AdminManager/BackAdmin.Master" ValidateRequest="false" AutoEventWireup="true" CodeBehind="CategoryAddEdit.aspx.cs" Inherits="Web09042024.AdminManager.CategoryAddEdit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainCnt" runat="server">
    <div id="page-wrapper">
        <div class="row">
            <div class="col-lg-12">
                <h1 class="page-header">ניהול קטגוריות</h1>
            </div>
            <!-- /.col-lg-12 -->
        </div>
        <!-- /.row -->
        <div class="row">
            <div class="col-lg-12">
                <div class="panel panel-default">
                    <div class="panel-heading">
                        הוספה / עריכת קטגוריה
                    </div>
                    <div class="panel-body">
                        <div class="row">
                            <div class="col-lg-6">  
                                <asp:HiddenField ID="HidCid" runat="server" Value="-1" />
                                <div class="form-group">
                                    <label>שם קטגוריה</label>
                                    <asp:TextBox ID="TxtCategoryName" Class="form-control" runat="server" placeholder="נא הזן שם קטגוריה" />                                           
                                </div>
                                <div class="form-group">
                                    <label>תיאור קטגוריה</label>
                                    <asp:TextBox ID="TxtCategoryDescription" Class="form-control" runat="server" TextMode="MultiLine" placeholder="נא הזן תיאור קטגוריה" />                                           
                                </div>   
                                <div class="form-group">
                                    <label>קוד קטגוריה חלופי</label>
                                    <asp:TextBox ID="TxtAvCategoryCode" Class="form-control" runat="server" placeholder="נא הזן קוד קטגוריה חלופי" />                                           
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
    <script src="https://cdn.ckeditor.com/ckeditor5/41.4.2/classic/ckeditor.js"></script>

    <script>
        ClassicEditor
            .create(document.querySelector('#MainCnt_TxtCategoryDescription'))
            .catch(error => {
                console.error(error);
            });
    </script>
</asp:Content>

