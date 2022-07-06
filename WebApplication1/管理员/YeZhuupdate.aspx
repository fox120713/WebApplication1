﻿<%@ Page Title="" Language="C#" MasterPageFile="~/管理员/site.Master" AutoEventWireup="true" CodeBehind="YeZhuupdate.aspx.cs" Inherits="WebApplication1.管理员.YeZhuupdate" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
 <link href="../css/bootstrap.css" rel="stylesheet" />
    <style>
      .col-md-9 table {
            width: 100%;
        }
       .col-md-9 table tr {
        height:60px;
        }
        .col-md-3 img {
        width:150px;
        height:200px;
        margin-top:10px;
        }
        .an {
        margin-left:350px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="header" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <div class="panel panel-default">
        <div class="panel-heading">
            <h3 class="panel-title">信息修改
            </h3>
        </div>
        <div class="panel-body">
            <div class="container">
                <div class="row">
                    <div class="col-md-3">
                        <asp:Image ID="Image1" runat="server" ImageUrl="~/业主图片/1.jpg" />
                    </div>
                    <div class="col-md-9">
                        <table>
                            <tr>
                                <td>业主编号：</td>
                                <td>
                                    <asp:Label ID="LabelBH" runat="server" Text="Label"></asp:Label>
                                </td>
                                <td>业主姓名：</td>
                                <td>
                                    <asp:TextBox ID="TextBoxName" runat="server"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td>性别：</td>
                                <td>
                                    <asp:Label ID="LabelSEx" runat="server" Text="Label"></asp:Label></td>
                                <td>密码：</td>
                                <td>
                                    <asp:TextBox ID="TextBoxPwd" runat="server"></asp:TextBox></td>
                            </tr>
                            <tr>
                                <td>身份证号：</td>
                                <td>
                                    <asp:Label ID="LabelCell" runat="server" Text="Label"></asp:Label></td>
                                <td>联系电话：</td>
                                <td>
                                    <asp:TextBox ID="TextBoxPhone" runat="server"></asp:TextBox></td>
                            </tr>
                            <tr>
                                
                                <td>楼栋号</td>
                                <td>
                                    <asp:Label ID="LabelLd" runat="server" Text="Label"></asp:Label></td>
                            </tr>

                        </table>
                    </div>

                </div>
            </div>
            <div class="an"><asp:Button ID="Button2" runat="server" Text="修改" class="btn btn-success"  OnClick="Button2_Click1" />
           <asp:Button ID="Button1" runat="server" Text="返回" class="btn btn-info"  OnClick="Button1_Click"/></div>
            <br />
        </div>
    </div>
</asp:Content>
