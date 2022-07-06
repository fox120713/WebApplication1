<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="jfxq.aspx.cs" Inherits="WebApplication1.jfxq" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
     <link href="../bp/bootstrap.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" Class="table table-striped table-bordered table-hover table-condensed" AllowPaging="True" OnSelectedIndexChanging="GridView1_SelectedIndexChanging" >
        <Columns>
            <asp:BoundField ApplyFormatInEditMode="True" DataField="mxid" HeaderText="id" Visible="False" />
            <asp:BoundField DataField="UserName" HeaderText="业主姓名" />
            <asp:BoundField DataField="months" HeaderText="时间" />
            <asp:BoundField DataField="PayName" HeaderText="分类" />
            <asp:BoundField DataField="Syd" HeaderText="上月用度" />
            <asp:BoundField DataField="Byd" HeaderText="本月用度" />
            <asp:BoundField DataField="YDdj" HeaderText="单价" />
            <asp:BoundField DataField="dateMoney" HeaderText="本月费用" />
        </Columns>
    </asp:GridView>
</asp:Content>
