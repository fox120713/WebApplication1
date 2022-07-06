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
    public partial class buyhome : System.Web.UI.Page
    {
        Home_BLL h_bll = new Home_BLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Bind();
            }
        }

        public void Bind()//绑定——指定类型的空房间
        {
            string lx = Request.QueryString["lx"].ToString();
            this.GridView1.DataSource = h_bll.sellx(lx);
            this.GridView1.DataBind();
        }

        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            this.GridView1.PageIndex = e.NewPageIndex;
            Bind();
        }

        protected void LinkButton1_Command(object sender, CommandEventArgs e)//传值购买房间——传门牌号
        {
            //buyhome_1.aspx
            string mp = e.CommandArgument.ToString();
            Response.Redirect("~/buyhome_1.aspx?mp=" + mp);  
        }

    }
}