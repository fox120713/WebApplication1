<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Public_maintenance.aspx.cs" Inherits="WebApplication1.Public_maintenance" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="css/bootstrap.css" rel="stylesheet" />
     <style>
        td img {
        width:100px;
        height:50px;
        }
        td {
        line-height:50px;
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
             区域选择：<asp:DropDownList ID="DropDownList1" runat="server">
    <asp:ListItem>A区</asp:ListItem>
    <asp:ListItem>B区</asp:ListItem>
    <asp:ListItem>C区</asp:ListItem>
    <asp:ListItem>D区</asp:ListItem>
</asp:DropDownList>审核状态：<asp:DropDownList ID="DropDownList2" runat="server">
    <asp:ListItem>已通过</asp:ListItem>
    <asp:ListItem>未通过</asp:ListItem>
    <asp:ListItem>待审核</asp:ListItem>
</asp:DropDownList>完成进度：<asp:DropDownList ID="DropDownList3" runat="server">
    <asp:ListItem>已完成</asp:ListItem>
    <asp:ListItem>未完成</asp:ListItem>
</asp:DropDownList><asp:Button ID="Button1" runat="server" Text="查询"  class="btn btn-success" OnClick="Button1_Click"/>
        </div>
    </div>
    
  
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False"  Class="table table-striped table-hover">
        <Columns>
            <asp:BoundField DataField="Prsite" HeaderText="维修地点" />
            <asp:BoundField DataField="PrCon" HeaderText="情况描述" />
            <asp:ImageField DataImageUrlField="Primg" HeaderText="图片">
            </asp:ImageField>
            <asp:BoundField DataField="Prsqr" HeaderText="申请人" />
            <asp:BoundField DataField="PrsDate" HeaderText="申请时间" DataFormatString="{0:d}" />
            <asp:BoundField DataField="Prphone" HeaderText="联系电话" />
            <asp:BoundField DataField="PrIstate" HeaderText="审核状态" />
            <asp:BoundField DataField="PrWxr" HeaderText="维修人员" />
            <asp:BoundField DataField="PrkDate" HeaderText="维修开始时间" DataFormatString="{0:d}" />
            <asp:BoundField DataField="PrjDate" HeaderText="维修结束时间" DataFormatString="{0:d}" />
            <asp:BoundField DataField="PrState" HeaderText="完成状态" />
        </Columns>
    </asp:GridView>
</asp:Content>