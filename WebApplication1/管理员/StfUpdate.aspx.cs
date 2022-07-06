using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MODEL;
using BLL;
using System.Data;

namespace WebApplication1.管理员
{
    public partial class StfUpdate : System.Web.UI.Page
    {
        StfInfo_BLL stf = new StfInfo_BLL();
        StfInfoMODEL stfmo = new StfInfoMODEL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string id = Request["id"];
                DataTable dt = stf.selid(id);
                this.Label1.Text = dt.Rows[0][0].ToString();
                this.Label2.Text = dt.Rows[0][4].ToString();
                this.Label3.Text = dt.Rows[0][6].ToString();
                this.TextBoxDate.Text = dt.Rows[0][8].ToString();
                this.TextBoxName.Text = dt.Rows[0][3].ToString();
                    this.TextBoxPhone.Text = dt.Rows[0][7].ToString();
                    this.TextBoxPwd.Text = dt.Rows[0][2].ToString();
                    this.TextBoxDate.Text = dt.Rows[0][8].ToString();
                    PosBLL Posbll = new PosBLL();
                    this.DropDownList1.DataSource = Posbll.PosAll();
                    this.DropDownList1.DataTextField = "PosName";
                    this.DropDownList1.DataValueField = "PosID";
                    this.DropDownList1.DataBind();
                    this.Image1.ImageUrl = "~/员工图片/" + dt.Rows[0][1].ToString();
            }
        }
        
        protected void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                stfmo.Ygdate = this.TextBoxDate.Text;
                stfmo.YgName1 = this.TextBoxName.Text;
                stfmo.YgPhone1 = this.TextBoxPhone.Text;
                stfmo.YgPwd1 = this.TextBoxPwd.Text;
                stfmo.YgId1 = Convert.ToInt32(this.Label1.Text);
                stfmo.Ygpos1 = Convert.ToInt32(this.DropDownList1.SelectedValue);
                if (stf.StfUpd(stfmo) > 0)
                {
                    Response.Write("<script>alert('修改成功！')</script>");
                }
            }
            catch (Exception)
            {

                Response.Write("<script>alert('输入数据有误！')</script>");
                
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("YuanGong.aspx");
        }
    }
}