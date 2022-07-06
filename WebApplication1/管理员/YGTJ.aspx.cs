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
    public partial class YGTJ : System.Web.UI.Page
    {
        PosBLL posbll = new PosBLL();
        StfInfo_BLL stfbll = new StfInfo_BLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //绑定下拉框
                this.DropDownListPos.DataSource = posbll.PosAll();
                this.DropDownListPos.DataTextField = "PosName";
                this.DropDownListPos.DataValueField = "PosID";
                this.DropDownListPos.DataBind();
                DateTime a = DateTime.Now;
                this.txtDate.Text = Convert.ToString(a);            }

        }
        /// <summary>
        /// 添加员工信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnInset_Click(object sender, EventArgs e)
        {
            try
            {
                StfInfoMODEL yg = new StfInfoMODEL();
                yg.YgName1 = this.txtName.Text;
                if (this.RadioButtonMan.Checked)
                {
                    yg.YgSex1 = "男";

                }
                else
                {
                    yg.YgSex1 = "女";
                }
                yg.YgAge1 = Convert.ToInt16(this.txtAge.Text);
                yg.YgCell1 = this.txtCell.Text;
                yg.YgPhone1 = this.txtPhone.Text;
                yg.Ygdate = this.txtDate.Text;
                yg.Posid = int.Parse(this.DropDownListPos.SelectedValue);
                yg.Ygimg = this.FileUpload1.FileName;
                if (stfbll.stInfoInsert(yg) > 0)
                {
                    FileUpload1.SaveAs(Server.MapPath("~/员工图片/" + yg.Ygimg));
                    Response.Write("<script>alert('添加成功')</script>");
                }
                else
                {
                    Response.Write("<script>alert('添加失败')</script>");
                }
            }
            catch (Exception)
            {

                Response.Write("<script>alert('输入有误')</script>");
            }
            


        }

        protected void btnqx_Click(object sender, EventArgs e)
        {
            Response.Redirect("YuanGong.aspx");
        }


    }
}