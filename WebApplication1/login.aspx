<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="WebApplication1.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link rel="stylesheet" href="css/sample.css" />
    <link rel="stylesheet" href="css/buttons.css" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <meta http-equiv="X-UA-Compatible" content="IE=edge,chrome=1" />
    <title></title>
    <style type="text/css">
        .wordbox {
            height: 600px;
            width: 500px;
            float: left;
            position: absolute;
            text-align: center;
            top: 55px;
            left: 500px;
        }

        .log {
            height: 80px;
            width: 500px;
        }

        .wordbox img {
            height: 150px;
        }

        .pic {
            opacity: 0.7;
            background-color: white;
            /*border: 1px solid red;*/
            height: 450px;
            width: 500px;
            border-radius: 10%;
        }

            .pic input {
                margin-bottom: 40px;
                border-radius: 20px;
                height: 40px;
                width: 400px;
            }

        .radio {
            font-family: 微软雅黑;
            font-size: 15px;
            text-align: left;
            margin-left: 40px;
        }

            .radio input {
                height: 20px;
                width: 20px;
                margin-bottom: 40px;
            }

            .radio a {
                text-decoration: none;
            }

        .head {
            height: 20%;
            width: 100%;
            /*border: 1px solid black;*/
            line-height: 60px;
            text-align: center;
            font-size: 20px;
        }

        .box {
            margin-left: 40px;
            height: 1px;
            width: 80%;
            background-color: grey;
        }
    </style>
</head>
<body class="starlight">
    <form id="form1" runat="server">
        <div>
            <%--外联样式引用—特效--%>
            <script src="js/jquery-1.11.0.min.js" type="text/javascript"></script>
            <script src="js/starlight.js"></script>
        </div>

        <div class="wordbox">
            <%--登录样式--%>
            <img src="img/log.png" />
            <div class="pic">
                <div class="head">
                    <span>用户登录</span>
                    <div class="box"></div>
                </div>
                <asp:TextBox ID="name" runat="server" Placeholder="请输入用户名"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="*" ControlToValidate="name" ForeColor="Red"></asp:RequiredFieldValidator>
                <br />
                <asp:TextBox ID="pwd" runat="server" Placeholder="请输入密码" TextMode="Password">   </asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="*" ControlToValidate="pwd" ForeColor="Red"></asp:RequiredFieldValidator>
                <br />
                <asp:Button ID="Button1" runat="server" Text="登录" Font-Size="15px" BackColor="#0066ff" ForeColor="White" OnClick="Button1_Click" /><br />
                <div class="radio">
                    <asp:RadioButton ID="radiobtn" runat="server" /><span>我同意 <a href="servise/servise1.aspx" target="_blank">服务协议</a> 、 <a href="servise/servise2.aspx" target="_blank">隐私政策</a> 和 <a href="servise/servise3.aspx" target="_blank">物业管理服务协议</a></span>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
