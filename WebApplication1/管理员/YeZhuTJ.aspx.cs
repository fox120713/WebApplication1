using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MODEL;
using BLL;
namespace WebApplication1.管理员
{
    public partial class YeZhuTJ : System.Web.UI.Page
    {
        UserInfo_BLL userinfoBll = new UserInfo_BLL();
        protected void Page_Load(object sender, EventArgs e)
        {


        }
        /// <summary>
        /// 业主添加信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnInset_Click(object sender, EventArgs e)
        {
            UserInfo user = new UserInfo();
            user.UserName1 = this.txtName.Text;
            if (this.RadioButtonMan.Checked)
            {
                user.UserSex1 = "男";
                
            }
            else
            {
                user.UserSex1 = "女";
            }
            user.UserAge1 = int.Parse(this.txtAge.Text);
            user.UserCard1 = this.txtCard.Text;
            user.UserCell1 = this.txtCell.Text;
            user.UserPhone1 = this.txtPhone.Text;
            user.UserImg1 = this.FileUpload1.FileName;
            if (userinfoBll.userinfoInsert(user)>0)
            {
                FileUpload1.SaveAs(Server.MapPath("~/img/" + user.UserImg1));
                Response.Write("<script>alert('添加成功')</script>");
                
            }
            else
            {
                Response.Write("<script>alert('添加失败')</script>");
            }
            
        }
    }
}