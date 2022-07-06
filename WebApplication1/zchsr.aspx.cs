using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using BLL;

namespace WebApplication1
{
    public partial class zchsr : System.Web.UI.Page
    {
        WuyeZHMXBLL bll = new WuyeZHMXBLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                drop();
                bind();
            }
        }

        public void bind()
        {
            this.GridView1.DataSource = bll.qb();
            this.GridView1.DataBind();
            this.Label2.Text = "￥" + bll.zje().Rows[0][0].ToString();
        }

        public void drop()
        {
            DataTable tb = bll.bd();
            DataRow row = tb.NewRow();
            row[0] = "全部";
            tb.Rows.InsertAt(row, 0);
            this.DropDownList2.DataSource = tb;
            this.DropDownList2.DataTextField = "yf";
            this.DropDownList2.DataValueField = "yf";
            this.DropDownList2.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string lx = this.DropDownList1.SelectedValue;
            string yf = this.DropDownList2.SelectedValue;
            if (lx == "收入" && yf != "全部")
            {
                string jq = this.DropDownList2.SelectedValue.Substring(0, 1);
                int num = Convert.ToInt32(jq);
                if (num != 0)
                {
                    this.GridView1.DataSource = bll.table(num);
                    this.GridView1.DataBind();
                    if (bll.srbq(num).Rows[0][0].ToString() == "")
                    {
                        this.Label2.Text = "￥" + 0;
                    }
                    else
                    {
                        this.Label2.Text = "￥" + bll.srbq(num).Rows[0][0].ToString();
                    }
                }
            }
            if (lx == "收入" && yf == "全部")
            {
                this.GridView1.DataSource = bll.table();
                this.GridView1.DataBind();
                if (bll.srq().Rows[0][0].ToString() == "")
                {
                    this.Label2.Text = "￥" + 0;
                }
                else
                {
                    this.Label2.Text = "￥" + bll.srq().Rows[0][0].ToString();
                }
            }
            if (lx == "全部" && yf != "全部")
            {
                string jq = this.DropDownList2.SelectedValue.Substring(0, 1);
                int num = Convert.ToInt32(jq);
                this.GridView1.DataSource = bll.ayf1(num);
                this.GridView1.DataBind();
                if (bll.ayf(num).Rows[0][0].ToString() == "")
                {
                    this.Label2.Text = "￥" + 0;
                }
                else
                {
                    this.Label2.Text = "￥" + bll.ayf(num).Rows[0][0].ToString();
                }
            }
            if (lx == "支出" && yf != "全部")
            {
                string jq = this.DropDownList2.SelectedValue.Substring(0, 1);
                int num = Convert.ToInt32(jq);
                if (num != 0)
                {
                    this.GridView1.DataSource = bll.zcsrcx(num);
                    this.GridView1.DataBind();
                    if (bll.zcbq(num).Rows[0][0].ToString() == "")
                    {
                        this.Label2.Text = "￥" + 0;
                    }
                    else
                    {
                        this.Label2.Text = "￥" + bll.zcbq(num).Rows[0][0].ToString();
                    }
                }
            }
            if (lx == "支出" && yf == "全部")
            {
                this.GridView1.DataSource = bll.zcsrcx();
                this.GridView1.DataBind();
                if (bll.zcq().Rows[0][0].ToString() == "")
                {
                    this.Label2.Text = "￥" + 0;
                }
                else
                {
                    this.Label2.Text = "￥" + bll.zcq().Rows[0][0].ToString();
                }
            }
            if (lx == "全部" && yf != "全部")
            {
                string jq = this.DropDownList2.SelectedValue.Substring(0, 1);
                int num = Convert.ToInt32(jq);
                this.GridView1.DataSource = bll.ayf1(num);
                this.GridView1.DataBind();
                if (bll.ayf(num).Rows[0][0].ToString() == "")
                {
                    this.Label2.Text = "￥" + 0;
                }
                else
                {
                    this.Label2.Text = "￥" + bll.ayf(num).Rows[0][0].ToString();
                }
            }
            if (lx == "全部" && yf == "全部")
            {
                bind();
            }
            if (lx == "全部" && yf != "全部")
            {
                string jq = this.DropDownList2.SelectedValue.Substring(0, 1);
                int num = Convert.ToInt32(jq);
                if (num != 0)
                {
                    this.GridView1.DataSource = bll.qb();
                    this.GridView1.DataBind();
                    this.Label2.Text = "￥" + bll.yje(num).Rows[0][0].ToString();
                }
            }

        }

        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            this.GridView1.PageIndex = e.NewPageIndex;
            if (this.DropDownList1.SelectedValue == "支出")
            {
                this.GridView1.DataSource = bll.zcsrcx();
                this.GridView1.DataBind();
            }
            else if (this.DropDownList1.SelectedValue == "收入")
            {
                this.GridView1.DataSource = bll.table();
                this.GridView1.DataBind();
            }
            else
            {
                bind();
            }
        }





    }
}