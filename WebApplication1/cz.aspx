<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="cz.aspx.cs" Inherits="WebApplication1.cz" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
     <link href="../bp/bootstrap.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CssClass="table table-striped table-bordered table-hover table-condensed" AllowPaging="True" OnPageIndexChanging="GridView1_PageIndexChanging" DataKeyNames="ZHId" OnSelectedIndexChanging="GridView1_SelectedIndexChanging" >
        <Columns>
            <asp:BoundField DataField="ZHId" HeaderText="账户编号" />
            <asp:BoundField DataField="ZHName" HeaderText="账户名称" />
            <asp:BoundField DataField="ZHType" HeaderText="账户类型" />
            <asp:BoundField DataField="ZHMoney" HeaderText="账户金额" />
            <asp:BoundField DataField="ZHDate" HeaderText="创建时间" />
            <asp:CommandField HeaderText="充值" SelectText="充值" ShowSelectButton="True" />
        </Columns>
    </asp:GridView>
</asp:Content>
