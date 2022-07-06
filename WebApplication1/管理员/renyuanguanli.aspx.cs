using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using BLL;
using MODEL;
namespace WebApplication1.管理员
{
    public partial class renyuanguanli : System.Web.UI.Page
    {
        infoBLL bll = new infoBLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            //表格数据
            if (!IsPostBack)
            {
                this.bind();

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
            ds.Tables.Add(bll.infoALL());
            ps.DataSource = ds.Tables["Table1"].DefaultView;
            //是否可以分页
            ps.AllowPaging = true;
            //显示的数量
            ps.PageSize = 12;
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
        //添加页面跳转
        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("yuangongtianjia.aspx");
        }


        //查询按钮点击事件
        protected void Button1_Click(object sender, EventArgs e)
        {
            string name = this.TextBox1.Text;
            this.GridView1.DataSource = bll.infosel(name);
            this.GridView1.DataBind();
        }

        protected void LinkButton1_Command(object sender, CommandEventArgs e)
        {
            int id = int.Parse(e.CommandArgument.ToString());
            if ((bll.ztqr(id).Rows[0][0]).ToString() == "工作中")
            {
                Response.Write("<script>alert('该员工已有值班安排！')</script>");

            }
            else
            {
                Response.Redirect("zhibantianjia.aspx?id=" + id);
            }


        }








    }
}