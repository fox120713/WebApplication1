<%@ Page Title="" Language="C#" MasterPageFile="~/管理员/site.Master" AutoEventWireup="true" CodeBehind="BuMen.aspx.cs" Inherits="WebApplication1.管理员.BuMen" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="bootstrap.css" rel="stylesheet" />
    <link href="StyleSheet8.css" rel="stylesheet" />
    <style>
        #ImageButtonTJ {
            width:50%;
            height:50%;
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
                名称:<asp:DropDownList ID="DropDownListPos" runat="server" AutoPostBack="true" OnSelectedIndexChanged="DropDownListPos_SelectedIndexChanged1"></asp:DropDownList>
            </div>
        </div>
    </div>
    <asp:GridView ID="GridViewBumen" runat="server" AutoGenerateColumns="False" class="table" OnSelectedIndexChanged="GridViewBumen_SelectedIndexChanged" CssClass="table table-striped table-bordered table-hover table-condensed" OnRowEditing="GridViewBumen_RowEditing" OnRowUpdating="GridViewBumen_RowUpdating" DataKeyNames="PosID" OnRowCancelingEdit="GridViewBumen_RowCancelingEdit">
        <Columns>
            <asp:BoundField DataField="PosID" HeaderText="部门编号" ReadOnly="True" />
            <asp:BoundField DataField="PosName" HeaderText="部门名称" />
        </Columns>
    </asp:GridView>
    <asp:HiddenField ID="HiddenField1" runat="server" />
    <script type="text/javascript">
        function ff() {
            //var ii = prompt('请输入部门名称');
            var ii = prompt('请输入部门名称', "");
            document.getElementById("ContentPlaceHolder1_HiddenField1").value = ii;
          
        }
    </script>
</asp:Content>
