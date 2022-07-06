<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="gonggaoxinxi.aspx.cs" Inherits="WebApplication1.gonggaoxinxi" %>

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

        公告标题：<asp:TextBox ID="TextBox14" runat="server"></asp:TextBox>
        公告状态：<asp:DropDownList ID="DropDownList3" runat="server"></asp:DropDownList>
        <asp:Button ID="Button9" runat="server" Text="查询" Width="120px" CssClass="btn btn-success" OnClick="Button9_Click" />
    </div>

    <asp:GridView ID="GridView7" runat="server" AllowPaging="True" AutoGenerateColumns="False" OnPageIndexChanging="GridView7_PageIndexChanging" PageSize="4" CssClass="table table-striped table-bordered table-hover table-condensed">
        <Columns>
            <asp:BoundField DataField="AnnTitle" HeaderText="公告标题">
                <FooterStyle Width="80px" />
            </asp:BoundField>
            <asp:BoundField DataField="AnnCon" HeaderText="公告内容">
                <FooterStyle Width="150px" />
                <ItemStyle Height="30px" />
            </asp:BoundField>
            <asp:BoundField DataField="AnnsqrID" HeaderText="公告发布人编号" />
            <asp:BoundField DataField="AnnaName" HeaderText="公告发布人姓名" />
            <asp:BoundField DataField="AnnaIstate" HeaderText="公告审核状态" />
            <asp:BoundField DataField="AnnWhy" HeaderText="状态原因" />
        </Columns>
    </asp:GridView>
</asp:Content>
