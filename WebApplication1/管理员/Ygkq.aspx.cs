using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Text;
using BLL;
using System.Data;
namespace WebApplication1.管理员
{
    public partial class Ygkq : System.Web.UI.Page
    {
        YgBLL bll = new YgBLL();
        PosBLL posbll = new PosBLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                bind();
                DataTable table = posbll.PosAll();
                DataRow row = table.NewRow();
                row[0] = 99;
                row[1] = "全部";
                table.Rows.InsertAt(row,0);
                this.DropDownList2.DataSource = table;
                this.DropDownList2.DataTextField = "PosName";
                this.DropDownList2.DataValueField = "POsID";
                this.DropDownList2.DataBind();
                
            }

        }

        public void bind()
        {
            this.GridView1.DataSource = bll.YGKqSum();
            this.GridView1.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            string name =this.TextBox1.Text;
            string zt = this.DropDownList1.SelectedItem.Text;
            int bm =int.Parse( this.DropDownList2.SelectedValue);
            this.GridView1.DataSource = bll.YGKqSum(name, zt, bm);
            this.GridView1.DataBind();
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {

        }

        protected void LinkButton1_Command(object sender, CommandEventArgs e)
        {
            int id =Convert.ToInt32( e.CommandArgument);
            Response.Redirect("YgkqXX.aspx?Ygid="+id);
        }

        protected void Button2_Click(object sender, EventArgs e)
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

        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            this.GridView1.PageIndex = e.NewPageIndex;
            bind();
        }


    }
}