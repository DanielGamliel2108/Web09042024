<%@ Page Title="" Language="C#" MasterPageFile="~/AdminManager/BackAdmin.Master" ValidateRequest="false" AutoEventWireup="true" CodeBehind="ProdAddEdit.aspx.cs" Inherits="Web09042024.AdminManager.ProdAddEdit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainCnt" runat="server">
        <div id="page-wrapper">
     <div class="row">
                <div class="col-lg-12">
                    <h1 class="page-header">ניהול מוצרים</h1>
                </div>
                <!-- /.col-lg-12 -->
            </div>
            <!-- /.row -->
            <div class="row">
                <div class="col-lg-12">
                    <div class="panel panel-default">
                        <div class="panel-heading">
                          הוספה / עריכת מוצר
                        </div>
                        <div class="panel-body">
                            <div class="row">
                                <div class="col-lg-6">  
                                    <asp:HiddenField ID="HidPid" runat="server" Value="-1" />
                                        <div class="form-group">
                                            <label>שם המוצר</label>
                                            <asp:TextBox ID="TxtPname" Class="form-control" runat="server" placeholder="נא הזן שם מוצר" />                                           
                                        </div>
                                    <div class="form-group">
                                            <label>מחיר</label>
                                            <asp:TextBox ID="TxtPrice" Class="form-control" runat="server" placeholder="נא הזן מחיר" />                                           
                                        </div>
                                    <div class="form-group">
                                            <label>תיאור המוצר</label>
                                            <asp:TextBox ID="TxtPdesc" Class="form-control" runat="server" TextMode="MultiLine" Rows="10" Columns="40" placeholder="נא הזן תיאור" />                                           
                                        </div>
                                    <div class="form-group">
                                            <label>שם תמונה</label>
                                            <asp:Image ID="ImgPicname" Class="form-control" runat="server"  />                                           
                                        </div>
                                     <div class="form-group">
                                         <label>תמונת מוצר </label>
                                        <asp:FileUpload ID ="UploadPic" runat ="server" />                                   
                                     </div>
                                      
                                        <asp:button ID="BtnSave" runat="server"  class="btn btn-primary" onclick="BtnSave_Click" Text="שמירה"/>
                                      
                                   
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
        .create(document.querySelector( '#MainCnt_TxtPdesc' ) )
        .catch( error => {
            console.error( error );
        } );
    </script>

</asp:Content>
