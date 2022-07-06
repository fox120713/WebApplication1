using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using BLL;
using System.Data;
namespace WebApplication1
{
    public partial class gonggaoxinxi : System.Web.UI.Page
    {
        Ann_BLL a_bll = new Ann_BLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                this.GridView7.DataSource = a_bll.sel();
                this.GridView7.DataBind();
                DataTable tb = a_bll.selzt();
                DataRow row = tb.NewRow();
                row[0] = "全部";
                tb.Rows.InsertAt(row, 0);
                this.DropDownList3.DataSource = tb;
                this.DropDownList3.DataTextField = "AnnaIstate";
                this.DropDownList3.DataValueField = "AnnaIstate";
                this.DropDownList3.DataBind();
            }
        }
        protected void GridView7_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            this.GridView7.PageIndex = e.NewPageIndex;
            this.GridView7.DataSource = a_bll.sel();
            this.GridView7.DataBind();
        }

        protected void Button9_Click(object sender, EventArgs e)//查询
        {
            try
            {
                string title = this.TextBox14.Text;
                string zt = this.DropDownList3.SelectedValue.ToString();
                this.GridView7.DataSource = a_bll.sel(title, zt);
                this.GridView7.DataBind();
            }
            catch (Exception)
            {
                Response.Write("<script>alert('网页运行失败，详情请咨询维护人员')</script>");
            }


        }

    }
}