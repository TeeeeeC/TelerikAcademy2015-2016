<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="MainPage.aspx.cs" Inherits="_2.Company.MainPage" %>
<asp:Content ID="ContentHeader" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="ContentMainPage" ContentPlaceHolderID="ContentPlaceHolderPageContent" runat="server">
    <h1>Welcome to International Company site!</h1>
    <asp:HyperLink runat="server" NavigateUrl="~/BG/Home.aspx" 
        Text="Bulgaria"/>
    <asp:HyperLink runat="server" NavigateUrl="~/UK/Home.aspx"
         Text="United Kingdom"/>
    <asp:HyperLink runat="server" NavigateUrl="~/GER/Home.aspx"
         Text="Germany"/>
</asp:Content>
