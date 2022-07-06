<%@ Page Title="" Language="C#" MasterPageFile="~/管理员/site.Master" AutoEventWireup="true" CodeBehind="GGTj.aspx.cs" Inherits="WebApplication1.管理员.GGTj" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
      <link href="../bootstrap.css" rel="stylesheet" />
    <style>
        .panel {
            margin-top:30px;
            width:80%;
            margin:0 auto;
            height:500px;
        }
        table {
            margin:0 auto;
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
<asp:Content ID="Content2" ContentPlaceHolderID="header" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="panel panel-info">
    <div class="panel-heading">
        <h3 class="panel-title">基本信息</h3>
    </div>
    <div class="panel-body ">
        <table class="input-group">
            <tr>
                <td>标题:</td>
                <td >
                    <input id="Text1" type="text" /></td>
            </tr>
             <tr>
                <td>内容:</td>
                <td >
                    <textarea></textarea></td>
            </tr>
             <tr>
                <td>发布时间:</td>
                <td > 
                  <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar></td>
            </tr>
             <tr>
                <td>上传图片:</td>
                <td >
                    <asp:Image ID="Image1" runat="server" /></td>
            </tr>
            <tr>
                <td colspan="2" style="text-align:center">
                    <asp:Button ID="Button1" runat="server" Text="提交" class="btn btn-default"/>&emsp;<asp:Button ID="Button2" runat="server" Text="取消"  class="btn btn-default"/></td>
            </tr>
        </table>
    </div>
</div>
</asp:Content>
