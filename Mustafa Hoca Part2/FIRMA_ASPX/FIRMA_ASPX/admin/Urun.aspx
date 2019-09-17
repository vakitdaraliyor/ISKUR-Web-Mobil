<%@ Page Title="" Language="C#" MasterPageFile="~/admin/Yonetim.Master" AutoEventWireup="true" CodeBehind="Urun.aspx.cs" Inherits="FIRMA_ASPX.admin.Urun" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Panel ID="pnlLISTE" runat="server">
        <table cellspacing="0" class="auto-style1">
            <tr>
                <td>
                    <asp:Label ID="Label1" runat="server" Text="Ürün Adı"></asp:Label>
                    <asp:TextBox ID="txtARA" runat="server"></asp:TextBox>
                    <asp:Button ID="Button1" runat="server" Text="Ara" />
                    <asp:Button ID="Button2" runat="server" Text="Yeni" />
                </td>
            </tr>
            <tr>
                <td>
                    <asp:GridView ID="GridView1" runat="server" Width="100%">
                    </asp:GridView>
                </td>
            </tr>
        </table>
    </asp:Panel>
    <asp:Panel ID="pnlKAYIT" runat="server">
    </asp:Panel>
</asp:Content>
