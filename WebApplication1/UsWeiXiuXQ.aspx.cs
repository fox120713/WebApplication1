using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using System.Data;
using System.IO;
namespace WebApplication1
{
    public partial class UsWeiXiuXQ : System.Web.UI.Page
    {
        Repn_BLL repnbll = new Repn_BLL();
        PrepnBLL prepnbll = new PrepnBLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string id = Request["id"];
                DataTable dt = repnbll.repn_shShow(id);
                this.Label1.Text = dt.Rows[0][1].ToString();
                this.Label2.Text = dt.Rows[0][2].ToString();
                this.Label3.Text = dt.Rows[0][5].ToString();
                this.Label4.Text = dt.Rows[0][4].ToString();
                this.Label5.Text = dt.Rows[0][12].ToString();

            }


        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            //完成维修 
            string id = Request["id"];
            DataTable dt = repnbll.repn_shShow(id);

            string test = dt.Rows[0][8].ToString();
            string test1 = dt.Rows[0][9].ToString();
            if (test == "" || test == null)
            {
                Response.Write("<script>alert('请先确认维修！！！')</script>");

            }
            else if (test1 != "")
            {
                Response.Write("<script>alert('维修已完成！！！')</script>");
            }
            else
            {
                Response.Write("<script>alert('请上传维修图片！！！')</script>");
                this.Panel1.Visible = true;

            }


        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //确认维修
            string date = DateTime.Now.ToString();
            string id = Request["id"];
            repnbll.repn_starta(id, date);
            Response.Write("<script>alert('确认维修完成！！！')</script>");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            if (FileUpload1.HasFile)//判断是否有文件
            {
                string filename = FileUpload1.FileName;
                string kzm = Path.GetExtension(FileUpload1.FileName);//提取文件扩展名
                if (kzm == ".jpg" || kzm == ".png" || kzm == ".jpeg")
                {
                    FileUpload1.SaveAs(Server.MapPath(".") + "\\wximg\\" + filename);
                    this.Image1.ImageUrl = "~/wximg/" + filename;
                    string id = Request["id"];
                    string date = DateTime.Now.ToString();
                    repnbll.repn_end(id, date, filename);

                    Response.Write("<script>alert('上传成功！！！');window.location.href='information.aspx';</script>");

                }
                else
                {
                    Response.Write("<script>alert('您上传的文件不是图片请重新上传！！！')</script>");

                }
            }
            else
            {
                Response.Write("<script>alert('请上传文件！！！')</script>");



            }
        }
    }
}