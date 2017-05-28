<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="Calculator.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="~/styles/main.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="MainForm" runat="server">
        <div id="content">
            <asp:Label runat="server" ID="result"></asp:Label>
            <asp:Label runat="server" ID="firstNum"></asp:Label>
            <asp:Label runat="server" ID="operator"></asp:Label>
            <asp:Label runat="server" ID="secondNum"></asp:Label>
            <br />
            <asp:Button ID="b1" runat="server" OnCommand="Btn_Command" CommandName="1" Text="1" CssClass="btn"/>
            <asp:Button ID="b2" runat="server" OnCommand="Btn_Command" CommandName="2" Text="2" CssClass="btn"/>
            <asp:Button ID="b3" runat="server" OnCommand="Btn_Command" CommandName="3" Text="3" CssClass="btn"/>
            <asp:Button ID="bPlus" runat="server" OnCommand="Btn_Command" CommandName="+" Text="+" CssClass="btn"/>
            <br />
            <asp:Button ID="b4" runat="server" OnCommand="Btn_Command" CommandName="4" Text="4" CssClass="btn"/>
            <asp:Button ID="b5" runat="server" OnCommand="Btn_Command" CommandName="5" Text="5" CssClass="btn"/>
            <asp:Button ID="b6" runat="server" OnCommand="Btn_Command" CommandName="6" Text="6" CssClass="btn"/>
            <asp:Button ID="bMinus" runat="server" OnCommand="Btn_Command" CommandName="-" Text="-" CssClass="btn"/>
            <br />
            <asp:Button ID="b7" runat="server" OnCommand="Btn_Command" CommandName="7" Text="7" CssClass="btn"/>
            <asp:Button ID="b8" runat="server" OnCommand="Btn_Command" CommandName="8" Text="8" CssClass="btn"/>
            <asp:Button ID="b9" runat="server" OnCommand="Btn_Command" CommandName="9" Text="9" CssClass="btn"/>
            <asp:Button ID="bMultiply" runat="server" OnCommand="Btn_Command" CommandName="*" Text="*" CssClass="btn"/>
            <br />
            <asp:Button ID="bClear" runat="server" OnCommand="Btn_Command" CommandName="Clear" Text="Clear" CssClass="btn"/>
            <asp:Button ID="b0" runat="server" OnCommand="Btn_Command" CommandName="0" Text="0" CssClass="btn"/>
            <asp:Button ID="bDivide" runat="server" OnCommand="Btn_Command" CommandName="/" Text="/" CssClass="btn"/>
            <asp:Button ID="bSqrt" runat="server" OnCommand="Btn_Command" CommandName="Sqrt" Text="Sqrt" CssClass="btn"/>
            <asp:Button ID="bEqual" runat="server" OnCommand="Btn_Command" CommandName="=" Text="=" CssClass="equal"/>
        </div>
    </form>
</body>
</html>
