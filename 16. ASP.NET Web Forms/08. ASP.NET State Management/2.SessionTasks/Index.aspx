<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="_2.SessionTasks.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="MainForm" runat="server">
        <div>
            <asp:TextBox ID="Text_Input" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Button ID="ButtonAddLoad" runat="server" Text="Post Back"
                OnClick="buttonAddLoad_Click" />
        </div>
        <div>
            <asp:Label ID="ResultText" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
