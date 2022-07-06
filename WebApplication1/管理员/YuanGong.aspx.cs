using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using System.Data;
using MODEL;

namespace WebApplication1.管理员
{
    public partial class YuanGong : System.Web.UI.Page
    {
        /// <summary>
        /// 员工信息表
        /// </summary>
        StfInfo_BLL stfBll = new StfInfo_BLL();
        PosBLL PosBll = new PosBLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Bind();
                PosSelect();

            }

        }
        /// <summary>
        /// 绑定表格数据
        /// </summary>
        public void Bind()
        {
            this.YGGv.DataSource = stfBll.StInfoAll();
            this.YGGv.DataBind();
        }
        /// <summary>
        /// 绑定员工部门表下拉框数值
        /// </summary>
        public void PosSelect()
        {
            DataTable table = PosBll.PosAll();
            DataRow row = table.NewRow();
            row[0] = 7;
            row[1] = "全部";
            table.Rows.InsertAt(row, 0);
            this.BumenDropList.DataSource = table;
            this.BumenDropList.DataTextField = "PosName";
            this.BumenDropList.DataValueField = "PosID";
            this.BumenDropList.DataBind();

        }
        public DataTable Posbind() {
            return PosBll.PosAll();
        
        
        }

        protected void YGGv_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            YGGv.PageIndex = e.NewPageIndex;
            Bind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //查询方法
            //获取文本框的值
            string name = this.txtName.Text;
            string phone = this.txtPhone.Text;
            //获取下拉框的值
            int posID =Convert.ToInt32(this.BumenDropList.SelectedValue);
            //if (posID == 7 && name == "" && phone == "")
            //{
            //    this.YGGv.DataSource = stfBll.StInfoAll();
            //    this.YGGv.DataBind();
            //}
            //else
            //{
                this.YGGv.DataSource = stfBll.StInfoAll(name, phone, posID);
                this.YGGv.DataBind();
            //}
            

            
        }

        protected void YGGv_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            //删除方法
            int id =Convert.ToInt32( this.YGGv.DataKeys[e.RowIndex].Value);
            stfBll.stInfoDel(id);
            Bind();
            
        }

        protected void YGGv_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void YGGv_RowEditing(object sender, GridViewEditEventArgs e)
        {
            this.YGGv.EditIndex = e.NewEditIndex;//设置编辑开启
            Bind();
        }
        //修改方法
        protected void YGGv_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            StfInfoMODEL yg=new StfInfoMODEL();

            //1.获取id
            yg.YgId1 =Convert.ToInt32( this.YGGv.DataKeys[e.RowIndex].Value.ToString());
            //2.获取用户修改的单元格里面的值
            yg.YgPwd1 = ((TextBox)(this.YGGv.Rows[e.RowIndex].Cells[1].Controls[0])).Text;
            yg.YgName1 = ((TextBox)(this.YGGv.Rows[e.RowIndex].Cells[2].Controls[0])).Text;
            yg.YgSex1 = ((TextBox)(this.YGGv.Rows[e.RowIndex].Cells[3].Controls[0])).Text;
            yg.YgAge1 =Convert.ToInt32( ((TextBox)(this.YGGv.Rows[e.RowIndex].Cells[4].Controls[0])).Text);
            yg.YgCell1 = ((TextBox)(this.YGGv.Rows[e.RowIndex].Cells[5].Controls[0])).Text;
            yg.YgPhone1 = ((TextBox)(this.YGGv.Rows[e.RowIndex].Cells[6].Controls[0])).Text;
            yg.Ygdate = ((TextBox)(this.YGGv.Rows[e.RowIndex].Cells[7].Controls[0])).Text;
            yg.Ygpos1 = Convert.ToInt32(((DropDownList)(this.YGGv.Rows[e.RowIndex].Cells[8].FindControl("DropDownList6"))).Text);
            if (stfBll.stInfoupdate(yg)>0)
            {
                Response.Write("<script>alert('修改成功！')</script>");
                
            }
            else
            {
                Response.Write("<script>alert('修改失败！')</script>");
            }
            this.YGGv.EditIndex = -1;
            Bind();

        }

        protected void YGGv_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            this.YGGv.EditIndex = -1;
            Bind();
        }

        protected void LinkButton2_Command(object sender, CommandEventArgs e)
        {
            string id = e.CommandName;
            Response.Redirect("StfUpdate.aspx?id="+id);

        }
        
    }
}