<%@ Page Title="" Language="C#" MasterPageFile="~/admin/Yonetim.Master" AutoEventWireup="true" CodeBehind="Kullanici.aspx.cs" Inherits="FIRMA_ASPX.admin.Kullanici" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 150px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:Panel ID="pnlLISTE" runat="server">
        <table cellspacing="0" class="auto-style1">
            <tr>
                <td>
                    <asp:Label ID="Label1" runat="server" Text="Kullanıcı Adı"></asp:Label>
                    <asp:TextBox ID="txtARA" runat="server"></asp:TextBox>
                    <asp:Button ID="Button1" runat="server" Text="Ara" OnClick="Button1_Click" />
                    <asp:Button ID="Button2" runat="server" Text="Yeni" OnClick="Button2_Click" />
                </td>
            </tr>
            <tr>
                <td>
                    <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AutoGenerateColumns="False" CellPadding="4" DataKeyNames="KULLANICI_REFNO" ForeColor="#333333" GridLines="None" OnPageIndexChanging="GridView1_PageIndexChanging" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" PageSize="5" Width="100%">
                        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                        <Columns>
                            <asp:CommandField HeaderText="Seç" ShowSelectButton="True" />
                            <asp:BoundField DataField="KULLANICI_REFNO" HeaderText="Kullanıcı Refno" />
                            <asp:BoundField DataField="KULLANICI_ADI" HeaderText="Kullanıcı Adı" />
                            <asp:BoundField DataField="PAROLA" HeaderText="Parola" />
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

    <asp:Panel ID="pnlKAYIT" runat="server" Visible="False">
        <table cellspacing="0" class="auto-style1">
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>
                    <asp:Label ID="Label2" runat="server" Text="KAYIT FORMU"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="Label3" runat="server" Text="Kullanıcı Refno"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtKULLANICI_REFNO" runat="server" MaxLength="50" ReadOnly="True"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="Label4" runat="server" Text="Kullanıcı Adı"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtKULLANICI_ADI" runat="server" MaxLength="50"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtKULLANICI_ADI" ErrorMessage="kullanıcı adı giriniz" ValidationGroup="ValidationGroup1"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="Label5" runat="server" Text="Parola"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtPAROLA" runat="server" MaxLength="50"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtPAROLA" ErrorMessage="parola giriniz" ValidationGroup="ValidationGroup1"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>
                    <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Kaydet" ValidationGroup="ValidationGroup1" />
                    <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="Vazgeç" />
                    <asp:Button ID="Button5" runat="server" OnClick="Button5_Click" OnClientClick="return confirm(&quot;Silmek istediğinize emin misiniz?&quot;)" Text="Sil" />
                </td>
            </tr>
        </table>
    </asp:Panel>

</asp:Content>
