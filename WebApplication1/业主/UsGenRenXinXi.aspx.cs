using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using BLL;
using MODEL;

namespace WebApplication1.业主
{
    public partial class UsGenRenXinXi : System.Web.UI.Page
    {
        
           UserInfo_BLL userbll = new UserInfo_BLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //string name = login.ygname;
                string name = "张丽丽";
                DataTable dt = userbll.selna(name);
                this.laid.Text = userbll.selna(name).Rows[0][0].ToString();
                this.laname.Text = userbll.selna(name).Rows[0][1].ToString();
                this.laage.Text = userbll.selna(name).Rows[0][3].ToString();
                this.laphone.Text = userbll.selna(name).Rows[0][6].ToString();
                this.lasex.Text = userbll.selna(name).Rows[0][3].ToString();
                this.alsfz.Text = userbll.selna(name).Rows[0][4].ToString();
            }
        }
        
    }
}