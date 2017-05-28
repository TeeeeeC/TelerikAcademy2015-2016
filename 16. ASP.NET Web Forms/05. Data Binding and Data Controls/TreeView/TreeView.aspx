<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TreeView.aspx.cs" Inherits="TreeView.TreeView" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <asp:XmlDataSource runat="server" ID="XmlSource" DataFile="students.xml"></asp:XmlDataSource>
    <form id="MainForm" runat="server">
        <asp:TreeView runat="server" DataSourceID="XmlSource"></asp:TreeView>
    </form>
</body>
</html>
