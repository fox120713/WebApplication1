<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="buyhome.aspx.cs" Inherits="WebApplication1.buyhome" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="header" runat="server">
    <style type="text/css">
        .GridView_ys {
        height:100%;
        width:100%;
        background-color:white;
        }
    </style>
    <link href="bp/bootstrap.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="GridView_ys">

    <asp:GridView ID="GridView1" runat="server" AllowPaging="True" OnPageIndexChanging="GridView1_PageIndexChanging" PageSize="20" AutoGenerateColumns="False" CssClass="table table-striped table-bordered table-hover table-condensed">
        <Columns>
            <asp:BoundField DataField="hometype" HeaderText="房屋类型" />
            <asp:BoundField DataField="homenumber" HeaderText="房屋门牌" />
            <asp:TemplateField HeaderText="操作" ShowHeader="False">
                <ItemTemplate>
                    <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="False" CommandName="Select" Text="选择" CommandArgument='<%#Eval("homenumber") %>' OnCommand="LinkButton1_Command"></asp:LinkButton>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
        </asp:GridView>

    </div>

</asp:Content>
