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
    public partial class jfhztj : System.Web.UI.Page
    {
        jfhzBLL bll = new jfhzBLL();
        UserInfo_BLL ubll = new UserInfo_BLL();
        static string dong;
        static string dy;
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
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

                string a = DateTime.Now.Year.ToString();
                string b = (DateTime.Now.Month - 1).ToString();
                string c = a + "-" + b;
            this.TextBox4.Text = c;

            string d = this.DropDownList1.SelectedValue.Substring(0, 1);
            string y = this.DropDownList2.SelectedValue.Substring(0, 1);
            string m = this.DropDownList3.SelectedValue.Substring(0, 3);
            string j = d + "-" + y + "-" + m;
            string h = DateTime.Now.Year.ToString();
            string g = DateTime.Now.Month.ToString();
            string l = h + "-" + g;
            this.TextBox1.Text = bll.ss(j, l).Rows[0][0].ToString();
            string t = (DateTime.Now.Month - 1).ToString();
            this.TextBox2.Text = bll.syjy(j, t).Rows[0][4].ToString();
            this.TextBox3.Text = bll.syjy(j, t).Rows[0][5].ToString();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string d = this.DropDownList1.SelectedValue.Substring(0, 1);
            string y = this.DropDownList2.SelectedValue.Substring(0, 1);
            string m = this.DropDownList3.SelectedValue.Substring(0, 3);
            string j = d + "-" + y + "-" + m;
            string b = DateTime.Now.Month.ToString();
            jfhzMODEL f = new jfhzMODEL();
            f.HzLD1 = j;
            f.Months1 = b;
            f.SJyu1 = Convert.ToDouble(this.TextBox2.Text);
            f.Byyu1 = Convert.ToDouble(this.TextBox3.Text);
            f.Summoney = Convert.ToDouble(this.TextBox1.Text);
            bll.tj(f);
            Response.Redirect("yzjfjl.aspx");
        }

        protected void TextBox4_DataBinding(object sender, EventArgs e)
        {
            //string d = this.DropDownList1.SelectedValue.Substring(0, 1);
            //string y = this.DropDownList2.SelectedValue.Substring(0, 1);
            //string m = this.DropDownList3.SelectedValue.Substring(0, 3);
            //string j = d + "-" + y + "-" + m;
            //string a = DateTime.Now.Year.ToString();
            //string b = DateTime.Now.Month.ToString();
            //string c = a + "-" + b;
            //this.TextBox1.Text = bll.ss(j,c).Rows[0][0].ToString();
            //string t=(DateTime.Now.Month - 1).ToString();
            //this.TextBox2.Text=bll.syjy(j,t).Rows[0][4].ToString();
            //this.TextBox3.Text=bll.syjy(j,t).Rows[0][5].ToString();
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

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("yzjfjl.aspx");
        }


        }
    }
