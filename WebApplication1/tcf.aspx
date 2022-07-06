<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="tcf.aspx.cs" Inherits="WebApplication1.tcf" EnableEventValidation="false" %>
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
            车牌号:<asp:TextBox ID="TextBox1" runat="server" Width="80px"></asp:TextBox>缴费状态：<asp:DropDownList ID="DropDownList1" runat="server">
            </asp:DropDownList>
            <asp:Button ID="Button3" runat="server" Text="查询" CssClass="btn btn-success" OnClick="Button3_Click" />
            <asp:Button ID="Button4" runat="server" Text="添加"  class="btn btn-success"  OnClientClick="ff()" OnClick="Button2_Click" />
            <asp:Button ID="Button1" runat="server" Text="导出为excle"  OnClick="Button1_Click" class="btn btn-success"/>
        </div>
 </div>
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CssClass="table table-striped table-bordered table-hover table-condensed" AllowPaging="True" OnPageIndexChanging="GridView1_PageIndexChanging">
        <Columns>
            <asp:BoundField DataField="ParkID" HeaderText="账单编号" />
            <asp:BoundField DataField="L_CarID" HeaderText="车位编号" />
            <asp:BoundField DataField="ParkNum" HeaderText="车牌号" /> 
            <asp:BoundField DataField="IntoTime" HeaderText="进入时间" />
            <asp:BoundField DataField="OutTime" HeaderText="外出时间" />
            <asp:BoundField DataField="ParkMoney" HeaderText="费用" DataFormatString="{0:c}" />
            <asp:BoundField DataField="Parkbool" HeaderText="缴费状态" />
            <asp:TemplateField HeaderText="缴费">
                <ItemTemplate>
                    <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="False" CommandArgument='<%# Eval("ParkID") %>' CommandName='<%# Eval("Parkbool","{0}")=="已缴费"?"已缴费":"未缴费" %>' Text='<%# Eval("Parkbool","{0}")=="已缴费"?"已缴费":"未缴费" %>' OnClientClick="return confirm('是否缴费')" OnCommand="LinkButton1_Command" ></asp:LinkButton>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>

      <asp:HiddenField ID="HiddenField1" runat="server" />
    <asp:HiddenField ID="HiddenField2" runat="server" />
    <script type="text/javascript">
        function ff() {
            var ii = prompt('请输入车位编号',"");
            var ee = prompt('请输入车牌号',"");
            var b = document.getElementById("ContentPlaceHolder1_HiddenField1").value = ii;
             var a = document.getElementById("ContentPlaceHolder1_HiddenField2").value = ee;
            // var reg = /^[京津沪渝冀豫云辽黑湘皖鲁新苏浙赣鄂桂甘晋蒙陕吉闽贵粤青藏川宁琼使领][A-Za-z]{1}[0-9]{4}/;
            //if (!reg.test(a)) {
            //    alert("输入格式错误！");
            //}
        }
    </script>
</asp:Content>
