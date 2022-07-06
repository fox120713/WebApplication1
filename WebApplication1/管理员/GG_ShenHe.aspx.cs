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
    public partial class GG_ShenHe : System.Web.UI.Page
    {
        Repn_BLL repnbll = new Repn_BLL();
        PrepnBLL prepnbll = new PrepnBLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string id = Request["id"];
                this.DropDownList1.DataSource = prepnbll.Prepn_wxr();
                this.DropDownList1.DataTextField = "ygname";
                this.DropDownList1.DataValueField = "ygname";
                this.DropDownList1.DataBind();
                DataTable dt = prepnbll.ggshShow(id);
                this.Label1.Text = dt.Rows[0][4].ToString();
                this.Label2.Text = dt.Rows[0][1].ToString();
                this.Label3.Text = dt.Rows[0][2].ToString();
                this.Label4.Text = dt.Rows[0][6].ToString();
                this.Image1.ImageUrl = "~/wximg/" + dt.Rows[0][3];
            }



        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string id = this.DropDownList1.SelectedValue;
            string name = Request["id"];
            if (prepnbll.shenhe(name, "已通过", id) > 0)
            {
                
                Response.Write("<script>alert('审核成功');window.location.href='GongGongWeiXiu.aspx';</script>");
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string id = this.DropDownList1.SelectedValue;
            string name = Request["id"];
            if (prepnbll.shenhe(name, "未通过", id) > 0)
            {
                Response.Write("<script>alert('审核未通过');window.location.href='GongGongWeiXiu.aspx';</script>");
            }
        }
    }
}