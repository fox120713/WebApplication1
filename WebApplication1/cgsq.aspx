<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="cgsq.aspx.cs" Inherits="WebApplication1.cgsq" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../bp/bootstrap.css" rel="stylesheet" />
    <style>
         .panel {
            margin-top:30px;
            width:80%;
            margin:0px auto;
            height:500px;
        }
         table {
            margin:0px auto;
         }
        tr {
            line-height:50px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="panel panel-info">
        <div class="panel-heading">
            <h3 class="panel-title">基本信息</h3>
        </div>
        <div class="panel-body ">
            <div class="input-group">
                <table class="hh">
                    <tr>
                        <td>商品名称：<asp:TextBox ID="TextBox1" runat="server" Width="200px" Height="30px"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td>商品数量：<asp:TextBox ID="TextBox2" runat="server" Width="200px" Height="30px" OnTextChanged="TextBox2_TextChanged"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextBox3" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
                            <asp:Label ID="Label1" runat="server" ForeColor="Red"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>商品单价：<asp:TextBox ID="TextBox3" runat="server" Width="200px" Height="30px" AutoPostBack="True" OnTextChanged="TextBox3_TextChanged"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox2" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
                            <asp:Label ID="Label2" runat="server" ForeColor="Red"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>商品总价：<asp:TextBox ID="TextBox4" runat="server" Width="200px" Height="30px" ReadOnly="True"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>采购原因：<asp:TextBox ID="TextBox5" runat="server" Width="200px" Height="30px"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="TextBox5" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                     <tr>
                        <td>
                          商品图片：<asp:FileUpload ID="FileUpload1" runat="server" Width="200px" Height="30px" />
                        </td>
                    </tr>
                    <tr>
                        <td>申   请   人：<asp:TextBox ID="TextBox6" runat="server" ReadOnly="True" Width="200px" Height="30px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Button ID="Button1" runat="server" Text="提交申请" OnClick="Button1_Click"  CssClass="btn btn-info" />
                            <asp:Button ID="Button2" runat="server" Text="取消申请" OnClick="Button2_Click"  CssClass="btn btn-info" />
                        </td>
                    </tr>
                </table>
            </div>
        </div>
    </div>
</asp:Content>
