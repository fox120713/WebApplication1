<%@ Page Title="" Language="C#" MasterPageFile="~/业主/SiteYezhu.Master" AutoEventWireup="true" CodeBehind="DopantAll.aspx.cs" Inherits="WebApplication1.业主.DopantAll" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../bootstrap.css" rel="stylesheet" />
    <style>
        r {
            color:blue;
        }
        #LabelSum {
           
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <div class="panel panel-default">
            <div class="panel-heading">
                <h3 class="panel-title">查询条件
                </h3>
            </div>
            <div class="panel-body">
                类型名称：<asp:DropDownList ID="DropDownList1" runat="server" class="btn dropdown-toggle" CssClass="btn-group" >
                </asp:DropDownList>
                年份：<asp:DropDownList ID="DropDownListYear" runat="server" ></asp:DropDownList>
                月份：<asp:DropDownList ID="DropDownListMonth" runat="server" >
                    <asp:ListItem>1</asp:ListItem>
                    <asp:ListItem>2</asp:ListItem>
                    <asp:ListItem>3</asp:ListItem>
                    <asp:ListItem>4</asp:ListItem>
                    <asp:ListItem>5</asp:ListItem>
                    <asp:ListItem>6</asp:ListItem>
                    <asp:ListItem>7</asp:ListItem>
                    <asp:ListItem>8</asp:ListItem>
                    <asp:ListItem>9</asp:ListItem>
                    <asp:ListItem>10</asp:ListItem>
                    <asp:ListItem>11</asp:ListItem>
                    <asp:ListItem>12</asp:ListItem>
                </asp:DropDownList>
                <asp:Button ID="ButtonCX" runat="server" Text="查询" class="btn btn-success " OnClick="ButtonCX_Click" />
            </div>
        </div>
    </div>
    <asp:GridView ID="GridViewDopant" runat="server" AutoGenerateColumns="False" class="table table-striped table-bordered table-hover table-condensed" AllowPaging="True" OnPageIndexChanging="GridViewDopant_PageIndexChanging" PageSize="15"  >
        <Columns>
            <asp:BoundField DataField="mxid" HeaderText="账单编号" Visible="False" />
            <asp:BoundField DataField="UserCell" HeaderText="楼栋号" Visible="False" />
            <asp:BoundField DataField="months" HeaderText="月份" />
            <asp:BoundField DataField="PayName" HeaderText="缴费类型" />
            <asp:TemplateField HeaderText="上月用度">
                <EditItemTemplate>
                    <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("Syd") %>'></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label2" runat="server" Text='<%# Eval("Syd")%>' ></asp:Label>
                    <asp:Label ID="Label1" runat="server" Text='<%# Eval("PayName","{0}")=="燃气费"?"<r>m³</r>":Eval("PayName","{0}")=="水费"?"t":Eval("PayName","{0}")=="电费"?"<r>KWH</r>":" " %>' ></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="本月用度">
                <EditItemTemplate>
                    <asp:TextBox ID="TextBox2" runat="server" Text='<%# Bind("Byd") %>'></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label4" runat="server" Text='<%# Bind("Byd") %>'></asp:Label>
                    <asp:Label ID="Label1" runat="server" Text='<%# Eval("PayName","{0}")=="燃气费"?"<r>m³</r>":Eval("PayName","{0}")=="水费"?"t":Eval("PayName","{0}")=="电费"?"<r>KWH</r>":" " %>' ></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:BoundField DataField="YDdj" HeaderText="类型单价" DataFormatString="{0:c}" />
            <asp:BoundField DataField="dateMoney" HeaderText="本月产生费用" Visible="true" DataFormatString="{0:c}" />
        </Columns>
    </asp:GridView>
    <h4>合计:¥<asp:Label ID="LabelSum" runat="server" Text="Label" Font-Bold="True" Font-Size="12pt"></asp:Label></h4>
</asp:Content>
