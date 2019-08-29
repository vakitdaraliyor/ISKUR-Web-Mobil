<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="CategoryList.ascx.cs" 
    Inherits="SportStore.Controls.CategoryList" %>

<%
    foreach (var category in GetCategories())
    {
        Response.Write(CreateLinkHtml(category));
    }
%>
