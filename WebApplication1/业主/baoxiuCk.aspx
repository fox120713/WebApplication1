<%@ Page Title="" Language="C#" MasterPageFile="~/业主/SiteYezhu.Master" AutoEventWireup="true" CodeBehind="baoxiuCk.aspx.cs" Inherits="WebApplication1.业主.baoxiuCk" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../bp/bootstrap.css" rel="stylesheet" />
    <style>
        td img {
            width: 100px;
            height: 50px;
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
                <asp:ListItem Value="1">已通过</asp:ListItem>
                <asp:ListItem Value="2">待审核</asp:ListItem>
                <asp:ListItem Value="3">未通过</asp:ListItem>
            </asp:DropDownList>
            维修状态：<asp:DropDownList ID="DropDownList2" runat="server" AutoPostBack="True">
                <asp:ListItem Value="已完成">已完成</asp:ListItem>
                <asp:ListItem Value="未完成">未完成</asp:ListItem>
            </asp:DropDownList>
            <asp:Button ID="Button1" runat="server" Text="查询" class="btn btn-success" OnClick="Button1_Click" />
        </div>
    </div>
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" class="table table-striped table-bordered table-hover table-condensed">
        <Columns>
            <asp:BoundField DataField="UserName" HeaderText="业主姓名" Visible="False" />
            <asp:BoundField DataField="RepnNumber" HeaderText="门牌号" Visible="False" />
            <asp:BoundField DataField="RepnpDay" HeaderText="申请日期" />
            <asp:BoundField DataField="RepnPhone" HeaderText="联系电话" />
            <asp:ImageField DataImageUrlField="RepnPic" HeaderText="图片">
            </asp:ImageField>
            <asp:BoundField DataField="RepnWhat" HeaderText="维修原因" />
            <asp:BoundField DataField="RepnState" HeaderText="审核状态" />
            <asp:BoundField DataField="ReppDayk" HeaderText="维修开始日期" />
            <asp:BoundField DataField="ReppDayj" HeaderText="维系结束日期" />
            <asp:BoundField DataField="ReppWhat" HeaderText="维修原因" />
            <asp:BoundField DataField="ReppBool" HeaderText="维修状态" />
            <asp:BoundField DataField="ReppMan" HeaderText="维修人" />
            <asp:ImageField DataImageUrlField="ReppWcImg" HeaderText="完成图片">
            </asp:ImageField>
        </Columns>
    </asp:GridView>
</asp:Content>
