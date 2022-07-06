<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="bokuan.aspx.cs" Inherits="WebApplication1.bokuan"  EnableEventValidation="false" %>
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
            年份<asp:DropDownList ID="DropDownList1" runat="server"></asp:DropDownList>：
            月份<asp:DropDownList ID="DropDownList2" runat="server"></asp:DropDownList>:
                办理人：
                <asp:TextBox ID="TextBox1" runat="server" Width="80px"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" Text="查询" OnClick="Button1_Click" class="btn btn-success"  />
            <asp:Button ID="Button3" runat="server" Text="导出为excle"  OnClick="Button3_Click" class="btn btn-success"/>
        </div>
 </div>
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" Class="table table-striped table-bordered table-hover table-condensed" AllowPaging="True" OnSelectedIndexChanging="GridView1_SelectedIndexChanging">
        <Columns>
            <asp:BoundField DataField="AppID" HeaderText="账单编号" />
            <asp:BoundField DataField="PosName" HeaderText="部门名称" />
            <asp:BoundField DataField="AppReason" HeaderText="拨款原因" />
            <asp:BoundField DataField="AppTime" HeaderText="拨款时间" DataFormatString="{0:d}" />
            <asp:BoundField DataField="AppMoney" HeaderText="拨款金额" DataFormatString="{0:c}" />
            <asp:BoundField DataField="AppName" HeaderText="办理人" />
        </Columns>
    </asp:GridView>
</asp:Content>
