using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using BLL;
using System.Data;
namespace WebApplication1
{
    public partial class glyzhangh : System.Web.UI.Page
    {
        WuyeZHMXBLL w_bll = new WuyeZHMXBLL();
        static string zt;
        static int yue;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                DataTable table = w_bll.months();
                DataRow dr = table.NewRow();
                dr[0] = 0;
                dr[1] = "全部";
                table.Rows.InsertAt(dr, 0);


                this.DropDownList2.DataTextField = "xs";
                this.DropDownList2.DataValueField = "yue";
                this.DropDownList2.DataSource = table;
                this.DropDownList2.DataBind();

                this.Label1.Text = w_bll.summoney().Rows[0][0].ToString();
                this.Label2.Text = w_bll.outmoney().Rows[0][0].ToString();

                zt = this.DropDownList3.SelectedValue;
                yue = int.Parse(this.DropDownList2.SelectedValue.ToString());

                sel();

            }
        }
        void sel()
        {
            if (zt == "收入" && yue == 0)
            {
                Bind();
            }
            if (zt == "支出" && yue == 0)
            {
                this.GridView1.DataSource = w_bll.seloutyue(yue);
                this.GridView1.DataBind();
            }
            if (zt == "收入" && yue!= 0)
            {
                this.GridView1.DataSource = w_bll.selyue(yue);
                this.GridView1.DataBind();
            }
            if (zt == "支出" &&yue!= 0)
            {
                this.GridView1.DataSource = w_bll.seloutyue(yue);
                this.GridView1.DataBind();
            }
        }
        void Bind()
        {
            this.GridView1.DataSource = w_bll.selall();
            this.GridView1.DataBind();
        }

        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            this.GridView1.PageIndex = e.NewPageIndex;
            zt = this.DropDownList3.SelectedValue;
            yue = int.Parse(this.DropDownList2.SelectedValue.ToString());
            sel();
        }

        protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
        {
            zt = this.DropDownList3.SelectedValue;
            yue = int.Parse(this.DropDownList2.SelectedValue.ToString());
            sel();
        }

        protected void DropDownList3_SelectedIndexChanged(object sender, EventArgs e)
        {
            zt = this.DropDownList3.SelectedValue;
            yue = int.Parse(this.DropDownList2.SelectedValue.ToString());
            sel();
        }
    }
}