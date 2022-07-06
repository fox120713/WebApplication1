<%@ Page Title="" Language="C#" MasterPageFile="~/业主/SiteYezhu.Master" AutoEventWireup="true" CodeBehind="ChongZhiXX.aspx.cs" Inherits="WebApplication1.业主.ChongZhiXX" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../bp/bootstrap.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="header" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server" >


      <div class="panel panel-default">
            <div class="panel-heading">
                <h3 class="panel-title">查询条件
                </h3>
            </div>
            <div class="panel-body">
                月份：<asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="true" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged"></asp:DropDownList>
            </div>
        </div>
    <asp:GridView ID="GridView1" runat="server" CssClass="table table-striped table-bordered table-hover table-condensed" AutoGenerateColumns="False">
        <Columns>
            <asp:BoundField DataField="Months" HeaderText="月份" />
            <asp:BoundField DataField="CZJE" DataFormatString="{0:c}" HeaderText="充值金额" />
            <asp:BoundField DataField="CzDate" HeaderText="具体时间" />
        </Columns>
    </asp:GridView>
</asp:Content>
