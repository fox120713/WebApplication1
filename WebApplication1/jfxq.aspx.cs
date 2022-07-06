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
    public partial class jfxq : System.Web.UI.Page
    {
        WuyeZHMXBLL bll = new WuyeZHMXBLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //string name = Request["id"];
                bind();
            }
        }

        public void bind()
        {
            string name = Request["id"];
            this.GridView1.DataSource = bll.qxck(name);
            this.GridView1.DataBind();
        }

        protected void GridView1_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {
            this.GridView1.PageIndex = e.NewSelectedIndex;
            bind();
        }


    }
}