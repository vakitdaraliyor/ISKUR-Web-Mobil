<%@ Page Title="" Language="C#" MasterPageFile="~/Anasayfa.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="FIRMA_ASPX.Home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 350px;
        }
    </style>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    
    <div id="urunler">
        <div id="urunbaslik" class="auto-style1">ÜRÜNLER</div>
        <asp:DataList ID="DataList1" runat="server" Width="50%">
            <AlternatingItemTemplate>
                <table cellspacing="0" class="auto-style1">
                    <tr>
                        <td class="auto-style2" style="vertical-align: top;">
                            <asp:HyperLink ID="HyperLink4" runat="server" NavigateUrl='<%# "~/Urundetay.aspx?urun_refno="+Eval("URUN_REFNO") %>' Text='<%# Eval("URUN_ADI") %>'></asp:HyperLink>
                            <br />
                            <asp:Label ID="Label3" runat="server" Text='<%# Eval("ACIKLAMA") %>'></asp:Label>
                        </td>
                        <td style="width: 100px; height: 150px;">
                            <asp:Image ID="Image3" runat="server" Height="150px" ImageUrl='<%# "~/images/urun/"+Eval("RESIM1") %>' Width="100px" CssClass="resimyuvarla" />
                        </td>
                    </tr>
                </table>
            </AlternatingItemTemplate>
            <ItemTemplate>
                <table cellspacing="0" class="auto-style1">
                    <tr>
                        <td style="width: 100px; height: 150px">
                            <asp:Image ID="Image1"  runat="server" Height="150px" ImageUrl='<%# "~/images/urun/"+Eval("RESIM1") %>' Width="100px" CssClass="resimyuvarla" />
                        </td>
                        <td style="vertical-align: top">
                            <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl='<%# "~/Urundetay.aspx?urun_refno="+Eval("URUN_REFNO") %>' Text='<%# Eval("URUN_ADI") %>'></asp:HyperLink>
                            <br />
                            <asp:Label ID="Label2" runat="server" Text='<%# Eval("ACIKLAMA") %>'></asp:Label>
                            <asp:Label ID="Label3" runat="server" Text='<%# Eval("FIYATI") %>'></asp:Label>
                        </td>
                    </tr>
                </table>
            </ItemTemplate>
        </asp:DataList>
    </div>

    <div id="projeler">
        <div id="projebaslik">PROJELER</div>
        <asp:DataList ID="DataList2" runat="server" Width="50%">
            <AlternatingItemTemplate>
                <table cellspacing="0" class="auto-style1">
                    <tr>
                        <td class="auto-style2" style="vertical-align: top;">
                            <asp:HyperLink ID="HyperLink4" runat="server" NavigateUrl='<%# "~/Projedetay.aspx?proje_refno="+Eval("PROJE_REFNO") %>' Text='<%# Eval("PROJE_ADI") %>'></asp:HyperLink>
                            <br />
                            <asp:Label ID="Label3" runat="server" Text='<%# Eval("ACIKLAMA") %>'></asp:Label>
                        </td>
                        <td style="width: 100px; height: 150px;">
                            <asp:Image ID="Image3" runat="server" Height="150px" ImageUrl='<%# "~/images/proje/"+Eval("RESIM") %>' Width="100px" CssClass="resimyuvarla" />
                        </td>
                    </tr>
                </table>
            </AlternatingItemTemplate>
            <ItemTemplate>
                <table cellspacing="0" class="auto-style1">
                    <tr>
                        <td style="width: 100px; height: 150px">
                            <asp:Image ID="Image1"  runat="server" Height="150px" ImageUrl='<%# "~/images/proje/"+Eval("RESIM") %>' Width="100px" CssClass="resimyuvarla" />
                        </td>
                        <td style="vertical-align: top">
                            <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl='<%# "~/Projedetay.aspx?proje_refno="+Eval("PROJE_REFNO") %>' Text='<%# Eval("PROJE_ADI") %>'></asp:HyperLink>
                            <br />
                            <asp:Label ID="Label2" runat="server" Text='<%# Eval("ACIKLAMA") %>'></asp:Label>
                        </td>
                    </tr>
                </table>
            </ItemTemplate>
        </asp:DataList>
    </div>

</asp:Content>
