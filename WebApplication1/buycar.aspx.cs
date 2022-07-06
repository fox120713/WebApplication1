using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using BLL;
using MODEL;
namespace WebApplication1
{
    public partial class buycar : System.Web.UI.Page
    {
        CarInfo_BLL c_bll = new CarInfo_BLL();
        UserInfo_BLL u_bll = new UserInfo_BLL();
        WuyeZHMXBLL w_bll = new WuyeZHMXBLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!IsPostBack)//绑定
                {
                    this.Label1.Text = Request.QueryString["id"];

                }
            }
            catch (Exception)
            {
                Response.Write("<script>alert('网页运行失败，详情请咨询维护人员')</script>");
            }


        }

        protected void Button1_Click(object sender, EventArgs e)//确定——修改车位信息表数据
        {
            try
            {
                CarInfo car = new CarInfo();
                car.CarBH1 = int.Parse(this.Label1.Text);
                car.UserID1 = int.Parse(u_bll.seluserid(this.TextBox2.Text).Rows[0][0].ToString());
                car.CarNum1 = this.TextBox1.Text;
                car.UserPhone1 = this.TextBox2.Text;
                car.Typee1 = "买断";
                car.CarSta1 = "1";

                WuyeZHMX wuye = new WuyeZHMX();
                wuye.Zdly1 = u_bll.selnum(this.TextBox2.Text).Rows[0][0].ToString();
                wuye.PayName1 = "买车位";
                wuye.Dates = System.DateTime.Now;
                wuye.Zdmoney1 = 150000;
                wuye.Months = System.DateTime.Now.Month;


                int usernum = int.Parse(u_bll.seluseridnum(car.UserPhone1).Rows[0][0].ToString());

                if (usernum>0)
                {
                   if (c_bll.update(car) > 0&&  w_bll.insercar(wuye)>0)
                {                   
                    Response.Write("<script>alert('购买成功！')</script>");
                    this.TextBox1.Text = null;
                    this.TextBox2.Text = null;
                }
                else if ( (this.TextBox1.Text==null)&&(this.TextBox2.Text == null))
                {
                     Response.Write("<script>alert('请勿重复购买！')</script>");
                }
                }
                else
                {
                    Response.Write("<script>alert('此车位只允许业主购买！')</script>");
                }

            }
            catch (Exception)
            {
                Response.Write("<script>alert('网页运行失败，详情请咨询维护人员')</script>");
            }

        }

        protected void Button2_Click(object sender, EventArgs e)//取消——清空
        {
            this.TextBox1.Text = null;
            this.TextBox2.Text = null;
        }
    }
}