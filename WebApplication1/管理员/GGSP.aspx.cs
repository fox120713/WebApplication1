using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;

namespace WebApplication1.管理员
{
    public partial class GGSP : System.Web.UI.Page
    {
        Ann_BLL bll = new Ann_BLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                this.GridView1.DataSource = bll.seldsh();
                this.GridView1.DataBind();
                this.DropDownList1.SelectedIndex = 1;
            }
            
        }
        protected void LinkButton1_Command(object sender, CommandEventArgs e)
        {
            string zt = e.CommandName;
            if (zt=="待审核")
            {
                int id = Convert.ToInt32(e.CommandArgument);
                Response.Redirect("GGSPXX.aspx?id=" + id);
           
            }
            else if (zt=="未通过"||zt=="已通过")
            {
                Response.Write("<script>alert('您已审核')</script>");
            }
            
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string zt = this.DropDownList1.SelectedItem.Text;
            this.GridView1.DataSource = bll.seld(zt);
            this.GridView1.DataBind();
        }

        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            this.GridView1.PageIndex = e.NewPageIndex;
            string zt = this.DropDownList1.SelectedItem.Text;
            this.GridView1.DataSource = bll.seld(zt);
            this.GridView1.DataBind();
        }
    }
}