using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Text;
using System.Data;
using BLL;
using MODEL;

namespace WebApplication1
{
    public partial class zwf : System.Web.UI.Page
    {
        DopantBLL bll = new DopantBLL();
        PayTypeBLL bll2 = new PayTypeBLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Drop1();
                Drop2();
                bind();
            }
        }
        //显示数据
        public void bind()
        {
            this.GridView1.DataSource = bll.table();
            this.GridView1.DataBind();
        }
        //绑定缴费类型
        public void Drop1()
        {
            DataTable tb = bll2.bd();
            DataRow row = tb.NewRow();
            row[0] = 0;
            row[1] = "全部";
            tb.Rows.InsertAt(row, 0);
            this.DropDownList1.DataSource = tb;
            this.DropDownList1.DataTextField = "PayName";
            this.DropDownList1.DataValueField = "PayID";
            this.DropDownList1.DataBind();
        }
        //绑定缴费状态
        public void Drop2()
        {
            DataTable tb = bll.bd2();
            DataRow row = tb.NewRow();
            row[0] = "全部";
            tb.Rows.InsertAt(row, 0);
            this.DropDownList2.DataSource = tb;
            this.DropDownList2.DataTextField = "DopantBool";
            this.DropDownList2.DataValueField = "DopantBool";
            this.DropDownList2.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string ld = this.TextBox1.Text;
            int lx = Convert.ToInt32(this.DropDownList1.SelectedValue);
            string jf = this.DropDownList2.SelectedValue;
            this.GridView1.DataSource = bll.jfcx(ld, lx, jf);
            this.GridView1.DataBind();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("sftj.aspx");
        }

        protected void LinkButton1_Command(object sender, CommandEventArgs e)
        {
            string zt = e.CommandName;
            if (zt != "已缴费")
            {
                int id = Convert.ToInt32(e.CommandArgument);
                string name = login.ygname;
                bll.xg(name, id);
                bind();
            }
        }

        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
            bind();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            toExecl("application/ms-excel", "MyExcelFile.xlsx");
        }

        private void toExecl(string FileType, string FileName)
        {
            //清楚分页
            GridView1.AllowPaging = false;
            bind();

            Response.Clear();
            Response.Buffer = true;
            //设定输出的字符集
            Response.Charset = "GB2312";
            //解决导出到Excel2007乱码问题
            Response.Write("<meta http-equiv=Content-Type content=text/html;charset=GB2312>");

            //假定导出的文件名为盘点结果表.xls
            Response.AppendHeader("Content-Disposition", "attachment;filename=" + HttpUtility.UrlEncode(FileName, Encoding.UTF8).ToString());
            //解决导出到Excel2007乱码问题
            Response.ContentEncoding = System.Text.Encoding.GetEncoding("GB2312");

            //设置导出文件的格式
            Response.ContentType = FileType;
            //关闭ViewState
            this.EnableViewState = false;
            StringWriter stringWriter = new StringWriter();
            HtmlTextWriter textWriter = new HtmlTextWriter(stringWriter);
            GridView1.RenderControl(textWriter);
            //把HTML写回浏览器
            Response.Write(stringWriter.ToString());
            Response.Flush();
            Response.End();
            GridView1.AllowPaging = true;//恢复分页
            //为GridView重新绑定数据源
            bind();
        }

        public override void VerifyRenderingInServerForm(Control control)
        {

            //这个方法不能删除掉

        }
    }
}