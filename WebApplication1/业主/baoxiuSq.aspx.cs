using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MODEL;
using BLL;
using System.Data;
namespace WebApplication1.业主
{
    public partial class baoxiuSq : System.Web.UI.Page
    {
        UserInfo_BLL ubll = new UserInfo_BLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string phone = login.userphone;
                DataTable dt = ubll.selnum(phone);
                this.TextBoxMp.Text = dt.Rows[0][0].ToString();
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                RepnMODEL repn = new RepnMODEL();
                Repn_BLL bll = new Repn_BLL();
                UserInfo_BLL ubll = new UserInfo_BLL();
                repn.RepnNumber1 = this.TextBoxMp.Text;
                ubll.seluserid(this.TextBoxMp.Text);
                DataTable tb = ubll.seluserMph(this.TextBoxMp.Text);
                repn.RepnName1 = tb.Rows[0][0].ToString();
                repn.RepnPhone1 = this.TextBoxDh.Text;
                repn.RepnWhat1 = this.TextBoxFK.Text;
                repn.RepnPic1 = this.FileUpload1.FileName;
              
                    if (bll.repninsert(repn) > 0)
                    {
                        FileUpload1.SaveAs(Server.MapPath("~/wximg/" + repn.RepnPic1));

                        Response.Write("<script>alert('添加成功');window.location.href='baoxiuCk.aspx';</script>");

                    }
                    else
                    {
                        Response.Write("<script>alert('添加失败')</script>");
                    }
                
            }
            catch (Exception)
            {

                Response.Write("<script>alert('输入错误!')</script>");
            }



            




        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("baoxiuCk.aspx");
        }
    }
}