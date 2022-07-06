﻿<%@ Page Title="" Language="C#" MasterPageFile="~/管理员/site.Master" AutoEventWireup="true" CodeBehind="CG.aspx.cs" Inherits="WebApplication1.管理员.CG" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../bp/bootstrap.css" rel="stylesheet" />
    <style>
        img {
            width:80px;
            height:60px;
        }
    </style>
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
               审核状态：<asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                   <asp:ListItem Value="全部">全部</asp:ListItem>
                   <asp:ListItem Value="未通过">未通过</asp:ListItem>
                   <asp:ListItem Value="已通过">已通过</asp:ListItem>
                   <asp:ListItem Value="待审核">待审核</asp:ListItem>
               </asp:DropDownList>
        </div>
    </div>
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" Class="table table-striped table-bordered table-hover table-condensed" AllowPaging="True" OnPageIndexChanging="GridView1_PageIndexChanging">
        <Columns>
            <asp:BoundField DataField="PurpName" HeaderText="商品名" />
            <asp:ImageField DataImageUrlField="PurpImg" HeaderText="商品图片">
            </asp:ImageField>
            <asp:BoundField DataField="PurpNumber" HeaderText="商品数量" />
            <asp:BoundField DataField="PurPrice" HeaderText="商品单价" />
            <asp:BoundField DataField="PurpSum" HeaderText="商品总价" />
            <asp:BoundField DataField="PurpAccount" HeaderText="采购理由" />
            <asp:BoundField DataField="PurSqr" HeaderText="申请人" />
            <asp:BoundField DataField="PurpDate" HeaderText="采购日期" />
            <asp:BoundField DataField="PurIstate" HeaderText="申请状态" />
            <asp:TemplateField HeaderText="通过" ShowHeader="False">
                <ItemTemplate>
                    <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="False" CommandName='<%#Eval("PurIstate")  %>' Text="选择"  CommandArgument='<%#Eval("PurpID") %>' OnClientClick="return confirm('是否通过审核'))" OnCommand="LinkButton1_Command"></asp:LinkButton>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="不通过" ShowHeader="False">
                <ItemTemplate>
                    <asp:LinkButton ID="LinkButton2" runat="server" CausesValidation="False" CommandName='<%#Eval("PurIstate") %>' Text="选择" CommandArgument='<%#Eval("PurpID") %>' OnClientClick="return confirm('是否拒绝通过审核'))" OnCommand="LinkButton2_Command" ></asp:LinkButton>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>

</asp:Content>
