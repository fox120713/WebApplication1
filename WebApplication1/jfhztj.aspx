<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="jfhztj.aspx.cs" Inherits="WebApplication1.jfhztj" %>
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
                <td class="auto-style1">楼栋号:</td>
                <td class="auto-style1" >
                    <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="true" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged"></asp:DropDownList>
                        <asp:DropDownList ID="DropDownList2" runat="server" OnSelectedIndexChanged="DropDownList2_SelectedIndexChanged" AutoPostBack="true"></asp:DropDownList>
                        <asp:DropDownList ID="DropDownList3" runat="server" AutoPostBack="true"></asp:DropDownList></td>
            </tr>
             <tr>
                <td>月份:</td>
                <td >
                    <asp:TextBox ID="TextBox4" runat="server"  Width="200px" Height="30px" ReadOnly="True" OnDataBinding="TextBox4_DataBinding" ></asp:TextBox>
                 </td>
            </tr>
            <tr>
                <td>总金额:</td>
                <td >
                    <asp:TextBox ID="TextBox1" runat="server" TextMode="DateTime" Width="200px" Height="30px" ReadOnly="True"></asp:TextBox>
                 </td>
            </tr>
            <tr>
                <td>上月结余:</td>
                <td >
                    <asp:TextBox ID="TextBox2" runat="server" TextMode="DateTime" Width="200px" Height="30px"  AutoPostBack="True" ReadOnly="True"></asp:TextBox>
                 </td>
            </tr>
            <tr>
                <td>本月结余:</td>
                <td >
                    <asp:TextBox ID="TextBox3" runat="server" TextMode="DateTime" Width="200px" Height="30px" ReadOnly="True"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td colspan="2" style="text-align:center">
                    <asp:Button ID="Button1" runat="server" Text="添加" class="btn btn-default"  OnClick="Button1_Click" CssClass="btn btn-info"  />&emsp;&emsp;<asp:Button ID="Button2" runat="server" Text="取消"  class="btn btn-default"  OnClick="Button2_Click" CssClass="btn btn-info"/></td>
            </tr>
        </table>
    </div>
</div>
</asp:Content>
