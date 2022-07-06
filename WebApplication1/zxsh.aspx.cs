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
    public partial class zxsh : System.Web.UI.Page
    {
        RepnnBLL rbll = new RepnnBLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string id = Session["RepnnID"].ToString();
                DataTable dt = rbll.RepnnIDSel(id);
                this.Label1.Text = dt.Rows[0][14].ToString();
                this.Label2.Text = dt.Rows[0][2].ToString();
                this.Image1.ImageUrl = "~/wximg/" + dt.Rows[0][9].ToString();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (rbll.updsh(Session["RepnnID"].ToString())>0)
                {

                    Response.Write("<script>alert('审核成功！！！');window.location.href='User_renovation.aspx';</script>");

                }
            }
            catch (Exception)
            {

                Response.Redirect("User_renovation.aspx");
                
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (rbll.updshw(Session["RepnnID"].ToString()) > 0)
                {
                    Response.Write("<script>alert('审核成功！！！')</script>");
                    Response.Redirect("User_renovation.aspx");
                }
            }
            catch (Exception)
            {

                Response.Redirect("User_renovation.aspx");
                
            }
        }
    }
}