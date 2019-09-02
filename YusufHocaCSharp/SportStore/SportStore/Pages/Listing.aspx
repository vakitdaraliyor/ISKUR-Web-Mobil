<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Listing.aspx.cs"  
    MasterPageFile="~/Store.Master" Inherits="SportStore.Pages.Listing"%>
<%@ Import Namespace="SportStore.Model" %>

<asp:Content ContentPlaceHolderID="BodyContent" runat="server">
    
    <div id="content">

        <asp:Repeater ItemType="SportStore.Model.Product" SelectMethod="GetProducts" runat="server">
            <ItemTemplate>
                <div class="item">
                    <h3><%# Item.NAME %></h3>
                    <p><%# Item.DESCRIPTION %></p>
                    <h4><%# Item.PRICE %></h4>
                    <button name="ekle" type="submit" value="<%# Item.PRODUCT_REFNO %>">Sepete Ekle</button>
                </div>
            </ItemTemplate>
        </asp:Repeater>
       
        <%/*        
            foreach(Product product in GetProducts())
            {
                Response.Write("<div class='item'>");
                Response.Write(string.Format("<h3>{0}</h3>", product.NAME));
                Response.Write(product.DESCRIPTION);
                Response.Write(string.Format("<h4>{0}</h4>", product.PRICE));
                Response.Write(string.Format("<button name='ekle' type='submit' value='{0}'>Sepete Ekle</button>", product.PRODUCT_REFNO));
                Response.Write("</div>");
            }*/
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

