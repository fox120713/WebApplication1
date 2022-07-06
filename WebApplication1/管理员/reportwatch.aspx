<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="reportwatch.aspx.cs" Inherits="WebApplication1.管理员.reportwatch" %>
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
    <p>
        &nbsp;</p>
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
                          成果图片：<asp:Image ID="Image1" runat="server" Width="180px" Height="100px"/>
                        </td>
                    </tr>                                 
                    <tr>
                        <td>报   告   人：<asp:Label ID="Label1" runat="server" Text=""></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td><asp:HiddenField runat="server" ID="HiddenField1"></asp:HiddenField>
                            <asp:Button ID="Button1" runat="server" Text="不通过" CssClass="btn btn-info"  OnClick="Button1_Click" OnClientClick="ff()"/>
                            <asp:Button ID="Button2" runat="server" Text="通过" CssClass="btn btn-info" OnClick="Button2_Click" OnClientClick='return confirm("是否确定通过？")' />
                        </td>
                    </tr>
                </table>
            </div>
        </div>
    </div>
    <script type="text/javascript">
        function ff() {
            var a = prompt('请输入不通过原因');
            if (a) {
                undefined
                var b = document.getElementById("ContentPlaceHolder1_HiddenField1").value = a;
            } else if (a == "") {
                undefined
                alert("请输入不通过原因");
            } else {
                undefined
                window.location.href = "zhibanshenhe.aspx";
            }

        }
    </script>
</asp:Content>
