using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using BLL;
using MODEL;
namespace WebApplication1
{
    public partial class buyhome_1 : System.Web.UI.Page
    {
        Home_BLL h_bll = new Home_BLL();
        UserInfo_BLL u_bll = new UserInfo_BLL();
        ZHuInfoBLL zbll = new ZHuInfoBLL();


        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)//绑定
            {
                string mp = Request.QueryString["mp"];
                this.Label1.Text = mp;
            }
        }

        protected void Button2_Click(object sender, EventArgs e)//新增用户表数据，并删除空房间
        {
            try
            {

                string mp = Request.QueryString["mp"];
                UserInfo user = new UserInfo();
                user.UserCell1 = mp;
                user.UserCard1 = this.TextBox1.Text;
                user.UserSex1 = this.RadioButton2.Checked == true ? "男" : "女";
                user.UserAge1 = int.Parse(this.TextBox2.Text);
                user.UserPhone1 = this.TextBox3.Text;
                user.UserName1 = this.TextBox4.Text;

                if (u_bll.add(user) > 0)
                {
                    h_bll.del(mp);
                    Response.Write("<script>alert('购买成功！')</script>");
                    this.TextBox1.Text = "";
                    this.TextBox2.Text = "";
                    this.TextBox3.Text = "";
                    this.TextBox4.Text = "";

                    Response.Redirect("userlive.aspx");
                }
            }
            catch (Exception)
            {
                Response.Write("<script>alert('网页运行失败，详情请咨询维护人员')</script>");
            }


        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            this.TextBox1.Text = "";
            this.TextBox2.Text = "";
            this.TextBox3.Text = "";
            this.TextBox4.Text = "";
        }
    }
}