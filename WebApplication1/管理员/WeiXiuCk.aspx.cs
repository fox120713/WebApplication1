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
    public partial class WeiXiuCk : System.Web.UI.Page
    {
        Repn_BLL repnBll = new Repn_BLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DataTable dt = repnBll.repnShow();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dt.Rows[i][6] = "~/wximg/" + dt.Rows[i][6];
                    dt.Rows[i][13] = "~/wximg/" + dt.Rows[i][13];
                }
                this.GridView1.DataSource = dt;
                this.GridView1.DataBind();
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //获取业主姓名
            string yzname = this.TextBox1.Text;
            //获取审核状态
            string shzt = this.DropDownList1.SelectedValue;
            //获取维修状态
            string wxzt = this.DropDownList2.SelectedValue;

            DataTable dt = repnBll.repnShow(yzname, shzt, wxzt);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dt.Rows[i][6] = "~/wximg/" + dt.Rows[i][6];
                dt.Rows[i][13] = "~/wximg/" + dt.Rows[i][13];
            }
            this.GridView1.DataSource = dt;
            
            this.GridView1.DataBind();
        }

        protected void LinkButton1_Command(object sender, CommandEventArgs e)
        {
            string name = e.CommandName;
            string zt = Convert.ToString(e.CommandArgument);
            if (zt != "待审核")
            {
                Response.Write("<script>alert('您已审核')</script>");
            }
            else
            {
                Response.Redirect("ShenHe.aspx?id=" + name);
            }
        }

        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {

            this.GridView1.PageIndex = e.NewPageIndex;
            DataTable dt = repnBll.repnShow();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dt.Rows[i][6] = "~/wximg/" + dt.Rows[i][6];
                dt.Rows[i][13] = "~/wximg/" + dt.Rows[i][13];
            }
            this.GridView1.DataSource = dt;
            this.GridView1.DataBind();
        }
    }
}