<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="sftj.aspx.cs" Inherits="WebApplication1.sftj" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../bootstrap.css" rel="stylesheet" />
    <style>
        body {
        }

        .BodyBoder {
            width: 420px;
            height: 600px;
            border: 1px solid #ccc8c8;
            border-radius: 20px;
            float: left;
            margin-left: 20px;
            margin-top: 10px;
            margin-left: 380px;
            background-color: white;
            box-shadow: 0 0 10px white;
        }

        .title {
            /*font-size:24px;*/
            color: white;
        }
        /*#Image2{
                width:120px;
                height:120px;
                margin-left:500px;
                margin-top:80px
            }*/
        .Card {
            width: 300px;
            height: 300px;
            border: 1px solid #ccc8c8;
            border-radius: 20px;
            margin: 0px auto;
            text-align: center;
            /*background:rgba(113, 197, 234, 0.57);*/
            margin-top: 20px;
        }

    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <div class="box">
            <div class="BodyBoder">
                <asp:Image ID="Image2" runat="server" ImageUrl="~/img/云端管理 (1).png" Height="120px" Width="120px" Style="margin-top: 20px; margin-left: 135px;" />
                <div class="Card" aria-autocomplete="list">
                    <p class="title " style="background-color: #3a4c9d">添加缴费</p>
                    <p></p>
                    用户姓名：<asp:TextBox ID="TextBox1" runat="server" BackColor="White" ForeColor="#70C4E9"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" EnableTheming="True" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
                    <br /><br />
                    楼栋号：&nbsp;<asp:TextBox ID="TextBox2" runat="server" BackColor="White" ForeColor="#70C4E9"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="TextBox2" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
                    
                    <br /><br />
                    收费项目：<asp:DropDownList ID="DropDownList1" runat="server" BackColor="White" ForeColor="#70C4E9" Width="145px">
                            <asp:ListItem>水费</asp:ListItem>
                            <asp:ListItem>电费</asp:ListItem>
                            <asp:ListItem>物业费</asp:ListItem>
                        </asp:DropDownList>
                    <br /><br />
                    收费金额：<asp:TextBox ID="TextBox3" runat="server" BackColor="White" ForeColor="#70C4E9"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextBox3" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
                    <br /><br />
                    <asp:Button ID="Button1" runat="server" Text="确定" OnClick="Button1_Click"   CssClass="btn btn-success" />&emsp;
                    <asp:Button ID="Button2" runat="server" Text="取消" OnClick="Button2_Click"  CssClass="btn btn-info" />
                </div>
            </div>
        </div>
    </div>
    

</asp:Content>
