<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ViewArticle.aspx.cs" Inherits="NewsSystem.ViewArticle" %>

<asp:Content ID="ContentViewArticle" ContentPlaceHolderID="MainContent" runat="server">
    <asp:FormView runat="server" ID="FormViewArticle"
         ItemType="NewsSystem.Models.Article"
         SelectMethod="FormViewArticle_GetItem">
        <ItemTemplate>
            <h2>
                <div class="like-control col-md-1 text-center">
                    <div class="lead">Likes
                        <asp:LinkButton runat="server" ID="ButtonLike" CssClass="btn btn-default glyphicon glyphicon-chevron-up" /> <br />
                        <asp:Label runat="server" ID="LabelValue" CssClass="like-value"  Text="<%#: Item.Likes.Count %> "/> <br />
                        <asp:LinkButton runat="server" ID="ButtonDislike" CssClass="btn btn-default glyphicon glyphicon-chevron-down" /> <br />
                    </div>
                </div>
                <%#: Item.Title %> 
                <small>Category: <%#: Item.Category.Name %></small>
            </h2>
            <p><%#: Item.Content %></p>
            <p>
                <span>Author: <%#: Item.Author.UserName %></span>
                <span class="pull-right"><%#: Item.DateCreated %></span>
            </p>
        </ItemTemplate>
    </asp:FormView>
</asp:Content>
