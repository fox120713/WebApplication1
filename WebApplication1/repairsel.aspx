<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="repairsel.aspx.cs" Inherits="WebApplication1.repairsel" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="css/bootstrap.css" rel="stylesheet" />
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="header" runat="server">
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="panel panel-default">
        <div class="panel-heading">
            <h3 class="panel-title">查询条件
            </h3>
        </div>
        <div class="panel-body">
            业主门牌号：<asp:TextBox ID="TextBox10" runat="server"></asp:TextBox>
            业主姓名：<asp:TextBox ID="TextBox9" runat="server"></asp:TextBox>
            <asp:Button ID="Button6" runat="server" Text="查询" Width="120px" CssClass="btn btn-success" OnClick="Button6_Click" />
        </div>
    </div>

                <asp:GridView ID="GridView4" runat="server" AllowPaging="True" OnPageIndexChanging="GridView4_PageIndexChanging" CssClass="table table-striped table-bordered table-hover table-condensed" AutoGenerateColumns="False">
                <Columns>
                    <asp:BoundField DataField="UserName" HeaderText="业主姓名" />
                    <asp:BoundField DataField="RepnNumber" HeaderText="门牌号" />
                    <asp:BoundField DataField="RepnpDay" HeaderText="申请日期" />
                    <asp:BoundField DataField="RepnPhone" HeaderText="业主电话" />
                    <asp:BoundField DataField="RepnWhat" HeaderText="申请原因" />
                    <asp:BoundField DataField="RepnState" HeaderText="申请状态" />
                    <asp:BoundField DataField="ReppDayk" HeaderText="维修日期" />
                    <asp:BoundField DataField="ReppBool" HeaderText="维修状态" />
                    <asp:BoundField DataField="ReppMan" HeaderText="维修负责人" />
                </Columns>
            </asp:GridView>

</asp:Content>
