<%@ Page Title="Register" Language="C#" MasterPageFile="~/MainMaster.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="Web09042024.Register" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainCnt" runat="server">
    <div class="container">
        <div class="row">
            <div class="col-md-6 col-md-offset-3">
                <div class="panel panel-default">
                    <div class="panel-heading">
                        <h3 class="panel-title">הרשמה</h3>
                    </div>
                    <div class="panel-body">
                        <asp:Literal ID="LtlMsg" runat="server" />
                        <form role="form">
                            <fieldset>
                                <div class="form-group">
                                    <asp:Label AssociatedControlID="TxtFirstName" runat="server" Text="שם :" CssClass="control-label" />
                                    <asp:TextBox ID="TxtFirstName" runat="server" CssClass="form-control" />
                                </div>
                                <div class="form-group">
                                    <asp:Label AssociatedControlID="TxtLastName" runat="server" Text="שם משפחה :" CssClass="control-label" />
                                    <asp:TextBox ID="TxtLastName" runat="server" CssClass="form-control" />
                                </div>
                                <div class="form-group">
                                    <asp:Label AssociatedControlID="TxtEmail" runat="server" Text="אימייל:" CssClass="control-label" />
                                    <asp:TextBox ID="TxtEmail" runat="server" TextMode="Email" CssClass="form-control" />
                                </div>
                                <div class="form-group">
                                    <asp:Label AssociatedControlID="TxtPass" runat="server" Text="סיסמה:" CssClass="control-label" />
                                    <asp:TextBox ID="TxtPass" runat="server" TextMode="Password" CssClass="form-control" />
                                </div>
                                <div class="form-group">
                                    <asp:Label AssociatedControlID="DDLCity" runat="server" Text="עיר:" CssClass="control-label" />
                                    <asp:DropDownList ID="DDLCity" runat="server" CssClass="form-control" />
                                </div>
                                <asp:Button ID="BtnReg" runat="server" Text="הרשמה" CssClass="btn btn-lg btn-success btn-block" OnClick="BtnReg_Click" />
                                <asp:Button ID="LogIn" runat="server" Text="Have User? Log In" CssClass="btn btn-lg btn-link btn-block" OnClick="LogIn_Click" />
                            </fieldset>
                        </form>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="FooterCnt" runat="server">
</asp:Content>
