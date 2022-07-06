using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using BLL;
namespace WebApplication1
{
    public partial class repairsel : System.Web.UI.Page
    {
        Repn_BLL r_bll = new Repn_BLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                this.GridView4.DataSource = r_bll.repnShow();
                this.GridView4.DataBind();
            }
        }
        protected void GridView4_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            this.GridView4.PageIndex = e.NewPageIndex;
            this.GridView4.DataSource = r_bll.repnShow();
            this.GridView4.DataBind();
        }

        protected void Button6_Click(object sender, EventArgs e)//查询
        {
            try
            {
                string number = this.TextBox10.Text;
                string name = this.TextBox9.Text;
                this.GridView4.DataSource = r_bll.sel(number, name);
                this.GridView4.DataBind();
            }
            catch (Exception)
            {
                Response.Write("<script>alert('网页运行失败，详情请咨询维护人员')</script>");
            }

        }
    }
}