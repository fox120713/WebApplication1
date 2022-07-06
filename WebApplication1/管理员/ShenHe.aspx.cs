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
    public partial class ShenHe : System.Web.UI.Page
    {
        Repn_BLL repnbll = new Repn_BLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string id = Request["id"];
                this.DropDownList1.DataSource = repnbll.repenWx();
                this.DropDownList1.DataTextField = "ygname";
                this.DropDownList1.DataValueField = "ygname";
                this.DropDownList1.DataBind();
                DataTable dt = repnbll.repn_WxShow(id);
                this.Label1.Text = dt.Rows[0][1].ToString();
                this.Label2.Text = dt.Rows[0][2].ToString();
                this.Label3.Text = dt.Rows[0][4].ToString();
                this.Label4.Text = dt.Rows[0][5].ToString();
                this.Image1.ImageUrl = "~/wximg/" + dt.Rows[0][6];
            }



        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string id = this.DropDownList1.SelectedValue;
            string name = Request["id"];
            if (repnbll.repn_upd(name, "已通过", id) > 0)
            {
                
                Response.Write("<script>alert('审核成功');window.location.href='WeiXiuCk.aspx';</script>");
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string id = this.DropDownList1.SelectedValue;
            string name = Request["id"];
            if (repnbll.repn_upd(name, "未通过", "") > 0)
            {
                
                Response.Write("<script>alert('审核未通过');window.location.href='WeiXiuCk.aspx';</script>");

            }
        }
    }
}