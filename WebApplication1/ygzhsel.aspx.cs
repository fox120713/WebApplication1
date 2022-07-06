using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using BLL;
using System.Data;
namespace WebApplication1
{
    public partial class ygzhsel : System.Web.UI.Page
    {
        StfInfo_BLL s_bll = new StfInfo_BLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                this.GridView6.DataSource = s_bll.sel();
                this.GridView6.DataBind();

                DataTable tables = s_bll.sex();
                DataRow drs = tables.NewRow();
                drs[0] = "全部";
                tables.Rows.InsertAt(drs, 0);
                this.DropDownList2.DataSource = tables;
                this.DropDownList2.DataTextField = "YgSex";
                this.DropDownList2.DataValueField = "YgSex";
                this.DropDownList2.DataBind();
            }
        }
        protected void Button8_Click(object sender, EventArgs e)//查询
        {

            try
            {
                string name = this.TextBox12.Text;
                string sex = this.DropDownList2.SelectedValue.ToString();
                this.GridView6.DataSource = s_bll.selbf(name, sex);
                this.GridView6.DataBind();
            }
            catch (Exception)
            {
                Response.Write("<script>alert('网页运行失败，详情请咨询维护人员')</script>");
            }


        }

        protected void GridView6_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            this.GridView6.PageIndex = e.NewPageIndex;
            this.GridView6.DataSource = s_bll.sel();
            this.GridView6.DataBind();
        }

    }
}