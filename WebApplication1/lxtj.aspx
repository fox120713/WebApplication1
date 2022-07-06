﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="lxtj.aspx.cs" Inherits="WebApplication1.lxtj" %>
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
            line-height:50px;
        }
      
         .auto-style1 {
             height: 52px;
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
                <td class="auto-style1">类型编号：</td>
                <td class="auto-style1" >
                    <asp:TextBox ID="TextBox1" runat="server" Rows="10" Width="200px" Height="30px" ReadOnly="True"></asp:TextBox></td>
            </tr>
             <tr>
                <td>缴费类型:</td>
                <td >
                   <asp:TextBox ID="TextBox2" runat="server" Rows="10" Width="200px" Height="30px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox2" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="TextBox2" ErrorMessage="只能为汉字" ForeColor="Red" ValidationExpression="^[\u4E00-\u9FA5]+$"></asp:RegularExpressionValidator>
                 </td>
            </tr>
            <tr>
                <td>单价:</td>
                <td >
                    <asp:TextBox ID="TextBox3" runat="server" TextMode="DateTime" Width="200px" Height="30px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox3" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TextBox3" ErrorMessage="只能为非负数" ForeColor="Red" ValidationExpression="^[0-9]+([.]{1}[0-9]+){0,1}$"></asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td colspan="2" style="text-align:center">
                    <asp:Button ID="Button1" runat="server" Text="添加" class="btn btn-default" OnClick="Button1_Click" CssClass="btn btn-info"  />&emsp;&emsp;<asp:Button ID="Button2" runat="server" Text="取消"  class="btn btn-default" OnClick="Button2_Click" CssClass="btn btn-info"/></td>
            </tr>
        </table>
    </div>
</div>
</asp:Content>
