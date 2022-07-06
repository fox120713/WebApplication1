<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="zwf.aspx.cs" Inherits="WebApplication1.zwf"  EnableEventValidation="false" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../bp/bootstrap.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="panel panel-info">
	<div class="panel-heading">
		<h3 class="panel-title">查询条件</h3>
	</div>
	<div class="panel-body">
		   楼栋号：
        <asp:TextBox ID="TextBox1" runat="server" Width="80px"></asp:TextBox>
    缴费类型：
    <asp:DropDownList ID="DropDownList1" runat="server" ></asp:DropDownList>
        缴费状态：
        <asp:DropDownList ID="DropDownList2" runat="server"></asp:DropDownList>
    <asp:Button ID="Button1" runat="server" Text="查询" OnClick="Button1_Click" CssClass="btn btn-success"/>
        <asp:Button ID="Button2" runat="server" Text="添加" OnClick="Button2_Click"  CssClass="btn btn-success" />
        <asp:Button ID="Button3" runat="server" Text="导出为excle"  OnClick="Button3_Click" class="btn btn-success"/>
        <br />
	</div>
</div>
    
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CssClass="table table-striped table-bordered table-hover table-condensed" AllowPaging="True" OnPageIndexChanging="GridView1_PageIndexChanging" >
        <Columns>
            <asp:BoundField DataField="DopantID" HeaderText="账单编号" />
            <asp:BoundField DataField="UserName" HeaderText="居民姓名" />
            <asp:BoundField DataField="UserCell" HeaderText="楼栋号" />
            <asp:BoundField DataField="PayName" HeaderText="缴费类型" />
            <asp:BoundField DataField="DopantMoney" HeaderText="金额" />
            <asp:BoundField DataField="DopantBool" HeaderText="缴费状态" />
            <asp:BoundField DataField="DopantTime" HeaderText="缴费时间" />
            <asp:BoundField DataField="DopantBlr" HeaderText="办理人" />
            <asp:TemplateField HeaderText="缴费">
                <ItemTemplate>
                    <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="False" CommandArgument='<%# Eval("DopantID") %>' CommandName='<%# Eval("DopantBool","{0}")=="已缴费"?"已缴费":"缴费" %>' Text='<%# Eval("DopantBool","{0}")=="已缴费"?"已缴费":"缴费" %>' OnClientClick="return confirm('是否缴费')" OnCommand="LinkButton1_Command" ></asp:LinkButton>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
</asp:Content>
