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
    public partial class cztj : System.Web.UI.Page
    {
        ZHuInfoBLL bll = new ZHuInfoBLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string id=Request["id"];
                this.TextBox1.Text = bll.table(id).Rows[0][0].ToString();
                this.TextBox2.Text = bll.table(id).Rows[0][1].ToString();
                this.TextBox3.Text = bll.table(id).Rows[0][2].ToString();
                this.TextBox4.Text = bll.table(id).Rows[0][3].ToString();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string id = Request["id"];
            double a =Convert.ToDouble(this.TextBox5.Text);
            bll.xg(a,id);
            Response.Redirect("cz.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("cz.aspx");
        }
    }
}