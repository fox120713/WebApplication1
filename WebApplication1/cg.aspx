<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="cg.aspx.cs" Inherits="WebApplication1.cg"  EnableEventValidation="false" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../bp/bootstrap.css" rel="stylesheet" />
    <style>
        img {
            width:80px;
            height:60px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      <div class="panel panel-default">
        <div class="panel-heading">
            <h3 class="panel-title">查询条件
            </h3>
        </div>
        <div class="panel-body">
              商品名称：<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
   审核状态：<asp:DropDownList ID="DropDownList1" runat="server" >
                <asp:ListItem Value="1">已通过</asp:ListItem>
                <asp:ListItem Value="2">待审核</asp:ListItem>
                <asp:ListItem Value="3">未通过</asp:ListItem>
            </asp:DropDownList>
    <asp:Button ID="Button1" runat="server" Text="查询" OnClick="Button1_Click" CssClass="btn btn-success"/>
            <asp:Button ID="Button2" runat="server" Text="导出为excle"  OnClick="Button2_Click" class="btn btn-success"/>
        </div>
 </div>
 
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False"  Class="table table-striped table-bordered table-hover table-condensed" AllowPaging="True" OnPageIndexChanging="GridView1_PageIndexChanging">
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
        </Columns>
    </asp:GridView>
</asp:Content>
