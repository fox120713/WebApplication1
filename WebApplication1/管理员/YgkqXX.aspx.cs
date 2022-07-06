using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using System.Data;
namespace WebApplication1.管理员
{
    public partial class YgkqXX : System.Web.UI.Page
    {
        YgBLL kqBll = new YgBLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                int id = int.Parse(Request.QueryString["Ygid"]);
                this.GridView1.DataSource = kqBll.YgKqALL(id);
                this.GridView1.DataBind();
                DataTable dt = kqBll.kqYear();
                //DataRow rows = dt.NewRow();
                //rows[0] = "全部";
                //dt.Rows.InsertAt(rows, 0);
                this.DropDownListYear.DataSource = dt;
                this.DropDownListYear.DataValueField = "years";
                this.DropDownListYear.DataTextField = "years";
                this.DropDownListYear.DataBind();
                int year = DateTime.Now.Year;
                this.DropDownListYear.SelectedValue = year.ToString();
                int months = DateTime.Now.Month;
                this.DropDownList2Month.SelectedValue = months.ToString();
                
            }
        }

        protected void DropDownListYear_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int id = int.Parse(Request.QueryString["Ygid"]);
            //1.获取年份
            string year = this.DropDownListYear.SelectedItem.Text;
            //2.获取月份
            string month = this.DropDownList2Month.SelectedItem.Text;
            int months = int.Parse(month);
            if (months<10)
            {
                month = 0 + month;
                string sj = year + "-" + month;
                this.GridView1.DataSource = kqBll.kqcx(id, sj);
                this.GridView1.DataBind();
                
            }
            else
            {
                string sj = year + "-" + month;
                this.GridView1.DataSource = kqBll.kqcx(id, sj);
                this.GridView1.DataBind();
            }
            
            
        }
    }
}