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
    public partial class cwbsg : System.Web.UI.Page
    {
        PurpBLL bll = new PurpBLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            string zt = this.DropDownList1.SelectedValue;
            if (zt == "已通过")
            {
                bind();
            }
            else
            {
                DataTable tb = bll.cx(zt);
                for (int i = 0; i < tb.Rows.Count; i++)
                {
                    tb.Rows[i][2] = "~/cgimg/" + tb.Rows[i][2];
                }
                this.GridView1.DataSource = tb;
                this.GridView1.DataBind();
            }


        }

        public void bind()
        {
            DataTable tb = bll.tb();
            for (int i = 0; i < tb.Rows.Count; i++)
            {
                tb.Rows[i][2] = "~/cgimg/" + tb.Rows[i][2];
            }
            this.GridView1.DataSource = tb;
            this.GridView1.DataBind();
        }

        protected void LinkButton1_Command(object sender, CommandEventArgs e)
        {
            int id = Convert.ToInt32(e.CommandArgument);
            string name = e.CommandName;
            string zt = bll.table(id).Rows[0][9].ToString();
            if (zt == "已通过")
            {
                if (name == "去拨款")
                {
                    Response.Redirect("bktj.aspx?id=" + id);
                }
            }
            else if (zt == "未通过")
            {
                if (name == "去拨款")
                {
                    DataTable tb = bll.cx(zt);
                    for (int i = 0; i < tb.Rows.Count; i++)
                    {
                        tb.Rows[i][2] = "~/cgimg/" + tb.Rows[i][2];
                    }
                    this.GridView1.DataSource = tb;
                    this.GridView1.DataBind();
                }

            }


        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string zt = this.DropDownList1.SelectedItem.Text;
            DataTable tb = bll.cx(zt);
            for (int i = 0; i < tb.Rows.Count; i++)
            {
                tb.Rows[i][2] = "~/cgimg/" + tb.Rows[i][2];
            }
            this.GridView1.DataSource = tb;
            this.GridView1.DataBind();
        }

    }
}