using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using BLL;

namespace WebApplication1
{
    public partial class nullhome : System.Web.UI.Page
    {
        Home_BLL h_bll = new Home_BLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)  //绑定表
            {
                this.GridView1.DataSource = h_bll.sel();
                this.GridView1.DataBind();
            }
        }
        protected void Button1_Click(object sender, EventArgs e)//查询
        {

            try
            {
                string hometype = this.TextBox1.Text;
                this.GridView1.DataSource = h_bll.sel(hometype);
                this.GridView1.DataBind();
            }
            catch (Exception)
            {
                Response.Write("<script>alert('网页运行失败，详情请咨询维护人员')</script>");
            }
        }

        protected void LinkButton1_Command1(object sender, CommandEventArgs e) //空房购买传值
        {
            string lx = e.CommandArgument.ToString();
            Response.Redirect("~/buyhome.aspx?lx=" + lx);
        }

    }
}