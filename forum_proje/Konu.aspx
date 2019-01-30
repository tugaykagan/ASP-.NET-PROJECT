<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Konu.aspx.cs" Inherits="Konu" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style5 {
            height: 181px;
            width:450px;
                float:left;
    word-wrap: break-word;
        }
        .auto-style6 {
            width: 100%;
            height: 135px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="auto-style6">
    <tr>
        <td>
            <b><u><asp:Label ID="Label1" runat="server" Text="Label"></asp:Label></u></b>
        </td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style5">
            <asp:Panel ID="Panel1" runat="server" Height="250px">
                <asp:Label ID="Label2" runat="server" Text="Label" EnableViewState="False"></asp:Label>
            </asp:Panel>
        </td>
        <td class="auto-style5"></td>
        <td class="auto-style5"></td>
    </tr>
    <tr>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
</table>
</asp:Content>

