<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="_1.Random.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="MainForm" runat="server">
        <div>
            <label>Generate Random number in given range</label>
            <br />
            Min:<input id="min" type="text" runat="server" />
            <br />
            Max:<input id="max" type="text" runat="server" />
            <br />
            <input id="ButtonSubmit" type="button"
              runat="server" value="Generate"
              onserverclick="ButtonSubmit_Click" />
            <br />
            Result:<input id="result" type="text" runat="server" />
        </div>
        <br />
        <br />
        <div>
            <asp:Label runat="server" Text="Generate Random number in given range" />
            <br />
            Min:<asp:TextBox ID="minWeb" runat="server" />
            <br />
            Max:<asp:TextBox ID="maxWeb" runat="server" />
            <br />
            <asp:Button ID="ButtonSubmitWeb" runat="server" 
                Text="Generate" OnClick="ButtonSubmitWeb_Click" />
            <br />
            Result:<asp:TextBox ID="resultWeb" runat="server" />
        </div>
    </form>
</body>
</html>
