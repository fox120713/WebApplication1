<%@ Page Title="" Language="C#" MasterPageFile="~/管理员/site.Master" AutoEventWireup="true" CodeBehind="GGSP.aspx.cs" Inherits="WebApplication1.管理员.GGSP" %>
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
        审核状态：<asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" AutoPostBack="true" >
                <asp:ListItem Value="1">已通过</asp:ListItem>
                <asp:ListItem Value="2">待审核</asp:ListItem>
                <asp:ListItem Value="3">未通过</asp:ListItem>
            </asp:DropDownList>
        </div>
        </div>
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" class="table table-striped table-bordered table-hover table-condensed" AllowPaging="True" OnPageIndexChanging="GridView1_PageIndexChanging" PageSize="15">
        <Columns>
            <asp:BoundField DataField="Annid" HeaderText="编号" />
            <asp:BoundField DataField="AnnTitle" HeaderText="标题" />
            <asp:BoundField DataField="AnnCon" HeaderText="内容" Visible="False" />
            <asp:BoundField DataField="AnnaDate" HeaderText="申请日期" />
            <asp:BoundField DataField="AnnsqrID" HeaderText="申请人" />
            <asp:BoundField DataField="AnnDate" HeaderText="发布日期" />
            <asp:BoundField DataField="AnnaName" HeaderText="发布人" />
            <asp:BoundField DataField="AnnaIstate" HeaderText="状态" />
            <asp:TemplateField HeaderText="操作" ShowHeader="False">
                <ItemTemplate>
                    <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="False" CommandName='<%#Eval("AnnaIstate")%>'  Text="选择" CommandArgument='<%#Eval("Annid") %>' OnCommand="LinkButton1_Command" ></asp:LinkButton>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
</asp:Content>
