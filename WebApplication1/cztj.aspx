<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="cztj.aspx.cs" Inherits="WebApplication1.cztj" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../bp/bootstrap.css" rel="stylesheet" />
     <style>
         .panel {
            margin-top:30px;
            width:80%;
            margin:0 auto;
            height:500px;
        }
         table {
             margin:0px auto;
         }
        tr {
            line-height:70px;
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
                <td>
                    账户编号：
                </td>
                <td >
                    <asp:TextBox ID="TextBox1" runat="server" ReadOnly="True"></asp:TextBox>
                </td>
            </tr>
             <tr>
                <td>账户名称：</td>
                <td >
                    <asp:TextBox ID="TextBox2" runat="server" ReadOnly="True"></asp:TextBox>
                 </td>
            </tr>
             <tr>
                <td>账户类型：</td>
                <td >
                    <asp:TextBox ID="TextBox3" runat="server" ReadOnly="True"></asp:TextBox>
                 </td>
            </tr>
            <tr>
                <td>账户金额：</td>
                <td >
                    <asp:TextBox ID="TextBox4" runat="server" ReadOnly="True"></asp:TextBox>
                 </td>
            </tr>
            <tr>
                <td>充值金额：</td>
                <td >
                    <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
                    <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToValidate="TextBox5" ErrorMessage="一次最多充值500元" ForeColor="Red" Operator="LessThanEqual" Type="Integer" ValueToCompare="500"></asp:CompareValidator>
                 </td>
            </tr>
            <tr>
                <td colspan="2" style="text-align:center">
                    <asp:Button ID="Button1" runat="server" Text="提交" class="btn btn-default" OnClick="Button1_Click" CssClass="btn btn-info" />&emsp;<asp:Button ID="Button2" runat="server" Text="取消"  class="btn btn-default" OnClick="Button2_Click" CssClass="btn btn-info" /></td>
            </tr>
        </table>
    </div>
</div>
</asp:Content>
