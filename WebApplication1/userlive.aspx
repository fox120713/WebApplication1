<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="userlive.aspx.cs" Inherits="WebApplication1.userlive" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="css/bootstrap.css" rel="stylesheet" />
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="header" runat="server">
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="panel panel-default">

        <div class="panel-heading">
            <h3 class="panel-title">查询条件
            </h3>
        </div>
        业主姓名：<asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
        业主门牌：<asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
        <asp:Button ID="Button4" runat="server" Text="查询" Width="120px" CssClass="btn btn-success" OnClick="Button4_Click" />
    </div>

    <%--业主居住信息表--%>
    <asp:GridView ID="GridView2" runat="server" AllowPaging="True" OnPageIndexChanging="GridView2_PageIndexChanging" CssClass="table table-striped table-bordered table-hover table-condensed" AutoGenerateColumns="False">
        <Columns>
            <asp:BoundField DataField="UserName" HeaderText="业主姓名" />
            <asp:BoundField DataField="UserSex" HeaderText="业主性别" />
            <asp:BoundField DataField="UserCell" HeaderText="业主门牌" />
            <asp:BoundField DataField="UserPhone" HeaderText="业主电话" />
            <asp:BoundField DataField="UserPwd" HeaderText="业主账号密码" />
        </Columns>
    </asp:GridView>


</asp:Content>
