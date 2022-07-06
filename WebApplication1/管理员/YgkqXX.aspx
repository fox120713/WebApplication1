<%@ Page Title="" Language="C#" MasterPageFile="~/管理员/site.Master" AutoEventWireup="true" CodeBehind="YgkqXX.aspx.cs" Inherits="WebApplication1.管理员.YgkqXX" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../bp/bootstrap.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="header" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div class="panel panel-default">
	<div class="panel-heading">
		<h3 class="panel-title">
			查询条件:
		</h3>
	</div>
	<div class="panel-body">
		年份：<asp:DropDownList ID="DropDownListYear" runat="server" OnSelectedIndexChanged="DropDownListYear_SelectedIndexChanged" AutoPostBack="True"></asp:DropDownList> 
        月份：<asp:DropDownList ID="DropDownList2Month" runat="server" AutoPostBack="True">
            <asp:ListItem>1</asp:ListItem>
            <asp:ListItem>2</asp:ListItem>
            <asp:ListItem>3</asp:ListItem>
            <asp:ListItem>4</asp:ListItem>
            <asp:ListItem>5</asp:ListItem>
            <asp:ListItem>6</asp:ListItem>
            <asp:ListItem>7</asp:ListItem>
            <asp:ListItem>8</asp:ListItem>
            <asp:ListItem>9</asp:ListItem>
            <asp:ListItem>10</asp:ListItem>
            <asp:ListItem>11</asp:ListItem>
            <asp:ListItem>12</asp:ListItem>
        </asp:DropDownList>
        <asp:Button ID="Button1" runat="server" Text="查询"  class="btn btn-success" OnClick="Button1_Click"/>
	</div>
</div>
    <a href="Ygkq.aspx">返回考勤信息页面</a>
    <asp:GridView ID="GridView1" runat="server" CssClass="table table-striped table-bordered table-hover table-condensed" AutoGenerateColumns="False">
        <Columns>
            <asp:BoundField DataField="PosName" HeaderText="部门" />
            <asp:BoundField DataField="YgName" HeaderText="姓名" />
            <asp:BoundField DataField="DaKaSj" HeaderText="打卡时间" DataFormatString="{0:yyyy-MM-dd hh:mm}" />
            <asp:BoundField DataField="BeiZhu" HeaderText="备注" />
            <asp:BoundField DataField="Ctime" HeaderText="迟到时长" />
        </Columns>
    </asp:GridView>

</asp:Content>
