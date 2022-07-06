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
    public partial class jflx : System.Web.UI.Page
    {
        PayTypeBLL bll = new PayTypeBLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                drop();
                bind();
            }
        }
        public void bind()
        {
            this.GridView1.DataSource = bll.bd();
            this.GridView1.DataBind();
        }

        public void drop()
        {
            DataTable tb = bll.bd();
            DataRow row = tb.NewRow();
            row[1] = "全部";
            tb.Rows.InsertAt(row, 0);
            this.DropDownList1.DataSource = tb;
            this.DropDownList1.DataTextField = "PayName";
            this.DropDownList1.DataValueField = "PayName";
            this.DropDownList1.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string lx = this.DropDownList1.SelectedValue;
            if (lx!="全部")
            {
                this.GridView1.DataSource = bll.cx(lx);
                this.GridView1.DataBind();
            }
            else
            {
                bind();
            }
           
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("lxtj.aspx");
        }

        protected void LinkButton1_Command(object sender, CommandEventArgs e)
        {
            int id = Convert.ToInt32(e.CommandArgument);
            Response.Redirect("jfxg.aspx?id="+id);
        }


    }
}