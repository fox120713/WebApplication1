using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using MODEL;
namespace WebApplication1.管理员
{
    public partial class GGSPXX : System.Web.UI.Page
    {
        Ann_BLL bll = new Ann_BLL();
        StfInfo_BLL sbll = new StfInfo_BLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            int id=Convert.ToInt32( Request["id"]);
            if (!IsPostBack)
            {
                this.Repeater1.DataSource = bll.selid(id);
                this.Repeater1.DataBind();
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            int id = Convert.ToInt32(Request["id"]);
            string sqrname = bll.selid1(id).Rows[0][14].ToString();
            string phone = login.userphone;
            string username = sbll.selphone(phone).Rows[0][3].ToString();
            bll.update(username,sqrname,id);
            Response.Redirect("GGSP.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request["id"]);
            string phone = login.userphone;
            string username = sbll.selphone(phone).Rows[0][3].ToString();
            string yy = this.TextBox1.Text;
            bll.jj(username,id,yy);
            Response.Redirect("GGSP.aspx");
        }
    }
}