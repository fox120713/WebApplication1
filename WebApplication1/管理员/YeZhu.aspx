<%@ Page Title="" Language="C#" MasterPageFile="~/管理员/site.Master" AutoEventWireup="true" CodeBehind="YeZhu.aspx.cs" Inherits="WebApplication1.管理员.YeZhu" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../bp/bootstrap.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="panel panel-default">
        <div class="panel-heading">
            <h3 class="panel-title">查询条件
            </h3>
        </div>
        <div class="panel-body">
            业主姓名：<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            业主楼栋号：<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" Text="查询" class="btn btn-success" OnClick="Button1_Click" />
        </div>
        </div>
    <asp:GridView ID="GridViewYezhu" runat="server" AllowPaging="True"  OnPageIndexChanging="GridViewYezhu_PageIndexChanging" AutoGenerateColumns="False" PageSize="15" Width="1232px" class="table table-striped table-bordered table-hover table-condensed" DataKeyNames="UserID" OnRowCancelingEdit="GridViewYezhu_RowCancelingEdit" OnRowDeleting="GridViewYezhu_RowDeleting" OnRowEditing="GridViewYezhu_RowEditing1" OnRowUpdating="GridViewYezhu_RowUpdating1" OnSelectedIndexChanged="GridViewYezhu_SelectedIndexChanged1">
        <Columns>
            <asp:BoundField DataField="UserID" HeaderText="业主编号" ReadOnly="True" />
            <asp:BoundField DataField="UserName" HeaderText="业主姓名" />
            <asp:BoundField DataField="UserSex" HeaderText="业主性别" />
            <asp:BoundField DataField="UserAge" HeaderText="年龄" />
            <asp:BoundField DataField="UserCard" HeaderText="身份证号" />
            <asp:BoundField DataField="UserCell" HeaderText="楼栋号" />
            <asp:BoundField DataField="UserPhone" HeaderText="电话号码" />
            <asp:BoundField DataField="UserPwd" HeaderText="账户密码" />
            <asp:CommandField ShowDeleteButton="True" HeaderText="操作" >
            <FooterStyle ForeColor="#33CC33" />
            </asp:CommandField>
            <asp:CommandField ShowEditButton="True" Visible="False"  />
            <asp:TemplateField HeaderText="详情" ShowHeader="False">
                <ItemTemplate>
                    <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="False" CommandName="Select" Text="选择"  CommandArgument='<%#Eval("UserID") %>' OnCommand="LinkButton1_Command"></asp:LinkButton>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
</asp:Content>
