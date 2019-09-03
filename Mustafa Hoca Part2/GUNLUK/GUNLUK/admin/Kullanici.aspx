<%@ Page Title="" Language="C#" MasterPageFile="~/admin/Yonetim.Master" AutoEventWireup="true" CodeBehind="Kullanici.aspx.cs" Inherits="GUNLUK.admin.Kullanici" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
    .auto-style1 {
        width: 100%;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:Panel ID="Panel1" runat="server">
    <table cellspacing="0" class="auto-style1">
        <tr>
            <td>
                <asp:Label ID="Label1" runat="server" Text="Kullanıcı Adı:"></asp:Label>
                <asp:TextBox ID="txtARA" runat="server"></asp:TextBox>
                <asp:Button ID="Button1" runat="server" Text="Ara" />
                <asp:Button ID="Button2" runat="server" Text="Yeni" />
            </td>
        </tr>
        <tr>
            <td>
                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" Width="100%">
                    <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                    <Columns>
                        <asp:CommandField HeaderText="Seç" ShowSelectButton="True" />
                        <asp:BoundField DataField="KULLANICI_REFNO" HeaderText="Kullanıcı Refno" />
                        <asp:BoundField DataField="KULLANICI_ADI" HeaderText="Kullanıcı Adı" />
                        <asp:BoundField DataField="DURUMU" HeaderText="Durumu" />
                    </Columns>
                    <EditRowStyle BackColor="#999999" />
                    <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                    <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                    <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                    <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                    <SortedAscendingCellStyle BackColor="#E9E7E2" />
                    <SortedAscendingHeaderStyle BackColor="#506C8C" />
                    <SortedDescendingCellStyle BackColor="#FFFDF8" />
                    <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
                </asp:GridView>
            </td>
        </tr>
    </table>

    </asp:Panel>
    <asp:Panel ID="Panel2" runat="server">

    </asp:Panel>

</asp:Content>
