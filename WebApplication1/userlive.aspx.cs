using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using BLL;

namespace WebApplication1
{
    public partial class userlive : System.Web.UI.Page
    {
        UserInfo_BLL u_bll = new UserInfo_BLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                this.GridView2.DataSource = u_bll.sel();
                this.GridView2.DataBind();
            }
        }

        protected void GridView2_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            this.GridView2.PageIndex = e.NewPageIndex;
            this.GridView2.DataSource = u_bll.sel();
            this.GridView2.DataBind();
        }

        protected void Button4_Click(object sender, EventArgs e)//查询
        {
            //try
            //{
            string name = this.TextBox7.Text;
            string mp = this.TextBox6.Text;
            this.GridView2.DataSource = u_bll.sel(name, mp);
            this.GridView2.DataBind();
            //}
            //catch (Exception)
            //{
            //    Response.Write("<script>alert('网页运行失败，详情请咨询维护人员')</script>");
            //}
        }

    }
}