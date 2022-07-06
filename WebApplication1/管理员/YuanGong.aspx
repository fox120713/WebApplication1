<%@ Page Title="" Language="C#" MasterPageFile="~/管理员/site.Master" AutoEventWireup="true" CodeBehind="YuanGong.aspx.cs" Inherits="WebApplication1.管理员.YuanGong" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../bp/bootstrap.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="panel panel-default">
        <div class="panel-heading">
            <h3 class="panel-title">查询条件
            </h3>
        </div>
        <div class="panel-body">
            名字：<asp:TextBox ID="txtName" runat="server"></asp:TextBox>电话：<asp:TextBox ID="txtPhone" runat="server"></asp:TextBox>
            部门:<asp:DropDownList ID="BumenDropList" runat="server" AutoPostBack="true"></asp:DropDownList>
            <asp:Button ID="Button1" runat="server" Text="查询" class="btn btn-success" OnClick="Button1_Click" />
            <a href="YGTJ.aspx">添加</a>
        </div>
        <asp:GridView ID="YGGv" runat="server" AllowPaging="True" AutoGenerateColumns="False" Width="1038px" OnPageIndexChanging="YGGv_PageIndexChanging" class="table table-striped table-bordered table-hover table-condensed  " DataKeyNames="YgId" OnRowDeleting="YGGv_RowDeleting" OnSelectedIndexChanged="YGGv_SelectedIndexChanged" OnRowEditing="YGGv_RowEditing" OnRowUpdating="YGGv_RowUpdating" OnRowCancelingEdit="YGGv_RowCancelingEdit">
            <Columns>
                <asp:BoundField DataField="YgId" HeaderText="员工编号" ReadOnly="True" />
                <asp:BoundField DataField="YgPwd" HeaderText="员工密码" />
                <asp:BoundField DataField="YgName" HeaderText="员工姓名" />
                <asp:BoundField DataField="YgSex" HeaderText="员工性别" />
                <asp:BoundField DataField="YgAge" HeaderText="员工年龄" />
                <asp:BoundField DataField="YgCell" HeaderText="身份证号" />
                <asp:BoundField DataField="YgPhone" HeaderText="电话号码" />
                <asp:BoundField DataField="Ygdate" HeaderText="入职日期" DataFormatString="{0:d}" />
                <asp:TemplateField HeaderText="所属部门" Visible="true">
                    <EditItemTemplate>
                        <%--<asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("YgType") %>'></asp:TextBox>--%>                         <asp:DropDownList ID="DropDownList6" runat="server" DataSource="<%# Posbind() %>" DataTextField="PosName" DataValueField="PosID"  SelectedValue='<%# Bind("PosID") %>' AutoPostBack="true"></asp:DropDownList>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label1" runat="server" Text='<%# Bind("PosName") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                
                <asp:TemplateField HeaderText="操作" ShowHeader="False">
                    <ItemTemplate>
                        <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="False" CommandName="Delete" Text="删除"  OnClientClick="return confirm('您确定要删除该员工吗')"></asp:LinkButton>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField ShowHeader="False" HeaderText="操作">
                    <ItemTemplate>
                        <asp:LinkButton ID="LinkButton2" runat="server" CausesValidation="False" CommandName='<%# Eval("YgId") %>' Text="选择" OnCommand="LinkButton2_Command"></asp:LinkButton>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
        </div>
    <script>
    </script>
</asp:Content>
