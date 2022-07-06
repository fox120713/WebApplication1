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
    public partial class bokuan : System.Web.UI.Page
    {
        AppBLL bll = new AppBLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                drop();
                drop1();
                bind();
            }
        }

        public void bind()
        {
            this.GridView1.DataSource = bll.table();
            this.GridView1.DataBind();
        }

        public void drop()
        {
            DataTable tb = bll.bd();
            DataRow row = tb.NewRow();
            this.DropDownList1.DataSource = tb;
            this.DropDownList1.DataTextField="sj";
            this.DropDownList1.DataValueField="sj";
            this.DropDownList1.DataBind();
        }

        public void drop1()
        {
            int n =Convert.ToInt32( this.DropDownList1.SelectedValue);
            DataTable tb = bll.bd(n);
            this.DropDownList2.DataSource = tb;
            this.DropDownList2.DataTextField = "yf";
            this.DropDownList2.DataValueField = "yf";
            this.DropDownList2.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
           string blr =this.TextBox1.Text;
           string n = this.DropDownList1.SelectedValue;
           string y = this.DropDownList2.SelectedValue;
            this.GridView1.DataSource = bll.mxcx(blr,n,y);
            this.GridView1.DataBind();
        }

        protected void GridView1_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {
            GridView1.PageIndex = e.NewSelectedIndex;
            bind();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            toExecl("application/ms-excel", "MyExcelFile.xlsx");
        }

        // 将GridView数据导出到EXECL

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