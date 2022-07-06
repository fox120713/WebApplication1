using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using BLL;

namespace WebApplication1
{
    public partial class yzjfmx : System.Web.UI.Page
    {
        WuyeZHMXBLL bll = new WuyeZHMXBLL();
        JfMxBLL bll2 = new JfMxBLL();
        UserInfo_BLL ubll = new UserInfo_BLL();
        static string dong;
        static string dy;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                drop();

                this.DropDownList1.DataSource = ubll.seldong();
                this.DropDownList1.DataTextField = "dong";
                this.DropDownList1.DataBind();

                dong = this.DropDownList1.SelectedValue;
                this.DropDownList2.DataSource = ubll.seldy(dong);
                this.DropDownList2.DataTextField = "dong";
                this.DropDownList2.DataBind();

                dy = this.DropDownList2.SelectedValue;
                this.DropDownList3.DataSource = ubll.selnumber(dong, dy);
                this.DropDownList3.DataTextField = "dong";
                this.DropDownList3.DataBind();
                bind();
            }
        }

        public void bind()
        {
            this.GridView1.DataSource = bll2.table();
            this.GridView1.DataBind();
        }

        public void drop()
        {
            DataTable tb = bll2.bdyf();
            DataRow row = tb.NewRow();
            row[0] = "全部";
            tb.Rows.InsertAt(row, 0);
            this.DropDownList4.DataSource = tb;
            this.DropDownList4.DataTextField = "months";
            this.DropDownList4.DataValueField = "months";
            this.DropDownList4.DataBind();
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dong = this.DropDownList1.SelectedValue;
            this.DropDownList2.DataSource = ubll.seldy(dong);
            this.DropDownList2.DataTextField = "dong";
            this.DropDownList2.DataBind();
        }

        protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
        {
            dy = this.DropDownList2.SelectedValue;
            this.DropDownList3.DataSource = ubll.selnumber(dong, dy);
            this.DropDownList3.DataTextField = "dong";
            this.DropDownList3.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string d = this.DropDownList1.SelectedValue.Substring(0, 1);
            string y = this.DropDownList2.SelectedValue.Substring(0, 1);
            string m = this.DropDownList3.SelectedValue.Substring(0, 3);
            string j = d + "-" + y + "-" + m;
            string yf = this.DropDownList4.SelectedValue;
            if (yf == "全部")
            {

                this.GridView1.DataSource = bll2.table(j);
                this.GridView1.DataBind();
            }
            else
            {
                    this.GridView1.DataSource = bll2.yf(yf,j);
                    this.GridView1.DataBind();
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("jftj.aspx");
        }

        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
            bind();
        }



    }
}