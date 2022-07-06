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
    public partial class cftj : System.Web.UI.Page
    {
        ParkBLL bll = new ParkBLL();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            //ParkMODEL b = new ParkMODEL();
            //b.L_CarID = Convert.ToInt32(this.TextBox1.Text);
            //b.ParkNum = this.TextBox2.Text;
            //b.IntoTime = Convert.ToDateTime(this.TextBox3.Text);
            //if (bll.tj(b) > 0)
            //{
            //    Response.Write("<script>alert('添加成功')</script>");
            //    Response.Redirect("tcf.aspx");
            //}

        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            this.TextBox1.Text = "";
            this.TextBox2.Text = "";
            this.TextBox3.Text = "";
        }
    }
}