<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="NewsSystem.Home" %>

<asp:Content ID="ContentHome" ContentPlaceHolderID="MainContent" runat="server">
    <h1>News</h1>
    <asp:Repeater ID="RepeaterArticles" runat="server" 
        ItemType="NewsSystem.Models.Article"
        SelectMethod="RepeaterArticles_GetItems">
        <HeaderTemplate>
            <h2>Most popular articles</h2>
        </HeaderTemplate>
        <ItemTemplate>
            <div class="row">
                <h3>
                    <a href="ViewArticle.aspx?id=<%# Item.Id %>">
                        <%#: Item.Title %>
                    </a>
                    <small><%#: Item.Category.Name %></small>
                </h3>
                <p>
                    <%#:
                        Item.Content.Length >= 300 ? Item.Content.Substring(0, 300) + "..." : Item.Content
                    %>
                </p>
                <p>Likes: <%#: Item.Likes.Count %></p>
                <div>
                    <i>by <%#: Item.Author.UserName %> created on: <%#: Item.DateCreated %></i>
                </div>
            </div>
        </ItemTemplate>
    </asp:Repeater>

    <asp:ListView runat="server" ID="ListViewCategories"
        ItemType="NewsSystem.Models.Category"
        SelectMethod="ListViewCategories_GetData"
        GroupItemCount="2">
        <LayoutTemplate>
            <h2>All categories</h2>
            <div runat="server" id="itemPlaceholder"></div>
            <asp:PlaceHolder runat="server" ID="groupPlaceHolder"></asp:PlaceHolder>
        </LayoutTemplate>
        <GroupTemplate>
            <div class="row">
                <asp:PlaceHolder runat="server" ID="itemPlaceHolder"></asp:PlaceHolder>
            </div>
        </GroupTemplate>
        <ItemTemplate>
            <div class="col-md-6">
                <h3><%#: Item.Name %></h3>
                <asp:ListView
                    runat="server"
                    ID="lvArticlesForCategory"
                    DataSource="<%# Item.Articles.OrderByDescending(x => x.DateCreated).Take(3) %>"
                    ItemType="NewsSystem.Models.Article">
                    <LayoutTemplate>
                        <ul>
                            <li runat="server" id="itemPlaceholder"></li>
                        </ul>
                    </LayoutTemplate>
                    <ItemTemplate>
                        <li>
                            <a href="ViewArticle.aspx?id=<%# Item.Id %>"><strong><%#: Item.Title %></strong> <i>by <%#: Item.Author.UserName %></i></a>
                        </li>
                    </ItemTemplate>
                    <EmptyDataTemplate>
                        <p>No articles.</p>
                    </EmptyDataTemplate>
                </asp:ListView>
            </div>
        </ItemTemplate>
    </asp:ListView>
</asp:Content>
