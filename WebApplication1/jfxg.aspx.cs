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
    public partial class jfxg : System.Web.UI.Page
    {
        PayTypeBLL bll = new PayTypeBLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                int id=Convert.ToInt32(Request["id"]);
                this.TextBox1.Text=bll.bd(id).Rows[0][0].ToString();
                this.TextBox2.Text = bll.bd(id).Rows[0][1].ToString();
                this.TextBox3.Text = bll.bd(id).Rows[0][2].ToString();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            double dj = Convert.ToDouble(this.TextBox3.Text);
            int id = Convert.ToInt32(this.TextBox1.Text);
            bll.xg(dj, id);
            Response.Redirect("jflx.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("jflx.aspx");
        }
    }
}