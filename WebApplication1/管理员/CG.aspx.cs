using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using System.Data;
namespace WebApplication1.管理员
{
    public partial class CG : System.Web.UI.Page
    {
        PurpBLL bll = new PurpBLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                bind();
            }
          
            
        }
        public void bind()
        {
            DataTable tb = bll.tableDSH();
            for (int i = 0; i < tb.Rows.Count; i++)
            {
                tb.Rows[i][2] = "~/cgimg/" + tb.Rows[i][2];
            }
            this.GridView1.DataSource = tb;
            this.GridView1.DataBind();
            this.DropDownList1.SelectedIndex = 3;
        }

        protected void LinkButton1_Command(object sender, CommandEventArgs e)
        {
            int id =int.Parse( e.CommandArgument.ToString());
            string name = e.CommandName;
            if (name=="待审核")
            {
                bll.update(id);
                Response.Write("<script>alert('审核成功')</script>");
                bind();
            }
            else
            {
                Response.Write("<script>alert('您已审核')</script>");
            }
            


        }
        protected void LinkButton2_Command(object sender, CommandEventArgs e)
        {

            //int id = int.Parse(e.CommandArgument.ToString());
            string name = e.CommandName;
            if (name == "待审核")
            {
                int id = Convert.ToInt16(e.CommandArgument);
                Response.Redirect("CGSP.aspx?id=" + id);
            }
            else
            {
                Response.Write("<script>alert('您已审核')</script>");
            }
           

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string zt = this.DropDownList1.SelectedItem.Text;
            DataTable tb=bll.cx(zt);
            for (int i = 0; i < tb.Rows.Count; i++)
            {
                tb.Rows[i][2] = "~/cgimg/" + tb.Rows[i][2];
            }
            this.GridView1.DataSource = tb;
            this.GridView1.DataBind();
        }

        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            this.GridView1.PageIndex = e.NewPageIndex;
            bind();
        }
    }
}