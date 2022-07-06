<%@ Page Title="" Language="C#" MasterPageFile="~/业主/SiteYezhu.Master" AutoEventWireup="true" CodeBehind="JiaoFei.aspx.cs" Inherits="WebApplication1.业主.JiaoFei" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../bootstrap.css" rel="stylesheet" />
    <style>
     
        .BodyBoder {
            width: 420px;
            height: 600px;
            border: 1px solid #ccc8c8;
            border-radius: 20px;
            float: left;
            margin-left: 20px;
            margin-top: 10px;
            margin-left:380px;
            background-color:white;
            box-shadow: 0 0 10px white;
        }
        .title {
            /*font-size:24px;*/
            color:white;
        }
    img{
                width:120px;
                height:120px;
                margin-left:160px;
                margin-top:80px
            }
        .Card{
            width:300px;
            height:300px;
            border:1px solid #ccc8c8;
            border-radius: 20px;
            margin:0px auto;
            text-align:center;
            /*background:rgba(113, 197, 234, 0.57);*/
            margin-top:20px;
        }
        .box {
         
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
            <div class="box">
                <div class="BodyBoder">
                    <asp:Image ID="Image2" runat="server" ImageUrl="~/img/云端管理 (1).png" />
                    <div class="Card">
                        <p class="title " style="background-color:#3a4c9d">缴费</p>
                        <p>&nbsp;</p>
                        <asp:DropDownList ID="DropDownList1" runat="server" BackColor="White" ForeColor="Black">
                        </asp:DropDownList>
                        <br />
                        <br />
                        <asp:TextBox ID="TextBox2" runat="server"  BackColor="White" ForeColor="Black" Text="请输入楼栋号"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="*" ForeColor="Red" ControlToValidate="TextBox2" Font-Size="14pt"></asp:RequiredFieldValidator><br />
                        
                        <br />
                        <br />
                        <asp:TextBox ID="TextBoxMoney" runat="server" Text="请输入金额" BackColor="White" ForeColor="Black"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="*" ForeColor="Red" ControlToValidate="TextBoxMoney" Font-Size="14pt"></asp:RequiredFieldValidator><br />
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="请输入非负数" ForeColor="Red" ControlToValidate="TextBoxMoney" ValidationExpression="^\d+$"></asp:RegularExpressionValidator>
                        <br />
                        <br />
                        <asp:Button ID="BtnJF" runat="server" Text="缴费" class=" btn btn-primary btn-lg" BackColor="White" ForeColor="Black" OnClick="BtnJF_Click" />
                    </div>
                </div>
            </div>
    </div>
</asp:Content>
