<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="dutywatch.aspx.cs" Inherits="WebApplication1.dutywatch" %>
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
            <h3 class="panel-title">查询条件
            </h3>
        </div>
        <div class="panel-body">
            工作日期：<asp:TextBox ID="TextBox1" runat="server" TextMode="Date"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" Text="查询" OnClick="Button1_Click"  class="btn btn-success"/>
            <asp:Button ID="Button2" runat="server" Text="导出为excle"  OnClick="Button2_Click" class="btn btn-success"/>
        </div>
        </div>
    <asp:GridView ID="GridView1" runat="server" Class="table table-striped table-bordered table-hover table-condensed" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" AutoGenerateColumns="False"  OnRowCommand="GridView1_RowCommand" DataKeyNames="zbid">
        <Columns>
            <asp:BoundField DataField="zbid" HeaderText="id" Visible="False" />
            <asp:TemplateField HeaderText="值班日期">
                <EditItemTemplate>
                    <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("zbdate") %>'></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label1" runat="server" Text='<%#Convert.ToDateTime(Eval("zbdate")).ToString("yyyy年MM月dd日")%>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:BoundField DataField="gznr" HeaderText="工作内容" />
            <asp:BoundField DataField="jttime" HeaderText="具体时间" />
            <asp:BoundField DataField="zt" HeaderText="状态" />
            <asp:TemplateField ShowHeader="False">
                <ItemTemplate>
                    <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="False"  Text="提交报告" CommandArgument='<%#Eval("zbid")%>' OnCommand="LinkButton1_Command"></asp:LinkButton>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
</asp:GridView>
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
