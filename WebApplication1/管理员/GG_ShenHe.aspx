<%@ Page Title="" Language="C#" MasterPageFile="~/管理员/site.Master" AutoEventWireup="true" CodeBehind="GG_ShenHe.aspx.cs" Inherits="WebApplication1.管理员.GG_ShenHe" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../css/bootstrap.css" rel="stylesheet" />
    <style>
        td img {
        width:200px;
        height:300px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="header" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="panel panel-default">
	<div class="panel-heading">
		<h3 class="panel-title">
			维修审核
		</h3>
	</div>
	<div class="panel-body">
        <table>
            <tr>
                <td>业主姓名：</td>
                <td>
                    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label></td>
            </tr>
           <tr>
                <td>维修地点：</td>
                <td>
                    <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label></td>
            </tr>
            <tr>
                <td>维修原因：</td>
                <td>
                    <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label></td>
            </tr>
            <tr>
                <td>联系电话：</td>
                <td>
                    <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label></td>

            </tr>
            <tr>
                <td>维修图片：</td>
                <td>

                    <asp:Image ID="Image1" runat="server" />
                </td>

            </tr>
            <tr>
                <td>选择维修人：</td>
                <td><asp:DropDownList ID="DropDownList1" runat="server"></asp:DropDownList></td>
            </tr>
        </table>
       
    <br />
    <asp:Button ID="Button1" runat="server" Text="通过" class="btn btn-success"  OnClick="Button1_Click"/>
        <asp:Button ID="Button2" runat="server" Text="拒绝" class="btn btn-danger"  OnClick="Button2_Click"/>
	</div>
</div>

</asp:Content>
