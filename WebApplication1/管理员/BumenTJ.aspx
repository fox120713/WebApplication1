<%@ Page Title="" Language="C#" MasterPageFile="~/管理员/site.Master" AutoEventWireup="true" CodeBehind="BumenTJ.aspx.cs" Inherits="WebApplication1.管理员.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        .bodyDiv{
            width:100%;
            height:100%;
            background-image: linear-gradient(18deg, #2830c8, #5274d4, #5fb5dd, #52f9e5)
        }
        .bodyBoder {
            width: 420px;
            height: 600px;
            border-radius: 20px;
            border: 1px solid #ccc8c8;
            background-color:white;
            box-shadow: 0 0 10px #007acc;
            margin:0 auto;
        }

    </style>
    <script src="../zdialog.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="header" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="bodyDiv">
        <div class="bodyBoder">
            <div class="navbar-right">
                <table>
                    <tr>
                        <td>部门名称：<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Button ID="Button1" runat="server" Text="确认添加" /></td>
                    </tr>
                </table>
            </div>
        </div>
    </div>
    
</asp:Content>
