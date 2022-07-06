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
    
    public partial class NoticeShow : System.Web.UI.Page
    {
        Ann_BLL bll = new Ann_BLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
            string id = Request["id"];
            DataTable dt = bll.AnnAll(id);          
            this.Label1.Text = dt.Rows[0][1].ToString();
            this.Label2.Text = dt.Rows[0][3].ToString();
            this.Label3.Text = dt.Rows[0][2].ToString();
            this.Image1.ImageUrl = "~/img/" + dt.Rows[0][4].ToString();
            this.DataList1.DataSource = bll.AnnOrderBy();
            this.DataList1.DataBind();
            }
        }
    }
}