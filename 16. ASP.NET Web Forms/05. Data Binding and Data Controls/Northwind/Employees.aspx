<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Employees.aspx.cs" Inherits="Northwind.Employees" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="MainForm" runat="server">
        <asp:GridView ID="GridViewEmployees" runat="server" AutoGenerateColumns="false">
	        <Columns>
		        <asp:BoundField DataField="FirstName"
			        HeaderText="First Name" />
		        <asp:BoundField DataField="LastName"
			        HeaderText="Last Name" />
		        <asp:HyperLinkField Text="Details" DataNavigateUrlFields="Id"
			        DataNavigateUrlFormatString="EmpDetails.aspx?Id={0}" />
	        </Columns>
        </asp:GridView>
    </form>
</body>
</html>
