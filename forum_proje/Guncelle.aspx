<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Guncelle.aspx.cs" Inherits="Guncelle" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            height: 21px;
        }
        .auto-style2 {
            height: 21px;
            width: 40px;
        }
        .auto-style4 {
            width: 40px;
        }
    .auto-style5 {
        margin-left: 258px;
    }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table style="width:100%;">
        <tr>
            <td class="auto-style2">
                <asp:Label ID="Label1" runat="server" Text="Başlık: "></asp:Label>
            </td>
            <td class="auto-style1">
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style1"></td>
        </tr>
        <tr>
            <td class="auto-style4">
                <asp:Label ID="Label2" runat="server" Text="Konu: "></asp:Label>
            </td>
            <td>
                <textarea id="TextArea1" cols="40" name="S1"  runat="server" rows="15"></textarea></td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style4">&nbsp;</td>
            <td>
                <asp:Button ID="Button1" runat="server" CssClass="auto-style5" OnClick="Button1_Click" Text="Güncelle" />
            </td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>

