<%@ Page Title="" Language="C#" MasterPageFile="~/业主/SiteYezhu.Master" AutoEventWireup="true" CodeBehind="baoxiuSq.aspx.cs" Inherits="WebApplication1.业主.baoxiuSq" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../bootstrap.css" rel="stylesheet" />
    <style>
        .panel {
            margin-top:30px;
            width:80%;
            margin:0 auto;
            height:500px;

        }
        tr {
            line-height:50px;
        }
        input {
            width:200px;
            height:30px;
        }
        table {
            margin:0 auto;
        }
        panel {
             margin:0 auto;
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
                    <asp:TextBox ID="TextBoxMp" runat="server" ReadOnly="True"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="*" ForeColor="Red" ControlToValidate="TextBoxMp"></asp:RequiredFieldValidator>
                </td>
            </tr>
             <tr>
                <td>联系电话:</td>
                <td >
                    <asp:TextBox ID="TextBoxDh" runat="server"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="*" ForeColor="Red" ControlToValidate="TextBoxDh"></asp:RequiredFieldValidator><asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ErrorMessage="手机号格式错误" ControlToValidate="TextBoxDh" ForeColor="Red" ValidationExpression="[1]{1}[0-9]{10}"></asp:RegularExpressionValidator></td>
            </tr>
             <tr>
                <td>问题反馈:</td>
                <td >
                    <asp:TextBox ID="TextBoxFK" runat="server" TextMode="MultiLine"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="*" ForeColor="Red" ControlToValidate="TextBoxFK"></asp:RequiredFieldValidator></td>
            </tr>
             <tr>
                <td>上传图片:</td>
                <td >
                    <asp:FileUpload ID="FileUpload1" runat="server" /></td>
            </tr>
            <tr>
                <td colspan="2" style="text-align:center">
                    <asp:Button ID="Button1" runat="server" Text="提交"  CssClass="btn btn-info" OnClick="Button1_Click" Width="150"/>&emsp;&emsp;<asp:Button ID="Button2" runat="server" Text="取消" CssClass="btn btn-info"   Width="150" OnClick="Button2_Click" /></td>
            </tr>
        </table>
    </div>
</div>
</asp:Content>
