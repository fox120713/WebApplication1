<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="report.aspx.cs" Inherits="WebApplication1.report" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../bp/bootstrap.css" rel="stylesheet" />
    <style>
         .panel {
            margin-top:30px;
            width:80%;
            margin:0px auto;
            height:500px;
        }
         table {
            margin:0px auto;
         }
        tr {
            line-height:50px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="header" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="panel panel-info">
        <div class="panel-heading">
            <h3 class="panel-title">基本信息</h3>
        </div>
        <div class="panel-body ">
            <div class="input-group">
                <table class="hh">
                    <tr>
                        <td>工作日期：<asp:Label ID="Label2" runat="server" Text=""></asp:Label>                           
                        </td>
                    </tr>
                    <tr>
                        <td>工作时间：<asp:Label ID="Label3" runat="server" Text=""></asp:Label>                           
                        </td>
                    </tr>
                    <tr>
                        <td>工作内容： <asp:Label ID="Label4" runat="server" Text=""></asp:Label>                                               
                        </td>
                    </tr>
                    <tr>
                        <td>
                          成果图片：<asp:FileUpload ID="FileUpload1" runat="server" Width="200px" Height="30px" />
                            <asp:Image ID="Image1" runat="server" Height="100px" Width="200px"/>
                            <asp:Button ID="Button3" runat="server" Text="上传"  CssClass="btn btn-info" OnClick="Button3_Click"/>
                        </td>
                    </tr>                                 
                    <tr>
                        <td>报   告   人：<asp:Label ID="Label1" runat="server" Text=""></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>                          
                            <asp:Button ID="Button2" runat="server" Text="取消申请" CssClass="btn btn-info" OnClick="Button2_Click" />
                            <asp:Button ID="Button1" runat="server" Text="提交申请" CssClass="btn btn-info"  OnClick="Button1_Click" OnClientClick="return confirm('是否确定提交？')"/>
                        </td>
                    </tr>
                </table>
            </div>
        </div>
    </div>
</asp:Content>
