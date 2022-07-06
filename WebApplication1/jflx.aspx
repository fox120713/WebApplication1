<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="jflx.aspx.cs" Inherits="WebApplication1.jflx" %>
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
            类型：<asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="true" ></asp:DropDownList>
            <asp:Button ID="Button1" runat="server" Text="查询"  class="btn btn-success"  OnClick="Button1_Click" />
            <asp:Button ID="Button2" runat="server" Text="添加" class="btn btn-success" OnClick ="Button2_Click" />
        </div>
 </div>
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" Class="table table-striped table-bordered table-hover table-condensed" >
        <Columns>
            <asp:BoundField DataField="PayID" HeaderText="类型编号" />
            <asp:BoundField DataField="PayName" HeaderText="缴费类型" />
            <asp:BoundField DataField="dj" HeaderText="单价" DataFormatString="{0:c}" />
            
            <asp:TemplateField HeaderText="修改" ShowHeader="False">
                <ItemTemplate>
                    <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="False" CommandName="Select" CommandArgument='<%# Eval("PayID") %>' Text="选择" OnCommand="LinkButton1_Command"></asp:LinkButton>
                </ItemTemplate>
            </asp:TemplateField>
            
        </Columns>
</asp:GridView>
</asp:Content>
