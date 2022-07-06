<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="gongaoadd.aspx.cs" Inherits="WebApplication1.gongaoadd" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="css/bootstrap.css" rel="stylesheet" />
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="header" runat="server">
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="panel panel-info">
	<div class="panel-heading">
		<h3 class="panel-title">公告添加</h3>
	</div>
	<div class="panel-body">

     <table class="table">
                <tr>
                    <td>公告标题：</td>
                    <td>
                        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>公告内容：</td>
                    <td>
                        <asp:TextBox ID="TextBox3" runat="server" Height="80px" TextMode="MultiLine" Width="303px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>公告申请人： </td>
                    <td>
                        <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="Button3" runat="server" Text="确定" BackColor=" #0094ff" ForeColor="White" Height="30px" class="btn btn-info" OnClick="Button3_Click" />
                    </td>
                    <td>
                        <asp:Button ID="Button2" runat="server" Text="取消" BackColor=" #0094ff" ForeColor="White" Height="30px"  class="btn btn-info" OnClick="Button2_Click" />
                    </td>
                </tr>
            </table>

        	</div>
</div>
</asp:Content>
