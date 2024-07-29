<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="LoginCube.ascx.cs" Inherits="Web09042024.User_Controls.LoginCube" %>
<div id ="LoginContainer" runat="server">
    <div class="container">
        <div class="row">
            <div class="col-md-4 col-md-offset-4">
                <div class="login-panel panel panel-default">
                    <div class="panel-heading">
                        <h3 class="panel-title">אנא התחבר</h3>
                    </div>
                    <div class="panel-body">
                        <asp:Literal ID="LtlMsg" runat="server" />
                        <form role="form">
                            <fieldset>
                                <div class="form-group">
                                    <asp:Label AssociatedControlID="TxtEmail" runat="server" Text="מייל:" CssClass="control-label" />
                                    <asp:TextBox ID="TxtEmail" runat="server" CssClass="form-control" />
                                </div>
                                <div class="form-group">
                                    <asp:Label AssociatedControlID="TxtPass" runat="server" Text="סיסמה:" CssClass="control-label" />
                                    <asp:TextBox ID="TxtPass" runat="server" TextMode="Password" CssClass="form-control" />
                                </div>
                                <asp:Button ID="BtnLogin" runat="server" Text="התחבר" CssClass="btn btn-lg btn-success btn-block" OnClick="BtnLogin_Click" />
                            </fieldset>
                        </form>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
<asp:Literal ID="LtlLoggedUser" runat="server" />
