<%@ Page Title="" Language="C#" MasterPageFile="~/管理员/site.Master" AutoEventWireup="true" CodeBehind="LzSP.aspx.cs" Inherits="WebApplication1.管理员.LzSP" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../bp/bootstrap.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="header" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <div class="panel panel-default">
        <div class="panel-heading">
            <h3 class="panel-title">查询条件
            </h3>
        </div>
        <div class="panel-body">
        姓名:<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        部门:<asp:DropDownList ID="DropDownListPos" runat="server" AutoPostBack="True"></asp:DropDownList>
        审核状态：<asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True">
                <asp:ListItem>全部</asp:ListItem>
                <asp:ListItem Value="1">已通过</asp:ListItem>
                <asp:ListItem Value="2">待审核</asp:ListItem>
                <asp:ListItem Value="3">未通过</asp:ListItem>
            </asp:DropDownList>
            <asp:Button ID="Button1" runat="server" Text="查询" class="btn btn-success" OnClick="Button1_Click" />
        </div>
        </div>
    <asp:GridView ID="GridView1" runat="server"  CssClass="table table-striped table-bordered table-hover table-condensed" AutoGenerateColumns="False">
        <Columns>
            <asp:BoundField DataField="ID" HeaderText="编号" />
            <asp:BoundField DataField="YgId" HeaderText="员工id" />
            <asp:BoundField DataField="YgName" HeaderText="员工名字" />
            <asp:BoundField DataField="PosName" HeaderText="部门名称" />
            <asp:BoundField DataField="YgRdate" HeaderText="入职日期" DataFormatString="{0:d}" />
            <asp:BoundField DataField="YgSdate" HeaderText="申请日期" DataFormatString="{0:d}" />
            <asp:BoundField DataField="YGlzYY" HeaderText="离职原因" />
            <asp:BoundField DataField="YgBool" HeaderText="审核状态" />
            <asp:BoundField DataField="Ygyy" HeaderText="状态原因" />
            <asp:BoundField DataField="YgLdate" HeaderText="离职日期" DataFormatString="{0:d}" />
            <asp:TemplateField ShowHeader="False" HeaderText="审核">
                <ItemTemplate>
                    <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="False" CommandName='<%#Eval("YgBool","{0}")=="待审核"?"审核":"" %>'  CommandArgument=<%# Eval("ID") %>  Text='<%#Eval("YgBool","{0}")=="待审核"?"审核":"" %>' OnCommand="LinkButton1_Command"></asp:LinkButton>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
</asp:Content>
