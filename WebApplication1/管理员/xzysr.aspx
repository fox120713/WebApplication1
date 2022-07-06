<%@ Page Title="" Language="C#" MasterPageFile="~/管理员/site.Master" AutoEventWireup="true" CodeBehind="xzysr.aspx.cs" Inherits="WebApplication1.管理员.xzysr" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="css/bootstrap.css" rel="stylesheet" />
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
			装修审核
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
                <td>门牌号：</td>
                <td>
                    <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label></td>
            </tr>
            
          
            <tr>
                <td>装修规划：</td>
                <td>

                    <asp:Image ID="Image1" runat="server" />
                </td>

            </tr>
           <tr>
               <td>选择验收人：</td>
               <td>
                   <asp:DropDownList ID="DropDownList1" runat="server"></asp:DropDownList></td>
           </tr>
        </table>
       
    <br />
        <asp:Button ID="Button1" runat="server" Text="确认" class="btn btn-success"  OnClick="Button1_Click"/>
	</div>
</div>
</asp:Content>
