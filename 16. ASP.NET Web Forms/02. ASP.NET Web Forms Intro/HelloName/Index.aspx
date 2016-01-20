<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="HelloName.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="UserForm" runat="server">
        <div>
            <label>Name</label>
            <asp:TextBox runat="server" ID="name"></asp:TextBox>
            <asp:Button runat="server" OnClick="Btn_Click" Text="Click" />
        </div>
    </form>
</body>
</html>
