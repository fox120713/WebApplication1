<%@ Page Title="" Language="C#" MasterPageFile="~/业主/SiteYezhu.Master" AutoEventWireup="true" CodeBehind="yzjf.aspx.cs" Inherits="WebApplication1.业主.yzjf" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
     <link href="../bootstrap.css" rel="stylesheet" />
    <style>
        .panel {
            width:800px;

        }
        tr {
            line-height:50px;
        }
        input {
            width:200px;
            height:30px;
        }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="panel panel-info">
    <div class="panel-heading">
        <h3 class="panel-title">基本信息</h3>
    </div>
    <div class="panel-body ">
        <table class="input-group">
            <tr>
                <td>门牌号:</td>
                <td >
                    <asp:TextBox ID="TextBox1" runat="server" ReadOnly="True"></asp:TextBox>
                </td>
            </tr>
             <tr>
                <td>缴费类型:</td>
                <td >
                    <asp:TextBox ID="TextBox2" runat="server" ReadOnly="True"></asp:TextBox></td>
            </tr>
             <tr>
                <td>缴费金额:</td>
                <td >
                    <asp:TextBox ID="TextBox3" runat="server" ReadOnly="True"></asp:TextBox></td>
            </tr>
            <tr>
                <td colspan="2" style="text-align:center">
                    <asp:Button ID="Button1" runat="server" Text="确定" class="btn btn-default" OnClick="Button1_Click"/>&emsp;&emsp;
                    <asp:Button ID="Button2" runat="server" Text="取消"  class="btn btn-default" OnClick="Button2_Click"/></td>
            </tr>
        </table>
    </div>
</div>
</asp:Content>
