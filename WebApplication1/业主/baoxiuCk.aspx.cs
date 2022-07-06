using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using System.Data;

namespace WebApplication1.业主
{
    public partial class baoxiuCk : System.Web.UI.Page
    {
        public static string UserName;
        
        Repn_BLL repnBll = new Repn_BLL();
        UserInfo_BLL u_bll = new UserInfo_BLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string username = login.user;

                //this.GridView1.DataSource = repnBll.repnSel(username);
                //this.GridView1.DataBind();
                DataTable dt = repnBll.repnSel(username); ;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dt.Rows[i][6] = "~/wximg/" + dt.Rows[i][6];
                    dt.Rows[i][13] = "~/wximg/" + dt.Rows[i][13];
                }
                this.GridView1.DataSource = dt;
                this.GridView1.DataBind();
            }
          

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string shzt = this.DropDownList1.SelectedItem.Text;
            string shwx = this.DropDownList2.SelectedItem.Text;
            string name = login.user;
            DataTable dt = repnBll.repnShow1(name, shzt, shwx);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dt.Rows[i][6] = "~/wximg/" + dt.Rows[i][6];
                dt.Rows[i][13] = "~/wximg/" + dt.Rows[i][13];
            }
            this.GridView1.DataSource = dt;
            this.GridView1.DataBind();



        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}