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
    public partial class DopantAll : System.Web.UI.Page
    {
        DopantBLL dopantbll = new DopantBLL();
        PayTypeBLL paybll = new PayTypeBLL();
        UserInfo_BLL ubll = new UserInfo_BLL();
        JfMxBLL jbll = new JfMxBLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Type();
                //string username = login.user;
                bind();
                //获取当前登录电话
                string phone = login.userphone;
                //获取缴费类型
                string typename = this.DropDownList1.SelectedItem.Text;
                //获取月份
                string yf = this.DropDownListMonth.SelectedItem.Text;
                //获取楼栋号
                string cell = ubll.selnum(phone).Rows[0][0].ToString();
                this.LabelSum.Text = jbll.sum(cell).Rows[0][0].ToString();
             
            }

        }
        public void bind() {

            //获取当前登录电话
            string phone = login.userphone;
            //获取楼栋号
            string cell = ubll.selnum(phone).Rows[0][0].ToString();
            this.GridViewDopant.DataSource = jbll.selJFMx(cell);
            this.GridViewDopant.DataBind();
        
        
        }
        /// <summary>
        /// 下拉列表绑定
        /// </summary>
        public void Type()
        {
            DataTable tb = paybll.bd();
            DataRow row = tb.NewRow();
            row[0] = 66;
            row[1] = "全部";
            tb.Rows.InsertAt(row, 0);
            this.DropDownList1.DataSource = tb;
            this.DropDownList1.DataTextField = "PayName";
            this.DropDownList1.DataValueField = "PayID";
            this.DropDownList1.DataBind();

            //DataTable months = jbll.selMoths();
            //DataRow rows = months.NewRow();
            //rows[0] = "全部";
            //months.Rows.InsertAt(rows,0);
            //this.DropDownListMonth.DataSource = months;
            //this.DropDownListMonth.DataTextField = "months";
            //this.DropDownListMonth.DataValueField = "months";
            //this.DropDownListMonth.DataBind();
            //取当前月分
            int month=DateTime.Now.Month;
            this.DropDownListMonth.SelectedValue = month.ToString();


            int years = DateTime.Now.Year;// 取当前时间年   
            DataTable year = jbll.selYear();
            //DataRow rowss = year.NewRow();
            //rowss[0] = "全部";
            //year.Rows.InsertAt(rowss, 0);
            this.DropDownListYear.DataSource = year;
            this.DropDownListYear.DataTextField = "year";
            this.DropDownListYear.DataValueField = "year";
            this.DropDownListYear.DataBind();



          
           
        }

        protected void ButtonCX_Click(object sender, EventArgs e)
        {
            
            //获取缴费类型
            string typename = this.DropDownList1.SelectedItem.Text;

            //获取年份的值
            string year = this.DropDownListYear.SelectedItem.Text;
            //获取月份的值
            string month = this.DropDownListMonth.SelectedItem.Text;
            //拼接根据日期查询数据
            string rq = year + "-" + month;

            ////获取月份
            //string yf = this.DropDownListMonth.SelectedItem.Text;
            //获取当前登录电话
            string phone = login.userphone;
            //获取楼栋号
            string cell = ubll.selnum(phone).Rows[0][0].ToString();
            this.GridViewDopant.DataSource = jbll.selJFMx(cell, typename, rq);
            this.GridViewDopant.DataBind();
            this.LabelSum.Text = jbll.selsum(cell, typename, rq).Rows[0][0].ToString();
            if (this.GridViewDopant.Rows.Count==0)
            {
                Response.Write("<script>alert('没有记录可以查看哦')</script>");
                
            }
        }

        protected void LinkButton1_Command(object sender, CommandEventArgs e)
        {
            int id = Convert.ToInt32(e.CommandArgument);
            string a = e.CommandArgument.ToString();
            if (a != "已缴费")
            {
                Response.Redirect("yzjf.aspx?id=" + id);
            }
            else
            {
                Response.Write("<script>alert('已缴费')</script>");
            }
        }

        protected void GridViewDopant_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            this.GridViewDopant.PageIndex = e.NewPageIndex;
            bind();
        }

 
    }
}