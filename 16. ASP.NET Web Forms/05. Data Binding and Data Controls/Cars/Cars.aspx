<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Cars.aspx.cs" Inherits="Cars.Cars" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="MainForm" runat="server">
        <label>Producer</label>
        <asp:DropDownList runat="server" ID="DropDownListProducer" OnSelectedIndexChanged="DropDownListProducer_SelectedIndexChanged" AutoPostBack="true">
            <asp:ListItem>all</asp:ListItem>            
        </asp:DropDownList>

        <label>Model</label>
        <asp:DropDownList runat="server" ID="DropDownListModel" OnSelectedIndexChanged="DropDownListModel_SelectedIndexChanged">
            <asp:ListItem>all</asp:ListItem>
        </asp:DropDownList>

        <br />

        <label>Extras</label>
        <asp:CheckBoxList runat="server" ID="CheckBoxListExtra">
        </asp:CheckBoxList>

        <label>Engine Type</label>
        <asp:RadioButtonList runat="server" ID="RadioButtonListEngine">
        </asp:RadioButtonList>

        <asp:Button runat="server" ID="SearchButton" Text="Search" OnCommand="SearchButton_Command" />

        <br />

        <asp:ListView runat="server" ID="ListViewCars" ItemType="Cars.Producer">
            <LayoutTemplate>
                <asp:PlaceHolder runat="server" ID="itemPlaceholder"></asp:PlaceHolder>
            </LayoutTemplate>

            <ItemTemplate>
                <div>
                    <h3><%#: Item.Name %></h3>
                </div>
            </ItemTemplate>

            <ItemTemplate>
                <div>
                    <h3><%#: Item.Models %></h3>
                </div>
            </ItemTemplate>
        </asp:ListView>

        <asp:Literal runat="server" ID="searchedParams"></asp:Literal>
    </form>
</body>
</html>
