using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MODEL;
using BLL;
using System.Data;

namespace WebApplication1.业主
{
    public partial class GGweixiuSq : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                PrepnModel prepn = new PrepnModel();
                PrepnBLL bll = new PrepnBLL();
                UserInfo_BLL ubll = new UserInfo_BLL();
                prepn.Prsite = this.DropDownList1.SelectedValue;
                prepn.Prsqr = login.user;
                prepn.Prsdate1 = DateTime.Now.ToString();
                prepn.Prphone  = this.TextBoxDh.Text;
                prepn.PrCon = this.TextBoxFK.Text; ;
               prepn.Primg = this.FileUpload1.FileName;
               

                

                    if (bll.Prepn_Add(prepn)> 0)
                    {
                        FileUpload1.SaveAs(Server.MapPath("~/wximg/" + prepn.Primg));
                        Response.Write("<script>alert('添加成功')</script>");

                    }
                    else
                    {
                        Response.Write("<script>alert('添加失败')</script>");
                    }
                
            }
            catch (Exception)
            {

                Response.Write("<script>alert('输入错误!')</script>");
            }








        }
    }
}