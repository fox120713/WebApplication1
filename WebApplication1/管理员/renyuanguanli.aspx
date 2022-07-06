 <%@ Page Title="" Language="C#" MasterPageFile="~/管理员/site.Master" AutoEventWireup="true" CodeBehind="renyuanguanli.aspx.cs" Inherits="WebApplication1.管理员.renyuanguanli"
     %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
     <style>
        .you_align {
            margin-top:60px;
       text-align:center;
        }
    </style>
    <link href="../bp/bootstrap.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="panel panel-default">
        <div class="panel-heading">
            <h3 class="panel-title">查询条件
            </h3>
        </div>
        <div class="panel-body">
            <div class="boxbody">
        <div class="headdiv">
    所属部门：<asp:Label ID="Label1" runat="server" Text="后勤部"></asp:Label>&nbsp
        员工姓名：<asp:TextBox ID="TextBox1" runat="server" ></asp:TextBox>
            
        <asp:Button ID="Button1" runat="server" Text="查询" CssClass="btn btn-success" OnClick="Button1_Click" />
        
        </div>
                </div>
        </div>
 </div>
        
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BorderColor="White" Width="100%" CssClass="table table-striped table-bordered table-hover table-condensed" DataKeyNames="YgId">
            <Columns>
                <asp:BoundField HeaderText="员工编号" ReadOnly="True" DataField="YgId" />
                <asp:BoundField HeaderText="员工姓名" DataField="YgName" />
                <asp:BoundField HeaderText="员工性别" DataField="YgSex" />
                <asp:BoundField HeaderText="员工年龄" DataField="YgAge" />
                <asp:BoundField HeaderText="身份证号" DataField="YgCell" />
                <asp:BoundField HeaderText="电话号码" DataField="YgPhone" />
                <asp:BoundField HeaderText="员工状态" DataField="YgState" />
                <asp:TemplateField ShowHeader="False">
                    <ItemTemplate>
                        <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="false" CommandArgument='<%#Eval("YgId") %>' CommandName="select" Text="安排值班" OnCommand="LinkButton1_Command" ></asp:LinkButton>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
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
</asp:Content>
