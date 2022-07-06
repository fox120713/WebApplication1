<%@ Page Title="" Language="C#" MasterPageFile="~/业主/SiteYezhu.Master" AutoEventWireup="true" CodeBehind="GGweixiuSq.aspx.cs" Inherits="WebApplication1.业主.GGweixiuSq" %>
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
                <td>维修区域</td>
                <td >
                    <asp:DropDownList ID="DropDownList1" runat="server">
                        <asp:ListItem>A区</asp:ListItem>
                        <asp:ListItem>B区</asp:ListItem>
                        <asp:ListItem>C区</asp:ListItem>
                        <asp:ListItem>D区</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
             <tr>
                <td>联系电话:</td>
                <td >
                    <asp:TextBox ID="TextBoxDh" runat="server"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="*" ForeColor="Red" ControlToValidate="TextBoxDh"></asp:RequiredFieldValidator></td>
            </tr>
             <tr>
                <td>问题反馈:</td>
                <td >
                    <asp:TextBox ID="TextBoxFK" runat="server"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="*" ForeColor="Red" ControlToValidate="TextBoxFK"></asp:RequiredFieldValidator></td>
            </tr>
             <tr>
                <td>上传图片:</td>
                <td >
                    <asp:FileUpload ID="FileUpload1" runat="server" /></td>
            </tr>
            <tr>
                <td colspan="2" style="text-align:center">
                    <asp:Button ID="Button1" runat="server" Text="提交"  CssClass="btn btn-info" OnClick="Button1_Click" Width="150"/>&emsp;&emsp;<asp:Button ID="Button2" runat="server" Text="取消" CssClass="btn btn-info"   Width="150" /></td>
            </tr>
        </table>
    </div>
</div>

</asp:Content>
