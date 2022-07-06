<%@ Page Title="" Language="C#" MasterPageFile="~/管理员/site.Master" AutoEventWireup="true" CodeBehind="CGSP.aspx.cs" Inherits="WebApplication1.管理员.CGSP" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../bp/bootstrap.css" rel="stylesheet" />
    <style>
        #Image1 {
            width:180px;
            height:180px;
        }
        tr {
            height:60px;
        }

    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="header" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div class="panel panel-primary">
	<div class="panel-heading">
		<h3 class="panel-title">采购审批</h3>
	</div>
	<div class="panel-body">
		    <table>
        <tr>
            <td>编号:</td>
            <td>
                <asp:Label ID="LabelBH" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
             
                <tr>
                    <td> 商品名称:</td>
            <td>
               <asp:Label ID="LabelName" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>商品图片:</td>
            <td>
                 <asp:Image ID="Image1" runat="server" ImageUrl="~/cgimg/tp1.png" />
            </td>
           
        </tr>
        <tr>
            <td>
                申请金额：
            </td>
            <td>
                <asp:Label ID="LabelMoney" runat="server" Text="Label"></asp:Label></td>
        </tr>
        <tr>
            <td>拒绝原因</td>
            <td>
                <asp:TextBox ID="TextBoxYY" runat="server" TextMode="MultiLine"></asp:TextBox></td>

        </tr>
         <tr>
             <td >
                 <asp:Button ID="Button1" runat="server" Text="提交" OnClick="Button1_Click"  class="btn btn-success"/></td>
             <td>
                 <asp:Button ID="Button2" runat="server" Text="取消" OnClick="Button2_Click"  class="btn btn-success"/></td>
         </tr>
         

    </table>
	</div>
</div>

</asp:Content>
