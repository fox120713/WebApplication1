<%@ Page Title="" Language="C#" MasterPageFile="~/业主/SiteYezhu.Master" AutoEventWireup="true" CodeBehind="ZxSq.aspx.cs" Inherits="WebApplication1.业主.ZxSq" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../bp/bootstrap.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="header" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="panel panel-primary">
	<div class="panel-heading">
		<h3 class="panel-title">装修申请</h3>
	</div>
	<div class="panel-body">
		<table>
            <tr>
                <td>门牌号:</td>
                <td>
                    <asp:TextBox ID="TextBox1" runat="server" ReadOnly="True"></asp:TextBox></td>
                </tr>
            <tr>
                <td>开始日期</td>
                <td>
                    <asp:TextBox ID="TextBox2" runat="server" ReadOnly="True"></asp:TextBox></td></tr>
             <tr>
                <td>装修押金:</td>
                 <td>
                     <asp:TextBox ID="TextBox4" runat="server" ReadOnly="True"></asp:TextBox></td>

             </tr>
            <tr>
                <td>装修规划书：</td>
                <td>
                    <asp:FileUpload ID="FileUpload1" runat="server" />
                </td>
                
            </tr>
           
            <tr>
                <td colspan="2"  align="center"><asp:RadioButton ID="RadioButton1" runat="server" /><a href="Zxcns.aspx">装修协议书</a></td>
                
            </tr>
            <tr>
                <td colspan="2"><asp:Button ID="Button1" runat="server" Text="提交申请" OnClick="Button1_Click" cssclass="btn btn-primary" /><asp:Button ID="Button2" runat="server" Text="取消" cssclass="btn btn-primary" OnClick="Button2_Click"/></td>
            </tr>
            

		</table>
	</div>
</div>
</asp:Content>
