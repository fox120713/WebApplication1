<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NoticeShow.aspx.cs" Inherits="WebApplication1.NoticeShow" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style>
         .head {
        height:80px;
        background-color:rgb(54,110,243);
        }
        .col-md-8 {
        background-color:white;
        box-shadow:0px 0px 1px gray;
        }
        .col-md-3 {
        background-color:white;
        box-shadow:0px 0px 1px gray;
        
        }

        img {
        width:500px;
        height:300px;
        }
         .head img {
        height:80px;
        width:200px;
        }
    </style>
    <link href="css/bootstrap.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <div class="head">
        <img src="img/log.png" />
    </div>
        <br />
        <br />
        <div class="container">
            <div class="row">
                <div class="col-md-8 ">
                    <h2> <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label></h2>
                    <p>
                        <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>  小区公告</p>
                    <hr />
                    <br />
                    <asp:Image ID="Image1" runat="server" />
                    <br />
                    <br />
                    <p>
                        <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label></p>
                   </div>
                <div class="col-md-3  col-md-offset-1">
                    <h2>最新内容</h2>
                    <br />
                    <hr />
                    <br />
                    <asp:DataList ID="DataList1" runat="server">
                        <ItemTemplate>
                            <a href="NoticeShow.aspx?id=<%# Eval("Annid") %>"><%# Eval("AnnConn")%></a>
                               
                            <p><%# Eval("ADate")%></p>
                            <br />
                        </ItemTemplate>
                    </asp:DataList>

                </div>

            </div>
        </div>
    </div>
    </form>
</body>
</html>
