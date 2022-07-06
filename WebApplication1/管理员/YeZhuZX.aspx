<%@ Page Title="" Language="C#" MasterPageFile="~/管理员/site.Master" AutoEventWireup="true" CodeBehind="YeZhuZX.aspx.cs" Inherits="WebApplication1.管理员.YeZhuZX" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
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
             业主名称：<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><asp:Button ID="Button1" runat="server" Text="查询" class="btn btn-success" OnClick="Button1_Click" />
        </div>
        
    </div>

     <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" Class="table table-striped table-hover">
        <Columns>
            <asp:BoundField DataField="UserName" HeaderText="业主名称" />
            <asp:BoundField DataField="UserCell" HeaderText="业主门牌号" />
            <asp:BoundField DataField="RepnnpDay" HeaderText="装修开始日期" />
            <asp:BoundField DataField="RepnnPDays" HeaderText="装修结束日期" />   
            <asp:BoundField DataField="RepnnMoney" HeaderText="押金" />
            <asp:BoundField DataField="Repnzt" HeaderText="装修状态" />
            
            <asp:BoundField DataField="ztspr" HeaderText="验收人" />
            
            <asp:TemplateField HeaderText="验收" ShowHeader="False">
                <ItemTemplate>
                    <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="False" CommandName="Select" CommandArgument='<%# Eval("RepnnID") %>' Text='<%# Eval("Repnzt","{0}")=="待验收"?"选择验收人":"" %>' OnCommand="LinkButton1_Command"></asp:LinkButton>
                </ItemTemplate>
            </asp:TemplateField>
            
        </Columns>
</asp:GridView>
</asp:Content>
