using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using System.Data;
using MODEL;

namespace WebApplication1
{
    public partial class Public_maintenance : System.Web.UI.Page
    {
        PrepnBLL PrBLL = new PrepnBLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DataTable dt = PrBLL.PrepnShow();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dt.Rows[i][3] = "~/wximg/" + dt.Rows[i][3];
                    //dt.Rows[i][13] = "~/wximg/" + dt.Rows[i][13];
                }
                this.GridView1.DataSource = dt;
                this.GridView1.DataBind();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string Prsite = this.DropDownList1.SelectedValue;
            string PrIstate = this.DropDownList2.SelectedValue;
            string PrState = this.DropDownList3.SelectedValue;
            DataTable dt = PrBLL.PrepnSelShow(Prsite, PrIstate, PrState);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dt.Rows[i][3] = "~/wximg/" + dt.Rows[i][3];
                //dt.Rows[i][13] = "~/wximg/" + dt.Rows[i][13];
            }
            this.GridView1.DataSource = dt;
            this.GridView1.DataBind();
        }
    }
}