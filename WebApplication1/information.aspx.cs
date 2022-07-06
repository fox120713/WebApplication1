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
    public partial class information : System.Web.UI.Page
    {
        Repn_BLL repnbll = new Repn_BLL();
        PrepnBLL prepnbll = new PrepnBLL();
        RepnnBLL rbll = new RepnnBLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string ygname = login.ygname;//获取登录的 员工名称
               
                    this.Repeater1.DataSource = prepnbll.Prpen_PrState(ygname);
                    this.Repeater1.DataBind();
                    this.Repeater2.DataSource = repnbll.repn_ReppBool(ygname);
                    this.Repeater2.DataBind();
                this.Repeater3.DataSource =rbll.SelYsl(ygname);
                this.DataBind();
                }
                
            
            }

        }
    }
