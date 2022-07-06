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
    public partial class kqcx : System.Web.UI.Page
    {
        YgBLL bll = new YgBLL();
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
            string name = login.ygname;
            this.GridView1.DataSource = bll.cx(name);
            this.GridView1.DataBind();
        }

        public void drop()
        {
            DataTable tb = bll.bd();
            DataRow row = tb.NewRow();
            row[0] = "全部";
            tb.Rows.InsertAt(row, 0);
            this.DropDownList1.DataSource = tb;
            this.DropDownList1.DataTextField = "BeiZhu";
            this.DropDownList1.DataValueField = "BeiZhu";
            this.DropDownList1.DataBind();
            DataTable dt = bll.kqYear();
            //DataRow rows = dt.NewRow();
            //rows[0] = "全部";
            //dt.Rows.InsertAt(rows, 0);
            this.DropDownListYear.DataSource = dt;
            this.DropDownListYear.DataValueField = "years";
            this.DropDownListYear.DataTextField = "years";
            this.DropDownListYear.DataBind();
            int year = DateTime.Now.Year;
            this.DropDownListYear.SelectedValue = year.ToString();
            
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            string name = login.ygname;
            string zt = this.DropDownList1.SelectedValue;
            //1.获取年份
            string year = this.DropDownListYear.SelectedItem.Text;
            //2.获取月份
            string month = this.DropDownList2Month.SelectedItem.Text;
            int months = int.Parse(month);
                if (months < 10)
                {
                    month = 0 + month;
                    string sj = year + "-" + month;
                    this.GridView1.DataSource = bll.cx(name, zt, sj);
                    this.GridView1.DataBind();

                }
                else
                {
                    string sj = year + "-" + month;
                    this.GridView1.DataSource = bll.cx(name, zt, sj);
                    this.GridView1.DataBind();
                }
            

        }


    }
}