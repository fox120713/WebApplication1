<%@ Page Title="" Language="C#" MasterPageFile="~/管理员/site.Master" AutoEventWireup="true" CodeBehind="zhibanshenhe.aspx.cs" Inherits="WebApplication1.管理员.zhibanshenhe" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        .you_align {
            text-align:center;
        }
    </style>
    <link href="../bp/bootstrap.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="header" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="panel panel-default">
        <div class="panel-heading">
            <h3 class="panel-title">值班审核
            </h3>
        </div>
        <div class="panel-body">
            审核状态：<asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="true">
                <asp:ListItem>待审核</asp:ListItem>
                <asp:ListItem>已通过</asp:ListItem>
                <asp:ListItem>未通过</asp:ListItem>
                <asp:ListItem Selected="True">全部</asp:ListItem>
            </asp:DropDownList><asp:Button ID="Button1" runat="server" Text="查询" class="btn btn-success" OnClick="Button1_Click"/>
        </div>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CssClass="table table-striped table-bordered table-hover table-condensed">
            <Columns>
                <asp:BoundField DataField="zbid" HeaderText="id" Visible="False" />
                <asp:TemplateField HeaderText="日期">
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("zbdate") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label1" runat="server" Text='<%#Convert.ToDateTime(Eval("zbdate")).ToString("yyyy年MM月dd日")%>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:BoundField HeaderText="具体时间" DataField="jttime" />
                <asp:BoundField HeaderText="报告人" DataField="YgName" />
                <asp:BoundField DataField="zt" HeaderText="状态" />
                <asp:ImageField DataImageUrlField="cgimg" HeaderText="图片">
                    <ControlStyle Height="100px" Width="130px" />
                </asp:ImageField>
                <asp:BoundField DataField="cause" HeaderText="原因" />
                <asp:TemplateField ShowHeader="False">
                    <ItemTemplate>
                        <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="false" CommandName='<%#Eval("zt") %>' Text="详情"  CommandArgument='<%#Eval("zbid") %>' OnCommand="LinkButton1_Command"></asp:LinkButton>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
    </div>
    <p class="you_align">

            <asp:Label ID="labCP" runat="server" Text="当前第"></asp:Label>
            <asp:Label ID="labPage" runat="server" Text="1"></asp:Label>
            &nbsp;页
                  <asp:Label ID="labTP" runat="server" Text="共"></asp:Label>
            <asp:Label ID="labBackPage" runat="server"></asp:Label>
            页
                  <asp:LinkButton ID="lnkbtnOne" runat="server" Font-Underline="False" ForeColor="Red" OnClick="lnkbtnOne_Click">第一页</asp:LinkButton>
            <asp:LinkButton ID="lnkbtnUp" runat="server" Font-Underline="False" ForeColor="Red" OnClick="lnkbtnUp_Click">上一页</asp:LinkButton>
            <asp:LinkButton ID="lnkbtnNext" runat="server" Font-Underline="False" ForeColor="Red" OnClick="lnkbtnNext_Click">下一页</asp:LinkButton>&nbsp;
                  <asp:LinkButton ID="lnkbtnBack" runat="server" Font-Underline="False" ForeColor="Red" OnClick="lnkbtnBack_Click">尾页</asp:LinkButton>&nbsp;&nbsp;
        </p>
</asp:Content>
