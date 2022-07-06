using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using System.Data;
namespace WebApplication1.管理员
{
    public partial class BuMen : System.Web.UI.Page
    {
        PosBLL Posbll = new PosBLL();




        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //绑定表格数据
                this.GridViewBumen.DataSource = Posbll.PosAll();
                this.GridViewBumen.DataBind();
                //绑定下拉框数据
                DataTable table = Posbll.PosAll();
                DataRow row = table.NewRow();
                row[0] = 66;
                row[1] = "全部";
                table.Rows.InsertAt(row, 0);
                this.DropDownListPos.DataSource = table;
                this.DropDownListPos.DataTextField = "PosName";
                this.DropDownListPos.DataValueField = "PosID";
                this.DropDownListPos.DataBind();
            }

        }


        protected void GridViewBumen_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button6_Command(object sender, CommandEventArgs e)
        {
            //删除部门
            //1.获取部门id
            object id = e.CommandArgument;
            Posbll.Posdel(Convert.ToInt32(id));
            //刷新数据
            this.GridViewBumen.DataSource = Posbll.PosAll();
            this.GridViewBumen.DataBind();
            DataTable table = Posbll.PosAll();
            DataRow row = table.NewRow();
            row[0] = 66;
            row[1] = "全部";
            table.Rows.InsertAt(row, 0);
            this.DropDownListPos.DataSource = table;
            this.DropDownListPos.DataTextField = "PosName";
            this.DropDownListPos.DataValueField = "PosID";
            this.DropDownListPos.DataBind();
            

        }

        protected void DropDownListPos_SelectedIndexChanged1(object sender, EventArgs e)
        {
            //获取下拉框选中id
            int id = Convert.ToInt16(this.DropDownListPos.SelectedValue);
            if (id != 66)
            {
                this.GridViewBumen.DataSource = Posbll.PosAll(id);
                this.GridViewBumen.DataBind();
            }
            else
            {
                this.GridViewBumen.DataSource = Posbll.PosAll();
                this.GridViewBumen.DataBind();
            }
        }
        
        
        //}
        /// <summary>
        /// 部门更改事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        
        protected void GridViewBumen_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            int id =Convert.ToInt32(this.GridViewBumen.DataKeys[e.RowIndex].Value.ToString());
            //获取部门值
            string posName = ((TextBox)(this.GridViewBumen.Rows[e.RowIndex].Cells[1].Controls[0])).Text;
            if (Posbll.Posupdate(posName,id)>0)
            {
                Response.Write("<script>alert('修改成功')</script>");
                DataTable table = Posbll.PosAll();
                DataRow row = table.NewRow();
                row[0] = 66;
                row[1] = "全部";
                table.Rows.InsertAt(row, 0);
                this.DropDownListPos.DataSource = table;
                this.DropDownListPos.DataTextField = "PosName";
                this.DropDownListPos.DataValueField = "PosID";
                this.DropDownListPos.DataBind();
            }
            else
            {
                Response.Write("<script>alert('修改失败')</script>");
            }



        }

        protected void GridViewBumen_RowEditing(object sender, GridViewEditEventArgs e)
        {
            this.GridViewBumen.EditIndex = e.NewEditIndex;
            //刷新数据
            this.GridViewBumen.DataSource = Posbll.PosAll();
            this.GridViewBumen.DataBind();
        }
        /// <summary>
        /// 结束编辑
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void GridViewBumen_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            this.GridViewBumen.EditIndex = -1;
            //刷新数据
            this.GridViewBumen.DataSource = Posbll.PosAll();
            this.GridViewBumen.DataBind();
        }

        protected void ImageButtonTJ_Click(object sender, ImageClickEventArgs e)
        {

            var ff = this.HiddenField1.Value;
            if (ff == "")
            {
                Response.Write("<script>alert('添加失败！')</script>");
            }
            else
            {
                if (Posbll.PosInsert(ff) > 0)
                {
                    Response.Write("<script>alert('添加成功！')</script>");
                    //刷新数据
                    this.GridViewBumen.DataSource = Posbll.PosAll();
                    this.GridViewBumen.DataBind();
                    DataTable table = Posbll.PosAll();
                    DataRow row = table.NewRow();
                    row[0] = 66;
                    row[1] = "全部";
                    table.Rows.InsertAt(row, 0);
                    this.DropDownListPos.DataSource = table;
                    this.DropDownListPos.DataTextField = "PosName";
                    this.DropDownListPos.DataValueField = "PosID";
                    this.DropDownListPos.DataBind();

                }
                else
                {
                    Response.Write("<script>alert('添加失败！')</script>");

                }
            }
        }
    }
}