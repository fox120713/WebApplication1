using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MODEL;
using BLL;

namespace WebApplication1
{
    public partial class zhibantianjia : System.Web.UI.Page
    {
        infoBLL bll = new infoBLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                this.TextBox4.Text = "";

            }

            


        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (Page.IsValid==true)
            {
                int id = int.Parse(this.TextBox1.Text);
                if (this.TextBox2.Text != "后勤部查无此人" && bll.ztqr(id).Rows[0][0].ToString() == "无任务")
                {
                    ZbInfoMODEL u = new ZbInfoMODEL();
                    u.YgId1 = int.Parse(this.TextBox1.Text);
                    u.YgName1 = this.TextBox2.Text;
                    u.YgPos1 = 5;
                    u.Zbdate = Convert.ToDateTime(this.TextBox4.Text + " 00:00:00");
                    u.Gznr = this.TextBox5.Text;
                    u.Jttime = this.DropDownList1.Text;
                    bll.ZBadd(u);
                    Response.Redirect("zhibanguanli.aspx");
                }
                else
                {
                    Response.Write("<script>alert('请输入暂无工作任务的员工的正确id')</script>");
                }
            }
            
               
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("zhibanguanli.aspx");            
        }


        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
            int id = int.Parse(this.TextBox1.Text); 
            if (bll.cs(id).Rows.Count != 0)
            {
                this.TextBox2.Text = bll.xm(id).Rows[0][0].ToString();
            }
            else
            {
                this.TextBox2.Text = "后勤部查无此人";
            }

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