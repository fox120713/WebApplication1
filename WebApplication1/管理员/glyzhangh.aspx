<%@ Page Title="" Language="C#" MasterPageFile="~/管理员/site.Master" AutoEventWireup="true" CodeBehind="glyzhangh.aspx.cs" Inherits="WebApplication1.glyzhangh" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../css/bootstrap.css" rel="stylesheet" />
    <style type="text/css">
        .glybox {
            height: 100%;
            width: 100%;
            background-color: white;
            /*border: 1px solid black;*/
        }

        .card {
            height: 20%;
            width: 100%;
            /*border: 1px solid red;*/
            background: linear-gradient(-45deg, #3A5FCD, #4876FF, #5D478B, #1874CD);
            background-size: 600% 600%;
            animation: gradientBG 20s ease infinite;
            margin: 0px initial;
        }

        @keyframes gradientBG {
            0% {
                background-position: 0% 50%;
            }

            50% {
                background-position: 100% 50%;
            }

            100% {
                background-position: 0% 50%;
            }
        }

        .card_tittle {
            height: 30%;
            width: 100%;
            background-color: white;
            opacity: 0.5;
            font-size: 20px;
            padding-top:5px;
        }

            .card_tittle img {
                height: 30px;
            }

        .card_sel {
            width: 100%;
            height: 70%;
        }

            .card_sel table {
                width: 100%;
                height: 100%;
                color: white;
                /*border: 1px solid red;*/
            }

                .card_sel table tr {
                    /*border: 1px solid red;*/
                }

                .card_sel table td {
                    /*border: 1px solid red;*/
                }

        .biao {
            background-color: #dfdff2;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="header" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="glybox">

        <div class="card">
            <%--渐变卡片效果--%>
            <div class="card_tittle">
                <asp:Image ID="Image1" runat="server" ImageUrl="~/img/理财.png" />
                <span style="margin-left: 10px; margin-right:10px">收入汇总 </span>
                <asp:DropDownList ID="DropDownList3" runat="server" AutoPostBack="true" OnSelectedIndexChanged="DropDownList3_SelectedIndexChanged">
                    <asp:ListItem>收入</asp:ListItem>
                    <asp:ListItem>支出</asp:ListItem>
                </asp:DropDownList>
            </div>
            <div class="card_sel">
                <table>

                    <tr style="height: 20%;">
                        <td>
                            <asp:DropDownList ID="DropDownList1" runat="server" Width="200px" ForeColor="Black">
                                <asp:ListItem>2022年</asp:ListItem>
                            </asp:DropDownList>
                        </td>
                        <td>收入
                        </td>
                        <td>支出
                        </td>
                    </tr>

                    <tr style="font-size: 30px;">
                        <td>
                            <asp:DropDownList ID="DropDownList2" runat="server" Width="200px" ForeColor="Black" OnSelectedIndexChanged="DropDownList2_SelectedIndexChanged" AutoPostBack="true"></asp:DropDownList>
                        </td>
                        <td>
                            <asp:Label ID="Label3" runat="server" Text="￥"></asp:Label>
                            <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
                        </td>
                        <td>
                            <asp:Label ID="Label4" runat="server" Text="￥"></asp:Label>
                            <asp:Label ID="Label2" runat="server" Text=""></asp:Label>
                        </td>
                    </tr>

                </table>
            </div>
        </div>

        <div class="biao">
            <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AutoGenerateColumns="False" OnPageIndexChanging="GridView1_PageIndexChanging" PageSize="12" CssClass="table table-striped table-bordered table-hover table-condensed">
                <Columns>
                    <asp:BoundField DataField="WuyeId" HeaderText="账单编号" />
                    <asp:BoundField DataField="Zdly" HeaderText="业主门牌编号" />
                    <asp:BoundField DataField="PayName" HeaderText="收入类型" />
                    <asp:BoundField DataField="dates" DataFormatString="{0:d}" HeaderText="时间" />
                    <asp:BoundField DataField="Zdmoney" HeaderText="金额" />
                </Columns>
            </asp:GridView>
        </div>

    </div>

</asp:Content>
