<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="_2.Escaping.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="MainForm" runat="server">
        <div>
            <asp:TextBox runat="server" ID="text"></asp:TextBox>
            <asp:Button runat="server" ID="Btn" OnClick="Btn_Click" text="Click"/>
            <br />
            Result: <asp:TextBox runat="server" ID="result"></asp:TextBox>
            <br />
            Label: <asp:Label runat="server" ID="resultLabel"></asp:Label>
        </div>
    </form>
</body>
</html>
