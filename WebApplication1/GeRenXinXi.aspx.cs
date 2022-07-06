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
    public partial class GeRenXinXi : System.Web.UI.Page
    {
        StfInfo_BLL stfbll = new StfInfo_BLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string name = login.ygname;
                this.laid.Text = stfbll.selname(name).Rows[0][0].ToString();
                this.laname.Text = stfbll.selname(name).Rows[0][2].ToString();
                this.laage.Text = stfbll.selname(name).Rows[0][4].ToString();
                this.laphone.Text = stfbll.selname(name).Rows[0][6].ToString();
                this.lasex.Text = stfbll.selname(name).Rows[0][3].ToString();
                this.alsfz.Text = stfbll.selname(name).Rows[0][5].ToString();
            }
        }
    }
}