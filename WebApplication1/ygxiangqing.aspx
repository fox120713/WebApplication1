<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="ygxiangqing.aspx.cs" Inherits="WebApplication1.ygxiangqing" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script src="js/jquery-3.3.1.min.js" type="text/javascript"></script>
    <style type="text/css">
        .bac {
            height: 100%;
            width: 100%;
            background-color: white;
            /*border: 1px solid black;*/
        }

        .bt {
            width: 100%;
            height: 10%;
            /*border: 1px solid red;*/
        }

            .bt img {
                border-radius: 60px;
            }

            .bt input {
                text-align: center;
            }

        .wenb {
            width: 100%;
            /*border: 1px solid black;*/
        }

            .wenb ul {
                height: 60px;
                width: 100%;
                float: left;
                padding: 0px;
                margin: 0px;
                /*border: 1px solid blue;*/
            }

                .wenb ul li {
                    float: left;
                    height: 50px;
                    text-align: center;
                    line-height: 50px;
                    width: 120px;
                    margin-left: 30px;
                }

                    .wenb ul li:hover {
                        border-bottom: 2px solid blue;
                    }

            .wenb img {
                height: 80px;
                width: 80px;
                border-radius: 80px;
            }

            .wenb .img {
                display: none;
            }

        .xg tr, td {
            height: 60px;
            width: 150px;
            font-size: 20px;
        }

        .xg input {
            height: 20px;
            width: 150px;
        }

        .img {
            height: 100%;
            width: 100%;
        }

            .img tr td {
                height: 100%;
                width: 100%;
            }

        .out {
            display: none;
            height: 100%;
            width: 100%;
        }
    </style>
    <link href="bp/bootstrap.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="header" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="bac">
        <div class="bt">
            <asp:Image ID="Image1" runat="server" ImageUrl="~/img/R-C.jfif" Width="60px" Height="60px" />
            <asp:Label ID="Label1" runat="server" Text="" Font-Size="35px" Height="60px" Width="150px"></asp:Label>
        </div>
        <div class="wenb">
            <ul>
                <li class="xgmm">修改密码</li>
                <li class="xgtx">更改头像</li>
                <li class="yhxq">用户详情</li>
                <li class="lz">离职申请</li>
            </ul>

            <table class="xg">
                <tr>
                    <td>用户名： </td>
                    <td style="width: 210px">
                        <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>密码： </td>
                    <td>
                        <asp:TextBox ID="TextBox1" runat="server" TextMode="Password"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>确认密码： </td>
                    <td>
                        <asp:TextBox ID="TextBox2" runat="server" TextMode="Password"></asp:TextBox>
                        <asp:CompareValidator ID="CompareValidator2" runat="server" ErrorMessage="*两次输入的密码不一致" ControlToValidate="TextBox1" ControlToCompare="TextBox2" Type="String" Operator="Equal" ForeColor="Red" Font-Size="15px" Width="180px"></asp:CompareValidator></td>
                </tr>
                <tr>
                    <td colspan="2" style="text-align: center;">
                        <asp:Button ID="Button1" runat="server" Text="确认" Height="40px" Width="80px" OnClick="Button1_Click"  class="btn btn-primary"/>
                        <asp:Button ID="Button2" runat="server" Text="取消" Height="40px" Width="80px"   class="btn btn-primary"/>
                    </td>
                </tr>
            </table>

            <table class="img">
                <tr>
                    <td>
                        <asp:Image ID="Image2" runat="server" ImageUrl="~/头像/1-3.png" />
                        <asp:Image ID="Image3" runat="server" ImageUrl="~/头像/2-5.png" />
                        <asp:Image ID="Image4" runat="server" ImageUrl="~/头像/3-3.jpg" />
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Image ID="Image5" runat="server" ImageUrl="~/头像/3-4.png" />
                        <asp:Image ID="Image6" runat="server" ImageUrl="~/头像/4-3.png" />
                        <asp:Image ID="Image7" runat="server" ImageUrl="~/头像/5-1.png" />
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Image ID="Image8" runat="server" ImageUrl="~/头像/5-2.png" />
                        <asp:Image ID="Image9" runat="server" ImageUrl="~/头像/5-3.png" />
                        <asp:Image ID="Image10" runat="server" ImageUrl="~/头像/5-6.png" />
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Image ID="Image11" runat="server" ImageUrl="~/头像/6-4.png" />
                        <asp:Image ID="Image12" runat="server" ImageUrl="~/头像/7-4.png" />
                        <asp:Image ID="Image13" runat="server" ImageUrl="~/头像/8-4.png" />
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Image ID="Image14" runat="server" ImageUrl="~/头像/9-3.png" />
                        <asp:Image ID="Image15" runat="server" ImageUrl="~/头像/9-4.png" />
                        <asp:Image ID="Image16" runat="server" ImageUrl="~/头像/9-5.png" />
                    </td>
                </tr>
                <tr>
                    <td colspan="3" style="text-align: center;">
                        <asp:Button ID="Button3" runat="server" Text="保存" OnClick="Button3_Click" Height="40px" Width="80px"  class="btn btn-primary" />
                    </td>
                </tr>

            </table>

            <div class="row" style="margin-left:20px">
                <table style="width: 100%;">
                    <tr>
                        <td>业主ID:<asp:Label ID="laid" runat="server" Text="Label"></asp:Label>

                        </td>
                        <td>业主姓名：<asp:Label ID="laname" runat="server" Text="Label"></asp:Label></td>

                    </tr>
                    <tr>
                        <td>性别：<asp:Label ID="lasex" runat="server" Text="Label"></asp:Label></td>
                        <td>年龄：<asp:Label ID="laage" runat="server" Text="Label"></asp:Label></td>

                    </tr>
                    <tr>
                        <td>身份证:<asp:Label ID="alsfz" runat="server" Text="Label"></asp:Label></td>
                        <td>联系方式：<asp:Label ID="laphone" runat="server" Text="Label"></asp:Label></td>
                    </tr>
                </table>
            </div>

            <div class="out">
                <table width="100%">
                    <tr>
                        <td>员工ID：<asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
                            员工姓名：<asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>性别：<asp:Label ID="Label5" runat="server" Text="Label"></asp:Label>
                            年龄：<asp:Label ID="Label6" runat="server" Text="Label"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>身份证：<asp:Label ID="Label7" runat="server" Text="Label"></asp:Label>
                            联系方式：<asp:Label ID="Label8" runat="server" Text="Label"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td colspan="2">离职原因：
                        </td>
                    </tr>
                    <tr>
                        <td colspan="2">
                            <asp:TextBox ID="TextBox3" runat="server" MaxLength="50" TextMode="DateTime"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Button ID="Button5" runat="server" Text="确认" OnClick="Button5_Click"  class="btn btn-primary" />
                            <asp:Button ID="Button4" runat="server" Text="取消"   class="btn btn-primary"/>
                        </td>
                    </tr>
                </table>
            </div>


        </div>

    </div>
    <asp:HiddenField ID="hidd_Img" runat="server" />
    <asp:HiddenField ID="HiddenField1" runat="server" />
    <script type="text/javascript">
        $(function () {
            $(".row").css("display", "none");

            $(".xgtx").click(function () {
                $(".img").css("display", "block");
                $(".xg").css("display", "none");
                $(".out").css("display", "none");
                $(".row").css("display", "none");
            })
            $(".xgmm").click(function () {
                $(".xg").css("display", "block");
                $(".img").css("display", "none");
                $(".out").css("display", "none");
                $(".row").css("display", "none");
            })
            $(".yhxq").click(function () {
                $(".row").css("display", "block");
                $(".img").css("display", "none");
                $(".xg").css("display", "none");
                $(".out").css("display", "none");
            })

            $(".lz").click(function () {
                $(".out").css("display", "block");
                $(".img").css("display", "none");
                $(".xg").css("display", "none");
                $(".row").css("display", "none");
            })

            $("img").click(function () {
                var a = $(this).attr("src");
                var lj = a.substring(a.indexOf("/"));
                $("#ContentPlaceHolder1_Image1").attr("src", "/头像" + lj);
                // alert(lj);
                document.getElementById("ContentPlaceHolder1_HiddenField1").value = lj;  //赋值
            })


        })

    </script>
</asp:Content>
