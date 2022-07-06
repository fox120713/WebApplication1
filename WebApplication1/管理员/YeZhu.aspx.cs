using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using MODEL;

namespace WebApplication1.管理员
{
    public partial class YeZhu : System.Web.UI.Page
    {
        UserInfo_BLL userbll = new UserInfo_BLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
            this.GridViewYezhu.DataSource = userbll.sel();
            this.GridViewYezhu.DataBind();
            }
            

        }

        protected void GridViewYezhu_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridViewYezhu.PageIndex = e.NewPageIndex;
            this.GridViewYezhu.DataSource = userbll.sel();
            this.GridViewYezhu.DataBind();
        }
        /// <summary>
        ///查询信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Button1_Click(object sender, EventArgs e)
        {
            string name = this.TextBox1.Text;
            string cell = this.TextBox2.Text;
            this.GridViewYezhu.DataSource = userbll.sel(name,cell);
            this.GridViewYezhu.DataBind();
        }
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void GridViewYezhu_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
               int id =Convert.ToInt32( this.GridViewYezhu.DataKeys[e.RowIndex].Value.ToString());
                userbll.UserinfoDel(id);
                ClientScript.RegisterStartupScript(GetType(), "message", "<script>alert('删除成功')</script>");
                this.GridViewYezhu.DataSource = userbll.sel();
                this.GridViewYezhu.DataBind();
               
        }

        protected void GridViewYezhu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void GridViewYezhu_RowEditing1(object sender, GridViewEditEventArgs e)
        {
            this.GridViewYezhu.EditIndex = e.NewEditIndex;//设置开启编辑
            this.GridViewYezhu.DataSource = userbll.sel();
            this.GridViewYezhu.DataBind();
        }

        protected void GridViewYezhu_RowUpdating1(object sender, GridViewUpdateEventArgs e)
        {
            
            UserInfo user = new UserInfo();
            //绑定id
            user.UserID1=Convert.ToInt32(this.GridViewYezhu.DataKeys[e.RowIndex].Value.ToString());
            user.UserName1 = ((TextBox)(this.GridViewYezhu.Rows[e.RowIndex].Cells[1].Controls[0])).Text;
            user.UserSex1=((TextBox)(this.GridViewYezhu.Rows[e.RowIndex].Cells[2].Controls[0])).Text;
            user.UserAge1=Convert.ToInt32(((TextBox)(this.GridViewYezhu.Rows[e.RowIndex].Cells[3].Controls[0])).Text);
            user.UserCard1=((TextBox)(this.GridViewYezhu.Rows[e.RowIndex].Cells[4].Controls[0])).Text;
            user.UserCell1=((TextBox)(this.GridViewYezhu.Rows[e.RowIndex].Cells[5].Controls[0])).Text;
            user.UserPhone1=((TextBox)(this.GridViewYezhu.Rows[e.RowIndex].Cells[6].Controls[0])).Text;
            user.UserPwd1 = ((TextBox)(this.GridViewYezhu.Rows[e.RowIndex].Cells[7].Controls[0])).Text;
            if (userbll.UserinfoUpdate(user)>0)
            {
                ClientScript.RegisterStartupScript(GetType(), "message", "<script>alert('修改成功')</script>");
            }
            else
            {
                ClientScript.RegisterStartupScript(GetType(), "message", "<script>alert('修改失败')</script>");
            }
            this.GridViewYezhu.EditIndex = -1;
            this.GridViewYezhu.DataSource = userbll.sel();
            this.GridViewYezhu.DataBind();
            


        }

        protected void GridViewYezhu_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            this.GridViewYezhu.EditIndex = -1;
            this.GridViewYezhu.DataSource = userbll.sel();
            this.GridViewYezhu.DataBind();
        }

        protected void LinkButton1_Command(object sender, CommandEventArgs e)
        {
            int id =Convert.ToInt32(e.CommandArgument);
            Response.Redirect("YeZhuupdate.aspx?id="+id);

        }

        protected void GridViewYezhu_SelectedIndexChanged1(object sender, EventArgs e)
        {

        }
    }
}