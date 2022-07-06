<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="xinxifuwu.aspx.cs" Inherits="WebApplication1.xinxi_fuwu" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="bp/bootstrap.css" rel="stylesheet" />
    <style type="text/css">
        .sel, sel1, .sel2, .sel3, .sel4, .sel5, .sel6 {
            height: 10%;
            width: 100%;
            line-height: 60px;
            text-align: center;
            display: none;
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

        .list1 input {
            width: 300px;
            height: 30px;
            margin-left: 20px;
        }

        .list2 input {
            width: 300px;
            height: 30px;
            margin-left: 20px;
        }

        .list3 input {
            width: 300px;
            height: 30px;
            margin-left: 20px;
        }

        .list4 input {
            width: 300px;
            height: 30px;
            margin-left: 20px;
        }

        .list5 input {
            width: 300px;
            height: 30px;
            margin-left: 20px;
        }

        .list6 input {
            width: 300px;
            height: 30px;
            margin-left: 20px;
        }

        .list7 input {
            width: 300px;
            height: 30px;
            margin-left: 20px;
        }


        .list, .list1, .list2 {
            text-align: center;
            /*border: 1px solid red;*/
        }

        .list7 table {
            height: 600px;
            width: 300px;
            border: 1px solid red;
            text-align: center;
            background-color: white;
            font-size: 20px;
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

            <div class="sel">
                房屋类型：<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                <asp:Button ID="Button1" runat="server" Text="查询" Width="120px" CssClass="btn btn-success" OnClick="Button1_Click" />
            </div>

            <div class="sel1">
                业主姓名：<asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
                业主门牌：<asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
                <asp:Button ID="Button4" runat="server" Text="查询" Width="120px" CssClass="btn btn-success" OnClick="Button4_Click" />
            </div>

            <div class="sel2">
                车位号：<asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
                <asp:Button ID="Button5" runat="server" Text="查询" Width="120px" CssClass="btn btn-success" OnClick="Button5_Click" />
            </div>

            <div class="sel3">
                业主门牌号：<asp:TextBox ID="TextBox10" runat="server"></asp:TextBox>
                业主姓名：<asp:TextBox ID="TextBox9" runat="server"></asp:TextBox>
                <asp:Button ID="Button6" runat="server" Text="查询" Width="120px" CssClass="btn btn-success" OnClick="Button6_Click" />
            </div>

            <div class="sel4">
                员工姓名：<asp:TextBox ID="TextBox11" runat="server"></asp:TextBox>
                所属部门：<asp:DropDownList ID="DropDownList1" runat="server"></asp:DropDownList>
                <asp:Button ID="Button7" runat="server" Text="查询" Width="120px" CssClass="btn btn-success" OnClick="Button7_Click" />
            </div>

            <div class="sel5">
                员工姓名：<asp:TextBox ID="TextBox12" runat="server"></asp:TextBox>
                性别：<asp:DropDownList ID="DropDownList2" runat="server"></asp:DropDownList>
                <asp:Button ID="Button8" runat="server" Text="查询" Width="120px" CssClass="btn btn-success" OnClick="Button8_Click" />
            </div>

            <div class="sel6">
                公告标题：<asp:TextBox ID="TextBox14" runat="server"></asp:TextBox>
                公告状态：<asp:DropDownList ID="DropDownList3" runat="server"></asp:DropDownList>
                <asp:Button ID="Button9" runat="server" Text="查询" Width="120px" CssClass="btn btn-success" OnClick="Button9_Click" />
            </div>

        </div>

    </div>
    <div>
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
        <div class="list1">
            <%--业主居住信息表--%>
            <asp:GridView ID="GridView2" runat="server" AllowPaging="True" OnPageIndexChanging="GridView2_PageIndexChanging" CssClass="table table-striped table-bordered table-hover table-condensed" AutoGenerateColumns="False">
                <Columns>
                    <asp:BoundField DataField="UserName" HeaderText="业主姓名" />
                    <asp:BoundField DataField="UserSex" HeaderText="业主性别" />
                    <asp:BoundField DataField="UserCell" HeaderText="业主门牌" />
                    <asp:BoundField DataField="UserPhone" HeaderText="业主电话" />
                    <asp:BoundField DataField="UserPwd" HeaderText="业主账号密码" />
                </Columns>
            </asp:GridView>
        </div>
        <div class="list2">
            <%--空车位表--%>
            <asp:GridView ID="GridView3" runat="server" AutoGenerateColumns="False" CssClass="table table-striped table-bordered table-hover table-condensed">
                <Columns>
                    <asp:BoundField DataField="CarID" HeaderText="车位编号" />
                    <asp:TemplateField HeaderText="车位状态">
                        <EditItemTemplate>
                            <asp:TextBox ID="TextBox1" runat="server" Text='<%# Eval("CarSta") %>'></asp:TextBox>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="Label1" runat="server" Text='<%# Eval("CarSta","{0}")=="0"?"空":""%>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="操作" ShowHeader="False">
                        <ItemTemplate>
                            <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="False" CommandName="Select" Text="选择" OnCommand="LinkButton1_Command" CommandArgument='<%#Eval("CarID") %>'></asp:LinkButton>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
        </div>

        <div class="list3">
            <%--业主维修信息表--%>
            <asp:GridView ID="GridView4" runat="server" AllowPaging="True" OnPageIndexChanging="GridView4_PageIndexChanging" CssClass="table table-striped table-bordered table-hover table-condensed" AutoGenerateColumns="False">
                <Columns>
                    <asp:BoundField DataField="UserName" HeaderText="业主姓名" />
                    <asp:BoundField DataField="RepnNumber" HeaderText="门牌号" />
                    <asp:BoundField DataField="RepnpDay" HeaderText="申请日期" />
                    <asp:BoundField DataField="RepnPhone" HeaderText="业主电话" />
                    <asp:BoundField DataField="RepnWhat" HeaderText="申请原因" />
                    <asp:BoundField DataField="RepnState" HeaderText="申请状态" />
                    <asp:BoundField DataField="ReppDayk" HeaderText="维修日期" />
                    <asp:BoundField DataField="ReppBool" HeaderText="维修状态" />
                    <asp:BoundField DataField="ReppMan" HeaderText="维修负责人" />
                </Columns>
            </asp:GridView>
        </div>

        <div class="list4">
            <%--员工离职状态表--%>
            <asp:GridView ID="GridView5" runat="server" CssClass="table table-striped table-bordered table-hover table-condensed" AutoGenerateColumns="False">
                <Columns>
                    <asp:BoundField DataField="Ygid" HeaderText="员工id" />
                    <asp:BoundField DataField="YgName" HeaderText="员工姓名" />
                    <asp:BoundField DataField="PosName" HeaderText="所属部门" />
                    <asp:BoundField DataField="YgBool" HeaderText="审核状态" />
                </Columns>
            </asp:GridView>
        </div>

        <div class="list5">
            <%--员工信息表--%>
            <asp:GridView ID="GridView6" runat="server" AllowPaging="True" CssClass="table table-striped table-bordered table-hover table-condensed" AutoGenerateColumns="False" OnPageIndexChanging="GridView6_PageIndexChanging">
                <Columns>
                    <asp:BoundField DataField="YgName" HeaderText="员工姓名" />
                    <asp:BoundField DataField="YgSex" HeaderText="员工性别" />
                    <asp:BoundField DataField="YgAge" HeaderText="员工年龄" />
                    <asp:BoundField DataField="YgPhone" HeaderText="员工电话" />
                </Columns>
            </asp:GridView>
        </div>

        <div class="list6">
            <%--公告审核表--%>
            <asp:GridView ID="GridView7" runat="server" AllowPaging="True" AutoGenerateColumns="False" OnPageIndexChanging="GridView7_PageIndexChanging" PageSize="4" CssClass="table table-striped table-bordered table-hover table-condensed">
                <Columns>
                    <asp:BoundField DataField="AnnTitle" HeaderText="公告标题">
                        <FooterStyle Width="80px" />
                    </asp:BoundField>
                    <asp:BoundField DataField="AnnCon" HeaderText="公告内容">
                        <FooterStyle Width="150px" />
                        <ItemStyle Height="30px" />
                    </asp:BoundField>
                    <asp:BoundField DataField="AnnsqrID" HeaderText="公告发布人编号" />
                    <asp:BoundField DataField="AnnaName" HeaderText="公告发布人姓名" />
                    <asp:BoundField DataField="AnnaIstate" HeaderText="公告审核状态" />
                    <asp:BoundField DataField="AnnWhy" HeaderText="状态原因" />
                </Columns>
            </asp:GridView>
        </div>

        <div class="list7">
            <table class="table">
                <tr>
                    <td>公告标题：</td>
                    <td>
                        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>公告内容：</td>
                    <td>
                        <asp:TextBox ID="TextBox3" runat="server" Height="80px" TextMode="MultiLine" Width="303px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>公告申请人： </td>
                    <td>
                        <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="Button3" runat="server" Text="确定" BackColor=" #0094ff" ForeColor="White" Height="30px" OnClick="Button3_Click" />
                    </td>
                    <td>
                        <asp:Button ID="Button2" runat="server" Text="取消" BackColor=" #0094ff" ForeColor="White" Height="30px" OnClick="Button2_Click" />
                    </td>
                </tr>
            </table>
        </div>


    </div>
    <script>
        var a = "<%=Request.QueryString["a"]%>"
        $(function () {
            //$(".list1").css("display") == "block"

            $(".list").css("display", "none");
            $(".list1").css("display", "none");
            $(".list2").css("display", "none");
            $(".list3").css("display", "none");
            $(".list4").css("display", "none");
            $(".list5").css("display", "none");
            $(".list6").css("display", "none");
            $(".list7").css("display", "none");

            <%
        if (int.Parse(Request.QueryString["id"].ToString()) == 1)
        {%>
            $(".sel").css("display", "block");
            $(".list").css("display", "block");
            $(".list").siblings().css("display", "none");
            $(".sel").siblings().css("display", "none");
       <% }
        else if (int.Parse(Request.QueryString["id"].ToString()) == 2)
        {%>
            $(".sel1").css("display", "block");
            $(".list1").css("display", "block");
            $(".list1").siblings().css("display", "none");
            $(".sel1").siblings().css("display", "none");
            <%  }
        else if (int.Parse(Request.QueryString["id"].ToString()) == 3)
        {%>
            $(".sel2").css("display", "block");
            $(".list2").css("display", "block");
            $(".list2").siblings().css("display", "none");
            $(".sel2").siblings().css("display", "none");
      <%  }
        else if (int.Parse(Request.QueryString["id"].ToString()) == 4)
        {%>
            $(".sel3").css("display", "block");
            $(".list3").css("display", "block");
            $(".list3").siblings().css("display", "none");
            $(".sel3").siblings().css("display", "none");
       <% }
        else if (int.Parse(Request.QueryString["id"].ToString()) == 5)
        {%>
            $(".sel4").css("display", "block");
            $(".list4").css("display", "block");
            $(".list4").siblings().css("display", "none");
            $(".sel4").siblings().css("display", "none");
       <% }
        else if (int.Parse(Request.QueryString["id"].ToString()) == 6)
        {%>
            $(".sel5").css("display", "block");
            $(".list5").css("display", "block");
            $(".list5").siblings().css("display", "none");
            $(".sel5").siblings().css("display", "none");
        <%}
        else if (int.Parse(Request.QueryString["id"].ToString()) == 7)
        {%>
            $(".sel6").css("display", "block");
            $(".list6").css("display", "block");
            $(".list6").siblings().css("display", "none");
            $(".sel6").siblings().css("display", "none");
       <% }
        else if (int.Parse(Request.QueryString["id"].ToString()) == 8)
        {%>
            $(".list7").css("display", "block");
            $(".list7").siblings().css("display", "none");
            $(".panel-body,.panel-heading").css("display", "none");
       <% }%>





            $(".img").click(function () {
                window.location.href = "user.aspx";
            })
            $(".home").click(function () {
                //房屋信息显示
                $(".sel").css("display", "block");
                $(".list").css("display", "block");
                $(".list").siblings().css("display", "none");
            })

            $(".master").click(function () {
                //业主信息显示
                $(".sel1").css("display", "block");
                $(".list1").css("display", "block");
                $(".list1").siblings().css("display", "none");
            })

            $(".car").click(function () {
                //空车位信息显示
                $(".sel").css("display", "block");
                $(".list2").css("display", "block");
                $(".list2").siblings().css("display", "none");
            })

            $(".dec").click(function () {
                //空车位信息显示
                $(".sel").css("display", "block");
                $(".list3").css("display", "block");
                $(".list3").siblings().css("display", "none");
            })

            $(".leave").click(function () {
                //空车位信息显示
                $(".sel").css("display", "block");
                $(".list4").css("display", "block");
                $(".list4").siblings().css("display", "none");
            })

            $(".accn").click(function () {
                //空车位信息显示
                $(".sel").css("display", "block");
                $(".list5").css("display", "block");
                $(".list5").siblings().css("display", "none");
            })

            $(".ann").click(function () {
                //空车位信息显示
                $(".sel").css("display", "block");
                $(".list6").css("display", "block");
                $(".list6").siblings().css("display", "none");
            })

            $(".anntj").click(function () {
                $(".sel").css("display", "block");
                $(".list7").css("display", "block");
                $(".list7").siblings().css("display", "none");
            })


        })
    </script>

</asp:Content>
