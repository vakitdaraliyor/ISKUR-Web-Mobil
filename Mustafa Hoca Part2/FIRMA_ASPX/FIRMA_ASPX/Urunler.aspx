<%@ Page Title="" Language="C#" MasterPageFile="~/Anasayfa.Master" AutoEventWireup="true" CodeBehind="Urunler.aspx.cs" Inherits="FIRMA_ASPX.Urunler" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div id="kategoriSol">
        <asp:DataList ID="DataList1" runat="server" Width="100%">
            <ItemTemplate>
                <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl='<%# "~/Urunler.aspx?kategori_id="+Eval("KATEGORI_REFNO") %>' 
                    Text='<%# Eval("KATEGORI_ADI") %>'></asp:HyperLink>
            </ItemTemplate>
        </asp:DataList>
    </div>

    <div id="urunlerSag">
        <div id="baslik">
            <asp:label ID ="Label1" runat="server" text="Label"></asp:label>
        </div>
        <div id="icerik">
            <asp:label ID ="Label2"  runat="server" text="Label"></asp:label>
            <asp:Image ID="Image1" runat="server" />
        </div>
    </div>

</asp:Content>
