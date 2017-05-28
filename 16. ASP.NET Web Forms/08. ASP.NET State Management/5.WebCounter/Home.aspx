<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="_5.WebCounter.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="MainForm" runat="server">
        <div>
            <asp:Button ID="buttonAddLoad" runat="server" Text="Post Back"
              OnClick="buttonAddLoad_Click" />
        </div>
    </form>
</body>
</html>
