using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using BLL;
using System.IO;
namespace WebApplication1
{
    public partial class report : System.Web.UI.Page
    {
        infoBLL bll = new infoBLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string phone = login.ygphone;
                DataTable dt = bll.myself(phone);
                this.Label2.Text = dt.Rows[0][17].ToString();
                this.Label3.Text = dt.Rows[0][19].ToString();
                this.Label4.Text = dt.Rows[0][18].ToString();
                this.Label1.Text = login.ygname;

            }



        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("dutywatch.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (this.Image1.ImageUrl!=null&&this.Image1.ImageUrl!="")
            {
                int id = int.Parse(Request["zbid"]);
                string imgurl = this.Image1.ImageUrl;
                bll.reportupd(imgurl, id); 
                Response.Write("<script>alert('上传成功！！！')</script>");
                Response.Redirect("dutywatch.aspx");
            }
            else
            {
                Response.Write("<script>alert('请上传图片！')</script>");
            }         
                
            
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            if (FileUpload1.HasFile)//判断是否有文件
            {
                string filename = FileUpload1.FileName;
                string kzm = Path.GetExtension(FileUpload1.FileName);//提取文件扩展名
                if (kzm == ".jpg" || kzm == ".png" || kzm == ".jpeg")
                {
                    FileUpload1.SaveAs(Server.MapPath(".") + "\\gzcgimg\\" + filename);
                    this.Image1.ImageUrl = "~/gzcgimg/" + filename;
                    Response.Write("<script>alert('上传成功！！！')</script>");


                }
                else
                {
                    Response.Write("<script>alert('您上传的文件不是图片请重新上传！')</script>");

                }
            }
            else
            {
                Response.Write("<script>alert('请上传文件！！！')</script>");
            }
            
        }

        

    }
}

