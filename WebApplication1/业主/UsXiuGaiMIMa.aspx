<%@ Page Title="" Language="C#" MasterPageFile="~/业主/SiteYezhu.Master" AutoEventWireup="true" CodeBehind="UsXiuGaiMIMa.aspx.cs" Inherits="WebApplication1.业主.UsXiuGaiMIMa" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
      <link href="bp/bootstrap.css" rel="stylesheet" />
    <style>
        .panel {
            height: 100%;
        }
       
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="header" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="panel panel-default">


        <div class="panel-body">
            <div class="container">
                <h3>修改密码</h3>
                <br />
                <br />

                <div class="row">

                    <div class="col-md-3">
                        <div class="input-group input-group-lg">
                            <asp:TextBox ID="TextBox1" runat="server" class="form-control" placeholder="当前密码" ></asp:TextBox>
                        </div>
                        <br />

                        <div class="input-group input-group-lg">
                            <asp:TextBox ID="TextBox2" runat="server" class="form-control" placeholder="新密码"></asp:TextBox>
                        </div>
                        <br />

                        <div class="input-group input-group-lg">
                            <asp:TextBox ID="TextBox3" runat="server" class="form-control" placeholder="确认新密码"></asp:TextBox>
                        </div>
                        <br />

                        <asp:Button ID="Button1" runat="server" Text="保存" Class="btn btn-danger btn-lg" OnClick="Button1_Click" />
                    </div>

                </div>

            </div>

        </div>
    </div>
</asp:Content>
