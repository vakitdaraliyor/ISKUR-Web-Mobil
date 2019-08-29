<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Listing.aspx.cs"  
    MasterPageFile="~/Store.Master" Inherits="SportStore.Pages.Listing"%>
<%@ Import Namespace="SportStore.Model" %>

<asp:Content ContentPlaceHolderID="BodyContent" runat="server">
    
    <div id="content">
        <%            
            foreach(Product product in GetProducts())
            {
                Response.Write("<div class='item'>");
                Response.Write(string.Format("<h3>{0}</h3>", product.NAME));
                Response.Write(product.DESCRIPTION);
                Response.Write(string.Format("<h4>{0}</4>", product.PRICE));
                Response.Write("</div>");
            }
        %>
    </div>
        

    <div class="pager">
        <%
            for (int i = 1; i <=MaxPage; i++)
            {
                Response.Write(string.Format("<a href='/Pages/Listing.aspx?page={0}&category={3}'{1}>{2}</a>", i,
                                                                                                               i==CurrentPage ? "class='selected'" : "",
                                                                                                               i, 
                                                                                                               CurrentCategory));
            }
        %>
    </div>   

</asp:Content>

