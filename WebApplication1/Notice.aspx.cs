using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using BLL;
using MODEL;

namespace WebApplication1
{
    public partial class Notice : System.Web.UI.Page
    {
        Ann_BLL abll = new Ann_BLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                bind();
                DataTable dt = abll.AnnAll();
                //for (int i = 0; i < dt.Rows.Count; i++)
                //{
                //    string str = dt.Rows[i][4].ToString();
                //    str=str.Substring(5);
                    
                //}
                //    this.DataList1.DataSource = dt;
                //this.DataList1.DataBind();
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
            ds.Tables.Add(abll.AnnAll());
            ps.DataSource = ds.Tables["Table1"].DefaultView;
            //是否可以分页
            ps.AllowPaging = true;
            //显示的数量
            ps.PageSize = 6;
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
            this.DataList1.DataSource = ps;
            this.DataList1.DataKeyField = "Annid";
            this.DataList1.DataBind();

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
        protected void ZWGK_ItemCommand(object source, DataListCommandEventArgs e)
        {
            int id = Convert.ToInt32(DataList1.DataKeys[e.Item.ItemIndex].ToString());
            Response.Write("<script language=javascript>location='show_News.aspx?id=" + id + "'</script>");
        }

    }
}