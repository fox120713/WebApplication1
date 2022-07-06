<%@ Page Title="" Language="C#" MasterPageFile="~/管理员/site.Master" AutoEventWireup="true" CodeBehind="GGSPXX.aspx.cs" Inherits="WebApplication1.管理员.GGSPXX" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../bp/bootstrap.css" rel="stylesheet" />
    <style>
        td {
            width: 300px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="header" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="panel panel-primary">
        <div class="panel-heading">
            <h3 class="panel-title">公告审核</h3>
        </div>
        <div class="panel-body">
    <asp:Repeater ID="Repeater1" runat="server">
        <ItemTemplate>
            <table>
                <tr>
                    <td>公告标题</td>
                    <td><%#Eval("AnnTitle") %></td>
                </tr>
                <tr>
                    <td>公告内容</td>
                    <td><%#Eval("AnnCon") %></td>
                </tr>
                <tr>
                    <td>申请人id</td>
                    <td><%#Eval("AnnsqrID") %></td>
                </tr>
                <tr>
                    <td>申请时间</td>
                    <td><%#Eval("AnnaDate") %></td>
                </tr>
            </table>
        </ItemTemplate>
    </asp:Repeater>
            原因：<asp:TextBox ID="TextBox1" runat="server" TextMode="MultiLine"></asp:TextBox><br />
            <asp:Button ID="Button1" runat="server" Text="通过" class="btn btn-success" OnClick="Button1_Click" />
            <asp:Button ID="Button2" runat="server" Text="拒绝" class="btn btn-danger" OnClick="Button2_Click" />
        </div>
    </div>
</asp:Content>
