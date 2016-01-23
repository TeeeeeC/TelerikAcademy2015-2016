<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EmpDetails.aspx.cs" Inherits="Northwind.EmpDetails" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="MainForm" runat="server">
        <asp:DetailsView ID="DetailsViewEmployee" runat="server" 
	        AutoGenerateRows="true">            
        </asp:DetailsView>
        <asp:HyperLink NavigateUrl="~/Employees.aspx" Text="Back" runat="server"></asp:HyperLink>
    </form>
</body>
</html>
