<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="cftj.aspx.cs" Inherits="WebApplication1.cftj" %>
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
                <td>车位编号:</td>
                <td >
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
             <tr>
                <td>车牌号:</td>
                <td >
                   <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox2" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
                 </td>
            </tr>
             <tr>
                <td>进入时间:</td>
                <td >
                    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextBox3" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
                 </td>
            </tr>
            <tr>
                <td colspan="2" style="text-align:center">
                    <asp:Button ID="Button3" runat="server" Text="提交" class="btn btn-default" OnClick="Button3_Click" CssClass="btn btn-info"/>&emsp;<asp:Button ID="Button4" runat="server" Text="取消"   OnClick="Button4_Click" class="btn btn-default" CssClass="btn btn-info"/></td>
            </tr>
        </table>
    </div>
</div>
</asp:Content>
