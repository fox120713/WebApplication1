<%@ Page Title="" Language="C#" MasterPageFile="~/管理员/site.Master" AutoEventWireup="true" CodeBehind="LzSPxx.aspx.cs" Inherits="WebApplication1.管理员.LzSPxx" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../bp/bootstrap.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="header" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="panel panel-primary">
        <div class="panel-heading">
            <h3 class="panel-title">审核信息</h3>
        </div>
        <div class="panel-body">

    <asp:Repeater ID="Repeater1" runat="server" OnItemCommand="Repeater1_ItemCommand">
        <ItemTemplate>
            <table class="table">
                <tr>
                    <td>员工工号</td>
                    <td><%# Eval("YgId") %></td>
                </tr>
                <tr>
                    <td>员工姓名</td>
                    <td><%# Eval("YgName") %></td>
                </tr>
                <tr>
                    <td>员工部门</td>
                    <td><%# Eval("PosName") %></td>
                </tr>
                <tr>
                    <td>员工入职日期</td>
                    <td><%# Eval("YgRdate") %></td>
                </tr>
                <tr>
                    <td>申请离职日期</td>
                    <td><%#Eval("YgSdate") %></td>
                </tr>
                <tr>
                    <td>离职原因</td>
                    <td><%# Eval("YGLzYY") %></td>
                </tr>
            </table>
        </ItemTemplate>

    </asp:Repeater>
            审核:<asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True">
                <asp:ListItem Value="1">通过</asp:ListItem>
                <asp:ListItem Value="2">拒绝</asp:ListItem>
            </asp:DropDownList><br />
            原因:     
            <asp:TextBox ID="TextBox1" runat="server" TextMode="MultiLine" Width="684px"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="原因不能为空!" ForeColor="Red" ControlToValidate="TextBox1"></asp:RequiredFieldValidator><br />
            <asp:Button ID="Button1" runat="server" Text="审核" OnClick="Button1_Click" CssClass="btn btn-primary btn-lg btn-block" /><asp:Button ID="Button2" runat="server" Text="取消" OnClick="Button2_Click" CssClass="btn  btn-lg btn-block" />
        </div>
    </div>
</asp:Content>
