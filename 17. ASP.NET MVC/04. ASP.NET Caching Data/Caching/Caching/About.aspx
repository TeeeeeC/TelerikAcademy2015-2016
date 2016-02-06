<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="Caching.About" %>
<%@ Register TagPrefix="uc" TagName="user" Src="~/UserControl.ascx" %>

<%@ outputcache duration="3600" varybyparam="none" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <h3>Your application description page.</h3>
    <p>Use this area to provide additional information.</p>
    <p><%: DateTime.Now %></p>
    <uc:user runat="server"></uc:user>
</asp:Content>
