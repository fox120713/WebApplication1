using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using System.Data;
using MODEL;

namespace WebApplication1
{
    public partial class User_renovation : System.Web.UI.Page
    {
        RepnnBLL ReBLL = new RepnnBLL();
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //this.GridView1.DataSource = ReBLL.RepnnShow();
                this.GridView1.DataSource = ReBLL.repnnshowwc();
                this.GridView1.DataBind();
            
            }
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            this.GridView1.DataSource = ReBLL.RepnnShow(this.TextBox1.Text);
            this.GridView1.DataBind();
        }

        protected void LinkButton1_Command(object sender, CommandEventArgs e)
        {

            if (e.CommandName == "待审核")
            {
                Session["RepnnID"] = e.CommandArgument;
                Response.Redirect("zxsh.aspx");
            }
            else {
                Response.Write("<script>alert('您已审核！！！')</script>");
            
            }
        }
    }
}