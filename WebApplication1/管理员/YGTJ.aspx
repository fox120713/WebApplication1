<%@ Page Title="" Language="C#" MasterPageFile="~/管理员/site.Master" AutoEventWireup="true" CodeBehind="YGTJ.aspx.cs" Inherits="WebApplication1.管理员.YGTJ" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../bp/bootstrap.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="header" runat="server">  
    <link href="../bp/bootstrap.css" rel="stylesheet" />
     <style>
        .panel {
            width:800px;

        }
         tr {
             line-height:60px;
         }
         table {
             margin-left:130px;
         }
         .table-style {
             width:800px;

         }
         .td-style {
             Width:300px;
             height:35px;
         }

         

        </style>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="panel panel-info">
    <div class="panel-heading">
        <h3 class="panel-title">基本信息</h3>
    </div>
    <div class="panel-body ">
        <table class="table-style">
            <tr>
                <td>员工姓名</td>
                <td >
                    <asp:TextBox ID="txtName" runat="server"  class="td-style"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="姓名不能为空！" ClientIDMode="Predictable" ControlToValidate="txtName" Font-Size="12pt" ForeColor="Red"  Font-Strikeout="False" Height="20px" SetFocusOnError="True"></asp:RequiredFieldValidator><asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ErrorMessage="姓名格式不正确" ControlToValidate="txtName" ValidationExpression="[\u4E00-\u9FA5]{2,4}" ForeColor="Red"></asp:RegularExpressionValidator></td>
            </tr>
            <tr>
                <td>员工性别</td>
                <td >
                   男<asp:RadioButton ID="RadioButtonMan" runat="server"  GroupName="sex"/>&emsp;&emsp;&emsp;女<asp:RadioButton ID="RadioButtonFWoMan" runat="server" GroupName="sex" /></td>
            </tr>
            <tr>
                <td>员工年龄</td>
                <td >
                    <asp:TextBox ID="txtAge" runat="server"  class="td-style"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="年龄不能为空！" ClientIDMode="Predictable" ControlToValidate="txtAge" Font-Size="12pt" ForeColor="Red"  Font-Strikeout="False" Height="20px" ></asp:RequiredFieldValidator><asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="未满18岁" Type="Integer" ControlToValidate="txtAge" Operator="GreaterThanEqual" ValueToCompare="18" ForeColor="Red"></asp:CompareValidator></td>
            </tr>
            <tr>
                <td>身份证号</td>
                <td >
                    <asp:TextBox ID="txtCell" runat="server"  class="td-style"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="身份证号不能为空！" ClientIDMode="Predictable" ControlToValidate="txtCell" Font-Size="12pt" ForeColor="Red"  Font-Strikeout="False" Height="20px" SetFocusOnError="True"></asp:RequiredFieldValidator> <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="身份证格式错误" ControlToValidate="txtCell" ForeColor="Red" ValidationExpression="[1-9]\d{5}(18|19|20|(3\d))\d{2}((0[1-9])|(1[0-2]))(([0-2][1-9])|10|20|30|31)\d{3}[0-9Xx]"></asp:RegularExpressionValidator></td>
            </tr>
            <tr>
                <td>电话号码</td>
                <td >
                    <asp:TextBox ID="txtPhone" runat="server"  class="td-style"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="号码不能为空！" ClientIDMode="Predictable" ControlToValidate="txtPhone" Font-Size="12pt" ForeColor="Red"  Font-Strikeout="False" Height="20px" SetFocusOnError="True"></asp:RequiredFieldValidator><asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ErrorMessage="手机号格式错误" ControlToValidate="txtPhone" ForeColor="Red" ValidationExpression="[1]{1}[0-9]{10}"></asp:RegularExpressionValidator></td>
            </tr>
            <tr>
                <td>入职日期</td>
                <td >
                    <asp:TextBox ID="txtDate" runat="server"  class="td-style" ReadOnly="True"></asp:TextBox></td>
            </tr>
            <tr>
                <td>所属部门</td>
                <td >
                    <asp:DropDownList ID="DropDownListPos" runat="server"  AutoPostBack="true"></asp:DropDownList></td>
            </tr>
            <tr>
                <td> 员工图片 </td>
                <td><asp:FileUpload ID="FileUpload1" runat="server" /></td>
            </tr>
            <tr >
                <td colspan="2" >
                    &emsp;&emsp; &emsp;&emsp;<asp:Button ID="btnInset" runat="server" Text="添加"  CssClass="btn btn-info btn-lg" Width="114px" OnClick="btnInset_Click"/> &emsp;&emsp; &emsp;&emsp; <asp:Button ID="btnqx" runat="server" Text="取消"  CssClass="btn btn-info btn-lg" Width="114px" OnClick="btnqx_Click"/></td>
            </tr>
        </table>
    </div>
</div>
</asp:Content>
