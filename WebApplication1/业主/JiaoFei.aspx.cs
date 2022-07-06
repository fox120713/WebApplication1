using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using System.Data;
namespace WebApplication1.业主
{
    public partial class JiaoFei : System.Web.UI.Page
    {
        PayTypeBLL tybll = new PayTypeBLL();
        DopantBLL dobll = new DopantBLL();
        ZHuInfoBLL zhbll = new ZHuInfoBLL();
        UserInfo_BLL userbll = new UserInfo_BLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                this.DropDownList1.DataSource = tybll.bd();
                this.DropDownList1.DataTextField = "PayName";
                this.DropDownList1.DataValueField = "PayID";
                this.DropDownList1.DataBind();
            }
        }

        protected void BtnJF_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(this.DropDownList1.SelectedValue);
                string name = login.user;
                int money = int.Parse(this.TextBoxMoney.Text);
                string cell = this.TextBox2.Text;
                DataTable ye = zhbll.cxMoney(name);
                double yue = Convert.ToDouble(ye.Rows[0][0].ToString());
                if (userbll.selCell(cell).Rows.Count == 0)
                {
                    Response.Write("<script>alert('楼栋号输入错误!')</script>");

                }
                else
                {
                    if (yue > 0)
                    {
                        if (dobll.DopantInsert(name, cell, id, money) > 0)
                        {
                            Response.Write("<script>alert('支付成功')</script>");
                            zhbll.jian(money, name);
                            this.TextBox2.Text = "";
                            this.TextBoxMoney.Text = "";


                        }
                    }
                    else
                    {
                        Response.Write("<script>alert('余额不足请充值')</script>");
                    }

                }
            }
            catch (Exception)
            {
                Response.Write("<script>alert('输入楼栋号格式错误!!')</script>");
               
            }

           

        }
    }
}