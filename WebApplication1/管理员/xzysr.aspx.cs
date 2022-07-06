using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using BLL;


namespace WebApplication1.管理员
{
    public partial class xzysr : System.Web.UI.Page
    {
        RepnnBLL rbll = new RepnnBLL();
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
                string id = Request["id"];

                if (rbll.updshSS(id, "验收中") > 0)
                {
                    string ysr = this.DropDownList1.SelectedValue;
                    rbll.xzspr(id, ysr);
                    
                    Response.Write("<script>alert('派遣完成');window.location.href='YeZhuZX.aspx';</script>");


                }
            }
            catch (Exception)
            {
                
                throw;
            }
                
        }
    }
}