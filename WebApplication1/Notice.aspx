<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="~/Notice.aspx.cs" Inherits="WebApplication1.Notice" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style>
        body {
        background-color:rgb(240,244,251);
        }
        .head {
        height:80px;
        background-color:rgb(54,110,243);
        }

        h1 {
        text-align:center;
        }
        p {
        text-align:center;
        color:gray;
        }
        .Control {
            width:600px;
            
            height:100px;
            
        display:flex;
        }
        .Control-left {
        width:10%;
          

        }
        .Control-center {
        width:60%;
        }
        .Control-right {
        width:30%;
           

        }
        .Control:hover {
            background-color:white;
        
        }
        .Control div p {
        line-height:40px;
        }
        .Control-date {
        color:blue;
        font-weight:bold;
        font-size:16px;
        }
        .Control div a {
        line-height:50px;
        text-align:center;
        }
        .btn1 {
            margin:0px auto;
        width:50%;
        height:50%;
         background-color:rgb(240,244,251);
            border-radius:30%;
           margin-top:25px;
        }
        .hover-blue {
        color:black;
        }
        .hover-blue:hover {
        color:blue;
        text-decoration:none;
        }
        .you_align {
            margin-top:60px;
       text-align:center;
        }
        .head img {
        height:80px;
        width:200px;
        }
    </style>
    <link href="css/bootstrap.css" rel="stylesheet" />
</head>
<body style="background-color:rgb(240,244,251);">
    <form id="form1" runat="server">
    <div>
    <div class="head">
        <img src="img/log.png" />

    </div>
        <h1>紫荆花语小区公告</h1>
        
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />

        <div class="container">
            <asp:DataList ID="DataList1" runat="server" RepeatColumns="2" >
            <ItemTemplate>
                <div class="Control">
                    <div class="Control-left">
                        <p> <span class="Control-date" ><%# Eval("ADate") %></span>
                            <br />
                            <small>2022</small>
                        </p>
                        

                       
                    </div>
                    <div class="Control-center">
                        <p><a class="hover-blue" href="NoticeShow.aspx?id=<%# Eval("Annid") %>"><%# Eval("AnnTitle") %></a>
                            <br />
                            <small><%# Eval("AnnConn") %>...</small></p>
                    </div>
                    <div class="Control-right">
                        <div class="btn1">
                       <p><a href="NoticeShow.aspx?id=<%# Eval("Annid") %>">查看详情</a></p> 
                            </div>
                    </div>

                </div>
            </ItemTemplate>
        </asp:DataList>

        </div>
        <p class="you_align">
        
                  <asp:Label ID="labCP" runat="server" Text="当前第"></asp:Label>
                     <asp:Label ID="labPage" runat="server" Text="1"></asp:Label> &nbsp;页
                  <asp:Label ID="labTP" runat="server" Text="共"></asp:Label>
                     <asp:Label ID="labBackPage" runat="server"></asp:Label> 页
                  <asp:LinkButton ID="lnkbtnOne" runat="server" Font-Underline="False" ForeColor="Red" OnClick="lnkbtnOne_Click">第一页</asp:LinkButton>
                  <asp:LinkButton ID="lnkbtnUp" runat="server" Font-Underline="False" ForeColor="Red"  OnClick="lnkbtnUp_Click">上一页</asp:LinkButton>
                  <asp:LinkButton ID="lnkbtnNext" runat="server" Font-Underline="False" ForeColor="Red" OnClick="lnkbtnNext_Click">下一页</asp:LinkButton>&nbsp;
                  <asp:LinkButton ID="lnkbtnBack" runat="server" Font-Underline="False" ForeColor="Red" OnClick="lnkbtnBack_Click">尾页</asp:LinkButton>&nbsp;&nbsp;
              
    </p>
        
    </div>
    </form>
</body>
</html>
