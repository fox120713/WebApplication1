using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using BLL;

namespace WebApplication1
{
    public partial class nullcar : System.Web.UI.Page
    {
        CarInfo_BLL c_bll = new CarInfo_BLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                this.GridView3.DataSource = c_bll.sel();
                this.GridView3.DataBind();
            }
        }

        protected void Button5_Click(object sender, EventArgs e)//查询
        {
            try
            {
                string carid = this.TextBox8.Text;
                this.GridView3.DataSource = c_bll.sel(carid);
                this.GridView3.DataBind();
            }
            catch (Exception)
            {
                Response.Write("<script>alert('网页运行失败，详情请咨询维护人员')</script>");
            }

        }

        protected void LinkButton1_Command(object sender, CommandEventArgs e)  //空车位购买传值
        {
            int id = int.Parse(e.CommandArgument.ToString());
            Response.Redirect("~/buycar.aspx?id=" + id);
        }


    }
}