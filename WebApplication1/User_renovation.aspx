<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="User_renovation.aspx.cs" Inherits="WebApplication1.User_renovation" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="css/bootstrap.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
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
            <asp:BoundField DataField="RepnnpDay" HeaderText="装修开始日期" DataFormatString="{0:d}" />
            <asp:BoundField DataField="RepnnPDays" HeaderText="装修结束日期" DataFormatString="{0:d}" />   
            <asp:BoundField DataField="RepnnMoney" HeaderText="押金" />
            <asp:BoundField DataField="Repnzt" HeaderText="装修进度" />
            
            
            <asp:BoundField DataField="ztspr" HeaderText="进度审批人" />
            <asp:TemplateField ShowHeader="False">
                <ItemTemplate>
                    <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="False" CommandName='<%#Eval("Repnzt") %>' CommandArgument='<%#Eval("RepnnID") %>' Text="审批" OnCommand="LinkButton1_Command"  ></asp:LinkButton>
                </ItemTemplate>
            </asp:TemplateField>
            
        </Columns>
</asp:GridView>
        

</asp:Content>
