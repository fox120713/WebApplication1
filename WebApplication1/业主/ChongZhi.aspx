<%@ Page Title="" Language="C#" MasterPageFile="~/业主/SiteYezhu.Master" AutoEventWireup="true" CodeBehind="ChongZhi.aspx.cs" Inherits="WebApplication1.业主.ChongZhi" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        .body {
            width: 540px;
            height: 520px;
            border: 1px solid #ccc8c8;
            border-radius: 10px;
            margin-left: 50px;
            padding: 50px;
            float: left;
            background-color: white;
            box-shadow: white 10px;
        }

        .title { 
            margin-top: 15px;
        }

        .czBody {
            width: 450px;
            height: 40px;
            margin-left: 0px;
        }

        .czborder {
            width: 120px;
            height: 45px;
            border: 1px solid #ccc8c8;
            border-radius: 5px;
            float: left;
            margin-left: 20px;
            margin-top: 10px;
        }

        tr {
            line-height: 50px;
        }

        #Text1 {
            width: 400px;
            height: 45px;
            border-radius: 5px;
        }

        #Text2 {
            width: 200px;
            height: 45px;
            border-radius: 5px;
            border: 1px solid #ccc8c8;
            border-radius: 5px;
            margin-left: 20px;
            margin-top: 20px;
        }
         #Text3 {
            width: 450px;
            height: 45px;
            border-radius: 5px;
            border: 1px solid #ccc8c8;
            border-radius: 5px;
            margin-left: 20px;
            margin-top: 20px;
        }


        h5 {
            position: relative;
            top: -12px;
            left: 10px;
        }

        .radio {
            position: relative;
            top: -55px;
            left: 40px;
            line-height: 40px;
        }

        #ButtonC {
            position: absolute;
            left: 1000px;
        }

        #ButtonC {
            margin-left: 20px;
            top: 932px;
        }

        #ButtonQ {
            position: relative;
            top: 200px;
            left: 0px;
        }

        .bj {
            background-color: #dfdff2;
            border: 0px;
        }

        .Card {
            width: 500px;
            height: 180px;
            border: 1px #808080 solid;
            border-radius: 10px;
            margin-top: -50px;
            margin-left: -50px;
            background-color:#7048d4;
        }

        .img {
            width: 200px;
            height: 200px;
            /*margin-left: 290px;
            margin-top: -80px;*/
            position:relative;
            top:-150px;
            left:300px;
            float: left;
        }

        .CardTitle {
            color: white;
            font-family: 微软简标宋;
            margin-top: 20px;
            margin-left: 20px;
        }

        .CardTitle1 {
            color: white;
            font-family: 微软简标宋;
            margin-left: 25px;
        }
        .Card2 {
            width: 500px;
            height: 320px;
            border: 1px solid #ccc8c8;
            border-radius: 5px;
            /*margin-left:-50px;
            margin-top:20px;*/
            position: absolute;
            overflow:hidden;
            top:310px;
            left:850px;
        }
        #LabelZF {
            margin-top:80px;
            font-size:50px;
        }
        .Card2-1 {
             width: 450px;
            height: 120px;
            border: 1px solid #ccc8c8;
            border-radius: 5px;
          /*position: absolute;
            top:350px;
            left:880px;*/
        }
        .textbox {
           width:400px;
           height:45px;
           border-radius: 5px;
        }
        #TextBox2 {
            margin-top:20px;
        }
        table {
            margin-top:-60px;
        }

    </style>
    <link href="../bootstrap.css" rel="stylesheet" />
    <script src="../js/jquery-3.3.1.min.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <h4>&emsp;普通账户</h4>
        <div class="body form-group">
            <p class="title">在线充值</p>
            <table>
                <tr>
                    <td>充值账号</td>
                </tr>
                <tr>
                    <td>
                        <asp:TextBox ID="TextBox1" runat="server" CssClass="textbox" ReadOnly="True"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="*" ControlToValidate="TextBox1" Font-Size="20pt" ForeColor="Red"></asp:RequiredFieldValidator></td>
                </tr>
                <tr>
                    <td>充值金额</td>
                </tr>
            </table>
            <div class="czBody">
                <div class="czborder">
                    <h5 style="line-height: 45px;margin-left:40px;">200元</h5>
                    <asp:RadioButton ID="RadioButton1" runat="server" CssClass="radio" GroupName="Money" BackColor="White" />
                </div>
                <div class="czborder">
                    <h5 style="line-height: 45px;margin-left:40px;">300元</h5>
                    <asp:RadioButton ID="RadioButton2" runat="server" CssClass="radio" GroupName="Money" />
                </div>
                <div class="czborder">
                    <h5 style="line-height: 45px;margin-left:40px;">400元</h5>
                    <asp:RadioButton ID="RadioButton3" runat="server" CssClass="radio" GroupName="Money" BorderColor="White" ForeColor="Black" EnableViewState="False"   />
                </div>
                <br />
                <asp:TextBox ID="TextBox2" runat="server"  CssClass="textbox" Width="380" ></asp:TextBox>
                &nbsp;&nbsp; 元<br />
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="请输入非负数" ForeColor="Red" ControlToValidate="TextBox2" ValidationExpression="^\d+$"></asp:RegularExpressionValidator>
                <h6>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 注：如遇到问题可拨打电话10088求助</h6>
                <br />
                &nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="ButtonC" runat="server" Text="立即充值" CssClass="btn btn-primary btn-lg" Width="190px" BackColor="#1f63f0" OnClick="ButtonC_Click" /><asp:Button ID="ButtonQ" runat="server" Text="取消充值" CssClass="btn btn-primary btn-lg" Width="190px" BackColor="#E6E3F9" ForeColor="#337AB7" />

            </div>
        </div>
        <div class="body form-group bj">
            <div class="Card">
                <h4 class="CardTitle">账户余额</h4>
                <asp:Label ID="LaMoney" runat="server" Text="0" Font-Size="30pt" ForeColor="White" class="CardTitle" Font-Bold="True"></asp:Label>
                <div>
                    <asp:Image ID="ImageCard" runat="server" ImageUrl="~/img/暂无银行卡.png"  Class="img"/>

                </div>
            </div>
            <div class="Card2">
                <asp:Label ID="Label1" runat="server" Text="充值渠道" ></asp:Label><br />
                <asp:TextBox ID="TextBox3" runat="server" CssClass="textbox" Enabled="False"></asp:TextBox><br />
                <br />
                <asp:Label ID="Label2" runat="server" Text="小区物业充值"></asp:Label><br />
                <br />
                 <br />
                <div class="Card2-1" >
                    &emsp;&emsp;共计：¥<asp:Label ID="LabelZF" runat="server" Text="0.00"></asp:Label><br />
                    <hr />
                    <p>&emsp;&emsp;支付账户：扣款</p>

                </div>

            </div>
        </div>
        </div>
   <script type="text/javascript">
       $(function () {
           $("#ContentPlaceHolder1_TextBox2").click(function () {
               $("input[type='radio']").prop("checked", false);



           });
           $("input[type='radio']").click(function () {
               $("#ContentPlaceHolder1_TextBox2").val("");
           });

       });

		</script>
</asp:Content>
