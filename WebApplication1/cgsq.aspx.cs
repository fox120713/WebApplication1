using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using BLL;
using MODEL;

namespace WebApplication1
{
    public partial class cgsq : System.Web.UI.Page
    {
        static bool pd = false;

        PurpBLL bll = new PurpBLL();
        StfInfo_BLL bll2 = new StfInfo_BLL();
        PurpDOMEL a = new PurpDOMEL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                this.TextBox6.Text = login.ygname;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (this.TextBox2.Text == "")
            {
                this.Label1.Text = "*";
            }
            else if (this.TextBox3.Text == "")
            {
                this.Label2.Text = "*";
            }
            else
            {
                a.PurpName = this.TextBox1.Text;
                a.PurpNumber = Convert.ToInt32(this.TextBox2.Text);
                a.PurPrice = Convert.ToDouble(this.TextBox3.Text);
                a.PurpSum = Convert.ToInt32(this.TextBox4.Text);
                a.PurpAccount = this.TextBox5.Text;
                a.PurSqr = this.TextBox6.Text;
                a.PurpImg = this.FileUpload1.FileName;
                if (bll.tj(a) > 0)
                {
                    FileUpload1.SaveAs(Server.MapPath("~/cgimg/" + a.PurpImg));
                    Response.Redirect("cg.aspx");
                }
            }

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            this.TextBox1.Text = "";
            this.TextBox2.Text = "";
            this.TextBox3.Text = "";
            this.TextBox4.Text = "";
            this.TextBox5.Text = "";
        }

        protected void TextBox3_TextChanged(object sender, EventArgs e)
        {
            try
            {
                //在这里将接收的字符串
                //int a = Convert.ToInt32(this.TextBox3.Text);
                //如果转换成功 返回的则是true  可以转换为int型
                this.TextBox4.Text = (Convert.ToInt32(this.TextBox2.Text) * Convert.ToDouble(this.TextBox3.Text)).ToString();
                //pd= true;
            }
            catch
            {
                //如果转换int型失败会返回false 这个字符串中含有非数字的字符 所以不能转换为int型
                //pd=false;
                this.TextBox4.Text = "";
                this.Label1.Text = "只能为非负数";
            }
        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                //在这里将接收的字符串
                //int a = Convert.ToInt32(this.TextBox3.Text);
                //如果转换成功 返回的则是true  可以转换为int型
                this.TextBox4.Text = (Convert.ToInt32(this.TextBox2.Text) * Convert.ToDouble(this.TextBox3.Text)).ToString();
                //pd = true;

            }
            catch
            {
                //如果转换int型失败会返回false 这个字符串中含有非数字的字符 所以不能转换为int型
                //pd=false;
                this.TextBox4.Text = "";
                this.Label2.Text = "只能为非负数";
            }
        }

    }
}