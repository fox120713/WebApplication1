using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using MODEL;
using System.Data;
namespace WebApplication1.管理员
{
    public partial class LzSPxx : System.Web.UI.Page
    {
        LzInfo_BLL lbll = new LzInfo_BLL();
        LzInfo lz = new LzInfo();
        StfInfo_BLL stbll = new StfInfo_BLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                int id =int.Parse( Request["id"]);
                this.Repeater1.DataSource = lbll.selxx(id);
                this.Repeater1.DataBind();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            lz.ID1 = int.Parse(Request["id"]);
            DataTable tb = lbll.selxx(lz.ID1);
            int ygid =Convert.ToInt32(tb.Rows[0][1].ToString());
            string zt=this.DropDownList1.SelectedItem.Text;
            if (zt=="通过")
            {
                lz.YgBool1 = "已通过";
            }
            else
            {
                lz.YgBool1 = "未通过";
            }
            lz.Ygyy1 = this.TextBox1.Text;
            if (lbll.update(lz)>0)
            {
                Response.Write("<script>alert('审核成功!')</script>");
                if (lz.YgBool1 == "已通过")
                {
                    stbll.stInfoDel(ygid);
                }
                
                Response.Redirect("LzSP.aspx");
            }
        }
        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("LzSP.aspx");
        
        }

        protected void Repeater1_ItemCommand(object source, RepeaterCommandEventArgs e)
        {

        }
    }
}