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
    public partial class CGSP : System.Web.UI.Page
    {
        PurpBLL pbll = new PurpBLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                int id =Convert.ToInt16( Request["id"]);
                DataTable tb = pbll.seljl(id);
                this.LabelBH.Text =tb.Rows[0][0].ToString();
                this.LabelName.Text = tb.Rows[0][1].ToString();
                this.LabelMoney.Text = tb.Rows[0][5].ToString();
                this.Image1.ImageUrl = "~/cgimg/" + tb.Rows[0][2].ToString();
                
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string yy = this.TextBoxYY.Text;
            int id = Convert.ToInt16(Request["id"]);
            if (pbll.update3(yy, id)>0)
            {
                Response.Write("<script>alert('审批成功!')</script>");
            }
          
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("CG.aspx");
        }
    }
}