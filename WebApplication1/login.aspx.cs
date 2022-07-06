using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using BLL;
using System.Threading;
namespace WebApplication1
{

    public partial class login : System.Web.UI.Page
    {
        UserInfo_BLL u_bll = new UserInfo_BLL();
        StfInfo_BLL s_bll = new StfInfo_BLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                this.radiobtn.Checked = true;
            }
        }
        public static string ygname;//员工姓名传值
        public static string ygphone;//员工账号传值
        public static string ygposname;//员工部门传值
        public static string user;//居民姓名传值
        public static string userphone;//居民账号传值

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                string phone = this.name.Text;
                string pwd = this.pwd.Text;
                ygphone = phone;
                userphone = phone;
                ygname = "";
                user = "";
                ygposname = "";

                if (int.Parse(s_bll.sel(phone).Rows[0][0].ToString()) > 0)
                {
                    ygname = s_bll.selphone(phone).Rows[0][3].ToString();
                    ygposname = s_bll.selbm(phone).Rows[0][0].ToString();
                }
                else
                {
                    user = u_bll.selphone(phone).Rows[0][2].ToString();
                }
                //Session["User"] = u_bll.sel(name);
                if ((int.Parse(s_bll.sel(phone).Rows[0][0].ToString()) > 0 || int.Parse(u_bll.sel(phone).Rows[0][0].ToString()) > 0 || int.Parse(s_bll.selgly(phone).Rows[0][0].ToString()) > 0) && this.radiobtn.Checked == true)//登录判断
                {
                    if (int.Parse(s_bll.selgly(phone, pwd).Rows[0][0].ToString()) > 0)
                    {
                        Response.Redirect("管理员/Glshouye.aspx");
                    }

                    else if (int.Parse(s_bll.denglu(phone, pwd).Rows[0][0].ToString()) > 0)
                    {
                        Response.Write("<script>alert('登录成功！')</script>");
                        Response.Redirect("~/PSHOUye.aspx");
                    }
                    else if (int.Parse(u_bll.denglu(phone, pwd).Rows[0][0].ToString()) > 0)
                    {
                        Response.Write("<script>alert('登录成功！')</script>");
                        Response.Redirect("业主/ShouYeYeZHu.aspx");
                    }
                    else
                    {
                        Response.Write("<script>alert('登录失败，请确认密码是否正确输入！')</script>");
                    }


                }
                else if (this.radiobtn.Checked == false)
                {
                    Response.Write("<script>alert('请仔细阅读并同意协议！')</script>");
                }
            }
            catch (Exception)
            {
                Response.Write("<script>alert('网页运行失败，详情请咨询维护人员')</script>");
            }

        }
    }
}