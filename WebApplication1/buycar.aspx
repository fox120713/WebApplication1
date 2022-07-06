<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="buycar.aspx.cs" Inherits="WebApplication1.buycar" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .table_box {
            height: 600px;
            width: 500px;
            /*border: 1px solid black;*/
            background-color: white;
            border-radius: 10px;
            font-size: 20px;
        }

            .table_box table tr {
                height: 60px;
                width: 500px;
                text-align: left;
            }

        .table_box_label input {
            width: 200px;
            height: 20px;
        }

        .table_box_button {
            text-align: center;
        }

            .table_box_button input {
                width: 120px;
                height: 30px;
            }
    </style>
    <link href="bp/bootstrap.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="header" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="panel panel-info">
	<div class="panel-heading">
		<h3 class="panel-title">购买车位</h3>
	</div>
	<div class="panel-body">

    <div class="table_box">
        <table>
            <tr>
                <td>车位号：</td>
                <td class="table_box_label">
                    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>车位状态：</td>
                <td class="table_box_label">
                    <asp:Label ID="Label2" runat="server" Text="买断"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>业主车牌号： </td>
                <td class="table_box_label">
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="*" ControlToValidate="TextBox1" ForeColor="Red"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="车牌格式不正确" ControlToValidate="TextBox1" ValidationExpression="[京津沪渝冀豫云辽黑湘皖鲁新苏浙赣鄂桂甘晋蒙陕吉闽贵粤青藏川宁琼使领A-Z]{1}[A-Z]{1}[A-Z0-9]{4}[A-Z0-9挂学警港澳]{1}" ForeColor="Red"></asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td>业主电话：</td>
                <td class="table_box_label">
                    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="*" ControlToValidate="TextBox2" ForeColor="Red"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ErrorMessage="手机号格式错误" ControlToValidate="TextBox2" ForeColor="Red" ValidationExpression="[1]{1}[0-9]{10}" ></asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td colspan="2" class="table_box_button">
                    <asp:Button ID="Button1" runat="server" Text="确认" OnClick="Button1_Click"  class="btn btn-info"/>
                    <asp:Button ID="Button2" runat="server" Text="取消" OnClick="Button2_Click"  class="btn btn-info"/>
                </td>
            </tr>
        </table>
    </div>
        	</div>
</div>
</asp:Content>
