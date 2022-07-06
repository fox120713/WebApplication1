<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="zchsr.aspx.cs" Inherits="WebApplication1.zchsr" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../bp/bootstrap.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="panel panel-default">
        <div class="panel-heading">
            <h3 class="panel-title">查询条件
            </h3>
        </div>
        <div class="panel-body">
            类型：<asp:DropDownList ID="DropDownList1" runat="server" >
                <asp:ListItem Value="全部">全部</asp:ListItem>
                <asp:ListItem Value="支出">支出</asp:ListItem>
                <asp:ListItem Value="收入">收入</asp:ListItem>
            </asp:DropDownList>
            月份：<asp:DropDownList ID="DropDownList2" runat="server"></asp:DropDownList>
            <asp:Button ID="Button1" runat="server" Text="查询"  class="btn btn-success" OnClick="Button1_Click" />
        </div>
 </div>
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" Class="table table-striped table-bordered table-hover table-condensed" AllowPaging="True" OnPageIndexChanging="GridView1_PageIndexChanging"  >
        <Columns>
            <asp:BoundField DataField="WuyeId" HeaderText="id" Visible="False" />
            <asp:BoundField DataField="Zdly" HeaderText="来源" />
            <asp:BoundField DataField="dates" HeaderText="时间" />
            <asp:BoundField DataField="Zdmoney" HeaderText="金额" DataFormatString="{0:c}" />
            <asp:BoundField DataField="months" HeaderText="月份" Visible="False" />
        </Columns>
    </asp:GridView>
    <asp:Label ID="Label1" runat="server" Text="合计：" Font-Size="30px" Font-Bold="true"></asp:Label>
    <asp:Label ID="Label2" runat="server" Font-Size="30px" Font-Bold="true" ></asp:Label>
</asp:Content>
