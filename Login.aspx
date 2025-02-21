<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="FeatureFlagPOC_LD.Login" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login - LaunchDarkly POC</title>
    <style>
        .login-container {
            width: 300px;
            margin: 100px auto;
            border: 1px solid #ccc;
            padding: 20px;
            box-shadow: 2px 2px 5px #aaa;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="login-container">
            <h2>Login</h2>
            <asp:Label ID="lblMessage" runat="server" ForeColor="Red"></asp:Label>
            <br />
            <asp:Label ID="lblUserId" runat="server" Text="User ID:"></asp:Label>
            <asp:TextBox ID="txtUserId" runat="server" Width="100%"></asp:TextBox>
            <br /><br />
            <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" />
        </div>
    </form>
</body>
</html>