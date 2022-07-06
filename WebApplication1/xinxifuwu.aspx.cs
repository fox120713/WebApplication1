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
    public partial class xinxi_fuwu : System.Web.UI.Page
    {
        Home_BLL h_bll = new Home_BLL();
        UserInfo_BLL u_bll = new UserInfo_BLL();
        CarInfo_BLL c_bll = new CarInfo_BLL();
        Repn_BLL r_bll = new Repn_BLL();
        LzInfo_BLL l_bll = new LzInfo_BLL();
        StfInfo_BLL s_bll = new StfInfo_BLL();
        Ann_BLL a_bll = new Ann_BLL();
        PosBLL p_bll = new PosBLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)  //绑定表
            {
                this.GridView1.DataSource = h_bll.sel();
                this.GridView1.DataBind();

                this.GridView2.DataSource = u_bll.sel();
                this.GridView2.DataBind();

                this.GridView3.DataSource = c_bll.sel();
                this.GridView3.DataBind();

                this.GridView4.DataSource = r_bll.repnShow();
                this.GridView4.DataBind();

                this.GridView5.DataSource = l_bll.sel();
                this.GridView5.DataBind();

                this.GridView6.DataSource = s_bll.sel();
                this.GridView6.DataBind();
                DataTable tables = s_bll.sex();
                DataRow drs = tables.NewRow();
                drs[0] = "全部";
                tables.Rows.InsertAt(drs, 0);
                this.DropDownList2.DataSource = tables;
                this.DropDownList2.DataTextField = "YgSex";
                this.DropDownList2.DataValueField = "YgSex";
                this.DropDownList2.DataBind();



                this.GridView7.DataSource = a_bll.sel();
                this.GridView7.DataBind();
                DataTable tb = a_bll.selzt();
                DataRow row = tb.NewRow();
                row[0] = "全部";
                tb.Rows.InsertAt(row, 0);
                this.DropDownList3.DataSource = tb;
                this.DropDownList3.DataTextField = "AnnaIstate";
                this.DropDownList3.DataValueField = "AnnaIstate";
                this.DropDownList3.DataBind();


                DataTable table = p_bll.PosAll();
                DataRow dr = table.NewRow();
                dr[0] = 0;
                dr[1] = "全部";
                table.Rows.InsertAt(dr, 0);
                this.DropDownList1.DataSource = table;
                this.DropDownList1.DataTextField = "PosName";
                this.DropDownList1.DataValueField = "PosName";
                this.DropDownList1.DataBind();


                this.Label2.Text = login.ygname;
            }

        }

        protected void GridView2_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            this.GridView2.PageIndex = e.NewPageIndex;
            this.GridView2.DataSource = u_bll.sel();
            this.GridView2.DataBind();
        }
        protected void GridView7_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            this.GridView7.PageIndex = e.NewPageIndex;
            this.GridView7.DataSource = a_bll.sel();
            this.GridView7.DataBind();
        }

        protected void GridView4_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            this.GridView4.PageIndex = e.NewPageIndex;
            this.GridView4.DataSource = r_bll.repnShow();
            this.GridView4.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)//查询
        {

            try
            {
                string hometype = this.TextBox1.Text;
                this.GridView1.DataSource = h_bll.sel(hometype);
                this.GridView1.DataBind();
            }
            catch (Exception)
            {
                Response.Write("<script>alert('网页运行失败，详情请咨询维护人员')</script>");
            }
        }

        protected void Button4_Click(object sender, EventArgs e)//查询
        {
            //try
            //{
            string name = this.TextBox7.Text;
            string mp = this.TextBox6.Text;
            this.GridView2.DataSource = u_bll.sel(name, mp);
            this.GridView2.DataBind();
            //}
            //catch (Exception)
            //{
            //    Response.Write("<script>alert('网页运行失败，详情请咨询维护人员')</script>");
            //}


        }

        protected void Button5_Click(object sender, EventArgs e)//查询
        {
            try
            {
            string carid =this.TextBox8.Text;
            this.GridView3.DataSource = c_bll.sel(carid);
            this.GridView3.DataBind();
            }
            catch (Exception)
            {
                Response.Write("<script>alert('网页运行失败，详情请咨询维护人员')</script>");
            }

        }

        protected void Button6_Click(object sender, EventArgs e)//查询
        {
            try
            {
            string number = this.TextBox10.Text;
            string name = this.TextBox9.Text;
            this.GridView4.DataSource = r_bll.sel(number, name);
            this.GridView4.DataBind();
            }
            catch (Exception)
            {
                Response.Write("<script>alert('网页运行失败，详情请咨询维护人员')</script>");
            }

        }

        protected void Button7_Click(object sender, EventArgs e)//查询
        {
            try
            {
            string name = this.TextBox11.Text;
            string type = this.DropDownList1.SelectedValue.ToString();
            this.GridView5.DataSource = l_bll.sel(name, type);
            this.GridView5.DataBind();
            }
            catch (Exception)
            {
                Response.Write("<script>alert('网页运行失败，详情请咨询维护人员')</script>");
            }


        }

        protected void Button8_Click(object sender, EventArgs e)//查询
        {

            try
            {
            string name = this.TextBox12.Text;
            string sex = this.DropDownList2.SelectedValue.ToString();
            this.GridView6.DataSource = s_bll.selbf(name, sex);
            this.GridView6.DataBind();
            }
            catch (Exception)
            {
                Response.Write("<script>alert('网页运行失败，详情请咨询维护人员')</script>");
            }


        }

        protected void Button9_Click(object sender, EventArgs e)//查询
        {
            try
            {
            string title = this.TextBox14.Text;
            string zt = this.DropDownList3.SelectedValue.ToString();
            this.GridView7.DataSource = a_bll.sel(title, zt);
            this.GridView7.DataBind();
            }
            catch (Exception)
            {
                Response.Write("<script>alert('网页运行失败，详情请咨询维护人员')</script>");
            }


        }

        protected void Button3_Click(object sender, EventArgs e)  //确定新增
        {
            try
            {
            string name = login.ygphone;
            Ann ann = new Ann();

            ann.AnnsqrID1 = Convert.ToInt32(s_bll.selname(name).Rows[0][0].ToString());
            ann.AnnTitle1 = this.TextBox2.Text;
            ann.AnnCon1 = this.TextBox3.Text;
            ann.AnnDate1 = System.DateTime.Now;
            ann.AnnaDate1 = System.DateTime.Now;
            ann.AnnaName1 = this.Label2.Text;
            if (a_bll.add(ann)>0)
            {
                Response.Write("<script>alert('添加成功!')</script>");
                
            }
            else
            {
                Response.Write("<script>alert('添加失败!')</script>");
            }

            }
            catch (Exception)
            {
                Response.Write("<script>alert('网页运行失败，详情请咨询维护人员')</script>");
            }
        }

        protected void Button2_Click(object sender, EventArgs e) //取消清空
        {
            this.TextBox2.Text = null;
            this.TextBox3.Text = null;
        }

        protected void LinkButton1_Command(object sender, CommandEventArgs e)  //空车位购买传值
        {
            int id = int.Parse(e.CommandArgument.ToString());
            Response.Redirect("~/buycar.aspx?id=" + id);


        }

        protected void LinkButton1_Command1(object sender, CommandEventArgs e) //空房购买传值
        {
            string lx = e.CommandArgument.ToString();
            Response.Redirect("~/buyhome.aspx?lx=" + lx);
        }

        protected void GridView6_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            this.GridView6.PageIndex = e.NewPageIndex;
            this.GridView6.DataSource = s_bll.sel();
            this.GridView6.DataBind();
        }










    }
}