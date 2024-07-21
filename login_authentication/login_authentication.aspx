<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login_authentication.aspx.cs" Inherits="login_authentication.login_authentication" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css" rel="stylesheet"/>
    <title>Login | Authentication Users</title>
</head>
<body>

    <form id="authentication" runat="server" class="container content-form">
        <div>
            <div class="mb-3">
                <h4>Login Authentication for users</h4>
                <label for="exampleInputEmail1" class="form-label">Username</label>
                <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control"></asp:TextBox>
              </div>
              <div class="mb-3">
                <label for="exampleInputPassword1" class="form-label">Password</label>
                  <asp:TextBox ID="TextBox2" TextMode="Password" runat="server" CssClass="form-control"></asp:TextBox>
              </div>
            <div class="row">
                <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
            </div>
            <br />
            <asp:Button ID="AuthenticationBTN" runat="server" Text="Authentication" CssClass="btn btn-warning btn-lg" OnClick="AuthenticationBTN_Click"/>
        </div>
    </form>

    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/js/bootstrap.bundle.min.js"></script>
</body>
</html>
