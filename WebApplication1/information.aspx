<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="information.aspx.cs" Inherits="WebApplication1.information" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="css/bootstrap.css" rel="stylesheet" />
    <style>
        .repeater_div {
        background-color:white;
        border-radius:5px;
        height:80px;
        box-shadow:1px 1px 1px #f4e8e8;
        }
            .repeater_div p{
            line-height:30px;
            margin-left:20px;
            }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="header" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

     <div class="panel panel-default">
	<div class="panel-heading">
		<h3 class="panel-title">
			我的消息
		</h3>
	</div>
	</div>
        <asp:Repeater ID="Repeater1" runat="server">
            <ItemTemplate>
                <div class="repeater_div">
                    <p><b>您有一条新的公共维修通知</b> &nbsp;&nbsp;<%# Convert.ToDateTime(Eval("PrsDate")).ToString("yyyy年MM月dd日")%></p>
                <p><a href="WeiXiuXQ.aspx?id=<%# Eval("PrID") %>">查看详情>></a></p>
                </div>
            </ItemTemplate>
        </asp:Repeater>
    <br />
     <asp:Repeater ID="Repeater2" runat="server">
            <ItemTemplate>
                <div class="repeater_div">
                    <p><b>您有一条新的业主维修通知</b> &nbsp;&nbsp;<%# Convert.ToDateTime(Eval("RepnpDay")).ToString("yyyy年MM月dd日")%></p>
                <p><a href="UsWeiXiuXQ.aspx?id=<%# Eval("ReID") %>">查看详情>></a></p>
                </div>
            </ItemTemplate>
        </asp:Repeater>
    <br />
     <asp:Repeater ID="Repeater3" runat="server">
            <ItemTemplate>
                <div class="repeater_div">
                    <p><b>您有一条新的验收通知</b> &nbsp;&nbsp;</p>
                <p><a href="YSqueren.aspx?id=<%# Eval("RepnnID") %>">查看详情>></a></p>
                </div>
            </ItemTemplate>
        </asp:Repeater>

    <%--<asp:Button ID="Button1" runat="server" Text="通过" class="btn btn-success" />
        <asp:Button ID="Button2" runat="server" Text="拒绝" class="btn btn-danger" />--%>
	

</asp:Content>
