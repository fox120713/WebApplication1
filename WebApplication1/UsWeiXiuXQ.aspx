<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="UsWeiXiuXQ.aspx.cs" Inherits="WebApplication1.UsWeiXiuXQ" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
       <link href="bp/bootstrap.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="header" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="panel panel-default">
        <div class="panel-heading">
            <h3 class="panel-title">维修详情
            </h3>
        </div>
        <div class="panel-body">
             <table>
            <tr>
                <td>业主编号：</td>
                <td>
                    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label></td>
            </tr>
           <tr>
                <td>维修地点：</td>
                <td>
                    <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label></td>
            </tr>
            <tr>
                <td>维修原因：</td>
                <td>
                    <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label></td>
            </tr>
                
            <tr>
                <td>联系电话：</td>
                <td>
                    <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label></td>

            </tr>
            <tr>
                <td>维修人：</td>
                <td>
                    <asp:Label ID="Label5" runat="server" Text="Label"></asp:Label></td>
            </tr>
        </table>
            <asp:Button ID="Button1" runat="server" Text="确认维修" class="btn btn-info" OnClick="Button1_Click" />
            <asp:Button ID="Button2" runat="server" Text="维修完成" class="btn btn-success" OnClick="Button2_Click" />

        </div>
        <asp:Panel ID="Panel1" runat="server" Visible="false">
           <asp:FileUpload ID="FileUpload1" runat="server"  />
       
            <asp:Button ID="Button3" runat="server" class="btn btn-success" OnClick="Button3_Click" Text="上传" />
         <br />
         <asp:Image ID="Image1" runat="server" Height="232px" Width="388px" />
                 </asp:Panel>
        
            
    
    </div>
</asp:Content>
