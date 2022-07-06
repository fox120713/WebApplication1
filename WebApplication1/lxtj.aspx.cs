using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using MODEL;

namespace WebApplication1
{
    public partial class lxtj : System.Web.UI.Page
    {
        PayTypeBLL bll = new PayTypeBLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                int id = Convert.ToInt32(bll.hq().Rows[0][0])+1;
                this.TextBox1.Text=id.ToString();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            PayTypeMODEL a = new PayTypeMODEL();
            a.Dj =Convert.ToDouble(this.TextBox3.Text);
            a.PayName = this.TextBox2.Text;
            bll.tj(a);
            Response.Write("<script>alert('添加成功！')</script>");
            Response.Redirect("jflx.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            this.TextBox2.Text="";
            this.TextBox2.Text="";
            Response.Redirect("jflx.aspx");
        }
    }
}