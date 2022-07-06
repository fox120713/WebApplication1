<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="nullcar.aspx.cs" Inherits="WebApplication1.nullcar" %>

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
                车位号：<asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
                <asp:Button ID="Button5" runat="server" Text="查询" Width="120px" CssClass="btn btn-success" OnClick="Button5_Click" />
        </div>
    </div>

        <%--空车位表--%>
        <asp:GridView ID="GridView3" runat="server" AutoGenerateColumns="False" CssClass="table table-striped table-bordered table-hover table-condensed">
            <Columns>
                <asp:BoundField DataField="CarBH" HeaderText="车位编号" />
                <asp:TemplateField HeaderText="车位状态">
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox1" runat="server" Text='<%# Eval("CarSta") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label1" runat="server" Text='<%# (Eval("CarSta")).ToString()=="0"?"空":" "%>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="操作" ShowHeader="False">
                    <ItemTemplate>
                        <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="False" CommandName="Select" Text="选择" OnCommand="LinkButton1_Command" CommandArgument='<%#Eval("CarBH") %>'></asp:LinkButton>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>

</asp:Content>
