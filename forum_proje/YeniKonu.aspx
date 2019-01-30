<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="YeniKonu.aspx.cs" Inherits="YeniKonu" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
    .auto-style1 {
        width: 37px;
    }
    .auto-style2 {
        width: 37px;
        height: 32px;
    }
    .auto-style3 {
            height: 32px;
        }
        .auto-style4 {
            margin-left: 276px;
        }
        .auto-style5 {
            width: 101%;
        }
        .auto-style6 {
            width: 37px;
            height: 32px;
        }
        .auto-style7 {
            height: 32px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="auto-style5">
    <tr>
        <td class="auto-style2">
            <asp:Label ID="Label2" runat="server" Text="Başlık: "></asp:Label>
        </td>
        <td class="auto-style3">
            <asp:TextBox ID="TextBox1" runat="server" Width="332px"></asp:TextBox>
        </td>
        <td class="auto-style3"></td>
    </tr>
    <tr>
        <td class="auto-style1">
            <asp:Label ID="Label1" runat="server" Text="Konu: "></asp:Label>
        </td>
        <td>
            <textarea id="TextArea1" cols="40" name="S1" rows="15" runat="server"></textarea></td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style6"></td>
        <td class="auto-style7"><asp:Button ID="Button1" runat="server" Text="Oluştur" CssClass="auto-style4" OnClick="Button1_Click" />
        </td>
        <td class="auto-style7"></td>
    </tr>
</table>
</asp:Content>

