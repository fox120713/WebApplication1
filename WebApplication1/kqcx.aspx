<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="kqcx.aspx.cs" Inherits="WebApplication1.kqcx" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
     <link href="../bp/bootstrap.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="panel panel-info">
	<div class="panel-heading">
		<h3 class="panel-title">查询条件</h3>
	</div>
	<div class="panel-body">
		   打卡状态：<asp:DropDownList ID="DropDownList1" runat="server"></asp:DropDownList>
        年份：<asp:DropDownList ID="DropDownListYear" runat="server" AutoPostBack="True">
            
           </asp:DropDownList> 
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
     
        <asp:Button ID="Button1" runat="server" Text="查询" OnClick="Button1_Click"  class="btn btn-success"  />
        <br />
	</div>
</div>
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CssClass="table table-striped table-bordered table-hover table-condensed" >
        <Columns>
            <asp:BoundField DataField="DaKaSj" HeaderText="打卡时间" />
            <asp:BoundField DataField="BeiZhu" HeaderText="备注" />
            <asp:BoundField DataField="Ctime" HeaderText="迟到时间" />
        </Columns>
    </asp:GridView>
</asp:Content>
