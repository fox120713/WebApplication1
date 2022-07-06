using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using BLL;
using MODEL;

namespace WebApplication1.业主
{
    public partial class yzjf : System.Web.UI.Page
    {
        DopantBLL bll = new DopantBLL();
        DopantMODEL a = new DopantMODEL();
        ZHuInfoBLL bll2 = new ZHuInfoBLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                int id = Convert.ToInt32(Request["id"]);
                this.TextBox1.Text = bll.xs(id).Rows[0][1].ToString();
                this.TextBox2.Text = bll.xs(id).Rows[0][2].ToString();
                this.TextBox3.Text = bll.xs(id).Rows[0][3].ToString();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request["id"]);
            string name = bll.xs(id).Rows[0][0].ToString(); 
            double money = Convert.ToDouble(this.TextBox3.Text);
            bll.xg(id);
            bll2.x(money,name);
            Response.Redirect("DopantAll.aspx");
           
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("DopantAll.aspx");
        }
    }
}