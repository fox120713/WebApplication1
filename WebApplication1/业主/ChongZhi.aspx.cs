using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using System.Data;
using MODEL;
namespace WebApplication1.业主
{
    public partial class ChongZhi : System.Web.UI.Page
    {
        ZHuInfoBLL zhuBll = new ZHuInfoBLL();
        UserInfo_BLL ubll = new UserInfo_BLL();
        CZMXBLL cbll = new CZMXBLL();//充值明细
        CZMXModel czmodel = new CZMXModel();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string name = login.user;
                string phone = login.userphone;
                DataTable dt = ubll.seluserid(phone);
                int id =Convert.ToInt32(dt.Rows[0][0].ToString());
                DataTable zh = zhuBll.selzh(id);
                this.TextBox1.Text = zh.Rows[0][0].ToString();
                cxmoney();
                this.TextBox3.Text = "个人充值";

            }
         
        }
        /// <summary>
        /// 根据账户id查询有多少钱
        /// </summary>
        public void cxmoney() {
            DataTable tb = zhuBll.cxMoney1(this.TextBox1.Text);
            this.LaMoney.Text = tb.Rows[0][3].ToString();
        }
        

        protected void ButtonC_Click(object sender, EventArgs e)
        {
            try
            {
                string id = this.TextBox1.Text;
                cxmoney();
                double money=0;
                if (this.TextBox2.Text.Trim() == "" || this.TextBox2.Text.Trim() == null)
                {
                    if (this.RadioButton1.Checked)
                    {
                        money = 200;
                        if (zhuBll.xg(money, id) > 0)
                        {
                            cxmoney();
                            Response.Write("<script>alert('充值成功')</script>");
                            this.LabelZF.Text = money.ToString();
                            //充值成功，同时添加一条充值记录
                            //获取当前充值账户业主id
                            string phone = login.userphone;
                            DataTable dt = ubll.seluserid(phone);
                            int yzid = Convert.ToInt32(dt.Rows[0][0].ToString());
                            czmodel.Yzid = yzid;
                            czmodel.Czje = money;
                            czmodel.Mph = ubll.selnum(phone).Rows[0][0].ToString();
                            cbll.czinsert(czmodel);
                        }
                        else
                        {
                            Response.Write("<script>alert('充值失败')</script>");
                        }
                    }
                    else if (this.RadioButton2.Checked)
                    {
                        money = 300;

                        if (zhuBll.xg(money, id) > 0)
                        {
                            cxmoney();
                            Response.Write("<script>alert('充值成功')</script>");
                            this.LabelZF.Text = money.ToString();
                            //充值成功，同时添加一条充值记录
                            //获取当前充值账户业主id
                            string phone = login.userphone;
                            DataTable dt = ubll.seluserid(phone);
                            int yzid = Convert.ToInt32(dt.Rows[0][0].ToString());
                            czmodel.Yzid = yzid;
                            czmodel.Czje = money;
                            czmodel.Mph = ubll.selnum(phone).Rows[0][0].ToString();
                            cbll.czinsert(czmodel);
                        }
                        else
                        {
                            Response.Write("<script>alert('充值失败')</script>");
                        }

                    }
                    else if (this.RadioButton3
                        .Checked)
                    {
                        money = 400;
                        if (zhuBll.xg(money, id) > 0)
                        {
                            cxmoney();
                            Response.Write("<script>alert('充值成功')</script>");
                            this.LabelZF.Text = money.ToString();
                            //充值成功，同时添加一条充值记录
                            //获取当前充值账户业主id
                            string phone = login.userphone;
                            DataTable dt = ubll.seluserid(phone);
                            int yzid = Convert.ToInt32(dt.Rows[0][0].ToString());
                            czmodel.Yzid = yzid;
                            czmodel.Czje = money;
                            czmodel.Mph = ubll.selnum(phone).Rows[0][0].ToString();
                            cbll.czinsert(czmodel);
                        }
                        else
                        {
                            Response.Write("<script>alert('充值失败')</script>");
                        }
                    }

                    else
                    {
                        Response.Write("<script>alert('请输入内容')</script>");

                    }
                }
                else
                {
                    money = double.Parse(this.TextBox2.Text);

                    if (zhuBll.xg(money, id) > 0)
                    {
                        cxmoney();
                        Response.Write("<script>alert('充值成功')</script>");
                        this.LabelZF.Text = money.ToString();
                        //充值成功，同时添加一条充值记录
                        //获取当前充值账户业主id
                        string phone = login.userphone;
                        DataTable dt = ubll.seluserid(phone);
                        int yzid = Convert.ToInt32(dt.Rows[0][0].ToString());
                        czmodel.Yzid = yzid;
                        czmodel.Czje = money;
                        czmodel.Mph = ubll.selnum(phone).Rows[0][0].ToString();
                        cbll.czinsert(czmodel);
                    }
                    else
                    {
                        Response.Write("<script>alert('充值失败')</script>");
                    }
                    cxmoney();
                    this.LabelZF.Text = money.ToString();

                }
            }
            catch (Exception)
            {

                Response.Write("<script>alert('超过最大长度!')</script>");
            }
            

        }

        
    }
}