using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using BLL;
using System.Data;
namespace WebApplication1.业主
{
    public partial class userxiangqing : System.Web.UI.Page
    {
        StfInfo_BLL s_bll = new StfInfo_BLL();
        UserInfo_BLL userbll = new UserInfo_BLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
            if (!IsPostBack)
            {
                string name = "";
                if (int.Parse(userbll.sel(login.userphone).Rows[0][0].ToString()) > 0)
                {
                    name = login.user;
                    this.Label1.Text = name;
                    this.Label2.Text = name;
                    DataTable dt = userbll.selna(login.userphone);
                    this.laid.Text = dt.Rows[0][0].ToString();
                    this.laname.Text = dt.Rows[0][2].ToString();
                    this.laage.Text = dt.Rows[0][4].ToString();
                    this.laphone.Text = dt.Rows[0][7].ToString();
                    this.lasex.Text = dt.Rows[0][3].ToString();
                    this.alsfz.Text = dt.Rows[0][5].ToString();                   


                    if (int.Parse(userbll.selpic(login.userphone).Rows[0][0].ToString()) == 0)
                    {
                        this.Image1.ImageUrl = "~/img/R-C.jfif";
                    }
                    else
                    {
                        this.Image1.ImageUrl = "~/头像" + userbll.selpic1(login.userphone).Rows[0][0].ToString();
                    }
                }
                else
                {
                    name = login.ygname;
                    this.Label1.Text = name;
                    this.Label2.Text = name;
                    DataTable dt = s_bll.selnameall(login.ygphone);
                    this.laid.Text = dt.Rows[0][0].ToString();
                    this.laname.Text = dt.Rows[0][3].ToString();
                    this.laage.Text = dt.Rows[0][5].ToString();
                    this.laphone.Text = dt.Rows[0][7].ToString();
                    this.lasex.Text = dt.Rows[0][4].ToString();
                    this.alsfz.Text = dt.Rows[0][6].ToString();

                    if (int.Parse(s_bll.selpic(login.ygphone).Rows[0][0].ToString()) == 0)
                    {
                        this.Image1.ImageUrl = "~/img/R-C.jfif";
                    }
                    else
                    {
                        this.Image1.ImageUrl = "~/头像" + s_bll.selpic1(login.ygname).Rows[0][0].ToString();
                    }
                }

            }
            }
            catch (Exception)
            {
                Response.Write("<script>alert('网页运行失败，详情请咨询维护人员')</script>");
            }



        }
        //员工密码修改
        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
            if (int.Parse(s_bll.sel(login.ygphone).Rows[0][0].ToString()) > 0)
            {
                string pwd = this.TextBox1.Text;
                if (s_bll.pwdupdate(login.ygphone, pwd) > 0)
                {
                    Response.Write("<script>alert('修改成功！需要用户重新登录！')</script>");
                    Response.Redirect("~/login.aspx");
                }
            }
            else
            {
                if (userbll.PwdUpd(login.ygphone, this.TextBox1.Text) > 0)
                {
                    Response.Write("<script>alert('修改成功！需要用户重新登录！')</script>");
                    Response.Redirect("~/login.aspx");
                }
            }
            }
            catch (Exception)
            {
                Response.Write("<script>alert('网页运行失败，详情请咨询维护人员')</script>");
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            try
            {
            if (int.Parse(s_bll.sel(login.ygphone).Rows[0][0].ToString()) > 0)
            {
                string dz = this.HiddenField1.Value;
                s_bll.updatepic(login.ygphone, dz);
                this.Image1.ImageUrl = "~/头像" + s_bll.selpic1(login.ygphone).Rows[0][0].ToString();
            }
            else
            {
                string dz = this.HiddenField1.Value;
                userbll.updatepic(login.userphone, dz);
                this.Image1.ImageUrl = "~/头像" + userbll.selpic1(login.userphone).Rows[0][0].ToString();
            }

            Response.Redirect("userxiangqing.aspx");
            }
            catch (Exception)
            {
                Response.Write("<script>alert('网页运行失败，详情请咨询维护人员')</script>");
            }

        }
    }
}