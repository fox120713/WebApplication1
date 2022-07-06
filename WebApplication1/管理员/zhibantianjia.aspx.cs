using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MODEL;
using BLL;

namespace WebApplication1.管理员
{
    public partial class zhibantianjia : System.Web.UI.Page
    {
        infoBLL bll = new infoBLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                int id = int.Parse(Request.QueryString["id"]);
                this.Label2.Text = id.ToString();
                this.Label3.Text = bll.xm(id).Rows[0][0].ToString();
                this.TextBox4.Text = "";

            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (Page.IsValid==true)
            {
                int id = int.Parse(this.Label2.Text);             
                    ZbInfoMODEL u = new ZbInfoMODEL();
                    u.YgId1 = int.Parse(this.Label2.Text);
                    u.YgName1 = this.Label3.Text;
                    u.YgPos1 = 5;
                    u.Zbdate = Convert.ToDateTime(this.TextBox4.Text + " 00:00:00");
                    u.Gznr = this.TextBox5.Text;
                    u.Jttime = this.DropDownList1.Text;
                    bll.ZBadd(u);
                    Response.Redirect("zhibanguanli.aspx");              
            }
            
               
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("renyuanguanli.aspx");            
        }


       

        protected void CustomValidator2_ServerValidate(object source, ServerValidateEventArgs args)
        {            
            if (DateTime.Parse(args.Value)<=DateTime.Parse(DateTime.Now.AddDays(-1).ToShortDateString()))
            {
                args.IsValid = false;                
                 
            }
            else
            {
                args.IsValid = true;
            }
        }
    }
}