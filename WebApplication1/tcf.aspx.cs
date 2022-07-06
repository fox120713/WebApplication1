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
using System.Text.RegularExpressions;

namespace WebApplication1
{
    public partial class tcf : System.Web.UI.Page
    {
        ParkBLL bll = new ParkBLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Drop1();
                bind();
            }
        }

        public void bind()
        {
            this.GridView1.DataSource = bll.tcfcx();
            this.GridView1.DataBind();
        }

        public void Drop1()
        {
            DataTable tb = bll.tcfzt();
            DataRow row = tb.NewRow();
            row[0] = "全部";
            tb.Rows.InsertAt(row, 0);
            this.DropDownList1.DataSource = tb;
            this.DropDownList1.DataTextField = "Parkbool";
            this.DropDownList1.DataValueField = "Parkbool";
            this.DropDownList1.DataBind();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Write("<script>alert('hhhhh')</script>");
            string cw = this.HiddenField1.Value;
            string cph = this.HiddenField2.Value;
            DateTime a = DateTime.Now;
            string c=@"/^[京津沪渝冀豫云辽黑湘皖鲁新苏浙赣鄂桂甘晋蒙陕吉闽贵粤青藏川宁琼使领][A-Za-z]{1}[0-9]{4}/";
            
            if (cw != "")
            {
                if (Regex.IsMatch(cph,c))
                {
                    int cwh = Convert.ToInt32(cw);
                    bll.tj(cwh, cph, a);
                    Response.Write("<script>alert('添加成功')</script>");
                }
                else
                {
                    Response.Write("<script>alert('添加失败！')</script>");
                }
            }
            else if (cw == "")
            {
                Response.Write("<script>alert('添加失败！')</script>");
            }
            bind();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            ParkMODEL a = new ParkMODEL();
            a.ParkNum = this.TextBox1.Text;
            a.Parkbool = this.DropDownList1.SelectedValue;
            this.GridView1.DataSource = bll.cx(a);
            this.GridView1.DataBind();
        }

        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
            bind();
        }

        protected void LinkButton1_Command(object sender, CommandEventArgs e)
        {
            string zt = e.CommandName;
            if (zt != "已缴费")
            {
                int id = Convert.ToInt32(e.CommandArgument);
                
                DateTime a = DateTime.Now;
                int y = Convert.ToInt32(a.Year);
                int M = Convert.ToInt32(a.Month);
                int d = Convert.ToInt32(a.Day);
                int h = Convert.ToInt32(a.Hour);
                DateTime inside = Convert.ToDateTime(bll.tcfcx(id).Rows[0][3].ToString());
                int y1 = Convert.ToInt32(inside.Year);
                int M1 = Convert.ToInt32(inside.Month);
                int d1 = Convert.ToInt32(inside.Day);
                int h1 = Convert.ToInt32(inside.Hour);
                int m1 = Convert.ToInt32(inside.Minute);
                int b = (y - y1) * 365 * 24 + (M - M1) * 30 * 24 + (d-d1) * 24 + (h - h1);
                if (m1 > 1)
                {
                    int z = (b + 1) * 5;
                    bll.xg(a, z, id);
                }
                bind();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
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
