<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="zhibantianjia.aspx.cs" Inherits="WebApplication1.zhibantianjia"  %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
     <style>
        table {
            margin:0px auto; 
        }
        #ContentPlaceHolder1_Button1,#ContentPlaceHolder1_Button1 {
            margin-left:90px;
        }
    </style>
    <link href="../bp/bootstrap.css" rel="stylesheet" />
   
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="panel panel-info">
    <div class="panel-heading">
        <h3 class="panel-title">值班信息</h3>
    </div>
    <div class="panel-body ">
        <table class="input-group">
    
        <tr>
            <td>
                
                员工编号:&nbsp<asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged" AutoPostBack="true"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="不能为空！" ControlToValidate="TextBox1" ForeColor="Red"></asp:RequiredFieldValidator></td>
        </tr>
        
        <tr>
            <td>员工姓名:&nbsp<asp:TextBox ID="TextBox2" runat="server" ReadOnly="True" BackColor="LightGray"></asp:TextBox></td>
        </tr>
        <tr>
            <td>所属部门:&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp;<asp:Label ID="Label1" runat="server" Text="后勤部"></asp:Label></td>
            
        </tr>
        <tr>
            <td>值班日期:&nbsp
                <asp:TextBox ID="TextBox4" runat="server" TextMode="Date"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="不能为空！" ControlToValidate="TextBox4" ForeColor="Red"></asp:RequiredFieldValidator>
                <asp:CustomValidator ID="CustomValidator2" runat="server" ErrorMessage="请选择当日或之后的日期" ControlToValidate="TextBox4" OnServerValidate="CustomValidator2_ServerValidate" ForeColor="Red"></asp:CustomValidator>
            </td>
        </tr>
        <tr>
            <td>工作内容:&nbsp<asp:TextBox ID="TextBox5" runat="server"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="不能为空！" ControlToValidate="TextBox5" ForeColor="Red"></asp:RequiredFieldValidator></td>
        </tr>
        <tr>
            <td>具体时间:&nbsp<asp:DropDownList ID="DropDownList1" runat="server">
                <asp:ListItem Selected="True">6:00--11:00</asp:ListItem>
                <asp:ListItem>2:00--7:00</asp:ListItem>
                </asp:DropDownList>
                </td>
            
            
        </tr>
        <tr >
            <td>
                
                <asp:Button ID="Button2" runat="server" Text="取消" CssClass="btn btn-success" OnClick="Button2_Click"  CausesValidation="false" /><asp:Button ID="Button1" runat="server" Text="添加" OnClick="Button1_Click"  CssClass="btn btn-success"/></td>
        </tr>
        </table>
        <div />
        </div>
        </div>
        
</asp:Content>
