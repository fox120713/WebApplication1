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
    public partial class WebForm2 : System.Web.UI.Page
    {
        AppBLL bll = new AppBLL();
        AppMODEL a = new AppMODEL();
        WuyeZHMX wuye = new WuyeZHMX();
        WuyeZHMXBLL wbll = new WuyeZHMXBLL();
        PurpBLL bll2 = new PurpBLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                int id = Convert.ToInt32(Request["id"]);
                if (id != 0)
                {
                    this.TextBox1.Text = bll.xs(id).Rows[0][6].ToString();
                    this.TextBox3.Text = bll.xs(id).Rows[0][5].ToString();
                    this.TextBox4.Text = login.ygname;
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            a.AppDepartment = 4;
            a.AppReason = this.TextBox1.Text;
            a.AppTime = DateTime.Now;
            a.AppMoney = Convert.ToDouble(this.TextBox3.Text);
            a.AppName = this.TextBox4.Text;
            bll.tj(a);
            wuye.Zdly1 = this.DropDownList1.SelectedItem.Text;
            wuye.Zdmoney1 = Convert.ToDouble(this.TextBox3.Text);
            wuye.BeiZhu1 = this.TextBox1.Text;
            wuye.Blr = this.TextBox4.Text;
            wbll.insertbk(wuye);
            int id = Convert.ToInt32(Request["id"]);
            bll2.xg(id);
            Response.Redirect("bokuan.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("cwbsg.aspx");
        }


    }
}