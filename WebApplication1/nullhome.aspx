<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="nullhome.aspx.cs" Inherits="WebApplication1.nullhome" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="css/bootstrap.css" rel="stylesheet" />

    <style type="text/css">
        .list {
            /*text-align: center;*/
            /*border: 1px solid red;*/
        }

        .panel-body input {
            width: 300px;
            height: 30px;
            margin-left: 20px;
        }

        .list input {
            width: 300px;
            height: 30px;
            margin-left: 20px;
        }
    </style>

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
            房屋类型：<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" Text="查询" Width="120px" CssClass="btn btn-success" OnClick="Button1_Click" />
    </div>
 </div>

    <div class="list">
        <%--空房表--%>
        <asp:GridView ID="GridView1" runat="server" CssClass="table table-striped table-bordered table-hover table-condensed" AutoGenerateColumns="False">
            <Columns>
                <asp:BoundField DataField="房屋类型" HeaderText="房屋类型" />
                <asp:BoundField DataField="房屋数量" HeaderText="房屋数量" />
                <asp:TemplateField HeaderText="操作" ShowHeader="False" SortExpression="0">
                    <ItemTemplate>
                        <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="False" CommandName="Select" Text="选择" CommandArgument='<%#Eval("房屋类型") %>' OnCommand="LinkButton1_Command1"></asp:LinkButton>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
    </div>

</asp:Content>
