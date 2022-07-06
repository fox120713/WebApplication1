<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="buyhome_1.aspx.cs" Inherits="WebApplication1.buyhome_1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="css/bootstrap.css" rel="stylesheet" />
    <style type="text/css">
        .table_box {
            height: 600px;
            width: 800px;
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
		<h3 class="panel-title">登记信息</h3>
	</div>
	<div class="panel-body">

    <div class="table_box">
        <table>
            <tr>
                <td>房屋门牌号：</td>
                <td class="table_box_label">
                    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>业主姓名：</td>
                <td class="table_box_label">
                    <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="*" ControlToValidate="TextBox1" ForeColor="Red"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ErrorMessage="姓名格式不正确" ControlToValidate="TextBox4" ValidationExpression="[\u4E00-\u9FA5]{2,4}" ForeColor="Red"></asp:RegularExpressionValidator>
                </td>
            </tr>

            <tr>
                <td>业主性别： </td>
                <td class="table_box_label">
                    <asp:RadioButton ID="RadioButton2" runat="server" GroupName="sex" />男
                    <asp:RadioButton ID="RadioButton1" runat="server" GroupName="sex" />女
                </td>
            </tr>

            <tr>
                <td>业主年龄：</td>
                <td class="table_box_label">
                    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="*" ControlToValidate="TextBox2" ForeColor="Red"></asp:RequiredFieldValidator>
                    <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="未满18岁" Type="Integer" ControlToValidate="TextBox2" Operator="GreaterThanEqual" ValueToCompare="18" ForeColor="Red"></asp:CompareValidator>
                </td>
            </tr>

            <tr>
                <td>业主电话：</td>
                <td class="table_box_label">
                    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="*" ControlToValidate="TextBox2" ForeColor="Red"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ErrorMessage="手机号格式错误" ControlToValidate="TextBox3" ForeColor="Red" ValidationExpression="[1]{1}[0-9]{10}"></asp:RegularExpressionValidator>
                </td>
            </tr>

            <tr>
                <td>业主身份证：</td>
                <td class="table_box_label">
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="*" ControlToValidate="TextBox1" ForeColor="Red"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="身份证格式错误" ControlToValidate="TextBox1" ForeColor="Red" ValidationExpression="[1-9]\d{5}(18|19|20|(3\d))\d{2}((0[1-9])|(1[0-2]))(([0-2][1-9])|10|20|30|31)\d{3}[0-9Xx]"></asp:RegularExpressionValidator>
                </td>
            </tr>

            <tr>
                <td colspan="2" class="table_box_button">
                    <asp:Button ID="Button2" runat="server" Text="确定" OnClick="Button2_Click"   class="btn btn-info"/>
                    <asp:Button ID="Button1" runat="server" Text="取消"  class="btn btn-info"  OnClick="Button1_Click"/>
                </td>
            </tr>
        </table>
        </div>
        	</div>
</div>
</asp:Content>
