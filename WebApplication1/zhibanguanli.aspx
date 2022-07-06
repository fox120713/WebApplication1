<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="zhibanguanli.aspx.cs" Inherits="WebApplication1.zhibanguanli"  EnableEventValidation="false" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        .you_align {
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
            员工姓名：<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            工作日期：<asp:TextBox ID="TextBox1" runat="server" TextMode="Date"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" Text="查询" OnClick="Button1_Click"  class="btn btn-success"/>
            <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click" ForeColor="Blue">添加</asp:LinkButton>
            <asp:Button ID="Button2" runat="server" Text="导出为excle"  OnClick="Button2_Click" class="btn btn-success"/>
        </div>
        </div>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BorderColor="White" Width="100%" DataKeyNames="YgId"  OnRowDeleting="GridView1_RowDeleting1" OnRowUpdating="GridView1_RowUpdating"  Class="table table-striped table-bordered table-hover table-condensed" OnRowCancelingEdit="GridView1_RowCancelingEdit" OnRowEditing="GridView1_RowEditing" >
            <Columns>
                <asp:BoundField DataField="YgId" HeaderText="员工编号" ReadOnly="True" />
                <asp:BoundField DataField="YgName" HeaderText="员工姓名" ReadOnly="True" />
                <asp:BoundField DataField="PosName" HeaderText="所属部门" ReadOnly="True" />
                <asp:TemplateField HeaderText="值班日期">
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("zbdate") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label1" runat="server" Text='<%#Convert.ToDateTime(Eval("zbdate")).ToString("yyyy年MM月dd日")%>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:BoundField DataField="gznr" HeaderText="工作内容" />
                <asp:BoundField DataField="jttime" HeaderText="具体时间" />

                <asp:CommandField ControlStyle-ForeColor="blue" ShowEditButton="True">

<ControlStyle ForeColor="Blue"></ControlStyle>

                </asp:CommandField>

                <asp:TemplateField ShowHeader="False" ControlStyle-ForeColor="black">
                    <ItemTemplate>
                        <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="False" CommandName="Delete" Text="删除" OnClientClick='return confirm("确定删除吗？")'></asp:LinkButton>
                    </ItemTemplate>
                    
<ControlStyle ForeColor="blue"></ControlStyle>
                </asp:TemplateField>

            </Columns>
        </asp:GridView>
        <asp:ScriptManager runat="server"></asp:ScriptManager>
        <asp:Timer ID="Timer1" runat="server" Enabled="true" >
        </asp:Timer>
        <p class="you_align">

            <asp:Label ID="labCP" runat="server" Text="当前第"></asp:Label>
            <asp:Label ID="labPage" runat="server" Text="1"></asp:Label>
            &nbsp;页
                  <asp:Label ID="labTP" runat="server" Text="共"></asp:Label>
            <asp:Label ID="labBackPage" runat="server"></asp:Label>
            页
                  <asp:LinkButton ID="lnkbtnOne" runat="server" Font-Underline="False" ForeColor="Red" OnClick="lnkbtnOne_Click">第一页</asp:LinkButton>
            <asp:LinkButton ID="lnkbtnUp" runat="server" Font-Underline="False" ForeColor="Red" OnClick="lnkbtnUp_Click">上一页</asp:LinkButton>
            <asp:LinkButton ID="lnkbtnNext" runat="server" Font-Underline="False" ForeColor="Red" OnClick="lnkbtnNext_Click">下一页</asp:LinkButton>&nbsp;
                  <asp:LinkButton ID="lnkbtnBack" runat="server" Font-Underline="False" ForeColor="Red" OnClick="lnkbtnBack_Click">尾页</asp:LinkButton>&nbsp;&nbsp;
        </p>
    </div>
</asp:Content>
