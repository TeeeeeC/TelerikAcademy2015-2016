<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="_4.TicTacToe.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="~/styles/main.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="MainForm" runat="server">
        <div id="content">
            <asp:Button ID="b1" runat="server" OnCommand="Btn_Command" CommandName="1" Text="" CssClass="btn"/>
            <asp:Button ID="b2" runat="server" OnCommand="Btn_Command" CommandName="2" Text="" CssClass="btn"/>
            <asp:Button ID="b3" runat="server" OnCommand="Btn_Command" CommandName="3" Text="" CssClass="btn"/>
            <br />
            <asp:Button ID="b4" runat="server" OnCommand="Btn_Command" CommandName="4" Text="" CssClass="btn"/>
            <asp:Button ID="b5" runat="server" OnCommand="Btn_Command" CommandName="5" Text="" CssClass="btn"/>
            <asp:Button ID="b6" runat="server" OnCommand="Btn_Command" CommandName="6" Text="" CssClass="btn"/>
            <br />
            <asp:Button ID="b7" runat="server" OnCommand="Btn_Command" CommandName="7" Text="" CssClass="btn"/>
            <asp:Button ID="b8" runat="server" OnCommand="Btn_Command" CommandName="8" Text="" CssClass="btn"/>
            <asp:Button ID="b9" runat="server" OnCommand="Btn_Command" CommandName="9" Text="" CssClass="btn"/>
        </div>
    </form>
</body>
</html>
