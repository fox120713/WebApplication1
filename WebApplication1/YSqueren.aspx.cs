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
    public partial class YSqueren : System.Web.UI.Page
    {
        RepnnBLL rbll = new RepnnBLL();
        ZHuInfoBLL zbll = new ZHuInfoBLL();
        WuyeZHMXBLL wbll = new WuyeZHMXBLL();
        CZMXBLL cbll = new CZMXBLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string id = Request["id"];
                DataTable dt = rbll.RepnnIDSel(id);
                this.Label1.Text = dt.Rows[0][14].ToString();
                this.Label2.Text = dt.Rows[0][2].ToString();
                this.Image1.ImageUrl = "~/wximg/" + dt.Rows[0][9].ToString();
                this.Label3.Text = dt.Rows[0][10].ToString();

            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                string id = Request["id"];

               
                DataTable dt = rbll.RepnnIDSel(id);
                
                string yzname = dt.Rows[0][14].ToString();
                string mph = dt.Rows[0][2].ToString();
                string userid = dt.Rows[0][1].ToString();

                rbll.updztwc(id);
                zbll.jia(yzname);

                wbll.insYaJinBZ(mph);

                cbll.tuikuancz(userid, mph);
                Response.Redirect("information.aspx");
            }
            catch (Exception)
            {
                
              
            }
           
            

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                string id = Request["id"];
                rbll.updshSS(id, "验收未通过");
                Response.Redirect("information.aspx");
            }
            catch (Exception)
            {
                
                
            }
           
        }
    }
}