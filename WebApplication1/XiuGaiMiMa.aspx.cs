using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using System.Data;

namespace WebApplication1
{
    public partial class XiuGaiMiMa : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
               

            }
        }
        StfInfo_BLL stfinfobll = new StfInfo_BLL();
        protected void Button1_Click(object sender, EventArgs e)
        {
            string name = login.ygname;
            //string name = "张浩宇";
             if (this.TextBox1.Text == "" || this.TextBox2.Text == "" || this.TextBox3.Text == "")
             {
                 Response.Write("<script>alert('密码不能为空')</script>");
             }
             else {
                 if (stfinfobll.selname(name).Rows[0][1].ToString() != this.TextBox1.Text)
                 {
                     Response.Write("<script>alert('密码错误')</script>");
                 }
                 else {
                     if (this.TextBox2.Text != this.TextBox3.Text)
                     {
                         Response.Write("<script>alert('两次密码不一致')</script>");

                     }
                     else {
                         stfinfobll.PwdUpd(name, this.TextBox3.Text);
                         Response.Write("<script>alert('修改成功！！！')</script>");
                     }
                 }

             }
        }
    }
}