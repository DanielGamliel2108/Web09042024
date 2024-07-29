<%@ Page Title="" Language="C#" MasterPageFile="~/AdminManager/BackAdmin.Master" ValidateRequest="false" AutoEventWireup="true" CodeBehind="ClientAddEdit.aspx.cs" Inherits="Web09042024.AdminManager.ClientAddEdit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainCnt" runat="server">
    <div id="page-wrapper">
        <div class="row">
            <div class="col-lg-12">
                <h1 class="page-header">ניהול לקוחות</h1>
            </div>
            <!-- /.col-lg-12 -->
        </div>
        <!-- /.row -->
        <div class="row">
            <div class="col-lg-12">
                <div class="panel panel-default">
                    <div class="panel-heading">
                        הוספה / עריכת לקוח
                    </div>
                    <div class="panel-body">
                        <div class="row">
                            <div class="col-lg-6">  
                                <asp:HiddenField ID="HidClientId" runat="server" Value="-1" />
                                <div class="form-group">
                                    <label>שם פרטי</label>
                                    <asp:TextBox ID="TxtClientName" Class="form-control" runat="server" placeholder="נא הזן שם פרטי" />                                           
                                </div>
                                <div class="form-group">
                                    <label>שם משפחה</label>
                                    <asp:TextBox ID="TxtClientLastname" Class="form-control" runat="server" placeholder="נא הזן שם משפחה" />                                           
                                </div>
                                <div class="form-group">
                                    <label>כתובת</label>
                                    <asp:TextBox ID="TxtClientAddress" Class="form-control" runat="server" placeholder="נא הזן כתובת" />                                           
                                </div>
                                <div class="form-group">
                                    <label>עיר</label>
                                    <asp:TextBox ID="TxtClientCity" Class="form-control" runat="server" placeholder="נא הזן עיר" />                                           
                                </div>
                                <div class="form-group">
                                    <label>טלפון</label>
                                    <asp:TextBox ID="TxtClientPhone" Class="form-control" runat="server" placeholder="נא הזן טלפון" />                                           
                                </div>
                                <div class="form-group">
                                    <label>דוא"ל</label>
                                    <asp:TextBox ID="TxtClientMail" Class="form-control" runat="server" placeholder="נא הזן אימייל" />                                           
                                </div>
                                <div class="form-group">
                                    <label>סיסמה</label>
                                    <asp:TextBox ID="TxtClientPassword" Class="form-control" runat="server" TextMode="Password" placeholder="נא הזן סיסמה" />                                           
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
            .create(document.querySelector('#MainCnt_TxtClientAddress'))
            .catch(error => {
                console.error(error);
            });
    </script>
</asp:Content>
