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
    public partial class LzSP : System.Web.UI.Page
    {
        LzInfo_BLL lzbll = new LzInfo_BLL();
        PosBLL Posbll = new PosBLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //绑定部门下拉列表
                    DataTable table = Posbll.PosAll();
                    DataRow row = table.NewRow();
                    row[0] = 66;
                    row[1] = "全部";
                    table.Rows.InsertAt(row, 0);
                    this.DropDownListPos.DataSource = table;
                    this.DropDownListPos.DataTextField = "PosName";
                    this.DropDownListPos.DataValueField = "PosID";
                    this.DropDownListPos.DataBind();
                //绑定表格数据
                this.GridView1.DataSource = lzbll.LzinfoAll();
                this.GridView1.DataBind();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string name = this.TextBox1.Text;
            string posname = this.DropDownListPos.SelectedItem.Text;
            string zt = this.DropDownList1.SelectedItem.Text;
            this.GridView1.DataSource = lzbll.cx(name, posname, zt);
            this.GridView1.DataBind();
        }

        protected void LinkButton1_Command(object sender, CommandEventArgs e)
        {
            int id =Convert.ToInt32(e.CommandArgument);
            Response.Redirect("LzSPxx.aspx?id="+id);
           

            

        }

      
    }
}