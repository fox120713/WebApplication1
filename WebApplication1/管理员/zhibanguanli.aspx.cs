using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using BLL;
using MODEL;
using System.Timers;
namespace WebApplication1.管理员
{
    public partial class zhibanguanli : System.Web.UI.Page
    {
        infoBLL bll = new infoBLL();
        

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //  GridView数据绑定   
                this.bind();
                //控件默认内容清空
                this.TextBox1.Text = "";
            }
        }
        protected void bind()
        {
            //取得当前页的页码
            int curpage = Convert.ToInt32(this.labPage.Text);
            //使用PagedDataSource类实现DataList控件的分页功能
            PagedDataSource ps = new PagedDataSource();
            //获取数据集
            DataSet ds = new DataSet();
            ds.Tables.Add(bll.ZBAll());
            ps.DataSource = ds.Tables["Table1"].DefaultView;
            //是否可以分页
            ps.AllowPaging = true;
            //显示的数量
            ps.PageSize = 8;
            //取得当前页的页码
            ps.CurrentPageIndex = curpage - 1;
            this.lnkbtnUp.Enabled = true;
            this.lnkbtnNext.Enabled = true;
            this.lnkbtnBack.Enabled = true;
            this.lnkbtnOne.Enabled = true;
            if (curpage == 1)
            {
                //不显示第一页按钮
                this.lnkbtnOne.Enabled = false;

                //不显示上一页按钮
                this.lnkbtnUp.Enabled = false;

            }
            if (curpage == ps.PageCount)
            {
                //不显示下一页
                this.lnkbtnNext.Enabled = false;

                //不显示最后一页
                this.lnkbtnBack.Enabled = false;

            }
            //显示分页数量
            this.labBackPage.Text = Convert.ToString(ps.PageCount);
            //绑定DataList控件
            this.GridView1.DataSource = ps;
            this.GridView1.DataBind();

        }
        //第一页
        protected void lnkbtnOne_Click(object sender, EventArgs e)
        {
            this.labPage.Text = "1";
            this.bind();
        }
        //上一页
        protected void lnkbtnUp_Click(object sender, EventArgs e)
        {
            this.labPage.Text = Convert.ToString(Convert.ToInt32(this.labPage.Text) - 1);
            this.bind();
        }
        //下一页
        protected void lnkbtnNext_Click(object sender, EventArgs e)
        {
            this.labPage.Text = Convert.ToString(Convert.ToInt32(this.labPage.Text) + 1);
            this.bind();
        }
        //最后一页
        protected void lnkbtnBack_Click(object sender, EventArgs e)
        {
            this.labPage.Text = this.labBackPage.Text;
            this.bind();
        }
        //查询按钮点击事件
        protected void Button1_Click(object sender, EventArgs e)
        {
            string name = this.TextBox2.Text;
            if (this.TextBox1.Text != "" && this.TextBox1.Text != null)
            {
                DateTime date = Convert.ToDateTime(this.TextBox1.Text + " 00:00:00");
                this.GridView1.DataSource = bll.ZBsel(name, date);
                this.GridView1.DataBind();
            }
            else
            {
                this.GridView1.DataSource = bll.ZBsel(name);
                this.GridView1.DataBind();
            }
        }


        //删除事件
        protected void GridView1_RowDeleting1(object sender, GridViewDeleteEventArgs e)
        {
            int id = Convert.ToInt32(this.GridView1.Rows[e.RowIndex].Cells[0].Text);
            bll.ZBdel(id);
            bll.ygupd(id);
            bind();
        }
        //修改事件
        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            try
            {
                ZbInfoMODEL u = new ZbInfoMODEL();
                u.YgId1 = Convert.ToInt32(this.GridView1.DataKeys[e.RowIndex].Value);
                u.YgName1 = this.GridView1.Rows[e.RowIndex].Cells[1].Text;
                u.Zbdate = Convert.ToDateTime(((TextBox)(this.GridView1.Rows[e.RowIndex].Cells[3].Controls[1])).Text);
                u.Gznr = ((TextBox)(this.GridView1.Rows[e.RowIndex].Cells[4].Controls[0])).Text;
                u.Jttime = ((TextBox)(this.GridView1.Rows[e.RowIndex].Cells[5].Controls[0])).Text;
                if (bll.DALupd(u) > 0)
                {
                    this.GridView1.EditIndex = -1;
                    bind();
                }
            }
            catch (Exception)
            {
                Response.Write("<script>alert('请输入正确日期')</script>");               
            }
            
        }
        //编辑行事件
        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            this.GridView1.EditIndex = e.NewEditIndex;
            bind();
        }
        //取消编辑事件
        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            this.GridView1.EditIndex = -1;
            bind();
        }
       

        protected void Button2_Click(object sender, EventArgs e)
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


