<%@ Page Title="" Language="C#" MasterPageFile="~/业主/SiteYezhu.Master" AutoEventWireup="true" CodeBehind="UsGenRenXinXi.aspx.cs" Inherits="WebApplication1.业主.UsGenRenXinXi" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="bp/bootstrap.css" rel="stylesheet" />
    <style>
       .row table tr {
        height:100px;
        }
       .col-md-6 img{
        height:120px;
        width:120px;
       
        margin-top:10px;
        margin:0px auto;
        }
        .panel {
        height:100%;
        }
        .btn {
        width:100px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="header" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="panel panel-default">
       
        
        <div class="panel-body">
            <div class="container">
                <h3>个人资料</h3>
                <br />
                <br />

                <div class="row">
                    
                    <div class="col-md-6">
                        <asp:Image ID="Image1" runat="server" ImageUrl="~/img/R-C.jfif"/>
                        <asp:Button ID="Button1" runat="server" Text="上传头像" class="btn" />
                        <asp:FileUpload ID="FileUpload1" runat="server" BackColor="White" />
                    </div>
                    
                </div>
                <br />
                <br />
                <br />
                <div class="row">                   
                        <table style="width: 100%;">
                            <tr>
                                <td>业主ID:<asp:Label ID="laid" runat="server" Text="Label"></asp:Label>
                                    
                                </td>
                                <td>业主名称：<asp:Label ID="laname" runat="server" Text="Label"></asp:Label></td>

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
            </div>
            
        </div>
    </div>
</asp:Content>
