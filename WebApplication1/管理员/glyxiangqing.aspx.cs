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

    public partial class glyxiangqing : System.Web.UI.Page
    {
        StfInfo_BLL s_bll = new StfInfo_BLL();
        UserInfo_BLL userbll = new UserInfo_BLL();
        LzInfo_BLL l_bll = new LzInfo_BLL();
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









                    this.Label4.Text = dt.Rows[0][0].ToString();
                    this.Label3.Text = dt.Rows[0][3].ToString();
                    this.Label5.Text = dt.Rows[0][4].ToString();
                    this.Label8.Text = dt.Rows[0][7].ToString();
                    this.Label7.Text = dt.Rows[0][6].ToString();
                    this.Label6.Text = dt.Rows[0][5].ToString();

                    if (int.Parse(s_bll.selpic(login.ygphone).Rows[0][0].ToString()) == 0)
                    {
                        this.Image1.ImageUrl = "~/img/R-C.jfif";
                    }
                    else
                    {
                        this.Image1.ImageUrl = "~/头像" + s_bll.selpic1(login.ygphone).Rows[0][0].ToString();
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
                Response.Redirect("glyxiangqing.aspx");
            }
            else
            {
                string dz = this.HiddenField1.Value;
                userbll.updatepic(login.userphone, dz);
                this.Image1.ImageUrl = "~/头像" + userbll.selpic1(login.userphone).Rows[0][0].ToString();
                Response.Redirect("glyxiangqing.aspx");
            }
            }
            catch (Exception)
            {
                Response.Write("<script>alert('网页运行失败，详情请咨询维护人员')</script>");
            }
        }

        protected void Button5_Click(object sender, EventArgs e)
        {

            try
            {
            LzInfo lz = new LzInfo();
            lz.YgId1 = int.Parse(this.Label4.Text);
            lz.YgName1 = this.Label3.Text;
            lz.PosName1 = login.ygposname;
            lz.YgRdate1 = Convert.ToDateTime(s_bll.selname(login.ygphone).Rows[0][8].ToString());
            lz.YgSdate1 = System.DateTime.Now;
            lz.YGlzYY1 = this.TextBox3.Text;
            lz.YgBool1 = "待审核";

            if (l_bll.add(lz) > 0)
            {
                Response.Write("<script>alert('申请提交成功！等待管理员审核！')</script>");
            }
            }
            catch (Exception)
            {
                Response.Write("<script>alert('网页运行失败，详情请咨询维护人员')</script>");
            }


        }

    }
}