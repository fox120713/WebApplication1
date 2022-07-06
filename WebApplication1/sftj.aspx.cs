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
    public partial class sftj : System.Web.UI.Page
    {
        PayTypeBLL bll = new PayTypeBLL();
        DopantBLL bll2 = new DopantBLL();
        DopantMODEL a = new DopantMODEL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                this.DropDownList1.DataSource = bll.bd();
                this.DropDownList1.DataTextField = "PayName";
                this.DropDownList1.DataValueField = "PayID";
                this.DropDownList1.DataBind();
                
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            a.UserName = this.TextBox1.Text;
            a.UserCell = this.TextBox2.Text;
            a.PayID = Convert.ToInt32(this.DropDownList1.SelectedValue);
            a.DopantMoney = Convert.ToInt32(this.TextBox3.Text);
            int b = Convert.ToInt32(bll2.cxxm(a.UserName).Rows[0][0].ToString());
            if (b == 1)
            {
                if (bll2.cxld(a.UserName).Rows[0][0].ToString() == a.UserCell)
                {
                    bll2.tj(a);
                    Response.Write("<script>alert('添加成功')</script>");
                    Response.Redirect("zwf.aspx");
                }
                else
                {
                    Response.Write("<script>alert('楼栋号错误')</script>");
                }
            }
            else
            {
                Response.Write("<script>alert('该用户不存在')</script>");
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            this.TextBox1.Text = "";
            this.TextBox2.Text = "";
            this.TextBox3.Text = "";
            Response.Redirect("zwf.aspx");
        }




    }
}