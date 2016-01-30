<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="_3.Cookie.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="MainForm" runat="server">
        <h1>Login Form</h1>
        <label>Username:</label>
        <asp:TextBox runat="server" ID="Username"></asp:TextBox>
        <asp:Button runat="server" ID="Btn_click" OnClick="Btn_click_Click" Text="Login"/>
    </form>
</body>
</html>
