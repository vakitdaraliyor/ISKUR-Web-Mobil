<%@ Page Title="" Language="C#" MasterPageFile="~/admin/Yonetim.Master" AutoEventWireup="true" CodeBehind="Proje.aspx.cs" Inherits="FIRMA_ASPX.admin.Proje" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 150px;
        }
        .auto-style3 {
            width: 150px;
            height: 21px;
        }
        .auto-style4 {
            height: 21px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:Panel ID="pnlLISTE" runat="server">
        <table cellspacing="0" class="auto-style1">
            <tr>
                <td>
                    <asp:Label ID="Label1" runat="server" Text="Proje Adı"></asp:Label>
                    <asp:TextBox ID="txtARA" runat="server"></asp:TextBox>
                    <asp:Button ID="Button1" runat="server" Text="Ara" OnClick="Button1_Click" />
                    <asp:Button ID="Button2" runat="server" Text="Yeni" OnClick="Button2_Click" />
                </td>
            </tr>
            <tr>
                <td>
                    <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AutoGenerateColumns="False" CellPadding="4" DataKeyNames="PROJE_REFNO" ForeColor="#333333" GridLines="None" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" PageSize="5" Width="100%" OnPageIndexChanging="GridView1_PageIndexChanging">
                        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                        <Columns>
                            <asp:CommandField HeaderText="Seç" ShowSelectButton="True" />
                            <asp:BoundField DataField="PROJE_REFNO" HeaderText="Proje Refno" />
                            <asp:BoundField DataField="PROJE_ADI" HeaderText="Proje Adı" />
                            <asp:BoundField />
                            <asp:ImageField DataImageUrlField="RESIM" HeaderText="Resim" DataImageUrlFormatString="/admin/Images/Proje/{0}">
                                <ControlStyle Height="50px" Width="50px" />
                            </asp:ImageField>
                            <asp:BoundField DataField="ACIKLAMA" HeaderText="Açıklama" />
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
                    <asp:Label ID="Label3" runat="server" Text="Proje Refno"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtPROJE_REFNO" runat="server" ReadOnly="True"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">
                    <asp:Label ID="Label4" runat="server" Text="Proje Adı"></asp:Label>
                </td>
                <td class="auto-style4">
                    <asp:TextBox ID="txtPROJE_ADI" runat="server" MaxLength="50"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtPROJE_ADI" ErrorMessage="proje adı giriniz" ValidationGroup="ValidationGroup1"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="Label5" runat="server" Text="Resim"></asp:Label>
                </td>
                <td>
                    <asp:FileUpload ID="fuRESIM" runat="server" />
                    <asp:Image ID="imgRESIM" Height="50" Width="50" runat="server" />
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="fuRESIM" ErrorMessage="resim yükleyiniz" ValidationGroup="ValidationGroup1"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="Label6" runat="server" Text="Açıklama"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtACIKLAMA" runat="server" Height="143px" TextMode="MultiLine" Width="282px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtACIKLAMA" ErrorMessage="içerik giriniz" ValidationGroup="ValidationGroup1"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>
                    <asp:Button ID="Button3" runat="server" Text="Kaydet" ValidationGroup="ValidationGroup1" OnClick="Button3_Click" />
                    <asp:Button ID="Button4" runat="server" Text="Vazgeç" OnClick="Button4_Click" />
                    <asp:Button ID="Button5" runat="server" OnClientClick="return confirm(&quot;Silmek istediğinize emin misiniz?&quot;)" Text="Sil" OnClick="Button5_Click" />
                </td>
            </tr>
        </table>
    </asp:Panel>
    <script>
        var editor = CKEDITOR.replace('ContentPlaceHolder1_txtACIKLAMA');
        CKFinder.setupCKEditor(editor, '/ckfinder/');
    </script>
</asp:Content>
