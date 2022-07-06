<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="yzjfjl.aspx.cs" Inherits="WebApplication1.yzjfjl" %>

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
            门牌号：<asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="true" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged"></asp:DropDownList>
                        <asp:DropDownList ID="DropDownList2" runat="server" OnSelectedIndexChanged="DropDownList2_SelectedIndexChanged" AutoPostBack="true"></asp:DropDownList>
                        <asp:DropDownList ID="DropDownList3" runat="server" AutoPostBack="true"></asp:DropDownList>
            月份：<asp:DropDownList ID="DropDownList4" runat="server" AutoPostBack="true">
            </asp:DropDownList>
            <asp:Button ID="Button1" runat="server" Text="查询" class="btn btn-success" OnClick="Button1_Click" />
            <asp:Button ID="Button2" runat="server" Text="添加" class="btn btn-success" OnClick="Button2_Click" />
        </div>
    </div>
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" Class="table table-striped table-bordered table-hover table-condensed" AllowPaging="True" OnPageIndexChanging="GridView1_PageIndexChanging1" >
        <Columns>
            <asp:BoundField DataField="Hzid" HeaderText="账单编号" />
            <asp:BoundField DataField="HzLD" HeaderText="门牌号" />
            <asp:BoundField DataField="Months" HeaderText="时间" />
            <asp:BoundField DataField="summoney" HeaderText="总金额" DataFormatString="{0:c}" />
            <asp:BoundField DataField="SJyu" HeaderText="上月结余" Visible="False" DataFormatString="{0:c}" />
            <asp:BoundField DataField="BYyu" HeaderText="本月结余" DataFormatString="{0:c}" />
        </Columns>
    </asp:GridView>
    
</asp:Content>
