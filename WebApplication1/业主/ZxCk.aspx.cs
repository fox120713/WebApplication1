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
    public partial class ZxCk : System.Web.UI.Page
    {
        RepnnBLL rbll = new RepnnBLL();
        UserInfo_BLL ubll = new UserInfo_BLL();
        ZHuInfoBLL zbll = new ZHuInfoBLL();
        WuyeZHMXBLL wbll = new WuyeZHMXBLL();
        CZMXBLL cbll = new CZMXBLL();
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                bind();
            }

        }
        
        public void bind()
        {
            string phone = login.userphone;
            DataTable dt = ubll.selnum(phone);
            string mph = dt.Rows[0][0].ToString();
            DataTable table = rbll.Repnnxx(mph);
            this.GridView1.DataSource = table;
            this.GridView1.DataBind();
        }

        protected void LinkButton1_Command(object sender, CommandEventArgs e)
        {
            try
            {
                string zt = e.CommandName;
                int id = Convert.ToInt32(e.CommandArgument);
                DateTime a = DateTime.Now;
                string phone = login.userphone;
                string name = ubll.seluserid(phone).Rows[0][2].ToString();
                string userid = ubll.seluserid(phone).Rows[0][0].ToString();
                DataTable dt = ubll.selnum(phone);
                string mph = dt.Rows[0][0].ToString();
                if (zt == "进行中")
                {
                    //rbll.xg(a, id);
                    //rbll.up(id);
                    //zbll.jia(name);

                    //wbll.insYaJinBZ(mph);

                    //cbll.tuikuancz(userid, mph);
                    string id1 = id.ToString();
                    rbll.updshSS(id1, "待验收");
                    bind();

                }
                else if(zt=="待审核") {
                    Response.Write("<script>alert('请等待工作人员审核')</script>");
                
                
                }
                else if (zt == "待验收")
                {
                    Response.Write("<script>alert('请等待工作人员上门验收')</script>");


                }
                else if (zt == "已完成")
                {
                    Response.Write("<script>alert('装修已完成')</script>");


                }
                else if (zt == "审核未通过")
                {
                    Response.Write("<script>alert('审核未通过请重新提交申请')</script>");
                
                }
                else if (zt == "验收未通过")
                {
                
                }
            }
            catch (Exception)
            {
                
                
            }
            

        }
    }
}