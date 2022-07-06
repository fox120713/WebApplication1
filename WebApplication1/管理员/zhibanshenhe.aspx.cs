using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using BLL;
namespace WebApplication1.管理员
{
    public partial class zhibanshenhe : System.Web.UI.Page
    {
        infoBLL bll = new infoBLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                bind();  
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
            DataTable dt = bll.shenhexinxi();
            ds.Tables.Add(dt);
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

        

        protected void LinkButton1_Command(object sender, CommandEventArgs e)
        {
                if (e.CommandName == "待审核")
                {
                    int id = int.Parse(e.CommandArgument.ToString());
                    Response.Redirect("reportwatch.aspx?zbid=" + id);
                }
                else
                {
                    Response.Write("<script>alert('您已审核此报告！ ')</script>");
                }
           
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (this.DropDownList1.Text!="全部")
            {
                string zt = this.DropDownList1.Text;
                this.GridView1.DataSource = bll.ztcx(zt);
                DataBind();
            }
            else
            {
                bind(); 
            }
        }







    }
}