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
    public partial class gongaoadd : System.Web.UI.Page
    {
        StfInfo_BLL s_bll = new StfInfo_BLL();
        Ann_BLL a_bll = new Ann_BLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                this.Label2.Text = login.ygname;
            }
        }

        protected void Button3_Click(object sender, EventArgs e)  //确定新增
        {
            try
            {
                string name = login.ygphone;
                Ann ann = new Ann();

                ann.AnnsqrID1 = Convert.ToInt32(s_bll.selname(name).Rows[0][0].ToString());
                ann.AnnTitle1 = this.TextBox2.Text;
                ann.AnnCon1 = this.TextBox3.Text;
                ann.AnnaDate1 = System.DateTime.Now;
                ann.AnnaName1 = this.Label2.Text;
                if (a_bll.add(ann) > 0)
                {
                    Response.Write("<script>alert('添加成功!')</script>");

                }
                else
                {
                    Response.Write("<script>alert('添加失败!')</script>");
                }

            }
            catch (Exception)
            {
                Response.Write("<script>alert('网页运行失败，详情请咨询维护人员')</script>");
            }
        }

        protected void Button2_Click(object sender, EventArgs e) //取消清空
        {
            this.TextBox2.Text = null;
            this.TextBox3.Text = null;
        }

    }
}