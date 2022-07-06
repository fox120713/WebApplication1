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
    public partial class jftj : System.Web.UI.Page
    {
        JfMxBLL bll = new JfMxBLL();
        UserInfo_BLL ubll = new UserInfo_BLL();
        static string dong;
        static string dy;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                this.DropDownList1.DataSource = ubll.seldong();
                this.DropDownList1.DataTextField = "dong";
                this.DropDownList1.DataBind();

                dong = this.DropDownList1.SelectedValue;
                this.DropDownList2.DataSource = ubll.seldy(dong);
                this.DropDownList2.DataTextField = "dong";
                this.DropDownList2.DataBind();

                dy = this.DropDownList2.SelectedValue;
                this.DropDownList3.DataSource = ubll.selnumber(dong, dy);
                this.DropDownList3.DataTextField = "dong";
                this.DropDownList3.DataBind();

                drop();


            }
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dong = this.DropDownList1.SelectedValue;
            this.DropDownList2.DataSource = ubll.seldy(dong);
            this.DropDownList2.DataTextField = "dong";
            this.DropDownList2.DataBind();
        }

        protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
        {
            dy = this.DropDownList2.SelectedValue;
            this.DropDownList3.DataSource = ubll.selnumber(dong, dy);
            this.DropDownList3.DataTextField = "dong";
            this.DropDownList3.DataBind();
        }

        public void drop()
        {
            this.DropDownList4.DataSource = bll.bd();
            this.DropDownList4.DataTextField = "PayName";
            this.DropDownList4.DataValueField = "PayName";
            this.DropDownList4.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string lx = this.DropDownList4.SelectedValue;
            string d = this.DropDownList1.SelectedValue.Substring(0, 1);
            string y = this.DropDownList2.SelectedValue.Substring(0, 1);
            string m = this.DropDownList3.SelectedValue.Substring(0, 3);
            string j = d + "-" + y + "-" + m;
            string a = DateTime.Now.Year.ToString();
            string b = DateTime.Now.Month.ToString();
            string c = a + "-" + b;
            if (lx != "物业费")
            {
                JfMxMODEL q = new JfMxMODEL();
                q.UserCell1 = j;
                q.Months = c;
                q.PayName1 = this.DropDownList4.SelectedValue;
                q.Syd1 = Convert.ToDouble(this.TextBox1.Text);
                q.Byd = Convert.ToDouble(this.TextBox2.Text);
                q.Yddj1 = Convert.ToDouble(this.TextBox3.Text);
                q.DateMoney = Convert.ToDouble(this.TextBox4.Text);
                q.Fwmj = Convert.ToDouble(bll.fwlx(j).Rows[0][9]);
                q.Home = bll.fwlx(j).Rows[0][8].ToString();
                bll.tj(q);
                Response.Redirect("yzjfmx.aspx");
            }
            else
            {
                JfMxMODEL gh = new JfMxMODEL();
                gh.PayName1 = this.DropDownList4.SelectedValue;
                gh.UserCell1 = j;
                gh.Yddj1 = Convert.ToDouble(this.TextBox3.Text);
                gh.Fwmj = Convert.ToDouble(bll.fwlx(j).Rows[0][9]);
                gh.Home = bll.fwlx(j).Rows[0][8].ToString();
                gh.Months = c;
                double mj = Convert.ToDouble(gh.Fwmj);
                double dj = Convert.ToDouble(this.TextBox3.Text);
                gh.DateMoney = mj * dj;
                bll.tj1(gh);
                Response.Redirect("yzjfmx.aspx");
            }

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            this.TextBox2.Text = "";

        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {
            string lx = this.DropDownList4.SelectedValue;
            if (lx != "物业费")
            {
                double a = Convert.ToDouble(this.TextBox1.Text);
                double b = Convert.ToDouble(this.TextBox2.Text);
                double c = Convert.ToDouble(this.TextBox3.Text);
                double d = (b - a) * c;
                this.TextBox4.Text = d.ToString();
            }
            else
            {
                string d = this.DropDownList1.SelectedValue.Substring(0, 1);
                string y = this.DropDownList2.SelectedValue.Substring(0, 1);
                string m = this.DropDownList3.SelectedValue.Substring(0, 3);
                string j = d + "-" + y + "-" + m;
                string a = DateTime.Now.Year.ToString();
                string b = (DateTime.Now.Month - 1).ToString();
                string c = a + "-" + b;
                double mj = Convert.ToDouble(bll.syyd(j, lx, c).Rows[0][9]);
                double dj = Convert.ToDouble(this.TextBox3.Text);
                double wyf = mj * dj;
                this.TextBox4.Text = wyf.ToString();
            }

        }

        protected void DropDownList4_SelectedIndexChanged(object sender, EventArgs e)
        {
            string d = this.DropDownList1.SelectedValue.Substring(0, 1);
            string y = this.DropDownList2.SelectedValue.Substring(0, 1);
            string m = this.DropDownList3.SelectedValue.Substring(0, 3);
            string j = d + "-" + y + "-" + m;
            string lx = this.DropDownList4.SelectedValue;
            string a = DateTime.Now.Year.ToString();
            string b = (DateTime.Now.Month - 1).ToString();
            string c = a + "-" + b;
            this.TextBox1.Text = bll.syyd(j, lx, c).Rows[0][4].ToString();
            this.TextBox3.Text = bll.bd(lx).Rows[0][0].ToString();
        }

        protected void DropDownList4_DataBound(object sender, EventArgs e)
        {
            string d = this.DropDownList1.SelectedValue.Substring(0, 1);
            string y = this.DropDownList2.SelectedValue.Substring(0, 1);
            string m = this.DropDownList3.SelectedValue.Substring(0, 3);
            string j = d + "-" + y + "-" + m;
            string lx = this.DropDownList4.SelectedValue;
            string a = DateTime.Now.Year.ToString();
            string b = (DateTime.Now.Month - 1).ToString();
            string c = a + "-" + b;
            this.TextBox1.Text = bll.syyd(j, lx, c).Rows[0][4].ToString();
            this.TextBox3.Text = bll.bd(lx).Rows[0][0].ToString();
        }



    }
}