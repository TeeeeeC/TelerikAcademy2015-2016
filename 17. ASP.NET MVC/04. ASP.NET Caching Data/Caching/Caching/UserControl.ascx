<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="UserControl.ascx.cs" Inherits="Caching.UserControl" %>

<%@ OutputCache Duration="600" VaryByParam="none" %>

<div style="outline: 3px solid black; padding: 10px;">
    <h3>I am a cachable user control</h3>
    <h3>My time is: <%= DateTime.Now %></h3>
</div>