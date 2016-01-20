<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="_3.Students.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="MainForm" runat="server">
        <asp:panel runat="server">
            FirstName:<asp:TextBox ID="firstName" runat="server" />
            <br />
            LastName:<asp:TextBox ID="lastName" runat="server" />
            <br />
            Faculty Number:<asp:TextBox ID="fNumber" runat="server" />
            <br />
            University:<asp:DropDownList ID="DropDownListUniversity" runat="server" AutoPostBack="True">
               <asp:ListItem Value="Technical University">Technical University</asp:ListItem>
               <asp:ListItem Value="Sofia University">Sofia University</asp:ListItem>
               <asp:ListItem Value="Bulgarian University">Bulgarian University</asp:ListItem>
            </asp:DropDownList>
            <br />
            Specialy:<asp:DropDownList ID="DropDownListSpecialy" runat="server" AutoPostBack="True">
               <asp:ListItem Value="Software Engineering">Software Engineering</asp:ListItem>
               <asp:ListItem Value="Telecommunication">Telecommunication</asp:ListItem>
               <asp:ListItem Value="Electronics">Electronics</asp:ListItem>
            </asp:DropDownList>
            <br />
            Courses:<asp:ListBox ID="ListBoxCourses" runat="server" SelectionMode="Multiple">
              <asp:ListItem Value="C#">C#</asp:ListItem>
              <asp:ListItem Value="JavaScript">JavaScript</asp:ListItem>
              <asp:ListItem Value="ASP.NET Web Forms">ASP.NET Web Forms</asp:ListItem>
              <asp:ListItem Value="ASP.NET MVC">ASP.NET MVC</asp:ListItem>
            </asp:ListBox>
            <br />
            <asp:Button ID="ButtonSubmitWeb" runat="server" Text="Register" OnClick="Registration_Click" />
        </asp:panel>
    </form>
</body>
</html>
