<%@ Page Title="" Language="C#" MasterPageFile="~/管理员/site.Master" AutoEventWireup="true" CodeBehind="Ygkq.aspx.cs" Inherits="WebApplication1.管理员.Ygkq"   EnableEventValidation="false" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
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
            名称：<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>状态：<asp:DropDownList ID="DropDownList1" runat="server">
                <asp:ListItem Value="1">全部</asp:ListItem>
                <asp:ListItem Value="2">异常</asp:ListItem>
            </asp:DropDownList>
            部门：<asp:DropDownList ID="DropDownList2" runat="server">
            </asp:DropDownList>
            <asp:Button ID="Button1" runat="server" Text="查询" class="btn btn-success" OnClick="Button1_Click" />
            <asp:Button ID="Button2" runat="server" Text="导出为excle"  OnClick="Button2_Click" class="btn btn-success"/>
        </div>
        </div>
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" Class="table table-striped table-bordered table-hover table-condensed" AllowPaging="True" PageSize="15" OnPageIndexChanging="GridView1_PageIndexChanging">
        <Columns>
            <asp:BoundField DataField="PosName" HeaderText="部门编号" />
            <asp:BoundField DataField="YgId" HeaderText="工号" />
<asp:BoundField DataField="YgName" HeaderText="姓名"></asp:BoundField>
            <asp:BoundField DataField="Ygday" HeaderText="打卡次数" />
            <asp:BoundField DataField="BeiZhu" Visible="False" HeaderText="备注" />
            <asp:BoundField DataField="ygcount" HeaderText="异常次数" />
            <asp:BoundField DataField="ygtime" HeaderText="总时长" />
            <asp:TemplateField HeaderText="操作" ShowHeader="False">
                <ItemTemplate>
                    <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="false" CommandName="" Text="详情" OnClick="LinkButton1_Click" CommandArgument='<%#Eval("YgId") %>'  OnCommand=" LinkButton1_Command"  ForeColor="#3333ff"></asp:LinkButton>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>

    </asp:GridView>
</asp:Content>
