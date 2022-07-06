<%@ Page Title="" Language="C#" MasterPageFile="~/管理员/site.Master" AutoEventWireup="true" CodeBehind="YeZhuTJ.aspx.cs" Inherits="WebApplication1.管理员.YeZhuTJ" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../bp/bootstrap.css" rel="stylesheet" />
     <style>
        .panel {
            width:800px;

        }
         tr {
             line-height:60px;
         }
         table {
             margin-left:130px;
         }
         .table-style {
             width:800px;

         }
         .td-style {
             Width:300px;
             height:35px;
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
        <table class="table-style">
            <tr>
                <td>居民姓名</td>
                <td >
                    <asp:TextBox ID="txtName" runat="server"  class="td-style"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="姓名不能为空！" ClientIDMode="Predictable" ControlToValidate="txtName" Font-Size="12pt" ForeColor="Red"  Font-Strikeout="False" Height="20px" SetFocusOnError="True"></asp:RequiredFieldValidator></td>
            </tr>
            <tr>
                <td>居民性别</td>
                <td >
                  &emsp;&emsp;男<asp:RadioButton ID="RadioButtonMan" runat="server"  GroupName="sex"/>&emsp;&emsp;&emsp;女<asp:RadioButton ID="RadioButtonFWoMan" runat="server" GroupName="sex" /></td>
            </tr>
            <tr>
                <td>居民年龄</td>
                <td >
                    <asp:TextBox ID="txtAge" runat="server"  class="td-style"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="年龄不能为空！" ClientIDMode="Predictable" ControlToValidate="txtAge" Font-Size="12pt" ForeColor="Red"  Font-Strikeout="False" Height="20px" ></asp:RequiredFieldValidator></td>
            </tr>
            <tr>
                <td>身份证号</td>
                <td >
                    <asp:TextBox ID="txtCard" runat="server"  class="td-style"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="身份证号不能为空！" ClientIDMode="Predictable" ControlToValidate="txtCard" Font-Size="12pt" ForeColor="Red"  Font-Strikeout="False" Height="20px" SetFocusOnError="True"></asp:RequiredFieldValidator></td>
            </tr>
            <tr>
                <td>楼栋号</td>
                <td >
                    <asp:TextBox ID="txtCell" runat="server"  class="td-style"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="楼栋不能为空！" ClientIDMode="Predictable" ControlToValidate="txtCell" Font-Size="12pt" ForeColor="Red"  Font-Strikeout="False" Height="20px" SetFocusOnError="True"></asp:RequiredFieldValidator></td>
            </tr>
            <tr>
                <td>电话号码</td>
                <td >
                    <asp:TextBox ID="txtPhone" runat="server"    class="td-style"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="电话号码不能为空！" ClientIDMode="Predictable" ControlToValidate="txtPhone" Font-Size="12pt" ForeColor="Red"  Font-Strikeout="False" Height="20px" SetFocusOnError="True"></asp:RequiredFieldValidator></td>
            </tr>
            <tr>
                <td> 居民图片 </td>
                <td><asp:FileUpload ID="FileUpload1" runat="server" /></td>
            </tr>
            <tr >
                <td colspan="2" >
                    &emsp;&emsp; &emsp;&emsp;<asp:Button ID="btnInset" runat="server" Text="添加"  CssClass="btn btn-info btn-lg" Width="114px" OnClick="btnInset_Click" /> &emsp;&emsp; &emsp;&emsp; <asp:Button ID="btnqx" runat="server" Text="取消"  CssClass="btn btn-info btn-lg" Width="114px"/></td>
            </tr>
        </table>
    </div>
</div>
</asp:Content>
