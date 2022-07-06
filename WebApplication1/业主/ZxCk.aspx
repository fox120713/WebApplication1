<%@ Page Title="" Language="C#" MasterPageFile="~/业主/SiteYezhu.Master" AutoEventWireup="true" CodeBehind="ZxCk.aspx.cs" Inherits="WebApplication1.业主.ZxCk" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../bp/bootstrap.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="header" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" class="table table-striped table-bordered table-hover table-condensed" >
        <Columns>
            <asp:BoundField DataField="RepnnID" HeaderText="id" Visible="False" />
            <asp:BoundField DataField="RepnnpDay" HeaderText="开始时间" />
            <asp:BoundField DataField="RepnnPDays" HeaderText="结束时间" />
            <asp:BoundField DataField="RepnnMoney" HeaderText="押金" />
            <asp:BoundField DataField="Repnzt" HeaderText="装修状态" />
            <asp:BoundField DataField="Moneyzt" HeaderText="押金状态" />
            <asp:TemplateField HeaderText="装修进度">
                <ItemTemplate>
                    <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="False" CommandArgument='<%# Eval("RepnnID") %>' CommandName='<%# Eval("Repnzt") %>' Text='<%# Eval("Repnzt","{0}")=="已完成"?"已完成":"未完成" %>' OnClientClick="return confirm('是否申请完成')" OnCommand="LinkButton1_Command"></asp:LinkButton>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
        
    </asp:GridView>
</asp:Content>
