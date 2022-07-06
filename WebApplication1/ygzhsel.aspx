<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="ygzhsel.aspx.cs" Inherits="WebApplication1.ygzhsel" %>

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

                员工姓名：<asp:TextBox ID="TextBox12" runat="server"></asp:TextBox>
                性别：<asp:DropDownList ID="DropDownList2" runat="server"></asp:DropDownList>
                <asp:Button ID="Button8" runat="server" Text="查询" Width="120px" CssClass="btn btn-success" OnClick="Button8_Click" />
        
    </div>

    <asp:GridView ID="GridView6" runat="server" AllowPaging="True" CssClass="table table-striped table-bordered table-hover table-condensed" AutoGenerateColumns="False" OnPageIndexChanging="GridView6_PageIndexChanging">
        <Columns>
            <asp:BoundField DataField="YgName" HeaderText="员工姓名" />
            <asp:BoundField DataField="YgSex" HeaderText="员工性别" />
            <asp:BoundField DataField="YgAge" HeaderText="员工年龄" />
            <asp:BoundField DataField="YgPhone" HeaderText="员工电话" />
        </Columns>
    </asp:GridView>
</asp:Content>
