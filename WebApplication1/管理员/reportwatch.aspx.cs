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
    public partial class reportwatch : System.Web.UI.Page
    {
        infoBLL bll = new infoBLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = int.Parse(Request["zbid"]);
            DataTable dt=bll.shenhexinxi(id);
            this.Label1.Text = dt.Rows[0][2].ToString();
            this.Label2.Text = dt.Rows[0][4].ToString();
            this.Label3.Text = dt.Rows[0][6].ToString();
            this.Label4.Text = dt.Rows[0][5].ToString();
            this.Image1.ImageUrl = dt.Rows[0][9].ToString();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int id = int.Parse(Request["zbid"]);
            string cause = this.HiddenField1.Value;
            bll.btg(cause,id);
            Response.Redirect("zhibanshenhe.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            int id = int.Parse(Request["zbid"]);
            string name = this.Label1.Text;
            bll.tg(id,name);
            Response.Write("<script>prompt('已通过！')</script>");
            Response.Redirect("zhibanshenhe.aspx");
        }
        
    }
}