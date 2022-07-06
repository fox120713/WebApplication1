using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using BLL;
using MODEL;
namespace WebApplication1.管理员
{
    public partial class YeZhuupdate : System.Web.UI.Page
    {
        UserInfo_BLL userbll = new UserInfo_BLL();
        UserInfo umodel = new UserInfo();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                int id =int.Parse( Request["id"]);
                DataTable tb = userbll.selxx(id);
                this.LabelBH.Text = tb.Rows[0][0].ToString();
                this.LabelCell.Text = tb.Rows[0][5].ToString();
                this.LabelLd.Text = tb.Rows[0][6].ToString();
                this.LabelSEx.Text = tb.Rows[0][3].ToString();
                this.TextBoxName.Text = tb.Rows[0][2].ToString();
                this.TextBoxPhone.Text = tb.Rows[0][7].ToString();
                this.TextBoxPwd.Text = tb.Rows[0][8].ToString();
                this.Image1.ImageUrl = "~/业主图片/" + tb.Rows[0][1].ToString();
  }
        }

        protected void Button2_Click1(object sender, EventArgs e)
        {
            umodel.UserName1 = this.TextBoxName.Text;
            umodel.UserPhone1 = this.TextBoxPhone.Text;
            umodel.UserPwd1 = this.TextBoxPwd.Text;
            umodel.UserID1 = int.Parse(Request["id"]);
            if (userbll.Update(umodel)>0)
            {
                Response.Write("<script>alert('修改成功')</script>");
                
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("YeZhu.aspx");
        }
    }
}