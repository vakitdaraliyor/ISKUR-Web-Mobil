<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SepetiGoster.aspx.cs" 
    Inherits="SportStore.Pages.SepetiGoster" MasterPageFile="~/Store.Master"%>
<%@ Import Namespace="SportStore.Model" %>

<asp:Content name="SepetiGoster" ContentPlaceHolderID="BodyContent" runat="server">
    <div id="content">
        <h2>Sepetim</h2>

        <!--Sepet tablosu start -->
        <table id="sepetTablosu">
            <thead>
                <tr>
                    <td>Miktar</td>
                    <td>Ürün Adı</td>
                    <td>Ürün Fiyatı</td>
                    <td>Ara Toplam</td>
                </tr>
            </thead>

            <tbody>
                <asp:Repeater ItemType="SportStore.Model.SepetElemani" SelectMethod="SepetElemanlariniGetir" runat="server" EnableViewState="false">
                    <ItemTemplate>
                        <tr>
                            <td><%# Item.adet %></td>
                            <td><%# Item.urun.NAME %></td>
                            <td><%# Item.urun.PRICE %></td>
                            <td><%# (Item.urun.PRICE * Item.adet) %></td>
                            <td>
                                <button type="submit" name="sil" value="<%# Item.urun.PRODUCT_REFNO %>">Çıkar</button>
                            </td>
                        </tr>
                    </ItemTemplate>
                </asp:Repeater>
            </tbody>
            <tfoot>
                <tr>
                    <td colspan="3"></td>
                    <td><%= SepetToplami.ToString() %></td>
                </tr>                
            </tfoot>

        </table>
        <!--Sepet tablosu start -->
    </div>
</asp:Content>
