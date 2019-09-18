<%@ Page Title="" Language="C#" MasterPageFile="~/admin/Yonetim.Master" AutoEventWireup="true" CodeBehind="Urun.aspx.cs" Inherits="FIRMA_ASPX.admin.Urun" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
    .auto-style3 {
        width: 150px;
        height: 21px;
    }
    .auto-style4 {
        height: 21px;
    }
    .auto-style5 {
        width: 150px;
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
                    <asp:Button ID="Button1" runat="server" Text="Ara" OnClick="Button1_Click" />
                    <asp:Button ID="Button2" runat="server" Text="Yeni" OnClick="Button2_Click" />
                </td>
            </tr>
            <tr>
                <td>
                    <asp:GridView ID="GridView1" runat="server" Width="100%" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" AllowPaging="True" DataKeyNames="URUN_REFNO" OnPageIndexChanging="GridView1_PageIndexChanging" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" PageSize="5">
                        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                        <Columns>
                            <asp:CommandField HeaderText="Seç" ShowSelectButton="True" />
                            <asp:BoundField DataField="URUN_REFNO" HeaderText="Ürün Refno" />
                            <asp:BoundField DataField="URUN_ADI" HeaderText="Ürün Adı" />
                            <asp:BoundField DataField="FIYATI" HeaderText="Fiyatı" />
                            <asp:BoundField DataField="DURUMU" HeaderText="Durumu" />
                            <asp:BoundField DataField="KATEGORI_ADI" HeaderText="Kategori Adı" />
                            <asp:BoundField DataField="KDV_ORANI" HeaderText="Kdv Oranı" />
                            <asp:BoundField DataField="MARKA_ADI" HeaderText="Marka Adı" />
                            <asp:BoundField DataField="ACIKLAMA" HeaderText="Açıklama" HtmlEncode="False" />
                            <asp:ImageField DataImageUrlField="RESIM1" DataImageUrlFormatString="/admin/Images/{0}" HeaderText="Resim1" ControlStyle-Width="50" ControlStyle-Height = "50"></asp:ImageField>
                            <asp:ImageField DataImageUrlField="RESIM2" DataImageUrlFormatString="/admin/Images/{0}" HeaderText="Resim2" ControlStyle-Width="50" ControlStyle-Height = "50"></asp:ImageField>
                            <asp:ImageField DataImageUrlField="RESIM3" DataImageUrlFormatString="/admin/Images/{0}" HeaderText="Resim3" ControlStyle-Width="50" ControlStyle-Height = "50"></asp:ImageField>
                            <asp:ImageField DataImageUrlField="RESIM4" DataImageUrlFormatString="/admin/Images/{0}" HeaderText="Resim4" ControlStyle-Width="50" ControlStyle-Height = "50"></asp:ImageField>
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
                <td class="auto-style5">&nbsp;</td>
                <td>
                    <asp:Label ID="Label2" runat="server" Text="KAYIT FORMU"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">
                    <asp:Label ID="Label3" runat="server" Text="Ürün Refno"></asp:Label>
                </td>
                <td class="auto-style4">
                    <asp:TextBox ID="txtURUN_REFNO" runat="server" ReadOnly="True"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style5">
                    <asp:Label ID="Label4" runat="server" Text="Ürün Adı"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtURUN_ADI" runat="server" MaxLength="50"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtURUN_ADI" ErrorMessage="ürün adı giriniz" ValidationGroup="ValidationGroup"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">
                    <asp:Label ID="Label5" runat="server" Text="Fiyatı"></asp:Label>
                </td>
                <td class="auto-style4">
                    <asp:TextBox ID="txtFIYATI" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtFIYATI" ErrorMessage="fiyatı giriniz" ValidationGroup="ValidationGroup"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style5">
                    <asp:Label ID="Label6" runat="server" Text="Durumu"></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="ddlDURUMU" runat="server">
                        <asp:ListItem Selected="True" Value="True">Aktif</asp:ListItem>
                        <asp:ListItem Value="False">Pasif</asp:ListItem>
                    </asp:DropDownList>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="ddlDURUMU" ErrorMessage="durumu seçiniz" ValidationGroup="ValidationGroup"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style5">
                    <asp:Label ID="Label7" runat="server" Text="Kategori Adı"></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="ddlKATEGORI_ADI" runat="server">
                    </asp:DropDownList>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="ddlKATEGORI_ADI" ErrorMessage="kategori seçiniz" ValidationGroup="ValidationGroup"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style5">
                    <asp:Label ID="Label8" runat="server" Text="Kdv Oranı"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtKDV_ORANI" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="txtKDV_ORANI" ErrorMessage="kdv oranı giriniz" ValidationGroup="ValidationGroup"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style5">
                    <asp:Label ID="Label9" runat="server" Text="Marka Adı"></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="ddlMARKA_ADI" runat="server">
                    </asp:DropDownList>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="ddlMARKA_ADI" ErrorMessage="marka seçiniz" ValidationGroup="ValidationGroup"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style5">
                    <asp:Label ID="Label10" runat="server" Text="Açıklama"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtACIKLAMA" runat="server" Height="132px" TextMode="MultiLine" Width="327px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style5">
                    <asp:Label ID="Label11" runat="server" Text="Resim1"></asp:Label>
                </td>
                <td>
                    <asp:FileUpload ID="fuRESIM1" runat="server" />
                    <asp:Image ID="imgRESIM1" Height="50" Width="50" runat="server" />
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="fuRESIM1" ErrorMessage="resim seçiniz" ValidationGroup="ValidationGroup"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style5">
                    <asp:Label ID="Label12" runat="server" Text="Resim2"></asp:Label>
                </td>
                <td>
                    <asp:FileUpload ID="fuRESIM2" runat="server" />
                    <asp:Image ID="imgRESIM2" Height="50" Width="50" runat="server" />
                </td>
            </tr>
            <tr>
                <td class="auto-style5">
                    <asp:Label ID="Label13" runat="server" Text="Resim3"></asp:Label>
                </td>
                <td>
                    <asp:FileUpload ID="fuRESIM3" runat="server" />
                    <asp:Image ID="imgRESIM3" Height="50" Width="50" runat="server" />
                </td>
            </tr>
            <tr>
                <td class="auto-style5">
                    <asp:Label ID="Label14" runat="server" Text="Resim4"></asp:Label>
                </td>
                <td>
                    <asp:FileUpload ID="fuRESIM4" runat="server" />
                    <asp:Image ID="imgRESIM4" Height="50" Width="50" runat="server" />
                </td>
            </tr>
            <tr>
                <td class="auto-style5">&nbsp;</td>
                <td>
                    <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Kaydet" ValidationGroup="ValidationGroup" />
                    <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="Vazgeç" />
                    <asp:Button ID="Button5" runat="server" OnClick="Button5_Click" Text="Sil" />
                </td>
            </tr>
        </table>
    </asp:Panel>
    <script>
        var editor = CKEDITOR.replace('ContentPlaceHolder1_txtACIKLAMA');
        CKFinder.setupCKEditor(editor, '/ckfinder/');
    </script>
</asp:Content>
