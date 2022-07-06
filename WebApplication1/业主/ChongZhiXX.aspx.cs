using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using BLL;
namespace WebApplication1.业主
{
    public partial class ChongZhiXX : System.Web.UI.Page
    {
        CZMXBLL cbll = new CZMXBLL();
        UserInfo_BLL ubll = new UserInfo_BLL();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                bind();
                mon();

            }
        }
        public void bind()
        {

            string phone = login.userphone;
            int id = Convert.ToInt32(ubll.seluseridnum(phone).Rows[0][0].ToString());
            this.GridView1.DataSource = cbll.czsel(id);
            this.GridView1.DataBind();

        }
        public void mon() {
            DataTable dt = cbll.months();
            DataRow rows = dt.NewRow();
            rows[0] = "全部";
            dt.Rows.InsertAt(rows,0);
            this.DropDownList1.DataSource = dt;
            this.DropDownList1.DataTextField = "Months";
            this.DropDownList1.DataValueField = "Months";
            this.DropDownList1.DataBind();

        
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string mon = this.DropDownList1.SelectedItem.Text;
            string phone = login.userphone;
            int id = Convert.ToInt32(ubll.seluseridnum(phone).Rows[0][0].ToString());
            if (mon=="全部")
            {
                bind();
            }
            else
            {
                DataTable tb = cbll.czsel(id, mon);
                this.GridView1.DataSource = tb;
                this.GridView1.DataBind();
            }
        }
    }
}