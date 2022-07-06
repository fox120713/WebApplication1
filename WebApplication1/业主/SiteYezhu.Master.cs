using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using BLL;
namespace WebApplication1.业主
{
    public partial class SiteYezhu : System.Web.UI.MasterPage
    {
        UserInfo_BLL u_bll = new UserInfo_BLL();
        StfInfo_BLL s_bll = new StfInfo_BLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (int.Parse(s_bll.sel(login.ygphone).Rows[0][0].ToString()) > 0)
                {
                    this.Label1.Text = login.ygname;
                    if (int.Parse(s_bll.selpic(login.ygphone).Rows[0][0].ToString()) == 0)
                    {
                        this.Image4.ImageUrl = "~/img/R-C.jfif";
                        this.Image9.ImageUrl = "~/img/R-C.jfif";
                    }
                    else
                    {
                        this.Image4.ImageUrl = "~/头像" + s_bll.selpic1(login.ygphone).Rows[0][0].ToString();
                        this.Image9.ImageUrl = "~/头像" + s_bll.selpic1(login.ygphone).Rows[0][0].ToString();
                    }
                }
                else
                {
                    this.Label1.Text = login.user;
                    if (int.Parse(u_bll.selpic(login.userphone).Rows[0][0].ToString()) == 0)
                    {
                        this.Image4.ImageUrl = "~/img/R-C.jfif";
                        this.Image9.ImageUrl = "~/img/R-C.jfif";
                    }
                    else
                    {
                        this.Image4.ImageUrl = "~/头像" + u_bll.selpic1(login.userphone).Rows[0][0].ToString();
                        this.Image9.ImageUrl = "~/头像" + u_bll.selpic1(login.userphone).Rows[0][0].ToString();
                    }
                }

            }
        }

    }
}